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
    public partial class frmStaffAdd : SampleAdd
    {
        public frmStaffAdd()
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
                qry = "Insert into staff Values(@Name,@Phone,@Role,@Username,@Password)";
            }
            //Update category
            else
            {
                qry = "Update staff Set sName = @Name,sPhone = @Phone, sRole=@Role,username=@Username,userPass=@Password where staffID= @id";

            }
            Hashtable hashtable = new Hashtable();
            hashtable.Add("@id", id);
            hashtable.Add("@Name", txtstaffName.Text);
            hashtable.Add("@Phone", txtPhone.Text);
            hashtable.Add("@Role", cbRole.Text);
            hashtable.Add("@Username", txtUsername.Text);
            hashtable.Add("@Password",txtPass.Text);

            if (MainClass.SQl(qry, hashtable) > 0)
            {
                MessageBox.Show("Saved Successfuly..");
                id = 0;
                txtstaffName.Text = "";
                txtstaffName.Focus();
                txtUsername.Text = "";
                txtUsername.Focus();
                cbRole.SelectedIndex = -1;
                cbRole.Focus();
            }
        }

       
    }
   
}
