using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiometricPayroll.Models
{
    public class FPTemplate
    {
        public int id { get; set; }
        public string owner { get; set; }
        public string type { get; set; }
        public Byte[] fingerprint { get; set; }

    }
}
