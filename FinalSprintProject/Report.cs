using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Web;
using ClosedXML.Excel;

namespace FinalSprintProject
{
    class Report
    {
        DataTable dbdataset;

        public void generateMasterReport()
        {
            var workBook = new XLWorkbook();
            List<IXLWorksheet> workSheets = new List<IXLWorksheet>();
            workSheets.Add(workBook.Worksheets.Add("Event"));
            workSheets.Add(workBook.Worksheets.Add("Inventory"));
            initialSetUp(workBook, workSheets);
            inventorySetUp(workBook, workSheets);
            eventSetUp(workBook, workSheets);
            patronsSetup(workBook, workSheets);
            //suspensionsSetUp(workBook, workSheets);
            String fileName = String.Format("Master Report {0} {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString());
            Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            fileName = rgx.Replace(fileName, "");
            workBook.SaveAs(String.Format("{0}.xlsx", fileName));
        }

        private void initialSetUp(XLWorkbook workbook, List<IXLWorksheet> workSheets)
        {
            workSheets[0].Cell("A1").Value = "Item ID";
            workSheets[0].Cell("A1").Style.Font.Bold = true;
            workSheets[0].Cell("B1").Value = "Item Name";
            workSheets[0].Cell("B1").Style.Font.Bold = true;
            workSheets[0].Cell("C1").Value = "Uses Left";
            workSheets[0].Cell("C1").Style.Font.Bold = true;
            workSheets[0].Cell("D1").Value = "Is Checked Out";

            workSheets[0].Cell("A1").Value = "ID";
            workSheets[0].Cell("A1").Style.Font.Bold = true;
            workSheets[0].Cell("B1").Value = "Name";
            workSheets[0].Cell("B1").Style.Font.Bold = true;
            workSheets[0].Cell("C1").Value = "Date";
            workSheets[0].Cell("C1").Style.Font.Bold = true;
            workSheets[0].Cell("D1").Value = "Memo";
            workSheets[0].Columns().AdjustToContents();
            workSheets[0].Rows().AdjustToContents();

            workSheets[0].Cell("A1").Value = "ID";
            workSheets[0].Cell("A1").Style.Font.Bold = true;
            workSheets[0].Cell("B1").Value = "First Name";
            workSheets[0].Cell("B1").Style.Font.Bold = true;
            workSheets[0].Cell("C1").Value = "Last Name";
            workSheets[0].Cell("C1").Style.Font.Bold = true;
            workSheets[0].Cell("D1").Value = "Birthday";
            workSheets[0].Cell("D1").Style.Font.Bold = true;
            workSheets[0].Cell("E1").Value = "Address";
            workSheets[0].Cell("E1").Style.Font.Bold = true;
            workSheets[0].Cell("F1").Value = "City";
            workSheets[0].Cell("F1").Style.Font.Bold = true;
            workSheets[0].Cell("G1").Value = "State";
            workSheets[0].Cell("G1").Style.Font.Bold = true;
            workSheets[0].Cell("H1").Value = "ZIP";
            workSheets[0].Cell("H1").Style.Font.Bold = true;
            workSheets[0].Cell("I1").Value = "Phone";
            workSheets[0].Cell("I1").Style.Font.Bold = true;
            workSheets[0].Cell("J1").Value = "Email";
            workSheets[0].Cell("J1").Style.Font.Bold = true;
            workSheets[0].Cell("K1").Value = "Is Patron";
            workSheets[0].Cell("K1").Style.Font.Bold = true;
            workSheets[0].Cell("L1").Value = "Is Employee";
            workSheets[0].Cell("L1").Style.Font.Bold = true;
            workSheets[0].Cell("M1").Value = "Is Manager";
            workSheets[0].Cell("M1").Style.Font.Bold = true;
            workSheets[0].Cell("N1").Value = "Is Admin";
            workSheets[0].Cell("N1").Style.Font.Bold = true;
            workSheets[0].Cell("O1").Value = "Warning Suspension";
            workSheets[0].Cell("O1").Style.Font.Bold = true;
            workSheets[0].Cell("P1").Value = "Suspended";
            workSheets[0].Cell("P1").Style.Font.Bold = true;
            workSheets[0].Cell("Q1").Value = "Password";
            workSheets[0].Cell("Q1").Style.Font.Bold = true;
            workSheets[0].Cell("R1").Value = "Waiver ID";
            workSheets[0].Cell("R1").Style.Font.Bold = true;
            workSheets[0].Cell("S1").Value = "Inventory ID";
            workSheets[0].Cell("S1").Style.Font.Bold = true;
            workSheets[0].Columns().AdjustToContents();
            workSheets[0].Rows().AdjustToContents();


        }

        private void inventorySetUp(XLWorkbook workbook, List<IXLWorksheet> workSheets)
        {
            var workBook = new XLWorkbook();
            //List<IXLWorksheet> workSheets = new List<IXLWorksheet>();
            string constring = "datasource=localhost;port=3306;username=root;password=3a1w";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand("SELECT * FROM sample_table.inventory;", conDatabase);


            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = cmdDatabase;
            dbdataset = new DataTable();
            sda.Fill(dbdataset);
            StringBuilder cell = new StringBuilder("A2");

            //put headers in 
            for (int i = 0; i < dbdataset.Rows.Count; i++)
            {
                for (int j = 0; j < dbdataset.Columns.Count; j++)
                {
                    workSheets[0].Cell(cell.ToString()).Value = dbdataset.Rows[i][j];
                    cell[0] = (char)((int)(cell[0]) + 1);

                }
                
				if (i > 0)
                {
                    cell = new StringBuilder('A' + (i + 3).ToString());
                }
                else
                {
                    cell = new StringBuilder("A3");
                }
            }

            String fileName = String.Format("Inventory Report {0} {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString());
            Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            fileName = rgx.Replace(fileName, "");
            workBook.SaveAs(String.Format("{0}.xlsx", fileName));

        }

         public void generateInventory()
         {
            var workBook = new XLWorkbook();
            List<IXLWorksheet> workSheets = new List<IXLWorksheet>();
            workSheets.Add(workBook.Worksheets.Add("Inventory"));
            workSheets[0].Cell("A1").Value = "Item ID";
            workSheets[0].Cell("A1").Style.Font.Bold = true;
            workSheets[0].Cell("B1").Value = "Item Name";
            workSheets[0].Cell("B1").Style.Font.Bold = true;
            workSheets[0].Cell("C1").Value = "Uses Left";
            workSheets[0].Cell("C1").Style.Font.Bold = true;
            workSheets[0].Cell("D1").Value = "Is Checked Out";

            string constring = "datasource=localhost;port=3306;username=root;password=3a1w";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand("SELECT * FROM sample_table.inventory;", conDatabase);
            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = cmdDatabase;
            dbdataset = new DataTable();
            sda.Fill(dbdataset);
            StringBuilder cell = new StringBuilder("A2");

            for (int i = 0; i < dbdataset.Rows.Count; i++)
             {
                 for (int j = 0; j < dbdataset.Columns.Count; j++)
                 {
                     workSheets[0].Cell(cell.ToString()).Value = dbdataset.Rows[i][j];
                     cell[0] = (char)((int)(cell[0]) + 1);
                 }
                 if (i > 0)
				{
                    cell = new StringBuilder('A' + (i + 3).ToString());
                }
                else
                {
                    cell = new StringBuilder("A3");
                }
             }
             String fileName = String.Format("Inventory Report {0} {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString());
             Regex rgx = new Regex("[^a-zA-Z0-9 -]");
             fileName = rgx.Replace(fileName, "");
             workBook.SaveAs(String.Format("{0}.xlsx", fileName));
         }

         private void eventSetUp(XLWorkbook workbook, List<IXLWorksheet> workSheets)
         {
            var workBook = new XLWorkbook();
            //List<IXLWorksheet> workSheets = new List<IXLWorksheet>();
            string constring = "datasource=localhost;port=3306;username=root;password=3a1w";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand("SELECT * FROM sample_table.event;", conDatabase);
            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = cmdDatabase;
            dbdataset = new DataTable();
            sda.Fill(dbdataset);
            StringBuilder cell = new StringBuilder("A2");

            //put headers in 
            for (int i = 0; i < dbdataset.Rows.Count; i++)
            {
                for (int j = 0; j < dbdataset.Columns.Count; j++)
                {
                    workSheets[0].Cell(cell.ToString()).Value = dbdataset.Rows[i][j];
                    cell[0] = (char)((int)(cell[0]) + 1);

                }
                if (i > 0)
                {
                    cell = new StringBuilder('A' + (i + 3).ToString());
                }
                else
                {
                    cell = new StringBuilder("A3");
                }
            }

            String fileName = String.Format("Events Report {0} {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString());
            Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            fileName = rgx.Replace(fileName, "");
            workBook.SaveAs(String.Format("{0}.xlsx", fileName));
         }

         public void generateEvents()
         {
            var workBook = new XLWorkbook();
            List<IXLWorksheet> workSheets = new List<IXLWorksheet>();
            workSheets.Add(workBook.Worksheets.Add("Events"));
            workSheets[0].Cell("A1").Value = "ID";
            workSheets[0].Cell("A1").Style.Font.Bold = true;
            workSheets[0].Cell("B1").Value = "Name";
            workSheets[0].Cell("B1").Style.Font.Bold = true;
            workSheets[0].Cell("C1").Value = "Date";
            workSheets[0].Cell("C1").Style.Font.Bold = true;
            workSheets[0].Cell("D1").Value = "Memo";
            workSheets[0].Columns().AdjustToContents();
            workSheets[0].Rows().AdjustToContents();


            string constring = "datasource=localhost;port=3306;username=root;password=3a1w";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand("SELECT * FROM sample_table.event;", conDatabase);
            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = cmdDatabase;
            dbdataset = new DataTable();
            sda.Fill(dbdataset);
            StringBuilder cell = new StringBuilder("A2");

            for (int i = 0; i < dbdataset.Rows.Count; i++)
            {
                for (int j = 0; j < dbdataset.Columns.Count; j++)
                {
                    workSheets[0].Cell(cell.ToString()).Value = dbdataset.Rows[i][j];
                    cell[0] = (char)((int)(cell[0]) + 1);
                }
                if (i > 0)
                {
                    cell = new StringBuilder('A' + (i + 3).ToString());
                }
                else
                {
                    cell = new StringBuilder("A3");
                }
            }
            String fileName = String.Format("Event Report {0} {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString());
            Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            fileName = rgx.Replace(fileName, "");
            workBook.SaveAs(String.Format("{0}.xlsx", fileName));

         }

        private void patronsSetup(XLWorkbook workbook, List<IXLWorksheet> workSheets)
        {
            var workBook = new XLWorkbook();
            //List<IXLWorksheet> workSheets = new List<IXLWorksheet>();
            string constring = "datasource=localhost;port=3306;username=root;password=3a1w";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand("SELECT * FROM sample_table.personal_info_table;", conDatabase);


            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = cmdDatabase;
            dbdataset = new DataTable();
            sda.Fill(dbdataset);
            StringBuilder cell = new StringBuilder("A2");

            //put headers in 
            for (int i = 0; i < dbdataset.Rows.Count; i++)
            {
                for (int j = 0; j < dbdataset.Columns.Count; j++)
                {
                    workSheets[0].Cell(cell.ToString()).Value = dbdataset.Rows[i][j];
                    cell[0] = (char)((int)(cell[0]) + 1);

                }
                if (i > 0)
                {
                    cell = new StringBuilder('A' + (i + 3).ToString());
                }
                else
                {
                    cell = new StringBuilder("A3");
                }
            }

            String fileName = String.Format("All Patrons Report {0} {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString());
            Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            fileName = rgx.Replace(fileName, "");
            workBook.SaveAs(String.Format("{0}.xlsx", fileName));
        }


        public void generateAllPatrons()
        {
            var workBook = new XLWorkbook();
            List<IXLWorksheet> workSheets = new List<IXLWorksheet>();
            workSheets.Add(workBook.Worksheets.Add("All Patrons"));
            workSheets[0].Cell("A1").Value = "ID";
            workSheets[0].Cell("A1").Style.Font.Bold = true;
            workSheets[0].Cell("B1").Value = "First Name";
            workSheets[0].Cell("B1").Style.Font.Bold = true;
            workSheets[0].Cell("C1").Value = "Last Name";
            workSheets[0].Cell("C1").Style.Font.Bold = true;
            workSheets[0].Cell("D1").Value = "Birthday";
            workSheets[0].Cell("D1").Style.Font.Bold = true;
            workSheets[0].Cell("E1").Value = "Address";
            workSheets[0].Cell("E1").Style.Font.Bold = true;
            workSheets[0].Cell("F1").Value = "City";
            workSheets[0].Cell("F1").Style.Font.Bold = true;
            workSheets[0].Cell("G1").Value = "State";
            workSheets[0].Cell("G1").Style.Font.Bold = true;
            workSheets[0].Cell("H1").Value = "ZIP";
            workSheets[0].Cell("H1").Style.Font.Bold = true;
            workSheets[0].Cell("I1").Value = "Phone";
            workSheets[0].Cell("I1").Style.Font.Bold = true;
            workSheets[0].Cell("J1").Value = "Email";
            workSheets[0].Cell("J1").Style.Font.Bold = true;
            workSheets[0].Cell("K1").Value = "Is Patron";
            workSheets[0].Cell("K1").Style.Font.Bold = true;
            workSheets[0].Cell("L1").Value = "Is Employee";
            workSheets[0].Cell("L1").Style.Font.Bold = true;
            workSheets[0].Cell("M1").Value = "Is Manager";
            workSheets[0].Cell("M1").Style.Font.Bold = true;
            workSheets[0].Cell("N1").Value = "Is Admin";
            workSheets[0].Cell("N1").Style.Font.Bold = true;
            workSheets[0].Cell("O1").Value = "Warning Suspension";
            workSheets[0].Cell("O1").Style.Font.Bold = true;
            workSheets[0].Cell("P1").Value = "Suspended";
            workSheets[0].Cell("P1").Style.Font.Bold = true;
            workSheets[0].Cell("Q1").Value = "Password";
            workSheets[0].Cell("Q1").Style.Font.Bold = true;
            workSheets[0].Cell("R1").Value = "Waiver ID";
            workSheets[0].Cell("R1").Style.Font.Bold = true;
            workSheets[0].Cell("S1").Value = "Inventory ID";
            workSheets[0].Cell("S1").Style.Font.Bold = true;
            workSheets[0].Columns().AdjustToContents();
            workSheets[0].Rows().AdjustToContents();


            string constring = "datasource=localhost;port=3306;username=root;password=3a1w";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand("SELECT * FROM sample_table.personal_info_table;", conDatabase);
            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = cmdDatabase;
            dbdataset = new DataTable();
            sda.Fill(dbdataset);
            StringBuilder cell = new StringBuilder("A2");

            for (int i = 0; i < dbdataset.Rows.Count; i++)
            {
                for (int j = 0; j < dbdataset.Columns.Count; j++)
                {
                    workSheets[0].Cell(cell.ToString()).Value = dbdataset.Rows[i][j];
                    cell[0] = (char)((int)(cell[0]) + 1);
                }
                if (i > 0)
                {
                    cell = new StringBuilder('A' + (i + 3).ToString());
                }
                else
                {
                    cell = new StringBuilder("A3");
                }
            }
            String fileName = String.Format("All Patrons Report {0} {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString());
            Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            fileName = rgx.Replace(fileName, "");
            workBook.SaveAs(String.Format("{0}.xlsx", fileName));

        }

    }
}






/*public void generateEvents()
{
    var workBook = new XLWorkbook();
    List<IXLWorksheet> workSheets = new List<IXLWorksheet>();
    workSheets.Add(workBook.Worksheets.Add("Event Information"));
    string constring = "datasource=localhost;port=3306;username=root;password=3a1w";
    MySqlConnection conDatabase = new MySqlConnection(constring);
    MySqlCommand cmdDatabase = new MySqlCommand("SELECT * FROM sample_table.event ;", conDatabase);

    try
    {
        MySqlDataAdapter sda = new MySqlDataAdapter();
        sda.SelectCommand = cmdDatabase;
        dbdataset = new DataTable();
        sda.Fill(dbdataset);
        StringBuilder cell = new StringBuilder("A2");

        //put headers in 
        for (int i = 0; i < dbdataset.Rows.Count; i++)
        {
            for (int j = 0; j < dbdataset.Columns.Count; j++)
            {
                workSheets[0].Cell(cell.ToString()).Value = dbdataset.Rows[i][j];
                cell[0] = (char)((int)(cell[0]) + 1);

            }
            cell[0] = 'A';
            cell[1] = (char)((int)(cell[1]) + 1);
        }
        String fileName = String.Format("Events Report {0} {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString());
        Regex rgx = new Regex("[^a-zA-Z0-9 -]");
        fileName = rgx.Replace(fileName, "");
        workBook.SaveAs(String.Format("{0}.xlsx", fileName));
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message);
    }
}

public void generateInventory()
{
    var workBook = new XLWorkbook();
    List<IXLWorksheet> workSheets = new List<IXLWorksheet>();
    workSheets.Add(workBook.Worksheets.Add("Inventory Information"));
    string constring = "datasource=localhost;port=3306;username=root;password=3a1w";
    MySqlConnection conDatabase = new MySqlConnection(constring);
    MySqlCommand cmdDatabase = new MySqlCommand("SELECT * FROM sample_table.inventory;;", conDatabase);


    MySqlDataAdapter sda = new MySqlDataAdapter();
    sda.SelectCommand = cmdDatabase;
    dbdataset = new DataTable();
    sda.Fill(dbdataset);
    StringBuilder cell = new StringBuilder("A2");

    //put headers in 
    for (int i = 0; i < dbdataset.Rows.Count; i++)
    {
        for (int j = 0; j < dbdataset.Columns.Count; j++)
        {
            workSheets[1].Cell(cell.ToString()).Value = dbdataset.Rows[i][j];
            cell[0] = (char)((int)(cell[0]) + 1);

        }
        cell[0] = 'A';
        cell[1] = (char)((int)(cell[1]) + 1);
    }
    String fileName = String.Format("Events Report {0} {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString());
    Regex rgx = new Regex("[^a-zA-Z0-9 -]");
    fileName = rgx.Replace(fileName, "");
    workBook.SaveAs(String.Format("{0}.xlsx", fileName));

}
*/