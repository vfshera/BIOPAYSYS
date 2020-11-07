using BiometricPayroll.HELPERS;
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
        private void Deductions_Load(object sender, EventArgs e)
        {
            loadDeductions();
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
                string dedVals = $" '{txtBxTitle.Text.ToUpper()}' , '{deductionMethodDropDown.SelectedItem.ToString().ToUpper()}' , {txtBxAmount.Text}";
                string deductionQuery = $"INSERT INTO taxes (title,method,amount) VALUES({dedVals})";


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
            this.ClearForm();
        }

        private void ClearForm()
        {
            txtBxTitle.Text = "";
            deductionMethodDropDown.StartIndex = -1;
            txtBxAmount.Text = "";
        }
    }
}
