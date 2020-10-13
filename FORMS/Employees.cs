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
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

       
        
        private void Employees_Load(object sender, EventArgs e)
        {
            this.openChildForm(new DisplayEmployees());
            this.pressedBtn(showAllEmployees);
        }
        private Form child = null;
        private Guna.UI2.WinForms.Guna2Button currBtn = null;

        public string selectedUserID;
        public string selectedUserWorkID;
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
            empContainerPanel.Controls.Add(child);
            empContainerPanel.Tag = child;
            child.BringToFront();
            child.Show();
        }

        private void pressedBtn(Guna.UI2.WinForms.Guna2Button cBtn)
        {
           
            if (currBtn != null)
            {
                currBtn.BorderRadius = 2;
                currBtn.Font = new Font("Nunito", 12, FontStyle.Bold);
                currBtn.BackColor = Color.White;
                currBtn.FillColor = Color.White;
                currBtn.HoverState.ForeColor = Color.White;
                currBtn.HoverState.FillColor = Color.FromArgb(94, 148, 255);
                currBtn.ForeColor = Color.FromArgb(94, 148, 255);
            }

            currBtn = cBtn;
            currBtn.BorderThickness = 0;
            currBtn.BorderRadius = 2;
            currBtn.BackColor = Color.FromArgb(94, 148, 255);
            currBtn.FillColor = Color.FromArgb(94, 148, 255);
            currBtn.ForeColor = Color.White;
            currBtn.Font = new Font("Nunito", 12, FontStyle.Bold);
            
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            this.openChildForm(new AddEmployee());
            this.pressedBtn(btnAddEmp);
            searchPanel.Visible = false;
            txtBxSearch.Visible = false;
        }

        private void showAllEmployees_Click(object sender, EventArgs e)
        {
            this.openChildForm(new DisplayEmployees());
            this.pressedBtn(showAllEmployees);

            
        }  

        public void setSelectedUser(string id, string workid)
        {
            selectedUserID = id;
            selectedUserWorkID = workid;
        }
        private void btnEditRow_Click(object sender, EventArgs e)
        {
            if (selectedUserID != null)
            {
                MessageBox.Show(selectedUserID + " " + selectedUserWorkID);
            }
            else
            {
                MessageBox.Show("EMPTY STRINGS");
            }
            
        }


       
    }
}
