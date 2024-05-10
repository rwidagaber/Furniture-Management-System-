
namespace Resturant_Mangement_System.Model
{
    partial class frmCheckout
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
            this.txtChange = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBillAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReceived = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(800, 100);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(800, 100);
            // 
            // txtChange
            // 
            this.txtChange.Enabled = false;
            this.txtChange.Location = new System.Drawing.Point(36, 281);
            this.txtChange.Multiline = true;
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.Size = new System.Drawing.Size(190, 37);
            this.txtChange.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(33, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 34);
            this.label3.TabIndex = 18;
            this.label3.Text = "Change";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.Enabled = false;
            this.txtBillAmount.Location = new System.Drawing.Point(36, 167);
            this.txtBillAmount.Multiline = true;
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.ReadOnly = true;
            this.txtBillAmount.Size = new System.Drawing.Size(190, 37);
            this.txtBillAmount.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(33, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 34);
            this.label2.TabIndex = 16;
            this.label2.Text = "Bill Amount";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtReceived
            // 
            this.txtReceived.Location = new System.Drawing.Point(273, 167);
            this.txtReceived.Multiline = true;
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.Size = new System.Drawing.Size(196, 37);
            this.txtReceived.TabIndex = 15;
            this.txtReceived.TextChanged += new System.EventHandler(this.txtReceived_TextChanged_1);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(270, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 34);
            this.label4.TabIndex = 14;
            this.label4.Text = "Payment Received";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBillAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtReceived);
            this.Controls.Add(this.label4);
            this.Name = "frmCheckout";
            this.Text = "frmCheckout";
            this.Load += new System.EventHandler(this.frmCheckout_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtReceived, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtBillAmount, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtChange, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBillAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReceived;
        private System.Windows.Forms.Label label4;
    }
}