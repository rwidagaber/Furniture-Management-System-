namespace Resturant_Mangement_System.View
{
    partial class frmProductAdd
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
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtsproductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbcat = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.rMSDataSet1 = new Resturant_Mangement_System.RMSDataSet1();
            this.categoryBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.rMSDataSet2 = new Resturant_Mangement_System.RMSDataSet2();
            this.categoryBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.categoryBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.rMSDataSet = new Resturant_Mangement_System.RMSDataSet();
            this.categoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtImage = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.categoryTableAdapter = new Resturant_Mangement_System.RMSDataSet1TableAdapters.categoryTableAdapter();
            this.categoryTableAdapter1 = new Resturant_Mangement_System.RMSDataSet2TableAdapters.categoryTableAdapter();
            this.rMSDataSet3 = new Resturant_Mangement_System.RMSDataSet3();
            this.categoryBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter2 = new Resturant_Mangement_System.RMSDataSet3TableAdapters.categoryTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMSDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMSDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource6)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(681, 100);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 434);
            this.panel2.Size = new System.Drawing.Size(681, 100);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.Text = "Product Details";
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
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(31, 257);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(240, 26);
            this.txtPrice.TabIndex = 7;
            // 
            // txtsproductName
            // 
            this.txtsproductName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsproductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsproductName.Location = new System.Drawing.Point(31, 163);
            this.txtsproductName.Name = "txtsproductName";
            this.txtsproductName.Size = new System.Drawing.Size(240, 26);
            this.txtsproductName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // cbcat
            // 
            this.cbcat.DataSource = this.categoryBindingSource6;
            this.cbcat.DisplayMember = "catName";
            this.cbcat.FormattingEnabled = true;
            this.cbcat.Location = new System.Drawing.Point(31, 370);
            this.cbcat.Name = "cbcat";
            this.cbcat.Size = new System.Drawing.Size(240, 21);
            this.cbcat.TabIndex = 8;
            this.cbcat.ValueMember = "catID";
            // 
            // categoryBindingSource5
            // 
            this.categoryBindingSource5.DataMember = "category";
            this.categoryBindingSource5.DataSource = this.rMSDataSet1;
            // 
            // rMSDataSet1
            // 
            this.rMSDataSet1.DataSetName = "RMSDataSet1";
            this.rMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource4
            // 
            this.categoryBindingSource4.DataMember = "category";
            this.categoryBindingSource4.DataSource = this.rMSDataSet2;
            // 
            // rMSDataSet2
            // 
            this.rMSDataSet2.DataSetName = "RMSDataSet2";
            this.rMSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource3
            // 
            this.categoryBindingSource3.DataMember = "category";
            this.categoryBindingSource3.DataSource = this.rMSDataSet1;
            // 
            // categoryBindingSource2
            // 
            this.categoryBindingSource2.DataMember = "category";
            this.categoryBindingSource2.DataSource = this.rMSDataSet;
            // 
            // rMSDataSet
            // 
            this.rMSDataSet.DataSetName = "RMSDataSet";
            this.rMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource1
            // 
            this.categoryBindingSource1.DataMember = "category";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Category";
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(390, 142);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(156, 145);
            this.txtImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txtImage.TabIndex = 9;
            this.txtImage.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(405, 316);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(130, 42);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // categoryTableAdapter1
            // 
            this.categoryTableAdapter1.ClearBeforeFill = true;
            // 
            // rMSDataSet3
            // 
            this.rMSDataSet3.DataSetName = "RMSDataSet3";
            this.rMSDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource6
            // 
            this.categoryBindingSource6.DataMember = "category";
            this.categoryBindingSource6.DataSource = this.rMSDataSet3;
            // 
            // categoryTableAdapter2
            // 
            this.categoryTableAdapter2.ClearBeforeFill = true;
            // 
            // frmProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 534);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.cbcat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtsproductName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmProductAdd";
            this.Text = "frmProductAdd";
            this.Load += new System.EventHandler(this.frmProductAdd_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtsproductName, 0);
            this.Controls.SetChildIndex(this.txtPrice, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.cbcat, 0);
            this.Controls.SetChildIndex(this.txtImage, 0);
            this.Controls.SetChildIndex(this.btnBrowse, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMSDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMSDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtPrice;
        public System.Windows.Forms.TextBox txtsproductName;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbcat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.Button btnBrowse;
        public System.Windows.Forms.PictureBox txtImage;
        private System.Windows.Forms.BindingSource categoryBindingSource1;
        private RMSDataSet rMSDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource2;
        private RMSDataSet1 rMSDataSet1;
        private System.Windows.Forms.BindingSource categoryBindingSource3;
        private RMSDataSet1TableAdapters.categoryTableAdapter categoryTableAdapter;
        private RMSDataSet2 rMSDataSet2;
        private System.Windows.Forms.BindingSource categoryBindingSource4;
        private RMSDataSet2TableAdapters.categoryTableAdapter categoryTableAdapter1;
        private System.Windows.Forms.BindingSource categoryBindingSource5;
        private RMSDataSet3 rMSDataSet3;
        private System.Windows.Forms.BindingSource categoryBindingSource6;
        private RMSDataSet3TableAdapters.categoryTableAdapter categoryTableAdapter2;
    }
}