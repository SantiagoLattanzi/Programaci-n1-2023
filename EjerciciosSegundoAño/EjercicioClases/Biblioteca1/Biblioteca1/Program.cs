using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_2;
using Biblioteca2_Clases;

namespace Biblioteca1_Consola
{
    public class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Principal principal = new Principal();
            do
            {
                Console.WriteLine("-------Menu-------");
                Console.WriteLine("1 = AltaCliente");
                Console.WriteLine("2 = AltaProducto");
                Console.WriteLine("3 = AltaUtiles");
                Console.WriteLine("4 = AltaLibro");
                Console.WriteLine("0 para finalizar");
                Console.WriteLine("--------------------");

                Console.WriteLine("Ingrese una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Cliente clienteAgregado = new Cliente();

                        Console.WriteLine("Agrega Nombre: ");
                        clienteAgregado.Nombre = Console.ReadLine();

                        Console.WriteLine("Agrega Apellido: ");
                        clienteAgregado.Apellido = Console.ReadLine();

                        Console.WriteLine("Agregar DNI: ");
                        clienteAgregado.DNI = int.Parse(Console.ReadLine());

                        Console.WriteLine("Agregar Edad: ");
                        clienteAgregado.Edad = int.Parse(Console.ReadLine());

                        Console.WriteLine("Agregar id: ");
                        clienteAgregado.id = int.Parse(Console.ReadLine());

                        principal.AltaCliente(clienteAgregado.DNI, clienteAgregado.Nombre, clienteAgregado.Apellido, clienteAgregado.Edad, clienteAgregado.id);
                        break;
                    case 2:
                        Producto productoAgregado = new Producto();

                        Console.WriteLine("Codigo del Producto: ");
                        productoAgregado.Codigo = int.Parse(Console.ReadLine());

                        Console.WriteLine("Costo del Producto: ");
                        productoAgregado.Costo = int.Parse(Console.ReadLine());

                        Console.WriteLine("Stock del Producto: ");
                        productoAgregado.Stock = int.Parse(Console.ReadLine());

                        principal.AltaProducto(productoAgregado.Codigo, productoAgregado.Stock, productoAgregado.Costo);
                        break;
                    case 3:
                        Utiles utilAgregado = new Utiles();

                        Console.WriteLine("Tipo de util: ");
                        utilAgregado.Tipo = Console.ReadLine();

                        Console.WriteLine("Marca: ");
                        utilAgregado.Marca = Console.ReadLine();

                        principal.AltaUtiles(utilAgregado.Tipo, utilAgregado.Marca);
                        break;
                    case 4:
                        Libro libroAgregado = new Libro();

                        Console.WriteLine("Nombre del libro: ");
                        libroAgregado.Nombre = Console.ReadLine();

                        Console.WriteLine("Editorial: ");
                        libroAgregado.Editorial = Console.ReadLine();

                        Console.WriteLine("Genero: ");
                        libroAgregado.Genero = Console.ReadLine();
                        principal.AltaLibro(libroAgregado.Nombre, libroAgregado.Editorial, libroAgregado.Genero);
                        break;
                }
            } while (opcion != 0);
        }
    }
}
