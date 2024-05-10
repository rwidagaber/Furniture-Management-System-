namespace Resturant_Mangement_System.View
{
    partial class frmStaffView
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
            this.staffView = new System.Windows.Forms.DataGridView();
            this.dgvSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvusername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvedit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvdel = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.staffView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(72, 29);
            this.label2.Text = "Staff ";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            // 
            // staffView
            // 
            this.staffView.AllowUserToAddRows = false;
            this.staffView.AllowUserToDeleteRows = false;
            this.staffView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.staffView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.staffView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.staffView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffView.ColumnHeadersHeight = 50;
            this.staffView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.staffView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSno,
            this.dgvid,
            this.dgvName,
            this.dgvPhone,
            this.dgvRole,
            this.dgvusername,
            this.dgvPassword,
            this.dgvedit,
            this.dgvdel});
            this.staffView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.staffView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.staffView.Location = new System.Drawing.Point(12, 169);
            this.staffView.Name = "staffView";
            this.staffView.ReadOnly = true;
            this.staffView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.staffView.RowHeadersVisible = false;
            this.staffView.RowHeadersWidth = 10;
            this.staffView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.staffView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.staffView.RowTemplate.Height = 24;
            this.staffView.Size = new System.Drawing.Size(776, 269);
            this.staffView.StandardTab = true;
            this.staffView.TabIndex = 9;
            this.staffView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.staffView_CellClick);
            // 
            // dgvSno
            // 
            this.dgvSno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvSno.FillWeight = 70F;
            this.dgvSno.HeaderText = "Sr#";
            this.dgvSno.MinimumWidth = 70;
            this.dgvSno.Name = "dgvSno";
            this.dgvSno.ReadOnly = true;
            this.dgvSno.Width = 70;
            // 
            // dgvid
            // 
            this.dgvid.HeaderText = "ID";
            this.dgvid.MinimumWidth = 6;
            this.dgvid.Name = "dgvid";
            this.dgvid.ReadOnly = true;
            this.dgvid.Visible = false;
            // 
            // dgvName
            // 
            this.dgvName.HeaderText = "Name";
            this.dgvName.MinimumWidth = 6;
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            // 
            // dgvPhone
            // 
            this.dgvPhone.HeaderText = "Phone";
            this.dgvPhone.MinimumWidth = 6;
            this.dgvPhone.Name = "dgvPhone";
            this.dgvPhone.ReadOnly = true;
            // 
            // dgvRole
            // 
            this.dgvRole.HeaderText = "Role";
            this.dgvRole.MinimumWidth = 6;
            this.dgvRole.Name = "dgvRole";
            this.dgvRole.ReadOnly = true;
            // 
            // dgvusername
            // 
            this.dgvusername.HeaderText = "Username";
            this.dgvusername.MinimumWidth = 6;
            this.dgvusername.Name = "dgvusername";
            this.dgvusername.ReadOnly = true;
            // 
            // dgvPassword
            // 
            this.dgvPassword.HeaderText = "Password";
            this.dgvPassword.MinimumWidth = 6;
            this.dgvPassword.Name = "dgvPassword";
            this.dgvPassword.ReadOnly = true;
            this.dgvPassword.Visible = false;
            // 
            // dgvedit
            // 
            this.dgvedit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvedit.FillWeight = 50F;
            this.dgvedit.HeaderText = "";
            this.dgvedit.MinimumWidth = 6;
            this.dgvedit.Name = "dgvedit";
            this.dgvedit.ReadOnly = true;
            this.dgvedit.Width = 50;
            // 
            // dgvdel
            // 
            this.dgvdel.HeaderText = "";
            this.dgvdel.MinimumWidth = 6;
            this.dgvdel.Name = "dgvdel";
            this.dgvdel.ReadOnly = true;
            // 
            // frmStaffView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.staffView);
            this.Name = "frmStaffView";
            this.Text = "frmStaffView";
            this.Load += new System.EventHandler(this.frmStaffView_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.staffView, 0);
            ((System.ComponentModel.ISupportInitialize)(this.staffView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView staffView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvusername;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPassword;
        private System.Windows.Forms.DataGridViewImageColumn dgvedit;
        private System.Windows.Forms.DataGridViewImageColumn dgvdel;
    }
}