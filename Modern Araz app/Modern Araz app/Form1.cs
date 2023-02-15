namespace Modern_Araz_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string parol = textBox2.Text;
            if (ad == "Mehdi" && parol == "Mehdi555")
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            else
            {
                button2.BackColor = Color.Red;
                MessageBox.Show("Tekrar cehd edin");

            }
        
        }
    }
}