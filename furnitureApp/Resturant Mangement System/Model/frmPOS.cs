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
            frmlog frm = new frmlog();
            frmMain fm = new frmMain();
            if (MainClass.IsManager(frm.txtUserName.Text,frm.txtpassword.Text))
            {
                this.Close();
               // this.Hide();
                fm.Show();
                
            }
           else this.Close();


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
           
        }

        
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            frmCheckout frm = new frmCheckout();
            
            frm.oID = id;
            frm.amt = Convert.ToDouble(lblTotal.Text);
            frm.ShowDialog();
            MainID = 0;
           
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmrecpcs frm = new frmrecpcs();
            frm.ShowDialog();
        }

        
    }
}