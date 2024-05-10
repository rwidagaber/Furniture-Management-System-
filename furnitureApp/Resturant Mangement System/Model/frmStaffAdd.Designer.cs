namespace Resturant_Mangement_System.Model
{
    partial class frmStaffAdd
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
            this.txtstaffName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(615, 100);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 491);
            this.panel2.Size = new System.Drawing.Size(615, 100);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.Text = "Staff Details";
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            // 
            // txtstaffName
            // 
            this.txtstaffName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtstaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstaffName.Location = new System.Drawing.Point(33, 173);
            this.txtstaffName.Name = "txtstaffName";
            this.txtstaffName.Size = new System.Drawing.Size(251, 30);
            this.txtstaffName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(29, 233);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(100, 22);
            this.Username.TabIndex = 3;
            this.Username.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(33, 267);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(240, 30);
            this.txtUsername.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(213, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Role";
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "Cashier",
            "Waiter",
            "Maneger",
            "Cleaner",
            "Driver",
            "other"});
            this.cbRole.Location = new System.Drawing.Point(217, 395);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(209, 24);
            this.cbRole.TabIndex = 6;
            // 
            // txtPass
            // 
            this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(333, 259);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '.';
            this.txtPass.Size = new System.Drawing.Size(240, 38);
            this.txtPass.TabIndex = 9;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(333, 173);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(251, 30);
            this.txtPhone.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(329, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(329, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Phone";
            // 
            // frmStaffAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 591);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtstaffName);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label2);
            this.Name = "frmStaffAdd";
            this.Text = "frmStaffAdd";
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.Username, 0);
            this.Controls.SetChildIndex(this.txtstaffName, 0);
            this.Controls.SetChildIndex(this.txtUsername, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.cbRole, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtPhone, 0);
            this.Controls.SetChildIndex(this.txtPass, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtstaffName;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label Username;
        public System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cbRole;
        public System.Windows.Forms.TextBox txtPass;
        public System.Windows.Forms.TextBox txtPhone;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}