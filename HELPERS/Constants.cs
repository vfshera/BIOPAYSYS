using System;
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

        //APP KEY
        public const string BIOPAYSYS_KEY = "q4GxaarGguyHkzd8VvczFuWpspeW";
        //ENDAPPKEY

        public const string ALLOWANCES_QUERY = "SELECT id AS ID,title AS TITLE, amount AS AMOUNT, method AS METHOD ,status AS STATUS FROM advances ORDER BY id ASC";
        public const string DEDUCTIONS_QUERY = "SELECT id AS ID,title AS TITLE, amount AS AMOUNT, method AS METHOD ,status AS STATUS FROM taxes ORDER BY id ASC";
       public const string EMP_QUERY = "SELECT id AS ID,salary AS SALARY, CONCAT_WS(' ' , first_name , surname) AS NAME,position AS JOB FROM employees ORDER BY id ASC";

        public const string EMPLOYEES_QUERY = "SELECT id AS ID,salary AS SALARY, CONCAT_WS(' ' , first_name , surname) AS NAME,position AS JOB,phonenumber AS CONTACT,email AS EMAIL,gender AS GENDER,work_status AS 'WORK STATUS' FROM employees ORDER BY id ASC";
       public const string USERS_QUERY = "SELECT id AS ID,name AS NAME ,email AS EMAIL, type AS TYPE FROM users  ORDER BY id ASC";

        public const string ATTENDANCE_QUERY = "SELECT emp_name AS NAME,emp_id AS 'EMP ID',in_time AS 'IN TIME',out_time AS 'OUT TIME',date AS DATE FROM attendance";
    }
}
