using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLibrary1
{
    internal class Piano : InstrumentoMusical
    {
        public override void Tocar()
        {
            MessageBox.Show("El piano se toca: Apretando las diferentes teclas del piano");
        }
    }
}
