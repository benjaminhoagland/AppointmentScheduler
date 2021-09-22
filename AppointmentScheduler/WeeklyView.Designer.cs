
namespace AppointmentScheduluer
{
    partial class weeklyView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.languageBox = new System.Windows.Forms.ComboBox();
            this.locationBox = new System.Windows.Forms.ComboBox();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pageLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timezoneLabel = new System.Windows.Forms.Label();
            this.timezoneBox = new System.Windows.Forms.ComboBox();
            this.customerButton = new System.Windows.Forms.Button();
            this.clearDataButton = new System.Windows.Forms.Button();
            this.populateDataButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mondayPanel = new System.Windows.Forms.TableLayoutPanel();
            this.nextButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.mondayLabel = new System.Windows.Forms.Label();
            this.tuesdayLabel = new System.Windows.Forms.Label();
            this.wednesdayLabel = new System.Windows.Forms.Label();
            this.thursdayLabel = new System.Windows.Forms.Label();
            this.fridayLabel = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.weekPanel = new System.Windows.Forms.TableLayoutPanel();
            this.fridayDate = new System.Windows.Forms.Label();
            this.thursdayDate = new System.Windows.Forms.Label();
            this.wednesdayDate = new System.Windows.Forms.Label();
            this.tuesdayDate = new System.Windows.Forms.Label();
            this.fridayPanel = new System.Windows.Forms.TableLayoutPanel();
            this.thursdayPanel = new System.Windows.Forms.TableLayoutPanel();
            this.wednesdayPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tuesdayPanel = new System.Windows.Forms.TableLayoutPanel();
            this.mondayDate = new System.Windows.Forms.Label();
            this.appointmentCount = new System.Windows.Forms.Label();
            this.changeViewButton = new System.Windows.Forms.Button();
            this.reportLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.report1button = new System.Windows.Forms.Button();
            this.report2button = new System.Windows.Forms.Button();
            this.report3button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.weekPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // languageBox
            // 
            this.languageBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageBox.FormattingEnabled = true;
            this.languageBox.Location = new System.Drawing.Point(914, 578);
            this.languageBox.Name = "languageBox";
            this.languageBox.Size = new System.Drawing.Size(121, 21);
            this.languageBox.TabIndex = 8;
            this.languageBox.SelectedIndexChanged += new System.EventHandler(this.languageBox_SelectedIndexChanged);
            // 
            // locationBox
            // 
            this.locationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.locationBox.FormattingEnabled = true;
            this.locationBox.Location = new System.Drawing.Point(787, 578);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(121, 21);
            this.locationBox.TabIndex = 9;
            this.locationBox.SelectedIndexChanged += new System.EventHandler(this.locationBox_SelectedIndexChanged);
            // 
            // appNameLabel
            // 
            this.appNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameLabel.ForeColor = System.Drawing.Color.Black;
            this.appNameLabel.Location = new System.Drawing.Point(12, 9);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(155, 17);
            this.appNameLabel.TabIndex = 10;
            this.appNameLabel.Text = "Appointment Scheduler";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.locationLabel.Location = new System.Drawing.Point(139, 0);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.locationLabel.Size = new System.Drawing.Size(143, 13);
            this.locationLabel.TabIndex = 11;
            this.locationLabel.Text = "Displaying times for location: ";
            this.locationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.locationLabel.Click += new System.EventHandler(this.locationLabel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.locationLabel);
            this.panel1.Location = new System.Drawing.Point(502, 581);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(282, 17);
            this.panel1.TabIndex = 12;
            // 
            // pageLabel
            // 
            this.pageLabel.AutoSize = true;
            this.pageLabel.Location = new System.Drawing.Point(423, 61);
            this.pageLabel.Name = "pageLabel";
            this.pageLabel.Size = new System.Drawing.Size(69, 13);
            this.pageLabel.TabIndex = 13;
            this.pageLabel.Text = "Weekly View";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.timezoneLabel);
            this.panel2.Location = new System.Drawing.Point(-156, 582);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(280, 17);
            this.panel2.TabIndex = 14;
            // 
            // timezoneLabel
            // 
            this.timezoneLabel.AutoSize = true;
            this.timezoneLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.timezoneLabel.Location = new System.Drawing.Point(175, 0);
            this.timezoneLabel.Name = "timezoneLabel";
            this.timezoneLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.timezoneLabel.Size = new System.Drawing.Size(105, 13);
            this.timezoneLabel.TabIndex = 11;
            this.timezoneLabel.Text = "Appointment time in: ";
            this.timezoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timezoneBox
            // 
            this.timezoneBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timezoneBox.FormattingEnabled = true;
            this.timezoneBox.Location = new System.Drawing.Point(129, 579);
            this.timezoneBox.Name = "timezoneBox";
            this.timezoneBox.Size = new System.Drawing.Size(262, 21);
            this.timezoneBox.TabIndex = 13;
            this.timezoneBox.SelectedIndexChanged += new System.EventHandler(this.timezoneBox_SelectedIndexChanged);
            // 
            // customerButton
            // 
            this.customerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customerButton.AutoSize = true;
            this.customerButton.Location = new System.Drawing.Point(953, 12);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(82, 23);
            this.customerButton.TabIndex = 15;
            this.customerButton.Text = "Customers";
            this.customerButton.UseVisualStyleBackColor = true;
            this.customerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearDataButton
            // 
            this.clearDataButton.BackColor = System.Drawing.Color.Aqua;
            this.clearDataButton.Location = new System.Drawing.Point(215, 1);
            this.clearDataButton.Name = "clearDataButton";
            this.clearDataButton.Size = new System.Drawing.Size(55, 23);
            this.clearDataButton.TabIndex = 16;
            this.clearDataButton.Text = "Clear";
            this.clearDataButton.UseVisualStyleBackColor = false;
            this.clearDataButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // populateDataButton
            // 
            this.populateDataButton.BackColor = System.Drawing.Color.Cyan;
            this.populateDataButton.Location = new System.Drawing.Point(276, 1);
            this.populateDataButton.Name = "populateDataButton";
            this.populateDataButton.Size = new System.Drawing.Size(63, 23);
            this.populateDataButton.TabIndex = 17;
            this.populateDataButton.Text = "Populate";
            this.populateDataButton.UseVisualStyleBackColor = false;
            this.populateDataButton.Click += new System.EventHandler(this.populateDataButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Debugging and Test Database Controls";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.populateDataButton);
            this.panel3.Controls.Add(this.clearDataButton);
            this.panel3.Location = new System.Drawing.Point(589, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(347, 25);
            this.panel3.TabIndex = 19;
            // 
            // mondayPanel
            // 
            this.mondayPanel.ColumnCount = 1;
            this.mondayPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mondayPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mondayPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mondayPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mondayPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mondayPanel.Location = new System.Drawing.Point(3, 45);
            this.mondayPanel.Name = "mondayPanel";
            this.mondayPanel.RowCount = 8;
            this.mondayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.mondayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.mondayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.mondayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.mondayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.mondayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.mondayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.mondayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.mondayPanel.Size = new System.Drawing.Size(167, 344);
            this.mondayPanel.TabIndex = 20;
            this.mondayPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(498, 56);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 21;
            this.nextButton.Text = "Next  >";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(342, 56);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(75, 23);
            this.prevButton.TabIndex = 22;
            this.prevButton.Text = "<  Previous";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // mondayLabel
            // 
            this.mondayLabel.AutoSize = true;
            this.mondayLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.mondayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mondayLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mondayLabel.Location = new System.Drawing.Point(3, 0);
            this.mondayLabel.Name = "mondayLabel";
            this.mondayLabel.Size = new System.Drawing.Size(167, 21);
            this.mondayLabel.TabIndex = 23;
            this.mondayLabel.Text = "Monday";
            this.mondayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tuesdayLabel
            // 
            this.tuesdayLabel.AutoSize = true;
            this.tuesdayLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tuesdayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tuesdayLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tuesdayLabel.Location = new System.Drawing.Point(176, 0);
            this.tuesdayLabel.Name = "tuesdayLabel";
            this.tuesdayLabel.Size = new System.Drawing.Size(167, 21);
            this.tuesdayLabel.TabIndex = 24;
            this.tuesdayLabel.Text = "Tuesday";
            this.tuesdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wednesdayLabel
            // 
            this.wednesdayLabel.AutoSize = true;
            this.wednesdayLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.wednesdayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wednesdayLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wednesdayLabel.Location = new System.Drawing.Point(349, 0);
            this.wednesdayLabel.Name = "wednesdayLabel";
            this.wednesdayLabel.Size = new System.Drawing.Size(167, 21);
            this.wednesdayLabel.TabIndex = 25;
            this.wednesdayLabel.Text = "Wednesday";
            this.wednesdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thursdayLabel
            // 
            this.thursdayLabel.AutoSize = true;
            this.thursdayLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.thursdayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thursdayLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thursdayLabel.Location = new System.Drawing.Point(522, 0);
            this.thursdayLabel.Name = "thursdayLabel";
            this.thursdayLabel.Size = new System.Drawing.Size(167, 21);
            this.thursdayLabel.TabIndex = 26;
            this.thursdayLabel.Text = "Thursday";
            this.thursdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fridayLabel
            // 
            this.fridayLabel.AutoSize = true;
            this.fridayLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.fridayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fridayLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fridayLabel.Location = new System.Drawing.Point(695, 0);
            this.fridayLabel.Name = "fridayLabel";
            this.fridayLabel.Size = new System.Drawing.Size(171, 21);
            this.fridayLabel.TabIndex = 27;
            this.fridayLabel.Text = "Friday";
            this.fridayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(409, 525);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(83, 23);
            this.refreshButton.TabIndex = 29;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // weekPanel
            // 
            this.weekPanel.ColumnCount = 5;
            this.weekPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.weekPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.weekPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.weekPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.weekPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.weekPanel.Controls.Add(this.fridayDate, 4, 1);
            this.weekPanel.Controls.Add(this.thursdayDate, 3, 1);
            this.weekPanel.Controls.Add(this.wednesdayDate, 2, 1);
            this.weekPanel.Controls.Add(this.tuesdayDate, 1, 1);
            this.weekPanel.Controls.Add(this.mondayLabel, 0, 0);
            this.weekPanel.Controls.Add(this.fridayPanel, 4, 2);
            this.weekPanel.Controls.Add(this.fridayLabel, 4, 0);
            this.weekPanel.Controls.Add(this.thursdayPanel, 3, 2);
            this.weekPanel.Controls.Add(this.thursdayLabel, 3, 0);
            this.weekPanel.Controls.Add(this.wednesdayPanel, 2, 2);
            this.weekPanel.Controls.Add(this.tuesdayPanel, 1, 2);
            this.weekPanel.Controls.Add(this.mondayPanel, 0, 2);
            this.weekPanel.Controls.Add(this.tuesdayLabel, 1, 0);
            this.weekPanel.Controls.Add(this.wednesdayLabel, 2, 0);
            this.weekPanel.Controls.Add(this.mondayDate, 0, 1);
            this.weekPanel.Location = new System.Drawing.Point(21, 127);
            this.weekPanel.Name = "weekPanel";
            this.weekPanel.RowCount = 3;
            this.weekPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.5F));
            this.weekPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.5F));
            this.weekPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89F));
            this.weekPanel.Size = new System.Drawing.Size(869, 392);
            this.weekPanel.TabIndex = 30;
            // 
            // fridayDate
            // 
            this.fridayDate.AutoSize = true;
            this.fridayDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fridayDate.Location = new System.Drawing.Point(695, 21);
            this.fridayDate.Name = "fridayDate";
            this.fridayDate.Size = new System.Drawing.Size(171, 21);
            this.fridayDate.TabIndex = 32;
            this.fridayDate.Text = "date";
            this.fridayDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thursdayDate
            // 
            this.thursdayDate.AutoSize = true;
            this.thursdayDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thursdayDate.Location = new System.Drawing.Point(522, 21);
            this.thursdayDate.Name = "thursdayDate";
            this.thursdayDate.Size = new System.Drawing.Size(167, 21);
            this.thursdayDate.TabIndex = 31;
            this.thursdayDate.Text = "date";
            this.thursdayDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wednesdayDate
            // 
            this.wednesdayDate.AutoSize = true;
            this.wednesdayDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wednesdayDate.Location = new System.Drawing.Point(349, 21);
            this.wednesdayDate.Name = "wednesdayDate";
            this.wednesdayDate.Size = new System.Drawing.Size(167, 21);
            this.wednesdayDate.TabIndex = 30;
            this.wednesdayDate.Text = "date";
            this.wednesdayDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tuesdayDate
            // 
            this.tuesdayDate.AutoSize = true;
            this.tuesdayDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tuesdayDate.Location = new System.Drawing.Point(176, 21);
            this.tuesdayDate.Name = "tuesdayDate";
            this.tuesdayDate.Size = new System.Drawing.Size(167, 21);
            this.tuesdayDate.TabIndex = 29;
            this.tuesdayDate.Text = "date";
            this.tuesdayDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fridayPanel
            // 
            this.fridayPanel.ColumnCount = 1;
            this.fridayPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.fridayPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.fridayPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.fridayPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.fridayPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.fridayPanel.Location = new System.Drawing.Point(695, 45);
            this.fridayPanel.Name = "fridayPanel";
            this.fridayPanel.RowCount = 8;
            this.fridayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.fridayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.fridayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.fridayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.fridayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.fridayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.fridayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.fridayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.fridayPanel.Size = new System.Drawing.Size(167, 344);
            this.fridayPanel.TabIndex = 21;
            // 
            // thursdayPanel
            // 
            this.thursdayPanel.ColumnCount = 1;
            this.thursdayPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.thursdayPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.thursdayPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.thursdayPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.thursdayPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.thursdayPanel.Location = new System.Drawing.Point(522, 45);
            this.thursdayPanel.Name = "thursdayPanel";
            this.thursdayPanel.RowCount = 8;
            this.thursdayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.thursdayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.thursdayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.thursdayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.thursdayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.thursdayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.thursdayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.thursdayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.thursdayPanel.Size = new System.Drawing.Size(167, 344);
            this.thursdayPanel.TabIndex = 21;
            // 
            // wednesdayPanel
            // 
            this.wednesdayPanel.ColumnCount = 1;
            this.wednesdayPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.wednesdayPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.wednesdayPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.wednesdayPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.wednesdayPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.wednesdayPanel.Location = new System.Drawing.Point(349, 45);
            this.wednesdayPanel.Name = "wednesdayPanel";
            this.wednesdayPanel.RowCount = 8;
            this.wednesdayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.wednesdayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.wednesdayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.wednesdayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.wednesdayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.wednesdayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.wednesdayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.wednesdayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.wednesdayPanel.Size = new System.Drawing.Size(167, 344);
            this.wednesdayPanel.TabIndex = 21;
            // 
            // tuesdayPanel
            // 
            this.tuesdayPanel.ColumnCount = 1;
            this.tuesdayPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tuesdayPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tuesdayPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tuesdayPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tuesdayPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tuesdayPanel.Location = new System.Drawing.Point(176, 45);
            this.tuesdayPanel.Name = "tuesdayPanel";
            this.tuesdayPanel.RowCount = 8;
            this.tuesdayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tuesdayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tuesdayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tuesdayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tuesdayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tuesdayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tuesdayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tuesdayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tuesdayPanel.Size = new System.Drawing.Size(167, 344);
            this.tuesdayPanel.TabIndex = 21;
            // 
            // mondayDate
            // 
            this.mondayDate.AutoSize = true;
            this.mondayDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mondayDate.Location = new System.Drawing.Point(3, 21);
            this.mondayDate.Name = "mondayDate";
            this.mondayDate.Size = new System.Drawing.Size(167, 21);
            this.mondayDate.TabIndex = 28;
            this.mondayDate.Text = "date";
            this.mondayDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // appointmentCount
            // 
            this.appointmentCount.AutoSize = true;
            this.appointmentCount.Location = new System.Drawing.Point(132, 84);
            this.appointmentCount.Name = "appointmentCount";
            this.appointmentCount.Size = new System.Drawing.Size(93, 13);
            this.appointmentCount.TabIndex = 31;
            this.appointmentCount.Text = "appointmentCount";
            this.appointmentCount.Visible = false;
            // 
            // changeViewButton
            // 
            this.changeViewButton.AutoSize = true;
            this.changeViewButton.BackColor = System.Drawing.Color.DarkSalmon;
            this.changeViewButton.Location = new System.Drawing.Point(388, 85);
            this.changeViewButton.Name = "changeViewButton";
            this.changeViewButton.Size = new System.Drawing.Size(132, 23);
            this.changeViewButton.TabIndex = 32;
            this.changeViewButton.Text = "Change to Monthly View";
            this.changeViewButton.UseVisualStyleBackColor = false;
            this.changeViewButton.Click += new System.EventHandler(this.changeViewButton_Click);
            // 
            // reportLabel
            // 
            this.reportLabel.AutoSize = true;
            this.reportLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportLabel.Location = new System.Drawing.Point(3, 0);
            this.reportLabel.Name = "reportLabel";
            this.reportLabel.Size = new System.Drawing.Size(133, 54);
            this.reportLabel.TabIndex = 33;
            this.reportLabel.Text = "Generate Reports";
            this.reportLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.report3button, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.reportLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.report2button, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.report1button, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(896, 127);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(139, 218);
            this.tableLayoutPanel1.TabIndex = 37;
            // 
            // report1button
            // 
            this.report1button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.report1button.Location = new System.Drawing.Point(3, 57);
            this.report1button.Name = "report1button";
            this.report1button.Size = new System.Drawing.Size(133, 48);
            this.report1button.TabIndex = 35;
            this.report1button.Text = "Appointment Types By Month";
            this.report1button.UseVisualStyleBackColor = true;
            this.report1button.Click += new System.EventHandler(this.report1button_Click);
            // 
            // report2button
            // 
            this.report2button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.report2button.Location = new System.Drawing.Point(3, 111);
            this.report2button.Name = "report2button";
            this.report2button.Size = new System.Drawing.Size(133, 48);
            this.report2button.TabIndex = 36;
            this.report2button.Text = "Consultant Schedules";
            this.report2button.UseVisualStyleBackColor = true;
            this.report2button.Click += new System.EventHandler(this.report2button_Click);
            // 
            // report3button
            // 
            this.report3button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.report3button.Location = new System.Drawing.Point(3, 165);
            this.report3button.Name = "report3button";
            this.report3button.Size = new System.Drawing.Size(133, 50);
            this.report3button.TabIndex = 38;
            this.report3button.Text = "Appointments by Location";
            this.report3button.UseVisualStyleBackColor = true;
            this.report3button.Click += new System.EventHandler(this.report3button_Click);
            // 
            // weeklyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 611);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.changeViewButton);
            this.Controls.Add(this.appointmentCount);
            this.Controls.Add(this.weekPanel);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.customerButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.timezoneBox);
            this.Controls.Add(this.pageLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.appNameLabel);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.languageBox);
            this.Name = "weeklyView";
            this.Text = "WeeklyView";
            this.Load += new System.EventHandler(this.WeeklyView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.weekPanel.ResumeLayout(false);
            this.weekPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox languageBox;
        private System.Windows.Forms.ComboBox locationBox;
        private System.Windows.Forms.Label appNameLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label pageLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label timezoneLabel;
        private System.Windows.Forms.ComboBox timezoneBox;
        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.Button clearDataButton;
        private System.Windows.Forms.Button populateDataButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel mondayPanel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Label mondayLabel;
        private System.Windows.Forms.Label tuesdayLabel;
        private System.Windows.Forms.Label wednesdayLabel;
        private System.Windows.Forms.Label thursdayLabel;
        private System.Windows.Forms.Label fridayLabel;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TableLayoutPanel weekPanel;
        private System.Windows.Forms.TableLayoutPanel fridayPanel;
        private System.Windows.Forms.TableLayoutPanel thursdayPanel;
        private System.Windows.Forms.TableLayoutPanel wednesdayPanel;
        private System.Windows.Forms.TableLayoutPanel tuesdayPanel;
        private System.Windows.Forms.Label fridayDate;
        private System.Windows.Forms.Label thursdayDate;
        private System.Windows.Forms.Label wednesdayDate;
        private System.Windows.Forms.Label tuesdayDate;
        private System.Windows.Forms.Label mondayDate;
        private System.Windows.Forms.Label appointmentCount;
        private System.Windows.Forms.Button changeViewButton;
        private System.Windows.Forms.Label reportLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button report3button;
        private System.Windows.Forms.Button report2button;
        private System.Windows.Forms.Button report1button;
    }
}