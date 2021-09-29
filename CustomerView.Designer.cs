
namespace AppointmentScheduluer
{
    partial class CustomerView
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
        /// the contents of th
        /// method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pageLabel = new System.Windows.Forms.Label();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.customerListBox = new System.Windows.Forms.ListBox();
            this.listLabel = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.listGroupboxLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.queryLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.statusButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.postalCodeBox = new System.Windows.Forms.TextBox();
            this.postalCodeLabel = new System.Windows.Forms.Label();
            this.countryBox = new System.Windows.Forms.TextBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.address2Box = new System.Windows.Forms.TextBox();
            this.address2Label = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.infoGroupboxLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pageLabel
            // 
            this.pageLabel.AutoSize = true;
            this.pageLabel.Location = new System.Drawing.Point(354, 32);
            this.pageLabel.Name = "pageLabel";
            this.pageLabel.Size = new System.Drawing.Size(77, 13);
            this.pageLabel.TabIndex = 15;
            this.pageLabel.Text = "Customer View";
            this.pageLabel.Click += new System.EventHandler(this.pageLabel_Click);
            // 
            // appNameLabel
            // 
            this.appNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameLabel.ForeColor = System.Drawing.Color.Black;
            this.appNameLabel.Location = new System.Drawing.Point(4, 14);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(155, 17);
            this.appNameLabel.TabIndex = 14;
            this.appNameLabel.Text = "Appointment Scheduler";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.customerListBox);
            this.groupBox1.Controls.Add(this.listLabel);
            this.groupBox1.Controls.Add(this.searchBox);
            this.groupBox1.Controls.Add(this.searchLabel);
            this.groupBox1.Controls.Add(this.listGroupboxLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 401);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Salmon;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.deleteButton.Location = new System.Drawing.Point(269, 357);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 31;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addButton.Location = new System.Drawing.Point(73, 357);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 30;
            this.addButton.Text = "Add New";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(283, 31);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(61, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // customerListBox
            // 
            this.customerListBox.FormattingEnabled = true;
            this.customerListBox.Location = new System.Drawing.Point(73, 64);
            this.customerListBox.Name = "customerListBox";
            this.customerListBox.Size = new System.Drawing.Size(271, 277);
            this.customerListBox.TabIndex = 3;
            this.customerListBox.SelectedIndexChanged += new System.EventHandler(this.customerListBox_SelectedIndexChanged);
            this.customerListBox.SelectedValueChanged += new System.EventHandler(this.customerListBox_SelectedValueChanged);
            // 
            // listLabel
            // 
            this.listLabel.AutoSize = true;
            this.listLabel.Location = new System.Drawing.Point(26, 64);
            this.listLabel.Name = "listLabel";
            this.listLabel.Size = new System.Drawing.Size(42, 13);
            this.listLabel.TabIndex = 3;
            this.listLabel.Text = "Results";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(73, 32);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(204, 20);
            this.searchBox.TabIndex = 1;
            this.searchBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(26, 35);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(41, 13);
            this.searchLabel.TabIndex = 1;
            this.searchLabel.Text = "Search";
            // 
            // listGroupboxLabel
            // 
            this.listGroupboxLabel.AutoSize = true;
            this.listGroupboxLabel.Location = new System.Drawing.Point(154, 0);
            this.listGroupboxLabel.Name = "listGroupboxLabel";
            this.listGroupboxLabel.Size = new System.Drawing.Size(70, 13);
            this.listGroupboxLabel.TabIndex = 0;
            this.listGroupboxLabel.Text = "Customer List";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.queryLabel);
            this.groupBox2.Controls.Add(this.cancelButton);
            this.groupBox2.Controls.Add(this.submitButton);
            this.groupBox2.Controls.Add(this.editButton);
            this.groupBox2.Controls.Add(this.statusButton);
            this.groupBox2.Controls.Add(this.statusLabel);
            this.groupBox2.Controls.Add(this.phoneBox);
            this.groupBox2.Controls.Add(this.phoneLabel);
            this.groupBox2.Controls.Add(this.postalCodeBox);
            this.groupBox2.Controls.Add(this.postalCodeLabel);
            this.groupBox2.Controls.Add(this.countryBox);
            this.groupBox2.Controls.Add(this.countryLabel);
            this.groupBox2.Controls.Add(this.cityBox);
            this.groupBox2.Controls.Add(this.cityLabel);
            this.groupBox2.Controls.Add(this.address2Box);
            this.groupBox2.Controls.Add(this.address2Label);
            this.groupBox2.Controls.Add(this.addressBox);
            this.groupBox2.Controls.Add(this.addressLabel);
            this.groupBox2.Controls.Add(this.nameBox);
            this.groupBox2.Controls.Add(this.infoGroupboxLabel);
            this.groupBox2.Controls.Add(this.nameLabel);
            this.groupBox2.Location = new System.Drawing.Point(401, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 401);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Status:";
            // 
            // queryLabel
            // 
            this.queryLabel.AutoSize = true;
            this.queryLabel.Location = new System.Drawing.Point(83, 35);
            this.queryLabel.Name = "queryLabel";
            this.queryLabel.Size = new System.Drawing.Size(38, 13);
            this.queryLabel.TabIndex = 4;
            this.queryLabel.Text = "Ready";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Orange;
            this.cancelButton.Location = new System.Drawing.Point(190, 357);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 28;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.submitButton.Location = new System.Drawing.Point(271, 357);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 27;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(17, 357);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // statusButton
            // 
            this.statusButton.Location = new System.Drawing.Point(86, 274);
            this.statusButton.Name = "statusButton";
            this.statusButton.Size = new System.Drawing.Size(75, 23);
            this.statusButton.TabIndex = 25;
            this.statusButton.Text = "Active";
            this.statusButton.UseVisualStyleBackColor = true;
            this.statusButton.Click += new System.EventHandler(this.statusButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(14, 279);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(37, 13);
            this.statusLabel.TabIndex = 23;
            this.statusLabel.Text = "Status";
            this.statusLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(86, 244);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(260, 20);
            this.phoneBox.TabIndex = 22;
            this.phoneBox.TextChanged += new System.EventHandler(this.phoneBox_TextChanged);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(14, 248);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(38, 13);
            this.phoneLabel.TabIndex = 21;
            this.phoneLabel.Text = "Phone";
            // 
            // postalCodeBox
            // 
            this.postalCodeBox.Location = new System.Drawing.Point(86, 184);
            this.postalCodeBox.MaxLength = 10;
            this.postalCodeBox.Name = "postalCodeBox";
            this.postalCodeBox.Size = new System.Drawing.Size(260, 20);
            this.postalCodeBox.TabIndex = 16;
            this.postalCodeBox.TextChanged += new System.EventHandler(this.postalCodeBox_TextChanged);
            // 
            // postalCodeLabel
            // 
            this.postalCodeLabel.AutoSize = true;
            this.postalCodeLabel.Location = new System.Drawing.Point(14, 188);
            this.postalCodeLabel.Name = "postalCodeLabel";
            this.postalCodeLabel.Size = new System.Drawing.Size(64, 13);
            this.postalCodeLabel.TabIndex = 19;
            this.postalCodeLabel.Text = "Postal Code";
            // 
            // countryBox
            // 
            this.countryBox.Location = new System.Drawing.Point(86, 214);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(260, 20);
            this.countryBox.TabIndex = 18;
            this.countryBox.TextChanged += new System.EventHandler(this.countryBox_TextChanged);
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(14, 218);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(43, 13);
            this.countryLabel.TabIndex = 15;
            this.countryLabel.Text = "Country";
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(86, 154);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(260, 20);
            this.cityBox.TabIndex = 14;
            this.cityBox.TextChanged += new System.EventHandler(this.cityBox_TextChanged);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(14, 158);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(24, 13);
            this.cityLabel.TabIndex = 13;
            this.cityLabel.Text = "City";
            // 
            // address2Box
            // 
            this.address2Box.Location = new System.Drawing.Point(86, 124);
            this.address2Box.Name = "address2Box";
            this.address2Box.Size = new System.Drawing.Size(260, 20);
            this.address2Box.TabIndex = 12;
            // 
            // address2Label
            // 
            this.address2Label.AutoSize = true;
            this.address2Label.Location = new System.Drawing.Point(14, 128);
            this.address2Label.Name = "address2Label";
            this.address2Label.Size = new System.Drawing.Size(54, 13);
            this.address2Label.TabIndex = 11;
            this.address2Label.Text = "Address 2";
            this.address2Label.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(86, 94);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(260, 20);
            this.addressBox.TabIndex = 8;
            this.addressBox.TextChanged += new System.EventHandler(this.addressBox_TextChanged);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(14, 98);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 7;
            this.addressLabel.Text = "Address";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(86, 64);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(260, 20);
            this.nameBox.TabIndex = 6;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // infoGroupboxLabel
            // 
            this.infoGroupboxLabel.AutoSize = true;
            this.infoGroupboxLabel.Location = new System.Drawing.Point(151, 0);
            this.infoGroupboxLabel.Name = "infoGroupboxLabel";
            this.infoGroupboxLabel.Size = new System.Drawing.Size(72, 13);
            this.infoGroupboxLabel.TabIndex = 1;
            this.infoGroupboxLabel.Text = "Customer Info";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(14, 68);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name";
            this.nameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(697, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 99;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // CustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pageLabel);
            this.Controls.Add(this.appNameLabel);
            this.Name = "CustomerView";
            this.Text = "CustomerView";
            this.Load += new System.EventHandler(this.CustomerView_Load);
            this.Shown += new System.EventHandler(this.CustomerView_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pageLabel;
        private System.Windows.Forms.Label appNameLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label listGroupboxLabel;
        private System.Windows.Forms.Label infoGroupboxLabel;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.ListBox customerListBox;
        private System.Windows.Forms.Label listLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox address2Box;
        private System.Windows.Forms.Label address2Label;
        private System.Windows.Forms.TextBox postalCodeBox;
        private System.Windows.Forms.Label postalCodeLabel;
        private System.Windows.Forms.TextBox countryBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Button statusButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label queryLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
    }
}