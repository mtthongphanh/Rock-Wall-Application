namespace FinalSprintProject
{
    partial class calendarNew
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
            this.EventsLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.dataTxt = new System.Windows.Forms.Label();
            this.memo = new System.Windows.Forms.RichTextBox();
            this.eventsDataGrid = new System.Windows.Forms.DataGridView();
            this.addEvents = new System.Windows.Forms.Label();
            this.eventTxt = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.searchEventLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchEventName = new System.Windows.Forms.TextBox();
            this.addEventName = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.loadDataBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.DescriptionTextBar = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // EventsLabel
            // 
            this.EventsLabel.AutoSize = true;
            this.EventsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventsLabel.Location = new System.Drawing.Point(25, 29);
            this.EventsLabel.Name = "EventsLabel";
            this.EventsLabel.Size = new System.Drawing.Size(180, 29);
            this.EventsLabel.TabIndex = 1;
            this.EventsLabel.Text = "Search Events";
            this.EventsLabel.Click += new System.EventHandler(this.EventsLabel_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(368, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 56);
            this.button1.TabIndex = 4;
            this.button1.Text = "Return to Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataTxt
            // 
            this.dataTxt.AutoSize = true;
            this.dataTxt.Location = new System.Drawing.Point(569, 167);
            this.dataTxt.Name = "dataTxt";
            this.dataTxt.Size = new System.Drawing.Size(78, 17);
            this.dataTxt.TabIndex = 9;
            this.dataTxt.Text = "Event Date";
            // 
            // memo
            // 
            this.memo.Location = new System.Drawing.Point(694, 201);
            this.memo.Name = "memo";
            this.memo.Size = new System.Drawing.Size(258, 173);
            this.memo.TabIndex = 10;
            this.memo.Text = "";
            // 
            // eventsDataGrid
            // 
            this.eventsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventsDataGrid.Location = new System.Drawing.Point(30, 167);
            this.eventsDataGrid.Name = "eventsDataGrid";
            this.eventsDataGrid.RowTemplate.Height = 24;
            this.eventsDataGrid.Size = new System.Drawing.Size(493, 252);
            this.eventsDataGrid.TabIndex = 11;
            this.eventsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventsDataGrid_CellContentClick);
            // 
            // addEvents
            // 
            this.addEvents.AutoSize = true;
            this.addEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEvents.Location = new System.Drawing.Point(563, 29);
            this.addEvents.Name = "addEvents";
            this.addEvents.Size = new System.Drawing.Size(91, 29);
            this.addEvents.TabIndex = 16;
            this.addEvents.Text = "Events";
            // 
            // eventTxt
            // 
            this.eventTxt.AutoSize = true;
            this.eventTxt.Location = new System.Drawing.Point(569, 204);
            this.eventTxt.Name = "eventTxt";
            this.eventTxt.Size = new System.Drawing.Size(119, 17);
            this.eventTxt.TabIndex = 18;
            this.eventTxt.Text = "Event Description";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(572, 387);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(129, 32);
            this.saveButton.TabIndex = 19;
            this.saveButton.Text = "Insert";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(742, 387);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(129, 32);
            this.editButton.TabIndex = 21;
            this.editButton.Text = "Update";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // searchEventLabel
            // 
            this.searchEventLabel.AutoSize = true;
            this.searchEventLabel.Location = new System.Drawing.Point(27, 111);
            this.searchEventLabel.Name = "searchEventLabel";
            this.searchEventLabel.Size = new System.Drawing.Size(168, 17);
            this.searchEventLabel.TabIndex = 23;
            this.searchEventLabel.Text = "Search Event Description";
            this.searchEventLabel.Click += new System.EventHandler(this.searchEvenDate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Search Event Name";
            // 
            // searchEventName
            // 
            this.searchEventName.Location = new System.Drawing.Point(211, 72);
            this.searchEventName.Name = "searchEventName";
            this.searchEventName.Size = new System.Drawing.Size(167, 22);
            this.searchEventName.TabIndex = 27;
            this.searchEventName.TextChanged += new System.EventHandler(this.searchEventName_TextChanged);
            // 
            // addEventName
            // 
            this.addEventName.AutoSize = true;
            this.addEventName.Location = new System.Drawing.Point(569, 129);
            this.addEventName.Name = "addEventName";
            this.addEventName.Size = new System.Drawing.Size(85, 17);
            this.addEventName.TabIndex = 28;
            this.addEventName.Text = "Event Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(694, 126);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(249, 22);
            this.name.TabIndex = 29;
            // 
            // loadDataBtn
            // 
            this.loadDataBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.loadDataBtn.Location = new System.Drawing.Point(384, 105);
            this.loadDataBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loadDataBtn.Name = "loadDataBtn";
            this.loadDataBtn.Size = new System.Drawing.Size(139, 27);
            this.loadDataBtn.TabIndex = 30;
            this.loadDataBtn.Text = "Load Table";
            this.loadDataBtn.UseVisualStyleBackColor = true;
            this.loadDataBtn.Click += new System.EventHandler(this.loadDataBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(901, 387);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(129, 31);
            this.deleteBtn.TabIndex = 31;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // date
            // 
            this.date.CustomFormat = "yyyy-MM-dd";
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.date.Location = new System.Drawing.Point(694, 162);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(249, 22);
            this.date.TabIndex = 32;
            // 
            // DescriptionTextBar
            // 
            this.DescriptionTextBar.Location = new System.Drawing.Point(211, 106);
            this.DescriptionTextBar.Name = "DescriptionTextBar";
            this.DescriptionTextBar.Size = new System.Drawing.Size(167, 22);
            this.DescriptionTextBar.TabIndex = 33;
            this.DescriptionTextBar.TextChanged += new System.EventHandler(this.DescriptionTextBar_TextChanged);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(691, 86);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(0, 17);
            this.ID.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(572, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Event ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // calendarNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 524);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.DescriptionTextBar);
            this.Controls.Add(this.date);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.loadDataBtn);
            this.Controls.Add(this.name);
            this.Controls.Add(this.addEventName);
            this.Controls.Add(this.searchEventName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchEventLabel);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.eventTxt);
            this.Controls.Add(this.addEvents);
            this.Controls.Add(this.eventsDataGrid);
            this.Controls.Add(this.memo);
            this.Controls.Add(this.dataTxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EventsLabel);
            this.Name = "calendarNew";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.calendarNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label EventsLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label dataTxt;
        private System.Windows.Forms.RichTextBox memo;
        private System.Windows.Forms.DataGridView eventsDataGrid;
        private System.Windows.Forms.Label addEvents;
        private System.Windows.Forms.Label eventTxt;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label searchEventLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchEventName;
        private System.Windows.Forms.Label addEventName;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button loadDataBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox DescriptionTextBar;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label3;
    }
}