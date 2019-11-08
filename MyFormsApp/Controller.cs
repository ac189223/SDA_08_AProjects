using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFormsApp
{
    class Controller
    {
        private StudentDAL studentDAL;

        public Controller()
        {
            this.studentDAL = new StudentDAL();
        }

        public Boolean addStudent(string sID, string sName, string sAddress)
        {
            return studentDAL.addStudent(sID, sName, sAddress);
        }

        internal List<Student> getStudents()
        {
            return studentDAL.GetStudents();
        }

        internal List<Student> searchForStudent(string sID, string sName, string sAddress)
        {
            return studentDAL.searchForStudent(sID, sName, sAddress);
        }

        internal Boolean updateStudent(string sID, string sName, string sAddress)
        {
            return studentDAL.updateStudent(sID, sName, sAddress);
        }

        internal Boolean deleteStudents(string sID, string sName, string sAddress)
        {
            return studentDAL.deleteStudents(sID, sName, sAddress);
        }
    }
}
