using Biblioteca_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2_Clases
{
    public class Principal
    {
        List<Cliente> ListaClientes = new List<Cliente>();
        List<Producto> ListaProducto = new List<Producto>();
        List<Libro> ListaLibro = new List<Libro>();
        List<Utiles> ListaUtiles = new List<Utiles>();

        public void AltaCliente(int dni, string nombre, string apellido, int edad, int id)
        {
            Cliente clienteNuevo = new Cliente();
            clienteNuevo.id = clienteNuevo.id + 1;
            clienteNuevo.DNI = dni;
            clienteNuevo.Nombre = nombre;
            clienteNuevo.Apellido = apellido;
            clienteNuevo.Edad = edad;
            ListaClientes.Add(clienteNuevo);

        }
        public void AltaProducto(int Codigo, int Stock, int Costo)
        {
            Producto productoNuevo = new Producto();
            productoNuevo.Codigo = Codigo;
            productoNuevo.Costo = Costo;
            productoNuevo.Stock = Stock;
            ListaProducto.Add(productoNuevo);
            
        }
        public void AltaUtiles(string Tipo, string Marca)
        {
            Utiles utilesNuevos = new Utiles();
            utilesNuevos.Tipo = Tipo;
            utilesNuevos.Marca = Marca;
            ListaUtiles.Add(utilesNuevos);
        }
        public void AltaLibro(string Nombre, string Editorial, string Genero)
        {
            Libro libroNuevo = new Libro();
            libroNuevo.Nombre = Nombre;
            libroNuevo.Editorial = Editorial;
            libroNuevo.Genero = Genero;
            ListaLibro.Add(libroNuevo);
        }
    }
}
