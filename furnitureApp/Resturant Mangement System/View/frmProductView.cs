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
    public partial class frmProductView : SampleView
    {
        public frmProductView()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            string qry = "select pID,pName,pPrice,categoryID,c.catName,pImage from product p inner join category c on p.categoryID= c.catID where pName like '%" + txtSearch.Text + "%' ";
            ListBox listBox = new ListBox();
            listBox.Items.Add(dgvid);
            listBox.Items.Add(dgvName);
            listBox.Items.Add(dgvprice);
            listBox.Items.Add(dgvcatID);
            listBox.Items.Add(dgvcategory); 
            listBox.Items.Add(dgvimage);
            MainClass.LoadData(qry, productView, listBox);
        }

        private void frmProductView_Load(object sender, EventArgs e)
        {
            GetData();
        }
        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            frmProductAdd frm = new frmProductAdd();
            frm.ShowDialog();
            GetData();
        }

        private void productView_CellClick(object sender, DataGridViewCellEventArgs e)
        {   // to edit value
            if (productView.CurrentCell.OwningColumn.Name == "dgvedit")
            {
                frmProductAdd frm = new frmProductAdd();
                frm.id = Convert.ToInt32(productView.CurrentRow.Cells["dgvid"].Value);
                frm.cID= Convert.ToInt32(productView.CurrentRow.Cells["dgvcatID"].Value) ;
                frm.ShowDialog();
                GetData();
            }
            else if (productView.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                if (MessageBox.Show("Are you sure to delete this product? ", "Warnnig", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int iD = Convert.ToInt32(productView.CurrentRow.Cells["dgvid"].Value);
                    string qry = "Delete from product where pID= " + iD + "";
                    Hashtable ht = new Hashtable();
                    MainClass.SQl(qry, ht);
                    MessageBox.Show("Product has been deleted Successfully..");
                    GetData();
                }
            }
        }
    }
}
