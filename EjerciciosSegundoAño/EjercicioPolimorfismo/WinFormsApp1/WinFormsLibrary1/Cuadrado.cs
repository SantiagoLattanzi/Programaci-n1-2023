using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLibrary1
{
    public class Cuadrado : FiguraGeometrica
    {
        public double lado { get; set; }

        public override double CalcularArea()
        {
            return lado * lado;
        }
    }
}
