using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace FinalSprintProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Application.Run(new calendar());
            //Application.Run(new suspensions());
            Application.Run(new loginScreen());

           // Application.Run(new calendarNew());
            //Application.Run(new paperlessWaiver());


            //DBConnect c = new DBConnect();
            //string query = "INSERT INTO Persons (LastName, FirstName, Address, City) VALUES('ethen','lee','3a1w','brookings')";
            //c.Insert("INSERT INTO Persons(LastName, FirstName, Address, Email, Telephone,PW) VALUES('Manki','Min','123','Volga,SD','535653','123')");
        }
    }
}
