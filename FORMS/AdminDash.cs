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
    public partial class AdminDash : Form
    {
        public string displayName;
        public string myID;
        public string myEmail;
        public string role;
        public AdminDash()
        {
            InitializeComponent();
        }

        private void AdminDash_Load(object sender, EventArgs e)
        {
            makeDashRound.BorderRadius = 30;
            if (displayName != "")
            {
                lblUserNameDisplay.Text = displayName;
            }
            else
            {
                lblUserNameDisplay.Text = "Username";
            }
        }


        private Guna.UI2.WinForms.Guna2Button currBtn = null;

        private Form child = null;

        private void btnDash_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();


            this.pressedBtn(btnDash);

            if (child != null)
            {
                child.Close();
            }

            dash.Text = "Biometric Payroll";
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            displayName = "";
            myID = "";
            myEmail = "";
            role = "";
            this.Hide();

            frmLogin login = new frmLogin();
            login.Show();
        }

        private void pressedBtn(Guna.UI2.WinForms.Guna2Button cBtn)
        {
            Dashboard dash = new Dashboard();
            if (currBtn != null)
            {
                currBtn.FillColor = Color.Transparent;
                currBtn.ForeColor = Color.White;
            }

            currBtn = cBtn;
            lblCurrentTask.Text = cBtn.Text;
            this.Text = "Biometric Payroll - " + cBtn.Text;
            cBtn.FillColor = Color.White;
            cBtn.ForeColor = Color.FromArgb(253, 104, 84);
            cBtn.Font = new Font("Nunito", 12, FontStyle.Bold);

        }

        private void openChildForm(Form cForm)
        {
            if (child != null)
            {
                child.Close();
            }

            child = cForm;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(child);
            pnlContainer.Tag = child;
            child.BringToFront();
            child.Show();
        }

      

       
        private void btnUsers_Click(object sender, EventArgs e)
        {
            
            this.pressedBtn(btnUsers);
           this.openChildForm(new Users()); 
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {

            this.pressedBtn(btnAddUser);
            this.openChildForm(new AddUsers());
        }

    

        private void gunaMaximizeBtn_Click(object sender, EventArgs e)
        {
            toggleBorderRadius();
        }

        public void toggleBorderRadius()
        {
            if (makeDashRound.BorderRadius == 0)
            {
                makeDashRound.BorderRadius = 30;
            }
            else if (makeDashRound.BorderRadius == 30)
            {
                makeDashRound.BorderRadius = 0;
            }
        }

        private void gunaMinimizeBtn_Click(object sender, EventArgs e)
        {
            toggleBorderRadius();
        }

        public void setCurrTask(string name)
        {
            this.lblCurrentTask.Text = name;
        }


    }
}
   