namespace QuanLyDeTai.PKHCN.TK
{
    partial class XuatKQ
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
            this.xuat = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // xuat
            // 
            this.xuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuat.Location = new System.Drawing.Point(0, 0);
            this.xuat.Name = "xuat";
            this.xuat.ServerReport.BearerToken = null;
            this.xuat.Size = new System.Drawing.Size(834, 541);
            this.xuat.TabIndex = 0;
            // 
            // XuatKQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 541);
            this.Controls.Add(this.xuat);
            this.Name = "XuatKQ";
            this.Text = "XuatKQ";
            this.Load += new System.EventHandler(this.XuatKQ_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer xuat;
    }
}