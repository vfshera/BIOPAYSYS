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
                    string markAttendance = $"INSERT INTO attendance (emp_name,emp_id) VALUES(@EmpName,@EmpID)";
                    var rows = con.Execute(markAttendance, employees);

                    if (rows > 0)
                    {
                        Alert.Popup("Welcome On Board ", Alert.AlertType.success);
                        marked = true;
                    }
                    else
                    {
                        Alert.Popup("Unable To Mark Your Attendance!", Alert.AlertType.success);
                        marked = false;
                    }
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
            string sql = $"UPDATE employees SET {fieldVals} WHERE id='{currID}' AND work_id='{currWorkID}' ";

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
            string sql = "SELECT * FROM employees WHERE work_status='ACTIVE'";

            bool processed = false;

            string processedID = "";

            try
            {
                con.Open();
                cmd = new MySqlCommand();
              
                cmd.Connection = con;
                cmd.CommandText = sql;
                MySqlDataReader dr = cmd.ExecuteReader();

               
                if (dr.HasRows)
                {
                    //paycon.Open();
                    while (dr.Read())
                    {                       
                        string name = dr.GetValue(2).ToString() + " " + dr.GetValue(3).ToString() + " " + dr.GetValue(4).ToString();
                        string query = $"INSERT INTO salaries (name,emp_id, national_id, position, allowances, total_allowance, decuctions, total_deduction , gender, basic_salary, net_salary, date, joined) VALUES({name},{dr.GetValue(0).ToString()}, {dr.GetValue(9).ToString()},{dr.GetValue(5).ToString()},'0','0','0','0','{dr.GetValue(11).ToString()}', '{dr.GetValue(1).ToString()}','0','0','{dr.GetValue(14).ToString()}')";

                        MySqlCommand empD = new MySqlCommand();
                        empD.Connection = con;
                        empD.CommandText = query;
                        int res = empD.ExecuteNonQuery();

                        if (res != 0)
                        {
                            Alert.Popup(dr.GetValue(4).ToString() + "'s Salary Processed!", Alert.AlertType.success);
                            processed = true;


                            if (processedID != "")
                            {
                                processedID += "," + dr.GetValue(0).ToString();
                            }
                            else
                            {
                                processedID += dr.GetValue(0).ToString();
                            }
                        }
                        else
                        {
                            Alert.Popup("Can't Process!", Alert.AlertType.error);
                        }

                    }

                    //paycon.Close();
                    dr.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();

                if (processed)
                {
                    getAllowance(processedID);
                }
            }

        }

        public void getAllowance(string ids)
        {
            string[] emps = ids.Split(',');


            bool processed = false;

            foreach (string id in emps)
            {
                string getAll = $"SELECT * FROM allowances WHERE receiver='{id}' AND amount='AMOUNT'";

                string allowances = "";

                int totalAllowance = 0;

                try
                {
                    con.Open();
                    MySqlCommand allcmd = new MySqlCommand();
                    
                    allcmd.Connection = con;
                    allcmd.CommandText = getAll;
                    MySqlDataReader alldr = allcmd.ExecuteReader();

               
                    if (alldr.HasRows)
                    {

                        while (alldr.Read())
                        {
                            //get allowance amount
                            if(allowances != "")
                            {
                                allowances += "," + alldr.GetValue(1).ToString() + " " + alldr.GetValue(3).ToString();
                                totalAllowance += int.Parse(alldr.GetValue(3).ToString());
                            }
                        }

                        alldr.Close();

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    con.Close();
                                     
                }



                string salaryQuery = $"UPDATE salaries SET allowances='{allowances}' , total_allowances='{totalAllowance}'";

                con.Open();
                MySqlCommand upallcmd = new MySqlCommand();
                upallcmd.Connection = con;
                upallcmd.CommandText = salaryQuery;
                int res = upallcmd.ExecuteNonQuery();

                if (res > 0)
                {
                    Alert.Popup("Allowance Set", Alert.AlertType.success);

                    processed = true;
                }
                else
                {
                    Alert.Popup("Allowance Not Set", Alert.AlertType.error);
                }

                con.Close();
            }

            if (processed)
            {
                getDeduction(emps);
            }

        }


        public void getDeduction(string[] empIDs)
        {

            bool processed = false;

            foreach (string id in empIDs)
            {
                string dsql = $"SELECT * FROM deductions WHERE payer='{id}' AND amount='AMOUNT'";

                string deductions = "";

                int totalDeductions = 0;

                try
                {
                    con.Open();
                    MySqlCommand dedcmd = new MySqlCommand();

                    dedcmd.Connection = con;
                    dedcmd.CommandText = dsql;
                    MySqlDataReader dedr = dedcmd.ExecuteReader();


                    if (dedr.HasRows)
                    {

                        while (dedr.Read())
                        {
                            //get deductions amount
                            if (deductions != "")
                            {
                                deductions += "," + dedr.GetValue(1).ToString() + " " + dedr.GetValue(3).ToString();
                                deductions += int.Parse(dedr.GetValue(3).ToString());
                            }
                        }

                        dedr.Close();

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    con.Close();
                }



                string salaryQuery = $"UPDATE salaries SET deductions='{deductions}' , total_deductions='{totalDeductions}'";

                con.Open();
                MySqlCommand updedcmd = new MySqlCommand();
                updedcmd.Connection = con;
                updedcmd.CommandText = salaryQuery;
                int res = updedcmd.ExecuteNonQuery();

                if (res > 0)
                {
                  
                    processed = true;
                }
                else
                {
                    
                }

                con.Close();
            }

            if (processed)
            {
                Alert.Popup("Deductions Set", Alert.AlertType.success);


            }
            else
            {
                Alert.Popup("Deduction Not Set", Alert.AlertType.error);
            }

            getNetPay(empIDs);
        }





        public void getNetPay(string[] empIDs)
        {

            string sal = "SELECT * FROM salaries";
            int res = 0;
                try
                {
                    con.Open();
                    MySqlCommand npcmd = new MySqlCommand();

                    npcmd.Connection = con;
                    npcmd.CommandText = sal;
                    MySqlDataReader npdr = npcmd.ExecuteReader();


                    if (npdr.HasRows)
                    {

                        while (npdr.Read())
                        {
                            int net = (int.Parse(npdr.GetValue(10).ToString()) + int.Parse(npdr.GetValue(5).ToString())) - int.Parse(npdr.GetValue(7).ToString());

                            string netQuery = $"UPDATE salaries SET net_salary='{net.ToString()}' WHERE id='{npdr.GetValue(0).ToString()}'";
                                
                            npcmd.CommandText = netQuery;

                            res = npcmd.ExecuteNonQuery();
                                                                        

                        }

                    npdr.Close();

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    con.Close();
                }


            if (res > 0)
            {
                Alert.Popup("Payroll Finished Process!", Alert.AlertType.success);

            }
            else
            {
                Alert.Popup("Failed To Process!", Alert.AlertType.error);
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
