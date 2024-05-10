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

namespace Resturant_Mangement_System.View
{
    public partial class frmKitchenView : Form
    {
        public frmKitchenView()
        {
            InitializeComponent();
        }

        private void frmKitchenView_Load(object sender, EventArgs e)
        {
            GetOrders();
        }
        private void GetOrders()
        {
            flowLayoutPanel1.Controls.Clear();
            string qry1 = @"Select * from tblMain where status = 'Pending'";
            SqlCommand cmd1= new SqlCommand(qry1,MainClass.con);
            DataTable dt1 = new DataTable();
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(cmd1);
            sqlDataAdapter1.Fill(dt1);

            FlowLayoutPanel p1, p2;
            for(int i = 0; i < dt1.Rows.Count; ++i)
            {
                p1 = new FlowLayoutPanel();
                p1.AutoSize= true;
                p1.Width = 230;
                p1.Height = 350;
                p1.FlowDirection = FlowDirection.TopDown;
                p1.BorderStyle = BorderStyle.FixedSingle;
                p1.Margin = new Padding(10, 10, 10, 10);

                p2 = new FlowLayoutPanel();
                p2.AutoSize = true;
                p2.Width = 230;
                p2.Height = 125;
                p2.FlowDirection = FlowDirection.TopDown;
                p2.BorderStyle = BorderStyle.FixedSingle;
                p2.Margin = new Padding(0);
                p2.BackColor=Color.Black;

                Label lbl1 = new Label();    
                lbl1.ForeColor = Color.White;
                lbl1.Margin= new Padding(10,10,3,0);
                lbl1 .AutoSize = true;

                Label lbl2 = new Label();
                lbl2.ForeColor = Color.White;
                lbl2.Margin = new Padding(10, 5, 3, 0);
                lbl2.AutoSize = true;

                Label lbl3 = new Label();
                lbl3.ForeColor = Color.White;
                lbl3.Margin = new Padding(10, 10, 3, 0);
                lbl3.AutoSize = true;

                Label lbl4 = new Label();   
                lbl4.ForeColor = Color.White;
                lbl4.Margin=new Padding(10,5, 3, 0);
                lbl4.AutoSize = true;

                lbl1.Text = "Table :" + dt1.Rows[i]["TableName"].ToString();
                lbl2.Text = "Waiter Name :" + dt1.Rows[i]["WaiterName"].ToString();
                lbl3.Text = "Order Time :" + dt1.Rows[i]["aTime"].ToString();
                lbl4.Text = "Order Type :" + dt1.Rows[i]["orderType"].ToString();

                p2.Controls.Add(lbl1);
                p2.Controls.Add(lbl2);
                p2.Controls.Add(lbl3);
                p2.Controls.Add(lbl4);

                int mid = 0;
                mid = Convert.ToInt32(dt1.Rows[i]["MainID"].ToString());

                string qry2 = @"select * from tblMain m inner join tblDetails d on m.MainID = d.MainID
                               inner join product p on p.pID = d.proID where m.MainID = "+mid+"";

                SqlCommand cmd2 = new SqlCommand(qry2, MainClass.con);
                DataTable dt2 = new DataTable();
                SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(cmd2);
                sqlDataAdapter2.Fill(dt2);

                for (int j = 0; j < dt2.Rows.Count; ++j)
                {
                    Label lbl5 = new Label();
                    lbl5.ForeColor = Color.White;
                    lbl5.Margin = new Padding(10, 5, 3, 0);
                    lbl5.AutoSize = true;

                    
                    lbl5.Text = "" + (i+j) + " " + dt2.Rows[j]["pName"].ToString() + " " + dt2.Rows[j]["qty"].ToString();
                    p1.Controls.Add(lbl5);

                }
                //complete button
                System.Windows.Forms.Button button = new System.Windows.Forms.Button();
                button.Size = new Size(100, 35);
                button.BackColor = Color.Yellow;
                button.Margin=new Padding(30, 5, 3, 10);
                button.Text = "Complete";
                button.Tag = dt1.Rows[i]["MainID"].ToString();//store id
                button.Click += new EventHandler(button_click);
                p1.Controls.Add(button);

                p1.Controls.Add(p2);
                flowLayoutPanel1.Controls.Add(p1 );

            }

        }

        private void button_click(object sender, EventArgs e)
        {
            int id= Convert.ToInt32(((Button)sender).Tag.ToString());

            if (MessageBox.Show("Are you sure to update order status? ", "Warnnig", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string qry = @"Update tblMain set status = 'Complete' where MainID=@ID";
                Hashtable ht = new Hashtable();
                ht.Add("@ID", id);

                if (MainClass.SQl(qry, ht) > 0)
                {
                    MessageBox.Show("Saved Successfuly...");
                }
            }GetOrders(); 
        }
    }
}
