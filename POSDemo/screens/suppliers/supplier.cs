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

namespace POSDemo.screens.suppliers
{
    public partial class supplier : Form
    {
        POSTutEntities2 db = new POSTutEntities2();
        string imgpath = "";
        int id=1;

        public supplier()
        {
            InitializeComponent();
            dataGridView1.DataSource = db.Suppliers.ToList();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();
            var r = MessageBox.Show("عملية الاضافة", "هل انت متاكد من انك ستقوم باضافة مورد جديد؟", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                supplier.name = sname.Text;
                supplier.phone = sphone.Text;
                supplier.email = semail.Text;
                supplier.company = scompany.Text;
                supplier.adress = sadress.Text;
                supplier.isActive = checkBox2.Checked;
                supplier.image = imgpath;

                if (!string.IsNullOrEmpty(sname.Text) && !string.IsNullOrEmpty(sphone.Text))
                {
                    db.Suppliers.Add(supplier);
                    db.SaveChanges();

                    if (!string.IsNullOrEmpty(imgpath) && File.Exists(imgpath))
                    {
                        string newpath = Path.Combine(Environment.CurrentDirectory, "images", "suppliers", supplier.id + ".jpg");
                        File.Copy(imgpath, newpath);
                        supplier.image = newpath;
                    }

                    db.SaveChanges();
                    MessageBox.Show("تمت عملية الاضافة بنجاح");
                    dataGridView1.DataSource = db.Suppliers.ToList();
                    ResetFields();
                }
                else
                {
                    MessageBox.Show("قم بادخال بيانات صحيحة");
                }
            }
        }

        private void supplierimg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialoge = new OpenFileDialog();
            if (dialoge.ShowDialog() == DialogResult.OK)
            {
                supplierimg.ImageLocation = dialoge.FileName;
                imgpath = dialoge.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            
                var result = db.Suppliers.SingleOrDefault(x => x.id == id);
                if (result != null)
                {
                    result.name = sname.Text;
                    result.phone = sphone.Text;
                    result.email = semail.Text;
                    result.company = scompany.Text;
                    result.adress = sadress.Text;
                    result.isActive = checkBox2.Checked;

                    if (!string.IsNullOrEmpty(imgpath) && File.Exists(imgpath))
                    {
                        string newpath = Path.Combine(Environment.CurrentDirectory, "images", "suppliers", result.id + ".jpg");
                        File.Copy(imgpath, newpath, true);
                        result.image = newpath;
                    }

                    if (!string.IsNullOrEmpty(sname.Text) && !string.IsNullOrEmpty(sphone.Text))
                    {
                        db.SaveChanges();
                        MessageBox.Show("تم التعديل بنجاح");
                        dataGridView1.DataSource = db.Suppliers.ToList();
                    }
                    else
                    {
                        MessageBox.Show("تاكد من اضافة بيانات صحيحة");
                    }
                
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (int.TryParse(dataGridView1.CurrentRow.Cells[0].Value.ToString(), out id))
            {
                var result = db.Suppliers.SingleOrDefault(x => x.id == id);
                if (result != null)
                {
                    sname.Text = result.name;
                    sphone.Text = result.phone;
                    semail.Text = result.email;
                    scompany.Text = result.company;
                    sadress.Text = result.adress;
                    checkBox2.Checked =(bool) result.isActive;

                    if (!string.IsNullOrEmpty(result.image) && File.Exists(result.image))
                    {
                        supplierimg.ImageLocation = result.image;
                    }
                    else
                    {
                        supplierimg.ImageLocation = null;
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("هل تريد الحذف", "هل انت متاكد من عملية الحذف هذه؟", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                var result = db.Suppliers.Find(id);
                if (result != null)
                {
                    db.Suppliers.Remove(result);
                    db.SaveChanges();
                    dataGridView1.DataSource = db.Suppliers.ToList();
                }
            }
        }

        private void ResetFields()
        {
            sname.Text = "";
            sphone.Text = "";
            semail.Text = "";
            scompany.Text = "";
            sadress.Text = "";
            supplierimg.ImageLocation = "";
            checkBox2.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchname.Text))
               dataGridView1.DataSource= db.Suppliers.Where(x => x.phone == searchphone.Text).ToList();
            
            else
                dataGridView1.DataSource = db.Suppliers.Where(x => x.phone == searchphone.Text || x.name==searchname.Text).ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Suppliers.ToList();
        }
    }
}

