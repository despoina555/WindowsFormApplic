using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication.WebServiceNamespace;
//export to excel
using Excel = Microsoft.Office.Interop.Excel;
using ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat;

namespace WindowsFormsApplication
{
    public partial class Form1 : Form
    {       
 
        WebServiceNamespace.WebService1SoapClient client = new WebServiceNamespace.WebService1SoapClient();
        List<string[]> editeddata4excel = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            editeddata4excel = null;
            //onclick consume the exposed webservice
            StudentData[] data = client.ReadFromDatabase();
            if (data!= null && data.Length != 0)
            {
                // if data no empty then
                DataGridView gripView = new DataGridView();
                SetupDataGridView(gripView);
                //edit data defore show them in DataGridView
                List<string[]> editeddata = modifyData(data);
                editeddata4excel = editeddata;
                PopulateDataGridView(gripView, editeddata);

                //create buttom to export  in excel
                Button export2ExcelButton = new Button();
                export2ExcelButton.Location =  new Point(button1.Top, button1.Left+50);                
                export2ExcelButton.Size = new Size(75, 75);
                export2ExcelButton.Text = "Excel Export";
                export2ExcelButton.Visible = true;
                export2ExcelButton.Click +=  export2ExcelButton_Click;    
                this.Controls.Add(export2ExcelButton);
            }
        }

        private void export2ExcelButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (editeddata4excel != null)
                {
                    Excel.Application xlAppToUpload = new Excel.Application();
                    xlAppToUpload.Workbooks.Add();

                    Excel.Worksheet xlWorkSheetToUpload = default(Excel.Worksheet);
                    xlWorkSheetToUpload = xlAppToUpload.Sheets["Sheet1"];

                    xlAppToUpload.Visible = true;

                    // SHOW THE HEADER BOLD AND SET FONT AND SIZE.
                    xlWorkSheetToUpload.Cells[1, 1].value = "Student Name";
                    xlWorkSheetToUpload.Cells[1, 2].value = "Average Grade";
                    xlWorkSheetToUpload.Cells[1, 1].FONT.NAME = "Calibri";
                    xlWorkSheetToUpload.Cells[1, 1].Font.Bold = true;
                    xlWorkSheetToUpload.Cells[1, 1].Font.Size = 11;
                    xlWorkSheetToUpload.Cells[1, 2].FONT.NAME = "Calibri";
                    xlWorkSheetToUpload.Cells[1, 2].Font.Bold = true;
                    xlWorkSheetToUpload.Cells[1, 2].Font.Size = 11;

                    int rowCount = 2;
                    for (var i = 0; i < editeddata4excel.Count; i++)
                    {
                        xlWorkSheetToUpload.Cells[rowCount, 1].value = editeddata4excel[i][0];
                        xlWorkSheetToUpload.Cells[rowCount, 2].value = editeddata4excel[i][1];

                        rowCount++;
                       // Console.WriteLine(">> excel>>"+ editeddata4excel[i] + " name: " + editeddata4excel[i][0] + " grade " + editeddata4excel[i][1]);
                    }

                    // FINALLY, FORMAT THE EXCEL SHEET USING EXCEL'S AUTOFORMAT FUNCTION.
                    //xlAppToUpload.ActiveCell.Worksheet.Cells[4, 1].AutoFormat(
                    //    ExcelAutoFormat.xlRangeAutoFormatList2);
                    xlAppToUpload = null;
                }
            }
            catch (Exception ex)  {
                Console.WriteLine(ex);
            }
    }

        private List<string[]> modifyData(StudentData[] data)
        {
            List<string[]> editeddata = new List<string[]>();
            editeddata4excel = new List<string[]>();

            Dictionary<string, StudAveGrade> dict = new Dictionary<string,StudAveGrade>();

            for (int i=0;i< data.Length;i++)
            {

                StudAveGrade studAveGrade;
                if (dict.TryGetValue(data[i].StudentID,out studAveGrade)){
                    //just update the sum of grades
                    studAveGrade.setAvGrades(studAveGrade.getAvGrades() + data[i].Grade) ;
                    studAveGrade.setNumberOfCourses(studAveGrade.getNumberOfCourses()+1);
                    Console.WriteLine(" new VALUE: "+ studAveGrade.getAvGrades());
                } else {
                    //create a new entry in dictionary
                     studAveGrade= new StudAveGrade();
                     studAveGrade.setStudentName(data[i].Name);
                     studAveGrade.setAvGrades(data[i].Grade);
                     studAveGrade.setNumberOfCourses(1);

                    dict.Add(data[i].StudentID,studAveGrade);
                    Console.WriteLine(" new VALUE in dict: " + studAveGrade.toString() +" key "+ data[i].StudentID);
                }

            }

            // reaf values from dictionary
            foreach (KeyValuePair<string, StudAveGrade> student in dict)
            {
                 //calculate the average grade
                int averageGrade= (student.Value.getAvGrades() / student.Value.getNumberOfCourses());
                student.Value.setAvGrades(averageGrade);
                //populate the edited data 
                string[] rowdata = new string[2];
                rowdata[0] = student.Value.getStudentName(); //student.Key;
                rowdata[1] = student.Value.getAvGrades().ToString();
                editeddata.Add(rowdata);

               // Console.WriteLine(">> Key: {0}, Value: {1}", student.Key, student.Value.getAvGrades().ToString());
            }

            return editeddata;
        }

        private void PopulateDataGridView(DataGridView gripView, List<String[]> editeddata)
        {
            if (gripView != null && editeddata != null)
                for (var i = 0; i < editeddata.Count; i++)
                {
                    gripView.Rows.Add(editeddata[i]);
                    Console.WriteLine(">>"+ editeddata[i]);
                }
        }

        private void SetupDataGridView(DataGridView gripView)
        {
            this.Controls.Add(gripView);
            
            gripView.ColumnCount = 2;
            gripView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            gripView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gripView.ColumnHeadersDefaultCellStyle.Font =
                new Font(gripView.Font, FontStyle.Bold);

            gripView.Name = "Students-Grades";
            gripView.Location = new Point(68, 168);
          //  gripView.Size = new Size(500, 250);
            gripView.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            gripView.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            gripView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            gripView.GridColor = Color.Black;
            gripView.RowHeadersVisible = false;
            gripView.AutoSize = true;

            gripView.Columns[0].Name = "Student Name";
            gripView.Columns[1].Name = "Avarage Grade";


            gripView.SelectionMode =  DataGridViewSelectionMode.FullRowSelect;
            //   gripView.MultiSelect = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
