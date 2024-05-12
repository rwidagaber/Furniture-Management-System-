using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant_Mangement_System
{
    public partial class frmlog : Form
    {
        public frmlog()
        {
            InitializeComponent();
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            if (MainClass.IsValidUser(txtUserName.Text, txtpassword.Text) == false)
            {
                MessageBox.Show("Wrong Username or password");
                return;
            }
            else
            {
               //public string usg = txtUserName.Text;
                this.Hide();
                if (MainClass.IsManager(txtUserName.Text, txtpassword.Text) == false)
                {
                    Model.frmPOS frm = new Model.frmPOS();
                    frm.Show();

                }
                else if(MainClass.IsManager(txtUserName.Text, txtpassword.Text) == true)
                {
                    frmMain frm = new frmMain();
                    frm.Show();
                    //frmMain frm = new frmMain();
                    //frm.Show();
                    
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
