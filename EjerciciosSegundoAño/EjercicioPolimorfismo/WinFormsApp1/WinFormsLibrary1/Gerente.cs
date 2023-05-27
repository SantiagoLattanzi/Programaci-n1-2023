using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLibrary1
{
    public class Gerente : Empleado
    {
        public int SueldoG { get; set; }
        public int HorasG { get; set; }
        public override int CalcularSalario()
        {
            return SueldoG * HorasG;
        }
    }
}
