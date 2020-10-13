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

        private MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=biopaysys;sslMode=none");
        private MySqlCommand cmd;
        private MySqlDataAdapter da;
        public DataTable dt;
        int result;

        public string[] Login(string username, string pass)
        {
            string sql = "SELECT id , name , email FROM users WHERE email=@username AND password=@password";

            string[] user = new string[3];
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
                    MessageBox.Show("Successfully Registered");
                }
                else
                {
                    MessageBox.Show("Failed To Register");
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


        public bool AddEmployee(string work_id, string first_name, string sec_name, string surname, string position, string address, string email, string phonenumber, string marital_status, string gender, string date_of_birth, string emmergency_tel, string date_hired, string work_status)
        {
            string fields = "work_id, first_name,sec_name, surname, position, address, email, phonenumber, marital_status, gender, date_of_birth, emmergency_tel, date_hired, work_status, created_at, updated_at";
            string vals = "@work_id,@first_name,@sec_name,@surname,@position, @address, @email, @phonenumber, @marital_status, @gender, @date_of_birth, @emmergency_tel, @date_hired, @work_status, @created_at, @updated_at";
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
                cmd.Parameters.AddWithValue("@marital_status", marital_status);
                cmd.Parameters.AddWithValue("@gender", gender);  
                cmd.Parameters.AddWithValue("@date_of_birth", date_of_birth);
                cmd.Parameters.AddWithValue("@emmergency_tel", emmergency_tel);   
                cmd.Parameters.AddWithValue("@date_hired", date_hired);
                cmd.Parameters.AddWithValue("@work_status", work_status);  
                cmd.Parameters.AddWithValue("@created_at", currTime);
                cmd.Parameters.AddWithValue("@updated_at", currTime);
                result = cmd.ExecuteNonQuery();

               added =  result > 0;
            
            

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
        public void Execute_CUD(string sql, string msg_false, string msg_true)
        {
            try
            {
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show(msg_true);
                }
                else
                {
                    MessageBox.Show(msg_false);
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
        public void Execute_Query(string sql)
        {
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
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void LoadDTG(Guna2DataGridView dg)
        {
            string sql = "SELECT id AS ID,work_id AS 'WORK ID', CONCAT_WS(' ' , first_name , surname) AS NAME,position AS JOB,phonenumber AS CONTACT,email AS EMAIL,gender AS GENDER,work_status AS 'WORK STATUS' FROM employees ORDER BY id ASC";
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
        public void fiil_CBO(string sql, ComboBox cbo)
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
                cbo.DataSource = dt;
                cbo.ValueMember = "ID";
                cbo.DisplayMember = "Name";


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
        public void singleResult(string sql)

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
