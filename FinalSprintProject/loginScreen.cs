using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalSprintProject
{
    
    
    public partial class loginScreen : Form
    {
        public loginScreen()
        {
            InitializeComponent();
        }
        private void llOpenConnAndSelect_LinkClicked(object sender,
               LinkLabelLinkClickedEventArgs e)
        {
            
        }
         
        private void vtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConnect c = new DBConnect();
            int result = c.Login(this.id.Text, this.password.Text);

            if (result == 1)
            {
                MessageBox.Show("Welcome Administrator");
                this.Hide();
                mainMenu f1 = new mainMenu();
                f1.ShowDialog();
            }
            else if (result == 2)
            {
                MessageBox.Show("Welcome Manager");
                this.Hide();
                employeeView f13 = new employeeView();
                f13.ShowDialog();
            }
            else if (result == 3)
            {
                MessageBox.Show("Welcome Employee");
                this.Hide();
                managerView f12 = new managerView();
                f12.ShowDialog();
            }
            else if (result == 4)
            {
                MessageBox.Show("Welcome Patron");
                this.Hide();
                patronView f11 = new patronView();
                f11.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong password");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
