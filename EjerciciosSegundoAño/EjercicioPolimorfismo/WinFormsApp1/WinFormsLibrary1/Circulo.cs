using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLibrary1
{
    public class Circulo : FiguraGeometrica
    {
        public double radio { get; set; }
        public override double CalcularArea()
        {
            return 3.14 * radio * radio;
        }
    }
}
