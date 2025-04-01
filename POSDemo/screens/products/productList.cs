using POSDemo.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace POSDemo.screens.products
{
    public partial class productList : Form
    {
        POSTutEntities2 db = new POSTutEntities2();
        int id;
        
       string imgpath;
        public productList()
        {
            InitializeComponent();
            dataGridView1.DataSource = db.Products.ToList();
        }

        private void productList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOSTutDataSet.Products' table. You can move, or remove it, as needed.

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            par.Text = "";
            productname.Text = "";
            productnote.Text = "";
            productprice.Text = "";
            productquantity.Text = "";
            productimg.ImageLocation = "";
                
            if (productname.Text=="")
            dataGridView1.DataSource=db.Products.Where(x=>x.code== txtcode.Text).ToList(); 
            else
             dataGridView1.DataSource=db.Products.Where(x=>x.name==productname.Text || x.code==txtcode.Text).ToList(); 
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.ToList();
        }

       

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

                id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    
                var result = db.Products.SingleOrDefault(x => x.id == id);
                if (result != null)
                {
                    par.Text = result.code;
                    productname.Text = result.name;
                    productnote.Text = result.note;
                    productquantity.Text = result.quantity.ToString();
                    productprice.Text = result.price.ToString();
                    productimg.ImageLocation = result.image;
                }
                else
                {

                }
                       
            }
            catch 
            {
                
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
           
                var result = db.Products.SingleOrDefault(x => x.id == id);
                result.code = par.Text;
                result.name = productname.Text;
                result.note = productnote.Text;
                result.price = decimal.Parse(productprice.Text);
                result.quantity = int.Parse(productquantity.Text);
                result.image = imgpath;
                string newpath;
                if (result.image != null)
                {
                    newpath = Environment.CurrentDirectory + "//images//products//" + result.id + ".jpg";
                    //true to make override , if theres image update it to new image .
                    File.Copy(imgpath, newpath, true);
                    result.image = newpath;
                }
                db.SaveChanges();
                MessageBox.Show("تم التعديل ");
                dataGridView1.DataSource = db.Products.ToList();
           

        }

        private void productimg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog(); 
           if(dialog.ShowDialog() == DialogResult.OK)
            {
                productimg.ImageLocation=dialog.FileName;
                imgpath=dialog.FileName;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
          var r=  MessageBox.Show("هل تريد الحذف ؟", "تاكيد الحذف ", MessageBoxButtons.OKCancel);
            try
            {
                if (r == DialogResult.OK)
                {
                    var result = db.Products.Find(id);
                    db.Products.Remove(result);
                    db.SaveChanges();
                    MessageBox.Show("تم الحذف");
                    dataGridView1.DataSource = db.Products.ToList();
                }
            }
            catch
            {
                MessageBox.Show("لا يمكنك الحذف من قائمة فارغة ");
            }
           
            


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void productname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            products product = new products ();
            product.Show();
        }
    }
}
