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
    public partial class CuentaBancari : Form
    {
        public CuentaBancari()
        {
            InitializeComponent();
        }
        Principal principal = new Principal();
        private void ActualizarDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = principal.DevolverListaCuentaBancaria();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CuentaBancari nuevaVentana = new CuentaBancari();
            this.Visible = false;
            nuevaVentana.ShowDialog();
            this.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtNumero.Text == "" || txtSaldos.Text == "" || txtTipos.Text == "")
            {
                MessageBox.Show("Complete todos los campos.");
            }
            else
            {
                CuentaBancaria nuevaCuenta = new CuentaBancaria();
                nuevaCuenta.NumeroCuenta = int.Parse(txtNumero.Text);
                nuevaCuenta.Saldo = double.Parse(txtSaldos.Text);
                nuevaCuenta.Tipo = txtTipos.Text;


                principal.CrearCuentaBancaria(nuevaCuenta);
                ActualizarDataGridView();
            }
        }

        private void txtSaldos_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtDepositar.Text == "")
            {
                MessageBox.Show("Complete el campo.");
            }
            else
            {
                int cuentaId = dataGridView1.CurrentCellAddress.Y;

                principal.RealizarDeposito(((int)dataGridView1[0, cuentaId].Value), double.Parse(txtDepositar.Text));
                ActualizarDataGridView();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CuentaBancari_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = principal.DevolverListaCuentaBancaria();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtRetirar.Text == "")
            {
                MessageBox.Show("Complete el campo.");
            }
            else
            {
                int cuentaId = dataGridView1.CurrentCellAddress.Y;                
                principal.RealizarExtraccion(((int)dataGridView1[0, cuentaId].Value), double.Parse(txtRetirar.Text));
                ActualizarDataGridView();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtTransfer.Text == "" || txtOrigen.Text == "" || txtDestino.Text == "")
            {
                MessageBox.Show("Complete los campos.");
            }
            else
            {
                int cuentaOrigenId = int.Parse(txtOrigen.Text);
                int cuentaDestinoId = int.Parse(txtDestino.Text);

                principal.RealizarTransferencia(cuentaOrigenId, cuentaDestinoId, double.Parse(txtTransfer.Text));
                ActualizarDataGridView();
            }
        }
    }
}
