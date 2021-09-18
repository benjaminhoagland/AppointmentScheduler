using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AppointmentScheduluer
{
    public static class Customer
    {
        private static int count = 0;
        public static int Count
        {
            get { return count; }
            set 
            { 
                count = value; 
                // MessageBox.Show("setting count to " + value); 
            }
        }

        public static class Selected
        {
            private static int _CustomerId = -1;
            private static string _Name = "No customer selected";
            private static int _AddressId = -1;
            private static string _Address = "";
            private static string _Address2 = "";
            private static int _CityId = -1;
            private static string _City = "";
            private static string _PostalCode = "";
            private static int _CountryId = -1;
            private static string _Country = "";
            private static string _Phone = "";
            private static bool _Active = true;


            public static int CustomerId 
            {
                get { return _CustomerId; }
                set
                {
                    if(value < 0) { return; }
                    _CustomerId = value;
                    // MessageBox.Show("setting selected customer id to: " + value);
                    _Name = Data.Select("customer", 1, "customerId = \'" + _CustomerId + "\';").FirstOrDefault();
                    var addressId = Data.Select("customer", 2, "customerId = \'" + _CustomerId + "\';").FirstOrDefault();
                    Int32.TryParse(addressId, out _AddressId);
                    if (_AddressId < 0) { return; }
                    _Address = Data.Select("address", 1, "addressId = \'" + _AddressId + "\';").FirstOrDefault();
                    _Address2 = Data.Select("address", 2, "addressId = \'" + _AddressId + "\';").FirstOrDefault();
                    var cityId = Data.Select("address", 3, "addressId = \'" + _AddressId + "\';").FirstOrDefault();
                    Int32.TryParse(cityId, out _CityId);
                    _City = Data.Select("city", 1, "cityId = \'" + _CityId + "\';").FirstOrDefault();
                    var countryId = Data.Select("city", 2, "cityId = \'" + _CityId + "\';").FirstOrDefault();
                    Int32.TryParse(countryId, out _CountryId);
                    
                    _Country = Data.Select("country", 1, "countryId = \'" + _CountryId + "\';").FirstOrDefault();
                    _PostalCode = Data.Select("address", 4, "addressId = \'" + _AddressId + "\';").FirstOrDefault();
                    _Phone = Data.Select("address", 5, "addressId = \'" + _AddressId + "\';").FirstOrDefault();
                    Boolean.TryParse(Data.Select("customer", 3, "customerId = \'" + _CustomerId + "\';").FirstOrDefault(), out _Active);
                } 
            }
            public static string Name { get { return _Name; } }
            public static int AddressId { get { return _AddressId; } }
            public static string Address { get { return _Address; } }
            public static string Address2 { get { return _Address2; } }
            public static int CityId { get { return _CityId; } }
            public static string City { get { return _City; } }
            public static string PostalCode { get { return _PostalCode; } }
            public static int CountryId { get { return _CountryId; } }
            public static string Country { get { return _Country; } }
            public static string Phone { get { return _Phone; } }
            public static bool Active { get { return _Active; } }
        }
        public static void Add()
        {
            Data.InsertCountry("Set country " + count);
            Data.InsertCity("Set city " + count, "Set country " + count);
            Data.InsertAddress("Set address " + count, " " + count, "Set city " + count, "Set code " + count, "Set phone " + count);
            Data.InsertCustomer("New Customer  " + count, "Set address " + count, true);

            /*
            Name
            Address
            Address2
            City
            PostalCode
            Country 
            Phone
            Active
            */
        }
        public static void Delete()
        {
            /*
            Name
            Address
            Address2
            City
            PostalCode
            Country 
            Phone
            Active
            */
            if(Customer.Selected.CustomerId > 0)
            {
                try
                {
                    var database = Data.Connect();
                    database.Open();
                    var command = database.CreateCommand();
                    command.CommandText = "DELETE FROM customer WHERE customerId = \'" + Selected.CustomerId + "\';";
                    command.ExecuteNonQuery();
                    database.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}
