using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Guna.UI2.WinForms;
using BiometricPayroll.FORMS;
using Dapper;
using BiometricPayroll.Models;

namespace BiometricPayroll.HELPERS
{
    class Database
    {

        private MySqlConnection con = new MySqlConnection(Constants.CONNECTION);
        private MySqlConnection paycon = new MySqlConnection(Constants.CONNECTION);

        private MySqlCommand cmd;
        private MySqlDataAdapter da;
        public DataTable dt;
        int result;

        public string[] Login(string username, string pass)
        {
            string sql = "SELECT id , name , email , type ,status FROM users WHERE email=@username AND password=@password";

            string[] user = new string[4];
            try
            {
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", pass);

                MySqlDataReader dr = cmd.ExecuteReader();
                            

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        

                        if (dr.GetValue(4).ToString() != "0")
                        {
                           
                            user[0] = dr.GetValue(0).ToString();
                            user[1] = dr.GetValue(1).ToString();
                            user[2] = dr.GetValue(2).ToString();
                            user[3] = dr.GetValue(3).ToString();
                        }
                        else
                        {
                            Alert.Popup("ACCOUNT BLOCKED!",Alert.AlertType.error);
                        }
                       
                      
                    }
                }
               
                dr.Close();                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return user;
        }

        public bool Register( string username, string email, string type, string pass)
        {
            string sql = "INSERT INTO users (name,email,type,password) VALUES(@username , @email,@type , @password)";
           
            try
            {
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@password", pass);
                result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    getAddedUser(email, username);

                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return result > 0;
        }

        public void getAddedUser(string email, string name)
        {
            string sql = $"SELECT id FROM users WHERE email='{email}' AND  name='{name}'";

            try
            {

                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                Object o = cmd.ExecuteScalar();

                if (o != null)
                {
                    AddUsers.addUsr.addedUserID =  o.ToString();
             
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public bool AddEmp(string salary, string first_name, string sec_name, string surname, string position, string address, string email, string phonenumber, string nationalID, string marital_status, string gender, string date_of_birth, string emmergency_tel, string date_hired, string work_status)
        {
            string fields = "salary, first_name,sec_name, surname, position, address, email, phonenumber,national_id, marital_status, gender, date_of_birth, emmergency_tel, date_hired, work_status, created_at, updated_at";
            string vals = "@salary,@first_name,@sec_name,@surname,@position, @address, @email, @phonenumber,@nationalid, @marital_status, @gender, @date_of_birth, @emmergency_tel, @date_hired, @work_status, @created_at, @updated_at";
            string sql = $"INSERT INTO employees ({fields}) VALUES({vals})";

            bool added = false;
           

            try
            {
                string currTime = DateTime.Now.ToString("yyyy'-'MM'-'dd HH':'mm':'ss");
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@salary", salary);
                cmd.Parameters.AddWithValue("@first_name", first_name);  
                cmd.Parameters.AddWithValue("@sec_name", sec_name);
                cmd.Parameters.AddWithValue("@surname", surname);  
                cmd.Parameters.AddWithValue("@position", position);
                cmd.Parameters.AddWithValue("@address", address);   
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@phonenumber", phonenumber);  
                cmd.Parameters.AddWithValue("@nationalid", nationalID);  
                cmd.Parameters.AddWithValue("@marital_status", marital_status);
                cmd.Parameters.AddWithValue("@gender", gender);  
                cmd.Parameters.AddWithValue("@date_of_birth", date_of_birth);
                cmd.Parameters.AddWithValue("@emmergency_tel", emmergency_tel);   
                cmd.Parameters.AddWithValue("@date_hired", date_hired);
                cmd.Parameters.AddWithValue("@work_status", work_status);  
                cmd.Parameters.AddWithValue("@created_at", currTime);
                cmd.Parameters.AddWithValue("@updated_at", currTime);
                result = cmd.ExecuteNonQuery();


                if(result > 0)
                {
                    added = result > 0;
                    getAddedEmp(email, nationalID);
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return added;
        }

        public void getAddedEmp(string email,string natID)
        {
            string sql = $"SELECT id FROM employees WHERE email='{email}' AND  national_id='{natID}'";

            try
            {

                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                Object o = cmd.ExecuteScalar();

               

                if (o != null)
                {
                    AddEmployee.addEmp.empID  = o.ToString();
                    AddEmployee.addEmp.setID();
                }

              

            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        public List<Models.EmployeesReport> getEmployeeReport()
        {
            List<Models.EmployeesReport> emps = null;

            using (con)
            {
                emps = con.Query<Models.EmployeesReport>(Constants.EMP_REPORT_QUERY).ToList();
            }


            return emps;
        }

        public List<Models.AttendanceReport> getAttendanceReport()
        {
            List<Models.AttendanceReport> attendance = null;

            using (con)
            {
                attendance = con.Query<Models.AttendanceReport>(Constants.ATTENDANCE_REPORT_QUERY).ToList();
            }

            return attendance;
        }

        public List<EmpSalaryReport> getSalaryReport()
        {
            List<EmpSalaryReport> empReport = null;

            using (con)
            {
                empReport = con.Query<EmpSalaryReport>(Constants.SALARIES_REPORT_QUERY).ToList();
            }

            return empReport;

        }


        public List<Payslip> GetPayslips()
        {
            List<Payslip> pay = null;

            using (con)
            {
                pay = con.Query<Payslip>(Constants.PAYSLIP_QUERY).ToList();
            }

            return pay;

        }

        public bool updateFP(string owner, string type, Byte[] fp)
        {
            bool reg = false;

            string sql = $"UPDATE templetes SET fingerprint=@finger WHERE owner=@owner AND type=@type";

            try
            {
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@finger", fp);
                cmd.Parameters.AddWithValue("@owner", owner);
                cmd.Parameters.AddWithValue("@type", type);

                result = cmd.ExecuteNonQuery();

                reg = result > 0;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return reg;
        }

        public bool RegFP(string owner , string type , Byte[] fp)
        {
            bool reg = false;

            string sql = "INSERT INTO templetes (owner,type,fingerprint) VALUES(@owner_id,@type,@fingerprint)";

            try
            {
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@owner_id", owner);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@fingerprint", fp);

                result = cmd.ExecuteNonQuery();

                reg = result > 0;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return reg;
        }

        public List<FPTemplate> GetFPTemplates()
        {
            List<FPTemplate> templates;

            bool found = false;
            
            using (con)
            {
                templates = con.Query<FPTemplate>(Constants.TEMPLATES_QUERY).ToList();
            }

          

            return templates;
        }

        public bool FetchMatchedEmp(string empID)
        {
            bool marked = false;
           List<EmpAttendance> employees;
            string checkedIn = $"SELECT * FROM employees WHERE id={empID}";

            using (con)
            {
                employees = con.Query<EmpAttendance>(checkedIn).ToList();

               
            }


            if (employees != null)
            {
                using (con)
                {
                   // List<EmpAttendance> attendedEMPS;

                   // attendedEMPS = con.Query<EmpAttendance>($"SELECT * FROM attendance WHERE emp_id={empID} AND in_time LIKE '{DateTime.Now.ToString("yyyy-MM")}%' ").ToList();

                   //if(attendedEMPS == null)
                   // {
                        string markAttendance = $"INSERT INTO attendance (emp_name,emp_id,in_time,out_time,date) VALUES(@EmpName,@EmpID,@CheckInTime,@CheckOutTime,@AttendingDate)";
                        var rows = con.Execute(markAttendance, employees);

                        if (rows > 0)
                        {
                            Alert.Popup("Welcome On Board", Alert.AlertType.success);
                            marked = true;
                        }
                        else
                        {
                            Alert.Popup("Unable To Mark Your Attendance!", Alert.AlertType.error);
                            marked = false;
                        }
                    //}
                    //else
                    //{
                    //    foreach(EmpAttendance att in attendedEMPS)
                    //    {
                    //        con.Execute($"UPDATE attendance SET out_time='{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}' WHERE emp_id={empID}");
                    //    }
                    //}
                }
            }
            else
            {
                Alert.Popup("Employee Not Found!", Alert.AlertType.error);
            }


            return marked;
        }

        public Byte[] GetFP(int owner,int type)
        {
            bool reg = false;

            string sql = $"SELECT fingerprint FROM templetes WHERE owner='{owner}' AND type='{type}'";

            Byte[] fprint = null;
           try{
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                      fprint = (Byte[])dr.GetValue(0);
                    
                    }
                }

                dr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return fprint;
        }

        public bool UpdateUser(string uID,string name,string pass ,string type, string email)
        {
            string sql = $"UPDATE users SET name = '{name}', email = '{email}',type = '{type}',password = '{pass}' WHERE id='{uID}' ";

            bool updated = false;

            try
            {
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
               
                result = cmd.ExecuteNonQuery();

                updated = result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return updated;
        }
        public bool UpdateEmployee(string currID,string currWorkID, string first_name, string sec_name, string surname, string position, string address, string email, string phonenumber,string nationalID ,string marital_status, string gender, string date_of_birth, string emmergency_tel, string date_hired, string work_status, string created_at)
        {
            string fieldVals = "first_name = @first_name,sec_name = @sec_name, surname = @surname, position = @position, address = @address, email = @email , phonenumber = @phonenumber,national_id = @nationalid, marital_status = @marital_status, gender = @gender, date_of_birth = @date_of_birth, emmergency_tel = @emmergency_tel, date_hired = @date_hired, work_status = @work_status, created_at = @created_at, updated_at = @updated_at";
            string sql = $"UPDATE employees SET {fieldVals} WHERE id='{currID}'";

            bool updated = false;
            try
            {
                string currTime = DateTime.Now.ToString("yyyy'-'MM'-'dd HH':'mm':'ss");
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@first_name", first_name);
                cmd.Parameters.AddWithValue("@sec_name", sec_name);
                cmd.Parameters.AddWithValue("@surname", surname);
                cmd.Parameters.AddWithValue("@position", position);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@phonenumber", phonenumber);
                cmd.Parameters.AddWithValue("@nationalid", nationalID);
                cmd.Parameters.AddWithValue("@marital_status", marital_status);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@date_of_birth", date_of_birth);
                cmd.Parameters.AddWithValue("@emmergency_tel", emmergency_tel);
                cmd.Parameters.AddWithValue("@date_hired", date_hired);
                cmd.Parameters.AddWithValue("@work_status", work_status);
                cmd.Parameters.AddWithValue("@created_at", created_at);
                cmd.Parameters.AddWithValue("@updated_at", currTime);
                result = cmd.ExecuteNonQuery();

                updated = result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return updated;
        }
    
        public int runQuery(string sql)
        {
            int result = 0;

            try
            {
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                result = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Alert.Popup(ex.Message, Alert.AlertType.error);
            }
            finally
            {
                con.Close();
            }

            return result;
        }


        
        public void LoadDTG(Guna2DataGridView dg,string myQuery)
        {
          
            try
            {
                con.Open();
                cmd = new MySqlCommand();
                da = new MySqlDataAdapter();
                dt = new DataTable();

                cmd.Connection = con;
                cmd.CommandText = myQuery;
                da.SelectCommand = cmd;
                da.Fill(dt);
                dg.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                da.Dispose();
            }

        }

        public void getPayrollFields(string sql,Guna.UI.WinForms.GunaLabel firstname, Guna.UI.WinForms.GunaLabel secname, Guna.UI.WinForms.GunaLabel surname, Guna.UI.WinForms.GunaLabel position, Guna.UI.WinForms.GunaLabel salary, Guna.UI.WinForms.GunaLabel natID, Guna.UI.WinForms.GunaLabel gender, Guna.UI.WinForms.GunaLabel joined)
        {
   
            try
            {
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                         
                        firstname.Text = dr.GetValue(0).ToString();
                        secname.Text =  dr.GetValue(1).ToString();
                        surname.Text=  dr.GetValue(2).ToString();
                        position.Text = "Job : " + dr.GetValue(3).ToString();
                        salary.Text = "B.Salary : " + dr.GetValue(4).ToString();
                        natID.Text = "Nat.ID : " + dr.GetValue(5).ToString();
                        gender.Text = "Sex : " + dr.GetValue(6).ToString();
                        joined.Text = "Joined On : " + DateTime.Parse(dr.GetValue(7).ToString()).ToString("ddd, dd MMM yyyy");
                       
                    }
                }

                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }


        }



        public void setPayroll()
        {
            string sqlGetEmps = "SELECT * FROM employees WHERE work_status='ACTIVE'";

            int result = 0;
            string sqlSalaryInsert = $"INSERT INTO salaries (name,emp_id, national_id, position, allowances, total_allowance, deductions, total_deduction , gender, basic_salary, net_salary, date, joined,created_at) VALUES(@name,@emp_id, @national_id, @position, @allowances, @total_allowance, @deductions, @total_deduction , @gender, @basic_salary, @net_salary, @date, @joined,@created_at)";

            List<EmpPayslip> employees;

            using (con)
            {
                employees = con.Query<EmpPayslip>(sqlGetEmps).ToList();

                if(employees != null)
                {
                    foreach (EmpPayslip emp in employees)
                    {
                        //allowances
                        string payableAllowance = "";
                        int totalEmpAllowance = 0;

                        string sqlGetEmpAllowance = $"SELECT * FROM allowances WHERE receiver='{emp.id}' AND status='1'";
                       
                        List<EmpAllowance> allowanceList = con.Query<EmpAllowance>(sqlGetEmpAllowance).ToList();
                       
                        foreach(EmpAllowance allo in allowanceList)
                        {
                            int amount = (allo.method == "AMOUNT") ? int.Parse(allo.amount) : (int)(Double.Parse(allo.amount) * Double.Parse(emp.salary));

                            if (payableAllowance != null)
                            {
                                payableAllowance = payableAllowance + allo.title + " " + amount.ToString() + ",";
                                
                            }
                            else
                            {
                                
                                    payableAllowance +=  allo.title + " " + amount.ToString();
                              
                            }

                            totalEmpAllowance += amount;
                        }

                        //end allowances




                        //advances

                        string payableAdvances = "";
                        int totalEmpAdvances = 0;
                        string sqlGetEmpAdvance = $"SELECT * FROM advances WHERE  status='1'";

                        List<EmpAllowance> advancesList = con.Query<EmpAllowance>(sqlGetEmpAllowance).ToList();

                        foreach (EmpAllowance advance in advancesList)
                        {
                            int advanceAmount = (advance.method == "AMOUNT") ? int.Parse(advance.amount) : (int)(Double.Parse(advance.amount) * Double.Parse(emp.salary));

                            if (payableAdvances != null)
                            {
                                payableAdvances = payableAdvances+ advance.title + " " + advanceAmount.ToString() + ",";
                            }
                            else
                            {
                               
                                    payableAdvances += advance.title + " " + advanceAmount.ToString();
                              
                            }

                            totalEmpAdvances += advanceAmount;
                        }

                        //end advances




                        //deductions
                        string payableDeductions = "";
                        int totalEmpDeduction = 0;
                        string sqlGetEmpDeductions = $"SELECT * FROM deductions WHERE payer='{emp.id}' AND status='1'";

                        List<EmpAllowance> deductionsList = con.Query<EmpAllowance>(sqlGetEmpDeductions).ToList();

                        foreach (EmpAllowance deduction in deductionsList)
                        {
                            int deductionAmount = (deduction.method == "AMOUNT") ? int.Parse(deduction.amount) : (int)(Double.Parse(deduction.amount) * Double.Parse(emp.salary));

                            if (payableDeductions != null)
                            {
                                payableDeductions = payableDeductions + deduction.title + " " + deductionAmount.ToString() + ",";
                            }
                            else
                            {
                               payableDeductions += deduction.title + " " + deductionAmount.ToString();
                               
                            }

                            totalEmpDeduction += deductionAmount;
                        }

                        //end deductions


                        //taxes

                        string payableTaxes = "";
                        int totalEmpTaxes = 0;
                        string sqlGetEmpTaxes = $"SELECT * FROM taxes WHERE status='1'";

                        List<EmpAllowance> taxesList = con.Query<EmpAllowance>(sqlGetEmpTaxes).ToList();

                        foreach (EmpAllowance tax in taxesList)
                        {
                            int taxAmount = (tax.method == "AMOUNT") ? int.Parse(tax.amount) : (int)(Double.Parse(tax.amount) * Double.Parse(emp.salary));

                            if (payableTaxes != null)
                            {
                                payableTaxes = payableTaxes + tax.title + " " + taxAmount.ToString() + ",";
                            }
                            else
                            {
                                payableTaxes += tax.title + " " + taxAmount.ToString();

                            }

                            totalEmpTaxes += taxAmount;
                        }

                        //end taxes



                        int basicSalary = (int.Parse(emp.salary) > 0) ? int.Parse(emp.salary) : 0;

                        int finalDeductions = totalEmpTaxes + totalEmpDeduction;

                        string finalDeductionList = payableDeductions + "," + payableTaxes;

                        int finalAllowance = totalEmpAdvances + totalEmpAllowance;

                        string finalAllowanceList = payableAdvances +" "+ payableAllowance;

                        int net_payable = (basicSalary + finalAllowance) - finalDeductions;

                         result = con.Execute(sqlSalaryInsert, new { name=emp.name, emp_id=emp.id, national_id=emp.national_id, position=emp.position, allowances=finalAllowanceList, total_allowance=finalAllowance.ToString(), deductions=finalDeductionList, total_deduction=finalDeductions.ToString(), gender=emp.gender, basic_salary=emp.salary, net_salary=net_payable.ToString(), date=emp.date, joined=emp.date_hired, created_at=emp.created_at });


                       
                    }
                }
            }

            if (result > 0)
            {
                Alert.Popup("PAYROLL PROCESSED!",Alert.AlertType.success);
              }else
            {
                Alert.Popup("PAYROLL NOT PROCESSED!", Alert.AlertType.error);
            }
        }




         public string[] singleRow(string sql)
        {
            string[] emp = new string[17];
            try
            {
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        emp[0] = dr.GetValue(0).ToString();
                        emp[1] = dr.GetValue(1).ToString();
                        emp[2] = dr.GetValue(2).ToString();
                        emp[3] = dr.GetValue(3).ToString();
                        emp[4] = dr.GetValue(4).ToString();
                        emp[5] = dr.GetValue(5).ToString();
                        emp[6] = dr.GetValue(6).ToString();
                        emp[7] = dr.GetValue(7).ToString();
                        emp[8] = dr.GetValue(8).ToString();
                        emp[9] = dr.GetValue(9).ToString();
                        emp[10] = dr.GetValue(10).ToString();
                        emp[11] = dr.GetValue(11).ToString();
                        emp[12] = dr.GetValue(12).ToString();
                        emp[13] = dr.GetValue(13).ToString();
                        emp[14] = dr.GetValue(14).ToString();
                        emp[15] = dr.GetValue(15).ToString();
                        emp[16] = dr.GetValue(16).ToString();
                        emp[17] = dr.GetValue(17).ToString();
                    }
                }

                dr.Close();

            }
            catch (System.IndexOutOfRangeException indexOutOfRange)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            

            return emp;
        }

        public void loadReports(string sql)

        {
            try
            {
                con.Open();
                cmd = new MySqlCommand();
                da = new MySqlDataAdapter();
                dt = new DataTable();


                cmd.Connection = con;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                da.Dispose();
            }
        }
    }
}
