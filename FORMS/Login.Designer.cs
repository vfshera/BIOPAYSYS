namespace BiometricPayroll
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.usernameLine = new Guna.UI2.WinForms.Guna2Panel();
            this.passLine = new Guna.UI2.WinForms.Guna2Panel();
            this.txtBxUsername = new System.Windows.Forms.TextBox();
            this.txtBxPassword = new System.Windows.Forms.MaskedTextBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.iconClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.loader = new System.Windows.Forms.PictureBox();
            this.lblLoginText = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.loader)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLine
            // 
            this.usernameLine.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.usernameLine.Location = new System.Drawing.Point(133, 203);
            this.usernameLine.Name = "usernameLine";
            this.usernameLine.ShadowDecoration.Parent = this.usernameLine;
            this.usernameLine.Size = new System.Drawing.Size(500, 3);
            this.usernameLine.TabIndex = 0;
            // 
            // passLine
            // 
            this.passLine.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.passLine.Location = new System.Drawing.Point(133, 304);
            this.passLine.Name = "passLine";
            this.passLine.ShadowDecoration.Parent = this.passLine;
            this.passLine.Size = new System.Drawing.Size(500, 3);
            this.passLine.TabIndex = 0;
            // 
            // txtBxUsername
            // 
            this.txtBxUsername.AllowDrop = true;
            this.txtBxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxUsername.BackColor = System.Drawing.SystemColors.Control;
            this.txtBxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBxUsername.Location = new System.Drawing.Point(133, 166);
            this.txtBxUsername.MaxLength = 32;
            this.txtBxUsername.Multiline = true;
            this.txtBxUsername.Name = "txtBxUsername";
            this.txtBxUsername.Size = new System.Drawing.Size(500, 35);
            this.txtBxUsername.TabIndex = 1;
            this.txtBxUsername.Text = "email";
            this.txtBxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBxUsername.Enter += new System.EventHandler(this.txtBxUsername_Enter);
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtBxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBxPassword.Location = new System.Drawing.Point(133, 272);
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.Size = new System.Drawing.Size(500, 27);
            this.txtBxPassword.TabIndex = 2;
            this.txtBxPassword.Text = "password";
            this.txtBxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBxPassword.Enter += new System.EventHandler(this.txtBxPassword_Enter);
            // 
            // btnLogin
            // 
            this.btnLogin.BorderColor = System.Drawing.Color.Green;
            this.btnLogin.BorderRadius = 5;
            this.btnLogin.BorderThickness = 1;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.Green;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.BorderColor = System.Drawing.Color.Green;
            this.btnLogin.HoverState.FillColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.ForeColor = System.Drawing.Color.Green;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(293, 365);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(180, 68);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // iconClose
            // 
            this.iconClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconClose.BackColor = System.Drawing.Color.Transparent;
            this.iconClose.BorderColor = System.Drawing.Color.Transparent;
            this.iconClose.CustomIconSize = 20F;
            this.iconClose.FillColor = System.Drawing.Color.Transparent;
            this.iconClose.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.iconClose.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.iconClose.HoverState.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.iconClose.HoverState.Parent = this.iconClose;
            this.iconClose.IconColor = System.Drawing.Color.Black;
            this.iconClose.Location = new System.Drawing.Point(678, 30);
            this.iconClose.Name = "iconClose";
            this.iconClose.ShadowDecoration.Parent = this.iconClose;
            this.iconClose.Size = new System.Drawing.Size(60, 34);
            this.iconClose.TabIndex = 4;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Panel3.BackgroundImage")));
            this.guna2Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel3.Location = new System.Drawing.Point(277, 30);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(212, 115);
            this.guna2Panel3.TabIndex = 5;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // loader
            // 
            this.loader.BackColor = System.Drawing.Color.Transparent;
            this.loader.Image = ((System.Drawing.Image)(resources.GetObject("loader.Image")));
            this.loader.Location = new System.Drawing.Point(124, 151);
            this.loader.Name = "loader";
            this.loader.Size = new System.Drawing.Size(509, 165);
            this.loader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.loader.TabIndex = 6;
            this.loader.TabStop = false;
            // 
            // lblLoginText
            // 
            this.lblLoginText.AutoSize = true;
            this.lblLoginText.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLoginText.ForeColor = System.Drawing.Color.Green;
            this.lblLoginText.Location = new System.Drawing.Point(340, 306);
            this.lblLoginText.Name = "lblLoginText";
            this.lblLoginText.Size = new System.Drawing.Size(96, 20);
            this.lblLoginText.TabIndex = 7;
            this.lblLoginText.Text = "Please wait ...";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 472);
            this.Controls.Add(this.lblLoginText);
            this.Controls.Add(this.loader);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.iconClose);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtBxPassword);
            this.Controls.Add(this.txtBxUsername);
            this.Controls.Add(this.passLine);
            this.Controls.Add(this.usernameLine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(766, 472);
            this.MinimumSize = new System.Drawing.Size(766, 472);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel usernameLine;
        private Guna.UI2.WinForms.Guna2Panel passLine;
        private System.Windows.Forms.TextBox txtBxUsername;
        private System.Windows.Forms.MaskedTextBox txtBxPassword;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2ControlBox iconClose;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.PictureBox loader;
        private Guna.UI.WinForms.GunaLabel lblLoginText;
    }
}

