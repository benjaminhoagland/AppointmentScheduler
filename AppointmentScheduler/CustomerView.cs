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
    public partial class CustomerView : Form
    {
        public static BindingList<string> VisibleCustomerNames = new BindingList<string>() { "this is a test line", "this is another test line" };
        public CustomerView()
        {
            InitializeComponent();
            Localize(AppStatus.LanguageSetting);
            customerListBox.DataSource = VisibleCustomerNames;


        }
        public void Localize(int Language)
        {
            appNameLabel.Text = AppointmentScheduluer.Language.Label.CustomerView.appNameLabel[Language];
            pageLabel.Text = AppointmentScheduluer.Language.Label.CustomerView.pageLabel[Language];
            listGroupboxLabel.Text = AppointmentScheduluer.Language.Label.CustomerView.listGroupboxLabel[Language];
            infoGroupboxLabel.Text = AppointmentScheduluer.Language.Label.CustomerView.infoGroupboxLabel[Language];
            searchLabel.Text = AppointmentScheduluer.Language.Label.CustomerView.searchLabel[Language];
            listLabel.Text = AppointmentScheduluer.Language.Label.CustomerView.listLabel[Language];
            nameLabel.Text = AppointmentScheduluer.Language.Label.CustomerView.nameLabel[Language];
            addressLabel.Text = AppointmentScheduluer.Language.Label.CustomerView.addressLabel[Language];
            statusLabel.Text = AppointmentScheduluer.Language.Label.CustomerView.statusLabel[Language];
            backButton.Text = AppointmentScheduluer.Language.Label.CustomerView.backButton[Language];


        }

        private void CustomerView_Load(object sender, EventArgs e)
        {
            // connect database
            try
            {
                var connection = Data.Connect();
                connection.Open();
                string query = "SELECT * FROM customer;";
                MySqlCommand command = new MySqlCommand(query, connection);
                // command.Parameters.AddWithValue("@table", "country");
                VisibleCustomerNames.Clear();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    VisibleCustomerNames.Add(reader[1].ToString());
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void pageLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
