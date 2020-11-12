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
    public partial class Payroll : Form
    {
        public Payroll()
        {
            InitializeComponent();
        }

        private Guna.UI.WinForms.GunaAdvenceButton currBtn = null;

        private Form child = null;


        private void Payroll_Load(object sender, EventArgs e)
        {
            openChildForm(new GeneratePay());
            pressedBtn(generatePay);
          
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            Alert.Popup("Printing...", Alert.AlertType.success);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Alert.Popup("Printing...", Alert.AlertType.success);
        }

        private void generatePay_Click(object sender, EventArgs e)
        {
            Alert.Popup("Printing...", Alert.AlertType.success);
        }

       

        private void pressedBtn(Guna.UI.WinForms.GunaAdvenceButton cBtn)
        {
         
            if (currBtn != null)
            {
                currBtn.BackColor = Color.FromArgb(66, 58, 170);
                currBtn.BaseColor = Color.FromArgb(66, 58, 170);
                currBtn.LineColor = Color.FromArgb(66, 58, 170);
                currBtn.ForeColor = Color.White;
            }

            currBtn = cBtn;
          
            cBtn.BackColor = Color.White;
            cBtn.BaseColor = Color.White;
            cBtn.LineColor = Color.White;
            cBtn.ForeColor = Color.FromArgb(66, 58, 170);

        }

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
            parentPanel.Controls.Add(child);
            parentPanel.Tag = child;
            child.BringToFront();
            child.Show();
        }
    }
}
