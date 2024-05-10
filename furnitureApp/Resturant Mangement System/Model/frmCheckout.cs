using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant_Mangement_System.Model
{
    public partial class frmCheckout : SampleAdd
    {
        public frmCheckout()
        {
            InitializeComponent();
        }


        public double amt;
        public int oID = 0;

        private void txtReceived_TextChanged_1(object sender, EventArgs e)
        {
            double amt = 0;
            double receipt = 0;
            double change = 0;

            double.TryParse(txtBillAmount.Text, out amt);
            double.TryParse(txtReceived.Text, out receipt);

            change = receipt - amt;
            txtChange.Text = change.ToString();
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            string qry = @"Update orderDetail set total = @total ,recieve = @rec , change = @change
                                      status = 'Paid'     where oID = @id";
            Hashtable ht = new Hashtable();
            ht.Add("@id", oID);
            ht.Add("@total", txtBillAmount.Text);
            ht.Add("@rec", txtReceived.Text);
            ht.Add("@change", txtChange.Text);

            if(MainClass.SQl(qry,ht)>0)
            {
                MessageBox.Show("done");
                //msgdialog.Button = System.Windows.Forms.msgdialogButton.OK;
                //msgdialog.Show();
                this.Close(); 
            }
        }

        private void frmCheckout_Load(object sender, EventArgs e)
        {
            txtBillAmount.Text = amt.ToString();
        }
    }

}
