using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiometricPayroll.Models
{
    public class EmpDeduction
    {
        public int id { get; set; }
        public string title { get; set; }
        public string method { get; set; }
        public string amount { get; set; }
    }
}
