namespace FinalSprintProject
{
    partial class mainMenu
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
            this.WaiverButton = new System.Windows.Forms.Button();
            this.NewEmployeeButton = new System.Windows.Forms.Button();
            this.SuspensionButton = new System.Windows.Forms.Button();
            this.ReportsButton = new System.Windows.Forms.Button();
            this.EquipmentCheckoutButton = new System.Windows.Forms.Button();
            this.CalendarButton = new System.Windows.Forms.Button();
            this.MenuTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WaiverButton
            // 
            this.WaiverButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaiverButton.Location = new System.Drawing.Point(104, 156);
            this.WaiverButton.Name = "WaiverButton";
            this.WaiverButton.Size = new System.Drawing.Size(161, 53);
            this.WaiverButton.TabIndex = 0;
            this.WaiverButton.Text = "Waiver";
            this.WaiverButton.UseVisualStyleBackColor = true;
            this.WaiverButton.Click += new System.EventHandler(this.WaiverButton_Click);
            // 
            // NewEmployeeButton
            // 
            this.NewEmployeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewEmployeeButton.Location = new System.Drawing.Point(104, 237);
            this.NewEmployeeButton.Name = "NewEmployeeButton";
            this.NewEmployeeButton.Size = new System.Drawing.Size(161, 50);
            this.NewEmployeeButton.TabIndex = 1;
            this.NewEmployeeButton.Text = "New User";
            this.NewEmployeeButton.UseVisualStyleBackColor = true;
            this.NewEmployeeButton.Click += new System.EventHandler(this.NewEmployeeButton_Click);
            // 
            // SuspensionButton
            // 
            this.SuspensionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuspensionButton.Location = new System.Drawing.Point(104, 320);
            this.SuspensionButton.Name = "SuspensionButton";
            this.SuspensionButton.Size = new System.Drawing.Size(161, 48);
            this.SuspensionButton.TabIndex = 2;
            this.SuspensionButton.Text = "Suspension";
            this.SuspensionButton.UseVisualStyleBackColor = true;
            this.SuspensionButton.Click += new System.EventHandler(this.SuspensionButton_Click);
            // 
            // ReportsButton
            // 
            this.ReportsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportsButton.Location = new System.Drawing.Point(320, 236);
            this.ReportsButton.Name = "ReportsButton";
            this.ReportsButton.Size = new System.Drawing.Size(170, 51);
            this.ReportsButton.TabIndex = 3;
            this.ReportsButton.Text = "Reports";
            this.ReportsButton.UseVisualStyleBackColor = true;
            this.ReportsButton.Click += new System.EventHandler(this.ReportsButton_Click);
            // 
            // EquipmentCheckoutButton
            // 
            this.EquipmentCheckoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EquipmentCheckoutButton.Location = new System.Drawing.Point(320, 320);
            this.EquipmentCheckoutButton.Name = "EquipmentCheckoutButton";
            this.EquipmentCheckoutButton.Size = new System.Drawing.Size(170, 48);
            this.EquipmentCheckoutButton.TabIndex = 6;
            this.EquipmentCheckoutButton.Text = "Inventory";
            this.EquipmentCheckoutButton.UseVisualStyleBackColor = true;
            this.EquipmentCheckoutButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // CalendarButton
            // 
            this.CalendarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalendarButton.Location = new System.Drawing.Point(320, 156);
            this.CalendarButton.Name = "CalendarButton";
            this.CalendarButton.Size = new System.Drawing.Size(170, 51);
            this.CalendarButton.TabIndex = 7;
            this.CalendarButton.Text = "Events";
            this.CalendarButton.UseVisualStyleBackColor = true;
            this.CalendarButton.Click += new System.EventHandler(this.CalendarButton_Click);
            // 
            // MenuTitle
            // 
            this.MenuTitle.AutoSize = true;
            this.MenuTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuTitle.Location = new System.Drawing.Point(42, 58);
            this.MenuTitle.Name = "MenuTitle";
            this.MenuTitle.Size = new System.Drawing.Size(549, 36);
            this.MenuTitle.TabIndex = 8;
            this.MenuTitle.Text = "SDSU Wellness Center Climbing Wall";
            this.MenuTitle.Click += new System.EventHandler(this.MenuTitle_Click);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 575);
            this.Controls.Add(this.MenuTitle);
            this.Controls.Add(this.CalendarButton);
            this.Controls.Add(this.EquipmentCheckoutButton);
            this.Controls.Add(this.ReportsButton);
            this.Controls.Add(this.SuspensionButton);
            this.Controls.Add(this.NewEmployeeButton);
            this.Controls.Add(this.WaiverButton);
            this.Name = "mainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WaiverButton;
        private System.Windows.Forms.Button NewEmployeeButton;
        private System.Windows.Forms.Button SuspensionButton;
        private System.Windows.Forms.Button ReportsButton;
        private System.Windows.Forms.Button EquipmentCheckoutButton;
        private System.Windows.Forms.Button CalendarButton;
        private System.Windows.Forms.Label MenuTitle;
    }
}