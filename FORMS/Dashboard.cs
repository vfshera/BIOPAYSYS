using System;
using BiometricPayroll;
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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private Guna.UI2.WinForms.Guna2Button currBtn = null;

        private Form child = null;

        private void pressedBtn(Guna.UI2.WinForms.Guna2Button cBtn)
        {
            if (currBtn != null)
            {
                currBtn.FillColor = Color.Transparent;
                currBtn.ForeColor = Color.White;
            }

            currBtn = cBtn;
            lblCurrentTask.Text = cBtn.Text;
            cBtn.FillColor = Color.White;
            cBtn.ForeColor = Color.FromArgb(253, 104, 84);
            cBtn.Font = new Font("Nunito", 12, FontStyle.Bold);

        }

        private void openChildForm(Form cForm)
        {
            if(child != null)
            {
                child.Close(); 
            }

            child = cForm;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(child);
            pnlContainer.Tag = child;
            child.BringToFront();
            child.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmLogin login = new frmLogin();
            login.Show();
        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            this.pressedBtn(btnPayroll);
            this.openChildForm(new Payroll());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            this.pressedBtn(btnReports);
            this.openChildForm(new Reports());
        }

        private void btnDeductions_Click(object sender, EventArgs e)
        {
            this.pressedBtn(btnDeductions);
            this.openChildForm( new Deductions());
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            this.pressedBtn(btnEmployees);
            this.openChildForm(new Employees());
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            this.pressedBtn(btnDash);

            if (child != null)
            {
                child.Close();
            }
        }
    }
}
