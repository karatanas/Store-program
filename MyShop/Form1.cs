using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyShop
{
    public partial class MainForm : Form
    {
        String stdDetails1 = "{0,-10}{1,-10}{2,-10}{3,-10}{4,-10}";
        public MainForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listItems.Items.Add(String.Format(stdDetails1, "Grp", "Name", "Size", "Pri", "Desc"));
            comboBox3.Items.Add("XXS");
            comboBox3.Items.Add("XS");
            comboBox3.Items.Add("S");
            comboBox3.Items.Add("M");
            comboBox3.Items.Add("L");
            comboBox3.Items.Add("XL");
            comboBox3.Items.Add("XXL");
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void AddTovar_Click(object sender, EventArgs e)
        {

        }
        public void button1_Click(object sender, EventArgs e)
        {
            CosGoo.Text = "";
            CosGoo.Text = TotalCena.ToString() + "$";
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
        }
        public void BoxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void AddGrName_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                BoxGroup2.Items.Add(textBox4.Text);
                textBox4.Text = "";
            }
            else
            {
                MessageBox.Show("Please enter a name to add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        double TotalCena = 0;
        private void AddItem_Click(object sender, EventArgs e)
        {
            String group, name, size, desc;
            double cena = 0;
            group = BoxGroup2.Text;
            name = textBox2.Text;
            size = comboBox3.Text;
            desc = textBox3.Text;
            try
            {
                cena = Convert.ToDouble(textBox1.Text);
                TotalCena += cena;
            }
            catch (Exception)
            {
                MessageBox.Show("Please check the box called price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Item item = new Item(group, name, cena, size, desc);
            if (group != "" && name != "" && cena != 0 && size != "")
            {
                listItems.Items.Add(String.Format(stdDetails1, group, name, size, cena + "$", desc));
            }
            else
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            textBox2.Text = ""; textBox3.Text = ""; textBox1.Text = "";
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void BoxGroup2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
        private void GroupName_TextChanged(object sender, EventArgs e)
        {

        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click_3(object sender, EventArgs e)
        {
            listItems.Items.Clear();
            listItems.Items.Add(String.Format(stdDetails1, "Grp", "Name", "Size", "Pri", "Desc"));
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listItems.Items.RemoveAt(listItems.SelectedIndex);

        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CosGoo_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void label10_Click(object sender, EventArgs e)
        {
        }
        private void CosInv_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            label2.Text = (listItems.Items.Count - 1).ToString();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
