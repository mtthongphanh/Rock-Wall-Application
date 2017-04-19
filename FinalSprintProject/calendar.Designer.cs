namespace FinalSprintProject
{
    partial class calendar
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
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Events = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.addEvent = new System.Windows.Forms.Button();
            this.deleteEvent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calendar";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(56, 128);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(73, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 56);
            this.button1.TabIndex = 4;
            this.button1.Text = "Return to Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Events});
            this.listView1.ForeColor = System.Drawing.Color.Black;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(378, 128);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(215, 207);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Events
            // 
            this.Events.Text = "Events";
            this.Events.Width = 137;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(384, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Event list";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // addEvent
            // 
            this.addEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEvent.Location = new System.Drawing.Point(378, 398);
            this.addEvent.Name = "addEvent";
            this.addEvent.Size = new System.Drawing.Size(125, 39);
            this.addEvent.TabIndex = 7;
            this.addEvent.Text = "Add event";
            this.addEvent.UseVisualStyleBackColor = true;
            this.addEvent.Click += new System.EventHandler(this.addEvent_Click);
            // 
            // deleteEvent
            // 
            this.deleteEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteEvent.Location = new System.Drawing.Point(522, 398);
            this.deleteEvent.Name = "deleteEvent";
            this.deleteEvent.Size = new System.Drawing.Size(125, 39);
            this.deleteEvent.TabIndex = 7;
            this.deleteEvent.Text = "Delete event";
            this.deleteEvent.UseVisualStyleBackColor = true;
            this.deleteEvent.Click += new System.EventHandler(this.deleteEvent_Click);
            // 
            // calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 524);
            this.Controls.Add(this.deleteEvent);
            this.Controls.Add(this.addEvent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label1);
            this.Name = "calendar";
            this.Text = "Form9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Events;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addEvent;
        private System.Windows.Forms.Button deleteEvent;
    }
}