using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AppointmentScheduluer
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();

            // initialize languages and locations datasources


            Localize(AppState.LanguageSetting);
            Locate(AppState.LocationSetting);

        }

        public void Locate(int Location)
        {
            locationBox.DataSource = AppointmentScheduluer.Location.Locations;
            locationBox.SelectedIndex = Location;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoginButton_Click(sender,e);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var language = languageBox.SelectedIndex;
            AppState.LanguageSetting = language;
            Localize(language);
        }

        private void WriteLoginToLog()
        {
            var exePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var workingDirectory = System.IO.Path.GetDirectoryName(exePath);
            var logName = workingDirectory + @"\log.txt";
            var content = "Logon event at " + DateTime.Now + " for the user " + usernameBox.Text + "."; 
            File.AppendAllText(logName, content + Environment.NewLine);
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(passwordBox.Text == "test" && usernameBox.Text == "test")
            {
                // login succedes
                statusLabel.Text = AppointmentScheduluer.Language.Label.LoginView.Status_Success[AppState.LanguageSetting];
                statusLabel.ForeColor = Color.Black;

                weeklyView weeklyView = new weeklyView();
                weeklyView.Visible = true;
                weeklyView.Activate();

                // cleanup LoginView
                this.Visible = false;
                this.Enabled = false;

                // log event
                WriteLoginToLog();
                this.Close();
            }
            else
            {
                // login fails
                statusLabel.Text = AppointmentScheduluer.Language.Label.LoginView.Status_Failure[AppState.LanguageSetting];
                statusLabel.ForeColor = Color.Red;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void statusLabel_Click(object sender, EventArgs e)
        {

        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void locationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppState.LocationSetting = locationBox.SelectedIndex;
        }

        public void Localize(int Language)
        {
            languageBox.DataSource = AppointmentScheduluer.Language.Languages;
            languageBox.SelectedIndex = Language;

            titleLabel.Text = AppointmentScheduluer.Language.Label.LoginView.Title[Language];
            usernameLabel.Text = AppointmentScheduluer.Language.Label.LoginView.Username[Language];
            passwordLabel.Text = AppointmentScheduluer.Language.Label.LoginView.Password[Language];
            statusLabel.Text = AppointmentScheduluer.Language.Label.LoginView.Status_Please[Language];
            loginButton.Text = AppointmentScheduluer.Language.Label.LoginView.Login[Language];
            languageLabel.Text = AppointmentScheduluer.Language.Label.LoginView.Language[Language];
            locationLabel.Text = AppointmentScheduluer.Language.Label.LoginView.Location[Language];

            statusLabel.ForeColor = Color.Black;
        }
    }
}
