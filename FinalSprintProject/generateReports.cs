using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace FinalSprintProject
{
    public partial class generateReports : Form
    {

        public generateReports()
        {
            InitializeComponent();
        }

        private void ReturntoMainMenuButton_Click(object sender, EventArgs e)
        {
            DBConnect c = new DBConnect();
            int result = c.Menu_Return();

            if (result == 1)
            {
                this.Hide();
                mainMenu f1 = new mainMenu();
                f1.ShowDialog();
            }
            else if (result == 2)
            {
                this.Hide();
                employeeView f13 = new employeeView();
                f13.ShowDialog();
            }
            else if (result == 3)
            {
                this.Hide();
                managerView f12 = new managerView();
                f12.ShowDialog();
            }
            else if (result == 4)
            {
                this.Hide();
                patronView f11 = new patronView();
                f11.ShowDialog();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void GeneratePDFReportbutton_Click(object sender, EventArgs e)
        {
            var r = new Report();
            foreach (var item in listBox2.Items)
            {
               if (item.ToString() == "Events")
                {
                    r.generateEvents();
                    MessageBox.Show("Excel file saved!");
                }
                else if (item.ToString() == "Inventory")
                {
                    r.generateInventory();
                    MessageBox.Show("Excel file saved!");
                }
                else if (item.ToString() == "All Patrons")
                {
                    r.generateAllPatrons();
                    MessageBox.Show("Excel file saved!");
                }
            }
        }

        private void loadTable_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItem != null)
            {
                this.listBox2.Items.Add(this.listBox1.SelectedItem);
                this.listBox1.Items.Remove(this.listBox1.SelectedItem);
            }
        }
    }
}
