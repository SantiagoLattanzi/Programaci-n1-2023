using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLibrary1
{
    public class Vendedor : Empleado
    {
        public int SueldoV { get; set; }
        public int HorasV { get; set; }
        public override int CalcularSalario()
        {
            return SueldoV * HorasV;
        }
    }
}
