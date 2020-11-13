namespace BiometricPayroll.FORMS
{
    partial class EmployeeFPConfirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeFPConfirm));
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.fingerPrintBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnRetryFP = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnConfirm = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lblWaitingFor = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.consentLbl = new Guna.UI.WinForms.GunaLabel();
            this.countDown = new Guna.UI.WinForms.GunaLabel();
            this.timerFP = new System.Windows.Forms.Timer(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fingerPrintBox)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(386, 26);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // fingerPrintBox
            // 
            this.fingerPrintBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fingerPrintBox.Image = ((System.Drawing.Image)(resources.GetObject("fingerPrintBox.Image")));
            this.fingerPrintBox.Location = new System.Drawing.Point(30, 228);
            this.fingerPrintBox.Name = "fingerPrintBox";
            this.fingerPrintBox.Padding = new System.Windows.Forms.Padding(20);
            this.fingerPrintBox.ShadowDecoration.Parent = this.fingerPrintBox;
            this.fingerPrintBox.Size = new System.Drawing.Size(399, 319);
            this.fingerPrintBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fingerPrintBox.TabIndex = 4;
            this.fingerPrintBox.TabStop = false;
            // 
            // btnRetryFP
            // 
            this.btnRetryFP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRetryFP.AnimationHoverSpeed = 0.07F;
            this.btnRetryFP.AnimationSpeed = 0.03F;
            this.btnRetryFP.BackColor = System.Drawing.Color.Transparent;
            this.btnRetryFP.BaseColor = System.Drawing.Color.Teal;
            this.btnRetryFP.BorderColor = System.Drawing.Color.Black;
            this.btnRetryFP.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnRetryFP.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnRetryFP.CheckedForeColor = System.Drawing.Color.White;
            this.btnRetryFP.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnRetryFP.CheckedImage")));
            this.btnRetryFP.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnRetryFP.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRetryFP.FocusedColor = System.Drawing.Color.Empty;
            this.btnRetryFP.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnRetryFP.ForeColor = System.Drawing.Color.White;
            this.btnRetryFP.Image = null;
            this.btnRetryFP.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRetryFP.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRetryFP.LineColor = System.Drawing.Color.Teal;
            this.btnRetryFP.Location = new System.Drawing.Point(32, 651);
            this.btnRetryFP.Name = "btnRetryFP";
            this.btnRetryFP.OnHoverBaseColor = System.Drawing.Color.Teal;
            this.btnRetryFP.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnRetryFP.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRetryFP.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnRetryFP.OnHoverImage")));
            this.btnRetryFP.OnHoverLineColor = System.Drawing.Color.Teal;
            this.btnRetryFP.OnPressedColor = System.Drawing.Color.Black;
            this.btnRetryFP.Radius = 8;
            this.btnRetryFP.Size = new System.Drawing.Size(149, 72);
            this.btnRetryFP.TabIndex = 5;
            this.btnRetryFP.Text = "RETRY";
            this.btnRetryFP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRetryFP.Click += new System.EventHandler(this.btnRetryFP_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.AnimationHoverSpeed = 0.07F;
            this.btnConfirm.AnimationSpeed = 0.03F;
            this.btnConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.BaseColor = System.Drawing.Color.Green;
            this.btnConfirm.BorderColor = System.Drawing.Color.Black;
            this.btnConfirm.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnConfirm.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnConfirm.CheckedForeColor = System.Drawing.Color.White;
            this.btnConfirm.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnConfirm.CheckedImage")));
            this.btnConfirm.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConfirm.FocusedColor = System.Drawing.Color.Empty;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Image = null;
            this.btnConfirm.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnConfirm.ImageSize = new System.Drawing.Size(30, 30);
            this.btnConfirm.LineColor = System.Drawing.Color.Green;
            this.btnConfirm.Location = new System.Drawing.Point(282, 651);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.OnHoverBaseColor = System.Drawing.Color.Green;
            this.btnConfirm.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnConfirm.OnHoverForeColor = System.Drawing.Color.White;
            this.btnConfirm.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnConfirm.OnHoverImage")));
            this.btnConfirm.OnHoverLineColor = System.Drawing.Color.Green;
            this.btnConfirm.OnPressedColor = System.Drawing.Color.Black;
            this.btnConfirm.Radius = 8;
            this.btnConfirm.Size = new System.Drawing.Size(149, 72);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblWaitingFor
            // 
            this.lblWaitingFor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWaitingFor.AutoSize = true;
            this.lblWaitingFor.BackColor = System.Drawing.Color.Transparent;
            this.lblWaitingFor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblWaitingFor.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblWaitingFor.Location = new System.Drawing.Point(106, 94);
            this.lblWaitingFor.Name = "lblWaitingFor";
            this.lblWaitingFor.Size = new System.Drawing.Size(247, 28);
            this.lblWaitingFor.TabIndex = 7;
            this.lblWaitingFor.Text = "WAITING FOR FRANKLIN";
            this.lblWaitingFor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.ForestGreen;
            this.gunaLabel1.Location = new System.Drawing.Point(108, 133);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(242, 28);
            this.gunaLabel1.TabIndex = 7;
            this.gunaLabel1.Text = "TO ENTER FINGERPRINT";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.Color.ForestGreen;
            this.gunaLabel2.Location = new System.Drawing.Point(38, 177);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(382, 28);
            this.gunaLabel2.TabIndex = 7;
            this.gunaLabel2.Text = "TO ALLOW ACCESS TO PERSONAL INFO";
            // 
            // consentLbl
            // 
            this.consentLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.consentLbl.AutoSize = true;
            this.consentLbl.BackColor = System.Drawing.Color.Transparent;
            this.consentLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.consentLbl.ForeColor = System.Drawing.Color.ForestGreen;
            this.consentLbl.Location = new System.Drawing.Point(101, 563);
            this.consentLbl.Name = "consentLbl";
            this.consentLbl.Size = new System.Drawing.Size(264, 28);
            this.consentLbl.TabIndex = 7;
            this.consentLbl.Text = "shera\'s consent is mandatory";
            // 
            // countDown
            // 
            this.countDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.countDown.AutoSize = true;
            this.countDown.BackColor = System.Drawing.Color.Transparent;
            this.countDown.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.countDown.ForeColor = System.Drawing.Color.ForestGreen;
            this.countDown.Location = new System.Drawing.Point(202, 57);
            this.countDown.Name = "countDown";
            this.countDown.Size = new System.Drawing.Size(54, 35);
            this.countDown.TabIndex = 7;
            this.countDown.Text = "15s";
            // 
            // timerFP
            // 
            this.timerFP.Interval = 1000;
            this.timerFP.Tick += new System.EventHandler(this.timerFP_Tick);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // EmployeeFPConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 774);
            this.Controls.Add(this.consentLbl);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.countDown);
            this.Controls.Add(this.lblWaitingFor);
            this.Controls.Add(this.btnRetryFP);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.fingerPrintBox);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeFPConfirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeFPConfirm";
            this.Load += new System.EventHandler(this.EmployeeFPConfirm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fingerPrintBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2PictureBox fingerPrintBox;
        private Guna.UI.WinForms.GunaAdvenceButton btnRetryFP;
        private Guna.UI.WinForms.GunaAdvenceButton btnConfirm;
        private Guna.UI.WinForms.GunaLabel lblWaitingFor;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel consentLbl;
        private Guna.UI.WinForms.GunaLabel countDown;
        private System.Windows.Forms.Timer timerFP;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}