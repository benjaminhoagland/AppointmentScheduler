using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace AppointmentScheduluer
{
    public partial class AppointmentScreen : Form
    {
        private static BindingList<(int id, string name)> CustomerList = new BindingList<(int, string)>();
        private static BindingList<string> CustomerNameList = new BindingList<string>();
        private static BindingList<int> CustomerIDList = new BindingList<int>();
        private static BindingList<string> LocationList = new BindingList<string>();
        public AppointmentScreen()
        {
            InitializeComponent();
            nameBox.DataSource = CustomerNameList;
            locationBox.DataSource = LocationList;
        }
        private void AppointmentScreen_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LocationList.Clear();
            foreach (var location in AppointmentScheduluer.Location.Locations)
            {
                LocationList.Add(location);
            }
        }
        private void LoadCustomers()
        {
            CustomerList.Clear();
            CustomerIDList.Clear();
            CustomerNameList.Clear();

            var idList = Data.Select("customer", 0);
            var nameList = Data.Select("customer", 1);
            foreach (var id in idList)
            {
                int parsed;
                Int32.TryParse(id, out parsed);
                CustomerList.Add((parsed, nameList[idList.IndexOf(id)]));
                CustomerNameList.Add(nameList[idList.IndexOf(id)]);
                CustomerIDList.Add(parsed);
            }
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

            var index = nameBox.SelectedIndex;
            var selectedCustomer = (
                    id: 0,
                    name: "default"
                );
            if (matchingCustomers.Count == 0)
            { return -1; }
            else if (matchingCustomers.Count == 1)
            {
                selectedCustomer = (
                        matchingCustomers.FirstOrDefault().id,
                        matchingCustomers.FirstOrDefault().name
                    );

            }
            else if (matchingCustomers.Count >= 1)
            {
                selectedCustomer = (
                        matchingCustomers[index].id,
                        matchingCustomers[index].name
                    );
            }
            return selectedCustomer.id;
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            Appointment.Delete();
            AppState.weeklyView.Show();
            AppState.weeklyView.ClickRefresh();
            this.Hide();
            // AppState.weeklyView.ClickRefresh();
        }

        private void AppointmentScreen_Shown(object sender, EventArgs e)
        {
            Localize(AppState.LanguageSetting);
            LoadCustomers();
            Customer.Selected.CustomerId = Appointment.Selected.CustomerId;

            int match = 0;
            foreach(var id in CustomerIDList)
            {
                if(id == Customer.Selected.CustomerId)
                {
                    match = id;
                }
            }

            if(Appointment.Selected.New == true)
            {
                nameBox.SelectedIndex = 0;
                phoneBox.Text = "";
                dateBox.Text = Appointment.Selected.Date.ToString("yyyy-MM-dd");
                startBox.Text = Appointment.Selected.Start.ToString("HH:mm");
                endBox.Text = Appointment.Selected.End.ToString("HH:mm");
                locationBox.SelectedIndex = AppState.LocationSetting;
                typeBox.Text = Appointment.Selected.Type;
                descriptionBox.Text = "New Appointment";
            }
            else
            {
                foreach(var name in CustomerNameList)
                {
                    if(name == Customer.Selected.Name)
                    {
                        nameBox.SelectedIndex = CustomerNameList.IndexOf(name);
                    }
                }
                // nameBox.SelectedIndex = match - 1;
                phoneBox.Text = Customer.Selected.Phone;
                dateBox.Text = Appointment.Selected.Date.ToString("yyyy-MM-dd");
                startBox.Text = Appointment.Selected.Start.ToString("HH:mm");
                endBox.Text = Appointment.Selected.End.ToString(("HH:mm"));
                locationBox.SelectedIndex = AppState.LocationSetting;
                typeBox.Text = Appointment.Selected.Type;
                descriptionBox.Text = Appointment.Selected.Description;
            }
        }
        private void Localize(int Language)
        {
            appNameLabel.Text = AppointmentScheduluer.Language.Label.CustomerView.appNameLabel[Language];
            pageLabel.Text = AppointmentScheduluer.Language.Label.AppointmentScreen.pageLabel[Language];

            customerPanelLabel.Text = AppointmentScheduluer.Language.Label.AppointmentScreen.customerPanelLabel[Language];
            appointmentPanelLabel.Text = AppointmentScheduluer.Language.Label.AppointmentScreen.appointmentPanelLabel[Language];

            deleteButton.Text = AppointmentScheduluer.Language.Label.CustomerView.deleteButton[Language];
            submitButton.Text = AppointmentScheduluer.Language.Label.CustomerView.submitButton[Language];
            backButton.Text = AppointmentScheduluer.Language.Label.CustomerView.backButton[Language];

            nameLabel.Text = AppointmentScheduluer.Language.Label.CustomerView.nameLabel[Language];
            phoneLabel.Text = AppointmentScheduluer.Language.Label.CustomerView.phoneLabel[Language];

            dateLabel.Text = AppointmentScheduluer.Language.Label.AppointmentScreen.dateLabel[Language];
            startLabel.Text = AppointmentScheduluer.Language.Label.AppointmentScreen.startLabel[Language];
            endLabel.Text = AppointmentScheduluer.Language.Label.AppointmentScreen.endLabel[Language];
            locationLabel.Text = AppointmentScheduluer.Language.Label.AppointmentScreen.locationLabel[Language];
            typeLabel.Text = AppointmentScheduluer.Language.Label.AppointmentScreen.typeLabel[Language];
            descriptionLabel.Text = AppointmentScheduluer.Language.Label.AppointmentScreen.descriptionLabel[Language];

            changeButton.Text = AppointmentScheduluer.Language.Label.AppointmentScreen.changeButton[Language];

        }

        private void nameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nameBox.SelectedIndex == -1) return;
            var id = -1;
            Int32.TryParse(Data.Select("customer", 0, "customerName = \'" + nameBox.Text +"\';").FirstOrDefault(), out id);
            // MessageBox.Show(" index selected id is " + id);
            Customer.Selected.CustomerId = id;
            phoneBox.Text = Customer.Selected.Phone;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            deleteButton.Enabled = false;
            const string message =
                "Are you sure you want to delete the selected appointment?";
            const string caption = "Delete Warning";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            var customerId = FindIDByName(nameBox.SelectedItem.ToString());
            // If the no button was pressed ...
            if (result == DialogResult.Yes)
            {
                Appointment.Delete();
            }
            deleteButton.Enabled = true;
            AppState.weeklyView.Show();
            this.Hide();
            AppState.weeklyView.ClickRefresh();
        }

        private void dateBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // set customer id
            var id = -1;
            Int32.TryParse(Data.Select("customer", 0, "customerName = \'" + nameBox.Text + "\';").FirstOrDefault(), out id);
            Customer.Selected.CustomerId = id;
            // MessageBox.Show("customerId is " + customerId);

            var description = descriptionBox.Text;
            var type = typeBox.Text;
            // MessageBox.Show("id is " + id);
            // MessageBox.Show("Customer.Selected.Name is " + Customer.Selected.Name);
            Data.UpdateAppointment(Appointment.Selected.AppointmentId, id, description, type);
            phoneBox.Text = Customer.Selected.Phone;
            
            this.Hide();
            AppState.weeklyView.ClickRefresh();
        }

        private void AppointmentScreen_VisibleChanged(object sender, EventArgs e)
        {

        }
    }
}
