using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentScheduluer
{
    public static class Appointment
    {
        public static void Delete()
        {
            if (Selected.AppointmentId > 0)
            {
                try
                {
                    var database = Data.Connect();
                    database.Open();
                    var command = database.CreateCommand();
                    command.CommandText = "DELETE FROM appointment WHERE appointmentId = \'" + Selected.AppointmentId + "\';";
                    command.ExecuteNonQuery();
                    database.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
        public static class Selected
        {
            
            private static int _AppointmentId = -1;
            private static int _CustomerId = -1;
            private static int _UserId = 1;
            private static string _Title = "No appointment selected yet";
            private static string _Description = "";
            private static string _Location = "";
            private static string _Contact = "";
            private static string _Type = "";
            private static string _Url = "";
            private static DateTime _Date = DateTime.Now;
            private static DateTime _Start = DateTime.Now;
            private static DateTime _End = DateTime.Now;
            private static bool _New = true;

            public static bool New { get { return _New; } set { _New = value; } }
            public static int AppointmentId
            {
                get { return _AppointmentId; }
                set
                {
                    if (value < 0) { return; }
                    _AppointmentId = value;
                    
                    Int32.TryParse(Data.Select("appointment", 1, "appointmentID = \'" + _AppointmentId + "\';").FirstOrDefault(), out _CustomerId);
                    _Title = Data.Select("appointment", 3, "appointmentID = \'" + _AppointmentId + "\';").FirstOrDefault();
                    
                    _Description = Data.Select("appointment", 4, "appointmentID = \'" + _AppointmentId + "\';").FirstOrDefault();
                    _Location = Data.Select("appointment", 5, "appointmentID = \'" + _AppointmentId + "\';").FirstOrDefault();
                    _Contact = Data.Select("appointment", 6, "appointmentID = \'" + _AppointmentId + "\';").FirstOrDefault();
                    _Type = Data.Select("appointment", 7, "appointmentID = \'" + _AppointmentId + "\';").FirstOrDefault();
                    _Url = Data.Select("appointment", 8, "appointmentID = \'" + _AppointmentId + "\';").FirstOrDefault();

                    var date = Data.Select("appointment", 9, "appointmentID = \'" + _AppointmentId + "\';").FirstOrDefault();
                    var start = Data.Select("appointment", 9, "appointmentID = \'" + _AppointmentId + "\';").FirstOrDefault();
                    var end = Data.Select("appointment", 10, "appointmentID = \'" + _AppointmentId + "\';").FirstOrDefault();
                    if (date == null || start == null || end == null)
                    {
                        // MessageBox.Show("end or start or date is null");
                    }
                    else
                    {

                    _Date = DateTime.Parse(date);

                    _Start = DateTime.Parse(start);

                    _End = DateTime.Parse(end);
                    }

                    /*
                    MessageBox.Show("date is " + date);
                    MessageBox.Show("_Date is " + _Date);
                    MessageBox.Show("start is " + start);
                    MessageBox.Show("_Start is " + _Start);
                    MessageBox.Show("end is " + end);
                    MessageBox.Show("_End is " + _End);
                    */

                    New = false;
                }
            }
            public static int CustomerId { get { return _CustomerId; } }
            public static int UserId { get { return _UserId; } }
            public static string Title { get { return _Title; } }
            public static string Description { get { return _Description; } }
            public static string Location { get { return _Location; } }
            public static string Contact { get { return _Contact; } }
            public static string Type { get { return _Type; } }
            public static string Url { get { return _Url; } }
            public static DateTime Date { get { return _Date; } }
            public static DateTime Start { get { return _Start; } }
            public static DateTime End { get { return _End; } }
        }

    }
}
