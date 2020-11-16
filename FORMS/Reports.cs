using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiometricPayroll.HELPERS;
using Ganss.Excel;
using Microsoft.Office.Interop.Excel;

namespace BiometricPayroll.FORMS
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }
        private void btnAttendanceReport_Click(object sender, EventArgs e)
        {
            Alert.Popup($"Showing  Attendance For {dateFilter.Value.ToString("MMMM yyyy")}!", Alert.AlertType.success);

            AttendanceReport ar = new AttendanceReport();
            ar.dateLike = dateFilter.Value.ToString("yyyy-MM");
            ar.Show();
        }
        private void btnSalary_Click(object sender, EventArgs e)
        {
            Alert.Popup($"Showing  Attendance For {dateFilter.Value.ToString("MMMM yyyy")}!", Alert.AlertType.success);

            SalaryReport sr = new SalaryReport();
            sr.dateLike = dateFilter.Value.ToString("yyyy-MM");
            sr.Show();
        }

        private void btnEmps_Click(object sender, EventArgs e)
        {
            EmployeesReport er = new EmployeesReport();
            er.Show();
        }

        private void btnSalaryExcel_Click(object sender, EventArgs e)
        {
            ExcelMapper em =  new ExcelMapper();

            var newSalaryFile = @"D:\salary_report_" + DateTime.Now.Ticks.ToString() + ".xlsx";

            Database db = new Database();
            var empData = db.getSalaryReport();

            em.Save(newSalaryFile,empData,"Salary Report",true);

            Alert.Popup("Salary Report Saved!",Alert.AlertType.success);

        
           
        }

        private void btnEmpExcel_Click(object sender, EventArgs e)
        {
            ExcelMapper em = new ExcelMapper();

            var empRepFile = @"D:\employees_report_" + DateTime.Now.Ticks.ToString() + ".xlsx";

            Database db = new Database();
            var empData = db.getEmployeeReport();

            em.Save(empRepFile, empData, "Employees Report", true);

            Alert.Popup("Employees Report Saved!", Alert.AlertType.success);

          

        }

        private void printAttendanceBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void attendanceExcelBtn_Click(object sender, EventArgs e)
        {
            ExcelMapper em = new ExcelMapper();

            var attRepFile = @"D:\attendance_report_" + DateTime.Now.Ticks.ToString() + ".xlsx";

            Database db = new Database();
            var empData = db.getAttendanceReport();

            em.Save(attRepFile, empData, "Attendance Report", true);

            Alert.Popup("Attendance Report Saved!", Alert.AlertType.success);
        }

      
    }
}
