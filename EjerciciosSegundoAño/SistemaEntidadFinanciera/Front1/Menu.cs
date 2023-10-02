using Back;

namespace Front1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tarjeta nuevaVentana = new Tarjeta();
            this.Visible = false;
            nuevaVentana.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CuentaBancari nuevaVentana = new CuentaBancari();
            this.Visible = false;
            nuevaVentana.ShowDialog();
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Registro nuevaVentana = new Registro();
            this.Visible = false;
            nuevaVentana.ShowDialog();
            this.Visible = true;
        }
    }
}