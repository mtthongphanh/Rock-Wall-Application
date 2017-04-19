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
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            inventory f8 = new inventory();
            f8.ShowDialog();
        }

        private void CalendarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            calendarNew f9 = new calendarNew();
            f9.ShowDialog();
        }

        private void WaiverButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            paperlessWaiver f2 = new paperlessWaiver();
            f2.ShowDialog();
        }

        private void NewEmployeeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            newEmployee f3 = new newEmployee();
            f3.ShowDialog();
        }

        private void SuspensionButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            suspensions f4 = new suspensions();
            f4.ShowDialog();
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            generateReports f5= new generateReports();
            f5.ShowDialog();
        }

        private void MenuTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
