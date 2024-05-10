namespace Resturant_Mangement_System.View
{
    partial class frmProductView
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
            this.productView = new System.Windows.Forms.DataGridView();
            this.dgvSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvimage = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvedit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvdel = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(151, 29);
            this.label2.Text = "Product List";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            // 
            // productView
            // 
            this.productView.AllowUserToAddRows = false;
            this.productView.AllowUserToDeleteRows = false;
            this.productView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.productView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productView.ColumnHeadersHeight = 50;
            this.productView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.productView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSno,
            this.dgvid,
            this.dgvName,
            this.dgvprice,
            this.dgvcatID,
            this.dgvcategory,
            this.dgvimage,
            this.dgvedit,
            this.dgvdel});
            this.productView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.productView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.productView.Location = new System.Drawing.Point(12, 169);
            this.productView.Name = "productView";
            this.productView.ReadOnly = true;
            this.productView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.productView.RowHeadersVisible = false;
            this.productView.RowHeadersWidth = 10;
            this.productView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.productView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.productView.RowTemplate.Height = 24;
            this.productView.Size = new System.Drawing.Size(776, 269);
            this.productView.StandardTab = true;
            this.productView.TabIndex = 9;
            this.productView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productView_CellClick);
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
            // dgvprice
            // 
            this.dgvprice.HeaderText = "Price";
            this.dgvprice.MinimumWidth = 6;
            this.dgvprice.Name = "dgvprice";
            this.dgvprice.ReadOnly = true;
            // 
            // dgvcatID
            // 
            this.dgvcatID.HeaderText = "cID";
            this.dgvcatID.MinimumWidth = 6;
            this.dgvcatID.Name = "dgvcatID";
            this.dgvcatID.ReadOnly = true;
            this.dgvcatID.Visible = false;
            // 
            // dgvcategory
            // 
            this.dgvcategory.HeaderText = "Category";
            this.dgvcategory.MinimumWidth = 6;
            this.dgvcategory.Name = "dgvcategory";
            this.dgvcategory.ReadOnly = true;
            // 
            // dgvimage
            // 
            this.dgvimage.HeaderText = "Image";
            this.dgvimage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvimage.MinimumWidth = 6;
            this.dgvimage.Name = "dgvimage";
            this.dgvimage.ReadOnly = true;
            this.dgvimage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            // frmProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.productView);
            this.Name = "frmProductView";
            this.Text = "frmProductView";
            this.Load += new System.EventHandler(this.frmProductView_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.productView, 0);
            ((System.ComponentModel.ISupportInitialize)(this.productView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcategory;
        private System.Windows.Forms.DataGridViewImageColumn dgvimage;
        private System.Windows.Forms.DataGridViewImageColumn dgvedit;
        private System.Windows.Forms.DataGridViewImageColumn dgvdel;
    }
}