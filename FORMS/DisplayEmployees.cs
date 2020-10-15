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
        private void DisplayEmployees_Load(object sender, EventArgs e)
        {
            loadEmployees();
        }

        public void loadEmployees()
        {
            Database db = new Database();

            db.LoadDTG(empTableGrid);
        }               
     
        private void empTableGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (empTableGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                empTableGrid.CurrentRow.Selected = true;

                SelectedRowID = empTableGrid.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                SelectedRowWorkID = empTableGrid.Rows[e.RowIndex].Cells["WORK ID"].FormattedValue.ToString();

                //USING PARENT INSTANCE emp TO ACCESS FUNCTION
                Employees.emp.setSelectedUser(SelectedRowID,SelectedRowWorkID);
            }
        }
    }
}
