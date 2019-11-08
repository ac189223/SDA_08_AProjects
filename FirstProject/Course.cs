using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class Course
    {
        private string courseID;
        private string courseName;
        private int credits;

        public Course() { }

        public Course(string courseID, string courseName, int credits)
        {
            this.courseID = courseID;
            this.courseName = courseName;
            this.credits = credits;
        }

        public string CourseID { get => courseID; set => courseID = value; }
        public string CourseName { get => courseName; set => courseName = value; }
        public int Credits { get => credits; set => credits = value; }

    }

}
