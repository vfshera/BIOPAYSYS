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
    public partial class Alert : Form
    {
        public Alert(string message , AlertType type)
        {
            InitializeComponent();

            alertMessage.Text = message;

            switch (type)
            {
                case AlertType.success:
                    this.BackColor = Color.FromArgb(40, 167, 69); 
                    break;
                case AlertType.info:
                    this.BackColor = Color.FromArgb(23, 162, 184);
                    break; 
                case AlertType.warning:
                    this.BackColor = Color.FromArgb(255, 193, 7);
                    break; 
                case AlertType.error:
                    this.BackColor = Color.FromArgb(220, 53, 69);
                    break;
                case AlertType.primary:
                    this.BackColor = Color.FromArgb(0, 123, 255);
                    break;

            }
        }

        public enum AlertType
        {
            success,//40,167,69
            info,//23,162,184
            warning,
            error,
            primary  
        }

        private void Alert_Load(object sender, EventArgs e)
        {
            this.Top = 8;
            this.Left = (Screen.PrimaryScreen.Bounds.Width / 2) - (this.Width / 2) ;
        }

        public static void Popup(string message, AlertType type)
        {
            new Alert(message, type).Show();
        }


        private void TimeOutTimer_Tick(object sender, EventArgs e)
        {
            
                this.Close();
           
        }



        int interval = 0;
        private void revealTimer_Tick(object sender, EventArgs e)
        {
            if(this.Top < 8)
            {
                this.Top += interval;
                interval += 2;
            }
            else
            {
                revealTimer.Stop();
            }
        }

    }
}
