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
    public partial class Allowances : Form
    {
        public Allowances()
        {
            InitializeComponent();
        }




        private string searchQuery = "";
        private string clickedRowID;

        private bool editMode = false;
        private void Allowances_Load(object sender, EventArgs e)
        {
            loadAllowances();
            checkMode();
        }

        private void checkMode()
        {
            if (editMode)
            {
                editBtn.Text = "UPDATE";
                delBtn.Text = "DELETE";
                btnAddAllowance.Text = "";
                editBtn.Enabled = true;
                editBtn.Visible = true;
                delBtn.Visible = true;
                delBtn.Enabled = true;
                btnAddAllowance.Enabled = false;
            }
            else
            {
                editBtn.Text = "";
                delBtn.Text = "";
                btnAddAllowance.Text = "ADD";
                editBtn.Enabled = false;
                editBtn.Visible = false;
                delBtn.Visible = false;
                delBtn.Enabled = false;
                btnAddAllowance.Enabled = true;
            }
        }
        public void loadAllowances()
        {
            Database db = new Database();
            string Search = $"SELECT id AS ID,title AS TITLE, amount AS AMOUNT, method AS METHOD FROM advances WHERE title LIKE '{searchQuery}%' ORDER BY id ASC";


            if (searchQuery.Length == 0)
            {
                db.LoadDTG(allowanceGridView, Constants.ALLOWANCES_QUERY);
            }
            else if (searchQuery.Length > 0)
            {
                db.LoadDTG(allowanceGridView, Search);
            }

        }

        private bool validateAllowances()
        {
            bool valid = false;
            if (txtBxTitle.Text.Length > 2
                && allowanceMethodDropDown.SelectedItem != null
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
        private void btnAddAllowance_Click(object sender, EventArgs e)
        {
            if (this.validateAllowances())
            {
                string status = (statusDropDwn.SelectedItem.ToString().ToUpper() == "ACTIVE") ? "1" : "0";
                string dedVals = $" '{txtBxTitle.Text.ToUpper()}' , '{allowanceMethodDropDown.SelectedItem.ToString().ToUpper()}' , '{txtBxAmount.Text}' ,'{status}'";
                string AllowanceQuery = $"INSERT INTO advances (title,method,amount,status) VALUES({dedVals})";


                Database db = new Database();

                int res = db.runQuery(AllowanceQuery);

                if (res > 0)
                {
                    Alert.Popup("Allowance " + txtBxTitle.Text + " has been Added!", Alert.AlertType.success);

                    this.ClearForm();

                    this.loadAllowances();
                }
                else
                {
                    Alert.Popup("Failed To Add Allowance!", Alert.AlertType.error);
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
            formHeaderlbl.Text = "ADD ALLOWANCE";
            txtBxTitle.Text = "";
            allowanceMethodDropDown.StartIndex = -1;
            txtBxAmount.Text = "";
            statusDropDwn.StartIndex = -1;
        }

        private void allowanceGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (allowanceGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    editMode = true;
                    checkMode();
                    formHeaderlbl.Text = "EDIT Allowance";
                    allowanceGridView.CurrentRow.Selected = true;

                    clickedRowID = allowanceGridView.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                    txtBxTitle.Text = allowanceGridView.Rows[e.RowIndex].Cells["TITLE"].FormattedValue.ToString();
                    allowanceMethodDropDown.Text = allowanceGridView.Rows[e.RowIndex].Cells["METHOD"].FormattedValue.ToString();
                    txtBxAmount.Text = allowanceGridView.Rows[e.RowIndex].Cells["AMOUNT"].FormattedValue.ToString();
                    statusDropDwn.Text = allowanceGridView.Rows[e.RowIndex].Cells["STATUS"].FormattedValue.ToString();

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
            string AllowanceQuery = $"UPDATE advances SET title='{txtBxTitle.Text.ToUpper()}' , method='{allowanceMethodDropDown.SelectedItem.ToString().ToUpper()}' , amount='{ txtBxAmount.Text}', status='{status}'  WHERE id='{clickedRowID}'";


            Database db = new Database();

            int res = db.runQuery(AllowanceQuery);

            if (res > 0)
            {
                Alert.Popup("Allowance  has been Updated!", Alert.AlertType.success);

                this.loadAllowances();
                ClearForm();
            }
            else
            {
                Alert.Popup("Failed To Update Allowance!", Alert.AlertType.error);
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            string AllowanceQuery = $"DELETE FROM advances WHERE id='{clickedRowID}'";


            Database db = new Database();

            int res = db.runQuery(AllowanceQuery);

            if (res > 0)
            {
                Alert.Popup("Allowance  has been Deleted!", Alert.AlertType.success);

                this.loadAllowances();
                ClearForm();
            }
            else
            {
                Alert.Popup("Failed To Delete Allowance!", Alert.AlertType.error);
            }
        }
    }
}
