namespace BiometricPayroll.FORMS
{
    partial class GeneratePay
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneratePay));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.empSidePanel = new Guna.UI.WinForms.GunaPanel();
            this.currEmpPanel = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.getSIzelbl = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.empListGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.incomePanel = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.btnAllowance = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnDeductions = new Guna.UI.WinForms.GunaAdvenceButton();
            this.DedAllGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.getWHtimer = new System.Windows.Forms.Timer(this.components);
            this.empSidePanel.SuspendLayout();
            this.currEmpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empListGV)).BeginInit();
            this.incomePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DedAllGV)).BeginInit();
            this.SuspendLayout();
            // 
            // empSidePanel
            // 
            this.empSidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empSidePanel.Controls.Add(this.currEmpPanel);
            this.empSidePanel.Controls.Add(this.empListGV);
            this.empSidePanel.Location = new System.Drawing.Point(6, 27);
            this.empSidePanel.Name = "empSidePanel";
            this.empSidePanel.Size = new System.Drawing.Size(468, 787);
            this.empSidePanel.TabIndex = 0;
            // 
            // currEmpPanel
            // 
            this.currEmpPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currEmpPanel.BackColor = System.Drawing.Color.White;
            this.currEmpPanel.Controls.Add(this.gunaLabel1);
            this.currEmpPanel.Controls.Add(this.getSIzelbl);
            this.currEmpPanel.Controls.Add(this.gunaLabel4);
            this.currEmpPanel.Controls.Add(this.gunaLabel6);
            this.currEmpPanel.Controls.Add(this.gunaLabel7);
            this.currEmpPanel.Controls.Add(this.gunaLabel3);
            this.currEmpPanel.Controls.Add(this.gunaLabel2);
            this.currEmpPanel.Controls.Add(this.gunaLabel5);
            this.currEmpPanel.Location = new System.Drawing.Point(7, 0);
            this.currEmpPanel.Name = "currEmpPanel";
            this.currEmpPanel.Size = new System.Drawing.Size(450, 215);
            this.currEmpPanel.TabIndex = 2;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gunaLabel1.Location = new System.Drawing.Point(13, 14);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(101, 28);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "FirstName";
            // 
            // getSIzelbl
            // 
            this.getSIzelbl.AutoSize = true;
            this.getSIzelbl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.getSIzelbl.Location = new System.Drawing.Point(370, 163);
            this.getSIzelbl.Name = "getSIzelbl";
            this.getSIzelbl.Size = new System.Drawing.Size(49, 28);
            this.getSIzelbl.TabIndex = 1;
            this.getSIzelbl.Text = "H:W";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gunaLabel4.Location = new System.Drawing.Point(13, 69);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(76, 28);
            this.gunaLabel4.TabIndex = 1;
            this.gunaLabel4.Text = "Gender";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gunaLabel6.Location = new System.Drawing.Point(370, 74);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(65, 28);
            this.gunaLabel6.TabIndex = 1;
            this.gunaLabel6.Text = "Salary";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gunaLabel7.Location = new System.Drawing.Point(13, 163);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(218, 28);
            this.gunaLabel7.TabIndex = 1;
            this.gunaLabel7.Text = "Joined On : 19-04-2020";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gunaLabel3.Location = new System.Drawing.Point(370, 14);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(89, 28);
            this.gunaLabel3.TabIndex = 1;
            this.gunaLabel3.Text = "Surname";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gunaLabel2.Location = new System.Drawing.Point(188, 14);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(129, 28);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "SecondName";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gunaLabel5.Location = new System.Drawing.Point(188, 74);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(106, 28);
            this.gunaLabel5.TabIndex = 1;
            this.gunaLabel5.Text = "NationalID";
            // 
            // empListGV
            // 
            this.empListGV.AllowUserToAddRows = false;
            this.empListGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.empListGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.empListGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empListGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.empListGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.empListGV.BackgroundColor = System.Drawing.Color.White;
            this.empListGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.empListGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.empListGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.empListGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.empListGV.ColumnHeadersHeight = 4;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.empListGV.DefaultCellStyle = dataGridViewCellStyle15;
            this.empListGV.EnableHeadersVisualStyles = false;
            this.empListGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.empListGV.Location = new System.Drawing.Point(8, 224);
            this.empListGV.Name = "empListGV";
            this.empListGV.ReadOnly = true;
            this.empListGV.RowHeadersVisible = false;
            this.empListGV.RowHeadersWidth = 51;
            this.empListGV.RowTemplate.Height = 24;
            this.empListGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.empListGV.Size = new System.Drawing.Size(450, 560);
            this.empListGV.TabIndex = 0;
            this.empListGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.empListGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.empListGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.empListGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.empListGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.empListGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.empListGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.empListGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.empListGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.empListGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.empListGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.empListGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.empListGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.empListGV.ThemeStyle.HeaderStyle.Height = 4;
            this.empListGV.ThemeStyle.ReadOnly = true;
            this.empListGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.empListGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.empListGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.empListGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.empListGV.ThemeStyle.RowsStyle.Height = 24;
            this.empListGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.empListGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // incomePanel
            // 
            this.incomePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.incomePanel.BackColor = System.Drawing.Color.White;
            this.incomePanel.Controls.Add(this.gunaLabel8);
            this.incomePanel.Controls.Add(this.btnAllowance);
            this.incomePanel.Controls.Add(this.btnDeductions);
            this.incomePanel.Controls.Add(this.DedAllGV);
            this.incomePanel.Location = new System.Drawing.Point(495, 27);
            this.incomePanel.Name = "incomePanel";
            this.incomePanel.Size = new System.Drawing.Size(774, 787);
            this.incomePanel.TabIndex = 1;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.gunaLabel8.Location = new System.Drawing.Point(11, 18);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(182, 35);
            this.gunaLabel8.TabIndex = 42;
            this.gunaLabel8.Text = "ALLOWANCES";
            // 
            // btnAllowance
            // 
            this.btnAllowance.AnimationHoverSpeed = 0.07F;
            this.btnAllowance.AnimationSpeed = 0.03F;
            this.btnAllowance.BackColor = System.Drawing.Color.Transparent;
            this.btnAllowance.BaseColor = System.Drawing.Color.DodgerBlue;
            this.btnAllowance.BorderColor = System.Drawing.Color.Black;
            this.btnAllowance.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAllowance.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAllowance.CheckedForeColor = System.Drawing.Color.White;
            this.btnAllowance.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAllowance.CheckedImage")));
            this.btnAllowance.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAllowance.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAllowance.FocusedColor = System.Drawing.Color.Empty;
            this.btnAllowance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAllowance.ForeColor = System.Drawing.Color.White;
            this.btnAllowance.Image = ((System.Drawing.Image)(resources.GetObject("btnAllowance.Image")));
            this.btnAllowance.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAllowance.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAllowance.LineColor = System.Drawing.Color.DodgerBlue;
            this.btnAllowance.Location = new System.Drawing.Point(567, 5);
            this.btnAllowance.Name = "btnAllowance";
            this.btnAllowance.OnHoverBaseColor = System.Drawing.Color.DodgerBlue;
            this.btnAllowance.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAllowance.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAllowance.OnHoverImage = null;
            this.btnAllowance.OnHoverLineColor = System.Drawing.Color.DodgerBlue;
            this.btnAllowance.OnPressedColor = System.Drawing.Color.Black;
            this.btnAllowance.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAllowance.Radius = 25;
            this.btnAllowance.Size = new System.Drawing.Size(161, 48);
            this.btnAllowance.TabIndex = 40;
            this.btnAllowance.Text = "ALLOWANCE";
            this.btnAllowance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDeductions
            // 
            this.btnDeductions.AnimationHoverSpeed = 0.07F;
            this.btnDeductions.AnimationSpeed = 0.03F;
            this.btnDeductions.BackColor = System.Drawing.Color.Transparent;
            this.btnDeductions.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnDeductions.BorderColor = System.Drawing.Color.Black;
            this.btnDeductions.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnDeductions.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnDeductions.CheckedForeColor = System.Drawing.Color.White;
            this.btnDeductions.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnDeductions.CheckedImage")));
            this.btnDeductions.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnDeductions.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDeductions.FocusedColor = System.Drawing.Color.Empty;
            this.btnDeductions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeductions.ForeColor = System.Drawing.Color.White;
            this.btnDeductions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeductions.Image")));
            this.btnDeductions.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDeductions.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDeductions.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDeductions.Location = new System.Drawing.Point(365, 7);
            this.btnDeductions.Name = "btnDeductions";
            this.btnDeductions.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnDeductions.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDeductions.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDeductions.OnHoverImage = null;
            this.btnDeductions.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.btnDeductions.OnPressedColor = System.Drawing.Color.Black;
            this.btnDeductions.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDeductions.Radius = 25;
            this.btnDeductions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDeductions.Size = new System.Drawing.Size(161, 48);
            this.btnDeductions.TabIndex = 41;
            this.btnDeductions.Text = "DEDUCTIONS";
            this.btnDeductions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DedAllGV
            // 
            this.DedAllGV.AllowUserToAddRows = false;
            this.DedAllGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.DedAllGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.DedAllGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DedAllGV.BackgroundColor = System.Drawing.Color.White;
            this.DedAllGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DedAllGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DedAllGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DedAllGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.DedAllGV.ColumnHeadersHeight = 4;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DedAllGV.DefaultCellStyle = dataGridViewCellStyle18;
            this.DedAllGV.EnableHeadersVisualStyles = false;
            this.DedAllGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DedAllGV.Location = new System.Drawing.Point(9, 69);
            this.DedAllGV.Name = "DedAllGV";
            this.DedAllGV.ReadOnly = true;
            this.DedAllGV.RowHeadersVisible = false;
            this.DedAllGV.RowHeadersWidth = 51;
            this.DedAllGV.RowTemplate.Height = 24;
            this.DedAllGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DedAllGV.Size = new System.Drawing.Size(753, 754);
            this.DedAllGV.TabIndex = 0;
            this.DedAllGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DedAllGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DedAllGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DedAllGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DedAllGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DedAllGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DedAllGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DedAllGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DedAllGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DedAllGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DedAllGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DedAllGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DedAllGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DedAllGV.ThemeStyle.HeaderStyle.Height = 4;
            this.DedAllGV.ThemeStyle.ReadOnly = true;
            this.DedAllGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DedAllGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DedAllGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DedAllGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DedAllGV.ThemeStyle.RowsStyle.Height = 24;
            this.DedAllGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DedAllGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // getWHtimer
            // 
            this.getWHtimer.Interval = 1000;
            this.getWHtimer.Tick += new System.EventHandler(this.getWHtimer_Tick);
            // 
            // GeneratePay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 842);
            this.Controls.Add(this.incomePanel);
            this.Controls.Add(this.empSidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GeneratePay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeneratePay";
            this.Load += new System.EventHandler(this.GeneratePay_Load);
            this.empSidePanel.ResumeLayout(false);
            this.currEmpPanel.ResumeLayout(false);
            this.currEmpPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empListGV)).EndInit();
            this.incomePanel.ResumeLayout(false);
            this.incomePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DedAllGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel empSidePanel;
        private Guna.UI2.WinForms.Guna2DataGridView empListGV;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaPanel incomePanel;
        private Guna.UI2.WinForms.Guna2DataGridView DedAllGV;
        private Guna.UI.WinForms.GunaAdvenceButton btnAllowance;
        private Guna.UI.WinForms.GunaAdvenceButton btnDeductions;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel getSIzelbl;
        private Guna.UI.WinForms.GunaPanel currEmpPanel;
        private System.Windows.Forms.Timer getWHtimer;
    }
}