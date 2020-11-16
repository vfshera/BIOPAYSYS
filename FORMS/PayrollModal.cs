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
    public partial class PayrollModal : Form
    {
        public PayrollModal()
        {
            InitializeComponent();
        }

        public string sqlState;
        public string id;
        public string title;
        public string btnStr;
        public string tableName;
        private string newValue;

        private void PayrollModal_Load(object sender, EventArgs e)
        {
            txtInfo.Text = title;
            txtInfo.TextAlign = ContentAlignment.MiddleCenter;
            btnAction.Text = btnStr;
            autoClosetmr.Enabled = true;
            setDefaults();
        }

        private void autoClosetmr_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setDefaults()
        {
            if(sqlState == "0")
            {
                newValue = "1";
            }
            else if (sqlState == "1")
            {
                newValue = "0";
            }
            else
            {
                newValue = "0";
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            string sql = $"UPDATE {tableName} SET status='{newValue}' WHERE id='{id}' ";

            MessageBox.Show("--"+sqlState+" -- "+sql);

            Database db = new Database();

            if(db.runQuery(sql) > 0)
            {
                Alert.Popup("Status Updated", Alert.AlertType.success);

                GeneratePay.payroll.fetchObligations();
                autoClosetmr.Stop();
                this.Close();
            }
            else
            {
                Alert.Popup("Failed To Update Status", Alert.AlertType.error);
            }
        }
    }
}
