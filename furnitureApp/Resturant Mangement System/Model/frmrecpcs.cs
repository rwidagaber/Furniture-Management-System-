//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

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
using PagedList;

namespace Resturant_Mangement_System.Model
{
    public partial class frmrecpcs : Form
    {
        public frmrecpcs()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT TOP 1 * FROM orderDetail ORDER BY oID DESC";
            using (MainClass.con )
            {
                SqlCommand command = new SqlCommand(query, MainClass.con);
                MainClass.con.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dgvRec.DataSource = dataTable;
                }
            }
        }

        Bitmap bm;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            int height = dgvRec.Height;
            
            bm = new Bitmap(this.dgvRec.Width*10, this.dgvRec.Height*20);
            dgvRec.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvRec.Width, this.dgvRec.Height));
            dgvRec.Height = height;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

