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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }
        Principal principal = new Principal();
        private void ActualizarLista()
        {
            listBoxCliente.DataSource = null;
            listBoxCliente.DataSource = principal.DevolverListaClientes();
            listBoxCliente.DisplayMember = "Clien";
        }

        public void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDni.Text == "")
            {
                MessageBox.Show("Complete todos los campos.");
            }
            else
            {
                Cliente nuevoCliente = new Cliente();
                nuevoCliente.Nombre = txtNombre.Text;
                nuevoCliente.Apellido = txtApellido.Text;
                nuevoCliente.DNI = int.Parse(txtDni.Text);

                principal.AgregarCliente(nuevoCliente);
                ActualizarLista();
            }

        }

        private void listBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {
            listBoxCliente.DataSource = principal.DevolverListaClientes();
            listBoxCliente.DisplayMember = "Clien";

        }
    }
}
