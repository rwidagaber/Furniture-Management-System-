using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant_Mangement_System.View
{
    public partial class frmProductAdd : SampleAdd
    {
        public frmProductAdd()
        {
            InitializeComponent();
        }
        public int id = 0;
        public int cID = 0;
        Byte[] imageByteArray;

        private void frmProductAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rMSDataSet3.category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter2.Fill(this.rMSDataSet3.category);


            if (cID > 0)
            {
                cbcat.SelectedValue=cID;
            }
            

        }
        public override void btnSave_Click(object sender, EventArgs e)
        {
            string qry = "";
            //insert category
            if (id == 0)
            {
                qry = "Insert into product Values(@Name,@Price,@cat,@img)";
            }
            //Update category
            else
            { 
                qry = "Update product Set pName = @Name,pPrice = @Price, categoryID=@cat , pImage=@image where pID= @id";

            }

            Hashtable hashtable = new Hashtable();
            hashtable.Add("@id", id);
            hashtable.Add("@Name", txtsproductName.Text);
            hashtable.Add("@Price", txtPrice.Text);
            hashtable.Add("@cat",Convert.ToInt32( cbcat.SelectedValue));

            Image img= new Bitmap(txtImage.Image);
            MemoryStream memoryStream = new MemoryStream();
            img.Save(memoryStream,System.Drawing.Imaging.ImageFormat.Png);
            imageByteArray = memoryStream.ToArray();
            hashtable.Add("@img", imageByteArray);



            if (MainClass.SQl(qry, hashtable) > 0)
            {
                MessageBox.Show("Saved Successfuly..");
                id = 0;
                cID = 0;
                txtsproductName.Text = "";
                txtsproductName.Focus();
                txtPrice.Text = "";
                txtPrice.Focus();
                cbcat.SelectedIndex = -1;
                cbcat.Focus();
            }
        }
      
        
        string filePath = "";
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "images(.jpg,.png)|* .png; *.jpg";
            if(ofd.ShowDialog() == DialogResult.OK) { 
                filePath = ofd.FileName;
                txtImage.Image = new Bitmap(filePath);


            }
        }
       /* private void ForUpdatelLoadData()
        {
            string qry = @"select * from product where pID= " + id + "";
            SqlCommand cmd=new SqlCommand(qry,MainClass.con);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if(dataTable.Rows.Count > 0)
            {
                txtsproductName.Text = dataTable.Rows[0]["pName"].ToString();
                txtPrice.Text= dataTable.Rows[0]["pPrice"].ToString();
                byte[] imageByteArray = (byte[])(dataTable.Rows[0]["pImage"]);
                txtImage.Image=Image.FromStream(new MemoryStream(imageByteArray));


            }
        }*/
    }
}
