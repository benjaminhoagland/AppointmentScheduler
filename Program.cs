using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace AppointmentScheduluer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Data.Clear();
            // Data.Populate();
            AppState.SelectedWeek = DateTime.Now.StartOfWeek(DayOfWeek.Monday);
            AppState.TimezoneSetting = Timezones.List.IndexOf(TimeZoneInfo.Local);

            CultureInfo ci = CultureInfo.CurrentCulture;
            if (ci.TwoLetterISOLanguageName == "es")
            {
                AppState.LanguageSetting = 1;
            }
            else
            {
                AppState.LanguageSetting = 0;
            }
            var main = new LoginView();
            main.FormClosed += new FormClosedEventHandler(FormClosed);
            main.Show();
            Application.Run();
        }

        static void FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= FormClosed;
            if (Application.OpenForms.Count == 0) Application.ExitThread();
            else Application.OpenForms[0].FormClosed += FormClosed;
        }
    }
}
