﻿using BiometricPayroll.HELPERS;
using System;
using System.Windows.Forms;

namespace BiometricPayroll.FORMS
{
    public partial class Deductions : Form
    {
        public Deductions()
        {
            InitializeComponent();
        }

        private string searchQuery = "";
        private string clickedRowID;

        private bool editMode = false;
        private void Deductions_Load(object sender, EventArgs e)
        {
            loadDeductions();
            checkMode();
        }

        private void checkMode()
        {
            if (editMode)
            {
                editBtn.Text = "UPDATE";
                delBtn.Text = "DELETE";
                btnAddDeduction.Text = "";
                editBtn.Enabled = true;
                editBtn.Visible = true;
                delBtn.Visible = true;
                delBtn.Enabled = true;
                btnAddDeduction.Enabled = false;
            }else
            {
                editBtn.Text = "";
                delBtn.Text = "";
                btnAddDeduction.Text = "ADD";
                editBtn.Enabled = false;
                editBtn.Visible = false;
                delBtn.Visible = false;
                delBtn.Enabled = false;
                btnAddDeduction.Enabled = true;
            }
        }
        public void loadDeductions()
        {
            Database db = new Database();
            string Search = $"SELECT id AS ID,title AS TITLE, amount AS AMOUNT, method AS METHOD FROM taxes WHERE title LIKE '{searchQuery}%' ORDER BY id ASC";


            if (searchQuery.Length == 0)
            {
                db.LoadDTG(deductionsGridView, Constants.DEDUCTIONS_QUERY);
            }
            else if (searchQuery.Length > 0)
            {
                db.LoadDTG(deductionsGridView, Search);
            }

        }

        private bool validateDeductions()
        {
            bool valid = false;
            if (txtBxTitle.Text.Length > 2
                && deductionMethodDropDown.SelectedItem != null
                && statusDropDwn.SelectedItem != null
                && txtBxAmount.Text.Length > 0)
            {
                valid = true;
            }

            else
            {
                valid = false;
            }

            return valid;
        }
        private void btnAddDeduction_Click(object sender, EventArgs e)
        {
            if (this.validateDeductions())
            {
                string status = (statusDropDwn.SelectedItem.ToString().ToUpper() == "ACTIVE") ? "1" : "0";
            string dedVals = $" '{txtBxTitle.Text.ToUpper()}' , '{deductionMethodDropDown.SelectedItem.ToString().ToUpper()}' , '{txtBxAmount.Text}' ,'{status}'";
                string deductionQuery = $"INSERT INTO taxes (title,method,amount,status) VALUES({dedVals})";


                Database db = new Database();

                int res = db.runQuery(deductionQuery);

                if (res > 0)
                {
                    Alert.Popup("Deduction " + txtBxTitle.Text + " has been Added!", Alert.AlertType.success);

                    this.ClearForm();

                    this.loadDeductions();
                }
                else
                {
                    Alert.Popup("Failed To Add Deduction!", Alert.AlertType.error);
                }
            }
            else
            {
                Alert.Popup("Fill All Fields!", Alert.AlertType.error);
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

        private void resetImgBtn_Click(object sender, EventArgs e)
        {
            editMode = false;
            checkMode();
            this.ClearForm();
        }

        private void ClearForm()
        {
            formHeaderlbl.Text = "ADD DEDUCTION";
            txtBxTitle.Text = "";
            deductionMethodDropDown.StartIndex = -1;
            txtBxAmount.Text = "";
            statusDropDwn.StartIndex = -1;
        }

        private void deductionsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (deductionsGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    editMode = true;
                    checkMode();
                    formHeaderlbl.Text = "EDIT DEDUCTION";
                    deductionsGridView.CurrentRow.Selected = true;

                    clickedRowID = deductionsGridView.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                    txtBxTitle.Text = deductionsGridView.Rows[e.RowIndex].Cells["TITLE"].FormattedValue.ToString();
                    deductionMethodDropDown.Text = deductionsGridView.Rows[e.RowIndex].Cells["METHOD"].FormattedValue.ToString();
                    txtBxAmount.Text = deductionsGridView.Rows[e.RowIndex].Cells["AMOUNT"].FormattedValue.ToString();
                    statusDropDwn.Text = deductionsGridView.Rows[e.RowIndex].Cells["STATUS"].FormattedValue.ToString();

                }
            }
            catch (System.ArgumentOutOfRangeException OutOfRange)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "#CELL CLICK ERROR");
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            string status = (statusDropDwn.SelectedItem.ToString().ToUpper() == "ACTIVE") ? "1" : "0";
            string deductionQuery = $"UPDATE taxes SET title='{txtBxTitle.Text.ToUpper()}' , method='{deductionMethodDropDown.SelectedItem.ToString().ToUpper()}' , amount='{ txtBxAmount.Text}', status='{status}'  WHERE id='{clickedRowID}'";


            Database db = new Database();

            int res = db.runQuery(deductionQuery);

            if (res > 0)
            {
                Alert.Popup("Deduction  has been Updated!", Alert.AlertType.success);

                this.loadDeductions();
                ClearForm();
            }
            else
            {
                Alert.Popup("Failed To Update Deduction!", Alert.AlertType.error);
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            string deductionQuery = $"DELETE FROM taxes WHERE id='{clickedRowID}'";


            Database db = new Database();

            int res = db.runQuery(deductionQuery);

            if (res > 0)
            {
                Alert.Popup("Deduction  has been Deleted!", Alert.AlertType.success);

                this.loadDeductions();
                ClearForm();
            }
            else
            {
                Alert.Popup("Failed To Delete Deduction!", Alert.AlertType.error);
            }
        }
    }
}
