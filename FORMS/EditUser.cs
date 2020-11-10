using BiometricPayroll.HELPERS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiometricPayroll.FORMS
{
    public partial class EditUser : Form
    {
        public EditUser()
        {
            InitializeComponent();
        }

        public string[] userData = new string[17];
        public string userID;
        private void EditUser_Load(object sender, EventArgs e)
        {
            string sql = $"SELECT id AS ID,name AS NAME,email AS EMAIL, type AS TYPE FROM users WHERE id='{userID}'";
            Database db = new Database();
            userData = db.singleRow(sql);



            if (userData?.Length == null)
            {

                Alert.Popup("Select A Field First!", Alert.AlertType.warning);
            }
            else
            {
                InitFormData();

            }

        }


        private void InitFormData()
        {
            txtEmail.Text = userData[2];
            txtName.Text = userData[1];
           
            roleDropDown.SelectedIndex = int.Parse(userData[3]);
        }
    }
}
