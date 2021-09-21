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
    public static class AppState
    {
        public static BindingList<string> VisibleCustomerNames = new BindingList<string>() { "this is a test line", "this is another test line" };

        public static DateTime SelectedWeek = DateTime.Now.StartOfWeek(DayOfWeek.Monday);

        private static int languageSetting = 0;
        public static weeklyView weeklyView;
        public static bool weeklySetting = true;
        public static int LanguageSetting
        {
            get => languageSetting;
            set
            {
                if (value >= 0 && value < Language.Languages.Count)
                {
                    languageSetting = value;
                }
            }
        }
        private static int locationSetting = 0;
        public static int LocationSetting
        {
            get => locationSetting;
            set
            {
                if (value >= 0 && value < Location.Locations.Count)
                {
                    locationSetting = value;
                }
            }
        }
        private static int _TimezoneSetting = 47;
        public static int TimezoneSetting
        {
            get => _TimezoneSetting;
            set
            {
                if (value >= 0 && value < Timezones.List.Count)
                {
                    _TimezoneSetting = value;
                    
                }
            }
        }
        private static DateTime _BusinessStart = new DateTime(2021, 01, 01, 08, 0, 0);
        public static DateTime BusinessStart { get {return _BusinessStart; } }
    }
}
