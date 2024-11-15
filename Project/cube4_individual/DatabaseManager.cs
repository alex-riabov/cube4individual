using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;

namespace CompanyDirectoryApp
{
    public class DatabaseManager
    {
        private string connectionString = "Server=localhost;Database=cube4_individual;User Id=root;Password=root;";

        public DataTable GetEmployees()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT e.id, e.first_name, e.last_name, e.fixed_phone, e.mobile_phone, e.email, 
                           s.service_name, l.city AS location
                    FROM Employees e
                    JOIN Services s ON e.service_id = s.id
                    JOIN Locations l ON e.location_id = l.id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public List<string> GetLocations()
        {
            List<string> locations = new List<string>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT city FROM Locations";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    locations.Add(reader["city"].ToString());
                }
            }
            return locations;
        }

        public List<string> GetServices()
        {
            List<string> services = new List<string>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT service_name FROM Services";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    services.Add(reader["service_name"].ToString());
                }
            }
            return services;
        }
    }
}
