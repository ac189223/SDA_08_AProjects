using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFormsApp
{
    class Student
    {
        private string studentID;
        private string studentName;
        private string studentAddress;

        public string StudentID { get => studentID; set => studentID = value; }
        public string StudentName { get => studentName; set => studentName = value; }
        public string StudentAddress { get => studentAddress; set => studentAddress = value; }
    }
}
