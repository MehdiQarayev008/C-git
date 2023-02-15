using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Modern_Araz_app
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            var item = label4.Select;
            DialogResult result = MessageBox.Show(" Reng", "Parametrler", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            string kateqoriya, mehsul, sayi, bar;
            kateqoriya = textBox1.Text;
            mehsul = textBox3.Text;
            sayi = textBox2.Text;
            //bar = maskedTextBox1.Text;

            string[] melumatlar = { kateqoriya, mehsul, sayi,/* bar*/ };
            ListViewItem td = new ListViewItem(melumatlar);
            listView1.Items.Add(td);


            if (textBox1.Text == " ")
            {
                MessageBox.Show("Xanalari doldur");
            }

            else if (textBox3.Text == "")
            {
                MessageBox.Show("Xanalari doldur");
            }

            else if (textBox2.Text == " ")
            {
                MessageBox.Show("Xanalari doldur");
            }
            else
            {
            }
            Form5 for5 = new Form5();
            form5.ShowDialog();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPEG (*.jpeg)|*.jpeg|JPG (*.jpg)|*.jpg";
            openFileDialog1.InitialDirectory = @"C:\Users\User\C# 2-ci modul 09.01.2023\Modern Araz app";
            openFileDialog1.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
