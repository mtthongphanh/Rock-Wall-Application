namespace FinalSprintProject
{
    partial class generateReports
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
            this.ReportsLabel = new System.Windows.Forms.Label();
            this.GeneratePDFReportbutton = new System.Windows.Forms.Button();
            this.ReturntoMainMenuButton = new System.Windows.Forms.Button();
            this.loadTable = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ReportsLabel
            // 
            this.ReportsLabel.Location = new System.Drawing.Point(0, 0);
            this.ReportsLabel.Name = "ReportsLabel";
            this.ReportsLabel.Size = new System.Drawing.Size(100, 23);
            this.ReportsLabel.TabIndex = 11;
            // 
            // GeneratePDFReportbutton
            // 
            this.GeneratePDFReportbutton.Location = new System.Drawing.Point(587, 358);
            this.GeneratePDFReportbutton.Name = "GeneratePDFReportbutton";
            this.GeneratePDFReportbutton.Size = new System.Drawing.Size(227, 34);
            this.GeneratePDFReportbutton.TabIndex = 5;
            this.GeneratePDFReportbutton.Text = "Generate Excel File";
            this.GeneratePDFReportbutton.UseVisualStyleBackColor = true;
            this.GeneratePDFReportbutton.Click += new System.EventHandler(this.GeneratePDFReportbutton_Click);
            // 
            // ReturntoMainMenuButton
            // 
            this.ReturntoMainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturntoMainMenuButton.Location = new System.Drawing.Point(298, 473);
            this.ReturntoMainMenuButton.Name = "ReturntoMainMenuButton";
            this.ReturntoMainMenuButton.Size = new System.Drawing.Size(278, 59);
            this.ReturntoMainMenuButton.TabIndex = 10;
            this.ReturntoMainMenuButton.Text = "Return to Main Menu";
            this.ReturntoMainMenuButton.UseVisualStyleBackColor = true;
            this.ReturntoMainMenuButton.Click += new System.EventHandler(this.ReturntoMainMenuButton_Click);
            // 
            // loadTable
            // 
            this.loadTable.Location = new System.Drawing.Point(91, 358);
            this.loadTable.Name = "loadTable";
            this.loadTable.Size = new System.Drawing.Size(227, 34);
            this.loadTable.TabIndex = 12;
            this.loadTable.Text = "Load Table";
            this.loadTable.UseVisualStyleBackColor = true;
            this.loadTable.Click += new System.EventHandler(this.loadTable_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(29, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Reports";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Events",
            "Inventory",
            "All Patrons"});
            this.listBox1.Location = new System.Drawing.Point(46, 134);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(366, 212);
            this.listBox1.TabIndex = 15;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(540, 134);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(366, 212);
            this.listBox2.TabIndex = 16;
            // 
            // generateReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 580);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadTable);
            this.Controls.Add(this.ReturntoMainMenuButton);
            this.Controls.Add(this.GeneratePDFReportbutton);
            this.Controls.Add(this.ReportsLabel);
            this.Name = "generateReports";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ReportsLabel;
        private System.Windows.Forms.Button GeneratePDFReportbutton;
        private System.Windows.Forms.Button ReturntoMainMenuButton;
        private System.Windows.Forms.Button loadTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}