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
    public partial class EmployeesReport : Form
    {
        public EmployeesReport()
        {
            InitializeComponent();
        }

        private void EmployeesReport_Load(object sender, EventArgs e)
        {
            Database db = new Database();

            db.LoadDTG(employeesReprtGV,Constants.EMP_REPORT_QUERY);
        }
    }
}
