using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentScheduluer
{
    public partial class reportView : Form
    {
        public static List<string> ReportNames = new List<string>()
        {
            AppointmentScheduluer.Language.Label.WeeklyView.report1button[AppState.LanguageSetting],
            AppointmentScheduluer.Language.Label.WeeklyView.report2button[AppState.LanguageSetting],
            AppointmentScheduluer.Language.Label.WeeklyView.report3button[AppState.LanguageSetting]
        };
        public reportView()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportView_Load(object sender, EventArgs e)
        {
            Localize(AppState.LanguageSetting);
            textBox1.Text = "Report: " + ReportNames[AppState.ReportType];
            textBox1.ReadOnly = true;
            textBox1.BorderStyle = 0;
            textBox1.BackColor = this.BackColor;
            textBox1.TabStop = false;
        }
        private void Localize(int Language)
        {

            appNameLabel.Text = AppointmentScheduluer.Language.Label.CustomerView.appNameLabel[Language];
            pageLabel.Text = AppointmentScheduluer.Language.Label.ReportView.pageLabel[Language];
            backButton.Text = AppointmentScheduluer.Language.Label.CustomerView.backButton[Language];
        }
    }
}
