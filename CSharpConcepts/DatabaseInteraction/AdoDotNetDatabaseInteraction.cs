using System;
using System.Data.SqlClient;

namespace CSharpConcepts.DatabaseInteraction
{
    internal class AdoDotNetDatabaseInteraction
    {
        public void ExecuteMe()
        {
            string CS = @"Data Source=DESKTOP-KPM188B\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            SqlConnection connection = new SqlConnection(CS);


            try
            {
                // Open the connection
                connection.Open();

                // Create the SqlCommand object with the query and connection
                SqlCommand cmd = new SqlCommand("SELECT * FROM PLAYERS", connection);

                // Execute the query and retrieve the data
                SqlDataReader reader = cmd.ExecuteReader();

                // Print the data to the console
                while (reader.Read())
                {
                    Console.WriteLine("ID: {0}, Name: {1}, Password: {2}",
                        reader["ID"], reader["NAME"], reader["PSWD"]);
                }

                reader.Close();

                cmd.CommandText = "SELECT COUNT(*) FROM PLAYERS";
                int count = (int)cmd.ExecuteScalar();
                Console.WriteLine(count);

                //cmd.CommandText = "INSERT INTO PLAYERS (NAME, PSWD) VALUES('User A', '123')";
                //int AffectedRows = (int)cmd.ExecuteNonQuery();
                //Console.WriteLine(AffectedRows);

                Console.WriteLine("Enter Character to search Player : ");
                string substring = Console.ReadLine();
                // SQL inject chances while making query with string concatination
                // cmd.CommandText = $"SELECT * FROM PLAYERS WHERE NAME LIKE '%{substring}%'";

                cmd.CommandText = "SELECT * FROM PLAYERS WHERE NAME LIKE @NAME";
                cmd.Parameters.AddWithValue("@NAME", $"%{substring}%");

                SqlDataReader reader1 = cmd.ExecuteReader();
                while (reader1.Read())
                {
                    Console.WriteLine($"ID: {reader1["ID"]}, Name: {reader1["NAME"]}, Password: {reader1["PSWD"]}");
                }
                reader1.Close();

                using (SqlCommand command = new SqlCommand("GETNAMEHAVINGCHARACTER", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    // Add the input parameter to the command
                    command.Parameters.AddWithValue("@char", "y"); // Replace with the desired character

                    // Execute the command
                    SqlDataReader reader2 = command.ExecuteReader();

                    // Process the results
                    while (reader2.Read())
                    {
                        // Access the data from the reader
                        string playerName = reader2["NAME"].ToString(); // Replace "NAME" with the actual column name

                        // Do something with the retrieved player name
                        Console.WriteLine(playerName);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                // Close the connection
                connection.Close();
            }
        }
    }
}
