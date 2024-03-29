﻿using BiometricPayroll.HELPERS;
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
    public partial class EditEmployee : Form
    {
        public EditEmployee()
        {
            InitializeComponent();
        }

        public string empID;
        private bool emailOk = true;
        public string[] employeeData = new string[17];

        private void EditEmployee_Load(object sender, EventArgs e)
        {
            string sql = $"SELECT * FROM employees WHERE id='{empID}'";
            Database db = new Database();
            employeeData = db.singleRow(sql);

            

            if(employeeData?.Length == null)
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
            txtSalary.Text = employeeData[1];
            txtFirstName.Text = employeeData[2];
            txtSecondName.Text = employeeData[3];
            txtSurname.Text = employeeData[4];
            txtJobPosition.Text = employeeData[5];
            txtAddress.Text = employeeData[6];
            txtEmail.Text = employeeData[7].ToLower();
            txtPhoneNumber.Text = employeeData[8];
            txtNationalID.Text = employeeData[9];
            maritalStatusDropDown.SelectedItem = employeeData[10];
            genderDropDown.SelectedItem = employeeData[11];
            pickerDOB.Value = DateTime.Parse(employeeData[12]);
            txtEmmergencyNo.Text = employeeData[13];
            pickerDateHired.Value = DateTime.Parse(employeeData[14]);
            workStatusDropDown.SelectedItem = employeeData[15];
        }

        private bool ValidateForm()
        {
            bool valid = false;
            
            if (
                txtAddress.Text.Length > 4 && emailOk && txtEmmergencyNo.Text.Length > 9 && txtFirstName.Text.Length >= 2 && txtJobPosition.Text.Length >= 2 && txtNationalID.Text.Length > 6 &&
                txtPhoneNumber.Text.Length >= 2 && txtSecondName.Text.Length >= 2 && txtSurname.Text.Length >= 2 &&
                txtSalary.Text.Length > 3 && genderDropDown.SelectedItem != null &&
                maritalStatusDropDown.SelectedItem != null && workStatusDropDown.SelectedItem != null
                )
            {
                valid = true;
            }
            else
            {
                
                valid = false;
            }

            return valid;
        }
        //email validation

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            emailOk = false;
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            Utilities myUtil = new Utilities();

            if (txtEmail.Text.Length > 3 && myUtil.ValidateEmail(txtEmail.Text.ToLower()))
            {
                txtEmail.BorderThickness = 1;
                txtEmail.BorderColor = SystemColors.Control;
                emailOk = true;
            }
            else
            {
                txtEmail.BorderThickness = 2;
                txtEmail.BorderColor = Color.Red;
                emailOk = false;
            }
        }

        //VALIDATING NUMBERS
        private void ValidateNumberOnKeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities util = new Utilities();
            util.NumbersOnly(e);
        }

        //VALIDATING TEXT
        private void ValidateTextOnKeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities util = new Utilities();
            util.TextOnly(e);
        }

     
        private void btnUpdatemployee_Click(object sender, EventArgs e)
        {
            if (this.ValidateForm())
            {
                Database emp = new Database();
                bool added = emp.UpdateEmployee(
                             employeeData[0],
                             txtSalary.Text.ToUpper(),
                             txtFirstName.Text.ToUpper(),
                             txtSecondName.Text.ToUpper(),
                             txtSurname.Text.ToUpper(),
                             txtJobPosition.Text.ToUpper(),
                             txtAddress.Text.ToUpper(),
                             txtEmail.Text.ToUpper(),
                             txtPhoneNumber.Text.ToUpper(),
                             txtNationalID.Text.ToUpper(),
                             maritalStatusDropDown.SelectedItem.ToString().ToUpper(),
                             genderDropDown.SelectedItem.ToString().ToUpper(),
                             pickerDOB.Value.ToString("yyyy'-'MM'-'dd"),
                             txtEmmergencyNo.Text.ToUpper(),
                             pickerDateHired.Value.ToString("yyyy'-'MM'-'dd HH':'mm':'ss"),
                             workStatusDropDown.SelectedItem.ToString().ToUpper(),
                             employeeData[16]
                        );


                if (added)
                {
                    Alert.Popup("Employee Updated!", Alert.AlertType.success);
                    DisplayEmployees.disp.loadEmployees();
                    this.Close();
                }
                else
                {
                    Alert.Popup("Unable To Update!", Alert.AlertType.error);
                    this.Close();
                }
            }
            else
            {
                Alert.Popup("Check The Form!", Alert.AlertType.warning);
            }
        }

        private void btnEmpDetailCancel_Click(object sender, EventArgs e)
        {
            InitFormData();
        }

        private void btnAllowance_Click(object sender, EventArgs e)
        {
            EmpAllowances eal = new EmpAllowances();
            eal.emplID = empID;
            eal.dataType = 1;
            this.Hide();
            eal.Show();
        }

        private void btnDeductions_Click(object sender, EventArgs e)
        {
            EmpAllowances eal = new EmpAllowances();
            eal.emplID = empID;
            eal.dataType = 0;
            this.Hide();
            eal.Show();
        }
    }
}
