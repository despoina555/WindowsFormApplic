using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

   

        [WebMethod(Description = "Returns Students data.")]
        public List<StudentData> ReadFromDatabase()
        {
            //contains the data
            List<StudentData> studentData = new List<StudentData>();
            //populate results using mock data
            studentData= mockData(studentData);

            //string connetionString;
            //SqlConnection cnn;
            //connetionString = @"Data Source=<ServerName>;Initial Catalog=<DBNAME>;User ID=<username>;Password=<password>";
            //cnn = new SqlConnection(connetionString);
            //try
            //{
            //        cnn.Open();

            //SqlCommand command = new SqlCommand("select st.NAME,st.ID,gr.GRADE,gr.COURSE_NAME"+
            //                                      "from STUDENT st,GRADES gr" +
            //                                       "where st.ID = gr.STUDENT_ID" +
            //                                       "order by st.ID; ", cnn);
            //        SqlDataReader reader = command.ExecuteReader();

            //        while (reader.Read())
            //        {
            //        System.Diagnostics.Debug.WriteLine(reader);
            //        System.Diagnostics.Debug.WriteLine(reader.GetString(0));
            //             StudentData student = new StudentData();
            //            student.Name = reader.GetString(0);
            //            student.studentID= reader.GetString(1);

            //           //  student.grade = reader.GetInt32(2);
            //            // student.courseName = reader.GetString(3);

            //           /*  List<CourseGrade> courceGradelist = new List<CourseGrade>();
            //            CourseGrade cgr = new CourseGrade();
            //            cgr.grade = reader.GetInt32(2);
            //            cgr.courseName = reader.GetString(3);
            //            courceGradelist.Add(cgr);
            //            student.courceGradelist = courceGradelist;
            //              */
            //            studentData.Add(student);
            //        }
            //            cnn.Close();

            //} catch (Exception ex) {
            //   //exeption occured
            //}

            return studentData;
        }

        private List<StudentData> mockData(List<StudentData> studentDatalist)
        {
            StudentData sdt1 = new StudentData();
            sdt1.Name = "Despina";
            sdt1.StudentID = "1";
            sdt1.CourseID = "001";
            sdt1.CourseName = "Maths";
            sdt1.Grade = 10;

            StudentData sdt3 = new StudentData();
            sdt3.Name = "Despina";
            sdt3.StudentID = "1";
            sdt3.CourseID = "002";
            sdt3.CourseName = "Physics";
            sdt3.Grade = 7;

            StudentData sdt2 = new StudentData();
            sdt2.Name = "Mark";
            sdt2.StudentID = "2";
            sdt2.CourseID = "001";
            sdt2.CourseName = "Maths";
            sdt2.Grade = 10;

            StudentData sdt4 = new StudentData();
            sdt4.Name = "Mark";
            sdt4.StudentID = "2";
            sdt4.CourseID = "002";
            sdt4.CourseName = "Physics";
            sdt4.Grade = 8;

            studentDatalist.Add(sdt1);
            studentDatalist.Add(sdt2);
            studentDatalist.Add(sdt3);
            studentDatalist.Add(sdt4);

            return studentDatalist;
        }

        public struct StudentData
        {
            public String Name;
            public String StudentID;

            //CourseGrade
            public String CourseID;
            public String CourseName;
            public int Grade;

           // public List<CourseGrade> courceGradelist; 
        }

        //public struct CourseGrade   {
        //    public String CourseID;
        //    public String CourseName;
        //    public int Grade;
        //}
    }

 
}
