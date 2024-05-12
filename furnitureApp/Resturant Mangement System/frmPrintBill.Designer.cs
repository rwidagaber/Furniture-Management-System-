namespace Resturant_Mangement_System
{
    partial class frmPrintBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintBill));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Maxmizebtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Maxmizebtn);
            this.panel1.Controls.Add(this.CloseBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 81);
            this.panel1.TabIndex = 2;
            // 
            // Maxmizebtn
            // 
            this.Maxmizebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maxmizebtn.BackColor = System.Drawing.Color.Transparent;
            this.Maxmizebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Maxmizebtn.BackgroundImage")));
            this.Maxmizebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Maxmizebtn.FlatAppearance.BorderSize = 0;
            this.Maxmizebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Maxmizebtn.Location = new System.Drawing.Point(510, 10);
            this.Maxmizebtn.Margin = new System.Windows.Forms.Padding(2);
            this.Maxmizebtn.Name = "Maxmizebtn";
            this.Maxmizebtn.Size = new System.Drawing.Size(30, 32);
            this.Maxmizebtn.TabIndex = 5;
            this.Maxmizebtn.UseVisualStyleBackColor = false;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseBtn.BackgroundImage")));
            this.CloseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Location = new System.Drawing.Point(564, 10);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(30, 32);
            this.CloseBtn.TabIndex = 3;
            this.CloseBtn.UseVisualStyleBackColor = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Resturant_Mangement_System.Reports.ReportBill.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 81);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(600, 285);
            this.reportViewer1.TabIndex = 3;
            // 
            // frmPrintBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPrintBill";
            this.Text = "frmPrintBill";
            this.Load += new System.EventHandler(this.frmPrintBill_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Maxmizebtn;
        private System.Windows.Forms.Button CloseBtn;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}