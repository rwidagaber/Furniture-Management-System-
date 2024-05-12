using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        public string custPhone = "010";
        public string date = "18/10/2002";

        public void txtReceived_TextChanged_1(object sender, EventArgs e)
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
            MessageBox.Show("payment has been done");

            int MainID = frmPOS.MainID;
            string qryl = "";
            string qry2 = "";
            int detailID = 0;
            // if (MainID == 0) //insert  
            if (MainID == 0) //insert
            {
                MessageBox.Show("saved");

                qryl = @"insert into orderDetail Values(  @odate , @total,
                               @Recieve,@change,@cashierName);
                                 select SCOPE_IDENTITY()";  //this line will get recent add id value

            }

            Hashtable ht = new Hashtable();

            SqlCommand cmd = new SqlCommand(qryl, MainClass.con);
            frmCheckout frmc = new frmCheckout();
            frmPOS frm = new frmPOS();
            cmd.Parameters.AddWithValue("@ID", MainID);
            
            cmd.Parameters.AddWithValue("@odate", "5/12/2024");
            
            cmd.Parameters.AddWithValue("@total", Convert.ToDouble(txtBillAmount.Text));  
            cmd.Parameters.AddWithValue("@Recieve", Convert.ToDouble(txtReceived.Text));
            cmd.Parameters.AddWithValue("@change", Convert.ToDouble(txtChange.Text));
           
            cmd.Parameters.AddWithValue("@cashierName", "ab");

            if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
            if (MainID == 0) { MainID = Convert.ToInt32(cmd.ExecuteScalar()); } else { cmd.ExecuteNonQuery(); }
            if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }



            foreach (DataGridViewRow row in frm.dataGridView1.Rows)
            {
                detailID = Convert.ToInt32(row.Cells["dgvid"].Value);

                if (detailID == 0) //insert into orders
                {
                    qry2 = @"insert into orders Values( @pID , @pQty ,  @pAmount,@detID ";
                }

                else
                {
                    qry2 = @"update  orders set  pID = @pID , pQty = @pQty , pAmount = @pAmount,detID=@detID";

                }


                SqlCommand cmd2 = new SqlCommand(qry2, MainClass.con);
                cmd2.Parameters.AddWithValue("@orID", detailID);
                cmd2.Parameters.AddWithValue("@pID", Convert.ToInt32(row.Cells["dgvid"].Value));
                cmd2.Parameters.AddWithValue("@pQty", Convert.ToInt32(row.Cells["dgvQty"].Value));
                cmd2.Parameters.AddWithValue("@pAmount", Convert.ToDouble(row.Cells["dgvAmount"].Value));
                cmd2.Parameters.AddWithValue("@detID", MainID);


                if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
                cmd2.ExecuteNonQuery();
                if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }


                //msg--->saved successfully
                MessageBox.Show("Saved Successfuly..");
                MainID = 0;
                detailID = 0;
                this.Close();

            }
        }
        private void frmCheckout_Load(object sender, EventArgs e)
        {
            txtBillAmount.Text = amt.ToString();
        }

        private void txtChange_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
