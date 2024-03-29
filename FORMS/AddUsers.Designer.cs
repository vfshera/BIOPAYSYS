﻿namespace BiometricPayroll.FORMS
{
    partial class AddUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUsers));
            this.roleDropDown = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnUserDetailCancel = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnSaveUser = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel15 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.tbxPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.printPanel = new Guna.UI.WinForms.GunaElipsePanel();
            this.addedIDlbl = new Guna.UI.WinForms.GunaLabel();
            this.printQualityProgress = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.enteredFPrint = new Guna.UI.WinForms.GunaLabel();
            this.lblDeviceInfo = new Guna.UI.WinForms.GunaLabel();
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
            // roleDropDown
            // 
            this.roleDropDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roleDropDown.BackColor = System.Drawing.Color.Transparent;
            this.roleDropDown.BorderRadius = 5;
            this.roleDropDown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.roleDropDown.DropDownHeight = 64;
            this.roleDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleDropDown.FocusedColor = System.Drawing.Color.Empty;
            this.roleDropDown.FocusedState.Parent = this.roleDropDown;
            this.roleDropDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.roleDropDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roleDropDown.FormattingEnabled = true;
            this.roleDropDown.HoverState.Parent = this.roleDropDown;
            this.roleDropDown.IntegralHeight = false;
            this.roleDropDown.ItemHeight = 30;
            this.roleDropDown.Items.AddRange(new object[] {
            "ADMIN",
            "HR"});
            this.roleDropDown.ItemsAppearance.Parent = this.roleDropDown;
            this.roleDropDown.Location = new System.Drawing.Point(31, 329);
            this.roleDropDown.Name = "roleDropDown";
            this.roleDropDown.ShadowDecoration.Parent = this.roleDropDown;
            this.roleDropDown.Size = new System.Drawing.Size(418, 36);
            this.roleDropDown.TabIndex = 30;
            this.roleDropDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnUserDetailCancel
            // 
            this.btnUserDetailCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUserDetailCancel.AnimationHoverSpeed = 0.07F;
            this.btnUserDetailCancel.AnimationSpeed = 0.03F;
            this.btnUserDetailCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnUserDetailCancel.BaseColor = System.Drawing.Color.Red;
            this.btnUserDetailCancel.BorderColor = System.Drawing.Color.Red;
            this.btnUserDetailCancel.BorderSize = 2;
            this.btnUserDetailCancel.CheckedBaseColor = System.Drawing.Color.Transparent;
            this.btnUserDetailCancel.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnUserDetailCancel.CheckedForeColor = System.Drawing.Color.White;
            this.btnUserDetailCancel.CheckedImage = null;
            this.btnUserDetailCancel.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnUserDetailCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUserDetailCancel.FocusedColor = System.Drawing.Color.Empty;
            this.btnUserDetailCancel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnUserDetailCancel.ForeColor = System.Drawing.Color.White;
            this.btnUserDetailCancel.Image = null;
            this.btnUserDetailCancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUserDetailCancel.ImageSize = new System.Drawing.Size(37, 37);
            this.btnUserDetailCancel.LineColor = System.Drawing.Color.Red;
            this.btnUserDetailCancel.Location = new System.Drawing.Point(31, 530);
            this.btnUserDetailCancel.Name = "btnUserDetailCancel";
            this.btnUserDetailCancel.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btnUserDetailCancel.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btnUserDetailCancel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUserDetailCancel.OnHoverImage = null;
            this.btnUserDetailCancel.OnHoverLineColor = System.Drawing.Color.Red;
            this.btnUserDetailCancel.OnPressedColor = System.Drawing.Color.Black;
            this.btnUserDetailCancel.Radius = 7;
            this.btnUserDetailCancel.Size = new System.Drawing.Size(149, 57);
            this.btnUserDetailCancel.TabIndex = 27;
            this.btnUserDetailCancel.Text = "CANCEL";
            this.btnUserDetailCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUserDetailCancel.Click += new System.EventHandler(this.btnUserDetailCancel_Click);
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveUser.AnimationHoverSpeed = 0.07F;
            this.btnSaveUser.AnimationSpeed = 0.03F;
            this.btnSaveUser.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveUser.BaseColor = System.Drawing.Color.Green;
            this.btnSaveUser.BorderColor = System.Drawing.Color.Green;
            this.btnSaveUser.BorderSize = 2;
            this.btnSaveUser.CheckedBaseColor = System.Drawing.Color.Transparent;
            this.btnSaveUser.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSaveUser.CheckedForeColor = System.Drawing.Color.White;
            this.btnSaveUser.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnSaveUser.CheckedImage")));
            this.btnSaveUser.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSaveUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSaveUser.FocusedColor = System.Drawing.Color.Empty;
            this.btnSaveUser.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnSaveUser.ForeColor = System.Drawing.Color.White;
            this.btnSaveUser.Image = null;
            this.btnSaveUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSaveUser.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSaveUser.LineColor = System.Drawing.Color.Green;
            this.btnSaveUser.Location = new System.Drawing.Point(294, 529);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnSaveUser.OnHoverBorderColor = System.Drawing.Color.Green;
            this.btnSaveUser.OnHoverForeColor = System.Drawing.Color.Green;
            this.btnSaveUser.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnSaveUser.OnHoverImage")));
            this.btnSaveUser.OnHoverLineColor = System.Drawing.Color.Green;
            this.btnSaveUser.OnPressedColor = System.Drawing.Color.Black;
            this.btnSaveUser.Radius = 7;
            this.btnSaveUser.Size = new System.Drawing.Size(155, 57);
            this.btnSaveUser.TabIndex = 26;
            this.btnSaveUser.Text = "ADD";
            this.btnSaveUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel8.ForeColor = System.Drawing.Color.White;
            this.gunaLabel8.Location = new System.Drawing.Point(29, 298);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(61, 28);
            this.gunaLabel8.TabIndex = 10;
            this.gunaLabel8.Text = "ROLE";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.BorderColor = System.Drawing.SystemColors.Control;
            this.txtEmail.BorderRadius = 7;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.Parent = this.txtEmail;
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.FocusedState.Parent = this.txtEmail;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.HoverState.Parent = this.txtEmail;
            this.txtEmail.Location = new System.Drawing.Point(31, 198);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "familyfriend@gmail.com";
            this.txtEmail.SelectedText = "";
            this.txtEmail.ShadowDecoration.Parent = this.txtEmail;
            this.txtEmail.Size = new System.Drawing.Size(418, 66);
            this.txtEmail.TabIndex = 16;
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // gunaLabel15
            // 
            this.gunaLabel15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel15.AutoSize = true;
            this.gunaLabel15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel15.ForeColor = System.Drawing.Color.White;
            this.gunaLabel15.Location = new System.Drawing.Point(32, 400);
            this.gunaLabel15.Name = "gunaLabel15";
            this.gunaLabel15.Size = new System.Drawing.Size(122, 28);
            this.gunaLabel15.TabIndex = 15;
            this.gunaLabel15.Text = "PASSWORD";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel7.ForeColor = System.Drawing.Color.White;
            this.gunaLabel7.Location = new System.Drawing.Point(30, 169);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(72, 28);
            this.gunaLabel7.TabIndex = 13;
            this.gunaLabel7.Text = "EMAIL";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.BorderColor = System.Drawing.SystemColors.Control;
            this.txtName.BorderRadius = 7;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.Parent = this.txtName;
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.FocusedState.Parent = this.txtName;
            this.txtName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.HoverState.Parent = this.txtName;
            this.txtName.Location = new System.Drawing.Point(35, 73);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "ALLAN SHERA";
            this.txtName.SelectedText = "";
            this.txtName.ShadowDecoration.Parent = this.txtName;
            this.txtName.Size = new System.Drawing.Size(414, 66);
            this.txtName.TabIndex = 18;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateTextOnKeyPress);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel6.ForeColor = System.Drawing.Color.White;
            this.gunaLabel6.Location = new System.Drawing.Point(34, 39);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(72, 28);
            this.gunaLabel6.TabIndex = 6;
            this.gunaLabel6.Text = "NAME";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.Location = new System.Drawing.Point(371, -70);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(142, 28);
            this.gunaLabel2.TabIndex = 5;
            this.gunaLabel2.Text = "Second Name";
            // 
            // tbxPass
            // 
            this.tbxPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxPass.BorderColor = System.Drawing.SystemColors.Control;
            this.tbxPass.BorderRadius = 7;
            this.tbxPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxPass.DefaultText = "";
            this.tbxPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxPass.DisabledState.Parent = this.tbxPass;
            this.tbxPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxPass.FocusedState.Parent = this.tbxPass;
            this.tbxPass.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPass.ForeColor = System.Drawing.Color.Black;
            this.tbxPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxPass.HoverState.Parent = this.tbxPass;
            this.tbxPass.Location = new System.Drawing.Point(33, 434);
            this.tbxPass.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbxPass.Name = "tbxPass";
            this.tbxPass.PasswordChar = '\0';
            this.tbxPass.PlaceholderText = "(&%@#123ABCxyz";
            this.tbxPass.SelectedText = "";
            this.tbxPass.ShadowDecoration.Parent = this.tbxPass;
            this.tbxPass.Size = new System.Drawing.Size(414, 66);
            this.tbxPass.TabIndex = 18;
            // 
            // printPanel
            // 
            this.printPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.printPanel.BackColor = System.Drawing.Color.Transparent;
            this.printPanel.BaseColor = System.Drawing.Color.White;
            this.printPanel.Controls.Add(this.addedIDlbl);
            this.printPanel.Controls.Add(this.printQualityProgress);
            this.printPanel.Controls.Add(this.enteredFPrint);
            this.printPanel.Controls.Add(this.lblDeviceInfo);
            this.printPanel.Controls.Add(this.deviceState);
            this.printPanel.Controls.Add(this.btnCapturePrint);
            this.printPanel.Controls.Add(this.gunaAdvenceButton1);
            this.printPanel.Controls.Add(this.btnEnroll);
            this.printPanel.Controls.Add(this.fingerPrintBox);
            this.printPanel.Controls.Add(this.gunaLabel16);
            this.printPanel.Controls.Add(this.txtFingerprintStatus);
            this.printPanel.Location = new System.Drawing.Point(600, 39);
            this.printPanel.Name = "printPanel";
            this.printPanel.Radius = 15;
            this.printPanel.Size = new System.Drawing.Size(434, 564);
            this.printPanel.TabIndex = 31;
            // 
            // addedIDlbl
            // 
            this.addedIDlbl.AutoSize = true;
            this.addedIDlbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addedIDlbl.Location = new System.Drawing.Point(228, 29);
            this.addedIDlbl.Name = "addedIDlbl";
            this.addedIDlbl.Size = new System.Drawing.Size(0, 20);
            this.addedIDlbl.TabIndex = 8;
            // 
            // printQualityProgress
            // 
            this.printQualityProgress.FillColor = System.Drawing.Color.White;
            this.printQualityProgress.ForeColor = System.Drawing.Color.White;
            this.printQualityProgress.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.printQualityProgress.Location = new System.Drawing.Point(91, 265);
            this.printQualityProgress.Name = "printQualityProgress";
            this.printQualityProgress.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.printQualityProgress.ProgressColor2 = System.Drawing.Color.DodgerBlue;
            this.printQualityProgress.ShadowDecoration.Parent = this.printQualityProgress;
            this.printQualityProgress.ShowPercentage = true;
            this.printQualityProgress.Size = new System.Drawing.Size(260, 18);
            this.printQualityProgress.TabIndex = 7;
            this.printQualityProgress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // enteredFPrint
            // 
            this.enteredFPrint.AutoSize = true;
            this.enteredFPrint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.enteredFPrint.Location = new System.Drawing.Point(152, 87);
            this.enteredFPrint.Name = "enteredFPrint";
            this.enteredFPrint.Size = new System.Drawing.Size(119, 20);
            this.enteredFPrint.TabIndex = 6;
            this.enteredFPrint.Text = "Enter Fingerprint";
            // 
            // lblDeviceInfo
            // 
            this.lblDeviceInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDeviceInfo.AutoSize = true;
            this.lblDeviceInfo.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceInfo.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblDeviceInfo.Location = new System.Drawing.Point(40, 425);
            this.lblDeviceInfo.Name = "lblDeviceInfo";
            this.lblDeviceInfo.Size = new System.Drawing.Size(337, 28);
            this.lblDeviceInfo.TabIndex = 5;
            this.lblDeviceInfo.Text = "DEVICE H : 000 , W: 000 , DPI : 000";
            this.lblDeviceInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deviceState
            // 
            this.deviceState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deviceState.AutoSize = true;
            this.deviceState.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.deviceState.Location = new System.Drawing.Point(114, 368);
            this.deviceState.Name = "deviceState";
            this.deviceState.Size = new System.Drawing.Size(210, 28);
            this.deviceState.TabIndex = 5;
            this.deviceState.Text = "Initialization Success";
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
            this.btnCapturePrint.Location = new System.Drawing.Point(147, 284);
            this.btnCapturePrint.Name = "btnCapturePrint";
            this.btnCapturePrint.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCapturePrint.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnCapturePrint.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCapturePrint.OnHoverImage = null;
            this.btnCapturePrint.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCapturePrint.OnPressedColor = System.Drawing.Color.Black;
            this.btnCapturePrint.Radius = 8;
            this.btnCapturePrint.Size = new System.Drawing.Size(141, 50);
            this.btnCapturePrint.TabIndex = 4;
            this.btnCapturePrint.Text = "CAPTURE";
            this.btnCapturePrint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(25, 491);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.Teal;
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.OnHoverImage")));
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.Teal;
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Radius = 8;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(165, 56);
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
            this.btnEnroll.Location = new System.Drawing.Point(229, 491);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.OnHoverBaseColor = System.Drawing.Color.Green;
            this.btnEnroll.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnEnroll.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEnroll.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnEnroll.OnHoverImage")));
            this.btnEnroll.OnHoverLineColor = System.Drawing.Color.Green;
            this.btnEnroll.OnPressedColor = System.Drawing.Color.Black;
            this.btnEnroll.Radius = 8;
            this.btnEnroll.Size = new System.Drawing.Size(167, 56);
            this.btnEnroll.TabIndex = 4;
            this.btnEnroll.Text = "ENROLL";
            this.btnEnroll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fingerPrintBox
            // 
            this.fingerPrintBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fingerPrintBox.Image = ((System.Drawing.Image)(resources.GetObject("fingerPrintBox.Image")));
            this.fingerPrintBox.Location = new System.Drawing.Point(105, 110);
            this.fingerPrintBox.Name = "fingerPrintBox";
            this.fingerPrintBox.Padding = new System.Windows.Forms.Padding(20);
            this.fingerPrintBox.ShadowDecoration.Parent = this.fingerPrintBox;
            this.fingerPrintBox.Size = new System.Drawing.Size(224, 149);
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
            this.gunaLabel16.Location = new System.Drawing.Point(148, 49);
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
            this.txtFingerprintStatus.Location = new System.Drawing.Point(89, 478);
            this.txtFingerprintStatus.Name = "txtFingerprintStatus";
            this.txtFingerprintStatus.Size = new System.Drawing.Size(0, 28);
            this.txtFingerprintStatus.TabIndex = 0;
            // 
            // AddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1060, 632);
            this.Controls.Add(this.printPanel);
            this.Controls.Add(this.roleDropDown);
            this.Controls.Add(this.btnUserDetailCancel);
            this.Controls.Add(this.btnSaveUser);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.gunaLabel15);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.tbxPass);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddUsers";
            this.Text = "AddUsers";
            this.Load += new System.EventHandler(this.AddUsers_Load);
            this.printPanel.ResumeLayout(false);
            this.printPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fingerPrintBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox roleDropDown;
        private Guna.UI.WinForms.GunaAdvenceButton btnUserDetailCancel;
        private Guna.UI.WinForms.GunaAdvenceButton btnSaveUser;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI.WinForms.GunaLabel gunaLabel15;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI2.WinForms.Guna2TextBox tbxPass;
        private Guna.UI.WinForms.GunaElipsePanel printPanel;
        private Guna.UI.WinForms.GunaLabel addedIDlbl;
        private Guna.UI2.WinForms.Guna2ProgressBar printQualityProgress;
        private Guna.UI.WinForms.GunaLabel enteredFPrint;
        private Guna.UI.WinForms.GunaLabel lblDeviceInfo;
        private Guna.UI.WinForms.GunaLabel deviceState;
        private Guna.UI.WinForms.GunaAdvenceButton btnCapturePrint;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaAdvenceButton btnEnroll;
        private Guna.UI2.WinForms.Guna2PictureBox fingerPrintBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel16;
        private Guna.UI.WinForms.GunaLabel txtFingerprintStatus;
    }
}