using MySqlConnector;
using System;
using System.Threading.Tasks;

namespace ChongYuHau_s_resume_MAUI_app.Data
{
    public class ContactFormService
    {
        private readonly string _connectionString;

        public ContactFormService()
        {
       
            var builder = new MySqlConnectionStringBuilder
            {
                Server = "localhost", 
                UserID = "root",         
                Password = "password",       
                Database = "contact_information",
            };

            // Build the connection string
            _connectionString = builder.ConnectionString;
        }

        public async Task SaveContactFormAsync(string name, string email, string comment)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    Console.WriteLine("Database connection is open.");

                    string query = "INSERT INTO contact_form (Name, Email, Comment) VALUES (@Name, @Email, @Comment)";
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Comment", comment);

                        await cmd.ExecuteNonQueryAsync();
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    throw new ApplicationException("An error occurred while saving the contact form.", ex);
                }
                finally
                {
                    await connection.CloseAsync();
                    Console.WriteLine("Database connection is closed.");
                }
            }
        }
    }
}
