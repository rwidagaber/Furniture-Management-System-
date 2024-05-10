using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;

namespace Resturant_Mangement_System.Model
{
    public partial class frmBillList : SampleAdd
    {
        public frmBillList()
        {
            InitializeComponent();
        }


        public int MainID = 0;
        private void frmBillList_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            //copy from frmproductView----->

            string qry = @"select oID,custNamecashierName,orderType,status,total from tblMain
                           where status <> 'Pending' ";

            ListBox lb = new ListBox();

            lb.Items.Add(dgvid);
            lb.Items.Add(dgvtable);
           // lb.Items.Add(dgvWaiter);
            lb.Items.Add(dgvType);
            lb.Items.Add(dgvStatus);
            lb.Items.Add(dgvTotal);


            MainClass.LoadData(qry, dataGridView1, lb);


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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
            {
                //this is change as we have to set from text propirtes before open
                MainID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvid"].Value);
                this.Close();
            }
            else if (dataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                //print bill
                MainID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvid"].Value);
                string qry = @"select * from tblMain m inner join 
                            tblDetails d on m.MainID=d.MainID inner join product p on p.PID = d.proID where m.MainID= "+MainID+"";
                
                SqlCommand cmd = new SqlCommand(qry,MainClass.con);
                MainClass.con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dt);
                MainClass.con.Close();
                frmPrint frm=new frmPrint();
                
            }
        }
    }
}
