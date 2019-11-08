using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFormsApp
{
    class DBConnection
    {
        public static SqlConnection con;
        public static SqlConnection MySQLConnection()
        {
            DBSecurity dbs = new DBSecurity();
            
            try
            {
                con = new SqlConnection(dbs.ConnectionString);
                con.Open();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Could not connect to database. Error Message (1): " + e);
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not connect to database. Error Message (2): " + e);
            }
            return con;
        }
    }
}
