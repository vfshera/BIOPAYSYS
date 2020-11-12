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
        public GeneratePay()
        {
            InitializeComponent();
            db = new Database();
        }

        private void GeneratePay_Load(object sender, EventArgs e)
        {
            ResponsiveUI.fitFormToScreen(this, 842, 1373);
            this.CenterToScreen();

            getWHtimer.Enabled = true;

            loadEmp();
        }

       private void loadEmp()
        {
            db.LoadDTG(empListGV, Constants.EMP_QUERY);
        }

        private void getWHtimer_Tick(object sender, EventArgs e)
        {
            getSIzelbl.Text = "H : " + this.Height.ToString() + ", W : " + this.Width.ToString();
        }


        private void empListGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (empListGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    empListGV.CurrentRow.Selected = true;

                    SelectedRowID = empListGV.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();

                    
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
    }
}
