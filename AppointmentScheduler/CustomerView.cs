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
        // flag:todo make "selectedCustomer" a static member of this class, and store the various retrieved info there 
        // including the record IDs for quick retrieval
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
            searchLabel.Text = AppointmentScheduluer.Language.Label.CustomerView.searchLabel[Language];
            searchButton.Text = AppointmentScheduluer.Language.Label.CustomerView.searchLabel[Language];
            listLabel.Text = AppointmentScheduluer.Language.Label.CustomerView.listLabel[Language];

            infoGroupboxLabel.Text = AppointmentScheduluer.Language.Label.CustomerView.infoGroupboxLabel[Language];
            nameLabel.Text = AppointmentScheduluer.Language.Label.CustomerView.nameLabel[Language];
            addressLabel.Text = AppointmentScheduluer.Language.Label.CustomerView.addressLabel[Language];
            address2Label.Text = AppointmentScheduluer.Language.Label.CustomerView.address2Label[Language];
            cityLabel.Text = AppointmentScheduluer.Language.Label.CustomerView.cityLabel[Language];
            postalCodeLabel.Text = AppointmentScheduluer.Language.Label.CustomerView.postalCodeLabel[Language];
            countryLabel.Text = AppointmentScheduluer.Language.Label.CustomerView.countryLabel[Language];
            phoneLabel.Text = AppointmentScheduluer.Language.Label.CustomerView.phoneLabel[Language];
            statusLabel.Text = AppointmentScheduluer.Language.Label.CustomerView.statusLabel[Language];

            statusButton.Text = AppointmentScheduluer.Language.Label.CustomerView.activeButton[Language];

            editButton.Text = AppointmentScheduluer.Language.Label.CustomerView.editButton[Language];
            cancelButton.Text = AppointmentScheduluer.Language.Label.CustomerView.cancelButton[Language];
            submitButton.Text = AppointmentScheduluer.Language.Label.CustomerView.submitButton[Language];
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

            // attach the keyup event
            searchBox.KeyUp += TextBoxKeyUp;
            DisableCustomerEdit();
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

        private void customerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // no action is needed if this fails, maybe we can call "clear customer information" or something similar
                if(VisibleCustomerNames.Count > 0)
                {
                    DisplayCustomerInformation(customerListBox.SelectedItem.ToString());
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.Message.ToString());
            }
            /*
            string selectedCustomer = "";
            try
            {
                var connection = Data.Connect();
                connection.Open();
                string query = "SELECT * FROM customer WHERE customerName = '" + customerListBox.SelectedItem  + "';";
                MySqlCommand command = new MySqlCommand(query, connection);
                // command.Parameters.AddWithValue("@table", "country");
                VisibleCustomerNames.Clear();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    selectedCustomer = (reader[1].ToString());
                    break;
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            nameBox.Text = selectedCustomer;
            */
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void statusButton_Click(object sender, EventArgs e)
        {

        }

        private void customerListBox_SelectedValueChanged(object sender, EventArgs e)
        {

        }
        private void TextBoxKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchButton_Click(sender, e);
                e.Handled = true;
            }
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            var searchText = searchBox.Text;
            VisibleCustomerNames.Clear();
            ClearCustomerInformation();
            try
            {
                var connection = Data.Connect();
                connection.Open();
                string query = "SELECT * FROM customer WHERE customerName LIKE '%" + searchText + "%';";
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
            if (customerListBox.Items.Count > 0)
            {
                customerListBox.SelectedIndex = 0;
                // customerListBox.Focus();
                DisplayCustomerInformation(customerListBox.SelectedItem.ToString());
                
            }
        }
        private void DisplayCustomerInformation(string customerName)
        {
            queryLabel.Text = "Querying...";
            queryLabel.Refresh();
            var matchingCustomerNames = Data.Select("customer", 1, "customerName LIKE '%" + customerName + "%';");
            var matchingCustomerIds = Data.Select("customer", 0, "customerName LIKE '%" + customerName + "%';");
            var matchingCustomers = new List<(
                    int id, 
                    string name
                )>();
            foreach (var name in matchingCustomerNames)
            {
                int result = 0;
                int.TryParse(matchingCustomerIds[matchingCustomerNames.IndexOf(name)], out result);
                matchingCustomers.Add((result, name));
            }

            var index = customerListBox.SelectedIndex;
            // flag:debug_only MessageBox.Show("index is " + index);
            // flag:debug_only MessageBox.Show("matchingCustomers.Count is " + matchingCustomers.Count);
            var selectedCustomer = (
                    id: 0, 
                    name: "default"
                );
            if (matchingCustomers.Count == 0)
            { return; }
            else if(matchingCustomers.Count == 1)
            { 
                selectedCustomer = (
                        matchingCustomers.FirstOrDefault().id, 
                        matchingCustomers.FirstOrDefault().name
                    );
                
            }
            else if(matchingCustomers.Count >= 1)
            {
                selectedCustomer = (
                        matchingCustomers[index].id, 
                        matchingCustomers[index].name
                    );
            }
            nameBox.Text = Data.Select("customer", 1, "customerId = \'" + selectedCustomer.id + "\';").FirstOrDefault();
            var addressId = Data.Select("customer", 2, "customerId = \'" + selectedCustomer.id + "\';").FirstOrDefault();
            addressBox.Text = Data.Select("address", 1, "addressId = \'" + addressId + "\';").FirstOrDefault();

            queryLabel.Text = "Ready";
            queryLabel.Refresh();
        }
        private void ClearCustomerInformation()
        {
            nameBox.Text = "";
            addressBox.Text = "";
            address2Box.Text = "";
            cityBox.Text = "";

            postalCodeBox.Text = "";
            countryBox.Text = "";
            phoneBox.Text = "";
            statusButton.Text = "Active";

            
        }
        private void DisableCustomerEdit()
        {
            searchBox.Enabled = true;
            searchButton.Enabled = true;
            customerListBox.Enabled = true;
            groupBox1.Refresh();

            nameBox.Enabled = false;
            addressBox.Enabled = false;
            address2Box.Enabled = false;
            cityBox.Enabled = false;

            postalCodeBox.Enabled = false;
            countryBox.Enabled = false;
            phoneBox.Enabled = false;
            statusButton.Enabled = false;

            editButton.Enabled = true;
            cancelButton.Enabled = false;
            cancelButton.BackColor = SystemColors.Control;
            submitButton.Enabled = false;
            submitButton.BackColor = SystemColors.Control;
            groupBox2.Refresh();

        }
        private void EnableCustomerEdit()
        {
            nameBox.Enabled = true;
            addressBox.Enabled = true;
            address2Box.Enabled = true;
            cityBox.Enabled = true;

            postalCodeBox.Enabled = true;
            countryBox.Enabled = true;
            phoneBox.Enabled = true;
            statusButton.Enabled = true;

            editButton.Enabled = false;
            cancelButton.Enabled = true;
            cancelButton.BackColor = Color.Orange;
            submitButton.Enabled = true;
            submitButton.BackColor = Color.LightSkyBlue;

            searchBox.Enabled = false;
            searchButton.Enabled = false;
            customerListBox.Enabled = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DisableCustomerEdit();
            ClearCustomerInformation();
            DisplayCustomerInformation(customerListBox.SelectedItem.ToString());
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EnableCustomerEdit();
            queryLabel.Text = "Editing...";
            queryLabel.Refresh();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            queryLabel.Text = "Processing...";
            queryLabel.Refresh();
        }
    }
}
