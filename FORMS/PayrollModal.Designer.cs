namespace BiometricPayroll.FORMS
{
    partial class PayrollModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayrollModal));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtInfo = new Guna.UI.WinForms.GunaLabel();
            this.btnAction = new Guna.UI.WinForms.GunaAdvenceButton();
            this.autoClosetmr = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 40;
            this.guna2Elipse1.TargetControl = this;
            // 
            // txtInfo
            // 
            this.txtInfo.AutoSize = true;
            this.txtInfo.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.txtInfo.Location = new System.Drawing.Point(73, 97);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(543, 57);
            this.txtInfo.TabIndex = 0;
            this.txtInfo.Text = "DEDUCTION CRB  IS ACTIVE";
            this.txtInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAction
            // 
            this.btnAction.AnimationHoverSpeed = 0.07F;
            this.btnAction.AnimationSpeed = 0.03F;
            this.btnAction.BackColor = System.Drawing.Color.Transparent;
            this.btnAction.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnAction.BorderColor = System.Drawing.Color.Black;
            this.btnAction.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAction.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAction.CheckedForeColor = System.Drawing.Color.White;
            this.btnAction.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAction.CheckedImage")));
            this.btnAction.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAction.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAction.FocusedColor = System.Drawing.Color.Empty;
            this.btnAction.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnAction.ForeColor = System.Drawing.Color.White;
            this.btnAction.Image = null;
            this.btnAction.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAction.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAction.Location = new System.Drawing.Point(247, 211);
            this.btnAction.Name = "btnAction";
            this.btnAction.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAction.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAction.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAction.OnHoverImage = null;
            this.btnAction.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAction.OnPressedColor = System.Drawing.Color.Black;
            this.btnAction.Radius = 20;
            this.btnAction.Size = new System.Drawing.Size(194, 75);
            this.btnAction.TabIndex = 1;
            this.btnAction.Text = "DISABLE IT";
            this.btnAction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // autoClosetmr
            // 
            this.autoClosetmr.Interval = 5000;
            this.autoClosetmr.Tick += new System.EventHandler(this.autoClosetmr_Tick);
            // 
            // PayrollModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 320);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.txtInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PayrollModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PayrollModal";
            this.Load += new System.EventHandler(this.PayrollModal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI.WinForms.GunaAdvenceButton btnAction;
        private Guna.UI.WinForms.GunaLabel txtInfo;
        private System.Windows.Forms.Timer autoClosetmr;
    }
}