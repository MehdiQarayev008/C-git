using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modern_Araz_app
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        string mebleg;
        string qepik = "50";

        private void button5_Click(object sender, EventArgs e)
        {
            
           string sonmebleg = mebleg - qepik;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = mebleg;
        }
    }
}
