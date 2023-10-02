using System.Text.RegularExpressions;

namespace Back
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public string Clien
        {
            get { return "Nombre: " + Nombre + ", Apellido: " + Apellido + ", DNI: " + DNI; }

        }
    }
}