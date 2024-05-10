
namespace Resturant_Mangement_System.Model
{
    partial class frmPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOS));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.ProductPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ucProduct2 = new Resturant_Mangement_System.Model.UcProduct();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.CategoryPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblWaiter = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.btnDin = new System.Windows.Forms.Button();
            this.POS = new System.Windows.Forms.Label();
            this.btnTake = new System.Windows.Forms.Button();
            this.btnDelievery = new System.Windows.Forms.Button();
            this.btnKot = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnHold = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.lblDriverName = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dgvSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.CategoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(701, 550);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 26);
            this.label1.TabIndex = 21;
            this.label1.Text = "Total";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(749, 553);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(107, 23);
            this.lblTotal.TabIndex = 22;
            this.lblTotal.Text = "0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductPanel
            // 
            this.ProductPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductPanel.AutoScroll = true;
            this.ProductPanel.Controls.Add(this.ucProduct2);
            this.ProductPanel.Location = new System.Drawing.Point(123, 133);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(510, 410);
            this.ProductPanel.TabIndex = 18;
            // 
            // ucProduct2
            // 
            this.ucProduct2.id = 0;
            this.ucProduct2.Location = new System.Drawing.Point(3, 3);
            this.ucProduct2.Name = "ucProduct2";
            this.ucProduct2.PCategory = null;
            this.ucProduct2.PImage = ((System.Drawing.Image)(resources.GetObject("ucProduct2.PImage")));
            this.ucProduct2.PName = "label1";
            this.ucProduct2.PPrice = null;
            this.ucProduct2.Size = new System.Drawing.Size(171, 159);
            this.ucProduct2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSno,
            this.dgvid,
            this.dgvName,
            this.dgvQty,
            this.dgvPrice,
            this.dgvAmount});
            this.dataGridView1.Location = new System.Drawing.Point(639, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(333, 407);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 579);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(650, 0, 0, 0);
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1058, 53);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckout.AutoSize = true;
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.btnCheckout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Location = new System.Drawing.Point(506, 550);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(78, 26);
            this.btnCheckout.TabIndex = 1;
            this.btnCheckout.Text = "Check Out";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // CategoryPanel
            // 
            this.CategoryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CategoryPanel.Controls.Add(this.button1);
            this.CategoryPanel.Location = new System.Drawing.Point(0, 133);
            this.CategoryPanel.Name = "CategoryPanel";
            this.CategoryPanel.Size = new System.Drawing.Size(118, 407);
            this.CategoryPanel.TabIndex = 23;
            this.CategoryPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CategoryPanel_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblWaiter
            // 
            this.lblWaiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaiter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWaiter.Location = new System.Drawing.Point(836, 41);
            this.lblWaiter.Name = "lblWaiter";
            this.lblWaiter.Size = new System.Drawing.Size(81, 29);
            this.lblWaiter.TabIndex = 8;
            this.lblWaiter.Text = "Waiter";
            this.lblWaiter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWaiter.Visible = false;
            // 
            // lblTable
            // 
            this.lblTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTable.Location = new System.Drawing.Point(836, 12);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(81, 29);
            this.lblTable.TabIndex = 7;
            this.lblTable.Text = "Table";
            this.lblTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTable.Visible = false;
            // 
            // btnDin
            // 
            this.btnDin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.btnDin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDin.FlatAppearance.BorderSize = 0;
            this.btnDin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDin.Location = new System.Drawing.Point(762, 12);
            this.btnDin.Name = "btnDin";
            this.btnDin.Size = new System.Drawing.Size(68, 38);
            this.btnDin.TabIndex = 6;
            this.btnDin.Text = "Din In";
            this.btnDin.UseVisualStyleBackColor = false;
            this.btnDin.Click += new System.EventHandler(this.btnDin_Click);
            // 
            // POS
            // 
            this.POS.AutoSize = true;
            this.POS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.POS.Location = new System.Drawing.Point(120, 9);
            this.POS.Name = "POS";
            this.POS.Size = new System.Drawing.Size(40, 18);
            this.POS.TabIndex = 5;
            this.POS.Text = "POS";
            // 
            // btnTake
            // 
            this.btnTake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.btnTake.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTake.FlatAppearance.BorderSize = 0;
            this.btnTake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTake.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTake.Location = new System.Drawing.Point(688, 12);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(68, 38);
            this.btnTake.TabIndex = 5;
            this.btnTake.Text = "Take Away";
            this.btnTake.UseVisualStyleBackColor = false;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // btnDelievery
            // 
            this.btnDelievery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.btnDelievery.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelievery.FlatAppearance.BorderSize = 0;
            this.btnDelievery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelievery.Location = new System.Drawing.Point(614, 12);
            this.btnDelievery.Name = "btnDelievery";
            this.btnDelievery.Size = new System.Drawing.Size(68, 38);
            this.btnDelievery.TabIndex = 4;
            this.btnDelievery.Text = "Delievery";
            this.btnDelievery.UseVisualStyleBackColor = false;
            this.btnDelievery.Click += new System.EventHandler(this.btnDelievery_Click);
            // 
            // btnKot
            // 
            this.btnKot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.btnKot.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKot.FlatAppearance.BorderSize = 0;
            this.btnKot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKot.Location = new System.Drawing.Point(540, 12);
            this.btnKot.Name = "btnKot";
            this.btnKot.Size = new System.Drawing.Size(68, 38);
            this.btnKot.TabIndex = 3;
            this.btnKot.Text = "Kot";
            this.btnKot.UseVisualStyleBackColor = false;
            this.btnKot.Click += new System.EventHandler(this.btnKot_Click);
            // 
            // btnBill
            // 
            this.btnBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.btnBill.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBill.FlatAppearance.BorderSize = 0;
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBill.Location = new System.Drawing.Point(466, 12);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(68, 38);
            this.btnBill.TabIndex = 2;
            this.btnBill.Text = "Bill List";
            this.btnBill.UseVisualStyleBackColor = false;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnHold
            // 
            this.btnHold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.btnHold.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHold.FlatAppearance.BorderSize = 0;
            this.btnHold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHold.Location = new System.Drawing.Point(392, 12);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(68, 38);
            this.btnHold.TabIndex = 1;
            this.btnHold.Text = "Hold";
            this.btnHold.UseVisualStyleBackColor = false;
            this.btnHold.Click += new System.EventHandler(this.btnHold_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblWaiter);
            this.panel1.Controls.Add(this.lblTable);
            this.panel1.Controls.Add(this.btnDin);
            this.panel1.Controls.Add(this.POS);
            this.panel1.Controls.Add(this.btnTake);
            this.panel1.Controls.Add(this.btnDelievery);
            this.panel1.Controls.Add(this.btnKot);
            this.panel1.Controls.Add(this.btnBill);
            this.panel1.Controls.Add(this.btnHold);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 74);
            this.panel1.TabIndex = 16;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.btnExit.Location = new System.Drawing.Point(923, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 50);
            this.btnExit.TabIndex = 24;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Location = new System.Drawing.Point(318, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(68, 38);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(148, 99);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(238, 28);
            this.txtsearch.TabIndex = 19;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // lblDriverName
            // 
            this.lblDriverName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverName.ForeColor = System.Drawing.Color.Black;
            this.lblDriverName.Location = new System.Drawing.Point(392, 99);
            this.lblDriverName.Name = "lblDriverName";
            this.lblDriverName.Size = new System.Drawing.Size(81, 29);
            this.lblDriverName.TabIndex = 24;
            this.lblDriverName.Text = "Driver";
            this.lblDriverName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDriverName.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.AutoSize = true;
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Location = new System.Drawing.Point(839, 546);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(78, 26);
            this.btnPrint.TabIndex = 25;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dgvSno
            // 
            this.dgvSno.FillWeight = 28.03069F;
            this.dgvSno.HeaderText = "Sr#";
            this.dgvSno.MinimumWidth = 6;
            this.dgvSno.Name = "dgvSno";
            this.dgvSno.ReadOnly = true;
            // 
            // dgvid
            // 
            this.dgvid.HeaderText = "id";
            this.dgvid.MinimumWidth = 6;
            this.dgvid.Name = "dgvid";
            this.dgvid.ReadOnly = true;
            this.dgvid.Visible = false;
            // 
            // dgvName
            // 
            this.dgvName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvName.FillWeight = 82.44316F;
            this.dgvName.HeaderText = "Name";
            this.dgvName.MinimumWidth = 50;
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            // 
            // dgvQty
            // 
            this.dgvQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvQty.FillWeight = 30F;
            this.dgvQty.HeaderText = "Qty";
            this.dgvQty.MinimumWidth = 30;
            this.dgvQty.Name = "dgvQty";
            this.dgvQty.ReadOnly = true;
            this.dgvQty.Width = 30;
            // 
            // dgvPrice
            // 
            this.dgvPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvPrice.FillWeight = 50F;
            this.dgvPrice.HeaderText = "Price";
            this.dgvPrice.MinimumWidth = 50;
            this.dgvPrice.Name = "dgvPrice";
            this.dgvPrice.ReadOnly = true;
            this.dgvPrice.Width = 50;
            // 
            // dgvAmount
            // 
            this.dgvAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvAmount.FillWeight = 50F;
            this.dgvAmount.HeaderText = "Amount";
            this.dgvAmount.MinimumWidth = 50;
            this.dgvAmount.Name = "dgvAmount";
            this.dgvAmount.ReadOnly = true;
            this.dgvAmount.Width = 50;
            // 
            // frmPOS
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1058, 632);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblDriverName);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.ProductPanel);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.CategoryPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtsearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPOS";
            this.Load += new System.EventHandler(this.frmPOS_Load);
            this.ProductPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.CategoryPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.FlowLayoutPanel ProductPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.FlowLayoutPanel CategoryPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblWaiter;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Button btnDin;
        private System.Windows.Forms.Label POS;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.Button btnDelievery;
        private System.Windows.Forms.Button btnKot;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnHold;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.PictureBox btnExit;
        //private UcProduct ucProduct2;
        private System.Windows.Forms.Label lblDriverName;
        private UcProduct ucProduct2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAmount;
    }
}