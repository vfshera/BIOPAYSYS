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
        public DisplayEmployees()
        {
            InitializeComponent();
        }

        private void DisplayEmployees_Load(object sender, EventArgs e)
        {
            Database db = new Database();

            db.LoadDTG(empTableGrid);
        }

    
     
        private void empTableGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (empTableGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                empTableGrid.CurrentRow.Selected = true;

                string id = empTableGrid.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                string workid = empTableGrid.Rows[e.RowIndex].Cells["WORK ID"].FormattedValue.ToString();

                using (Employees emp = new Employees())
                {
                   emp.setSelectedUser(id, workid);
                }
             
                
            }
        }
    }
}
