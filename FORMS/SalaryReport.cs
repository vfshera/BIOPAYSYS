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
    public partial class SalaryReport : Form
    {
        public SalaryReport()
        {
            InitializeComponent();
        }

        public string dateLike = "";
        private void SalaryReport_Load(object sender, EventArgs e)
        {
            Database db = new Database();

            db.LoadDTG(salaryReprtGV, Constants.SALARIES_REPORT_QUERY + $" WHERE date LIKE '{dateLike}%' ");
        }
    }
}
