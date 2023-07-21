using System;
using System.Data.SqlClient;
using Dapper;

namespace CSharpConcepts.Concepts
{
    class Player
    {
        public int id;
        public string name;
        public string pswd;

        public override string ToString()
        {
            return $"Id : {this.id}, Name : {this.name}, Pswd : {this.pswd}";
        }
    }
    internal class DapperDatabaseInteraction
    {
        public void Execute()
        {
            string CS = @"Data Source=DESKTOP-KPM188B\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False";
            try
            {
                using (var connection = new SqlConnection(CS))
                {
                    var players = connection.Query<Player>("SELECT name FROM PLAYERS").ToList();

                    foreach (var player in players)
                    {
                        Console.WriteLine(player);
                    }
                    var count = connection.ExecuteScalar("SELECT count(*) FROM PLAYERS");
                    Console.WriteLine($"Total Records : {count}");

                    var onlyone = connection.QuerySingle("SELECT * FROM PLAYERS where id = 1");
                    var onlyoneTypePlayer = connection.QuerySingle<Player>("SELECT * FROM PLAYERS where id = 1");
                    Console.WriteLine(onlyone);
                    Console.WriteLine(onlyoneTypePlayer);

                    //Multiple result
                    string sql = @"SELECT * FROM PLAYERS;
                                    SELECT * FROM GAMES;
                                    ";
                    using (var mutliOut = connection.QueryMultiple(sql))
                    {
                        Console.WriteLine("Query Multiple Rows");
                        Console.WriteLine(mutliOut.ReadFirst());
                        Console.WriteLine(mutliOut.Read());
                    };

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
