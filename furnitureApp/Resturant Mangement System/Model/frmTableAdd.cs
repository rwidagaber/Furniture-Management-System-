using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant_Mangement_System.Model
{
    public partial class frmTableAdd : SampleAdd
    {
        public frmTableAdd()
        {
            InitializeComponent();
        }
        public int id = 0;

        public override void btnSave_Click(object sender, EventArgs e)
        {
            string qry = "";
            //insert category
            if (id == 0)
            {
                qry = "Insert into tables Values(@Name)";
            }
            //Update category
            else
            {
                qry = "Update tables Set tName = @Name where tId= @id";

            }
            Hashtable hashtable = new Hashtable();
            hashtable.Add("@id", id);
            hashtable.Add("@Name", txttableName.Text);
            if (MainClass.SQl(qry, hashtable) > 0)
            {
                MessageBox.Show("Saved Successfuly..");
                id = 0;
                txttableName.Text = "";
                txttableName.Focus();
            }
        }
    }
}
