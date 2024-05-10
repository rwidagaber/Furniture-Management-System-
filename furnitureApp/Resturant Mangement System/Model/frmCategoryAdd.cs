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

namespace Resturant_Mangement_System.Model
{
    public partial class frmCategoryAdd : SampleAdd
    {
        public frmCategoryAdd()
        {
            InitializeComponent();
        }

        private void frmCategoryAdd_Load(object sender, EventArgs e)
        {
            this.Visible = true;
        }
        public int id = 0;
        public override void btnSave_Click(object sender, EventArgs e)
        {
            string qry = "";
            //insert category
            if(id == 0)
            {
                qry = "Insert into category Values(@Name)";
            }
            //Update category
            else
            {
                qry = "Update category Set catName = @Name where catID= @id";

            }
            Hashtable hashtable = new Hashtable();
            hashtable.Add("@id", id);
            hashtable.Add("@Name", txtCatName.Text);
            if(MainClass.SQl(qry, hashtable) > 0)
            {
                MessageBox.Show("Saved Successfuly..");
                id = 0;
                txtCatName.Text = "";
                txtCatName.Focus();
            }
        }

        private void txtCatName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
