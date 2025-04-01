namespace POSDemo.screens.products
{
    partial class productList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productList));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.pOSTutDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.productquantity = new System.Windows.Forms.TextBox();
            this.productnote = new System.Windows.Forms.TextBox();
            this.productprice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.productimg = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.productname = new System.Windows.Forms.TextBox();
            this.par = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSTutDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productimg)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 88);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(407, 407);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // pOSTutDataSet
            // 
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            // 
            // productsTableAdapter
            // 
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "بحث";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(303, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 34);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(843, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "كود المنتج ";
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(711, 14);
            this.txtcode.Multiline = true;
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(126, 38);
            this.txtcode.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(594, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "اسم المنتج ";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(434, 14);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(150, 38);
            this.name.TabIndex = 6;
            // 
            // pOSTutDataSetBindingSource
            // 
            this.pOSTutDataSetBindingSource.Position = 0;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(570, 283);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 29);
            this.label6.TabIndex = 47;
            this.label6.Text = "ملاحظات ";
            // 
            // productquantity
            // 
            this.productquantity.Location = new System.Drawing.Point(18, 73);
            this.productquantity.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.productquantity.Multiline = true;
            this.productquantity.Name = "productquantity";
            this.productquantity.Size = new System.Drawing.Size(204, 41);
            this.productquantity.TabIndex = 46;
            // 
            // productnote
            // 
            this.productnote.Location = new System.Drawing.Point(325, 237);
            this.productnote.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.productnote.Multiline = true;
            this.productnote.Name = "productnote";
            this.productnote.Size = new System.Drawing.Size(229, 101);
            this.productnote.TabIndex = 45;
            // 
            // productprice
            // 
            this.productprice.Location = new System.Drawing.Point(325, 182);
            this.productprice.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.productprice.Multiline = true;
            this.productprice.Name = "productprice";
            this.productprice.Size = new System.Drawing.Size(229, 41);
            this.productprice.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(554, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 29);
            this.label3.TabIndex = 43;
            this.label3.Text = "سعر المنتج ";
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(148, 348);
            this.button3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 39);
            this.button3.TabIndex = 42;
            this.button3.Text = "تعديل";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Location = new System.Drawing.Point(239, 348);
            this.button4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(34, 39);
            this.button4.TabIndex = 41;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // productimg
            // 
            this.productimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.productimg.Location = new System.Drawing.Point(9, 124);
            this.productimg.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.productimg.Name = "productimg";
            this.productimg.Size = new System.Drawing.Size(213, 214);
            this.productimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.productimg.TabIndex = 40;
            this.productimg.TabStop = false;
            this.productimg.Click += new System.EventHandler(this.productimg_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(234, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 29);
            this.label4.TabIndex = 39;
            this.label4.Text = "الكمية ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(366, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 32);
            this.label5.TabIndex = 38;
            this.label5.Text = "تعديل منتج";
            // 
            // productname
            // 
            this.productname.Location = new System.Drawing.Point(325, 131);
            this.productname.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.productname.Multiline = true;
            this.productname.Name = "productname";
            this.productname.Size = new System.Drawing.Size(229, 41);
            this.productname.TabIndex = 37;
            this.productname.TextChanged += new System.EventHandler(this.productname_TextChanged);
            // 
            // par
            // 
            this.par.Location = new System.Drawing.Point(325, 66);
            this.par.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.par.Multiline = true;
            this.par.Name = "par";
            this.par.Size = new System.Drawing.Size(229, 41);
            this.par.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(568, 136);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 29);
            this.label11.TabIndex = 35;
            this.label11.Text = "اسم المنتج";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(566, 73);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 29);
            this.label12.TabIndex = 34;
            this.label12.Text = "الباركورد ";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(9, 348);
            this.button5.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 42);
            this.button5.TabIndex = 49;
            this.button5.Text = "حذف";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.Location = new System.Drawing.Point(99, 348);
            this.button6.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(37, 42);
            this.button6.TabIndex = 50;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.productnote);
            this.groupBox1.Controls.Add(this.productquantity);
            this.groupBox1.Controls.Add(this.productprice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.productimg);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.productname);
            this.groupBox1.Controls.Add(this.par);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(425, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 407);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "update";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(514, 11);
            this.button7.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(149, 39);
            this.button7.TabIndex = 51;
            this.button7.Text = "اضافة منتج جديد ";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // productList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1103, 529);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "productList";
            this.Text = "productList";
            this.Load += new System.EventHandler(this.productList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSTutDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productimg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.BindingSource pOSTutDataSetBindingSource;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox productquantity;
        private System.Windows.Forms.TextBox productnote;
        private System.Windows.Forms.TextBox productprice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox productimg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox productname;
        private System.Windows.Forms.TextBox par;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button7;
    }
}