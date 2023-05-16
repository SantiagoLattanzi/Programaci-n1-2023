using Biblioteca2_Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_2
{
    public class Libro : Producto
    {
        public string Nombre { get; set; }
        public string Editorial { get; set; }
        public string Genero { get; set; }

    }
}
