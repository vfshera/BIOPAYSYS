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
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
        }

        public string searchQuery = "";
            public string searchTxt = "";
        public string searchDate = "";

        private void Attendance_Load(object sender, EventArgs e)
        {
            loadLoadAttendance();
        }


        public void loadLoadAttendance()
        {
            Database db = new Database();
            string Search = $"SELECT emp_name AS Name,emp_work_id AS 'WORK ID',in_time AS IN,out_time AS OUT,date AS DATE FROM attendance WHERE first_name LIKE '{searchQuery}%' OR  surname LIKE '{searchQuery}%' ORDER BY id ASC";


            if (searchQuery.Length == 0)
            {
                db.LoadDTG(attendanceListDGV, Constants.ATTENDANCE_QUERY);
            }
            else if (searchQuery.Length > 0)
            {
                db.LoadDTG(attendanceListDGV, Search);
            }


        }
    }
}
