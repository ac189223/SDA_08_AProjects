using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFormsApp
{
    public partial class StudentForm : Form
    {
        Controller controller = new Controller();

        public StudentForm()
        {
            InitializeComponent();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string sID = tbSID.Text;
                string sName = tbSName.Text;
                string sAddress = tbSAddress.Text;

                controller.addStudent(sID, sName, sAddress);

                clearFields();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Exception happened: " + ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception happened: " + ex);
            }
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            string sID = tbSID.Text;
            string sName = tbSName.Text;
            string sAddress = tbSAddress.Text;
            if (sID.Length > 0 || sName.Length > 0 || sAddress.Length > 0)
            {
                dgvData.DataSource = controller.searchForStudent(sID, sName, sAddress).Select(x => new { StudentID = x.StudentID, StudentName = x.StudentName, StudentAddress = x.StudentAddress }).ToList();
            }
            clearFields();
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            string sID = tbSID.Text;
            string sName = tbSName.Text;
            string sAddress = tbSAddress.Text;
            if (sID.Length > 0 && sName.Length > 0 && sAddress.Length > 0)
            {
                controller.updateStudent(sID, sName, sAddress);
            }
            clearFields();
        }

        private void clearFields()
        {
            tbSID.Clear();
            tbSName.Clear();
            tbSAddress.Clear();
        }

        private void bList_Click_1(object sender, EventArgs e)
        {
            dgvData.DataSource = controller.getStudents().Select(x => new { StudentID = x.StudentID, StudentName = x.StudentName, StudentAddress = x.StudentAddress }).ToList();
            clearFields();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            string sID = tbSID.Text;
            string sName = tbSName.Text;
            string sAddress = tbSAddress.Text;
            if (sID.Length > 0 || sName.Length > 0 || sAddress.Length > 0)
            {
                controller.deleteStudents(sID, sName, sAddress);
            }
            clearFields();
        }
    }
}
