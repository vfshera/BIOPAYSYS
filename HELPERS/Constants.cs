﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiometricPayroll.HELPERS
{
    class Constants
    {
        //db connection string
        public const string CONNECTION = "server=localhost;user id=root;database=biopaysys;sslMode=none";




       public const string DEDUCTIONS_QUERY = "SELECT id AS ID,title AS TITLE, amount AS AMOUNT, method AS METHOD FROM taxes ORDER BY id ASC";
       public const string EMPLOYEES_QUERY = "SELECT id AS ID,work_id AS 'WORK ID', CONCAT_WS(' ' , first_name , surname) AS NAME,position AS JOB,phonenumber AS CONTACT,email AS EMAIL,gender AS GENDER,work_status AS 'WORK STATUS' FROM employees ORDER BY id ASC";

    }
}
