using BiometricPayroll.HELPERS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiometricPayroll.FORMS
{
    public partial class DisplayEmployees : Form
    {
        public static DisplayEmployees disp;
        public DisplayEmployees()
        {
            InitializeComponent();
            disp = this;
        }

       
        public string SelectedRowID;
        public string SelectedRowWorkID;
        public string SelectedUserSurname;
        public string searchQuery = "";
        private void DisplayEmployees_Load(object sender, EventArgs e)
        {
            loadEmployees();
        }

        public void loadEmployees()
        {
            Database db = new Database();
            string Search = $"SELECT id AS ID,work_id AS 'WORK ID', CONCAT_WS(' ' , first_name , surname) AS NAME,position AS JOB,phonenumber AS CONTACT,email AS EMAIL,gender AS GENDER,work_status AS 'WORK STATUS' FROM employees WHERE first_name LIKE '{searchQuery}%' OR  surname LIKE '{searchQuery}%' ORDER BY id ASC";
           

            if (searchQuery.Length == 0)
            {
                db.LoadDTG(empTableGrid, Constants.EMPLOYEES_QUERY);
            }
            else if (searchQuery.Length > 0)
            {
                db.LoadDTG(empTableGrid, Search);
            }

          
        }               
     
        private void empTableGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (empTableGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    empTableGrid.CurrentRow.Selected = true;

                    SelectedRowID = empTableGrid.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                    SelectedUserSurname = empTableGrid.Rows[e.RowIndex].Cells["NAME"].FormattedValue.ToString();
                    SelectedRowWorkID = empTableGrid.Rows[e.RowIndex].Cells["WORK ID"].FormattedValue.ToString();

                    //USING PARENT INSTANCE emp TO ACCESS FUNCTION
                    Employees.emp.setSelectedUser(SelectedRowID, SelectedRowWorkID,SelectedUserSurname);
                }
            }
            catch(System.ArgumentOutOfRangeException OutOfRange)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
