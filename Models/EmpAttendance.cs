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
    }
}
