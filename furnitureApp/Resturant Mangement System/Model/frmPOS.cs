using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Resturant_Mangement_System.Model
{
    public partial class frmPOS : Form
    {
        public frmPOS()
        {
            InitializeComponent();
        }
        public static int MainID = 0;
        public string OrderType = "";
        public int id = 0;
        public int driverID = 0;
        public string customerName = "";
        public string customerPhone = "";


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        private void frmPOS_Load(object sender, EventArgs e)
        {
            AddCategory();
            ProductPanel.Controls.Clear();
            LoadProducts();
        }


        private void AddCategory()
        {
            string qry = "Select * from category";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            CategoryPanel.Controls.Clear();


            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows) //back again to make sure--->
                {
                    //properties
                    Button b = new Button();
                    b.BackColor = Color.FromArgb(151, 116, 95);
                    b.ForeColor = Color.FromArgb(255, 255, 255);
                    b.Size = new Size(134, 50);
                    //b.ButtonMode = System.Windows.Forms.Enums.ButtonMode.RadioButton;
                    b.Text = row["CatName"].ToString();

                    //event for click
                    b.Click += new EventHandler(b_Click);

                    CategoryPanel.Controls.Add(b);
                }

            }
        }

        private void b_Click(object sender, EventArgs e)
        {

            System.Windows.Forms.Button b = (System.Windows.Forms.Button)sender;

            if (b.Text == "All Ctegories")
            {
                txtsearch.Text = "1";
                txtsearch.Text = "";
            }

            foreach (var item in ProductPanel.Controls)
            {
                var pro = (UcProduct)item;
                pro.Visible = pro.PCategory.ToLower().Contains(b.Text.Trim().ToLower());
            };
        }
        // view Prudcut cards
        private void AddItems(string id, string proID, string name, string cat, string price, Image pimage)
        {
            var w = new UcProduct {
                PName = name,
                PPrice = price,
                PCategory = cat,
                PImage = pimage,
                id = Convert.ToInt32(proID)
            };

            ProductPanel.Controls.Add(w);

            w.onSelect += (ss, ee) =>
            {
                var wdg = (UcProduct)ss;
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    //this will check product already there then +1 to quantity and update price
                    if (Convert.ToInt32(item.Cells["dgvid"].Value) == wdg.id)
                    {
                        item.Cells["dgvQty"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) + 1;
                        item.Cells["dgvAmount"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) *
                            double.Parse(item.Cells["dgvPrice"].Value.ToString());


                        GetTotal();
                        return;
                    }


                }

                //this line add new product

                dataGridView1.Rows.Add(new object[] { 0, wdg.id, wdg.PName, 1, wdg.PPrice, wdg.PPrice });

                GetTotal();
            };

        }


        //getting product from DB

        private void LoadProducts()
        {
            string qry = "select * from product inner join category on catID = categoryID";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                Byte[] imagearray = (byte[])item["PImage"];
                byte[] imagebytarray = imagearray;

                AddItems("0", item["pID"].ToString(), item["pName"].ToString(), item["catName"].ToString(),
                    item["pPrice"].ToString(), Image.FromStream(new MemoryStream(imagebytarray)));
            }
        }



        private void CategoryPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in ProductPanel.Controls)
            {
                var pro = (UcProduct)item;
                pro.Visible = pro.PName.ToLower().Contains(txtsearch.Text.Trim().ToLower());
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //for serial no

            int count = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                count++;
                row.Cells[0].Value = count;

            }
        }

        //total price
        private double GetTotal()
        {
            double tot = 0;
            lblTotal.Text = "";
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                tot += double.Parse(item.Cells["dgvAmount"].Value.ToString());
            }
            lblTotal.Text = tot.ToString("N2");
            return tot;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            dataGridView1.Rows.Clear();
            MainID = 0;
            lblTotal.Text = "00";
        }








        


    

    private void btnBill_Click(object sender, EventArgs e)
        {
            frmBillList frm = new frmBillList();
            frm.ShowDialog();

            if (frm.MainID > 0)
            {
                id = frm.MainID;
                MainID = frm.MainID;
                LoadEntries();
            }
        }

        private void LoadEntries()
        {
            string qry = @"Select * from orderDetil m
                                    inner join tblDetails d on m.oID
                                    inner join products p on p.pID = d.pID
                                    where m.oID = " + id + "";

            SqlCommand cmd2 = new SqlCommand(qry, MainClass.con);
            DataTable dt2 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            da.Fill(dt2);

            //if (dt2.Rows[0]["orderType"].ToString() == "Delivery")
            //{
            //    //btnDelievery. = true;
            //    lblWaiter.Visible = false;
            //    lblTable.Visible = false;

            //}

            //else if (dt2.Rows[0]["orderType"].ToString() == "Take Away")
            //{
            //   // btnTake.Select() = true;
            //    btnTake.BackColor=Color.White;
            //    lblWaiter.Visible = false;
            //    lblTable.Visible = false;

            //}

            //else
            //{
            //    //btnDin.check = true;
            //    lblWaiter.Visible = true;
            //    lblTable.Visible = true;

            //}

            dataGridView1.Rows.Clear();

            foreach (DataRow item in dt2.Rows)
            {
                lblTable.Text = item["TableName"].ToString();
                lblWaiter.Text = item["WaiterName"].ToString();

                string detailid = item["DetailID"].ToString();
                string proName = item["proID"].ToString();
                string proid = item["proID"].ToString();
                string qty = item["qty"].ToString();
                string price = item["price"].ToString();
                string amount = item["amount"].ToString();


                object[] obj = { 0, detailid, proid, proName, qty, price, amount };

                dataGridView1.Rows.Add(obj);
            }
            GetTotal();

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            frmCheckout frm = new frmCheckout();
            
            frm.oID = id;
            frm.amt = Convert.ToDouble(lblTotal.Text);
            frm.ShowDialog();


            //MessageBox.Show("Saved Successfully");
            MainID = 0;
           // dataGridView1.Rows.Clear();
            //lblTable.Text = "";
            //lblWaiter.Text = "";
            //lblTable.Visible = false;
            //lblWaiter.Visible = false;
            //lblTotal.Text = "00";
        }


        private void btnHold_Click(object sender, EventArgs e)
        {
            string qryl = "";  //main table
            string qry2 = ""; //deatil table

            int detailID = 0;

            if(OrderType=="")
            {
                MessageBox.Show("Please select order type");
                return;
            }

            if (MainID == 0) //insert
            {

                qryl = @"insert into tblMain Values(@aDate , @aTime , @TableName  ,@WaiterName ,
                               @status , @orderType , @total , @recevied , @change, @driverID , @CustName , @CustPhone);
                                 select SCOPE_IDENTITY()";  //this line will get recent add id value
            }

            else //update
            {
                qryl = @"update into tblMain set status= @status,total = @total,recevied = @recevied,change = @change where MainID = @ID";

            }

            Hashtable ht = new Hashtable();

            SqlCommand cmd = new SqlCommand(qryl, MainClass.con);
            cmd.Parameters.AddWithValue("@ID", MainID);
            cmd.Parameters.AddWithValue("(@aDate", Convert.ToDateTime(DateTime.Now.Date));
            cmd.Parameters.AddWithValue("@aTime", DateTime.Now.ToShortTimeString());
            cmd.Parameters.AddWithValue("@TableName", lblTable.Text);
            cmd.Parameters.AddWithValue("@WaiterName", lblWaiter.Text);
            cmd.Parameters.AddWithValue("@status", "Hold");
            cmd.Parameters.AddWithValue("@orderType", OrderType);
            cmd.Parameters.AddWithValue("@total", Convert.ToDouble(0));  //as we only saving data for kitch value will update when payement
            cmd.Parameters.AddWithValue("@recevied", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@change", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@driverID", driverID);
            cmd.Parameters.AddWithValue("@CustName", customerName);
            cmd.Parameters.AddWithValue("@CustPhone", customerPhone);


            if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
            if (MainID == 0) { MainID = Convert.ToInt32(cmd.ExecuteScalar()); } else { cmd.ExecuteNonQuery(); }
            if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                detailID = Convert.ToInt32(row.Cells["dgvproID"].Value);

                if (detailID == 0) //insert
                {
                    qry2 = @"insert into orders Values( @pID , @pQty ,  @pAmount,@detID ";
                }

                else
                {
                    qry2 = @"update  tblDetails set  pID = @proID , pQty = @qty ,  amount = @amount";

                }


                SqlCommand cmd2 = new SqlCommand(qry2, MainClass.con);
                cmd2.Parameters.AddWithValue("@ID", detailID);
                cmd2.Parameters.AddWithValue("@pID", Convert.ToInt32(row.Cells["dgvproID"].Value));
                //cmd.Parameters.AddWithValue("(@proID", );
               cmd2.Parameters.AddWithValue("@pqty", Convert.ToInt32(row.Cells["dgvQty"].Value));
               // cmd.Parameters.AddWithValue("@priec", Convert.ToDouble(row.Cells["dgvPrice"].Value));
                cmd2.Parameters.AddWithValue("@amount", Convert.ToDouble(row.Cells["dgvQty"].Value));
                cmd2.Parameters.AddWithValue("@detID", MainID);


                if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
                //cmd2.ExecuteNonQuery();
                if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }


                //msg--->saved successfully
                MessageBox.Show("Saved Successfuly..");
                MainID = 0;
                detailID = 0;
               // dataGridView1.Rows.Clear();
                lblTable.Text = "";
                lblWaiter.Text = "";
                lblTable.Visible = false;
                lblWaiter.Visible = false;
                MainID = 0;
                //lblTotal.Text = "00";
                lblDriverName.Text = "";
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
                e.Graphics.DrawImage(bm, 0, 0) ;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmrecpcs frm = new frmrecpcs();
            frm.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //label2.Text = 

        }

        private void userName_TextChanged(object sender, EventArgs e)
        {
           // userName.Text= MainClass.USER; ;
        }
    }
}