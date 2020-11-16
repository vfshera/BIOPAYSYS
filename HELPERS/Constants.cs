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

        public const string TEMPLATES_QUERY = "SELECT * FROM templetes";
       
        public const string EMP_REPORT_QUERY = "SELECT CONCAT_WS(' ' ,first_name, sec_name, surname) AS NAME, position AS POSITION, address AS ADDRESS, email AS EMAIL, phonenumber AS PHONE FROM employees";
        public const string ATTENDANCE_REPORT_QUERY = "SELECT emp_name AS NAME,in_time AS 'IN_TIME',out_time AS 'OUT_TIME',date AS DATE FROM attendance";
        public const string SALARIES_REPORT_QUERY = "SELECT name AS NAME, position AS POSITION, total_allowance AS ALLOWANCE, total_deduction AS DEDUCTIONS,basic_salary AS 'BASIC SALARY', net_salary AS 'NET SALARY' FROM salaries";
        public const string PAYSLIP_QUERY = "SELECT name AS NAME, position AS POSITION, allowances AS ALLOWANCE, total_allowance AS TOTAL_ALLOWANCE,deductions AS DEDUCTIONS,total_deduction AS TOTAL_DEDUCTIONS,basic_salary AS 'BASIC_SALARY', net_salary AS 'NET_SALARY' FROM salaries";
      
        public const string ALLOWANCES_QUERY = "SELECT id AS ID,title AS TITLE, amount AS AMOUNT, method AS METHOD ,status AS STATUS FROM advances ORDER BY id ASC";
        public const string DEDUCTIONS_QUERY = "SELECT id AS ID,title AS TITLE, amount AS AMOUNT, method AS METHOD ,status AS STATUS FROM taxes ORDER BY id ASC";
       public const string EMP_QUERY = "SELECT id AS ID,salary AS SALARY, CONCAT_WS(' ' , first_name , surname) AS NAME,position AS JOB FROM employees ORDER BY id ASC";

        public const string EMPLOYEES_QUERY = "SELECT id AS ID,salary AS SALARY, CONCAT_WS(' ' , first_name , surname) AS NAME,position AS JOB,phonenumber AS CONTACT,email AS EMAIL,gender AS GENDER,work_status AS 'WORK STATUS' FROM employees ORDER BY id ASC";
       public const string USERS_QUERY = "SELECT id AS ID,name AS NAME ,email AS EMAIL, type AS TYPE FROM users  ORDER BY id ASC";

        public const string ATTENDANCE_QUERY = "SELECT emp_name AS NAME,emp_id AS 'EMP ID',in_time AS 'IN TIME',out_time AS 'OUT TIME',date AS DATE FROM attendance";
    }
}
