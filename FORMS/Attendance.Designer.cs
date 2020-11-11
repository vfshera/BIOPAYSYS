namespace BiometricPayroll.FORMS
{
    partial class Attendance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.attendanceListDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.datePickSearch = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtBxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceListDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // attendanceListDGV
            // 
            this.attendanceListDGV.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.attendanceListDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.attendanceListDGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.attendanceListDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.attendanceListDGV.BackgroundColor = System.Drawing.Color.White;
            this.attendanceListDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.attendanceListDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.attendanceListDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.attendanceListDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.attendanceListDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.attendanceListDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.attendanceListDGV.EnableHeadersVisualStyles = false;
            this.attendanceListDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.attendanceListDGV.Location = new System.Drawing.Point(6, 60);
            this.attendanceListDGV.Name = "attendanceListDGV";
            this.attendanceListDGV.RowHeadersVisible = false;
            this.attendanceListDGV.RowHeadersWidth = 51;
            this.attendanceListDGV.RowTemplate.Height = 24;
            this.attendanceListDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.attendanceListDGV.Size = new System.Drawing.Size(1067, 613);
            this.attendanceListDGV.TabIndex = 0;
            this.attendanceListDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.attendanceListDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.attendanceListDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.attendanceListDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.attendanceListDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.attendanceListDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.attendanceListDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.attendanceListDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.attendanceListDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.attendanceListDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.attendanceListDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.attendanceListDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.attendanceListDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attendanceListDGV.ThemeStyle.HeaderStyle.Height = 4;
            this.attendanceListDGV.ThemeStyle.ReadOnly = false;
            this.attendanceListDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.attendanceListDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.attendanceListDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.attendanceListDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.attendanceListDGV.ThemeStyle.RowsStyle.Height = 24;
            this.attendanceListDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.attendanceListDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // datePickSearch
            // 
            this.datePickSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datePickSearch.CheckedState.Parent = this.datePickSearch;
            this.datePickSearch.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datePickSearch.HoverState.Parent = this.datePickSearch;
            this.datePickSearch.Location = new System.Drawing.Point(769, 12);
            this.datePickSearch.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datePickSearch.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datePickSearch.Name = "datePickSearch";
            this.datePickSearch.ShadowDecoration.Parent = this.datePickSearch;
            this.datePickSearch.Size = new System.Drawing.Size(297, 36);
            this.datePickSearch.TabIndex = 1;
            this.datePickSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.datePickSearch.Value = new System.DateTime(2020, 11, 11, 2, 26, 23, 388);
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
            this.txtBxSearch.Location = new System.Drawing.Point(13, 8);
            this.txtBxSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtBxSearch.Name = "txtBxSearch";
            this.txtBxSearch.Padding = new System.Windows.Forms.Padding(17, 0, 11, 0);
            this.txtBxSearch.PasswordChar = '\0';
            this.txtBxSearch.PlaceholderText = "Search . . . .";
            this.txtBxSearch.SelectedText = "";
            this.txtBxSearch.ShadowDecoration.Parent = this.txtBxSearch;
            this.txtBxSearch.Size = new System.Drawing.Size(415, 43);
            this.txtBxSearch.TabIndex = 5;
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 679);
            this.Controls.Add(this.txtBxSearch);
            this.Controls.Add(this.datePickSearch);
            this.Controls.Add(this.attendanceListDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Attendance";
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.Attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.attendanceListDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView attendanceListDGV;
        private Guna.UI2.WinForms.Guna2DateTimePicker datePickSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtBxSearch;
    }
}