namespace WinFormsLibrary1
{
    public abstract class FiguraGeometrica
    {

        public string Nombre { get; set; }
        public abstract double CalcularArea();

        public string QuienSos()
        {
            return "Hola me llamo " + Nombre + " y mi area es: " + CalcularArea();
        }
    }
}