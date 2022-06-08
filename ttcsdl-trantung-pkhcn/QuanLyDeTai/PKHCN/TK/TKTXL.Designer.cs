namespace QuanLyDeTai.PKHCN.TK
{
    partial class TKTXL
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tenKhoa = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Nam = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TK = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TKXL = new Guna.UI2.WinForms.Guna2DataGridView();
            this.xuatKQ = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TKXL)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.xuatKQ);
            this.panel1.Controls.Add(this.guna2HtmlLabel2);
            this.panel1.Controls.Add(this.guna2HtmlLabel1);
            this.panel1.Controls.Add(this.tenKhoa);
            this.panel1.Controls.Add(this.Nam);
            this.panel1.Controls.Add(this.TK);
            this.panel1.Controls.Add(this.TKXL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1384, 547);
            this.panel1.TabIndex = 0;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(385, 34);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(60, 21);
            this.guna2HtmlLabel2.TabIndex = 5;
            this.guna2HtmlLabel2.Text = "Tên khoa";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(41, 34);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(33, 21);
            this.guna2HtmlLabel1.TabIndex = 4;
            this.guna2HtmlLabel1.Text = "Năm";
            // 
            // tenKhoa
            // 
            this.tenKhoa.BackColor = System.Drawing.Color.Transparent;
            this.tenKhoa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.tenKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tenKhoa.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tenKhoa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tenKhoa.FocusedState.Parent = this.tenKhoa;
            this.tenKhoa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tenKhoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.tenKhoa.HoverState.Parent = this.tenKhoa;
            this.tenKhoa.ItemHeight = 30;
            this.tenKhoa.ItemsAppearance.Parent = this.tenKhoa;
            this.tenKhoa.Location = new System.Drawing.Point(451, 25);
            this.tenKhoa.Name = "tenKhoa";
            this.tenKhoa.ShadowDecoration.Parent = this.tenKhoa;
            this.tenKhoa.Size = new System.Drawing.Size(169, 36);
            this.tenKhoa.TabIndex = 3;
            this.tenKhoa.SelectedIndexChanged += new System.EventHandler(this.tenKhoa_SelectedIndexChanged);
            // 
            // Nam
            // 
            this.Nam.BackColor = System.Drawing.Color.Transparent;
            this.Nam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Nam.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Nam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Nam.FocusedState.Parent = this.Nam;
            this.Nam.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Nam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Nam.HoverState.Parent = this.Nam;
            this.Nam.ItemHeight = 30;
            this.Nam.ItemsAppearance.Parent = this.Nam;
            this.Nam.Location = new System.Drawing.Point(80, 25);
            this.Nam.Name = "Nam";
            this.Nam.ShadowDecoration.Parent = this.Nam;
            this.Nam.Size = new System.Drawing.Size(169, 36);
            this.Nam.TabIndex = 2;
            this.Nam.SelectedIndexChanged += new System.EventHandler(this.Nam_SelectedIndexChanged);
            // 
            // TK
            // 
            chartArea2.Name = "ChartArea1";
            this.TK.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.TK.Legends.Add(legend2);
            this.TK.Location = new System.Drawing.Point(795, 125);
            this.TK.Name = "TK";
            this.TK.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.TK.Series.Add(series2);
            this.TK.Size = new System.Drawing.Size(526, 396);
            this.TK.TabIndex = 1;
            this.TK.Text = "chart1";
            // 
            // TKXL
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.TKXL.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.TKXL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TKXL.BackgroundColor = System.Drawing.Color.White;
            this.TKXL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TKXL.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TKXL.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TKXL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.TKXL.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TKXL.DefaultCellStyle = dataGridViewCellStyle6;
            this.TKXL.EnableHeadersVisualStyles = false;
            this.TKXL.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TKXL.Location = new System.Drawing.Point(31, 125);
            this.TKXL.Name = "TKXL";
            this.TKXL.RowHeadersVisible = false;
            this.TKXL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TKXL.Size = new System.Drawing.Size(589, 389);
            this.TKXL.TabIndex = 0;
            this.TKXL.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.TKXL.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.TKXL.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.TKXL.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.TKXL.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.TKXL.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.TKXL.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TKXL.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TKXL.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TKXL.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.TKXL.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.TKXL.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.TKXL.ThemeStyle.HeaderStyle.Height = 30;
            this.TKXL.ThemeStyle.ReadOnly = false;
            this.TKXL.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.TKXL.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TKXL.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.TKXL.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TKXL.ThemeStyle.RowsStyle.Height = 22;
            this.TKXL.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TKXL.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // xuatKQ
            // 
            this.xuatKQ.CheckedState.Parent = this.xuatKQ;
            this.xuatKQ.CustomImages.Parent = this.xuatKQ;
            this.xuatKQ.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.xuatKQ.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.xuatKQ.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.xuatKQ.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.xuatKQ.DisabledState.Parent = this.xuatKQ;
            this.xuatKQ.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.xuatKQ.ForeColor = System.Drawing.Color.White;
            this.xuatKQ.HoverState.Parent = this.xuatKQ;
            this.xuatKQ.Location = new System.Drawing.Point(795, 25);
            this.xuatKQ.Name = "xuatKQ";
            this.xuatKQ.ShadowDecoration.Parent = this.xuatKQ;
            this.xuatKQ.Size = new System.Drawing.Size(110, 36);
            this.xuatKQ.TabIndex = 6;
            this.xuatKQ.Text = "Xuất kết quả";
            this.xuatKQ.Click += new System.EventHandler(this.xuatKQ_Click);
            // 
            // TKTXL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 581);
            this.Controls.Add(this.panel1);
            this.Name = "TKTXL";
            this.Text = "TKTXL";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TKXL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView TKXL;
        private System.Windows.Forms.DataVisualization.Charting.Chart TK;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox tenKhoa;
        private Guna.UI2.WinForms.Guna2ComboBox Nam;
        private Guna.UI2.WinForms.Guna2Button xuatKQ;
    }
}