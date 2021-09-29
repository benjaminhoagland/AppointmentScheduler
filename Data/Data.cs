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
        public static List<string> tables = new List<string>() 
        { 
            "appointment",
            "customer", 
            "address", 
            "city", 
            "country", 
            "user"
        };
        public static MySqlConnection Connect()
        {
            var connectionString = "server=127.0.0.1;database=client_schedule;port=3306;userid=sqlUser;password=Passw0rd!;";
            return new MySqlConnection(connectionString);
        }
        public static void Populate()
        {
            // fill sample dataset into database
            var users = new List<(string userName, string password)>();
            users.Add(("test", "test"));
            users.Add(("Consultant 1", "test1"));
            users.Add(("Consultant 2", "test2"));
            foreach (var (userName, password) in users)
            {
                InsertUser(userName, password);
            }

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

            var appointments = new List<(
                int customerId,
                string title,
                string description,
                string location,
                string contact,
                string type,
                string url,
                DateTime start,
                DateTime end,
                int userId)>();

            appointments.Add
                (
                    (
                        4,
                        "Appointment 1",
                        "This is the first appointment",
                        "New York, NY",
                        "Contact Information",
                        "Initial Appointment",
                        "someaddress.domain.com",
                        DateTime.Now.StartOfWeek(DayOfWeek.Monday).AddDays(0).AddHours(11),
                        DateTime.Now.StartOfWeek(DayOfWeek.Monday).AddDays(0).AddHours(12),
                        2
                     )
                );
            appointments.Add
                (
                    (
                        1,
                        "Appointment 2",
                        "This is the second appointment",
                        "London, UK",
                        "Contact Information",
                        "Initial Appointment",
                        "someaddress.domain.com",
                        DateTime.Now.StartOfWeek(DayOfWeek.Monday).AddDays(0).AddHours(9),
                        DateTime.Now.StartOfWeek(DayOfWeek.Monday).AddDays(0).AddHours(10),
                        2
                     )
                );
            appointments.Add
                (
                    (
                        2,
                        "Appointment 3",
                        "This is the third appointment",
                        "London, UK",
                        "Contact Information",
                        "Follow-Up Appointment",
                        "someaddress.domain.com",
                        DateTime.Now.StartOfWeek(DayOfWeek.Monday).AddDays(1).AddHours(8),
                        DateTime.Now.StartOfWeek(DayOfWeek.Monday).AddDays(1).AddHours(9),
                        3
                     )
                );
            appointments.Add
                (
                    (
                        3,
                        "Appointment 4",
                        "This is the fourth appointment",
                        "New York, NY",
                        "Contact Information",
                        "Follow-Up Appointment",
                        "someaddress.domain.com",
                        DateTime.Now.StartOfWeek(DayOfWeek.Monday).AddDays(1).AddHours(9),
                        DateTime.Now.StartOfWeek(DayOfWeek.Monday).AddDays(1).AddHours(10),
                        3
                     )
                );

            foreach (var (customerId, title, description, location, contact, type, url, start, end, userId) in appointments)
            {
                InsertAppointment(customerId, title, description, location, contact, type, url, start, end, userId);
            }
        }
        public static List<(DateTime start, DateTime end, string location)> GetAppointments(DateTime date)
        {
            var list = new List<(DateTime start, DateTime end, string location)>();
            var query = "SELECT * FROM appointment"; // WHERE start >= '" + date.ToString("yyyy-MM-dd") + "'"
                // + "AND end <= '" + date.AddDays(1).ToString("yyyy-MM-dd") + "';";
            // MessageBox.Show("query is " + query);
            // var result = SQL(query);
            // list.Add(result.start, result.end);
            try
            {
                var connection = Data.Connect();
                connection.Open();

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // MessageBox.Show("reader[9].ToString() is " + reader[9].ToString());
                    // MessageBox.Show("reader[10].ToString() is " + reader[10].ToString());
                    list.Add((DateTime.Parse(reader[9].ToString()), DateTime.Parse(reader[10].ToString()), reader[5].ToString()));
                }
                reader.Close();
                connection.Close();
                return list;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return list;
        }
        public static List<string> Select(string table, int attribute = 0, string where = null)
        {
            var contents = new List<string>();
            string query;
            if (where == null)
            {
                query = "SELECT * FROM " + table + ";";
            }
            else
            {
                // string query = "SELECT * FROM " + table + " WHERE country = 'Spain';";
                query = "SELECT * FROM " + table + " WHERE " + where + ";";
            }
            try
            {
                var connection = Data.Connect();
                connection.Open();
                
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            if(contents.Count == 0)
            {
                contents.Add("No matching record");
                MessageBox.Show("No matching record found for query \"" + query + "\"");
            }
            return contents;
        }
        public static void UpdateAppointment(int appointmentId, int customerId, string description, string type)
        {
            try
            {
                var database = Data.Connect();
                database.Open();

                var command = database.CreateCommand();
                command.CommandText = "UPDATE appointment SET customerId = ?customerId, description = ?description, type = ?type WHERE appointmentId = ?appointmentId;";
                command.Parameters.AddWithValue("?customerId", customerId);
                command.Parameters.AddWithValue("?description", description);
                command.Parameters.AddWithValue("?type", type);
                command.Parameters.AddWithValue("?appointmentId", appointmentId);
                command.ExecuteNonQuery();


                // close database
                database.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public static void InsertAppointment(
            int customerId,
            string title,
            string description,
            string location,
            string contact,
            string type,
            string url,
            DateTime start,
            DateTime end,
            int userId = 1,
            string createdBy = "Initialization", string lastupdateby = "Initialization")
        {
            /*
            appointmentId INT(10)
            customerId INT(10)
            userId INT
            title VARCHAR(255)
            description TEXT
            location TEXT
            contact TEXT
            type TEXT
            url VARCHAR(255)
            start DATETIME
            end DATETIME
            createDate DATETIME
            createdBy VARCHAR(40)
            lastUpdate TIMESTAMP
            lastUpdateBy VARCHAR(40)

            */

            try
            {
                var database = Data.Connect();
                database.Open();
                var command = database.CreateCommand();
                command.CommandText = "INSERT INTO appointment(customerId, userId, title, description, location, contact, type, url, start, end, createdate, createdBy, lastupdateby)"
                    + " VALUES(?customerId, ?userId, ?title, ?description, ?location, ?contact, ?type, ?url, ?start, ?end, ?createdate, ?createdBy, ?lastupdateby)";
                command.Parameters.Add("?customerId", MySqlDbType.Int32).Value = customerId;
                command.Parameters.Add("?userId", MySqlDbType.Int32).Value = userId;
                command.Parameters.Add("?title", MySqlDbType.VarChar).Value = title;
                command.Parameters.Add("?description", MySqlDbType.Text).Value = description;
                command.Parameters.Add("?location", MySqlDbType.Text).Value = location;
                command.Parameters.Add("?contact", MySqlDbType.Text).Value = contact;
                command.Parameters.Add("?type", MySqlDbType.Text).Value = type;
                command.Parameters.Add("?url", MySqlDbType.VarChar).Value = url;
                command.Parameters.Add("?start", MySqlDbType.VarChar).Value = start.ToString("yyyy-MM-dd HH:mm:ss");
                command.Parameters.Add("?end", MySqlDbType.VarChar).Value = end.ToString("yyyy-MM-dd HH:mm:ss");
                command.Parameters.Add("?createdate", MySqlDbType.VarChar).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                command.Parameters.Add("?createdBy", MySqlDbType.VarChar).Value = createdBy;
                command.Parameters.Add("?lastupdateby", MySqlDbType.VarChar).Value = lastupdateby;
                /*
                MessageBox.Show("command.CommandText is " + command.CommandText);
                
                MessageBox.Show(String.Format("parameters are customerId = {0},@ userId = {1},@ title = {2},@ description = {3},@ location = {4},@ contact = {5},@ type = {6},@ url = {7},@ start.ToString(\"yyyy - MM - dd hh: mm:ss\") = {8},@ end.ToString(\"yyyy - MM - dd hh: mm:ss\")= {9}  ", 
                    customerId, userId,
                    title, description,
                    location, contact,
                    type, url,
                    start.ToString("yyyy-MM-dd hh:mm:ss"), end.ToString("yyyy-MM-dd hh:mm:ss")).Replace("@", System.Environment.NewLine));
                */
                command.ExecuteNonQuery();


                // close database
                database.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public static void InsertUser(string userName, string password, bool active = true, string createdBy = "Initialization", string lastupdateby = "Initialization")
        {
            /*
            userId INT
            userName VARCHAR(50)
            password VARCHAR(50)
            active TINYINT
            createDate DATETIME
            createdBy VARCHAR(40)
            lastUpdate TIMESTAMP
            lastUpdateBy VARCHAR(40)
            */
            try
            {
                var database = Data.Connect();
                database.Open();

                var command = database.CreateCommand();
                command.CommandText = "INSERT INTO user(userName, password, active, createdate, createdBy, lastupdateby)"
                    + " VALUES(?userName, ?password, ?active, ?createdate, ?createdBy, ?lastupdateby)";
                command.Parameters.Add("?userName", MySqlDbType.VarChar).Value = userName;
                command.Parameters.Add("?password", MySqlDbType.VarChar).Value = password;
                command.Parameters.Add("?active", MySqlDbType.Byte).Value = active;
                command.Parameters.Add("?createdate", MySqlDbType.VarChar).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
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
        public static void UpdateCustomer(int customerId, string newName, bool newStatus)
        {
            try
            {
                var database = Data.Connect();
                database.Open();
                
                var command = database.CreateCommand();
                command.CommandText = "UPDATE customer SET customerName = ?customerName, active = ?active  WHERE customerId = ?customerId;";
                command.Parameters.AddWithValue("?customerName", newName);
                command.Parameters.AddWithValue("?active", newStatus);
                command.Parameters.AddWithValue("?customerId", customerId);
                command.ExecuteNonQuery();


                // close database
                database.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
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
                var addressId = Select("address", 0, "address = \'" + address + "\'").FirstOrDefault();
                // MessageBox.Show("addressId is " + addressId);
                // insert 
                var command = database.CreateCommand();
                command.CommandText = "INSERT INTO customer(customerName, addressId, active, createdate, createdBy, lastupdateby)"
                    + " VALUES(?customerName, ?addressId, ?active, ?createdate, ?createdBy, ?lastupdateby)";
                command.Parameters.Add("?customerName", MySqlDbType.VarChar).Value = customerName;
                command.Parameters.Add("?addressId", MySqlDbType.Int32).Value = addressId; // very problematic but will work for the test data
                command.Parameters.Add("?active", MySqlDbType.Byte).Value = active;
                command.Parameters.Add("?createdate", MySqlDbType.VarChar).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                command.Parameters.Add("?createdBy", MySqlDbType.VarChar).Value = createdBy;
                command.Parameters.Add("?lastupdateby", MySqlDbType.VarChar).Value = lastupdateby;
                command.ExecuteNonQuery();


                // close database
                database.Close();
                Customer.Count++;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public static void UpdateAddress(int addressId, string newAddress, string newAddress2, string newPostalCode, string newPhone)
        {
            try
            {
                var database = Data.Connect();
                database.Open();

                var command = database.CreateCommand();
                command.CommandText = "UPDATE address SET address = ?address, address2 = ?address2, postalCode = ?postalCode, phone = ?phone WHERE addressId = ?addressId;";
                command.Parameters.AddWithValue("?addressId", addressId);
                command.Parameters.AddWithValue("?address", newAddress);
                command.Parameters.AddWithValue("?address2", newAddress2);
                command.Parameters.AddWithValue("?postalCode", newPostalCode);
                command.Parameters.AddWithValue("?phone", newPhone);
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
                command.Parameters.Add("?createdate", MySqlDbType.VarChar).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
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
        public static void UpdateCity(int cityId, string city)
        {
            try
            {
                var database = Data.Connect();
                database.Open();
                // MessageBox.Show("updating city with ID: " + cityId);
                var command = database.CreateCommand();
                command.CommandText = "UPDATE city SET city = ?city WHERE cityId = ?cityId;";
                command.Parameters.AddWithValue("?cityId", cityId);
                command.Parameters.AddWithValue("?city", city);
                // MessageBox.Show("command.CommandText is " + command.CommandText);
                // MessageBox.Show("newName is " + city);
                // MessageBox.Show("cityId is " + cityId);
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
                command.Parameters.Add("?createdate", MySqlDbType.VarChar).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
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
        public static void UpdateCountry(int countryId, string country)
        {
            try
            {
                var database = Data.Connect();
                database.Open();

                var command = database.CreateCommand();
                command.CommandText = "UPDATE country SET country = ?country WHERE countryId = ?countryId;";
                command.Parameters.AddWithValue("?country", country);
                command.Parameters.AddWithValue("?countryId", countryId);
                // MessageBox.Show("command.CommandText is " + command.CommandText);
                // MessageBox.Show("country is " + country);
                // MessageBox.Show("countryId is " + countryId);
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
                command.Parameters.Add("?createdate", MySqlDbType.VarChar).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                command.Parameters.Add("?createdBy", MySqlDbType.VarChar).Value = createdBy;
                command.Parameters.Add("?lastupdateby", MySqlDbType.VarChar).Value = lastupdateby;
                command.ExecuteNonQuery();
                // MessageBox.Show("created country with a name of " + country);
                var auditedId = Data.Select("country", 0, "country = \'" + country + "\';").FirstOrDefault();
                // MessageBox.Show("auditedId is " + auditedId);
                // close database
                database.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private static void ResetAutoIncrementValues(string Table)
        {
            
            try
            {
                var database = Data.Connect();
                database.Open();
                var command = database.CreateCommand();
                command.CommandText = String.Format("ALTER TABLE {0} AUTO_INCREMENT = 1", Table);
                command.ExecuteNonQuery();
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
                ResetAutoIncrementValues(table);
            }
            Customer.Count = 0;
        }
    }
}
