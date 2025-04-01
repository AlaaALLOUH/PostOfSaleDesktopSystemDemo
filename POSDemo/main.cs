using POSDemo.screens;
using POSDemo.screens.customers;
using POSDemo.screens.products;
using POSDemo.screens.suppliers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSDemo
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void editProductToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            products product=new products();
            product.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewUser u = new NewUser();
            u.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            productList productlist = new productList();
            productlist.Show(); 
        }

        private void عرضكافةالمنتجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productList productList = new productList(); 
            productList.Show(); 
        }

        private void ادارةالموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supplier s = new supplier();
            s.Show();
        }

        private void اضافةعميلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerManagment c= new CustomerManagment();
            c.Show();
        }

        private void تToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerManagment c = new CustomerManagment();
            c.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerManagment c=new CustomerManagment(); 
            c.Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            supplier supplier = new supplier(); 
            supplier.Show(); 
        }
    }
}
