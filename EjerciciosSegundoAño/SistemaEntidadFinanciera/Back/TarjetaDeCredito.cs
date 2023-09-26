using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class TarjetaDeCredito
    {
        public int Id { get; set; }
        public int NumeroTarjeta { get; set; }
        public int LimiteCredito { get; set; }
        public double SaldoDisponible { get; set; }
        public string Estado { get; set; }
        public double MontoDeuda { get; set; }
    }
}
