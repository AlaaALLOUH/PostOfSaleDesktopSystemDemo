using POSDemo.DB;
using POSDemo.screens;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace POSDemo
{
    public partial class Form1 : Form
    {
        POSTutEntities2 db = new POSTutEntities2();

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           var result = db.Users.Where(x => x.UserName ==txtname.Text && x.password==txtpassword.Text).ToList();
            if (result.Count() > 0 && txtname.Text != ""&& txtpassword.Text!="")
            {
                this.Close();
                Thread th = new Thread(openfrm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                MessageBox.Show("Enter a valid username or password ");
                this.Close(); 
            }


           
        }

        void openfrm()
        {
            Application.Run(new main());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewUser u = new NewUser ();
            u.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
