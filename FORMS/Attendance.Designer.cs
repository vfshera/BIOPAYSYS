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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendance));
            this.attendanceListDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.datePickSearch = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtBxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.attendanceListDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // attendanceListDGV
            // 
            this.attendanceListDGV.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.attendanceListDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.attendanceListDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.attendanceListDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.attendanceListDGV.BackgroundColor = System.Drawing.Color.White;
            this.attendanceListDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.attendanceListDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.attendanceListDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.attendanceListDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.attendanceListDGV.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.attendanceListDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.attendanceListDGV.EnableHeadersVisualStyles = false;
            this.attendanceListDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.attendanceListDGV.Location = new System.Drawing.Point(12, 69);
            this.attendanceListDGV.Name = "attendanceListDGV";
            this.attendanceListDGV.RowHeadersVisible = false;
            this.attendanceListDGV.RowHeadersWidth = 51;
            this.attendanceListDGV.RowTemplate.Height = 40;
            this.attendanceListDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.attendanceListDGV.Size = new System.Drawing.Size(1055, 598);
            this.attendanceListDGV.TabIndex = 0;
            this.attendanceListDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.attendanceListDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.attendanceListDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.attendanceListDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.attendanceListDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.attendanceListDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.attendanceListDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.attendanceListDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.attendanceListDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.attendanceListDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.attendanceListDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.attendanceListDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.attendanceListDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.attendanceListDGV.ThemeStyle.HeaderStyle.Height = 40;
            this.attendanceListDGV.ThemeStyle.ReadOnly = false;
            this.attendanceListDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.attendanceListDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.attendanceListDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.attendanceListDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.attendanceListDGV.ThemeStyle.RowsStyle.Height = 40;
            this.attendanceListDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.attendanceListDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.attendanceListDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.attendanceListDGV_CellContentClick);
            // 
            // datePickSearch
            // 
            this.datePickSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datePickSearch.CheckedState.Parent = this.datePickSearch;
            this.datePickSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickSearch.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datePickSearch.HoverState.Parent = this.datePickSearch;
            this.datePickSearch.Location = new System.Drawing.Point(664, 6);
            this.datePickSearch.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datePickSearch.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datePickSearch.Name = "datePickSearch";
            this.datePickSearch.ShadowDecoration.Parent = this.datePickSearch;
            this.datePickSearch.Size = new System.Drawing.Size(405, 57);
            this.datePickSearch.TabIndex = 1;
            this.datePickSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.datePickSearch.Value = new System.DateTime(2020, 11, 11, 2, 26, 23, 388);
            this.datePickSearch.ValueChanged += new System.EventHandler(this.datePickSearch_ValueChanged);
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
            this.txtBxSearch.Location = new System.Drawing.Point(12, 8);
            this.txtBxSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtBxSearch.Name = "txtBxSearch";
            this.txtBxSearch.Padding = new System.Windows.Forms.Padding(17, 0, 11, 0);
            this.txtBxSearch.PasswordChar = '\0';
            this.txtBxSearch.PlaceholderText = "Search . . . .";
            this.txtBxSearch.SelectedText = "";
            this.txtBxSearch.ShadowDecoration.Parent = this.txtBxSearch;
            this.txtBxSearch.Size = new System.Drawing.Size(552, 52);
            this.txtBxSearch.TabIndex = 5;
            this.txtBxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxSearch_KeyPress);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 25;
            this.guna2Elipse2.TargetControl = this.datePickSearch;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 25;
            this.guna2Elipse3.TargetControl = this.attendanceListDGV;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(453, 262);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 90;
            this.guna2Elipse4.TargetControl = this.pictureBox1;
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1078, 679);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBxSearch);
            this.Controls.Add(this.datePickSearch);
            this.Controls.Add(this.attendanceListDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Attendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.Attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.attendanceListDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView attendanceListDGV;
        private Guna.UI2.WinForms.Guna2DateTimePicker datePickSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtBxSearch;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
    }
}