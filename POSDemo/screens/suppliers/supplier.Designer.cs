using POSDemo.DB;

namespace POSDemo.screens.suppliers
{
    partial class supplier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(supplier));
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.searchphone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchname = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.semail = new System.Windows.Forms.TextBox();
            this.scompany = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customercompany = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.customeradress = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.sphone = new System.Windows.Forms.TextBox();
            this.sadress = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.Label();
            this.supplierimg = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sname = new System.Windows.Forms.TextBox();
            this.customername = new System.Windows.Forms.Label();
            this.pOSTutDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSTutDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(854, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 63;
            this.label1.Text = "رقم المورد";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(314, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 34);
            this.button2.TabIndex = 62;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 34);
            this.button1.TabIndex = 61;
            this.button1.Text = "بحث";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchphone
            // 
            this.searchphone.Location = new System.Drawing.Point(722, 23);
            this.searchphone.Multiline = true;
            this.searchphone.Name = "searchphone";
            this.searchphone.Size = new System.Drawing.Size(126, 38);
            this.searchphone.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(605, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 29);
            this.label2.TabIndex = 65;
            this.label2.Text = "اسم المورد";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            // 
            // pOSTutDataSet
            // 
           
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 97);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(429, 484);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // searchname
            // 
            this.searchname.Location = new System.Drawing.Point(445, 23);
            this.searchname.Multiline = true;
            this.searchname.Name = "searchname";
            this.searchname.Size = new System.Drawing.Size(150, 38);
            this.searchname.TabIndex = 66;
            // 
            // productsTableAdapter
            // 
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.Location = new System.Drawing.Point(239, 428);
            this.button8.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(34, 39);
            this.button8.TabIndex = 58;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(25, 428);
            this.button7.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(215, 39);
            this.button7.TabIndex = 57;
            this.button7.Text = "اضافة مورد  جديد ";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(599, 367);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(62, 20);
            this.checkBox2.TabIndex = 56;
            this.checkBox2.Text = "نشط ؟ ";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // semail
            // 
            this.semail.Location = new System.Drawing.Point(302, 309);
            this.semail.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.semail.Multiline = true;
            this.semail.Name = "semail";
            this.semail.Size = new System.Drawing.Size(229, 41);
            this.semail.TabIndex = 55;
            // 
            // scompany
            // 
            this.scompany.Location = new System.Drawing.Point(353, 226);
            this.scompany.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.scompany.Multiline = true;
            this.scompany.Name = "scompany";
            this.scompany.Size = new System.Drawing.Size(229, 41);
            this.scompany.TabIndex = 54;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(543, 309);
            this.email.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(155, 29);
            this.email.TabIndex = 53;
            this.email.Text = "البريد الالكتروني";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.semail);
            this.groupBox1.Controls.Add(this.scompany);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.customercompany);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.customeradress);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.sphone);
            this.groupBox1.Controls.Add(this.sadress);
            this.groupBox1.Controls.Add(this.phone);
            this.groupBox1.Controls.Add(this.supplierimg);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.sname);
            this.groupBox1.Controls.Add(this.customername);
            this.groupBox1.Location = new System.Drawing.Point(436, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 484);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "update";
            // 
            // customercompany
            // 
            this.customercompany.AutoSize = true;
            this.customercompany.BackColor = System.Drawing.Color.Transparent;
            this.customercompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customercompany.Location = new System.Drawing.Point(603, 226);
            this.customercompany.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.customercompany.Name = "customercompany";
            this.customercompany.Size = new System.Drawing.Size(70, 29);
            this.customercompany.TabIndex = 52;
            this.customercompany.Text = "الشركة";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(234, 136);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 29);
            this.label7.TabIndex = 48;
            this.label7.Text = "الصورة ";
            // 
            // customeradress
            // 
            this.customeradress.AutoSize = true;
            this.customeradress.BackColor = System.Drawing.Color.Transparent;
            this.customeradress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customeradress.Location = new System.Drawing.Point(594, 153);
            this.customeradress.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.customeradress.Name = "customeradress";
            this.customeradress.Size = new System.Drawing.Size(79, 29);
            this.customeradress.TabIndex = 43;
            this.customeradress.Text = "العنوان ";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.Location = new System.Drawing.Point(99, 380);
            this.button6.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(37, 42);
            this.button6.TabIndex = 50;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Location = new System.Drawing.Point(239, 383);
            this.button4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(34, 39);
            this.button4.TabIndex = 41;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(148, 383);
            this.button3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 39);
            this.button3.TabIndex = 42;
            this.button3.Text = "تعديل";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(9, 380);
            this.button5.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 42);
            this.button5.TabIndex = 49;
            this.button5.Text = "حذف";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // sphone
            // 
            this.sphone.Location = new System.Drawing.Point(18, 73);
            this.sphone.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.sphone.Multiline = true;
            this.sphone.Name = "sphone";
            this.sphone.Size = new System.Drawing.Size(204, 41);
            this.sphone.TabIndex = 46;
            // 
            // sadress
            // 
            this.sadress.Location = new System.Drawing.Point(353, 153);
            this.sadress.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.sadress.Multiline = true;
            this.sadress.Name = "sadress";
            this.sadress.Size = new System.Drawing.Size(229, 41);
            this.sadress.TabIndex = 44;
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.BackColor = System.Drawing.Color.Transparent;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(234, 78);
            this.phone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(111, 29);
            this.phone.TabIndex = 39;
            this.phone.Text = "رقم التلفون ";
            // 
            // supplierimg
            // 
            this.supplierimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.supplierimg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.supplierimg.Location = new System.Drawing.Point(9, 124);
            this.supplierimg.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.supplierimg.Name = "supplierimg";
            this.supplierimg.Size = new System.Drawing.Size(213, 214);
            this.supplierimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.supplierimg.TabIndex = 40;
            this.supplierimg.TabStop = false;
            this.supplierimg.Click += new System.EventHandler(this.supplierimg_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(388, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 32);
            this.label5.TabIndex = 38;
            this.label5.Text = "الموردون";
            // 
            // sname
            // 
            this.sname.Location = new System.Drawing.Point(353, 85);
            this.sname.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.sname.Multiline = true;
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(229, 41);
            this.sname.TabIndex = 37;
            // 
            // customername
            // 
            this.customername.AutoSize = true;
            this.customername.BackColor = System.Drawing.Color.Transparent;
            this.customername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customername.Location = new System.Drawing.Point(589, 94);
            this.customername.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.customername.Name = "customername";
            this.customername.Size = new System.Drawing.Size(102, 29);
            this.customername.TabIndex = 35;
            this.customername.Text = "اسم المورد";
            // 
            // pOSTutDataSetBindingSource
            // 
            this.pOSTutDataSetBindingSource.Position = 0;
            // 
            // supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1134, 604);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchphone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchname);
            this.Controls.Add(this.groupBox1);
            this.Name = "supplier";
            this.Text = "supplier";
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSTutDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox searchphone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private POSTutDataSet pOSTutDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox searchname;
        private DB.POSTutDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox semail;
        private System.Windows.Forms.TextBox scompany;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label customercompany;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label customeradress;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox sphone;
        private System.Windows.Forms.TextBox sadress;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.PictureBox supplierimg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sname;
        private System.Windows.Forms.Label customername;
        private System.Windows.Forms.BindingSource pOSTutDataSetBindingSource;
    }
}