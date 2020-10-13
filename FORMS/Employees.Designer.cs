namespace BiometricPayroll.FORMS
{
    partial class Employees
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddEmp = new Guna.UI2.WinForms.Guna2Button();
            this.empContainerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.showAllEmployees = new Guna.UI2.WinForms.Guna2Button();
            this.searchPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.txtBxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.searchElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnEditRow = new Guna.UI2.WinForms.Guna2Button();
            this.searchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "EMPLOYEES";
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddEmp.BorderRadius = 2;
            this.btnAddEmp.CheckedState.Parent = this.btnAddEmp;
            this.btnAddEmp.CustomImages.Parent = this.btnAddEmp;
            this.btnAddEmp.FillColor = System.Drawing.Color.White;
            this.btnAddEmp.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnAddEmp.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddEmp.HoverState.Parent = this.btnAddEmp;
            this.btnAddEmp.Location = new System.Drawing.Point(996, 6);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.ShadowDecoration.Parent = this.btnAddEmp;
            this.btnAddEmp.Size = new System.Drawing.Size(89, 40);
            this.btnAddEmp.TabIndex = 2;
            this.btnAddEmp.Text = "ADD";
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // empContainerPanel
            // 
            this.empContainerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empContainerPanel.BackColor = System.Drawing.Color.Transparent;
            this.empContainerPanel.BorderColor = System.Drawing.Color.White;
            this.empContainerPanel.BorderRadius = 2;
            this.empContainerPanel.FillColor = System.Drawing.Color.White;
            this.empContainerPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.empContainerPanel.Location = new System.Drawing.Point(12, 57);
            this.empContainerPanel.MinimumSize = new System.Drawing.Size(1075, 664);
            this.empContainerPanel.Name = "empContainerPanel";
            this.empContainerPanel.ShadowDecoration.Depth = 2;
            this.empContainerPanel.ShadowDecoration.Enabled = true;
            this.empContainerPanel.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.empContainerPanel.ShadowDecoration.Parent = this.empContainerPanel;
            this.empContainerPanel.Size = new System.Drawing.Size(1075, 664);
            this.empContainerPanel.TabIndex = 3;
            // 
            // showAllEmployees
            // 
            this.showAllEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showAllEmployees.BorderColor = System.Drawing.Color.Transparent;
            this.showAllEmployees.BorderRadius = 2;
            this.showAllEmployees.CheckedState.Parent = this.showAllEmployees;
            this.showAllEmployees.CustomImages.Parent = this.showAllEmployees;
            this.showAllEmployees.FillColor = System.Drawing.Color.White;
            this.showAllEmployees.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllEmployees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.showAllEmployees.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.showAllEmployees.HoverState.FillColor = System.Drawing.Color.White;
            this.showAllEmployees.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.showAllEmployees.HoverState.Parent = this.showAllEmployees;
            this.showAllEmployees.Location = new System.Drawing.Point(885, 6);
            this.showAllEmployees.Name = "showAllEmployees";
            this.showAllEmployees.ShadowDecoration.Parent = this.showAllEmployees;
            this.showAllEmployees.Size = new System.Drawing.Size(89, 40);
            this.showAllEmployees.TabIndex = 2;
            this.showAllEmployees.Text = "ALL";
            this.showAllEmployees.Click += new System.EventHandler(this.showAllEmployees_Click);
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.White;
            this.searchPanel.BorderRadius = 15;
            this.searchPanel.BorderThickness = 1;
            this.searchPanel.Controls.Add(this.txtBxSearch);
            this.searchPanel.Location = new System.Drawing.Point(14, 6);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.ShadowDecoration.Parent = this.searchPanel;
            this.searchPanel.Size = new System.Drawing.Size(437, 43);
            this.searchPanel.TabIndex = 0;
            // 
            // txtBxSearch
            // 
            this.txtBxSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtBxSearch.BorderColor = System.Drawing.Color.Transparent;
            this.txtBxSearch.BorderThickness = 0;
            this.txtBxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBxSearch.DefaultText = "";
            this.txtBxSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBxSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBxSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBxSearch.DisabledState.Parent = this.txtBxSearch;
            this.txtBxSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBxSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBxSearch.FocusedState.Parent = this.txtBxSearch;
            this.txtBxSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtBxSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBxSearch.HoverState.Parent = this.txtBxSearch;
            this.txtBxSearch.Location = new System.Drawing.Point(25, 4);
            this.txtBxSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBxSearch.Name = "txtBxSearch";
            this.txtBxSearch.PasswordChar = '\0';
            this.txtBxSearch.PlaceholderText = "";
            this.txtBxSearch.SelectedText = "";
            this.txtBxSearch.ShadowDecoration.Parent = this.txtBxSearch;
            this.txtBxSearch.Size = new System.Drawing.Size(342, 33);
            this.txtBxSearch.TabIndex = 0;
            // 
            // searchElipse
            // 
            this.searchElipse.BorderRadius = 40;
            this.searchElipse.TargetControl = this.searchPanel;
            // 
            // btnEditRow
            // 
            this.btnEditRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditRow.BorderColor = System.Drawing.Color.Transparent;
            this.btnEditRow.BorderRadius = 2;
            this.btnEditRow.CheckedState.Parent = this.btnEditRow;
            this.btnEditRow.CustomImages.Parent = this.btnEditRow;
            this.btnEditRow.FillColor = System.Drawing.Color.White;
            this.btnEditRow.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnEditRow.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnEditRow.HoverState.FillColor = System.Drawing.Color.White;
            this.btnEditRow.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnEditRow.HoverState.Parent = this.btnEditRow;
            this.btnEditRow.Location = new System.Drawing.Point(746, 6);
            this.btnEditRow.Name = "btnEditRow";
            this.btnEditRow.ShadowDecoration.Parent = this.btnEditRow;
            this.btnEditRow.Size = new System.Drawing.Size(89, 40);
            this.btnEditRow.TabIndex = 2;
            this.btnEditRow.Text = "EDIT";
            this.btnEditRow.Click += new System.EventHandler(this.btnEditRow_Click);
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1096, 726);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.empContainerPanel);
            this.Controls.Add(this.btnEditRow);
            this.Controls.Add(this.showAllEmployees);
            this.Controls.Add(this.btnAddEmp);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1096, 726);
            this.Name = "Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            this.searchPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnAddEmp;
        private Guna.UI2.WinForms.Guna2Panel empContainerPanel;
        private Guna.UI2.WinForms.Guna2Button showAllEmployees;
        private Guna.UI2.WinForms.Guna2Panel searchPanel;
        private Guna.UI2.WinForms.Guna2Elipse searchElipse;
        private Guna.UI2.WinForms.Guna2TextBox txtBxSearch;
        private Guna.UI2.WinForms.Guna2Button btnEditRow;
    }
}