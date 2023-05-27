using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLibrary1
{
    public class Bicicleta : Vehiculo
    {
        public int VelocidadB { get; set; }
        public void Acelerar()
        {
            MessageBox.Show("La bici debe aumentar la velocidad a: " + VelocidadB);
        }

    }
}
