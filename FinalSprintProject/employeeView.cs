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
    public partial class employeeView : Form
    {
        public employeeView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            paperlessWaiver f2 = new paperlessWaiver();
            f2.ShowDialog();
        }

        private void SuspensionButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            suspensions f4 = new suspensions();
            f4.ShowDialog();
        }

        private void CalendarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            calendarNew f9 = new calendarNew();
            f9.ShowDialog();
        }
    }
}
