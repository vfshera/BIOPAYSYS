using BiometricPayroll.FORMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiometricPayroll.HELPERS;

namespace BiometricPayroll
{
    public partial class frmLogin : Form
    {
        bool errOnLogin = false;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            loader.Visible = false;
            lblLoginText.Visible = false;
        }
        public bool validateForm()
        {
            bool valid = false;
            Utilities util = new Utilities();

            if (util.ValidateEmail(txtBxUsername.Text.ToLower()) && txtBxPassword.Text != null && txtBxPassword.Text.ToLower() != "password")
            {
                valid = true;
            }
            else
            {
                valid = false;
                errOnLogin = true;
                this.checkError();
            }
            return valid;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                btnLogin.BackColor = Color.White;

                loader.Visible = true;
                lblLoginText.Visible = true;
                lblLoginText.BackColor = Color.Transparent;
                loader.BackColor = Color.Transparent;

                Database db = new Database();
                Utilities utils = new Utilities();

                string[] loggedUser = new string[3];

                
                loggedUser = db.Login(txtBxUsername.Text.ToLower(), utils.HashPassword(txtBxPassword.Text));
                /*
                db.Register(txtBxUsername.Text , utils.HashPassword(txtBxPassword.Text));

                */
                if (loggedUser[0] != null)
                {
                    Dashboard dash = new Dashboard();
                    dash.displayName = loggedUser[1];
                    dash.myEmail = loggedUser[2];
                    dash.myID = loggedUser[0];
                    this.Hide();
                    dash.Show();

                }
                else if (loggedUser[0] == null)
                {
                    loader.Visible = false;
                    lblLoginText.Visible = false;

                    btnLogin.BackColor = Color.Green;
                    errOnLogin = true;
                    this.checkError();
                }



            }


        }


        public void checkError()
        {
            if (errOnLogin)
            {
                passLine.BackColor = Color.Red;
                usernameLine.BackColor = Color.Red;
                txtBxUsername.ForeColor = Color.Red;
                txtBxPassword.ForeColor = Color.Red;
                btnLogin.BorderRadius = 5;
                btnLogin.BorderThickness = 1;
            }
            else
            {
                passLine.BackColor = SystemColors.ButtonShadow;
                usernameLine.BackColor = SystemColors.ButtonShadow;
                txtBxUsername.ForeColor = SystemColors.WindowText;
                txtBxPassword.ForeColor = SystemColors.WindowText;
                btnLogin.BorderRadius = 5;
                btnLogin.BorderThickness = 1;
            }
        }

        private void txtBxPassword_Enter(object sender, EventArgs e)
        {
            txtBxPassword.PasswordChar = '*';
            txtBxPassword.Text = "";
            txtBxPassword.ForeColor = SystemColors.WindowText;
            passLine.BackColor = SystemColors.ButtonShadow;
        }

        private void txtBxUsername_Enter(object sender, EventArgs e)
        {
            txtBxUsername.Text = "";
            usernameLine.BackColor = SystemColors.ButtonShadow;
            txtBxUsername.ForeColor = SystemColors.WindowText;
        }

        private void txtBxUsername_Leave(object sender, EventArgs e)
        {
            Utilities myUtil = new Utilities();

            if (myUtil.ValidateEmail(txtBxUsername.Text.ToLower()))
            {
                usernameLine.BackColor = Color.Green;
                usernameLine.FillColor = Color.Green;
                txtBxUsername.ForeColor = Color.Green;
              
            }
            else
            {
                usernameLine.BackColor = Color.Red;
                usernameLine.FillColor = Color.Red;
                txtBxUsername.ForeColor = Color.Red;
            }
        }
    }
}
