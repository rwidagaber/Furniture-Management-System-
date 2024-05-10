
namespace Resturant_Mangement_System.Model
{
    partial class UcProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcProduct));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.IbName = new System.Windows.Forms.Label();
            this.txtImg = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtImg);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 153);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.IbName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 40);
            this.panel2.TabIndex = 1;
            // 
            // IbName
            // 
            this.IbName.Location = new System.Drawing.Point(3, 0);
            this.IbName.Name = "IbName";
            this.IbName.Size = new System.Drawing.Size(159, 40);
            this.IbName.TabIndex = 0;
            this.IbName.Text = "label1";
            this.IbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtImg
            // 
            this.txtImg.Image = ((System.Drawing.Image)(resources.GetObject("txtImg.Image")));
            this.txtImg.Location = new System.Drawing.Point(31, 18);
            this.txtImg.Name = "txtImg";
            this.txtImg.Size = new System.Drawing.Size(96, 89);
            this.txtImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txtImg.TabIndex = 0;
            this.txtImg.TabStop = false;
            this.txtImg.Click += new System.EventHandler(this.txtImg_click);
            // 
            // UcProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UcProduct";
            this.Size = new System.Drawing.Size(171, 159);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label IbName;
        private System.Windows.Forms.PictureBox txtImg;
    }
}
