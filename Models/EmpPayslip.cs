using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiometricPayroll.Models
{
    public class EmpPayslip
    {
        public int id { get; set; }
        public string name {
            get{
                return first_name + " " + sec_name + " " + surname;
                }
        }
        public string first_name { get; set; }
        public string sec_name { get; set; }
        public string surname { get; set; }
        public string emp_id { get; set; }
        public string national_id { get; set; }
        public string position { get; set; }    
        public string allowances { get; set; }
        public string total_allowance { get; set; }
        public string deductions { get; set; }
        public string total_deduction { get; set; }
        public string gender { get; set; }
        public string salary { get; set; }
        public string net_salary { get; set; }
        public string date {
            get
            {
                return DateTime.Now.ToString("yyyy-MM-dd");
            }
        }
        public string joined { get; set; }
        public string date_hired { get; set;}
        public string created_at {
            get {
                return DateTime.Now.ToString("yyyy-MM-dd");
            } 
        }
        public string updated_at { get; set; }
     
    }
}
