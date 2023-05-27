using WinFormsLibrary1;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Circulo micirculo = new Circulo();
            micirculo.radio = double.Parse(textBox2.Text);
            micirculo.Nombre = textBox1.Text;
            MessageBox.Show(micirculo.QuienSos());
            label3.Text = micirculo.QuienSos();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}