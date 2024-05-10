
namespace Resturant_Mangement_System.Model
{
    partial class frmAddCustomer
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDriver = new System.Windows.Forms.ComboBox();
            this.lblDriver = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //  
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(336, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(99, 259);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(258, 36);
            this.txtPhone.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(99, 195);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(258, 36);
            this.txtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // cbDriver
            // 
            this.cbDriver.FormattingEnabled = true;
            this.cbDriver.Items.AddRange(new object[] {
            "Cashier",
            "Waiter",
            "Maneger",
            "Cleaner",
            "Other"});
            this.cbDriver.Location = new System.Drawing.Point(99, 143);
            this.cbDriver.Name = "cbDriver";
            this.cbDriver.Size = new System.Drawing.Size(258, 24);
            this.cbDriver.TabIndex = 1;
            // 
            // lblDriver
            // 
            this.lblDriver.AutoSize = true;
            this.lblDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriver.Location = new System.Drawing.Point(99, 118);
            this.lblDriver.Name = "lblDriver";
            this.lblDriver.Size = new System.Drawing.Size(64, 22);
            this.lblDriver.TabIndex = 0;
            this.lblDriver.Text = "Driver";
            // 
            // frmAddCustomer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(581, 468);
            this.Controls.Add(this.lblDriver);
            this.Controls.Add(this.cbDriver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPhone);
            this.Name = "frmAddCustomer";
            this.Text = "frmAddCustomer";
            this.Load += new System.EventHandler(this.frmAddCustomer_Load);
            this.Controls.SetChildIndex(this.txtPhone, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cbDriver, 0);
            this.Controls.SetChildIndex(this.lblDriver, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbDriver;
        private System.Windows.Forms.Label lblDriver;
    }
}