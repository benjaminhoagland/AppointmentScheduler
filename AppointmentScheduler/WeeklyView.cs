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
    public partial class weeklyView : Form
    {
        Form customerView = new CustomerView();
        Form appointmentScreen = new AppointmentScreen();
        public static List<Label> DisplayedDateLabels = new List<Label>();
        public static List<TableLayoutPanel> DayPanels = new List<TableLayoutPanel>();
        public static Form refreshable;
        public static bool loaded = false;
        public weeklyView()
        {
            InitializeComponent();
            Localize(AppState.LanguageSetting);
            Locate(AppState.LocationSetting);
            Temporize(AppState.TimezoneSetting);
            refreshable = this;
        }
        private void WeeklyView_Load(object sender, EventArgs e)
        {
            // load into customer view when app loads
            // button1_Click(sender, e);
            PopulateLabels();

            AppState.weeklyView = this;
            refreshButton_Click(sender, e);
            loaded = true;
        }
        private void PopulateLabels()
        {
            DisplayedDateLabels.Add(mondayDate);
            DisplayedDateLabels.Add(tuesdayDate);
            DisplayedDateLabels.Add(wednesdayDate);
            DisplayedDateLabels.Add(thursdayDate);
            DisplayedDateLabels.Add(fridayDate);

            DayPanels.Add(mondayPanel);
            DayPanels.Add(tuesdayPanel);
            DayPanels.Add(wednesdayPanel);
            DayPanels.Add(thursdayPanel);
            DayPanels.Add(fridayPanel);
        }
        private void languageBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var language = languageBox.SelectedIndex;
            AppState.LanguageSetting = language;
            Localize(language);
        }
        public void Temporize(int Timezone)
        {
            timezoneBox.DataSource = AppointmentScheduluer.Timezones.List;
            timezoneBox.SelectedIndex = Timezone;
        }
        public void Localize(int Language)
        {
            languageBox.DataSource = AppointmentScheduluer.Language.Languages;
            languageBox.SelectedIndex = Language;
            appNameLabel.Text = AppointmentScheduluer.Language.Label.WeeklyView.appNameLabel[Language];
            locationLabel.Text = AppointmentScheduluer.Language.Label.WeeklyView.locationLabel[Language];
            timezoneLabel.Text = AppointmentScheduluer.Language.Label.WeeklyView.timezoneLabel[Language];
            customerButton.Text = AppointmentScheduluer.Language.Label.WeeklyView.customerButton[Language];
            prevButton.Text = AppointmentScheduluer.Language.Label.WeeklyView.prevButton[Language];
            nextButton.Text = AppointmentScheduluer.Language.Label.WeeklyView.nextButton[Language];
            refreshButton.Text = AppointmentScheduluer.Language.Label.WeeklyView.refreshButton[Language];

            mondayLabel.Text = AppointmentScheduluer.Language.Label.WeeklyView.mondayLabel[Language];
            tuesdayLabel.Text = AppointmentScheduluer.Language.Label.WeeklyView.tuesdayLabel[Language];
            wednesdayLabel.Text = AppointmentScheduluer.Language.Label.WeeklyView.wednesdayLabel[Language];
            thursdayLabel.Text = AppointmentScheduluer.Language.Label.WeeklyView.thursdayLabel[Language];
            fridayLabel.Text = AppointmentScheduluer.Language.Label.WeeklyView.fridayLabel[Language];

            changeViewButton.Text = AppState.weeklySetting == true
                ? AppointmentScheduluer.Language.Label.WeeklyView.changeToMonthly[AppState.LanguageSetting]
                : AppointmentScheduluer.Language.Label.WeeklyView.changeToWeekly[AppState.LanguageSetting];
            pageLabel.Text = AppState.weeklySetting == true
                ? AppointmentScheduluer.Language.Label.WeeklyView.weeklyViewLabel[AppState.LanguageSetting]
                : AppointmentScheduluer.Language.Label.WeeklyView.monthlyViewLabel[AppState.LanguageSetting];
        }
        public void Locate(int Location)
        {
            locationBox.DataSource = AppointmentScheduluer.Location.Locations;
            locationBox.SelectedIndex = Location;
        }

        private void locationLabel_Click(object sender, EventArgs e)
        {

        }

        private void timezoneBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppState.TimezoneSetting = timezoneBox.SelectedIndex;
            refreshButton_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // open customer view modal
            
            customerView.ShowDialog(this);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Cyan;
            panel3.Refresh();
            Data.Clear();
            panel3.BackColor = SystemColors.GradientActiveCaption;
            panel3.Refresh();
            refreshButton_Click(sender, e);
        }

        private void populateDataButton_Click(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Cyan;
            panel3.Refresh();
            var foundItems = Data.Select("customer", 0);
            if(foundItems.Count == 0)
            {
                Data.Populate();
            }
            panel3.BackColor = SystemColors.GradientActiveCaption;
            panel3.Refresh();
            refreshButton_Click(sender, e);
        }

        public void ClickRefresh()
        {
            refreshButton.PerformClick();
        }
        private List<TimeAddressableButton> buttonList = new List<TimeAddressableButton>();
        public void refreshButton_Click(object sender, EventArgs e)
        {
   
            Drawing.Suspend(this);
            /* 
            Data.InsertAppointment(3,
                       "Appointment 4",
                       "This is the fourth appointment",
                       "New York, New York",
                       "Contact Information",
                       "Follow-Up Appointment",
                       "someaddress.domain.com",
                       DateTime.Now.StartOfWeek(DayOfWeek.Monday).AddDays(1).AddHours(9),
                       DateTime.Now.StartOfWeek(DayOfWeek.Monday).AddDays(1).AddHours(10));
            */
            if (AppState.weeklySetting == true)
            {
                buttonList.Clear();
                PopulateLabels();
                foreach (int day in Enumerable.Range(0, 5))
                {
                    DayPanels[day].Controls.Clear();
                    DisplayedDateLabels[day].Text = AppState.SelectedWeek.AddDays(day).ToString("yyyy-MM-dd");
                    var appointments = Data.GetAppointments(AppState.SelectedWeek.AddDays(day));

                    appointmentCount.Text = appointments.Count().ToString();

                    foreach (var hour in Enumerable.Range(0, 8))
                    {
                        var timeslot = AppState.SelectedWeek.AddDays(day).AddHours(AppState.BusinessStart.AddHours(hour).Hour);
                        var button = new TimeAddressableButton();
                        buttonList.Add(button);
                        button.TextAlign = ContentAlignment.MiddleCenter;
                        button.Dock = DockStyle.Fill;
                        button.Text = AppState.SelectedWeek.AddDays(day).AddHours(timeslot.Hour)
                            .AddHours(Timezones.List[AppState.TimezoneSetting].BaseUtcOffset.Hours)
                            .AddHours(-Timezones.List[AppointmentScheduluer.Location.Timezone[AppState.LocationSetting]].BaseUtcOffset.Hours)
                            .ToString("HH:mm");

                        button.Name = "button" + timeslot.ToString("yyyymmddhh");
                        button.TimeAddress = timeslot;
                        button.Click += (s, ev) => // "lambda instance 2"
                        {
                            // initialize button
                            int id = 0;

                            // try to find a matching appointment at that time
                            Int32.TryParse(Data.Select("appointment", 0, "start = \'" + button.TimeAddress.ToString("yyyy-MM-dd hh:mm:ss") + "\';").FirstOrDefault(), out id);
                            // MessageBox.Show("found id is " + id);
                            if (id == 0)
                            {
                                // create an appointment
                                Data.InsertAppointment(1, "New appointment" + button.TimeAddress.ToString("yyyy-MM-dd"), "", AppointmentScheduluer.Location.Locations[AppState.LocationSetting], "", "New", "", button.TimeAddress, button.TimeAddress.AddHours(1));
                                // get the most recently created appointment's id
                                Int32.TryParse(Data.Select("appointment", 0, "start = \'" + button.TimeAddress.ToString("yyyy-MM-dd hh:mm:ss") + "\';").LastOrDefault(), out id);
                                // MessageBox.Show("button.TimeAddress.ToString(\"yyyy - MM - dd hh: mm:ss\") is " + button.TimeAddress.ToString("yyyy-MM-dd hh:mm:ss"));


                                // use the new appointment id as the selected id
                                Appointment.Selected.AppointmentId = id;
                            }
                            else
                            {
                                // use the found appointment id to set the selected id
                                Appointment.Selected.AppointmentId = id;
                            }

                            // id was not found to be 0, and there was an appointment detected in that slot
                            // check if the found matching appoiintment is at the correct location
                            if (Data.Select("appointment", 5, "appointmentId = \'" + id + "\';").FirstOrDefault() == AppointmentScheduluer.Location.Locations[AppState.LocationSetting])
                            {

                                // MessageBox.Show(Data.Select("appointment", 5, "start = \'" + button.TimeAddress.ToString("yyyy-MM-dd hh:mm:ss") + "\';").FirstOrDefault());

                                // check if there is no appointment at that time
                                if (id == 0)
                                {
                                    // create an appointment
                                    Data.InsertAppointment(1, "New appointment" + button.TimeAddress.ToString("yyyy-MM-dd"), "", AppointmentScheduluer.Location.Locations[AppState.LocationSetting], "", "New", "", button.TimeAddress, button.TimeAddress.AddHours(1));
                                    // get the most recently created appointment's id
                                    Int32.TryParse(Data.Select("appointment", 0, "start = \'" + button.TimeAddress.ToString("yyyy-MM-dd hh:mm:ss") + "\';").LastOrDefault(), out id);
                                    MessageBox.Show("button.TimeAddress.ToString(\"yyyy - MM - dd hh: mm:ss\") is " + button.TimeAddress.ToString("yyyy-MM-dd hh:mm:ss"));


                                    // use the new appointment id as the selected id
                                    Appointment.Selected.AppointmentId = id;
                                }
                                else
                                {
                                    // use the found appointment id to set the selected id
                                    Appointment.Selected.AppointmentId = id;
                                }
                            }
                            // show the dialog
                            appointmentScreen.ShowDialog(this);


                        };
                        DayPanels[day].Controls.Add(button, 0, hour);
                        if (appointments.Any(t => t.start == timeslot && t.location == AppointmentScheduluer.Location.Locations[AppState.LocationSetting])) // "lambda instance 1"
                        {
                            button.BackColor = Color.Orange;
                            button.Text += System.Environment.NewLine;
                            button.Text += "Edit Appointment";
                        }
                        else
                        {
                            button.BackColor = Color.LightBlue;
                            button.Text += System.Environment.NewLine;
                            button.Text += "Create Appointment";
                        }
                    }
                }
            }
            else
            {
                foreach (var panel in DayPanels)
                {
                    panel.Controls.Clear();
                }
                buttonList.Clear();
                PopulateLabels();
                foreach (int week in Enumerable.Range(0, 5))
                {
                    // MessageBox.Show("week is " + week);
                    var offset = week * 7;
                    foreach (int day in Enumerable.Range(0, 5))
                    {
                        // MessageBox.Show("day is " + day);
                        
                        if(week == 0) DisplayedDateLabels[day].Text = "";

                        var appointments = Data.GetAppointments(AppState.SelectedWeek.AddDays(day + offset));
                        appointmentCount.Text = appointments.Count().ToString();

                        var button = new TimeAddressableButton();
                        buttonList.Add(button);
                        button.TextAlign = ContentAlignment.MiddleCenter;
                        button.Dock = DockStyle.Fill;
                        button.Text = AppState.SelectedWeek.AddDays(day + offset).ToString("yyyy-MM-dd");

                        button.Name = "button" + AppState.SelectedWeek.AddDays(day + offset).ToString("yyyymmdd");
                        button.TimeAddress = AppState.SelectedWeek.AddDays(day + offset);
                        button.Click += (s, ev) => 
                        { 
                            AppState.weeklySetting = true; 
                            AppState.SelectedWeek = button.TimeAddress.StartOfWeek(DayOfWeek.Monday);
                            refreshButton_Click(sender, e);
                        }; // "lambda instance 3"

                        DayPanels[day].Controls.Add(button, 0, week);
                        if (appointments.Any(
                            t => t.start >= AppState.SelectedWeek.AddDays(day + offset).AddHours(AppState.BusinessStart.Hour) 
                            && t.end <= AppState.SelectedWeek.AddDays(day + offset).AddHours(AppState.BusinessStart.Hour + 8)
                            && t.location == AppointmentScheduluer.Location.Locations[AppState.LocationSetting])) // "lambda instance 1"
                        {
                            button.BackColor = Color.Orange;
                            button.Text += System.Environment.NewLine;
                            button.Text += "View Appointments";
                        }
                        else
                        {
                            button.BackColor = Color.LightBlue;
                            button.Text += System.Environment.NewLine;
                            button.Text += "Create Appointment";
                        }
                        
                    }
                }
            }
            // timezoneBox.SelectedIndex = AppState.TimezoneSetting;
            Drawing.Resume(this);
            this.Refresh();
        }
        private void NewButton_Click(object sender, EventArgs e) // "lambda instance 2" was refitted from this function
        {
            var clicked = (TimeAddressableButton)sender;

            foreach (var button in buttonList)
            {
                if (clicked.TimeAddress == button.TimeAddress)
                {
                    int id;
                    Int32.TryParse(Data.Select("appointment", 0, "start = \'" + clicked.TimeAddress + "\';").FirstOrDefault(), out id);
                    Appointment.Selected.AppointmentId = id;
                    appointmentScreen.ShowDialog(this);
                    break;
                }
            }
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            var days = AppState.weeklySetting == true ? 7 : 7 * 4;
            AppState.SelectedWeek = AppState.SelectedWeek.AddDays(days);
            refreshButton_Click(sender,e);
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            var days = AppState.weeklySetting == true ? 7 : 7 * 4;
            AppState.SelectedWeek = AppState.SelectedWeek.AddDays(-days);
            refreshButton_Click(sender, e);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void locationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppState.LocationSetting = locationBox.SelectedIndex;
            
            if(loaded) refreshButton_Click(sender, e);
        }

        private void changeViewButton_Click(object sender, EventArgs e)
        {
            AppState.weeklySetting = !AppState.weeklySetting;
            changeViewButton.Text = AppState.weeklySetting == true
                ? AppointmentScheduluer.Language.Label.WeeklyView.changeToMonthly[AppState.LanguageSetting]
                : AppointmentScheduluer.Language.Label.WeeklyView.changeToWeekly[AppState.LanguageSetting];
            pageLabel.Text = AppState.weeklySetting == true
                ? AppointmentScheduluer.Language.Label.WeeklyView.weeklyViewLabel[AppState.LanguageSetting]
                : AppointmentScheduluer.Language.Label.WeeklyView.monthlyViewLabel[AppState.LanguageSetting];
            refreshButton_Click(sender, e);
        }
    }
}
