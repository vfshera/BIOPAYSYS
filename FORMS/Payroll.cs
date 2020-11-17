using BiometricPayroll.HELPERS;
using BiometricPayroll.Models;
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
        Database db;
        public Payroll()
        {
            InitializeComponent();
            db = new Database();
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
            printPayslipPreviewDialog.Document = printDocument1;

            printPayslipPreviewDialog.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {


            Database db = new Database();

            List<Payslip> payslips =  db.GetPayslips();
           
            foreach(Payslip payslip in payslips)
            {
                //dashes
                string longDash = "-------------------------------------------------------------------------------------------------------------------------------------";
                //enddashes
                e.Graphics.DrawString("BIOMETRIC PAYROLL", new System.Drawing.Font("Century Gothic", 26, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(260, 50));
                e.Graphics.DrawString(longDash, new System.Drawing.Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(30, 1050));

                //e.Graphics.DrawRectangle(new System.Drawing.Pen(System.Drawing.Color.DarkGray),new System.Drawing.Rectangle(new System.Drawing.Point(0,1000), new System.Drawing.Size(850,100)));
                e.Graphics.DrawLine(new System.Drawing.Pen(System.Drawing.Color.DarkGray), 30, 100, 820, 100);



                //NAME
                e.Graphics.DrawString("NAME : ", new System.Drawing.Font("Century Gothic", 16, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(50, 150));
                e.Graphics.DrawString(payslip.NAME, new System.Drawing.Font("Century Gothic", 16, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(380, 150));


           
                //POSITION
                e.Graphics.DrawString("DESIGNATION : ", new System.Drawing.Font("Century Gothic", 16, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(50, 220));
                e.Graphics.DrawString(payslip.POSITION, new System.Drawing.Font("Century Gothic", 16, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(380, 220));

                //printed date
                e.Graphics.DrawString("PROCESSED ON : ", new System.Drawing.Font("Century Gothic", 16, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(50, 270));

                e.Graphics.DrawString(DateTime.Parse(payslip.created_at).ToString("ddd, dd MMMM yyyy"), new System.Drawing.Font("Century Gothic", 14, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(380, 270));



                //ALLOWANCES    
                e.Graphics.DrawString("ALLOWANCES : ", new System.Drawing.Font("Century Gothic", 16, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(50, 370));


                e.Graphics.DrawString(payslip.ALLOWANCE, new System.Drawing.Font("Century Gothic", 16, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 420));
               
                e.Graphics.DrawString(int.Parse(payslip.TOTAL_ALLOWANCE).ToString("#,###"), new System.Drawing.Font("Century Gothic", 16, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(650, 440));

                e.Graphics.DrawLine(new System.Drawing.Pen(System.Drawing.Color.DarkGray), 620, 480, 740, 480);
                e.Graphics.DrawLine(new System.Drawing.Pen(System.Drawing.Color.DarkGray), 620, 485, 740, 485);


                e.Graphics.DrawLine(new System.Drawing.Pen(System.Drawing.Color.DarkGray), 30, 510, 820, 510);



                //DEDUCTIONS   
                e.Graphics.DrawString("DEDUCTIONS : ", new System.Drawing.Font("Century Gothic", 16, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(50, 650));
                
                e.Graphics.DrawString(payslip.DEDUCTIONS, new System.Drawing.Font("Century Gothic", 16, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 700));
               
                e.Graphics.DrawString(int.Parse(payslip.TOTAL_DEDUCTIONS).ToString("#,###"), new System.Drawing.Font("Century Gothic", 16, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(650, 720));
              
                e.Graphics.DrawLine(new System.Drawing.Pen(System.Drawing.Color.DarkGray), 620, 760, 740, 760);
                e.Graphics.DrawLine(new System.Drawing.Pen(System.Drawing.Color.DarkGray), 620, 765, 740, 765);


                e.Graphics.DrawLine(new System.Drawing.Pen(System.Drawing.Color.DarkGray), 30, 790, 820, 790);



                //BASIC
                e.Graphics.DrawString("BASIC SALARY : ", new System.Drawing.Font("Century Gothic", 18, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(50, 900));
                e.Graphics.DrawString(payslip.BASIC_SALARY, new System.Drawing.Font("Century Gothic", 18, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(380, 900));


                //NET
                e.Graphics.DrawString("NET SALARY : ", new System.Drawing.Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(50, 990));
                e.Graphics.DrawString(int.Parse(payslip.NET_SALARY).ToString("#,###"), new System.Drawing.Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(380, 990));
               
               

            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            //Alert.Popup("Preparing Payroll...", Alert.AlertType.success);
            db.setPayroll();
            //payrolStart();
        }

        private async void payrolStart()
        {

            try
            {
                Salary payslip = await Requests.processPay();
                Alert.Popup(payslip.Message, Alert.AlertType.success);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


        //private async void getJP()
        //{
        //    JPlaceHolder post = await Requests.getPost();
        //    Alert.Popup(post.Title, Alert.AlertType.success);
        //}

        private void generatePay_Click(object sender, EventArgs e)
        {
            
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
