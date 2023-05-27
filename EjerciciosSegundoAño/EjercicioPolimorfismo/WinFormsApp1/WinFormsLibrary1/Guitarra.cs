using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLibrary1
{
    public class Guitarra : InstrumentoMusical
    {
        public override void Tocar()
        {
            MessageBox.Show("La guitarra se toca: tocando las cuerdas ");
        }
    }
}
