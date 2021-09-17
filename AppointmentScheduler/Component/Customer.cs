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
        public static int count = 0;

        public static class Selected
        {
            private static int _ID = -1;
            private static string _Name = "No customer selected";
            private static string _Address = "";
            private static string _Address2 = "";
            private static string _City = "";
            private static string _PostalCode = "";
            private static string _Country = "";
            private static string _Phone = "";
            private static bool _Active = false;


            public static int ID 
            {
                get { return _ID; }
                set
                {
                    _ID = value;
                    _Name = Data.Select("customer", 1, "customerId = \'" + _ID + "\';").FirstOrDefault();
                    var addressId = Data.Select("customer", 2, "customerId = \'" + _ID + "\';").FirstOrDefault();
                    _Address = Data.Select("address", 1, "addressId = \'" + addressId + "\';").FirstOrDefault();
                    _Address2 = Data.Select("address", 2, "addressId = \'" + addressId + "\';").FirstOrDefault();
                    var cityId = Data.Select("address", 3, "addressId = \'" + addressId + "\';").FirstOrDefault();
                    _City = Data.Select("city", 1, "cityId = \'" + cityId + "\';").FirstOrDefault();
                    var countryId = Data.Select("city", 2, "cityId = \'" + cityId + "\';").FirstOrDefault();
                    _Country = Data.Select("country", 1, "countryId = \'" + countryId + "\';").FirstOrDefault();
                    _PostalCode = Data.Select("address", 4, "addressId = \'" + addressId + "\';").FirstOrDefault();
                    _Phone = Data.Select("address", 5, "addressId = \'" + addressId + "\';").FirstOrDefault();
                    Boolean.TryParse(Data.Select("customer", 3, "customerId = \'" + _ID + "\';").FirstOrDefault(), out _Active);
                } 
            }
            public static string Name { get { return _Name; } }
            public static string Address { get { return _Address; } }
            public static string Address2 { get { return _Address2; } }
            public static string City { get { return _City; } }
            public static string PostalCode { get { return _PostalCode; } }
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
        }
    }
}
