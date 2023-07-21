using System.Data.SqlClient;
using Dapper;
using ReadWriteOperation;

namespace AuthenticationSystem
{
    class Player
    {
        public int id;
        public string? name;
        public string? pswd;

        public override string ToString()
        {
            return $"Id : {this.id}, Name : {this.name}, Pswd : {this.pswd}";
        }
    }
    class Authenticate
    {
        public string? Username;
        public string? Pswd;

        public string CS = @"Data Source=DESKTOP-KPM188B\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False";

        public Authenticate(string username, string pswd)
        {
            this.Username = username;
            this.Pswd = pswd;
        }

        public bool isAuthenticated()
        {
            try
            {
                using (var connection = new SqlConnection(CS))
                {
                    bool userExists = connection.ExecuteScalar<bool>($"SELECT CASE WHEN EXISTS(SELECT 1 FROM PLAYERS WHERE name = '{this.Username}' AND pswd = '{this.Pswd}') THEN 1 ELSE 0 END");
                    Console.Write(userExists);
                    if (userExists)
                    {
                        Log.logEvent("Authentication System", logLevel.DEBUG, $"Signing in Username : {this.Username}");

                    }
                    else
                    {
                        Log.logEvent("Authentication System", logLevel.DEBUG, $"Wrong Attempt By  Username : {this.Username}");

                    }
                    return userExists;
                }
            }
            catch (Exception ex)
            {
                Log.logEvent("Authentication System", logLevel.DEBUG, $"{ex}");
                return false;
            }
        }
    }
}