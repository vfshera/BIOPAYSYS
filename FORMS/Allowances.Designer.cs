namespace BiometricPayroll.FORMS
{
    partial class Allowances
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Allowances));
            this.parentDeductionPanel = new Guna.UI.WinForms.GunaGradient2Panel();
            this.DeductionsGVPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.allowancesGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.AddDeductionsPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.resetImgBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.statusDropDwn = new Guna.UI2.WinForms.Guna2ComboBox();
            this.allowanceMethodDropDown = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAddAllowances = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtBxTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtBxAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.formHeaderlbl = new Guna.UI.WinForms.GunaLabel();
            this.editBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.delBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.parentDeductionPanel.SuspendLayout();
            this.DeductionsGVPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allowancesGridView)).BeginInit();
            this.AddDeductionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // parentDeductionPanel
            // 
            this.parentDeductionPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.parentDeductionPanel.BackColor = System.Drawing.Color.LightGray;
            this.parentDeductionPanel.Controls.Add(this.DeductionsGVPanel);
            this.parentDeductionPanel.Controls.Add(this.AddDeductionsPanel);
            this.parentDeductionPanel.Controls.Add(this.editBtn);
            this.parentDeductionPanel.Controls.Add(this.delBtn);
            this.parentDeductionPanel.GradientColor1 = System.Drawing.Color.White;
            this.parentDeductionPanel.GradientColor2 = System.Drawing.Color.White;
            this.parentDeductionPanel.Location = new System.Drawing.Point(8, 6);
            this.parentDeductionPanel.Name = "parentDeductionPanel";
            this.parentDeductionPanel.Size = new System.Drawing.Size(1078, 713);
            this.parentDeductionPanel.TabIndex = 1;
            // 
            // DeductionsGVPanel
            // 
            this.DeductionsGVPanel.BackColor = System.Drawing.Color.Transparent;
            this.DeductionsGVPanel.Controls.Add(this.gunaLabel6);
            this.DeductionsGVPanel.Controls.Add(this.allowancesGridView);
            this.DeductionsGVPanel.FillColor = System.Drawing.Color.White;
            this.DeductionsGVPanel.Location = new System.Drawing.Point(7, 7);
            this.DeductionsGVPanel.Name = "DeductionsGVPanel";
            this.DeductionsGVPanel.Radius = 10;
            this.DeductionsGVPanel.ShadowColor = System.Drawing.Color.Black;
            this.DeductionsGVPanel.Size = new System.Drawing.Size(734, 701);
            this.DeductionsGVPanel.TabIndex = 1;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.gunaLabel6.Location = new System.Drawing.Point(290, 15);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(173, 32);
            this.gunaLabel6.TabIndex = 1;
            this.gunaLabel6.Text = "ALLOWANCES";
            // 
            // allowancesGridView
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.allowancesGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.allowancesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.allowancesGridView.BackgroundColor = System.Drawing.Color.White;
            this.allowancesGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allowancesGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.allowancesGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allowancesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.allowancesGridView.ColumnHeadersHeight = 40;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.allowancesGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.allowancesGridView.EnableHeadersVisualStyles = false;
            this.allowancesGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.allowancesGridView.Location = new System.Drawing.Point(14, 62);
            this.allowancesGridView.Name = "allowancesGridView";
            this.allowancesGridView.RowHeadersVisible = false;
            this.allowancesGridView.RowHeadersWidth = 51;
            this.allowancesGridView.RowTemplate.Height = 40;
            this.allowancesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allowancesGridView.Size = new System.Drawing.Size(706, 599);
            this.allowancesGridView.TabIndex = 0;
            this.allowancesGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.allowancesGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.allowancesGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.allowancesGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.allowancesGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.allowancesGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.allowancesGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.allowancesGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.allowancesGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.allowancesGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.allowancesGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allowancesGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.allowancesGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.allowancesGridView.ThemeStyle.HeaderStyle.Height = 40;
            this.allowancesGridView.ThemeStyle.ReadOnly = false;
            this.allowancesGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.allowancesGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.allowancesGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allowancesGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.allowancesGridView.ThemeStyle.RowsStyle.Height = 40;
            this.allowancesGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.allowancesGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.allowancesGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.allowancesGridView_CellClick);
            // 
            // AddDeductionsPanel
            // 
            this.AddDeductionsPanel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AddDeductionsPanel.BackColor = System.Drawing.Color.Transparent;
            this.AddDeductionsPanel.Controls.Add(this.resetImgBtn);
            this.AddDeductionsPanel.Controls.Add(this.statusDropDwn);
            this.AddDeductionsPanel.Controls.Add(this.allowanceMethodDropDown);
            this.AddDeductionsPanel.Controls.Add(this.btnAddAllowances);
            this.AddDeductionsPanel.Controls.Add(this.txtBxTitle);
            this.AddDeductionsPanel.Controls.Add(this.gunaLabel1);
            this.AddDeductionsPanel.Controls.Add(this.txtBxAmount);
            this.AddDeductionsPanel.Controls.Add(this.gunaLabel4);
            this.AddDeductionsPanel.Controls.Add(this.gunaLabel3);
            this.AddDeductionsPanel.Controls.Add(this.gunaLabel2);
            this.AddDeductionsPanel.Controls.Add(this.gunaPanel2);
            this.AddDeductionsPanel.Controls.Add(this.gunaPanel1);
            this.AddDeductionsPanel.Controls.Add(this.formHeaderlbl);
            this.AddDeductionsPanel.FillColor = System.Drawing.Color.White;
            this.AddDeductionsPanel.ForeColor = System.Drawing.Color.Black;
            this.AddDeductionsPanel.Location = new System.Drawing.Point(752, 13);
            this.AddDeductionsPanel.Name = "AddDeductionsPanel";
            this.AddDeductionsPanel.Radius = 10;
            this.AddDeductionsPanel.ShadowColor = System.Drawing.Color.Black;
            this.AddDeductionsPanel.Size = new System.Drawing.Size(317, 604);
            this.AddDeductionsPanel.TabIndex = 0;
            // 
            // resetImgBtn
            // 
            this.resetImgBtn.CheckedState.Parent = this.resetImgBtn;
            this.resetImgBtn.HoverState.Parent = this.resetImgBtn;
            this.resetImgBtn.Image = ((System.Drawing.Image)(resources.GetObject("resetImgBtn.Image")));
            this.resetImgBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.resetImgBtn.Location = new System.Drawing.Point(128, 536);
            this.resetImgBtn.Name = "resetImgBtn";
            this.resetImgBtn.PressedState.Parent = this.resetImgBtn;
            this.resetImgBtn.Size = new System.Drawing.Size(63, 48);
            this.resetImgBtn.TabIndex = 7;
            this.resetImgBtn.Click += new System.EventHandler(this.resetImgBtn_Click);
            // 
            // statusDropDwn
            // 
            this.statusDropDwn.BackColor = System.Drawing.Color.Transparent;
            this.statusDropDwn.BorderRadius = 5;
            this.statusDropDwn.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.statusDropDwn.DropDownHeight = 64;
            this.statusDropDwn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusDropDwn.FocusedColor = System.Drawing.Color.Empty;
            this.statusDropDwn.FocusedState.Parent = this.statusDropDwn;
            this.statusDropDwn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.statusDropDwn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.statusDropDwn.FormattingEnabled = true;
            this.statusDropDwn.HoverState.Parent = this.statusDropDwn;
            this.statusDropDwn.IntegralHeight = false;
            this.statusDropDwn.ItemHeight = 30;
            this.statusDropDwn.Items.AddRange(new object[] {
            "ACTIVE",
            "INACTIVE"});
            this.statusDropDwn.ItemsAppearance.Parent = this.statusDropDwn;
            this.statusDropDwn.Location = new System.Drawing.Point(44, 427);
            this.statusDropDwn.Name = "statusDropDwn";
            this.statusDropDwn.ShadowDecoration.Parent = this.statusDropDwn;
            this.statusDropDwn.Size = new System.Drawing.Size(231, 36);
            this.statusDropDwn.TabIndex = 6;
            this.statusDropDwn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // allowanceMethodDropDown
            // 
            this.allowanceMethodDropDown.BackColor = System.Drawing.Color.Transparent;
            this.allowanceMethodDropDown.BorderRadius = 5;
            this.allowanceMethodDropDown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.allowanceMethodDropDown.DropDownHeight = 64;
            this.allowanceMethodDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.allowanceMethodDropDown.FocusedColor = System.Drawing.Color.Empty;
            this.allowanceMethodDropDown.FocusedState.Parent = this.allowanceMethodDropDown;
            this.allowanceMethodDropDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.allowanceMethodDropDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.allowanceMethodDropDown.FormattingEnabled = true;
            this.allowanceMethodDropDown.HoverState.Parent = this.allowanceMethodDropDown;
            this.allowanceMethodDropDown.IntegralHeight = false;
            this.allowanceMethodDropDown.ItemHeight = 30;
            this.allowanceMethodDropDown.Items.AddRange(new object[] {
            "AMOUNT",
            "PERCENTAGE"});
            this.allowanceMethodDropDown.ItemsAppearance.Parent = this.allowanceMethodDropDown;
            this.allowanceMethodDropDown.Location = new System.Drawing.Point(44, 331);
            this.allowanceMethodDropDown.Name = "allowanceMethodDropDown";
            this.allowanceMethodDropDown.ShadowDecoration.Parent = this.allowanceMethodDropDown;
            this.allowanceMethodDropDown.Size = new System.Drawing.Size(231, 36);
            this.allowanceMethodDropDown.TabIndex = 6;
            this.allowanceMethodDropDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddAllowances
            // 
            this.btnAddAllowances.AnimationHoverSpeed = 0.07F;
            this.btnAddAllowances.AnimationSpeed = 0.03F;
            this.btnAddAllowances.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAllowances.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnAddAllowances.BorderColor = System.Drawing.Color.Black;
            this.btnAddAllowances.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAddAllowances.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAddAllowances.CheckedForeColor = System.Drawing.Color.White;
            this.btnAddAllowances.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAddAllowances.CheckedImage")));
            this.btnAddAllowances.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAddAllowances.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddAllowances.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddAllowances.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnAddAllowances.ForeColor = System.Drawing.Color.White;
            this.btnAddAllowances.Image = null;
            this.btnAddAllowances.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddAllowances.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddAllowances.Location = new System.Drawing.Point(109, 476);
            this.btnAddAllowances.Name = "btnAddAllowances";
            this.btnAddAllowances.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAddAllowances.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddAllowances.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddAllowances.OnHoverImage = null;
            this.btnAddAllowances.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddAllowances.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddAllowances.Radius = 6;
            this.btnAddAllowances.Size = new System.Drawing.Size(107, 42);
            this.btnAddAllowances.TabIndex = 5;
            this.btnAddAllowances.Text = "ADD";
            this.btnAddAllowances.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddAllowances.Click += new System.EventHandler(this.btnAddAllowance_Click);
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
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(140, 402);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(49, 20);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Status";
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
            this.txtBxAmount.Location = new System.Drawing.Point(18, 231);
            this.txtBxAmount.Margin = new System.Windows.Forms.Padding(8);
            this.txtBxAmount.Name = "txtBxAmount";
            this.txtBxAmount.PasswordChar = '\0';
            this.txtBxAmount.PlaceholderText = "eg. 1500";
            this.txtBxAmount.SelectedText = "";
            this.txtBxAmount.ShadowDecoration.Parent = this.txtBxAmount;
            this.txtBxAmount.Size = new System.Drawing.Size(272, 33);
            this.txtBxAmount.TabIndex = 4;
            this.txtBxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(129, 297);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(61, 20);
            this.gunaLabel4.TabIndex = 2;
            this.gunaLabel4.Text = "Method";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(129, 200);
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
            this.gunaPanel2.Location = new System.Drawing.Point(18, 266);
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
            // formHeaderlbl
            // 
            this.formHeaderlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.formHeaderlbl.AutoSize = true;
            this.formHeaderlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.formHeaderlbl.Location = new System.Drawing.Point(78, 52);
            this.formHeaderlbl.Name = "formHeaderlbl";
            this.formHeaderlbl.Size = new System.Drawing.Size(194, 28);
            this.formHeaderlbl.TabIndex = 0;
            this.formHeaderlbl.Text = "ADD ALLOWANCES";
            this.formHeaderlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editBtn
            // 
            this.editBtn.AnimationHoverSpeed = 0.07F;
            this.editBtn.AnimationSpeed = 0.03F;
            this.editBtn.BackColor = System.Drawing.Color.Transparent;
            this.editBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.editBtn.BorderColor = System.Drawing.Color.Black;
            this.editBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.editBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.editBtn.CheckedForeColor = System.Drawing.Color.White;
            this.editBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("editBtn.CheckedImage")));
            this.editBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.editBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.editBtn.FocusedColor = System.Drawing.Color.Empty;
            this.editBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Image = null;
            this.editBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.editBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.editBtn.Location = new System.Drawing.Point(962, 630);
            this.editBtn.Name = "editBtn";
            this.editBtn.OnHoverBaseColor = System.Drawing.Color.Teal;
            this.editBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.editBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.editBtn.OnHoverImage = null;
            this.editBtn.OnHoverLineColor = System.Drawing.Color.Cyan;
            this.editBtn.OnPressedColor = System.Drawing.Color.Black;
            this.editBtn.Radius = 6;
            this.editBtn.Size = new System.Drawing.Size(107, 42);
            this.editBtn.TabIndex = 5;
            this.editBtn.Text = "EDIT";
            this.editBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.AnimationHoverSpeed = 0.07F;
            this.delBtn.AnimationSpeed = 0.03F;
            this.delBtn.BackColor = System.Drawing.Color.Transparent;
            this.delBtn.BaseColor = System.Drawing.Color.Red;
            this.delBtn.BorderColor = System.Drawing.Color.Black;
            this.delBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.delBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.delBtn.CheckedForeColor = System.Drawing.Color.White;
            this.delBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("delBtn.CheckedImage")));
            this.delBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.delBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.delBtn.FocusedColor = System.Drawing.Color.Empty;
            this.delBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.delBtn.ForeColor = System.Drawing.Color.White;
            this.delBtn.Image = null;
            this.delBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.delBtn.LineColor = System.Drawing.Color.Red;
            this.delBtn.Location = new System.Drawing.Point(757, 630);
            this.delBtn.Name = "delBtn";
            this.delBtn.OnHoverBaseColor = System.Drawing.Color.Maroon;
            this.delBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.delBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.delBtn.OnHoverImage = null;
            this.delBtn.OnHoverLineColor = System.Drawing.Color.Red;
            this.delBtn.OnPressedColor = System.Drawing.Color.Black;
            this.delBtn.Radius = 6;
            this.delBtn.Size = new System.Drawing.Size(107, 42);
            this.delBtn.TabIndex = 5;
            this.delBtn.Text = "DELETE";
            this.delBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // Allowances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 726);
            this.Controls.Add(this.parentDeductionPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Allowances";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Allowances";
            this.Load += new System.EventHandler(this.Allowances_Load);
            this.parentDeductionPanel.ResumeLayout(false);
            this.DeductionsGVPanel.ResumeLayout(false);
            this.DeductionsGVPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allowancesGridView)).EndInit();
            this.AddDeductionsPanel.ResumeLayout(false);
            this.AddDeductionsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradient2Panel parentDeductionPanel;
        private Guna.UI2.WinForms.Guna2ShadowPanel DeductionsGVPanel;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI2.WinForms.Guna2DataGridView allowancesGridView;
        private Guna.UI2.WinForms.Guna2ShadowPanel AddDeductionsPanel;
        private Guna.UI2.WinForms.Guna2ImageButton resetImgBtn;
        private Guna.UI2.WinForms.Guna2ComboBox statusDropDwn;
        private Guna.UI2.WinForms.Guna2ComboBox allowanceMethodDropDown;
        private Guna.UI.WinForms.GunaAdvenceButton btnAddAllowances;
        private Guna.UI2.WinForms.Guna2TextBox txtBxTitle;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtBxAmount;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel formHeaderlbl;
        private Guna.UI.WinForms.GunaAdvenceButton editBtn;
        private Guna.UI.WinForms.GunaAdvenceButton delBtn;
    }
}