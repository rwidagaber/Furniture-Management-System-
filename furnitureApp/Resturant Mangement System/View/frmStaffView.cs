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
    public partial class frmStaffView : SampleView
    {
        public frmStaffView()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            string qry = "Select * from staff where sName like '%" + txtSearch.Text + "%' ";
            ListBox listBox = new ListBox();
            listBox.Items.Add(dgvid);
            listBox.Items.Add(dgvName);
            listBox.Items.Add(dgvPhone);
            listBox.Items.Add(dgvRole);
            listBox.Items.Add(dgvusername);
            listBox.Items.Add(dgvPassword);


            MainClass.LoadData(qry, staffView, listBox);
        }

        private void frmStaffView_Load(object sender, EventArgs e)
        {
            GetData();
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            frmStaffAdd frm = new frmStaffAdd();
            frm.ShowDialog();
            GetData();
        }
        private void staffView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (staffView.CurrentCell.OwningColumn.Name == "dgvedit")
            {
                frmStaffAdd frm = new frmStaffAdd();
                frm.id = Convert.ToInt32(staffView.CurrentRow.Cells["dgvid"].Value);
                frm.txtstaffName.Text = Convert.ToString(staffView.CurrentRow.Cells["dgvName"].Value);
                frm.txtPhone.Text = Convert.ToString(staffView.CurrentRow.Cells["dgvPhone"].Value);
                frm.txtPhone.Text = Convert.ToString(staffView.CurrentRow.Cells["dgvusername"].Value);
                frm.txtPhone.Text = Convert.ToString(staffView.CurrentRow.Cells["dgvPassword"].Value);
                frm.cbRole.Text = Convert.ToString(staffView.CurrentRow.Cells["dgvRole"].Value);
                frm.ShowDialog();
                GetData();
            }
            else if (staffView.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                if (MessageBox.Show("Are you sure to delete this person? ", "Warnnig", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int iD = Convert.ToInt32(staffView.CurrentRow.Cells["dgvid"].Value);
                    string qry = "Delete from staff where staffID= " + iD + "";
                    Hashtable ht = new Hashtable();
                    MainClass.SQl(qry, ht);
                    MessageBox.Show("Person has been deleted Successfully..");
                    GetData();
                }
            }
        }
    }
}
