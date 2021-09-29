using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace AppointmentScheduluer
{
    public class Reports
    {
        private static List<string> MonthNames = new List<string>()
        {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"
        };
        public static string AppoinmentTypesByMonth()
        {
            string report = "Displaying Appointment Types by Month";
            var newline = System.Environment.NewLine;
            report += newline;

            var yearStart = new DateTime(DateTime.Now.Year, 1, 1);
            var yearEnd = new DateTime(yearStart.Year, 1, 1).AddYears(1).AddSeconds(-1);


            List<string> yearlyAppointmentList = Data.Select("appointment", 0, "start >= \'" + yearStart.ToString("yyyy-MM-dd HH:mm:ss") + "\'"
                              + "AND end <= \'" + yearEnd.ToString("yyyy-MM-dd HH:mm:ss") + "\'");
            // MessageBox.Show("yearlyAppointmentList is " + yearlyAppointmentList.Count);

            List<int> yearlyAppointmentIds = new List<int>();
            foreach (var idString in yearlyAppointmentList)
            {
                int parsed = -1;
                Int32.TryParse(idString, out parsed);
                if (parsed != -1) yearlyAppointmentIds.Add(parsed);
            }

            List<(string name, DateTime monthStart, DateTime monthEnd)> Months = new List<(string name, DateTime monthStart, DateTime monthEnd)>();
            foreach (var monthInt in Enumerable.Range(1, 12))
            {
                Months.Add((MonthNames[monthInt - 1], new DateTime(yearStart.Year, 1, 1).AddMonths(monthInt - 1), new DateTime(yearStart.Year, 1, 1).AddMonths(monthInt).AddSeconds(-1)));
            }
            List<string> typeList = new List<string>();
            foreach (var month in Months)
            {
                typeList.Clear();
                List<string> monthlyAppointmentList = Data.Select("appointment", 0, "start >= \'" + month.monthStart.ToString("yyyy-MM-dd HH:mm:ss") + "\'"
                              + "AND end <= \'" + month.monthEnd.ToString("yyyy-MM-dd HH:mm:ss") + "\'");
                List<int> monthlyAppointmentIds = new List<int>();
                foreach (var idString in monthlyAppointmentList)
                {
                    int parsed = -1;
                    Int32.TryParse(idString, out parsed);
                    if (parsed != -1) monthlyAppointmentIds.Add(parsed);
                }

                report += "For the month of " + month.name + ":" + newline;
               
                foreach (var id in monthlyAppointmentIds)
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
                    //query

                    int _CustomerId;
                    Int32.TryParse(Data.Select("appointment", 1, "appointmentID = \'" + id + "\';").FirstOrDefault(), out _CustomerId);
                    var _CustomerName = Data.Select("customer", 1, "customerId = \'" + _CustomerId + "\';").FirstOrDefault();

                    var _Title = Data.Select("appointment", 3, "appointmentID = \'" + id + "\';").FirstOrDefault();

                    var _Description = Data.Select("appointment", 4, "appointmentID = \'" + id + "\';").FirstOrDefault();
                    var _Location = Data.Select("appointment", 5, "appointmentID = \'" + id + "\';").FirstOrDefault();
                    var _Contact = Data.Select("appointment", 6, "appointmentID = \'" + id + "\';").FirstOrDefault();
                    var _Type = Data.Select("appointment", 7, "appointmentID = \'" + id + "\';").FirstOrDefault();
                    var _Url = Data.Select("appointment", 8, "appointmentID = \'" + id + "\';").FirstOrDefault();
                    DateTime _Date;
                    DateTime.TryParse(Data.Select("appointment", 9, "appointmentID = \'" + id + "\';").FirstOrDefault(), out _Date);
                    DateTime _Start;
                    DateTime.TryParse(Data.Select("appointment", 9, "appointmentID = \'" + id + "\';").FirstOrDefault(), out _Start);
                    DateTime _End;
                    DateTime.TryParse(Data.Select("appointment", 10, "appointmentID = \'" + id + "\';").FirstOrDefault(), out _End);

                    */
                    var _Type = Data.Select("appointment", 7, "appointmentID = \'" + id + "\';").FirstOrDefault();
                    typeList.Add(_Type);
                    //display
                }
                List<string> foundTypes = new List<string>();
                Dictionary<string, int> typeCounts = new Dictionary<string, int>();
                foreach(var type in typeList)
                {
                    if(foundTypes.Contains(type))
                    {
                        typeCounts[type] += 1;
                    }
                    else
                    {
                        foundTypes.Add(type);
                        typeCounts.Add(type, 1);
                    }
                }    
                foreach(var type in foundTypes)
                {
                    report += "\t" + type + " with a count of " + typeCounts[type] + newline;
                }

                report += newline + newline;
            }

            return report;
        }
        public static string ConsultantSchedules()
        {
            string report = "Displaying Consultant (User) Schedules";
            var newline = System.Environment.NewLine;
            var tab = "\t";
            report += newline;

            var userIds = Data.Select("user", 0);
            foreach(var id in userIds)
            {
                var userName = Data.Select("user", 1, "userId = \'" + id + "\'").FirstOrDefault();
                report += "The consultant '" + userName + "' has the following appointments scheduled:";
                report += newline;

                var appointmentIds = Data.Select("appointment", 0, "userId = \'" + id + "\'");
                var customerIds = Data.Select("appointment", 1, "userId = \'" + id + "\'");
                var starts = Data.Select("appointment", 9, "userId = \'" + id + "\'");
                var locations = Data.Select("appointment", 5, "userId = \'" + id + "\'");

                var appointments = new List<(int id, string customerName, DateTime start, string location)>();
                foreach(var appID in appointmentIds)
                {
                    var index = appointmentIds.IndexOf(appID);
                    int parsed;
                    Int32.TryParse(appID, out parsed);
                    int customerId;
                    Int32.TryParse(customerIds[index], out customerId);
                    var customerName = Data.Select("customer", 1, "customerId = \'" + customerId + "\'").FirstOrDefault();
                    DateTime start = DateTime.Parse(starts[index]);
                    var location = locations[index];
                    appointments.Add((parsed, customerName, start, location));
                }
                appointments.Sort((x, y) => x.start.CompareTo(y.start));

                foreach(var appointment in appointments)
                {
                    report += tab + tab + "Appointment Time: " + appointment.start.ToString();
                    report += tab + tab + "Customer Name: " + appointment.customerName;
                    report += tab + tab + "Location: " + appointment.location;
                    report += newline + newline;
                }
            }
            return report;
        }
        public static string AppointmentsByLocation()
        {
            string report = "Displaying Appointments by Location";
            var newline = System.Environment.NewLine;
            var tab = "\t";
            report += newline;

            var locations = Data.Select("appointment", 5);
            // MessageBox.Show("locations.Count is " + locations.Count);
            locations = locations.Distinct().ToList();
            foreach(var location in locations)
            {
                report += location + " has the following appointments scheduled:" + newline;

                

                var appointmentIds = Data.Select("appointment", 0, "location = \'" + location + "\'");
                var customerIds = Data.Select("appointment", 1, "location = \'" + location + "\'");
                var starts = Data.Select("appointment", 9, "location = \'" + location + "\'");
                var consultants = Data.Select("appointment", 2, "location = \'" + location + "\'");

                var appointments = new List<(int id, string customerName, DateTime start, string consultant)>();
                foreach (var appID in appointmentIds)
                {
                    var index = appointmentIds.IndexOf(appID);
                    int parsed;
                    Int32.TryParse(appID, out parsed);
                    int customerId;
                    Int32.TryParse(customerIds[index], out customerId);
                    var customerName = Data.Select("customer", 1, "customerId = \'" + customerId + "\'").FirstOrDefault();
                    DateTime start = DateTime.Parse(starts[index]);
                    int userId;
                    Int32.TryParse(consultants[index], out userId);
                    var consultant = Data.Select("user", 1, "userId = \'" + userId + "\'").FirstOrDefault();
                    appointments.Add((parsed, customerName, start, consultant));
                }
                appointments.Sort((x, y) => x.start.CompareTo(y.start));

                foreach (var appointment in appointments)
                {
                    report += tab + tab + "Appointment Time: " + appointment.start.ToString();
                    report += tab + tab + "Customer Name: " + appointment.customerName;
                    report += tab + tab + "Consultant: " + appointment.consultant;
                    report += newline + newline;
                }
            }


            
            return report;
        }

    }
}
