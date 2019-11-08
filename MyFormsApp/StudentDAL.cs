using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFormsApp
{
    class StudentDAL
    {
        SqlCommand sqlCom = new SqlCommand();
        SqlConnection sqlCon = new SqlConnection();

        public Boolean addStudent(string sID, string sName, string sAddress)
        {
            try
            {
                sqlCon = DBConnection.MySQLConnection();

                string sqlString = "INSERT INTO Student VALUES(@param1, @param2, @param3)";
                sqlCom = new SqlCommand(sqlString, sqlCon);
                sqlCom.Parameters.Add("@param1", SqlDbType.VarChar, 10).Value = sID;
                sqlCom.Parameters.Add("@param2", SqlDbType.VarChar, 100).Value = sName;
                sqlCom.Parameters.Add("@param3", SqlDbType.VarChar, 100).Value = sAddress;

                int rows = sqlCom.ExecuteNonQuery();
                if (rows == 1)
                {
                    MessageBox.Show(sName + " added!");
                }
                else
                {
                    MessageBox.Show(sName + " could not be added!");
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Sql error: " + e);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
            finally
            {
                sqlCon.Close();
            }
            return true;
        }

        internal Boolean deleteStudents(string sID, string sName, string sAddress)
        {
            try
            {
                sqlCon = DBConnection.MySQLConnection();

                string sqlString = "DELETE FROM Student WHERE ";
                if (sID.Length > 0)
                    sqlString += "studentID = '" + sID + "' AND";
                if (sName.Length > 0)
                    sqlString += "studentName = '" + sName + "' AND";
                if (sAddress.Length > 0)
                    sqlString += "studentAddress = '" + sAddress + "' ";

                sqlString = sqlString.Remove(sqlString.LastIndexOf("'") + 1);
                sqlCom = new SqlCommand(sqlString, sqlCon);

                int rows = sqlCom.ExecuteNonQuery();
                MessageBox.Show(rows + " deleted!");
            }
            catch (SqlException e)
            {
                MessageBox.Show("Sql error: " + e);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
            finally
            {
                sqlCon.Close();
            }
            return true;
        }

        internal List<Student> searchForStudent(string sID, string sName, string sAddress)
        {
            List<Student> students = new List<Student>();

            try
            {
                sqlCon = DBConnection.MySQLConnection();

                string sqlString = "SELECT * FROM Student WHERE ";
                if (sID.Length > 0)
                    sqlString += "studentID = '" + sID + "' AND";
                if (sName.Length > 0)
                    sqlString += "studentName = '" + sName + "' AND";
                if (sAddress.Length > 0)
                    sqlString += "studentAddress = '" + sAddress + "' ";

                sqlString = sqlString.Remove(sqlString.LastIndexOf("'") + 1);

                sqlCom = new SqlCommand(sqlString, sqlCon);
                sqlCom.CommandType = CommandType.Text;

                SqlDataReader dR = sqlCom.ExecuteReader();

                while (dR.Read())
                {
                    Student s = new Student();

                    s.StudentID = dR["studentID"].ToString();
                    s.StudentName = dR["studentName"].ToString();
                    s.StudentAddress = dR["studentAddress"].ToString();

                    students.Add(s);
                }
                dR.Close();
                return students;
            }
            catch (SqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                sqlCon.Close();
            }
        }

        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();

            try
            {
                sqlCon = DBConnection.MySQLConnection();

                string sqlString = "SELECT * FROM Student";
                sqlCom = new SqlCommand(sqlString, sqlCon);
                sqlCom.CommandType = CommandType.Text;
                
                SqlDataReader dR = sqlCom.ExecuteReader();

                while (dR.Read())
                {
                    Student s = new Student();

                    s.StudentID = dR["studentID"].ToString();
                    s.StudentName = dR["studentName"].ToString();
                    s.StudentAddress = dR["studentAddress"].ToString();

                    students.Add(s);
                }
                dR.Close();
                return students;
            }
            catch (SqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                sqlCon.Close();
            }
        }

        public Boolean updateStudent(string sID, string sName, string sAddress)
        {
            try
            {
                sqlCon = DBConnection.MySQLConnection();
                
                string sqlString = "UPDATE Student SET studentName = '" + sName + "', studentAddress = '" + sAddress + "' WHERE studentID = '" + sID + "'";
                sqlCom = new SqlCommand(sqlString, sqlCon);
                
                int rows = sqlCom.ExecuteNonQuery();
                if (rows == 1)
                {
                    MessageBox.Show(sName + " updated!");
                }
                else
                {
                    MessageBox.Show(sName + " could not be updated!");
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Sql error: " + e);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
            finally
            {
                sqlCon.Close();
            }
            return true;
        }
    }
}
