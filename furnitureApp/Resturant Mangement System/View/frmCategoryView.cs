using Resturant_Mangement_System.Model;
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

namespace Resturant_Mangement_System.View
{
    public partial class frmCategoryView : SampleView
    {
        public frmCategoryView()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            string qry = "Select * from category where catName like '%"+txtSearch.Text+"%' ";
            ListBox listBox = new ListBox();
            listBox.Items.Add(dgvid);
            listBox.Items.Add(dgvName);

            MainClass.LoadData(qry, categoryView,listBox); 
        }

        private void frmCategoryView_Load(object sender, EventArgs e)
        {
            GetData();
        }
        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            frmCategoryAdd frm = new frmCategoryAdd();
            frm.ShowDialog();
            GetData();
        }


        private void categoryView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (categoryView.CurrentCell.OwningColumn.Name == "dgvedit")
            {
                frmCategoryAdd frm=new frmCategoryAdd();
                frm.id = Convert.ToInt32(categoryView.CurrentRow.Cells["dgvid"].Value);
                frm.txtCatName.Text= Convert.ToString(categoryView.CurrentRow.Cells["dgvName"].Value);
                frm.ShowDialog();
                GetData();
            }
            else if(categoryView.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                if (MessageBox.Show("Are you sure to delete this category? ", "Warnnig", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int iD = Convert.ToInt32(categoryView.CurrentRow.Cells["dgvid"].Value);
                    string qry = "Delete from category where catID= " + iD + "";
                    Hashtable ht = new Hashtable();
                    MainClass.SQl(qry, ht);
                    MessageBox.Show("Category has been deleted Successfully..");
                    GetData();
                }
            }
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Bitmap bm = new Bitmap(this.categoryView.Width, this.categoryView.Height);
            //categoryView.DrawToBitmap(bm, new Rectangle(0, 0, this.categoryView.Width, this.categoryView.Height));
            //e.Graphics.DrawImage(bm, 0, 0);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //printDocument1_PrintPage(sender, printD
        }
    }
}
