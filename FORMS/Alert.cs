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
                    this.BackColor = Color.SeaGreen;
                    break;
                case AlertType.info:
                    this.BackColor = Color.Gray;
                    break; 
                case AlertType.warning:
                    this.BackColor = Color.Crimson;
                    break; 
                case AlertType.error:
                    this.BackColor = Color.FromArgb(255,128,0);
                    break;
              
            }
        }

        public enum AlertType
        {
            success,
            info,
            warning,
            error
        }

        private void Alert_Load(object sender, EventArgs e)
        {
            this.Top = 7;
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
            if(this.Top < 7)
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
