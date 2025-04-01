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

namespace POSDemo.screens.products
{
   
    public partial class products : Form
    {
        POSTutEntities2 db = new POSTutEntities2();
        string imgpath="";

        public products()
        {
            InitializeComponent();
        }

        private void products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOSTutDataSet1.Category' table. You can move, or remove it, as needed.

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            if (productname.Text == "" || par.Text == " " || productprice.Text  == "")
            {
                MessageBox.Show("قم بادخال البيانات ");
            }
            else
            {
                product.name = productname.Text;
                product.code = par.Text;
                int price;
                int qt;
                int.TryParse (productprice.Text, out price); 
                int.TryParse(productquantity.Text, out qt); 
                product.price = price;
                product.quantity = qt;
                product.note = productnote.Text;
                product.image = imgpath;
                //join between products and category table
                product.CategoryId = int.Parse(comboBox1.SelectedValue.ToString());
                db.Products.Add(product);
                db.SaveChanges();
                MessageBox.Show("تم حفظ المنتج ");
                if (imgpath != "") { 
                    string newpath = Environment.CurrentDirectory + "\\images\\products\\" + product.id + ".jpg";
                    File.Copy(imgpath, newpath);
                    product.image = newpath;
                    db.SaveChanges();
                }
            }
            productname.Text = "";
            par.Text = "";
            productprice.Text = "";
            productquantity.Text = "";
            productnote.Text = "";
            productimg.ImageLocation = "";
        }

        private void productimg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                productimg.ImageLocation = dialog.FileName;
                imgpath = dialog.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            productList p =new productList (); 
            p.Show (); 
        }
    }
}
