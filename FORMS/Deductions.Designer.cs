namespace BiometricPayroll.FORMS
{
    partial class Deductions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deductions));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.parentDeductionPanel = new Guna.UI.WinForms.GunaGradient2Panel();
            this.AddDeductionsPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.deductionMethodDropDown = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAddDeduction = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtBxTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBxAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.comboElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.resetImgBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.DeductionsGVPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.deductionsGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gridViewElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.parentDeductionPanel.SuspendLayout();
            this.AddDeductionsPanel.SuspendLayout();
            this.DeductionsGVPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deductionsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // parentDeductionPanel
            // 
            this.parentDeductionPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.parentDeductionPanel.BackColor = System.Drawing.Color.LightGray;
            this.parentDeductionPanel.Controls.Add(this.DeductionsGVPanel);
            this.parentDeductionPanel.Controls.Add(this.AddDeductionsPanel);
            this.parentDeductionPanel.GradientColor1 = System.Drawing.Color.White;
            this.parentDeductionPanel.GradientColor2 = System.Drawing.Color.White;
            this.parentDeductionPanel.Location = new System.Drawing.Point(5, 6);
            this.parentDeductionPanel.Name = "parentDeductionPanel";
            this.parentDeductionPanel.Size = new System.Drawing.Size(1087, 716);
            this.parentDeductionPanel.TabIndex = 0;
            // 
            // AddDeductionsPanel
            // 
            this.AddDeductionsPanel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AddDeductionsPanel.BackColor = System.Drawing.Color.Transparent;
            this.AddDeductionsPanel.Controls.Add(this.resetImgBtn);
            this.AddDeductionsPanel.Controls.Add(this.deductionMethodDropDown);
            this.AddDeductionsPanel.Controls.Add(this.btnAddDeduction);
            this.AddDeductionsPanel.Controls.Add(this.txtBxTitle);
            this.AddDeductionsPanel.Controls.Add(this.txtBxAmount);
            this.AddDeductionsPanel.Controls.Add(this.gunaLabel4);
            this.AddDeductionsPanel.Controls.Add(this.gunaLabel3);
            this.AddDeductionsPanel.Controls.Add(this.gunaLabel2);
            this.AddDeductionsPanel.Controls.Add(this.gunaPanel2);
            this.AddDeductionsPanel.Controls.Add(this.gunaPanel1);
            this.AddDeductionsPanel.Controls.Add(this.gunaLabel1);
            this.AddDeductionsPanel.FillColor = System.Drawing.Color.White;
            this.AddDeductionsPanel.ForeColor = System.Drawing.Color.Black;
            this.AddDeductionsPanel.Location = new System.Drawing.Point(767, 7);
            this.AddDeductionsPanel.Name = "AddDeductionsPanel";
            this.AddDeductionsPanel.Radius = 10;
            this.AddDeductionsPanel.ShadowColor = System.Drawing.Color.Black;
            this.AddDeductionsPanel.Size = new System.Drawing.Size(317, 568);
            this.AddDeductionsPanel.TabIndex = 0;
            // 
            // deductionMethodDropDown
            // 
            this.deductionMethodDropDown.BackColor = System.Drawing.Color.Transparent;
            this.deductionMethodDropDown.BorderRadius = 5;
            this.deductionMethodDropDown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.deductionMethodDropDown.DropDownHeight = 64;
            this.deductionMethodDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deductionMethodDropDown.FocusedColor = System.Drawing.Color.Empty;
            this.deductionMethodDropDown.FocusedState.Parent = this.deductionMethodDropDown;
            this.deductionMethodDropDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.deductionMethodDropDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deductionMethodDropDown.FormattingEnabled = true;
            this.deductionMethodDropDown.HoverState.Parent = this.deductionMethodDropDown;
            this.deductionMethodDropDown.IntegralHeight = false;
            this.deductionMethodDropDown.ItemHeight = 30;
            this.deductionMethodDropDown.Items.AddRange(new object[] {
            "AMOUNT",
            "PERCENTAGE"});
            this.deductionMethodDropDown.ItemsAppearance.Parent = this.deductionMethodDropDown;
            this.deductionMethodDropDown.Location = new System.Drawing.Point(44, 362);
            this.deductionMethodDropDown.Name = "deductionMethodDropDown";
            this.deductionMethodDropDown.ShadowDecoration.Parent = this.deductionMethodDropDown;
            this.deductionMethodDropDown.Size = new System.Drawing.Size(231, 36);
            this.deductionMethodDropDown.TabIndex = 6;
            this.deductionMethodDropDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddDeduction
            // 
            this.btnAddDeduction.AnimationHoverSpeed = 0.07F;
            this.btnAddDeduction.AnimationSpeed = 0.03F;
            this.btnAddDeduction.BackColor = System.Drawing.Color.Transparent;
            this.btnAddDeduction.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnAddDeduction.BorderColor = System.Drawing.Color.Black;
            this.btnAddDeduction.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAddDeduction.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAddDeduction.CheckedForeColor = System.Drawing.Color.White;
            this.btnAddDeduction.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAddDeduction.CheckedImage")));
            this.btnAddDeduction.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAddDeduction.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddDeduction.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddDeduction.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnAddDeduction.ForeColor = System.Drawing.Color.White;
            this.btnAddDeduction.Image = null;
            this.btnAddDeduction.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddDeduction.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddDeduction.Location = new System.Drawing.Point(109, 431);
            this.btnAddDeduction.Name = "btnAddDeduction";
            this.btnAddDeduction.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAddDeduction.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddDeduction.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddDeduction.OnHoverImage = null;
            this.btnAddDeduction.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddDeduction.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddDeduction.Radius = 6;
            this.btnAddDeduction.Size = new System.Drawing.Size(107, 42);
            this.btnAddDeduction.TabIndex = 5;
            this.btnAddDeduction.Text = "ADD";
            this.btnAddDeduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddDeduction.Click += new System.EventHandler(this.btnAddDeduction_Click);
            // 
            // txtBxTitle
            // 
            this.txtBxTitle.BorderColor = System.Drawing.Color.Transparent;
            this.txtBxTitle.BorderThickness = 0;
            this.txtBxTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBxTitle.DefaultText = "";
            this.txtBxTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBxTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBxTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBxTitle.DisabledState.Parent = this.txtBxTitle;
            this.txtBxTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBxTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBxTitle.FocusedState.Parent = this.txtBxTitle;
            this.txtBxTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.txtBxTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBxTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBxTitle.HoverState.Parent = this.txtBxTitle;
            this.txtBxTitle.Location = new System.Drawing.Point(19, 144);
            this.txtBxTitle.Margin = new System.Windows.Forms.Padding(16);
            this.txtBxTitle.Name = "txtBxTitle";
            this.txtBxTitle.PasswordChar = '\0';
            this.txtBxTitle.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtBxTitle.PlaceholderText = "eg. NHIF";
            this.txtBxTitle.SelectedText = "";
            this.txtBxTitle.ShadowDecoration.Parent = this.txtBxTitle;
            this.txtBxTitle.Size = new System.Drawing.Size(271, 25);
            this.txtBxTitle.TabIndex = 4;
            this.txtBxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBxTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateTextOnKeyPress);
            // 
            // txtBxAmount
            // 
            this.txtBxAmount.BorderColor = System.Drawing.Color.Transparent;
            this.txtBxAmount.BorderThickness = 0;
            this.txtBxAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBxAmount.DefaultText = "";
            this.txtBxAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBxAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBxAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBxAmount.DisabledState.Parent = this.txtBxAmount;
            this.txtBxAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBxAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBxAmount.FocusedState.Parent = this.txtBxAmount;
            this.txtBxAmount.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.txtBxAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBxAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBxAmount.HoverState.Parent = this.txtBxAmount;
            this.txtBxAmount.Location = new System.Drawing.Point(18, 247);
            this.txtBxAmount.Margin = new System.Windows.Forms.Padding(8);
            this.txtBxAmount.Name = "txtBxAmount";
            this.txtBxAmount.PasswordChar = '\0';
            this.txtBxAmount.PlaceholderText = "eg. 1500";
            this.txtBxAmount.SelectedText = "";
            this.txtBxAmount.ShadowDecoration.Parent = this.txtBxAmount;
            this.txtBxAmount.Size = new System.Drawing.Size(272, 33);
            this.txtBxAmount.TabIndex = 4;
            this.txtBxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBxAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNumberOnKeyPress);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(94, 320);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(134, 20);
            this.gunaLabel4.TabIndex = 2;
            this.gunaLabel4.Text = "Deduction Method";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(129, 216);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(62, 20);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "Amount";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(141, 110);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(38, 20);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Title";
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.DarkGray;
            this.gunaPanel2.Location = new System.Drawing.Point(18, 282);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(273, 4);
            this.gunaPanel2.TabIndex = 1;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.DarkGray;
            this.gunaPanel1.Location = new System.Drawing.Point(18, 172);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(273, 4);
            this.gunaPanel1.TabIndex = 1;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.Location = new System.Drawing.Point(78, 34);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(178, 28);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "ADD DEDUCTION";
            // 
            // resetImgBtn
            // 
            this.resetImgBtn.CheckedState.Parent = this.resetImgBtn;
            this.resetImgBtn.HoverState.Parent = this.resetImgBtn;
            this.resetImgBtn.Image = ((System.Drawing.Image)(resources.GetObject("resetImgBtn.Image")));
            this.resetImgBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.resetImgBtn.Location = new System.Drawing.Point(128, 491);
            this.resetImgBtn.Name = "resetImgBtn";
            this.resetImgBtn.PressedState.Parent = this.resetImgBtn;
            this.resetImgBtn.Size = new System.Drawing.Size(63, 48);
            this.resetImgBtn.TabIndex = 7;
            this.resetImgBtn.Click += new System.EventHandler(this.resetImgBtn_Click);
            // 
            // DeductionsGVPanel
            // 
            this.DeductionsGVPanel.BackColor = System.Drawing.Color.Transparent;
            this.DeductionsGVPanel.Controls.Add(this.gunaLabel6);
            this.DeductionsGVPanel.Controls.Add(this.deductionsGridView);
            this.DeductionsGVPanel.FillColor = System.Drawing.Color.White;
            this.DeductionsGVPanel.Location = new System.Drawing.Point(7, 6);
            this.DeductionsGVPanel.Name = "DeductionsGVPanel";
            this.DeductionsGVPanel.Radius = 10;
            this.DeductionsGVPanel.ShadowColor = System.Drawing.Color.Black;
            this.DeductionsGVPanel.Size = new System.Drawing.Size(754, 702);
            this.DeductionsGVPanel.TabIndex = 1;
            // 
            // deductionsGridView
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.deductionsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.deductionsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.deductionsGridView.BackgroundColor = System.Drawing.Color.White;
            this.deductionsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deductionsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.deductionsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.deductionsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.deductionsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.deductionsGridView.DefaultCellStyle = dataGridViewCellStyle12;
            this.deductionsGridView.EnableHeadersVisualStyles = false;
            this.deductionsGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.deductionsGridView.Location = new System.Drawing.Point(9, 62);
            this.deductionsGridView.Name = "deductionsGridView";
            this.deductionsGridView.RowHeadersVisible = false;
            this.deductionsGridView.RowHeadersWidth = 51;
            this.deductionsGridView.RowTemplate.Height = 24;
            this.deductionsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.deductionsGridView.Size = new System.Drawing.Size(738, 646);
            this.deductionsGridView.TabIndex = 0;
            this.deductionsGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.deductionsGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.deductionsGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.deductionsGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.deductionsGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.deductionsGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.deductionsGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.deductionsGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.deductionsGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.deductionsGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.deductionsGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deductionsGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.deductionsGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deductionsGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.deductionsGridView.ThemeStyle.ReadOnly = false;
            this.deductionsGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.deductionsGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.deductionsGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deductionsGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.deductionsGridView.ThemeStyle.RowsStyle.Height = 24;
            this.deductionsGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.deductionsGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.gunaLabel6.Location = new System.Drawing.Point(300, 16);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(168, 32);
            this.gunaLabel6.TabIndex = 1;
            this.gunaLabel6.Text = "DEDUCTIONS";
            // 
            // gridViewElipse
            // 
            this.gridViewElipse.BorderRadius = 10;
            this.gridViewElipse.TargetControl = this.DeductionsGVPanel;
            // 
            // Deductions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1096, 726);
            this.Controls.Add(this.parentDeductionPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1096, 726);
            this.Name = "Deductions";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Deductions";
            this.Load += new System.EventHandler(this.Deductions_Load);
            this.parentDeductionPanel.ResumeLayout(false);
            this.AddDeductionsPanel.ResumeLayout(false);
            this.AddDeductionsPanel.PerformLayout();
            this.DeductionsGVPanel.ResumeLayout(false);
            this.DeductionsGVPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deductionsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradient2Panel parentDeductionPanel;
        private Guna.UI2.WinForms.Guna2ShadowPanel AddDeductionsPanel;
        private Guna.UI.WinForms.GunaAdvenceButton btnAddDeduction;
        private Guna.UI2.WinForms.Guna2TextBox txtBxAmount;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2Elipse comboElipse;
        private Guna.UI2.WinForms.Guna2ComboBox deductionMethodDropDown;
        private Guna.UI2.WinForms.Guna2TextBox txtBxTitle;
        private Guna.UI2.WinForms.Guna2ImageButton resetImgBtn;
        private Guna.UI2.WinForms.Guna2ShadowPanel DeductionsGVPanel;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI2.WinForms.Guna2DataGridView deductionsGridView;
        private Guna.UI2.WinForms.Guna2Elipse gridViewElipse;
    }
}