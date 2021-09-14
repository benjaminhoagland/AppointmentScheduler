using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AppointmentScheduluer
{
    public static class Data
    {
        public static List<string> tables = new List<string>() { "address", "appointment", "city", "country", "customer", "user" };
        public static MySqlConnection Connect()
        {
            var connectionString = "server=wgudb.ucertify.com;database=U08i7a;port=3306;userid=U08i7a;password=53689299403;useaffectedrows=True;allowuservariables=True;sslmode=None";
            return new MySqlConnection(connectionString);
        }
        public static void Populate()
        {
            // fill sample dataset into database
            var countries = new List<string>()
            {
                "United Kingdom",
                "United States of America",
                "Spain",
                "Mexico"
            };
            foreach (var country in countries)
            {
                InsertCountry(country);
            }

            var cities = new List<(string name,string country)>();
            cities.Add(("London", "United Kingdom"));
            cities.Add(("New York, New York", "United States of America"));
            cities.Add(("Madrid", "Spain"));
            cities.Add(("Mexico City", "Mexico"));
            foreach (var city in cities)
            {
                InsertCity(city.name, city.country);
            }

            var addresses = new List<(string address, string address2, string city, string postalCode, string phone)>();
            addresses.Add
            (
                (
                "10 Downing Street",
                "",
                "London",
                "SW1A 2AA",
                "07911 123456"
                )
            );
            addresses.Add
            (
                (
                "1 Main St",
                "",
                "New York, New York",
                "12345",
                "(111) 222-3344"
                )
            );
            foreach(var (address, address2, city, postalCode, phone) in addresses)
            {
                InsertAddress(address, address2, city, postalCode, phone);
            }

            var customers = new List<(string customerName, string address, bool active)>();
            customers.Add(("John Smith", "10 Downing Street", true));
            customers.Add(("Jane Smith", "10 Downing Street", true));
            customers.Add(("Pablo Diaz", "1 Main St", true));
            customers.Add(("Claudia Diaz", "1 Main St", true));
            foreach (var (customerName, address, active) in customers)
            {
                InsertCustomer(customerName, address, active);
            }
        }
        public static List<string> Select(string table, int attribute = 0, string where = null)
        {
            var contents = new List<string>();
            try
            {
                var connection = Data.Connect();
                connection.Open();
                if (where == null)
                {
                    string query = "SELECT * FROM " + table + ";";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        contents.Add(reader[attribute].ToString());
                    }
                    reader.Close();
                    connection.Close();
                    return contents;
                }
                else
                {
                    // string query = "SELECT * FROM " + table + " WHERE country = 'Spain';";
                    string query = "SELECT * FROM " + table + " WHERE " + where + ";";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        contents.Add(reader[attribute].ToString());
                    }
                    reader.Close();
                    connection.Close();
                    return contents;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            contents.Add("Query returns 0 records");
            return contents;
        }
        public static void InsertCustomer(string customerName, string address, bool active, string createdBy = "Initialization", string lastupdateby = "Initialization")
        {
            /*
            customerName VARCHAR(45)
            addressId INT(10)
            active TINYINT(1)
            createDate DATETIME
            createdBy VARCHAR(40)
            lastUpdate TIMESTAMP
            lastUpdateBy VARCHAR(40)
            */
            try
            {
                var database = Data.Connect();
                database.Open();

                // get id
                var addressId = Select("address", 0, "address = \'" + address + "\'");

                // insert 
                var command = database.CreateCommand();
                command.CommandText = "INSERT INTO customer(customerName, addressId, active, createdate, createdBy, lastupdateby)"
                    + " VALUES(?customerName, ?addressId, ?active, ?createdate, ?createdBy, ?lastupdateby)";
                command.Parameters.Add("?customerName", MySqlDbType.VarChar).Value = customerName;
                command.Parameters.Add("?addressId", MySqlDbType.Int32).Value = addressId.FirstOrDefault(); // very problematic but will work for the test data
                command.Parameters.Add("?active", MySqlDbType.Byte).Value = active;
                command.Parameters.Add("?createdate", MySqlDbType.VarChar).Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                command.Parameters.Add("?createdBy", MySqlDbType.VarChar).Value = createdBy;
                command.Parameters.Add("?lastupdateby", MySqlDbType.VarChar).Value = lastupdateby;
                command.ExecuteNonQuery();


                // close database
                database.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public static void InsertAddress(string address, string address2, string city, string postalCode, string phone, string createdBy = "Initialization", string lastupdateby = "Initialization")
        {
            /*
            address VARCHAR(50)
            address2 VARCHAR(50)
            cityId INT(10)
            postalCode VARCHAR(10)
            phone VARCHAR(20)
            createDate DATETIME
            createdBy VARCHAR(40)
            lastUpdate TIMESTAMP
            lastUpdateBy VARCHAR(40)
            */
            try
            {
                var database = Data.Connect();
                database.Open();

                // get id
                var cityId = Select("city", 0, "city = \'" + city + "\'");

                // insert 
                var command = database.CreateCommand();
                command.CommandText = "INSERT INTO address(address, address2, cityId, postalCode, phone, createdate, createdBy, lastupdateby)"
                    + " VALUES(?address, ?address2, ?cityId, ?postalCode, ?phone, ?createdate, ?createdBy, ?lastupdateby)";
                command.Parameters.Add("?address", MySqlDbType.VarChar).Value = address;
                command.Parameters.Add("?address2", MySqlDbType.VarChar).Value = address2;
                command.Parameters.Add("?cityId", MySqlDbType.Int32).Value = cityId.FirstOrDefault(); // very problematic but will work for the test data
                command.Parameters.Add("?postalCode", MySqlDbType.VarChar).Value = postalCode;
                command.Parameters.Add("?phone", MySqlDbType.VarChar).Value = phone; 
                command.Parameters.Add("?createdate", MySqlDbType.VarChar).Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                command.Parameters.Add("?createdBy", MySqlDbType.VarChar).Value = createdBy;
                command.Parameters.Add("?lastupdateby", MySqlDbType.VarChar).Value = lastupdateby;
                command.ExecuteNonQuery();


                // close database
                database.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public static void InsertCity(string city, string country, string createdBy = "Initialization", string lastupdateby = "Initialization")
        {
            try
            {
                var database = Data.Connect();
                database.Open();

                // get id
                var countryID = Select("country", 0, "country = \'" + country + "\'");

                // insert
                var command = database.CreateCommand();
                command.CommandText = "INSERT INTO city(city, countryId, createdate, createdBy, lastupdateby)"
                    + " VALUES(?city, ?countryId, ?createdate, ?createdBy, ?lastupdateby)";
                command.Parameters.Add("?city", MySqlDbType.VarChar).Value = city;
                command.Parameters.Add("?countryId", MySqlDbType.Int32).Value = countryID.FirstOrDefault(); // very problematic but will work for the test data
                command.Parameters.Add("?createdate", MySqlDbType.VarChar).Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                command.Parameters.Add("?createdBy", MySqlDbType.VarChar).Value = createdBy;
                command.Parameters.Add("?lastupdateby", MySqlDbType.VarChar).Value = lastupdateby;
                command.ExecuteNonQuery();


                // close database
                database.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public static void InsertCountry(string country, string createdBy = "Initialization", string lastupdateby = "Initialization")
        {
            try
            {
                var database = Data.Connect();
                database.Open();

                var command = database.CreateCommand();
                command.CommandText = "INSERT INTO country(country, createdate, createdBy, lastupdateby)"
                    + " VALUES(?country, ?createdate, ?createdBy, ?lastupdateby)";
                command.Parameters.Add("?country", MySqlDbType.VarChar).Value = country;
                command.Parameters.Add("?createdate", MySqlDbType.VarChar).Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                command.Parameters.Add("?createdBy", MySqlDbType.VarChar).Value = createdBy;
                command.Parameters.Add("?lastupdateby", MySqlDbType.VarChar).Value = lastupdateby;
                command.ExecuteNonQuery();


                // close database
                database.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private static void DeleteAllTableRecords(string Table)
        {
            try
            {
                var database = Data.Connect();
                database.Open();
                var command = database.CreateCommand();
                command.CommandText = "DELETE FROM " + Table;
                command.ExecuteNonQuery();
                database.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public static void Clear()
        {
            foreach (var table in tables)
            {
                DeleteAllTableRecords(table);
            }
        }
    }
}
