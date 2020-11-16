using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiometricPayroll.Models
{
    public class EmpSalaryReport
    {

        public string NAME { get; set; }
        public string POSITION { get; set; }
        public string ALLOWANCE { get; set; }
        public string DEDUCTIONS { get; set; }
        public string BASIC_SALARY { get; set; }
        public string NET_SALARY { get; set; }
    }
}
