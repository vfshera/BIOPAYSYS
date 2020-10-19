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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private bool emailOk = false;
        private void AddEmployee_Load(object sender, EventArgs e)
        {
            
        }

        private void ClearFields()
        {
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtEmmergencyNo.Text = "";
            txtFirstName.Text = "";
            txtJobPosition.Text = "";
            txtNationalID.Text = "";
            txtPhoneNumber.Text = "";
            txtSecondName.Text = "";
            txtSurname.Text = "";
            txtWorkID.Text = "";
            genderDropDown.StartIndex = -1;
            maritalStatusDropDown.StartIndex = -1;
            workStatusDropDown.StartIndex = -1;
        }
        private void btnEmpDetailCancel_Click(object sender, EventArgs e)
        {
            this.ClearFields();
        }

        private bool ValidateForm()
        {
            bool valid = false;
            if(
                txtAddress.Text.Length > 4  &&  emailOk &&  txtEmmergencyNo.Text.Length > 9 &&
                txtFirstName.Text != "" && txtJobPosition.Text != "" && txtNationalID.Text.Length > 6 &&
                txtPhoneNumber.Text.Length >= 2 && txtSecondName.Text.Length >= 2 && txtSurname.Text.Length >= 2 &&
                txtWorkID.Text.Length > 3 && genderDropDown.SelectedItem != null &&
                maritalStatusDropDown.SelectedItem != null  && workStatusDropDown.SelectedItem != null
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

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
          if(this.ValidateForm())
            {
                Database emp = new Database();
                bool added = emp.AddEmployee(
                             txtWorkID.Text.ToUpper(),
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
                             workStatusDropDown.SelectedItem.ToString().ToUpper()
                        );


                if (added)
                {
                    Alert.Popup("Employee Added!", Alert.AlertType.success);
                    this.ClearFields();
                }
                else
                {
                    Alert.Popup("Unable To Add Employee!", Alert.AlertType.error);
                }
            }
            else
            {
                Alert.Popup("Check The Form!", Alert.AlertType.warning);
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

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            Utilities myUtil = new Utilities();

            if(myUtil.ValidateEmail(txtEmail.Text.ToLower()))
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

       
    }
}
