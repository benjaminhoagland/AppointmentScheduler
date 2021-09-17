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
        // flag:todo make "selectedCustomer" a static member of this class, and store the various retrieved info there 
        // including the record IDs for quick retrieval
        public CustomerView()
        {
            InitializeComponent();
            Localize(AppState.LanguageSetting);
            customerListBox.DataSource = AppState.VisibleCustomerNames;


        }
        public void Localize(int Language)
        {
            appNameLabel.Text = AppointmentScheduluer.Language.Label.CustomerView.appNameLabel[Language];
            pageLabel.Text = AppointmentScheduluer.Language.Label.CustomerView.pageLabel[Language];

            listGroupboxLabel.Text = AppointmentScheduluer.Language.Label.CustomerView.listGroupboxLabel[Language];
            searchLabel.Text = AppointmentScheduluer.Language.Label.CustomerView.searchLabel[Language];
            searchButton.Text = AppointmentScheduluer.Language.Label.CustomerView.searchLabel[Language];
            listLabel.Text = AppointmentScheduluer.Language.Label.CustomerView.listLabel[Language];

            addButton.Text = AppointmentScheduluer.Language.Label.CustomerView.addButton[Language];
            deleteButton.Text = AppointmentScheduluer.Language.Label.CustomerView.deleteButton[Language];

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

        private void CustomerView_Shown(object sender, EventArgs e)
        {

            searchButton_Click(sender, e);
        }
        private void CustomerView_Load(object sender, EventArgs e)
        {
            // attach the keyup event
            searchBox.KeyUp += TextBoxKeyUp;
            DisableCustomerEdit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void customerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            queryLabel.Text = "Querying...";
            queryLabel.Refresh();
            try
            {
                // no action is needed if this fails, maybe we can call "clear customer information" or something similar
                if(AppState.VisibleCustomerNames.Count > 0)
                {
                    var customerId = FindIDByName(customerListBox.SelectedItem.ToString());
                    LoadCustomer(customerId);
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.Message.ToString());
            }
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
            queryLabel.Text = "Querying...";
            queryLabel.Refresh();
            var searchText = searchBox.Text;
            AppState.VisibleCustomerNames.Clear();
            ClearCustomerInformation();
            try
            {
                var connection = Data.Connect();
                connection.Open();
                string query = "SELECT * FROM customer WHERE customerName LIKE '%" + searchText + "%';";
                MySqlCommand command = new MySqlCommand(query, connection);
                AppState.VisibleCustomerNames.Clear();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    AppState.VisibleCustomerNames.Add(reader[1].ToString());
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
                
                var customerId = FindIDByName(customerListBox.SelectedItem.ToString());
                LoadCustomer(customerId);
                
            }
        }
        private void LoadCustomer(int customerId)
        {
            Customer.Selected.ID = customerId;
            DisplaySelectedCustomerInformation();
        }
        private int FindIDByName(string customerName)
        {
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
            { return -1; }
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
            return selectedCustomer.id;
        }

        private void DisplaySelectedCustomerInformation()
        {
            nameBox.Text = Customer.Selected.Name;
            addressBox.Text = Customer.Selected.Address;
            address2Box.Text = Customer.Selected.Address2;
            cityBox.Text = Customer.Selected.City;
            postalCodeBox.Text = Customer.Selected.PostalCode;
            countryBox.Text = Customer.Selected.Country;
            phoneBox.Text = Customer.Selected.Phone;
            statusButton.Text = Customer.Selected.Active == true ? 
                Language.Label.CustomerView.activeButton[AppState.LanguageSetting] : 
                Language.Label.CustomerView.inactiveButton[AppState.LanguageSetting];
            queryLabel.Text = "Ready      ";
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
            DisplaySelectedCustomerInformation();
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
        private void pageLabel_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addButton.Enabled = false;
            Customer.Add();
            searchButton_Click(sender, e);
            addButton.Enabled = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            deleteButton.Enabled = false;
            Customer.Delete();
            searchButton_Click(sender, e);
            deleteButton.Enabled = true;    
        }
    }
}
