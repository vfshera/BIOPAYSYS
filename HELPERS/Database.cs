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

namespace BiometricPayroll.HELPERS
{
    class Database
    {

        private MySqlConnection con = new MySqlConnection(Constants.CONNECTION);
        private MySqlCommand cmd;
        private MySqlDataAdapter da;
        public DataTable dt;
        int result;

        public string[] Login(string username, string pass)
        {
            string sql = "SELECT id , name , email , type FROM users WHERE email=@username AND password=@password";

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
                        
                        user[0] = dr.GetValue(0).ToString();
                        user[1] = dr.GetValue(1).ToString();
                        user[2] = dr.GetValue(2).ToString();
                        user[3] = dr.GetValue(3).ToString();
                       
                      
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

        public void Register( string username, string pass)
        {
            string sql = "INSERT INTO users (name,type,password) VALUES(@username , 0, @password)";
           
            try
            {
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", pass);
                result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    Alert.Popup("User Registered!", Alert.AlertType.success);
                }
                else
                {
                    Alert.Popup("Failed To Register User!", Alert.AlertType.error);
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
        }

       
        public bool AddEmp(string work_id, string first_name, string sec_name, string surname, string position, string address, string email, string phonenumber, string nationalID, string marital_status, string gender, string date_of_birth, string emmergency_tel, string date_hired, string work_status)
        {
            string fields = "work_id, first_name,sec_name, surname, position, address, email, phonenumber,national_id, marital_status, gender, date_of_birth, emmergency_tel, date_hired, work_status, created_at, updated_at";
            string vals = "@work_id,@first_name,@sec_name,@surname,@position, @address, @email, @phonenumber,@nationalid, @marital_status, @gender, @date_of_birth, @emmergency_tel, @date_hired, @work_status, @created_at, @updated_at";
            string sql = $"INSERT INTO employees ({fields}) VALUES({vals})";

            bool added = false;
           

            try
            {
                string currTime = DateTime.Now.ToString("yyyy'-'MM'-'dd HH':'mm':'ss");
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@work_id", work_id);
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
                MessageBox.Show(sql);
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
