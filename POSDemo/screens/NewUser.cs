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

namespace POSDemo.screens
{
    public partial class NewUser : Form
    {
        POSTutEntities2 db = new POSTutEntities2();
        string imagePath;

        public NewUser()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = dialog.FileName;
                imagePath = dialog.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User
                {
                    UserName = txtuser.Text,
                    password = txtpassword.Text
                };
                db.Users.Add(user);
                db.SaveChanges();
                string newPath = Environment.CurrentDirectory + "//images//Users//" + user.Id + ".jpg";
                File.Copy(imagePath, newPath);
                user.image = newPath;
                db.SaveChanges();
                MessageBox.Show("all Data successfully saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
