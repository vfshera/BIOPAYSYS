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
        public static Employees emp;
        public Employees()
        {
            InitializeComponent();

            emp = this;
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
        public string selectedUserName;
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
            txtBxSearch.Visible = false;
        }

        private void showAllEmployees_Click(object sender, EventArgs e)
        {
            this.openChildForm(new DisplayEmployees());
            this.pressedBtn(showAllEmployees);
            txtBxSearch.Visible = true;

        }  

        public void setSelectedUser(string id, string workid,string name)
        {
            selectedUserID = id;           
            selectedUserWorkID = workid;           
            selectedUserName = name;           
        }
        private void btnEditRow_Click(object sender, EventArgs e)
        {
            if (selectedUserID != null && selectedUserWorkID != null)
            {/*
                EditEmployee edit = new EditEmployee();
                edit.empID = selectedUserID;
                edit.empWorkID = selectedUserWorkID;
                edit.Show();*/

                EmployeeFPConfirm ec = new EmployeeFPConfirm();

                ec.SelectedRowID = selectedUserID;
                ec.SelectedRowWorkID = selectedUserWorkID;
                ec.SelectedUserName = selectedUserName;

                ec.Show();
            }
            else
            {

                Alert.Popup("Please Select A Field To Edit!", Alert.AlertType.warning);
            }        
        }

        private void txtBxSearch_TextChanged(object sender, EventArgs e)
        {
            DisplayEmployees.disp.searchQuery = txtBxSearch.Text.ToUpper();
            DisplayEmployees.disp.loadEmployees();
        }

        private void empContainerPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
