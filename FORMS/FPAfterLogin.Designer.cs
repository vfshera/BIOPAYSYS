namespace BiometricPayroll.FORMS
{
    partial class FPAfterLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPAfterLogin));
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.fpPanel = new Guna.UI.WinForms.GunaPanel();
            this.pbxVerfy = new Guna.UI.WinForms.GunaPictureBox();
            this.appStatelbl = new Guna.UI.WinForms.GunaLabel();
            this.retryBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.fpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVerfy)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Panel3.BackgroundImage")));
            this.guna2Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel3.Location = new System.Drawing.Point(196, 39);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(251, 115);
            this.guna2Panel3.TabIndex = 6;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(477, 39);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(97, 64);
            this.guna2ControlBox1.TabIndex = 7;
            // 
            // fpPanel
            // 
            this.fpPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fpPanel.BackgroundImage")));
            this.fpPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fpPanel.Controls.Add(this.pbxVerfy);
            this.fpPanel.Location = new System.Drawing.Point(196, 160);
            this.fpPanel.Name = "fpPanel";
            this.fpPanel.Size = new System.Drawing.Size(251, 200);
            this.fpPanel.TabIndex = 8;
            // 
            // pbxVerfy
            // 
            this.pbxVerfy.BackColor = System.Drawing.Color.Transparent;
            this.pbxVerfy.BaseColor = System.Drawing.Color.Transparent;
            this.pbxVerfy.Location = new System.Drawing.Point(26, 11);
            this.pbxVerfy.Name = "pbxVerfy";
            this.pbxVerfy.Radius = 5;
            this.pbxVerfy.Size = new System.Drawing.Size(199, 181);
            this.pbxVerfy.TabIndex = 0;
            this.pbxVerfy.TabStop = false;
            // 
            // appStatelbl
            // 
            this.appStatelbl.AutoSize = true;
            this.appStatelbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.appStatelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.appStatelbl.Location = new System.Drawing.Point(220, 385);
            this.appStatelbl.Name = "appStatelbl";
            this.appStatelbl.Size = new System.Drawing.Size(203, 20);
            this.appStatelbl.TabIndex = 9;
            this.appStatelbl.Text = "Waiting For Your Fingerprint...";
            // 
            // retryBtn
            // 
            this.retryBtn.CheckedState.Parent = this.retryBtn;
            this.retryBtn.HoverState.Parent = this.retryBtn;
            this.retryBtn.Image = ((System.Drawing.Image)(resources.GetObject("retryBtn.Image")));
            this.retryBtn.ImageSize = new System.Drawing.Size(50, 50);
            this.retryBtn.Location = new System.Drawing.Point(284, 419);
            this.retryBtn.Name = "retryBtn";
            this.retryBtn.PressedState.Parent = this.retryBtn;
            this.retryBtn.Size = new System.Drawing.Size(75, 58);
            this.retryBtn.TabIndex = 10;
            this.retryBtn.Click += new System.EventHandler(this.retryBtn_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // FPAfterLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 503);
            this.Controls.Add(this.retryBtn);
            this.Controls.Add(this.appStatelbl);
            this.Controls.Add(this.fpPanel);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2Panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FPAfterLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FPAfterLogin";
            this.Load += new System.EventHandler(this.FPAfterLogin_Load);
            this.fpPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxVerfy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI.WinForms.GunaPanel fpPanel;
        private Guna.UI.WinForms.GunaLabel appStatelbl;
        private Guna.UI2.WinForms.Guna2ImageButton retryBtn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI.WinForms.GunaPictureBox pbxVerfy;
    }
}