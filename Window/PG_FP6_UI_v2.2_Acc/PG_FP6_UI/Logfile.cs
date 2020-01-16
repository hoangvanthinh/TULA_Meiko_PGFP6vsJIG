using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Drawing;

using System.Collections;



namespace PG_FP6_UI
{
    class Logfile
    {
        private string excelFilePath = string.Empty;
        private int rowNumber = 1; // define first row number to enter data in excel

        Excel.Application myExcelApplication;
        Excel.Workbook myExcelWorkbook;
        Excel.Worksheet myExcelWorkSheet;

        public string ExcelFilePath
        {
            get { return excelFilePath; }
            set { excelFilePath = value; }
        }

        public int Rownumber
        {
            get { return rowNumber; }
            set { rowNumber = value; }
        }


        public int Rn()
        {
            myExcelWorkSheet = (Excel.Worksheet)myExcelWorkbook.Worksheets[1];
            return this.myExcelWorkSheet.UsedRange.Rows.Count;
        }
        string[,] skyscrapers = new string[1,5]
        {
             { "TT", "Code", "Status", "Date", "Note" }
            
        };
        public void createExcelfile(string pathfile)
        {
            excelFilePath = pathfile;

            myExcelApplication = null;
            myExcelApplication = new Excel.Application();
            myExcelWorkbook = myExcelApplication.Workbooks.Add();

           //myExcelWorkSheet = (Excel.Worksheet)myExcelWorkbook.Worksheets.get_Item(1);

            myExcelWorkSheet = (Excel.Worksheet)myExcelWorkbook.Worksheets[1]; // define in which worksheet, do you want to add data
            myExcelWorkSheet.Name = "File1"; // define a name for the worksheet (optinal)

            for (int i = 0; i < 5; i++)
                myExcelWorkSheet.Cells[1,i+1] = skyscrapers[0, i];

            myExcelWorkSheet.Cells[1, 1].Interior.Color = Color.YellowGreen;
            myExcelWorkSheet.Cells[1, 2].Interior.Color = Color.YellowGreen;
            myExcelWorkSheet.Cells[1, 3].Interior.Color = Color.YellowGreen;
            myExcelWorkSheet.Cells[1, 4].Interior.Color = Color.YellowGreen;
            myExcelWorkSheet.Cells[1, 5].Interior.Color = Color.YellowGreen;


            myExcelWorkSheet.Range[myExcelWorkSheet.Cells[1, 1], myExcelWorkSheet.Cells[2, 1]].Merge();
            myExcelWorkSheet.Range[myExcelWorkSheet.Cells[1, 2], myExcelWorkSheet.Cells[2, 2]].Merge();
            myExcelWorkSheet.Range[myExcelWorkSheet.Cells[1, 3], myExcelWorkSheet.Cells[2, 3]].Merge();
            myExcelWorkSheet.Range[myExcelWorkSheet.Cells[1, 4], myExcelWorkSheet.Cells[2, 4]].Merge();
            myExcelWorkSheet.Range[myExcelWorkSheet.Cells[1, 5], myExcelWorkSheet.Cells[2, 5]].Merge();
       

            myExcelWorkSheet.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            myExcelWorkSheet.Cells.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

            

            myExcelWorkbook.SaveAs(excelFilePath);
            myExcelWorkbook.Close();
            myExcelApplication.Quit();

        }
        public void openExcel(string pathfile)
        {
            excelFilePath = pathfile;

            myExcelApplication = null;

            myExcelApplication = new Excel.Application(); // create Excell App
            myExcelApplication.DisplayAlerts = false; // turn off alerts


            myExcelWorkbook = (Excel.Workbook)(myExcelApplication.Workbooks._Open(excelFilePath, System.Reflection.Missing.Value,
               System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
               System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
               System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
               System.Reflection.Missing.Value, System.Reflection.Missing.Value)); // open the existing excel file

            int numberOfWorkbooks = myExcelApplication.Workbooks.Count; // get number of workbooks (optional)

            //myExcelWorkSheet = (Excel.Worksheet)myExcelWorkbook.Worksheets[1]; // define in which worksheet, do you want to add data
            //myExcelWorkSheet.Name = "WorkSheet 1"; // define a name for the worksheet (optinal)

            int numberOfSheets = myExcelWorkbook.Worksheets.Count; // get number of worksheets (optional)
            
            myExcelApplication.Visible = true;
            //rowNumber = myExcelWorkSheet.Columns.Count + 3;

        }

        public void addDataToExcel(string ID, string code, string status, string date, string Note)
        {
            myExcelWorkSheet = (Excel.Worksheet)myExcelWorkbook.Worksheets[1]; // define in which worksheet, do you want to add data
            rowNumber = myExcelWorkSheet.UsedRange.Rows.Count + 1;

            myExcelWorkSheet.Cells[rowNumber, 1] = (rowNumber-2).ToString();
            myExcelWorkSheet.Cells[rowNumber, 2] = code;
            myExcelWorkSheet.Cells[rowNumber, 3] = status;
            myExcelWorkSheet.Cells[rowNumber, 4] = date;
            myExcelWorkSheet.Cells[rowNumber, 5] = Note;
            myExcelWorkSheet.Columns.AutoFit();

            if (status == "ERROR")
            {
               // myExcelWorkSheet.Cells[rowNumber, 3].Interior.Color = Color.Red;
                myExcelWorkSheet.Cells[rowNumber, 3].Font.Color = Color.Red;

            }
            else
                //myExcelWorkSheet.Cells[rowNumber, 3].Interior.Color = Color.White;
                myExcelWorkSheet.Cells[rowNumber, 3].Font.Color = Color.Lime;

        }

        public void closeExcel()
        {
            try
            {
                myExcelWorkbook.SaveAs(excelFilePath, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                                               System.Reflection.Missing.Value, System.Reflection.Missing.Value, Excel.XlSaveAsAccessMode.xlNoChange,
                                               System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                                               System.Reflection.Missing.Value, System.Reflection.Missing.Value); // Save data in excel


                myExcelWorkbook.Close(true, excelFilePath, System.Reflection.Missing.Value); // close the worksheet
               // myExcelWorkbook.Close();
                myExcelApplication.Quit();

            }
            finally
            {
                if (myExcelApplication != null)
                {
                    myExcelApplication.Quit(); // close the excel application
                }
            }
   
      
        }

    }
}
