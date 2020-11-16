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
    public partial class EmpAllowances : Form
    {
        Database db;
        public EmpAllowances()
        {
            InitializeComponent();
            db = new Database();
        }

        public string emplID;
        public int dataType;

        public string search;
        public string selectedRowID;
        private void EmpAllowances_Load(object sender, EventArgs e)
        {
            choose();
        }

        public void choose()
        {
            if (dataType == 0)
            {
                loadDeductions();

            }
            else if (dataType == 1)
            {
                loadAllowances();
            }
        }
        public void loadAllowances()
        {
            string sql = $"SELECT id AS ID, title AS TITLE, method AS METHOD, amount AS AMOUNT FROM allowances WHERE receiver ='{emplID}'";

            if(search != null)
            {
                sql += $" AND title LIKE '{search}%'";
            }

            db.LoadDTG(allowancesDGV,sql);
        }

        public void loadDeductions()
        {
            string sql = $"SELECT id AS ID, title AS TITLE, method AS METHOD, amount AS AMOUNT FROM deductions WHERE payer ='{emplID}'";

            if (search != null)
            {
                sql += $" AND title LIKE '{search}%'";
            }

            db.LoadDTG(allowancesDGV, sql);
        }


        private bool ValidateForm()
        {
            bool valid = false;
            if (txtAmount.Text.Length > 2 && txtTitle.Text.Length > 2 && dropMethod.SelectedItem != null){
                valid = true;
            }
            else
            {
                valid = false;
            }

            return valid;
        }

        private void clearForm()
        {
            txtAmount.Text = "";
                txtTitle.Text = "";
            dropMethod.SelectedIndex = -1;
        }
        private void addAllowanceBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                string query = "";
                if (dataType == 0)
                {
                     query = $"INSERT INTO deductions (title,method,amount,payer,status) VALUES('{txtTitle.Text.ToUpper()}','{dropMethod.SelectedItem.ToString().ToUpper()}','{txtAmount.Text.ToUpper()}','{emplID}','1')";

                }
                else if(dataType == 1)
                {
                     query = $"INSERT INTO allowances (title,method,amount,receiver,status) VALUES('{txtTitle.Text.ToUpper()}','{dropMethod.SelectedItem.ToString().ToUpper()}','{txtAmount.Text.ToUpper()}','{emplID}','1')";
                }


               int res = db.runQuery(query);

                if(res > 0)
                {
                    Alert.Popup("Successfully Added!", Alert.AlertType.success);
                    clearForm();
                    choose();

                }
                else
                {
                    Alert.Popup("Unable To Add", Alert.AlertType.error);
                }
            }
            else
            {
                Alert.Popup("FORM INCOMPLETE", Alert.AlertType.error);
            }
        }

        private void txtBxSearch_TextChanged(object sender, EventArgs e)
        {
            choose();
        }
        private void toggleEditBTN(bool state)
        {
            btnEditAllowance.Enabled = state;
            btnEditAllowance.Visible = state;
            deleteAllowanceBtn.Enabled = state;
            deleteAllowanceBtn.Visible = state;
        }
        private void allowancesDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                if (allowancesDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    allowancesDGV.CurrentRow.Selected = true;

                    selectedRowID = allowancesDGV.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                    txtTitle.Text = allowancesDGV.Rows[e.RowIndex].Cells["TITLE"].FormattedValue.ToString();
                    txtAmount.Text = allowancesDGV.Rows[e.RowIndex].Cells["AMOUNT"].FormattedValue.ToString();
                    dropMethod.SelectedItem = allowancesDGV.Rows[e.RowIndex].Cells["METHOD"].FormattedValue.ToString();

                    toggleEditBTN(true);
                }
            }
            catch (System.ArgumentOutOfRangeException OutOfRange)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEditAllowance_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                string query = "";
                if (dataType == 0)
                {
                    query = $"UPDATE deductions SET title='{txtTitle.Text.ToUpper()}',method='{dropMethod.SelectedItem.ToString().ToUpper()}',amount='{txtAmount.Text.ToUpper()}' WHERE id='{selectedRowID}'";

                }
                else if (dataType == 1)
                {
                    query = $"UPDATE allowances SET title='{txtTitle.Text.ToUpper()}',method='{dropMethod.SelectedItem.ToString().ToUpper()}',amount='{txtAmount.Text.ToUpper()}' WHERE id='{selectedRowID}'";
                }


                int res = db.runQuery(query);

                if (res > 0)
                {
                    Alert.Popup("Successfully Updated!", Alert.AlertType.success);
                    clearForm();
                    choose();

                }
                else
                {
                    Alert.Popup("Unable To Update", Alert.AlertType.error);
                }
            }
            else
            {
                Alert.Popup("FORM INCOMPLETE", Alert.AlertType.error);
            }
        }

        private void deleteAllowanceBtn_Click(object sender, EventArgs e)
        {
            if (selectedRowID != null)
            {
                string query = "";
                if (dataType == 0)
                {
                    query = $"DELETE FROM deductions  WHERE id='{selectedRowID}'";

                }
                else if (dataType == 1)
                {
                    query = $"DELETE FROM allowances  WHERE id='{selectedRowID}'";
                }


                int res = db.runQuery(query);

                if (res > 0)
                {
                    Alert.Popup("Successfully Deleted!", Alert.AlertType.success);
                    clearForm();
                    choose();

                }
                else
                {
                    Alert.Popup("Unable To Delete", Alert.AlertType.error);
                }
            }
            else
            {
                Alert.Popup("CAN'T FIND ID", Alert.AlertType.error);
            }
        }
    }
}
