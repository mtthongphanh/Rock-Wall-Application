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
    public partial class calendar : Form
    {
        public calendar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu f1 = new mainMenu();
            f1.ShowDialog();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addEvent_Click(object sender, EventArgs e)
        {
            this.Hide();
            addEvent f1 = new addEvent();
            f1.ShowDialog();

        }

        private void deleteEvent_Click(object sender, EventArgs e)
        {
            this.Hide();
            deleteEvent f1 = new deleteEvent();
            f1.ShowDialog();
        }
    }
}
