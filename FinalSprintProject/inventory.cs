using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Web;
using System.Net.Mail;

namespace FinalSprintProject
{
    public partial class inventory : Form
    {
        public inventory()
        {
            InitializeComponent();
        }

        DataTable dbdataset;

        private void loadTableButton_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=3a1w";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand("SELECT * FROM sample_table.inventory ;", conDatabase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                equipDataView.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=3a1w";
            string Query = "update sample_table.inventory set invID= '" + this.idTxtBox.Text + "', invDesc='" + this.equipTxtBox.Text + "', invPurchase='" + this.purchaseTxtBox.Text + "' , invReplace='" + this.replaceTxtBox.Text + "' where invID='" + this.idTxtBox.Text + "'";

            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;
            try
            {
                conDatabase.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {

                }
                MessageBox.Show("Inventory updated!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            DBConnect c = new DBConnect();

            c.Delete_Inventory(this.idTxtBox.Text);


        }


        private void checkOutButton_Click_1(object sender, EventArgs e)
        {
            DBConnect c = new DBConnect();

            c.Insert_Inventory( this.equipTxtBox.Text, this.purchaseTxtBox.Text,
                    this.replaceTxtBox.Text);
            MessageBox.Show("Inventory added!");

        }

        private void searchIDTxtBox_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
            //DV.RowFilter = string.Format("invID LIKE '%{0}%'", searchIDTxtBox.Text);
            DV.RowFilter = "Convert(invID, 'System.String') like '%" + searchIDTxtBox.Text + "%'";
            equipDataView.DataSource = DV;
        }

        private void equipSearch_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("invDesc LIKE '%{0}%'", equipSearch.Text);
            equipDataView.DataSource = DV;
        }
        private void button6_Click_1(object sender, EventArgs e)
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

        private void equipDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.equipDataView.Rows[e.RowIndex];
                idTxtBox.Text = row.Cells["invID"].Value.ToString();
                equipTxtBox.Text = row.Cells["invDesc"].Value.ToString();
                purchaseTxtBox.Text = row.Cells["invPurchase"].Value.ToString();
                replaceTxtBox.Text = row.Cells["invReplace"].Value.ToString();

            }
        }

        private void idTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void inventory_Load(object sender, EventArgs e)
        {

        }
    }
}
