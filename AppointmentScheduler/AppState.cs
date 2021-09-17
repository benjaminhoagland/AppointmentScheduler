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

        private static int languageSetting = 0;
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
        private static int timezoneSetting = 47;
        public static int TimezoneSetting
        {
            get => timezoneSetting;
            set
            {
                if (value >= 0 && value < Location.Locations.Count)
                {
                    timezoneSetting = value;
                }
            }
        }
    }
}
