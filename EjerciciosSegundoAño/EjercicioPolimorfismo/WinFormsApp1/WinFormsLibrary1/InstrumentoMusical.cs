using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLibrary1
{
    public class InstrumentoMusical
    {
        public virtual void Tocar()
        {
            MessageBox.Show("El instrumento musical ... se toca: ");
        }
    }
}
