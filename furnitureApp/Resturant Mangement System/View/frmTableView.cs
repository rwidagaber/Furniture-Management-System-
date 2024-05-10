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
    public partial class frmTableView : SampleView
    {
        public frmTableView()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            string qry = "Select * from tables where tName like '%" + txtSearch.Text + "%' ";
            ListBox listBox = new ListBox();
            listBox.Items.Add(dgvid);
            listBox.Items.Add(dgvName);

            MainClass.LoadData(qry, tablesView, listBox);
        }

        
        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            frmTableAdd frm = new frmTableAdd();
            frm.ShowDialog();
            GetData();
        }


      

        private void frmTableView_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void tablesView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablesView.CurrentCell.OwningColumn.Name == "dgvedit")
            {
                frmTableAdd frm = new frmTableAdd();
                frm.id = Convert.ToInt32(tablesView.CurrentRow.Cells["dgvid"].Value);
                frm.txttableName.Text = Convert.ToString(tablesView.CurrentRow.Cells["dgvName"].Value);
                frm.ShowDialog();
                GetData();
            }
            else if (tablesView.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                if (MessageBox.Show("Are you sure to delete this table? ", "Warnnig", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int iD = Convert.ToInt32(tablesView.CurrentRow.Cells["dgvid"].Value);
                    string qry = "Delete from tables where tId= " + iD + "";
                    Hashtable ht = new Hashtable();
                    MainClass.SQl(qry, ht);
                    MessageBox.Show("Table has been deleted Successfully..");
                    GetData();
                }
            }
        }
    }

}
