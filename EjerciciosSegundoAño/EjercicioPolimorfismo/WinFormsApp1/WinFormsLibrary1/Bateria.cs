using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLibrary1
{
    public class Bateria : InstrumentoMusical
    {
        public override void Tocar()
        {
            MessageBox.Show("La batería se toca: golpeando los platillos y tambores");
        }
    }
}
