namespace BiometricPayroll.FORMS
{
    partial class Alert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.alertElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.alertMessage = new Guna.UI.WinForms.GunaLabel();
            this.timeoutTimer = new System.Windows.Forms.Timer(this.components);
            this.revealTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // alertElipse
            // 
            this.alertElipse.BorderRadius = 20;
            this.alertElipse.TargetControl = this;
            // 
            // alertMessage
            // 
            this.alertMessage.AutoSize = true;
            this.alertMessage.BackColor = System.Drawing.Color.Transparent;
            this.alertMessage.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.alertMessage.ForeColor = System.Drawing.Color.White;
            this.alertMessage.Location = new System.Drawing.Point(84, 8);
            this.alertMessage.Name = "alertMessage";
            this.alertMessage.Size = new System.Drawing.Size(282, 41);
            this.alertMessage.TabIndex = 0;
            this.alertMessage.Text = "Employee Updated!";
            this.alertMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeoutTimer
            // 
            this.timeoutTimer.Enabled = true;
            this.timeoutTimer.Interval = 3500;
            this.timeoutTimer.Tick += new System.EventHandler(this.TimeOutTimer_Tick);
            // 
            // revealTimer
            // 
            this.revealTimer.Interval = 200;
            this.revealTimer.Tick += new System.EventHandler(this.revealTimer_Tick);
            // 
            // Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(500, 60);
            this.Controls.Add(this.alertMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alert";
            this.Opacity = 0.96D;
            this.Text = "Alert";
            this.Load += new System.EventHandler(this.Alert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse alertElipse;
        private Guna.UI.WinForms.GunaLabel alertMessage;
        private System.Windows.Forms.Timer timeoutTimer;
        private System.Windows.Forms.Timer revealTimer;
    }
}