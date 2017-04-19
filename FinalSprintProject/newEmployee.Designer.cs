namespace FinalSprintProject
{
    partial class newEmployee
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
            this.RegisterNewEmployeeLabel = new System.Windows.Forms.Label();
            this.FirstnameLabel = new System.Windows.Forms.Label();
            this.LastnameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.ZipcodeLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.Savebutton = new System.Windows.Forms.Button();
            this.ReturntoMainMenuButton = new System.Windows.Forms.Button();
            this.FirstName_txt = new System.Windows.Forms.TextBox();
            this.LastName_txt = new System.Windows.Forms.TextBox();
            this.Address_txt = new System.Windows.Forms.TextBox();
            this.Position_Combobox = new System.Windows.Forms.ComboBox();
            this.Phone_txt = new System.Windows.Forms.TextBox();
            this.City_txt = new System.Windows.Forms.TextBox();
            this.State_txt = new System.Windows.Forms.TextBox();
            this.ZipCode_txt = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.email_txt = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ID_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.inputIDLabel = new System.Windows.Forms.Label();
            this.SearchPatronID = new System.Windows.Forms.TextBox();
            this.loadtable_txt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // RegisterNewEmployeeLabel
            // 
            this.RegisterNewEmployeeLabel.AutoSize = true;
            this.RegisterNewEmployeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterNewEmployeeLabel.Location = new System.Drawing.Point(33, 23);
            this.RegisterNewEmployeeLabel.Name = "RegisterNewEmployeeLabel";
            this.RegisterNewEmployeeLabel.Size = new System.Drawing.Size(234, 29);
            this.RegisterNewEmployeeLabel.TabIndex = 0;
            this.RegisterNewEmployeeLabel.Text = "Register New User";
            // 
            // FirstnameLabel
            // 
            this.FirstnameLabel.AutoSize = true;
            this.FirstnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstnameLabel.Location = new System.Drawing.Point(37, 153);
            this.FirstnameLabel.Name = "FirstnameLabel";
            this.FirstnameLabel.Size = new System.Drawing.Size(113, 25);
            this.FirstnameLabel.TabIndex = 1;
            this.FirstnameLabel.Text = "First name";
            this.FirstnameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // LastnameLabel
            // 
            this.LastnameLabel.AutoSize = true;
            this.LastnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastnameLabel.Location = new System.Drawing.Point(37, 190);
            this.LastnameLabel.Name = "LastnameLabel";
            this.LastnameLabel.Size = new System.Drawing.Size(112, 25);
            this.LastnameLabel.TabIndex = 2;
            this.LastnameLabel.Text = "Last name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Birth date";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(38, 258);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(87, 24);
            this.AddressLabel.TabIndex = 5;
            this.AddressLabel.Text = "Address";
            // 
            // ZipcodeLabel
            // 
            this.ZipcodeLabel.AutoSize = true;
            this.ZipcodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZipcodeLabel.Location = new System.Drawing.Point(37, 288);
            this.ZipcodeLabel.Name = "ZipcodeLabel";
            this.ZipcodeLabel.Size = new System.Drawing.Size(155, 25);
            this.ZipcodeLabel.TabIndex = 6;
            this.ZipcodeLabel.Text = "City, State, Zip";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLabel.Location = new System.Drawing.Point(37, 323);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(74, 25);
            this.PhoneLabel.TabIndex = 8;
            this.PhoneLabel.Text = "Phone";
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionLabel.Location = new System.Drawing.Point(35, 380);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(89, 25);
            this.PositionLabel.TabIndex = 9;
            this.PositionLabel.Text = "Position";
            // 
            // Savebutton
            // 
            this.Savebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebutton.Location = new System.Drawing.Point(207, 429);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(89, 41);
            this.Savebutton.TabIndex = 10;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // ReturntoMainMenuButton
            // 
            this.ReturntoMainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturntoMainMenuButton.Location = new System.Drawing.Point(207, 501);
            this.ReturntoMainMenuButton.Name = "ReturntoMainMenuButton";
            this.ReturntoMainMenuButton.Size = new System.Drawing.Size(241, 66);
            this.ReturntoMainMenuButton.TabIndex = 11;
            this.ReturntoMainMenuButton.Text = "Return to Main Menu";
            this.ReturntoMainMenuButton.UseVisualStyleBackColor = true;
            this.ReturntoMainMenuButton.Click += new System.EventHandler(this.ReturntoMainMenuButton_Click);
            // 
            // FirstName_txt
            // 
            this.FirstName_txt.Location = new System.Drawing.Point(207, 153);
            this.FirstName_txt.Name = "FirstName_txt";
            this.FirstName_txt.Size = new System.Drawing.Size(297, 22);
            this.FirstName_txt.TabIndex = 12;
            this.FirstName_txt.TextChanged += new System.EventHandler(this.FirstName_txt_TextChanged);
            // 
            // LastName_txt
            // 
            this.LastName_txt.Location = new System.Drawing.Point(207, 190);
            this.LastName_txt.Name = "LastName_txt";
            this.LastName_txt.Size = new System.Drawing.Size(297, 22);
            this.LastName_txt.TabIndex = 13;
            this.LastName_txt.TextChanged += new System.EventHandler(this.LastName_txt_TextChanged);
            // 
            // Address_txt
            // 
            this.Address_txt.Location = new System.Drawing.Point(207, 260);
            this.Address_txt.Name = "Address_txt";
            this.Address_txt.Size = new System.Drawing.Size(297, 22);
            this.Address_txt.TabIndex = 14;
            // 
            // Position_Combobox
            // 
            this.Position_Combobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Position_Combobox.FormattingEnabled = true;
            this.Position_Combobox.Items.AddRange(new object[] {
            "Patron",
            "Employee",
            "Manager",
            "Administrator"});
            this.Position_Combobox.Location = new System.Drawing.Point(207, 380);
            this.Position_Combobox.Name = "Position_Combobox";
            this.Position_Combobox.Size = new System.Drawing.Size(297, 24);
            this.Position_Combobox.TabIndex = 20;
            this.Position_Combobox.Text = "Select...";
            // 
            // Phone_txt
            // 
            this.Phone_txt.Location = new System.Drawing.Point(207, 323);
            this.Phone_txt.Name = "Phone_txt";
            this.Phone_txt.Size = new System.Drawing.Size(297, 22);
            this.Phone_txt.TabIndex = 23;
            this.Phone_txt.TextChanged += new System.EventHandler(this.Phone_txt_TextChanged);
            // 
            // City_txt
            // 
            this.City_txt.Location = new System.Drawing.Point(207, 288);
            this.City_txt.Name = "City_txt";
            this.City_txt.Size = new System.Drawing.Size(110, 22);
            this.City_txt.TabIndex = 24;
            // 
            // State_txt
            // 
            this.State_txt.Location = new System.Drawing.Point(323, 288);
            this.State_txt.Name = "State_txt";
            this.State_txt.Size = new System.Drawing.Size(51, 22);
            this.State_txt.TabIndex = 25;
            // 
            // ZipCode_txt
            // 
            this.ZipCode_txt.Location = new System.Drawing.Point(380, 288);
            this.ZipCode_txt.Name = "ZipCode_txt";
            this.ZipCode_txt.Size = new System.Drawing.Size(124, 22);
            this.ZipCode_txt.TabIndex = 26;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(207, 224);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(293, 22);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // email_txt
            // 
            this.email_txt.AutoSize = true;
            this.email_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_txt.Location = new System.Drawing.Point(37, 348);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(73, 25);
            this.email_txt.TabIndex = 28;
            this.email_txt.Text = "E-mail";
            this.email_txt.Click += new System.EventHandler(this.label1_Click);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(207, 351);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(297, 22);
            this.email.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "Password";
            // 
            // ID_txt
            // 
            this.ID_txt.Location = new System.Drawing.Point(207, 83);
            this.ID_txt.Name = "ID_txt";
            this.ID_txt.Size = new System.Drawing.Size(297, 22);
            this.ID_txt.TabIndex = 32;
            this.ID_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_txt_KeyPress);
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(207, 117);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(297, 22);
            this.password_txt.TabIndex = 33;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(612, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(725, 288);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // inputIDLabel
            // 
            this.inputIDLabel.AutoSize = true;
            this.inputIDLabel.Location = new System.Drawing.Point(609, 83);
            this.inputIDLabel.Name = "inputIDLabel";
            this.inputIDLabel.Size = new System.Drawing.Size(70, 17);
            this.inputIDLabel.TabIndex = 35;
            this.inputIDLabel.Text = "Search ID";
            // 
            // SearchPatronID
            // 
            this.SearchPatronID.Location = new System.Drawing.Point(694, 78);
            this.SearchPatronID.Name = "SearchPatronID";
            this.SearchPatronID.Size = new System.Drawing.Size(147, 22);
            this.SearchPatronID.TabIndex = 36;
            this.SearchPatronID.TextChanged += new System.EventHandler(this.SearchPatronID_TextChanged);
            this.SearchPatronID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchPatronID_KeyPress);
            // 
            // loadtable_txt
            // 
            this.loadtable_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.loadtable_txt.Location = new System.Drawing.Point(856, 64);
            this.loadtable_txt.Name = "loadtable_txt";
            this.loadtable_txt.Size = new System.Drawing.Size(129, 38);
            this.loadtable_txt.TabIndex = 37;
            this.loadtable_txt.Text = "Load Table";
            this.loadtable_txt.UseVisualStyleBackColor = true;
            this.loadtable_txt.Click += new System.EventHandler(this.loadtable_txt_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(302, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 41);
            this.button2.TabIndex = 54;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // delete_button
            // 
            this.delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.Location = new System.Drawing.Point(418, 429);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(110, 41);
            this.delete_button.TabIndex = 55;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // newEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 646);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.loadtable_txt);
            this.Controls.Add(this.SearchPatronID);
            this.Controls.Add(this.inputIDLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.ID_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.email);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ZipCode_txt);
            this.Controls.Add(this.State_txt);
            this.Controls.Add(this.City_txt);
            this.Controls.Add(this.Phone_txt);
            this.Controls.Add(this.Position_Combobox);
            this.Controls.Add(this.Address_txt);
            this.Controls.Add(this.LastName_txt);
            this.Controls.Add(this.FirstName_txt);
            this.Controls.Add(this.ReturntoMainMenuButton);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.PositionLabel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.ZipcodeLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LastnameLabel);
            this.Controls.Add(this.FirstnameLabel);
            this.Controls.Add(this.RegisterNewEmployeeLabel);
            this.Name = "newEmployee";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RegisterNewEmployeeLabel;
        private System.Windows.Forms.Label FirstnameLabel;
        private System.Windows.Forms.Label LastnameLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label ZipcodeLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Button ReturntoMainMenuButton;
        private System.Windows.Forms.TextBox FirstName_txt;
        private System.Windows.Forms.TextBox LastName_txt;
        private System.Windows.Forms.TextBox Address_txt;
        private System.Windows.Forms.ComboBox Position_Combobox;
        private System.Windows.Forms.TextBox Phone_txt;
        private System.Windows.Forms.TextBox City_txt;
        private System.Windows.Forms.TextBox State_txt;
        private System.Windows.Forms.TextBox ZipCode_txt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label email_txt;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ID_txt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label inputIDLabel;
        private System.Windows.Forms.TextBox SearchPatronID;
        private System.Windows.Forms.Button loadtable_txt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button delete_button;
    }
}