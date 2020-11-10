namespace BiometricPayroll.FORMS
{
    partial class ReplaceFP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReplaceFP));
            this.printPanel = new Guna.UI.WinForms.GunaElipsePanel();
            this.addedIDlbl = new Guna.UI.WinForms.GunaLabel();
            this.printQualityProgress = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.enteredFPrint = new Guna.UI.WinForms.GunaLabel();
            this.deviceState = new Guna.UI.WinForms.GunaLabel();
            this.btnCapturePrint = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnEnroll = new Guna.UI.WinForms.GunaAdvenceButton();
            this.fingerPrintBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.gunaLabel16 = new Guna.UI.WinForms.GunaLabel();
            this.txtFingerprintStatus = new Guna.UI.WinForms.GunaLabel();
            this.printPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fingerPrintBox)).BeginInit();
            this.SuspendLayout();
            // 
            // printPanel
            // 
            this.printPanel.BackColor = System.Drawing.Color.Transparent;
            this.printPanel.BaseColor = System.Drawing.Color.White;
            this.printPanel.Controls.Add(this.addedIDlbl);
            this.printPanel.Controls.Add(this.printQualityProgress);
            this.printPanel.Controls.Add(this.enteredFPrint);
            this.printPanel.Controls.Add(this.deviceState);
            this.printPanel.Controls.Add(this.btnCapturePrint);
            this.printPanel.Controls.Add(this.gunaAdvenceButton1);
            this.printPanel.Controls.Add(this.btnEnroll);
            this.printPanel.Controls.Add(this.fingerPrintBox);
            this.printPanel.Controls.Add(this.gunaLabel16);
            this.printPanel.Controls.Add(this.txtFingerprintStatus);
            this.printPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printPanel.Location = new System.Drawing.Point(0, 0);
            this.printPanel.Name = "printPanel";
            this.printPanel.Radius = 15;
            this.printPanel.Size = new System.Drawing.Size(441, 727);
            this.printPanel.TabIndex = 6;
            // 
            // addedIDlbl
            // 
            this.addedIDlbl.AutoSize = true;
            this.addedIDlbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addedIDlbl.Location = new System.Drawing.Point(223, 32);
            this.addedIDlbl.Name = "addedIDlbl";
            this.addedIDlbl.Size = new System.Drawing.Size(0, 20);
            this.addedIDlbl.TabIndex = 8;
            // 
            // printQualityProgress
            // 
            this.printQualityProgress.FillColor = System.Drawing.Color.White;
            this.printQualityProgress.ForeColor = System.Drawing.Color.White;
            this.printQualityProgress.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.printQualityProgress.Location = new System.Drawing.Point(24, 424);
            this.printQualityProgress.Name = "printQualityProgress";
            this.printQualityProgress.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.printQualityProgress.ProgressColor2 = System.Drawing.Color.DodgerBlue;
            this.printQualityProgress.ShadowDecoration.Parent = this.printQualityProgress;
            this.printQualityProgress.ShowPercentage = true;
            this.printQualityProgress.Size = new System.Drawing.Size(392, 20);
            this.printQualityProgress.TabIndex = 7;
            this.printQualityProgress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // enteredFPrint
            // 
            this.enteredFPrint.AutoSize = true;
            this.enteredFPrint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.enteredFPrint.Location = new System.Drawing.Point(145, 90);
            this.enteredFPrint.Name = "enteredFPrint";
            this.enteredFPrint.Size = new System.Drawing.Size(150, 20);
            this.enteredFPrint.TabIndex = 6;
            this.enteredFPrint.Text = "Enter First Fingerprint";
            // 
            // deviceState
            // 
            this.deviceState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deviceState.AutoSize = true;
            this.deviceState.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.deviceState.Location = new System.Drawing.Point(110, 546);
            this.deviceState.Name = "deviceState";
            this.deviceState.Size = new System.Drawing.Size(138, 28);
            this.deviceState.TabIndex = 5;
            this.deviceState.Text = "STATUS TEXT";
            this.deviceState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCapturePrint
            // 
            this.btnCapturePrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapturePrint.AnimationHoverSpeed = 0.07F;
            this.btnCapturePrint.AnimationSpeed = 0.03F;
            this.btnCapturePrint.BackColor = System.Drawing.Color.Transparent;
            this.btnCapturePrint.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCapturePrint.BorderColor = System.Drawing.Color.Black;
            this.btnCapturePrint.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnCapturePrint.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnCapturePrint.CheckedForeColor = System.Drawing.Color.White;
            this.btnCapturePrint.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnCapturePrint.CheckedImage")));
            this.btnCapturePrint.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnCapturePrint.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCapturePrint.FocusedColor = System.Drawing.Color.Empty;
            this.btnCapturePrint.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnCapturePrint.ForeColor = System.Drawing.Color.White;
            this.btnCapturePrint.Image = null;
            this.btnCapturePrint.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCapturePrint.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCapturePrint.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCapturePrint.Location = new System.Drawing.Point(150, 450);
            this.btnCapturePrint.Name = "btnCapturePrint";
            this.btnCapturePrint.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCapturePrint.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnCapturePrint.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCapturePrint.OnHoverImage = null;
            this.btnCapturePrint.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCapturePrint.OnPressedColor = System.Drawing.Color.Black;
            this.btnCapturePrint.Radius = 8;
            this.btnCapturePrint.Size = new System.Drawing.Size(141, 61);
            this.btnCapturePrint.TabIndex = 4;
            this.btnCapturePrint.Text = "CAPTURE";
            this.btnCapturePrint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCapturePrint.Click += new System.EventHandler(this.btnCapturePrint_Click);
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.Teal;
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = null;
            this.gunaAdvenceButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.Teal;
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(11, 621);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.Teal;
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.OnHoverImage")));
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.Teal;
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Radius = 8;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(189, 72);
            this.gunaAdvenceButton1.TabIndex = 4;
            this.gunaAdvenceButton1.Text = "RETRY";
            this.gunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEnroll
            // 
            this.btnEnroll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnroll.AnimationHoverSpeed = 0.07F;
            this.btnEnroll.AnimationSpeed = 0.03F;
            this.btnEnroll.BackColor = System.Drawing.Color.Transparent;
            this.btnEnroll.BaseColor = System.Drawing.Color.Green;
            this.btnEnroll.BorderColor = System.Drawing.Color.Black;
            this.btnEnroll.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnEnroll.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnEnroll.CheckedForeColor = System.Drawing.Color.White;
            this.btnEnroll.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnEnroll.CheckedImage")));
            this.btnEnroll.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnEnroll.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEnroll.FocusedColor = System.Drawing.Color.Empty;
            this.btnEnroll.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnEnroll.ForeColor = System.Drawing.Color.White;
            this.btnEnroll.Image = null;
            this.btnEnroll.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEnroll.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEnroll.LineColor = System.Drawing.Color.Green;
            this.btnEnroll.Location = new System.Drawing.Point(236, 621);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.OnHoverBaseColor = System.Drawing.Color.Green;
            this.btnEnroll.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnEnroll.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEnroll.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnEnroll.OnHoverImage")));
            this.btnEnroll.OnHoverLineColor = System.Drawing.Color.Green;
            this.btnEnroll.OnPressedColor = System.Drawing.Color.Black;
            this.btnEnroll.Radius = 8;
            this.btnEnroll.Size = new System.Drawing.Size(189, 72);
            this.btnEnroll.TabIndex = 4;
            this.btnEnroll.Text = "ENROLL";
            this.btnEnroll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click);
            // 
            // fingerPrintBox
            // 
            this.fingerPrintBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fingerPrintBox.Image = ((System.Drawing.Image)(resources.GetObject("fingerPrintBox.Image")));
            this.fingerPrintBox.Location = new System.Drawing.Point(39, 139);
            this.fingerPrintBox.Name = "fingerPrintBox";
            this.fingerPrintBox.Padding = new System.Windows.Forms.Padding(20);
            this.fingerPrintBox.ShadowDecoration.Parent = this.fingerPrintBox;
            this.fingerPrintBox.Size = new System.Drawing.Size(363, 268);
            this.fingerPrintBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fingerPrintBox.TabIndex = 3;
            this.fingerPrintBox.TabStop = false;
            // 
            // gunaLabel16
            // 
            this.gunaLabel16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel16.AutoSize = true;
            this.gunaLabel16.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel16.ForeColor = System.Drawing.Color.ForestGreen;
            this.gunaLabel16.Location = new System.Drawing.Point(150, 55);
            this.gunaLabel16.Name = "gunaLabel16";
            this.gunaLabel16.Size = new System.Drawing.Size(141, 28);
            this.gunaLabel16.TabIndex = 0;
            this.gunaLabel16.Text = "FINGERPRINT";
            // 
            // txtFingerprintStatus
            // 
            this.txtFingerprintStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFingerprintStatus.AutoSize = true;
            this.txtFingerprintStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtFingerprintStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(165)))), ((int)(((byte)(33)))));
            this.txtFingerprintStatus.Location = new System.Drawing.Point(96, 478);
            this.txtFingerprintStatus.Name = "txtFingerprintStatus";
            this.txtFingerprintStatus.Size = new System.Drawing.Size(0, 28);
            this.txtFingerprintStatus.TabIndex = 0;
            // 
            // ReplaceFP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 727);
            this.Controls.Add(this.printPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReplaceFP";
            this.Text = "ReplaceFP";
            this.printPanel.ResumeLayout(false);
            this.printPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fingerPrintBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel printPanel;
        private Guna.UI.WinForms.GunaLabel addedIDlbl;
        private Guna.UI2.WinForms.Guna2ProgressBar printQualityProgress;
        private Guna.UI.WinForms.GunaLabel enteredFPrint;
        private Guna.UI.WinForms.GunaLabel deviceState;
        private Guna.UI.WinForms.GunaAdvenceButton btnCapturePrint;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaAdvenceButton btnEnroll;
        private Guna.UI2.WinForms.Guna2PictureBox fingerPrintBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel16;
        private Guna.UI.WinForms.GunaLabel txtFingerprintStatus;
    }
}