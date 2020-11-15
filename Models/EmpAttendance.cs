using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiometricPayroll.Models
{
    public class EmpAttendance
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string sec_name { get; set; }
        public string surname { get; set; }
        public string position { get; set; }

        public string EmpName
        {
            get
            {
                return $"{first_name} {sec_name} {surname}";
            }
        }

        public string EmpID
        {
            get
            {
                return $"{id}";
            }
        }


        public string CheckInTime
        {
            get
            {

                return (int.Parse(DateTime.Now.ToString("HH")) < 12) ? DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") : "";
            }
        }


        public string CheckOutTime
        {
            get
            {

                return (int.Parse(DateTime.Now.ToString("HH")) > 14) ? DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") : "";
            }
        }

        public string AttendingDate
        {
            get
            {

                return  DateTime.Now.ToString("yyyy-MM-dd");
            }
        }
    }
}
