namespace MyShop
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listItems = new System.Windows.Forms.ListBox();
            this.TotalCost = new System.Windows.Forms.Button();
            this.CosGoo = new System.Windows.Forms.Label();
            this.OutputTotal = new System.Windows.Forms.Label();
            this.OutputProd = new System.Windows.Forms.Label();
            this.BoxGroup2 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AddItem = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.AddGrName = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listItems
            // 
            this.listItems.FormattingEnabled = true;
            this.listItems.Location = new System.Drawing.Point(7, 52);
            this.listItems.Name = "listItems";
            this.listItems.Size = new System.Drawing.Size(243, 264);
            this.listItems.TabIndex = 0;
            this.listItems.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // TotalCost
            // 
            this.TotalCost.Location = new System.Drawing.Point(5, 38);
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.Size = new System.Drawing.Size(56, 23);
            this.TotalCost.TabIndex = 5;
            this.TotalCost.Text = "Total";
            this.TotalCost.UseVisualStyleBackColor = true;
            this.TotalCost.Click += new System.EventHandler(this.button1_Click);
            // 
            // CosGoo
            // 
            this.CosGoo.AutoSize = true;
            this.CosGoo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.CosGoo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CosGoo.Location = new System.Drawing.Point(104, 18);
            this.CosGoo.Name = "CosGoo";
            this.CosGoo.Size = new System.Drawing.Size(36, 37);
            this.CosGoo.TabIndex = 8;
            this.CosGoo.Text = "0";
            this.CosGoo.Click += new System.EventHandler(this.CosGoo_Click);
            // 
            // OutputTotal
            // 
            this.OutputTotal.AutoSize = true;
            this.OutputTotal.Location = new System.Drawing.Point(18, 4);
            this.OutputTotal.Name = "OutputTotal";
            this.OutputTotal.Size = new System.Drawing.Size(0, 13);
            this.OutputTotal.TabIndex = 10;
            // 
            // OutputProd
            // 
            this.OutputProd.AutoSize = true;
            this.OutputProd.Location = new System.Drawing.Point(157, 4);
            this.OutputProd.Name = "OutputProd";
            this.OutputProd.Size = new System.Drawing.Size(0, 13);
            this.OutputProd.TabIndex = 11;
            // 
            // BoxGroup2
            // 
            this.BoxGroup2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxGroup2.FormattingEnabled = true;
            this.BoxGroup2.Location = new System.Drawing.Point(146, 22);
            this.BoxGroup2.Name = "BoxGroup2";
            this.BoxGroup2.Size = new System.Drawing.Size(111, 21);
            this.BoxGroup2.TabIndex = 23;
            this.BoxGroup2.SelectedIndexChanged += new System.EventHandler(this.BoxGroup2_SelectedIndexChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(146, 172);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(111, 20);
            this.textBox3.TabIndex = 22;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Size*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Price of goods*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Product Name*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Product group*";
            // 
            // AddItem
            // 
            this.AddItem.Location = new System.Drawing.Point(35, 206);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(222, 28);
            this.AddItem.TabIndex = 15;
            this.AddItem.Text = "Add item";
            this.AddItem.UseVisualStyleBackColor = true;
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Group name";
            // 
            // AddGrName
            // 
            this.AddGrName.Location = new System.Drawing.Point(31, 56);
            this.AddGrName.Name = "AddGrName";
            this.AddGrName.Size = new System.Drawing.Size(226, 28);
            this.AddGrName.TabIndex = 24;
            this.AddGrName.Text = "Add product";
            this.AddGrName.UseVisualStyleBackColor = true;
            this.AddGrName.Click += new System.EventHandler(this.AddGrName_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BoxGroup2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.AddItem);
            this.groupBox1.Location = new System.Drawing.Point(267, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 235);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add item";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(146, 60);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(111, 21);
            this.textBox2.TabIndex = 33;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 98);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(111, 21);
            this.textBox1.TabIndex = 32;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(146, 135);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(111, 21);
            this.comboBox3.TabIndex = 28;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Product description";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.AddGrName);
            this.groupBox2.Location = new System.Drawing.Point(267, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 92);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add product";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter_1);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(146, 20);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(111, 21);
            this.textBox4.TabIndex = 30;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.listItems);
            this.groupBox3.Location = new System.Drawing.Point(5, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 326);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Info";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(133, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 21);
            this.button2.TabIndex = 29;
            this.button2.Text = "Delete ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 21);
            this.button1.TabIndex = 28;
            this.button1.Text = "Delete all";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.OutputProd);
            this.groupBox4.Controls.Add(this.OutputTotal);
            this.groupBox4.Controls.Add(this.CosGoo);
            this.groupBox4.Controls.Add(this.TotalCost);
            this.groupBox4.Location = new System.Drawing.Point(5, 325);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(256, 67);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cost of all goods:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Location = new System.Drawing.Point(267, 325);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(266, 67);
            this.groupBox5.TabIndex = 32;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Number of goods";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(120, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 37);
            this.label2.TabIndex = 12;
            this.label2.Text = "0";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 38);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Calculate";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 395);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(555, 434);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(555, 434);
            this.Name = "MainForm";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button TotalCost;
        private System.Windows.Forms.Label CosGoo;
        private System.Windows.Forms.Label OutputTotal;
        private System.Windows.Forms.Label OutputProd;
        private System.Windows.Forms.BindingSource productBindingSource;
        public System.Windows.Forms.ComboBox BoxGroup2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button AddGrName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.ListBox listItems;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
    }
}

