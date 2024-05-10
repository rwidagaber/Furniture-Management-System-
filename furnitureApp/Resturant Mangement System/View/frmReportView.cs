using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant_Mangement_System.View
{
    public partial class frmReportView : Form
    {
        public frmReportView()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            string qry = @"select * from products" ;
            SqlCommand cmd= new SqlCommand(qry,MainClass.con);
            MainClass.con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.Fill(dt);
            MainClass.con.Close();
           // frmprint frm = new frmprint();
            
            


           
        }
    }
}
