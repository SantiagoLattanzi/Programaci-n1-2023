using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsLibrary1
{
    public class Auto : Vehiculo     
    {
        public int VelocidadA { get; set; }
        public void Acelerar()
        {
            MessageBox.Show("El auto debe aumentar la velocidad a: " + VelocidadA);
        }
    }
}
