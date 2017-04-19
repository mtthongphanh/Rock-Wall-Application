namespace FinalSprintProject
{
    partial class inventory
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
            this.searchIDTxt = new System.Windows.Forms.Label();
            this.equipTxt = new System.Windows.Forms.Label();
            this.searchIDTxtBox = new System.Windows.Forms.TextBox();
            this.equipSearch = new System.Windows.Forms.TextBox();
            this.loadTableButton = new System.Windows.Forms.Button();
            this.equipDataView = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.checkOutInv = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.Label();
            this.equipmentTxt = new System.Windows.Forms.Label();
            this.purchaseLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkOutButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.equipTxtBox = new System.Windows.Forms.TextBox();
            this.purchaseTxtBox = new System.Windows.Forms.DateTimePicker();
            this.replaceTxtBox = new System.Windows.Forms.DateTimePicker();
            this.deleteButton = new System.Windows.Forms.Button();
            this.idTxtBox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.equipDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "Search Inventory";
            // 
            // searchIDTxt
            // 
            this.searchIDTxt.AutoSize = true;
            this.searchIDTxt.Location = new System.Drawing.Point(68, 92);
            this.searchIDTxt.Name = "searchIDTxt";
            this.searchIDTxt.Size = new System.Drawing.Size(70, 17);
            this.searchIDTxt.TabIndex = 27;
            this.searchIDTxt.Text = "Search ID";
            // 
            // equipTxt
            // 
            this.equipTxt.AutoSize = true;
            this.equipTxt.Location = new System.Drawing.Point(68, 128);
            this.equipTxt.Name = "equipTxt";
            this.equipTxt.Size = new System.Drawing.Size(75, 17);
            this.equipTxt.TabIndex = 28;
            this.equipTxt.Text = "Equipment";
            // 
            // searchIDTxtBox
            // 
            this.searchIDTxtBox.Location = new System.Drawing.Point(149, 89);
            this.searchIDTxtBox.Name = "searchIDTxtBox";
            this.searchIDTxtBox.Size = new System.Drawing.Size(166, 22);
            this.searchIDTxtBox.TabIndex = 40;
            this.searchIDTxtBox.TextChanged += new System.EventHandler(this.searchIDTxtBox_TextChanged);
            // 
            // equipSearch
            // 
            this.equipSearch.Location = new System.Drawing.Point(149, 124);
            this.equipSearch.Name = "equipSearch";
            this.equipSearch.Size = new System.Drawing.Size(166, 22);
            this.equipSearch.TabIndex = 58;
            this.equipSearch.TextChanged += new System.EventHandler(this.equipSearch_TextChanged);
            // 
            // loadTableButton
            // 
            this.loadTableButton.Location = new System.Drawing.Point(321, 124);
            this.loadTableButton.Name = "loadTableButton";
            this.loadTableButton.Size = new System.Drawing.Size(119, 23);
            this.loadTableButton.TabIndex = 42;
            this.loadTableButton.Text = "Load Table";
            this.loadTableButton.Click += new System.EventHandler(this.loadTableButton_Click);
            // 
            // equipDataView
            // 
            this.equipDataView.Location = new System.Drawing.Point(71, 173);
            this.equipDataView.Name = "equipDataView";
            this.equipDataView.Size = new System.Drawing.Size(560, 337);
            this.equipDataView.TabIndex = 57;
            this.equipDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.equipDataView_CellContentClick);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(373, 551);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(258, 39);
            this.button6.TabIndex = 44;
            this.button6.Text = "Return to Main Menu";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // checkOutInv
            // 
            this.checkOutInv.AutoSize = true;
            this.checkOutInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOutInv.Location = new System.Drawing.Point(670, 44);
            this.checkOutInv.Name = "checkOutInv";
            this.checkOutInv.Size = new System.Drawing.Size(118, 29);
            this.checkOutInv.TabIndex = 45;
            this.checkOutInv.Text = "Inventory";
            // 
            // idTxt
            // 
            this.idTxt.AutoSize = true;
            this.idTxt.Location = new System.Drawing.Point(672, 94);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(21, 17);
            this.idTxt.TabIndex = 46;
            this.idTxt.Text = "ID";
            // 
            // equipmentTxt
            // 
            this.equipmentTxt.AutoSize = true;
            this.equipmentTxt.Location = new System.Drawing.Point(672, 126);
            this.equipmentTxt.Name = "equipmentTxt";
            this.equipmentTxt.Size = new System.Drawing.Size(75, 17);
            this.equipmentTxt.TabIndex = 47;
            this.equipmentTxt.Text = "Equipment";
            // 
            // purchaseLabel
            // 
            this.purchaseLabel.AutoSize = true;
            this.purchaseLabel.Location = new System.Drawing.Point(672, 164);
            this.purchaseLabel.Name = "purchaseLabel";
            this.purchaseLabel.Size = new System.Drawing.Size(102, 17);
            this.purchaseLabel.TabIndex = 48;
            this.purchaseLabel.Text = "Purchase Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(672, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "Replacement Date";
            // 
            // checkOutButton
            // 
            this.checkOutButton.Location = new System.Drawing.Point(675, 258);
            this.checkOutButton.Name = "checkOutButton";
            this.checkOutButton.Size = new System.Drawing.Size(132, 29);
            this.checkOutButton.TabIndex = 50;
            this.checkOutButton.Text = "Insert";
            this.checkOutButton.UseVisualStyleBackColor = true;
            this.checkOutButton.Click += new System.EventHandler(this.checkOutButton_Click_1);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(826, 258);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(126, 29);
            this.updateButton.TabIndex = 51;
            this.updateButton.Text = "Update";
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // equipTxtBox
            // 
            this.equipTxtBox.Location = new System.Drawing.Point(802, 128);
            this.equipTxtBox.Name = "equipTxtBox";
            this.equipTxtBox.Size = new System.Drawing.Size(240, 22);
            this.equipTxtBox.TabIndex = 53;
            // 
            // purchaseTxtBox
            // 
            this.purchaseTxtBox.CustomFormat = "yyyy-MM-dd";
            this.purchaseTxtBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.purchaseTxtBox.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.purchaseTxtBox.Location = new System.Drawing.Point(802, 164);
            this.purchaseTxtBox.Name = "purchaseTxtBox";
            this.purchaseTxtBox.Size = new System.Drawing.Size(240, 22);
            this.purchaseTxtBox.TabIndex = 54;
            this.purchaseTxtBox.Value = new System.DateTime(2017, 3, 27, 0, 0, 0, 0);
            // 
            // replaceTxtBox
            // 
            this.replaceTxtBox.CustomFormat = "yyyy-MM-dd";
            this.replaceTxtBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.replaceTxtBox.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.replaceTxtBox.Location = new System.Drawing.Point(803, 204);
            this.replaceTxtBox.Name = "replaceTxtBox";
            this.replaceTxtBox.Size = new System.Drawing.Size(239, 22);
            this.replaceTxtBox.TabIndex = 55;
            this.replaceTxtBox.Value = new System.DateTime(2017, 3, 28, 17, 13, 17, 0);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(969, 258);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(125, 29);
            this.deleteButton.TabIndex = 56;
            this.deleteButton.Text = "Delete";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // idTxtBox
            // 
            this.idTxtBox.AutoSize = true;
            this.idTxtBox.Location = new System.Drawing.Point(803, 94);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.Size = new System.Drawing.Size(0, 17);
            this.idTxtBox.TabIndex = 59;
            // 
            // inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 637);
            this.Controls.Add(this.idTxtBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.replaceTxtBox);
            this.Controls.Add(this.purchaseTxtBox);
            this.Controls.Add(this.equipTxtBox);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.checkOutButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.purchaseLabel);
            this.Controls.Add(this.equipmentTxt);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.checkOutInv);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.equipDataView);
            this.Controls.Add(this.loadTableButton);
            this.Controls.Add(this.equipSearch);
            this.Controls.Add(this.searchIDTxtBox);
            this.Controls.Add(this.equipTxt);
            this.Controls.Add(this.searchIDTxt);
            this.Controls.Add(this.label1);
            this.Name = "inventory";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label searchIDTxt;
        private System.Windows.Forms.Label equipTxt;
        private System.Windows.Forms.TextBox searchIDTxtBox;
        private System.Windows.Forms.TextBox equipSearch;
        private System.Windows.Forms.Button loadTableButton;
        private System.Windows.Forms.DataGridView equipDataView;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label checkOutInv;
        private System.Windows.Forms.Label idTxt;
        private System.Windows.Forms.Label equipmentTxt;
        private System.Windows.Forms.Label purchaseLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button checkOutButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox equipTxtBox;
        private System.Windows.Forms.DateTimePicker purchaseTxtBox;
        private System.Windows.Forms.DateTimePicker replaceTxtBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label idTxtBox;
    }
}