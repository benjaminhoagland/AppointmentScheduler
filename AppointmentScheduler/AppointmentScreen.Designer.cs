
namespace AppointmentScheduluer
{
    partial class AppointmentScreen
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
            this.pageLabel = new System.Windows.Forms.Label();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.customerPanelLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.appointmentPanelLabel = new System.Windows.Forms.Label();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.startBox = new System.Windows.Forms.TextBox();
            this.startLabel = new System.Windows.Forms.Label();
            this.endBox = new System.Windows.Forms.TextBox();
            this.endLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.ComboBox();
            this.locationBox = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pageLabel
            // 
            this.pageLabel.AutoSize = true;
            this.pageLabel.Location = new System.Drawing.Point(160, 46);
            this.pageLabel.Name = "pageLabel";
            this.pageLabel.Size = new System.Drawing.Size(92, 13);
            this.pageLabel.TabIndex = 15;
            this.pageLabel.Text = "Appointment View";
            this.pageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // appNameLabel
            // 
            this.appNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameLabel.ForeColor = System.Drawing.Color.Black;
            this.appNameLabel.Location = new System.Drawing.Point(12, 9);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(155, 17);
            this.appNameLabel.TabIndex = 14;
            this.appNameLabel.Text = "Appointment Scheduler";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(311, 9);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 102;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.VisibleChanged += new System.EventHandler(this.AppointmentScreen_VisibleChanged);
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nameBox);
            this.groupBox2.Controls.Add(this.changeButton);
            this.groupBox2.Controls.Add(this.phoneBox);
            this.groupBox2.Controls.Add(this.phoneLabel);
            this.groupBox2.Controls.Add(this.customerPanelLabel);
            this.groupBox2.Controls.Add(this.nameLabel);
            this.groupBox2.Location = new System.Drawing.Point(15, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 83);
            this.groupBox2.TabIndex = 101;
            this.groupBox2.TabStop = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Red;
            this.deleteButton.Location = new System.Drawing.Point(6, 203);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 27;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // phoneBox
            // 
            this.phoneBox.Enabled = false;
            this.phoneBox.Location = new System.Drawing.Point(86, 51);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(260, 20);
            this.phoneBox.TabIndex = 22;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(14, 55);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(38, 13);
            this.phoneLabel.TabIndex = 21;
            this.phoneLabel.Text = "Phone";
            // 
            // customerPanelLabel
            // 
            this.customerPanelLabel.AutoSize = true;
            this.customerPanelLabel.Location = new System.Drawing.Point(156, 0);
            this.customerPanelLabel.Name = "customerPanelLabel";
            this.customerPanelLabel.Size = new System.Drawing.Size(72, 13);
            this.customerPanelLabel.TabIndex = 1;
            this.customerPanelLabel.Text = "Customer Info";
            this.customerPanelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(14, 29);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.locationBox);
            this.groupBox1.Controls.Add(this.submitButton);
            this.groupBox1.Controls.Add(this.endBox);
            this.groupBox1.Controls.Add(this.endLabel);
            this.groupBox1.Controls.Add(this.startBox);
            this.groupBox1.Controls.Add(this.startLabel);
            this.groupBox1.Controls.Add(this.descriptionBox);
            this.groupBox1.Controls.Add(this.descriptionLabel);
            this.groupBox1.Controls.Add(this.typeBox);
            this.groupBox1.Controls.Add(this.typeLabel);
            this.groupBox1.Controls.Add(this.locationLabel);
            this.groupBox1.Controls.Add(this.dateBox);
            this.groupBox1.Controls.Add(this.dateLabel);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Location = new System.Drawing.Point(15, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 232);
            this.groupBox1.TabIndex = 102;
            this.groupBox1.TabStop = false;
            // 
            // appointmentPanelLabel
            // 
            this.appointmentPanelLabel.AutoSize = true;
            this.appointmentPanelLabel.Location = new System.Drawing.Point(160, 164);
            this.appointmentPanelLabel.Name = "appointmentPanelLabel";
            this.appointmentPanelLabel.Size = new System.Drawing.Size(87, 13);
            this.appointmentPanelLabel.TabIndex = 1;
            this.appointmentPanelLabel.Text = "Appointment Info";
            this.appointmentPanelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateBox
            // 
            this.dateBox.Enabled = false;
            this.dateBox.Location = new System.Drawing.Point(86, 19);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(260, 20);
            this.dateBox.TabIndex = 31;
            this.dateBox.TextChanged += new System.EventHandler(this.dateBox_TextChanged);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(14, 23);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(30, 13);
            this.dateLabel.TabIndex = 30;
            this.dateLabel.Text = "Date";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(14, 101);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(48, 13);
            this.locationLabel.TabIndex = 32;
            this.locationLabel.Text = "Location";
            // 
            // typeBox
            // 
            this.typeBox.Location = new System.Drawing.Point(86, 123);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(260, 20);
            this.typeBox.TabIndex = 35;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(14, 127);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(31, 13);
            this.typeLabel.TabIndex = 34;
            this.typeLabel.Text = "Type";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(86, 149);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(260, 20);
            this.descriptionBox.TabIndex = 37;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(14, 153);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 36;
            this.descriptionLabel.Text = "Description";
            // 
            // startBox
            // 
            this.startBox.Enabled = false;
            this.startBox.Location = new System.Drawing.Point(86, 45);
            this.startBox.Name = "startBox";
            this.startBox.Size = new System.Drawing.Size(260, 20);
            this.startBox.TabIndex = 39;
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(14, 49);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(29, 13);
            this.startLabel.TabIndex = 38;
            this.startLabel.Text = "Start";
            // 
            // endBox
            // 
            this.endBox.Enabled = false;
            this.endBox.Location = new System.Drawing.Point(86, 71);
            this.endBox.Name = "endBox";
            this.endBox.Size = new System.Drawing.Size(260, 20);
            this.endBox.TabIndex = 41;
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(14, 75);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(26, 13);
            this.endLabel.TabIndex = 40;
            this.endLabel.Text = "End";
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.LightBlue;
            this.changeButton.Enabled = false;
            this.changeButton.Location = new System.Drawing.Point(271, 23);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 23);
            this.changeButton.TabIndex = 42;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Visible = false;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.LightBlue;
            this.submitButton.Location = new System.Drawing.Point(290, 203);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 43;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.FormattingEnabled = true;
            this.nameBox.Location = new System.Drawing.Point(86, 24);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(179, 21);
            this.nameBox.TabIndex = 43;
            this.nameBox.SelectedIndexChanged += new System.EventHandler(this.nameBox_SelectedIndexChanged);
            // 
            // locationBox
            // 
            this.locationBox.Enabled = false;
            this.locationBox.FormattingEnabled = true;
            this.locationBox.Location = new System.Drawing.Point(86, 97);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(260, 21);
            this.locationBox.TabIndex = 44;
            // 
            // AppointmentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 409);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pageLabel);
            this.Controls.Add(this.appNameLabel);
            this.Controls.Add(this.appointmentPanelLabel);
            this.Controls.Add(this.groupBox1);
            this.Name = "AppointmentScreen";
            this.Text = "AppointmentScreen";
            this.Load += new System.EventHandler(this.AppointmentScreen_Load);
            this.Shown += new System.EventHandler(this.AppointmentScreen_Shown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pageLabel;
        private System.Windows.Forms.Label appNameLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label customerPanelLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label appointmentPanelLabel;
        private System.Windows.Forms.TextBox endBox;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.TextBox startBox;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ComboBox nameBox;
        private System.Windows.Forms.ComboBox locationBox;
    }
}