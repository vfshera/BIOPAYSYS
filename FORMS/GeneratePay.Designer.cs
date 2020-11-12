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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneratePay));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.empSidePanel = new Guna.UI.WinForms.GunaPanel();
            this.currEmpPanel = new Guna.UI.WinForms.GunaPanel();
            this.curEmpFN = new Guna.UI.WinForms.GunaLabel();
            this.lblPosition = new Guna.UI.WinForms.GunaLabel();
            this.curEmpGender = new Guna.UI.WinForms.GunaLabel();
            this.curEmpSalary = new Guna.UI.WinForms.GunaLabel();
            this.curEmpJoined = new Guna.UI.WinForms.GunaLabel();
            this.curEmpSurname = new Guna.UI.WinForms.GunaLabel();
            this.curEmpSN = new Guna.UI.WinForms.GunaLabel();
            this.curEmpNatID = new Guna.UI.WinForms.GunaLabel();
            this.empListGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.incomePanel = new Guna.UI.WinForms.GunaPanel();
            this.stateLeadlbl = new Guna.UI.WinForms.GunaLabel();
            this.btnAllowance = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnDeductions = new Guna.UI.WinForms.GunaAdvenceButton();
            this.DedAllGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
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
            this.empSidePanel.Size = new System.Drawing.Size(483, 787);
            this.empSidePanel.TabIndex = 0;
            // 
            // currEmpPanel
            // 
            this.currEmpPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currEmpPanel.BackColor = System.Drawing.Color.White;
            this.currEmpPanel.Controls.Add(this.curEmpFN);
            this.currEmpPanel.Controls.Add(this.lblPosition);
            this.currEmpPanel.Controls.Add(this.curEmpGender);
            this.currEmpPanel.Controls.Add(this.curEmpSalary);
            this.currEmpPanel.Controls.Add(this.curEmpJoined);
            this.currEmpPanel.Controls.Add(this.curEmpSurname);
            this.currEmpPanel.Controls.Add(this.curEmpSN);
            this.currEmpPanel.Controls.Add(this.curEmpNatID);
            this.currEmpPanel.Location = new System.Drawing.Point(7, 0);
            this.currEmpPanel.Name = "currEmpPanel";
            this.currEmpPanel.Size = new System.Drawing.Size(465, 194);
            this.currEmpPanel.TabIndex = 2;
            // 
            // curEmpFN
            // 
            this.curEmpFN.AutoSize = true;
            this.curEmpFN.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.curEmpFN.Location = new System.Drawing.Point(13, 20);
            this.curEmpFN.Name = "curEmpFN";
            this.curEmpFN.Size = new System.Drawing.Size(101, 28);
            this.curEmpFN.TabIndex = 1;
            this.curEmpFN.Text = "FirstName";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPosition.Location = new System.Drawing.Point(370, 139);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(82, 28);
            this.lblPosition.TabIndex = 1;
            this.lblPosition.Text = "Position";
            // 
            // curEmpGender
            // 
            this.curEmpGender.AutoSize = true;
            this.curEmpGender.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.curEmpGender.Location = new System.Drawing.Point(13, 77);
            this.curEmpGender.Name = "curEmpGender";
            this.curEmpGender.Size = new System.Drawing.Size(76, 28);
            this.curEmpGender.TabIndex = 1;
            this.curEmpGender.Text = "Gender";
            // 
            // curEmpSalary
            // 
            this.curEmpSalary.AutoSize = true;
            this.curEmpSalary.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.curEmpSalary.Location = new System.Drawing.Point(370, 80);
            this.curEmpSalary.Name = "curEmpSalary";
            this.curEmpSalary.Size = new System.Drawing.Size(65, 28);
            this.curEmpSalary.TabIndex = 1;
            this.curEmpSalary.Text = "Salary";
            // 
            // curEmpJoined
            // 
            this.curEmpJoined.AutoSize = true;
            this.curEmpJoined.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.curEmpJoined.Location = new System.Drawing.Point(13, 139);
            this.curEmpJoined.Name = "curEmpJoined";
            this.curEmpJoined.Size = new System.Drawing.Size(218, 28);
            this.curEmpJoined.TabIndex = 1;
            this.curEmpJoined.Text = "Joined On : 19-04-2020";
            // 
            // curEmpSurname
            // 
            this.curEmpSurname.AutoSize = true;
            this.curEmpSurname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.curEmpSurname.Location = new System.Drawing.Point(370, 20);
            this.curEmpSurname.Name = "curEmpSurname";
            this.curEmpSurname.Size = new System.Drawing.Size(89, 28);
            this.curEmpSurname.TabIndex = 1;
            this.curEmpSurname.Text = "Surname";
            // 
            // curEmpSN
            // 
            this.curEmpSN.AutoSize = true;
            this.curEmpSN.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.curEmpSN.Location = new System.Drawing.Point(188, 20);
            this.curEmpSN.Name = "curEmpSN";
            this.curEmpSN.Size = new System.Drawing.Size(129, 28);
            this.curEmpSN.TabIndex = 1;
            this.curEmpSN.Text = "SecondName";
            // 
            // curEmpNatID
            // 
            this.curEmpNatID.AutoSize = true;
            this.curEmpNatID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.curEmpNatID.Location = new System.Drawing.Point(188, 80);
            this.curEmpNatID.Name = "curEmpNatID";
            this.curEmpNatID.Size = new System.Drawing.Size(106, 28);
            this.curEmpNatID.TabIndex = 1;
            this.curEmpNatID.Text = "NationalID";
            // 
            // empListGV
            // 
            this.empListGV.AllowUserToAddRows = false;
            this.empListGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.empListGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.empListGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empListGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.empListGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.empListGV.BackgroundColor = System.Drawing.Color.White;
            this.empListGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.empListGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.empListGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.empListGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.empListGV.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.empListGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.empListGV.EnableHeadersVisualStyles = false;
            this.empListGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.empListGV.Location = new System.Drawing.Point(8, 224);
            this.empListGV.Name = "empListGV";
            this.empListGV.ReadOnly = true;
            this.empListGV.RowHeadersWidth = 51;
            this.empListGV.RowTemplate.Height = 40;
            this.empListGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.empListGV.Size = new System.Drawing.Size(465, 560);
            this.empListGV.TabIndex = 0;
            this.empListGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.empListGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.empListGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.empListGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.empListGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.empListGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.empListGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.empListGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.empListGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.empListGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.empListGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.empListGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.empListGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.empListGV.ThemeStyle.HeaderStyle.Height = 40;
            this.empListGV.ThemeStyle.ReadOnly = true;
            this.empListGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.empListGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.empListGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.empListGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.empListGV.ThemeStyle.RowsStyle.Height = 40;
            this.empListGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.empListGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.empListGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empListGV_CellClick);
            // 
            // incomePanel
            // 
            this.incomePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.incomePanel.BackColor = System.Drawing.Color.White;
            this.incomePanel.Controls.Add(this.stateLeadlbl);
            this.incomePanel.Controls.Add(this.btnAllowance);
            this.incomePanel.Controls.Add(this.btnDeductions);
            this.incomePanel.Controls.Add(this.DedAllGV);
            this.incomePanel.Location = new System.Drawing.Point(495, 27);
            this.incomePanel.Name = "incomePanel";
            this.incomePanel.Size = new System.Drawing.Size(774, 787);
            this.incomePanel.TabIndex = 1;
            // 
            // stateLeadlbl
            // 
            this.stateLeadlbl.AutoSize = true;
            this.stateLeadlbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.stateLeadlbl.Location = new System.Drawing.Point(11, 18);
            this.stateLeadlbl.Name = "stateLeadlbl";
            this.stateLeadlbl.Size = new System.Drawing.Size(182, 35);
            this.stateLeadlbl.TabIndex = 42;
            this.stateLeadlbl.Text = "ALLOWANCES";
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
            this.btnAllowance.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
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
            this.btnAllowance.Radius = 20;
            this.btnAllowance.Size = new System.Drawing.Size(160, 48);
            this.btnAllowance.TabIndex = 40;
            this.btnAllowance.Text = "ALLOWANCE";
            this.btnAllowance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAllowance.Click += new System.EventHandler(this.btnAllowance_Click);
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
            this.btnDeductions.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
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
            this.btnDeductions.Radius = 20;
            this.btnDeductions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDeductions.Size = new System.Drawing.Size(160, 48);
            this.btnDeductions.TabIndex = 41;
            this.btnDeductions.Text = "DEDUCTIONS";
            this.btnDeductions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDeductions.Click += new System.EventHandler(this.btnDeductions_Click);
            // 
            // DedAllGV
            // 
            this.DedAllGV.AllowUserToAddRows = false;
            this.DedAllGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.DedAllGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DedAllGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DedAllGV.BackgroundColor = System.Drawing.Color.White;
            this.DedAllGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DedAllGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DedAllGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DedAllGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DedAllGV.ColumnHeadersHeight = 40;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DedAllGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.DedAllGV.EnableHeadersVisualStyles = false;
            this.DedAllGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.DedAllGV.Location = new System.Drawing.Point(9, 69);
            this.DedAllGV.Name = "DedAllGV";
            this.DedAllGV.ReadOnly = true;
            this.DedAllGV.RowHeadersVisible = false;
            this.DedAllGV.RowHeadersWidth = 51;
            this.DedAllGV.RowTemplate.Height = 40;
            this.DedAllGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DedAllGV.Size = new System.Drawing.Size(753, 754);
            this.DedAllGV.TabIndex = 0;
            this.DedAllGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.DedAllGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.DedAllGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DedAllGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DedAllGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DedAllGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DedAllGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DedAllGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.DedAllGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.DedAllGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DedAllGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DedAllGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.DedAllGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DedAllGV.ThemeStyle.HeaderStyle.Height = 40;
            this.DedAllGV.ThemeStyle.ReadOnly = true;
            this.DedAllGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DedAllGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DedAllGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DedAllGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DedAllGV.ThemeStyle.RowsStyle.Height = 40;
            this.DedAllGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.DedAllGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this.currEmpPanel;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 15;
            this.guna2Elipse2.TargetControl = this.incomePanel;
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
        private Guna.UI.WinForms.GunaLabel curEmpSurname;
        private Guna.UI.WinForms.GunaLabel curEmpSN;
        private Guna.UI.WinForms.GunaLabel curEmpFN;
        private Guna.UI.WinForms.GunaLabel curEmpSalary;
        private Guna.UI.WinForms.GunaLabel curEmpNatID;
        private Guna.UI.WinForms.GunaLabel curEmpGender;
        private Guna.UI.WinForms.GunaLabel curEmpJoined;
        private Guna.UI.WinForms.GunaPanel incomePanel;
        private Guna.UI2.WinForms.Guna2DataGridView DedAllGV;
        private Guna.UI.WinForms.GunaAdvenceButton btnAllowance;
        private Guna.UI.WinForms.GunaAdvenceButton btnDeductions;
        private Guna.UI.WinForms.GunaLabel stateLeadlbl;
        private Guna.UI.WinForms.GunaLabel lblPosition;
        private Guna.UI.WinForms.GunaPanel currEmpPanel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
    }
}