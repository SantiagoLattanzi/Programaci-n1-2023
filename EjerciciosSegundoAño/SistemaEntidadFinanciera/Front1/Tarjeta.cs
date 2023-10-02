using Back;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front1
{
    public partial class Tarjeta : Form
    {

        public Tarjeta()
        {
            InitializeComponent();
        }
        Principal principal = new Principal();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void IngredientesABM_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = principal.DevolverListaTarjeta();
        }
        private void ActualizarDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = principal.DevolverListaTarjeta();

        }
        private void Tarjeta_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = principal.DevolverListaTarjeta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text == "" || txtLimite.Text == "" || txtSaldo.Text == "" || txtEstado.Text == "" || txtMonto.Text == "")
            {
                MessageBox.Show("Complete todos los campos.");
            }
            else
            {
                TarjetaDeCredito nuevaTarjeta = new TarjetaDeCredito();
                nuevaTarjeta.NumeroTarjeta = int.Parse(txtNumero.Text);
                nuevaTarjeta.LimiteCredito = int.Parse(txtLimite.Text);
                nuevaTarjeta.SaldoDisponible = double.Parse(txtSaldo.Text);
                nuevaTarjeta.Estado = txtEstado.Text;
                nuevaTarjeta.MontoDeuda = double.Parse(txtMonto.Text);

                principal.EmitirTarjetaCredito(nuevaTarjeta);
                ActualizarDataGridView();
            }
        }

        private void txtSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            int cuentaId = dataGridView1.CurrentCellAddress.Y;
            principal.PausarTarjetaCredito((int)dataGridView1[0, cuentaId].Value);
            ActualizarDataGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtPagar.Text == "")
            {
                MessageBox.Show("Complete el campo.");
            }
            else
            {
                int cuentaId = dataGridView1.CurrentCellAddress.Y;
                principal.PagarTarjetaCredito(((int)dataGridView1[0, cuentaId].Value), double.Parse(txtPagar.Text));
                ActualizarDataGridView();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int cuentaId = dataGridView1.CurrentCellAddress.Y;
            MessageBox.Show(principal.GenerarResumenTarjeta(((int)dataGridView1[0, cuentaId].Value)));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

