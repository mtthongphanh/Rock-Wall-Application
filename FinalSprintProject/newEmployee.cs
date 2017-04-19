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

namespace FinalSprintProject
{
    public partial class newEmployee : Form
    {
        public newEmployee()
        {
            InitializeComponent();
            load_table();


        }

        DataTable dbdataset;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void FirstName_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastName_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            DBConnect c = new DBConnect();

            c.Insert_Employee( this.ID_txt.Text, this.password_txt.Text, this.FirstName_txt.Text, this.LastName_txt.Text, this.dateTimePicker1.Text,
                 this.Address_txt.Text, this.City_txt.Text, this.State_txt.Text, 
                 this.ZipCode_txt.Text, this.Phone_txt.Text, this.email.Text, this.Position_Combobox.Text
                 );
           // this.Hide();
          //  Form1 f1 = new Form1();
          //  f1.ShowDialog();
        }

        private void Phone_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ID_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void loadtable_txt_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=3a1w";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand("SELECT ID, firstname, lastname, birthday, address, city, state, zip, phone, password,email, isPatron, isEmployee, isManager, isAdmin FROM sample_table.personal_info_table ;", conDatabase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        void load_table()
        {
            string constring = "datasource=localhost;port=3306;username=root;password=3a1w";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand("SELECT ID, firstname, lastname, birthday, address, city, state, zip, phone, password,email, isPatron, isEmployee, isManager, isAdmin FROM sample_table.personal_info_table ;", conDatabase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchPatronID_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = "Convert(ID, 'System.String') like '%" + SearchPatronID.Text + "%'";
            dataGridView1.DataSource = DV;
        }

        private void SearchPatronID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if( e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                ID_txt.Text = row.Cells["id"].Value.ToString();
                password_txt.Text = row.Cells["password"].Value.ToString();
                FirstName_txt.Text = row.Cells["firstname"].Value.ToString();
                LastName_txt.Text = row.Cells["lastname"].Value.ToString();
                dateTimePicker1.Text = row.Cells["birthday"].Value.ToString();
                Address_txt.Text = row.Cells["address"].Value.ToString();
                City_txt.Text = row.Cells["city"].Value.ToString();
                State_txt.Text = row.Cells["state"].Value.ToString();
                ZipCode_txt.Text = row.Cells["zip"].Value.ToString();
                Phone_txt.Text = row.Cells["phone"].Value.ToString();
                email.Text = row.Cells["email"].Value.ToString();
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            DBConnect c = new DBConnect();

            c.Delete_Employee(this.ID_txt.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBConnect c = new DBConnect();

            c.Update_Employee(this.ID_txt.Text, this.password_txt.Text, this.FirstName_txt.Text, this.LastName_txt.Text, this.dateTimePicker1.Text,
                 this.Address_txt.Text, this.City_txt.Text, this.State_txt.Text,
                 this.ZipCode_txt.Text, this.Phone_txt.Text, this.email.Text, this.Position_Combobox.Text
                 );
        }
    }
}
