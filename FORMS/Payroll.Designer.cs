namespace BiometricPayroll.FORMS
{
    partial class Payroll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payroll));
            this.parentPanel = new Guna.UI.WinForms.GunaPanel();
            this.generatePay = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnPrint = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnRun = new Guna.UI.WinForms.GunaAdvenceButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // parentPanel
            // 
            this.parentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parentPanel.Location = new System.Drawing.Point(7, 63);
            this.parentPanel.Name = "parentPanel";
            this.parentPanel.Size = new System.Drawing.Size(1082, 655);
            this.parentPanel.TabIndex = 0;
            // 
            // generatePay
            // 
            this.generatePay.AnimationHoverSpeed = 0.07F;
            this.generatePay.AnimationSpeed = 0.03F;
            this.generatePay.BackColor = System.Drawing.Color.Transparent;
            this.generatePay.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.generatePay.BorderColor = System.Drawing.Color.Black;
            this.generatePay.CheckedBaseColor = System.Drawing.Color.Gray;
            this.generatePay.CheckedBorderColor = System.Drawing.Color.Black;
            this.generatePay.CheckedForeColor = System.Drawing.Color.White;
            this.generatePay.CheckedImage = ((System.Drawing.Image)(resources.GetObject("generatePay.CheckedImage")));
            this.generatePay.CheckedLineColor = System.Drawing.Color.DimGray;
            this.generatePay.DialogResult = System.Windows.Forms.DialogResult.None;
            this.generatePay.FocusedColor = System.Drawing.Color.Empty;
            this.generatePay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.generatePay.ForeColor = System.Drawing.Color.White;
            this.generatePay.Image = ((System.Drawing.Image)(resources.GetObject("generatePay.Image")));
            this.generatePay.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.generatePay.ImageSize = new System.Drawing.Size(25, 25);
            this.generatePay.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.generatePay.Location = new System.Drawing.Point(9, 12);
            this.generatePay.Name = "generatePay";
            this.generatePay.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(57)))), ((int)(((byte)(170)))));
            this.generatePay.OnHoverBorderColor = System.Drawing.Color.Black;
            this.generatePay.OnHoverForeColor = System.Drawing.Color.White;
            this.generatePay.OnHoverImage = null;
            this.generatePay.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.generatePay.OnPressedColor = System.Drawing.Color.Black;
            this.generatePay.Radius = 15;
            this.generatePay.Size = new System.Drawing.Size(158, 42);
            this.generatePay.TabIndex = 1;
            this.generatePay.Text = "GENERATE";
            this.generatePay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.generatePay.Click += new System.EventHandler(this.generatePay_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.AnimationHoverSpeed = 0.07F;
            this.btnPrint.AnimationSpeed = 0.03F;
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnPrint.BorderColor = System.Drawing.Color.Black;
            this.btnPrint.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnPrint.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnPrint.CheckedForeColor = System.Drawing.Color.White;
            this.btnPrint.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.CheckedImage")));
            this.btnPrint.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnPrint.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrint.FocusedColor = System.Drawing.Color.Empty;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPrint.ImageSize = new System.Drawing.Size(25, 25);
            this.btnPrint.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPrint.Location = new System.Drawing.Point(950, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(57)))), ((int)(((byte)(170)))));
            this.btnPrint.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPrint.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPrint.OnHoverImage = null;
            this.btnPrint.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPrint.OnPressedColor = System.Drawing.Color.Black;
            this.btnPrint.Radius = 15;
            this.btnPrint.Size = new System.Drawing.Size(132, 42);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.AnimationHoverSpeed = 0.07F;
            this.btnRun.AnimationSpeed = 0.03F;
            this.btnRun.BackColor = System.Drawing.Color.Transparent;
            this.btnRun.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnRun.BorderColor = System.Drawing.Color.Black;
            this.btnRun.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnRun.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnRun.CheckedForeColor = System.Drawing.Color.White;
            this.btnRun.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnRun.CheckedImage")));
            this.btnRun.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnRun.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRun.FocusedColor = System.Drawing.Color.Empty;
            this.btnRun.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRun.ForeColor = System.Drawing.Color.White;
            this.btnRun.Image = ((System.Drawing.Image)(resources.GetObject("btnRun.Image")));
            this.btnRun.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRun.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRun.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnRun.Location = new System.Drawing.Point(803, 12);
            this.btnRun.Name = "btnRun";
            this.btnRun.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(57)))), ((int)(((byte)(170)))));
            this.btnRun.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRun.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRun.OnHoverImage = null;
            this.btnRun.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnRun.OnPressedColor = System.Drawing.Color.Black;
            this.btnRun.Radius = 15;
            this.btnRun.Size = new System.Drawing.Size(119, 42);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "RUN";
            this.btnRun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // Payroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1096, 726);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.generatePay);
            this.Controls.Add(this.parentPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1096, 726);
            this.Name = "Payroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Payroll";
            this.Load += new System.EventHandler(this.Payroll_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel parentPanel;
        private Guna.UI.WinForms.GunaAdvenceButton generatePay;
        private Guna.UI.WinForms.GunaAdvenceButton btnPrint;
        private Guna.UI.WinForms.GunaAdvenceButton btnRun;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}