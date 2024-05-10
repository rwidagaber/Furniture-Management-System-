namespace Resturant_Mangement_System.View
{
    partial class frmTableView
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
            this.tablesView = new System.Windows.Forms.DataGridView();
            this.dgvSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvedit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvdel = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablesView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.Text = "Tables list";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            // 
            // tablesView
            // 
            this.tablesView.AllowUserToAddRows = false;
            this.tablesView.AllowUserToDeleteRows = false;
            this.tablesView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablesView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablesView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.tablesView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablesView.ColumnHeadersHeight = 50;
            this.tablesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSno,
            this.dgvid,
            this.dgvName,
            this.dgvedit,
            this.dgvdel});
            this.tablesView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.tablesView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.tablesView.Location = new System.Drawing.Point(12, 158);
            this.tablesView.Name = "tablesView";
            this.tablesView.ReadOnly = true;
            this.tablesView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablesView.RowHeadersVisible = false;
            this.tablesView.RowHeadersWidth = 10;
            this.tablesView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.tablesView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablesView.RowTemplate.Height = 24;
            this.tablesView.Size = new System.Drawing.Size(776, 269);
            this.tablesView.StandardTab = true;
            this.tablesView.TabIndex = 9;
            this.tablesView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablesView_CellClick);
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
            this.dgvdel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvdel.FillWeight = 50F;
            this.dgvdel.HeaderText = "";
            this.dgvdel.MinimumWidth = 50;
            this.dgvdel.Name = "dgvdel";
            this.dgvdel.ReadOnly = true;
            this.dgvdel.Width = 50;
            // 
            // frmTableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tablesView);
            this.Name = "frmTableView";
            this.Text = "frmTableView";
            this.Load += new System.EventHandler(this.frmTableView_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.tablesView, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tablesView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablesView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewImageColumn dgvedit;
        private System.Windows.Forms.DataGridViewImageColumn dgvdel;
    }
}