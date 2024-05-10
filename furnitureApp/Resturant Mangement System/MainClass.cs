using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.SqlClient;
using System.Collections;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing;

namespace Resturant_Mangement_System
{
    internal class MainClass
    {
        //connect to database

        //   public static readonly string con_string = "Data Source=CAMELLIA;Initial Catalog=RMS;Integrated Security=True;TrustServerCertificate=True";
        public static readonly string con_string = "Data Source=RWIDA;Initial Catalog=furnture;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(con_string);

        //Methode to check user validation

        public static bool IsValidUser(string username, string password)
        {
            bool isValid = false;
            
            string qry = @"Select * from staff where username ='" + username + "' and upass ='" + password + "'";
            SqlCommand cmd = new SqlCommand(qry, con);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                isValid = true;
                USER = dt.Rows[0]["username"].ToString();

            }

           
            return isValid;
        }


        public static bool IsManager(string username, string password)
        {
            bool manger = false;
            string qry2 = @"Select * from staff where username ='" + username + "' and upass ='" + password + "' and sRole='manager'";
            SqlCommand cmd2 = new SqlCommand(qry2, con);
            DataTable dt2 = new DataTable();
            SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
            adapter2.Fill(dt2);

            if (dt2.Rows.Count>0)
            {
     
                manger = true;
                USER2 = dt2.Rows[0]["sRole"].ToString();

            }
            return manger;
        }

        public static string user2;
        public static string USER2
        {
            get { return user2; }
            private set { user2 = value; }
        }

        public static string user;
         public static string USER
        {
            get { return user; }
            private set { user = value; }
        } 

        //Curd operation 
        public static int SQl(string qry,Hashtable ht)
        {
            int res = 0;

            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;
                foreach(DictionaryEntry item in ht)
                {

                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                res = cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
            return res;
        }


        //loading data from database

        public static void LoadData(string qry,DataGridView gv,ListBox lb)
        {
            gv.CellFormatting += new DataGridViewCellFormattingEventHandler(gv_CellFormatting);
            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                for (int i = 0; i < lb.Items.Count; i++)
                {
                    string colNam1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[colNam1].DataPropertyName = dt.Columns[i].ToString();

                }
                gv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }

        }
        //For scr  
        private static void gv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            System.Windows.Forms.DataGridView gv = (System.Windows.Forms.DataGridView)sender;
            int cnt = 0;
            foreach (DataGridViewRow row in gv.Rows) {
                cnt++;
                row.Cells[0].Value = cnt;
            }

        }
        // for category comboBox
        public static void CBFill(String qry, ComboBox cb)
        {
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            cb.DisplayMember = "name";
            cb.ValueMember = "id";
            cb.DataSource = dataTable;
            cb.SelectedIndex = -1;

        }

    }
}
