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
    public partial class suspensions : Form
    {
        public suspensions()
        {
            InitializeComponent();
            Password_txt.PasswordChar = '*';
        }

        DataTable dbdataset;
        bool suspend;
        bool warningSuspend;

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

        private void LoadTalbe_txt_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=3a1w";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand("SELECT ID, firstname, lastname, email, warningSuspension AS 'Warning Suspension', suspended FROM sample_table.personal_info_table ;", conDatabase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                // creates a copy of the data set (clone) //

                DataTable dtCloned = dbdataset.Clone();

                // change the data type of the specific row //
                dtCloned.Columns["suspended"].DataType = typeof(String);
                
                // copying the contents of the dataset
                foreach (DataRow row in dbdataset.Rows)
                {
                    dtCloned.ImportRow(row);
                }


                foreach (DataRow row in dtCloned.Rows)
                {
                    // check if the suspended flag to a user friendly value //
                    if (row["suspended"].ToString() == "1")
                    {
                        row["suspended"] = "YES";
                    }
                    else
                    {
                        row["suspended"] = "NO";
                    }
                }
                bSource.DataSource = dtCloned;
                PatronProfileView.DataSource = bSource;

                //sda.Update(dtCloned);
                /*bSource.DataSource = dbdataset;
                PatronProfileView.DataSource = bSource;
                sda.Update(dbdataset);*/
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
            PatronProfileView.DataSource = DV;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void GenerateEmailButton_Click(object sender, EventArgs e)
        {

            if(smtpServerCombo.Text == "smtp.office365.com" || smtpServerCombo.Text == "smtp.gmail.com" )
            {
                MailMessage mail = new MailMessage(From_txt.Text, to_txt.Text, Subject_txt.Text, body_txt.Text);
                SmtpClient client = new SmtpClient(smtpServerCombo.Text);

                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential(UserName_txt.Text, Password_txt.Text);

                client.EnableSsl = true;
                client.Send(mail);

                MessageBox.Show(" Mail Sent! Success");
            }

            else if(smtpServerCombo.Text == "smtp.mail.yahoo.com")
            {
                MailMessage mail = new MailMessage(From_txt.Text, to_txt.Text, Subject_txt.Text, body_txt.Text);
                SmtpClient client = new SmtpClient(smtpServerCombo.Text);

                client.Port = 465;
                client.Credentials = new System.Net.NetworkCredential(UserName_txt.Text, Password_txt.Text);

                client.EnableSsl = true;
                client.Send(mail);

                MessageBox.Show(" Mail Sent! Success");
            }
           
        }

        private void PatronProfileView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {         
        }

        private void Password_txt_TextChanged(object sender, EventArgs e)
        {
        }

        private void upadateButton_Click(object sender, EventArgs e)
        {
            DBConnect c = new DBConnect();
            c.UpdateSuspension(suspend, SearchPatronID.Text);     
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            suspend = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            suspend = false;
        }

        private void updateWarningButton_Click(object sender, EventArgs e)
        {
            DBConnect c = new DBConnect();
            c.UpdateWarningSuspension(warningSuspend, SearchPatronID.Text);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            warningSuspend = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            warningSuspend = false;
        }

        private void SearchPatronID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void SearchPatronID_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void to_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void smtpServerCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
