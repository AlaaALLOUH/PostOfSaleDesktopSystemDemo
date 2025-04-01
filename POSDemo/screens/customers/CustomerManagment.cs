using POSDemo.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSDemo.screens.customers
{
    public partial class CustomerManagment : Form
    {
        POSTutEntities2 db = new POSTutEntities2();
        string imgpath = "";
        int id;
        public CustomerManagment()
        {
            InitializeComponent();
            dataGridView1.DataSource = db.Customers.ToList();

        }

        private void CustomerManagment_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            var r = MessageBox.Show("اضافة عميل جديد ", " هل انت متاكد من عملية الاضافة ", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                Customer customer = new Customer();
                if (!string.IsNullOrEmpty(cname.Text) || !string.IsNullOrEmpty(cphone.Text))
                {

                    var existphone = db.Customers.Where(x => x.phone == cphone.Text).ToList();
                    if (existphone.Count() > 0)
                    {
                        MessageBox.Show("العميل موجود مسبقا ");
                    }
                    else
                    {

                        customer.name = cname.Text;
                        customer.phone = cphone.Text;

                        customer.email = cemail.Text;
                        customer.adress = cadress.Text;
                        customer.company = ccompany.Text;
                        customer.isActive = checkBox1.Checked;

                        customer.image = imgpath;

                        db.Customers.Add(customer);
                        db.SaveChanges();
                        MessageBox.Show("تم اضافة العميل بنجاح ");

                        dataGridView1.DataSource = db.Customers.ToList();
                        resetField();

                        if (!string.IsNullOrEmpty(imgpath) && File.Exists(imgpath))
                        {
                            string newpath = Environment.CurrentDirectory + "\\images\\customers\\" + customer.id + ".jpg";
                            File.Copy(imgpath, newpath);
                            customer.image = newpath;
                            db.SaveChanges();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("الرجائ ادخال البيانات الصحيحة ");
                }

            }

        
        }

        private void productimg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                customerimg.ImageLocation = dialog.FileName;
                imgpath = dialog.FileName;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcustomer.Text))
            {
                dataGridView1.DataSource = db.Customers.Where(x => x.phone == txtphone.Text).ToList();
            }
            else
            {
                dataGridView1.DataSource = db.Customers.Where(x => x.phone == txtphone.Text || x.name.Contains(txtcustomer.Text)).ToList();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Customers.ToList();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           

            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                var result = db.Customers.SingleOrDefault(x => x.id == id);
            try
            {
                if (result != null)
                {

                    cname.Text = result.name;
                    cphone.Text = result.phone;
                    cemail.Text = result.email;
                    cadress.Text = result.adress;
                    ccompany.Text = result.company;
                    customerimg.ImageLocation = result.image;
                    checkBox1.Checked = (bool)result.isActive;
                    
                }
                else
                {

                }
            }

            catch { } 
           

          

        }

        private void button3_Click(object sender, EventArgs e)
        {
            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var result = db.Customers.SingleOrDefault(x => x.id == id);

            var r = MessageBox.Show("هل أنت متأكد من حفظ التعديل ", "هل تريد التعديل ", MessageBoxButtons.YesNo);
            if (r==DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(cname.Text) || !string.IsNullOrEmpty(cphone.Text))
                {

                    if (db.Customers.Where(x => x.phone == cphone.Text && x.id != id).ToList().Count() > 0)
                    {
                        MessageBox.Show("لايمكن تعديل رقم العميل   لرقم عميل  موجود مسبقا ");
                        return;
                    }

                    result.name = cname.Text;
                    result.phone = cphone.Text;
                    result.email = cemail.Text;
                    result.adress = cadress.Text;
                    result.company = ccompany.Text;
                    result.isActive = checkBox1.Checked;



                    if (!string.IsNullOrEmpty(imgpath) && File.Exists(imgpath))
                    {
                        string newpath = Environment.CurrentDirectory + "\\images\\customers\\" + result.id + ".jpg";
                        File.Copy(imgpath, newpath, true);
                        result.image = newpath;
                    }
                    if (!string.IsNullOrEmpty(cname.Text) && !string.IsNullOrEmpty(cphone.Text))
                    {
                        db.SaveChanges();
                        MessageBox.Show("تم التعديل بنجاح ");


                        dataGridView1.DataSource = db.Customers.ToList();

                        cname.Text = "";
                        cphone.Text = "";
                        cemail.Text = "";
                        cadress.Text = "";
                        ccompany.Text = "";
                        customerimg.ImageLocation = "";
                        checkBox1.Checked = false;
                    }
                }
            }

            else
            {
                MessageBox.Show("ادخل بيانات صحيحة");
            }
            }
        

        private void button5_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("هل تريد الحذف ", "هل أنت متاكد من عملية الحذف", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                var result = db.Customers.Find(id);
                db.Customers.Remove(result);
                db.SaveChanges();
                dataGridView1.DataSource = db.Customers.ToList();
            }
        }

        public void resetField()
        {
            cname.Text = "";
            cphone.Text = "";
            cemail.Text = "";
            cadress.Text = "";
            ccompany.Text = "";
            customerimg.ImageLocation = "";
            checkBox1.Checked = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void customeradress_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pOSTutDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void cphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void ccompany_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void customercompany_Click(object sender, EventArgs e)
        {

        }

        private void cadress_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cname_TextChanged(object sender, EventArgs e)
        {

        }

        private void customername_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtcustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void productsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}

        
        