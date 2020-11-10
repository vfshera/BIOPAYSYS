namespace BiometricPayroll.FORMS
{
    partial class Users
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.usersContainerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.usersTableGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnEditRow = new Guna.UI2.WinForms.Guna2Button();
            this.usersContainerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersTableGrid)).BeginInit();
            this.SuspendLayout();
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
            this.txtBxSearch.Location = new System.Drawing.Point(12, 13);
            this.txtBxSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtBxSearch.Name = "txtBxSearch";
            this.txtBxSearch.Padding = new System.Windows.Forms.Padding(17, 0, 11, 0);
            this.txtBxSearch.PasswordChar = '\0';
            this.txtBxSearch.PlaceholderText = "Search . . . .";
            this.txtBxSearch.SelectedText = "";
            this.txtBxSearch.ShadowDecoration.Parent = this.txtBxSearch;
            this.txtBxSearch.Size = new System.Drawing.Size(415, 43);
            this.txtBxSearch.TabIndex = 8;
            // 
            // usersContainerPanel
            // 
            this.usersContainerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usersContainerPanel.BackColor = System.Drawing.Color.Transparent;
            this.usersContainerPanel.BorderColor = System.Drawing.Color.White;
            this.usersContainerPanel.BorderRadius = 2;
            this.usersContainerPanel.Controls.Add(this.usersTableGrid);
            this.usersContainerPanel.FillColor = System.Drawing.Color.White;
            this.usersContainerPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usersContainerPanel.Location = new System.Drawing.Point(11, 65);
            this.usersContainerPanel.MinimumSize = new System.Drawing.Size(1075, 649);
            this.usersContainerPanel.Name = "usersContainerPanel";
            this.usersContainerPanel.ShadowDecoration.Depth = 2;
            this.usersContainerPanel.ShadowDecoration.Enabled = true;
            this.usersContainerPanel.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.usersContainerPanel.ShadowDecoration.Parent = this.usersContainerPanel;
            this.usersContainerPanel.Size = new System.Drawing.Size(1075, 649);
            this.usersContainerPanel.TabIndex = 7;
            // 
            // usersTableGrid
            // 
            this.usersTableGrid.AllowUserToAddRows = false;
            this.usersTableGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.usersTableGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.usersTableGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersTableGrid.BackgroundColor = System.Drawing.Color.White;
            this.usersTableGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usersTableGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.usersTableGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersTableGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.usersTableGrid.ColumnHeadersHeight = 40;
            this.usersTableGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usersTableGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.usersTableGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersTableGrid.EnableHeadersVisualStyles = false;
            this.usersTableGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.usersTableGrid.Location = new System.Drawing.Point(0, 0);
            this.usersTableGrid.Name = "usersTableGrid";
            this.usersTableGrid.ReadOnly = true;
            this.usersTableGrid.RowHeadersVisible = false;
            this.usersTableGrid.RowHeadersWidth = 51;
            this.usersTableGrid.RowTemplate.Height = 24;
            this.usersTableGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersTableGrid.Size = new System.Drawing.Size(1075, 649);
            this.usersTableGrid.TabIndex = 1;
            this.usersTableGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.usersTableGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.usersTableGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.usersTableGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.usersTableGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.usersTableGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.usersTableGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.usersTableGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.usersTableGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.usersTableGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.usersTableGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.usersTableGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.usersTableGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.usersTableGrid.ThemeStyle.HeaderStyle.Height = 40;
            this.usersTableGrid.ThemeStyle.ReadOnly = true;
            this.usersTableGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.usersTableGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.usersTableGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.usersTableGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usersTableGrid.ThemeStyle.RowsStyle.Height = 24;
            this.usersTableGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.usersTableGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.usersTableGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersTableGrid_CellClick);
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
            this.btnEditRow.Location = new System.Drawing.Point(995, 13);
            this.btnEditRow.Name = "btnEditRow";
            this.btnEditRow.ShadowDecoration.Parent = this.btnEditRow;
            this.btnEditRow.Size = new System.Drawing.Size(89, 40);
            this.btnEditRow.TabIndex = 5;
            this.btnEditRow.Text = "EDIT";
            this.btnEditRow.Click += new System.EventHandler(this.btnEditRow_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 726);
            this.Controls.Add(this.txtBxSearch);
            this.Controls.Add(this.usersContainerPanel);
            this.Controls.Add(this.btnEditRow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.usersContainerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersTableGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtBxSearch;
        private Guna.UI2.WinForms.Guna2Panel usersContainerPanel;
        private Guna.UI2.WinForms.Guna2Button btnEditRow;
        private Guna.UI2.WinForms.Guna2DataGridView usersTableGrid;
    }
}