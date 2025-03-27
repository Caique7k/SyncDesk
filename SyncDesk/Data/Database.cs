using Npgsql;
using System;
using System.Data;

namespace SyncDesk.Data
{
    public class Database
    {
        private static string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=1234;Database=syncdesk";

        public static NpgsqlConnection GetConnection()
        {
            try
            {
                var conn = new NpgsqlConnection(connectionString);
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao conectar ao banco: {ex.Message}");
                return null;
            }
        }
    }
}
