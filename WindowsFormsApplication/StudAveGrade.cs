using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication
{
    class StudAveGrade
    {
        private String StudentName;
        private int AvGrades;
        private int NumberOfCourses;



        public String getStudentName()
        {
            return StudentName;
        }


        public void setStudentName(String StudentName)
        {
            this.StudentName= StudentName;
        }


        public int getAvGrades()
        {
            return AvGrades;
        }


        public void setAvGrades(int AvGrades)
        {
            this.AvGrades = AvGrades;
        }


        public int getNumberOfCourses()
        {
            return NumberOfCourses;
        }


        public void setNumberOfCourses(int NumberOfCourses)
        {
            this.NumberOfCourses = NumberOfCourses;
        }

        public String toString()
        {
            return " StudentName " + StudentName + " AvGrades " + AvGrades;
        }
    }

}
