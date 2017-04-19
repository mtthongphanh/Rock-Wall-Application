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


namespace FinalSprintProject
{
    public partial class calendarNew : Form
    {

        DataTable dbdataset;

        public calendarNew()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        void loadDataBtn_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=3a1w";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand("SELECT * FROM sample_table.event ;", conDatabase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                eventsDataGrid.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DBConnect c = new DBConnect();

            c.AddEvent(this.date.Text, this.name.Text, this.memo.Text);

            MessageBox.Show("Event saved");

            
        }

        private void eventsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.eventsDataGrid.Rows[e.RowIndex];
                ID.Text = row.Cells["id"].Value.ToString();
                name.Text = row.Cells["name"].Value.ToString();
                date.Text = row.Cells["date"].Value.ToString();
                memo.Text = row.Cells["memo"].Value.ToString();
            }
     
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            string constring = "datasource=localhost;port=3306;username=root;password=3a1w";
            string Query = "delete from sample_table.event where id = '" + this.ID.Text + "' and date = '"+this.date.Text+"' and memo = '"+this.memo.Text+"'";
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
                MessageBox.Show("Event deleted");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {

            string constring = "datasource=localhost;port=3306;username=root;password=3a1w";
            string Query = "update sample_table.event set id='" + this.ID.Text + "',name='" + this.name.Text +"', date='" +this.date.Text +"', memo='"+this.memo.Text +"' where id='"+this.ID.Text+"' ;";


   
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
                MessageBox.Show("Event updated");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void searchEventName_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
            // DV.RowFilter = name + "like '%"+ searchEventName.Text + "%'";
            DV.RowFilter = string.Format(" name LIKE '%{0}%'", searchEventName.Text);
            eventsDataGrid.DataSource = DV;
        }

        private void EventsLabel_Click(object sender, EventArgs e)
        {
           

        }

        private void searchEventDate_TextChanged(object sender, EventArgs e)
        {


        }

        private void searchEvenDate_Click(object sender, EventArgs e)
        {

        }

        private void DescriptionTextBar_TextChanged(object sender, EventArgs e)
        {
            DataView DVC = new DataView(dbdataset);
            // DV.RowFilter = name + "like '%"+ searchEventName.Text + "%'";
            DVC.RowFilter = string.Format(" memo LIKE '%{0}%'", DescriptionTextBar.Text);
            eventsDataGrid.DataSource = DVC;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void calendarNew_Load(object sender, EventArgs e)
        {

        }
    }
}
