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
    public partial class AttendanceReport : Form
    {
        public AttendanceReport()
        {
            InitializeComponent();
        }

        private void AttendanceReport_Load(object sender, EventArgs e)
        {
            Database db = new Database();

            db.LoadDTG(attendanceReprtGV, Constants.ATTENDANCE_REPORT_QUERY);
        }
    }
}
