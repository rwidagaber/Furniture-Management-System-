using Microsoft.Win32;
using Resturant_Mangement_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant_Mangement_System
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maxmizebtn_Click(object sender, EventArgs e)
        {
            
        }

        private void HomeFrm_Load(object sender, EventArgs e)
        {
         //   Usernamelbl.Text = MainClass.USER;
        }

        private void HomeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Btn_setting(object sender, EventArgs e)
        {
            foreach (Control c in BtnPanel.Controls)
            {
                c.BackColor = Color.FromArgb(25,25,25);
                c.ForeColor = Color.White;
            }
            // click setting
            Control click=(Control)sender;
            click.BackColor = Color.FromArgb(255, 223, 0);
            click.ForeColor=Color.Black;
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            Btn_setting(HomeBtn, null);
            AddControl(new frmHome());
        }

        private void Categoriesbtn_Click(object sender, EventArgs e)
        {
            Btn_setting(Categoriesbtn, null);
            AddControl(new View.frmCategoryView());
        }

        private void Productsbtn_Click(object sender, EventArgs e)
        {
            Btn_setting(sender, null);
            AddControl(new View.frmProductView());
        }

        private void Tablesbtn_Click(object sender, EventArgs e)
        {
            Btn_setting(sender, null);
            AddControl(new View.frmTableView());
        }

        private void Staffbtn_Click(object sender, EventArgs e)
        {
            Btn_setting(sender, null);
            AddControl(new View.frmStaffView());
        }

        private void POSbtn_Click(object sender, EventArgs e)
        {
            frmPOS frm = new frmPOS();
            frm.ShowDialog();
            this.Hide();
            
        }

        private void Kitchenbtn_Click(object sender, EventArgs e)
        {
            Btn_setting(sender, null);
            AddControl(new View.frmKitchenView());
        }

        private void Reportsbtn_Click(object sender, EventArgs e)
        {
            Btn_setting(sender, null);
            AddControl(new View.frmReportView());

        }

        private void Settingbtn_Click(object sender, EventArgs e)
        {
            Btn_setting(sender, null);
        }


        // Add controls to main form
        public void AddControl(Form f)
        {
           CenterPanel.Controls.Clear();
            f.Dock= DockStyle.Fill;
            f.TopLevel = false;
            CenterPanel.Controls.Add(f);
            f.Show();

        }

        private void CenterPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //frmlog frm = new frmlog();
            //frm.Show();

        }
    }
}
