using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentScheduluer
{
    public class Timezones
    {
        public static List<TimeZoneInfo> List = new List<TimeZoneInfo>(TimeZoneInfo.GetSystemTimeZones());
    }
}
