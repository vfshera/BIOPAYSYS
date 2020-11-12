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
    public partial class GeneratePay : Form
    {
        Database db;

        public static GeneratePay payroll;
        public GeneratePay()
        {
            InitializeComponent();
            payroll = this;
            db = new Database();
        }

        string SelectedRowID;

        int currViewState = 0;

        string query = "";
        private void GeneratePay_Load(object sender, EventArgs e)
        {
            ResponsiveUI.fitFormToScreen(this, 842, 1373);
            this.CenterToScreen();

          
            loadEmp();
            setCurrentView(0);
        }

       private void loadEmp()
        {
            db.LoadDTG(empListGV, Constants.EMP_QUERY);
        }
     
        private void setCurrentView(int state)
        {
            currViewState = state;
            restrictBtnClick();
        }

        private void restrictBtnClick()
        {
            if (currViewState == 1)
            {
                btnAllowance.Enabled = false;
                btnAllowance.ForeColor = Color.FromArgb(178,178,178);
                btnDeductions.ForeColor = Color.FromArgb(0, 0, 0);
                btnDeductions.Enabled = true;
            }
            else if (currViewState == 0)
            {
                btnDeductions.Enabled = false;
                btnAllowance.Enabled = true;
                btnDeductions.ForeColor = Color.FromArgb(178, 178, 178);
                btnAllowance.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }
        private void empListGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (empListGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    empListGV.CurrentRow.Selected = true;

                   SelectedRowID = empListGV.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();

                    string sql = $"SELECT first_name, sec_name, surname,position,salary,national_id,gender,date_hired FROM employees WHERE id='{SelectedRowID}' ";


                    db.getPayrollFields(sql,curEmpFN,curEmpSN,curEmpSurname,lblPosition, curEmpSalary, curEmpNatID,curEmpGender,curEmpJoined);

                    fetchObligations();
                }
            }
            catch (System.ArgumentOutOfRangeException OutOfRange)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"#CELL CLICK ERROR");
            }
        }


        public void fetchObligations()
        {

            if(currViewState == 1)
            {
                query = $"SELECT id AS ID,title AS TITLE, amount AS AMOUNT, method AS METHOD , status AS STATUS FROM allowances WHERE receiver='{SelectedRowID}' ORDER BY id ASC";

                db.LoadDTG(DedAllGV, query);
                stateLeadlbl.Text = "ALLOWANCES";
            }
            else if (currViewState == 0)
            {
                query = $"SELECT id AS ID,title AS TITLE, amount AS AMOUNT, method AS METHOD ,status AS STATUS FROM deductions WHERE payer='{SelectedRowID}' ORDER BY id ASC";

                db.LoadDTG(DedAllGV, query);

                stateLeadlbl.Text = "DEDUCTIONS";
            }
            else
            {
                Alert.Popup("Can't Load Query Type!", Alert.AlertType.error);
            }
        }

        private void btnAllowance_Click(object sender, EventArgs e)
        {
            setCurrentView(1);
            if(SelectedRowID != null)
            {
                fetchObligations();
            }
            else
            {
                Alert.Popup("Select Employee First!", Alert.AlertType.error);
            }
            
        }

        private void btnDeductions_Click(object sender, EventArgs e)
        {
            setCurrentView(0);
            if (SelectedRowID != null)
            {
                fetchObligations();
            }
            else
            {
                Alert.Popup("Select Employee First!", Alert.AlertType.error);
            }

        }

    
        private void DedAllGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (DedAllGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    DedAllGV.CurrentRow.Selected = true;

                   

                    PayrollModal pmodal = new PayrollModal();
                    pmodal.title = (DedAllGV.Rows[e.RowIndex].Cells["STATUS"].FormattedValue.ToString() == "1") ? DedAllGV.Rows[e.RowIndex].Cells["TITLE"].FormattedValue.ToString().ToUpper()+" IS ACTIVE" : DedAllGV.Rows[e.RowIndex].Cells["TITLE"].FormattedValue.ToString().ToUpper() + " IS INACTIVE";
                    pmodal.id = DedAllGV.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                    pmodal.btnStr = (DedAllGV.Rows[e.RowIndex].Cells["STATUS"].FormattedValue.ToString() == "1") ? "DEACTIVATE?" : "ACTIVATE?";
                    pmodal.sqlState = DedAllGV.Rows[e.RowIndex].Cells["STATUS"].FormattedValue.ToString();
                    pmodal.tableName = (currViewState == 0) ? "deductions" : "allowances";
                    pmodal.Show();


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
    }
}
