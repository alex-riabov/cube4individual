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

        public DataTable GetServicesTable()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id, service_name FROM Services";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public DataTable GetLocationsTable()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id, city FROM Locations";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public List<Location> GetLocations()
        {
            List<Location> locations = new List<Location>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id, city FROM Locations";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    locations.Add(new Location
                    {
                        Id = reader.GetInt32("id"),
                        City = reader.GetString("city")
                    });
                }
            }
            return locations;
        }

        public List<Service> GetServices()
        {
            List<Service> services = new List<Service>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id, service_name FROM Services";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    services.Add(new Service
                    {
                        Id = reader.GetInt32("id"),
                        ServiceName = reader.GetString("service_name")
                    });
                }
            }
            return services;
        }

        public bool AddEmployee(string firstName, string lastName, string fixedPhone, string mobilePhone, string email, int serviceId, int locationId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    INSERT INTO Employees (first_name, last_name, fixed_phone, mobile_phone, email, service_id, location_id) 
                    VALUES (@firstName, @lastName, @fixedPhone, @mobilePhone, @Email, @serviceId, @locationId)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@firstName", firstName);
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("@fixedPhone", fixedPhone);
                cmd.Parameters.AddWithValue("@mobilePhone", mobilePhone);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@serviceId", serviceId);
                cmd.Parameters.AddWithValue("@locationId", locationId);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool AddService(string serviceName)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Services (service_name) VALUES (@serviceName)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@serviceName", serviceName);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool AddLocation(string city)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Locations (city) VALUES (@city)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@city", city);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateEmployee(int id, string firstName, string lastName, string fixedPhone, string mobilePhone, string email, int serviceId, int locationId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    UPDATE Employees 
                    SET first_name = @firstName, last_name = @lastName, fixed_phone = @fixedPhone, mobile_phone = @mobilePhone, email = @Email, 
                        service_id = @serviceId, location_id = @locationId 
                    WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@firstName", firstName);
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("@fixedPhone", fixedPhone);
                cmd.Parameters.AddWithValue("@mobilePhone", mobilePhone);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@serviceId", serviceId);
                cmd.Parameters.AddWithValue("@locationId", locationId);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteEmployee(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Employees WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateLocation(int id, string city)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Locations SET city = @city WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@city", city);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteLocation(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Locations WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateService(int id, string serviceName)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Services SET service_name = @serviceName WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@serviceName", serviceName);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteService(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Services WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public Employee GetEmployeeById(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT e.id, e.first_name, e.last_name, e.fixed_phone, e.mobile_phone, e.email, 
                           e.service_id, e.location_id
                    FROM Employees e
                    WHERE e.id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Employee
                        {
                            Id = reader.GetInt32("id"),
                            FirstName = reader.GetString("first_name"),
                            LastName = reader.GetString("last_name"),
                            FixedPhone = reader.GetString("fixed_phone"),
                            MobilePhone = reader.GetString("mobile_phone"),
                            Email = reader.GetString("email"),
                            ServiceId = reader.GetInt32("service_id"),
                            LocationId = reader.GetInt32("location_id")
                        };
                    }
                }
            }
            return null;
        }

        public Service GetServiceById(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id, service_name FROM Services WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Service
                        {
                            Id = reader.GetInt32("id"),
                            ServiceName = reader.GetString("service_name")
                        };
                    }
                }
            }
            return null;
        }

        public Location GetLocationById(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id, city FROM Locations WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Location
                        {
                            Id = reader.GetInt32("id"),
                            City = reader.GetString("city")
                        };
                    }
                }
            }
            return null;
        }


    }
}
