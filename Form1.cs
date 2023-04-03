namespace Calculator_dB2
{
    public partial class Form1 : Form
    {
        public bool N1;
        public bool N2;
        public Form1()
        {
            N1 = false;
            N2 = false;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {   
              Button B = (Button)sender;
              if (N1)
                 if (textBox1.Text=="0")
                 textBox1.Text = B.Text;
                 else
                 textBox1.Text = textBox1.Text + B.Text;
              else
                if (textBox2.Text == "0")
                textBox2.Text = B.Text;
            else
                textBox2.Text = textBox1.Text + B.Text;




        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
    }
}