namespace BiometricPayroll.FORMS
{
    partial class EmpAllowances
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.allowancesDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.addAllowanceBtn = new Guna.UI2.WinForms.Guna2Button();
            this.dropMethod = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.txtBxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEditAllowance = new Guna.UI2.WinForms.Guna2Button();
            this.deleteAllowanceBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.allowancesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // allowancesDGV
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.allowancesDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.allowancesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.allowancesDGV.BackgroundColor = System.Drawing.Color.White;
            this.allowancesDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allowancesDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.allowancesDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allowancesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.allowancesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.allowancesDGV.DefaultCellStyle = dataGridViewCellStyle15;
            this.allowancesDGV.EnableHeadersVisualStyles = false;
            this.allowancesDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.allowancesDGV.Location = new System.Drawing.Point(6, 135);
            this.allowancesDGV.Name = "allowancesDGV";
            this.allowancesDGV.RowHeadersWidth = 51;
            this.allowancesDGV.RowTemplate.Height = 24;
            this.allowancesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allowancesDGV.Size = new System.Drawing.Size(1095, 669);
            this.allowancesDGV.TabIndex = 0;
            this.allowancesDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.allowancesDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.allowancesDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.allowancesDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.allowancesDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.allowancesDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.allowancesDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.allowancesDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.allowancesDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.allowancesDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.allowancesDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.allowancesDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.allowancesDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allowancesDGV.ThemeStyle.HeaderStyle.Height = 4;
            this.allowancesDGV.ThemeStyle.ReadOnly = false;
            this.allowancesDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.allowancesDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.allowancesDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.allowancesDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.allowancesDGV.ThemeStyle.RowsStyle.Height = 24;
            this.allowancesDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.allowancesDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.allowancesDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.allowancesDGV_CellClick);
            // 
            // txtTitle
            // 
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.DefaultText = "";
            this.txtTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitle.DisabledState.Parent = this.txtTitle;
            this.txtTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitle.FocusedState.Parent = this.txtTitle;
            this.txtTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitle.HoverState.Parent = this.txtTitle;
            this.txtTitle.Location = new System.Drawing.Point(13, 13);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PasswordChar = '\0';
            this.txtTitle.PlaceholderText = "Enter Title ...";
            this.txtTitle.SelectedText = "";
            this.txtTitle.ShadowDecoration.Parent = this.txtTitle;
            this.txtTitle.Size = new System.Drawing.Size(377, 44);
            this.txtTitle.TabIndex = 1;
            // 
            // txtAmount
            // 
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.DefaultText = "";
            this.txtAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount.DisabledState.Parent = this.txtAmount;
            this.txtAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmount.FocusedState.Parent = this.txtAmount;
            this.txtAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmount.HoverState.Parent = this.txtAmount;
            this.txtAmount.Location = new System.Drawing.Point(429, 12);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.PlaceholderText = "Enter Amount ...";
            this.txtAmount.SelectedText = "";
            this.txtAmount.ShadowDecoration.Parent = this.txtAmount;
            this.txtAmount.Size = new System.Drawing.Size(218, 44);
            this.txtAmount.TabIndex = 1;
            // 
            // addAllowanceBtn
            // 
            this.addAllowanceBtn.CheckedState.Parent = this.addAllowanceBtn;
            this.addAllowanceBtn.CustomImages.Parent = this.addAllowanceBtn;
            this.addAllowanceBtn.FillColor = System.Drawing.Color.Green;
            this.addAllowanceBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.addAllowanceBtn.ForeColor = System.Drawing.Color.White;
            this.addAllowanceBtn.HoverState.Parent = this.addAllowanceBtn;
            this.addAllowanceBtn.Location = new System.Drawing.Point(960, 12);
            this.addAllowanceBtn.Name = "addAllowanceBtn";
            this.addAllowanceBtn.ShadowDecoration.Parent = this.addAllowanceBtn;
            this.addAllowanceBtn.Size = new System.Drawing.Size(135, 45);
            this.addAllowanceBtn.TabIndex = 2;
            this.addAllowanceBtn.Text = "ADD";
            this.addAllowanceBtn.Click += new System.EventHandler(this.addAllowanceBtn_Click);
            // 
            // dropMethod
            // 
            this.dropMethod.BackColor = System.Drawing.Color.Transparent;
            this.dropMethod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dropMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropMethod.FocusedColor = System.Drawing.Color.Empty;
            this.dropMethod.FocusedState.Parent = this.dropMethod;
            this.dropMethod.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dropMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.dropMethod.FormattingEnabled = true;
            this.dropMethod.HoverState.Parent = this.dropMethod;
            this.dropMethod.ItemHeight = 30;
            this.dropMethod.Items.AddRange(new object[] {
            "AMOUNT",
            "PERCENTAGE"});
            this.dropMethod.ItemsAppearance.Parent = this.dropMethod;
            this.dropMethod.Location = new System.Drawing.Point(700, 13);
            this.dropMethod.Name = "dropMethod";
            this.dropMethod.ShadowDecoration.Parent = this.dropMethod;
            this.dropMethod.Size = new System.Drawing.Size(218, 36);
            this.dropMethod.TabIndex = 3;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gunaPanel1.Location = new System.Drawing.Point(9, 65);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1090, 3);
            this.gunaPanel1.TabIndex = 4;
            // 
            // txtBxSearch
            // 
            this.txtBxSearch.BorderRadius = 15;
            this.txtBxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBxSearch.DefaultText = "";
            this.txtBxSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBxSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBxSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBxSearch.DisabledState.Parent = this.txtBxSearch;
            this.txtBxSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBxSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBxSearch.FocusedState.Parent = this.txtBxSearch;
            this.txtBxSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBxSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBxSearch.HoverState.Parent = this.txtBxSearch;
            this.txtBxSearch.Location = new System.Drawing.Point(13, 80);
            this.txtBxSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtBxSearch.Name = "txtBxSearch";
            this.txtBxSearch.Padding = new System.Windows.Forms.Padding(17, 0, 11, 0);
            this.txtBxSearch.PasswordChar = '\0';
            this.txtBxSearch.PlaceholderText = "Search . . . .";
            this.txtBxSearch.SelectedText = "";
            this.txtBxSearch.ShadowDecoration.Parent = this.txtBxSearch;
            this.txtBxSearch.Size = new System.Drawing.Size(641, 43);
            this.txtBxSearch.TabIndex = 5;
            this.txtBxSearch.TextChanged += new System.EventHandler(this.txtBxSearch_TextChanged);
            // 
            // btnEditAllowance
            // 
            this.btnEditAllowance.CheckedState.Parent = this.btnEditAllowance;
            this.btnEditAllowance.CustomImages.Parent = this.btnEditAllowance;
            this.btnEditAllowance.Enabled = false;
            this.btnEditAllowance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditAllowance.ForeColor = System.Drawing.Color.White;
            this.btnEditAllowance.HoverState.Parent = this.btnEditAllowance;
            this.btnEditAllowance.Location = new System.Drawing.Point(700, 80);
            this.btnEditAllowance.Name = "btnEditAllowance";
            this.btnEditAllowance.ShadowDecoration.Parent = this.btnEditAllowance;
            this.btnEditAllowance.Size = new System.Drawing.Size(135, 45);
            this.btnEditAllowance.TabIndex = 2;
            this.btnEditAllowance.Text = "UPDATE";
            this.btnEditAllowance.Visible = false;
            this.btnEditAllowance.Click += new System.EventHandler(this.btnEditAllowance_Click);
            // 
            // deleteAllowanceBtn
            // 
            this.deleteAllowanceBtn.CheckedState.Parent = this.deleteAllowanceBtn;
            this.deleteAllowanceBtn.CustomImages.Parent = this.deleteAllowanceBtn;
            this.deleteAllowanceBtn.Enabled = false;
            this.deleteAllowanceBtn.FillColor = System.Drawing.Color.Red;
            this.deleteAllowanceBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.deleteAllowanceBtn.ForeColor = System.Drawing.Color.White;
            this.deleteAllowanceBtn.HoverState.Parent = this.deleteAllowanceBtn;
            this.deleteAllowanceBtn.Location = new System.Drawing.Point(960, 80);
            this.deleteAllowanceBtn.Name = "deleteAllowanceBtn";
            this.deleteAllowanceBtn.ShadowDecoration.Parent = this.deleteAllowanceBtn;
            this.deleteAllowanceBtn.Size = new System.Drawing.Size(135, 45);
            this.deleteAllowanceBtn.TabIndex = 2;
            this.deleteAllowanceBtn.Text = "DELETE";
            this.deleteAllowanceBtn.Visible = false;
            this.deleteAllowanceBtn.Click += new System.EventHandler(this.deleteAllowanceBtn_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(841, 80);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(77, 42);
            this.guna2ControlBox1.TabIndex = 6;
            // 
            // EmpAllowances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1108, 811);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.txtBxSearch);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.dropMethod);
            this.Controls.Add(this.deleteAllowanceBtn);
            this.Controls.Add(this.btnEditAllowance);
            this.Controls.Add(this.addAllowanceBtn);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.allowancesDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmpAllowances";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmpAllowances";
            this.Load += new System.EventHandler(this.EmpAllowances_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allowancesDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView allowancesDGV;
        private Guna.UI2.WinForms.Guna2TextBox txtTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtAmount;
        private Guna.UI2.WinForms.Guna2Button addAllowanceBtn;
        private Guna.UI2.WinForms.Guna2ComboBox dropMethod;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI2.WinForms.Guna2TextBox txtBxSearch;
        private Guna.UI2.WinForms.Guna2Button btnEditAllowance;
        private Guna.UI2.WinForms.Guna2Button deleteAllowanceBtn;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}