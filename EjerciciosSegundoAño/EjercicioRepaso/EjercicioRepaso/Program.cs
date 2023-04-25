using System;
using System.Collections.Generic;

namespace Latta
{
    /*
    class Ej1
    {
        static void Main(string[] args)
        {
            int ClaveCorrecta, ClaveUsuario, NumeroUsuario;
            int NumerosNegativos = 0;
            int CantidadNumeros = 0;

            ClaveCorrecta = 667788;

            do
            {
                Console.WriteLine("Ingrese la clave: ");
                ClaveUsuario = int.Parse(Console.ReadLine());
                if (ClaveUsuario != ClaveCorrecta)
                {
                    Console.WriteLine("Contraseña Incorrecta");

                }

            }
            while (ClaveUsuario != ClaveCorrecta);
            Console.WriteLine("Contraseña Correcta");
            do
            {
                Console.WriteLine("Ingrese un numero positivo: ");
                NumeroUsuario = int.Parse(Console.ReadLine());
                if (NumeroUsuario < 0)
                {
                    NumerosNegativos = NumerosNegativos + NumeroUsuario;
                    CantidadNumeros++;
                }

            }
            while (NumeroUsuario < 0);
            int Promedio;
            Promedio = NumerosNegativos / CantidadNumeros;
            Console.WriteLine("El promedio es: " + Promedio);
            int Numeross;
            int NumSum = 0;
            int Prom;
            int CantSum = 0;

            do
            {
                Console.WriteLine("Ingrese un numero mayor a 3 cifras: ");
                Numeross = int.Parse(Console.ReadLine());
                NumSum = NumSum + Numeross;
                CantSum++;
               
            }
            while (Numeross <= 999);
            Prom = NumSum / CantSum;
            Console.WriteLine("El promedio de los numeros ingresados es: " + Prom);
    }
    
    class Ej2
    {

        static void Main(string[] args)
        {
            /*
            int num5, sum5;
            sum5 = 0;

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Escriba un numero: ");
                num5 = int.Parse(Console.ReadLine());
                sum5 = sum5 + num5;
                

            }
            Console.WriteLine("La suma de los numeros es: " + sum5);

            int num8, sum8, cant8, prom8;
            sum8 = 0;
            cant8 = 0;

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Ingrese 8 numeros para conocer su promedio: ");
                num8 = int.Parse(Console.ReadLine());
                cant8++;
                sum8 = sum8 + num8;
                
            }
            prom8 = sum8 / cant8;

            Console.WriteLine("El promedio de los 8 numeros ingresados es: " + prom8);

            
            int cost5, tot5;
            tot5 = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el costo de 5 compras para averiguar el Total: ");
                cost5 = int.Parse(Console.ReadLine());
                tot5 = tot5 + cost5;
            }
            Console.WriteLine("El total de las 5 compras es: " + tot5);
            

            int nums8, may8;

            nums8 = 0;
            may8 = 0;
            for (int i = 0; i < 8; i++)
            {
               
                Console.WriteLine("Escriba 8 numeros: ");
                nums8 = int.Parse(Console.ReadLine());
                if (nums8 > may8)
                {
                    may8 = nums8;
                }
            }
            Console.WriteLine("El mayor es: " + may8);
           
            string nom5, gasto = "";
            
            int tot, may;
            may = 0;
            tot = 0;
            

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el nombre de usuario; ");
                nom5 = Console.ReadLine();

                Console.WriteLine("Ingrese el costo Total: ");
                tot = int.Parse(Console.ReadLine());

                if (tot > may)
                {
                    may = tot;
                    gasto = nom5;
                }
            }
            Console.WriteLine("El que mas gasto es: " + gasto);
            
            int num1 = 1;
            int sumas = 0;
            int contar_ej3 = 0;
            int prom_ej3 = 0;
         

            while (num1 != 0 && num1 > 0)
            {
                Console.WriteLine("Escriba numeros positivos, escrbir 0 para parar: ");
                num1 = int.Parse(Console.ReadLine());
                sumas = sumas + num1;
                contar_ej3 ++;
                
            }
            Console.WriteLine("La suma de los numeros ingresados es: " + sumas);
            prom_ej3 = sumas / contar_ej3;
            Console.WriteLine("El promedio de los valores ingresados es: " + prom_ej3);
            

            List<string> nombres = new List<string>();
            string nombres_ej3 = "";
            while   (true)
            {
                Console.WriteLine("Esciba un nombre para agregar a la lista, dejar vacio al finalizar ");
                nombres_ej3 = Console.ReadLine();
                if (nombres_ej3 == "")
                {
                    break;
                }
                nombres.Add(nombres_ej3);
                

            }
            Console.WriteLine("La lista de nombres es: ");
            foreach (string nombree in nombres)
            {
                Console.Write(nombree + "");

            }
        }
       
            double costo_ej3 = 1;
            double total_ej3 = 0;
            double total_adeudado = 0;

            while (costo_ej3 != 0)
            {
                Console.WriteLine("Ingrese el Costo, con 0 se finaliza: ");
                costo_ej3 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el Total: ");
                total_ej3 = double.Parse(Console.ReadLine());
                total_adeudado = total_adeudado + total_ej3;
            }
            Console.WriteLine("Total adeudado: " + total_adeudado);
            
            double CuantosProductos = 0;
            double Total_ej5 = 0;
            double Costo_ej5 = 0;
            double Total_adeudado = 0;

            Console.WriteLine("Ingrese el numero de productos comprados: ");
            CuantosProductos = double.Parse(Console.ReadLine());  
            for (int i = 0; i < CuantosProductos; i++)
            {
                Console.WriteLine("Ingrese el total: ");
                Total_ej5 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el costo: ");
                Costo_ej5 = double.Parse(Console.ReadLine());

                Total_adeudado += Total_ej5;
            }
            Console.WriteLine("El total adeudado es: " + Total_adeudado);
            
            int CodigoProducto = 1;
            int Precio_ej1 = 0;
            int Cantidad_ej1 = 0;
            int may_ej1 = 0;
            int Codigo_may = 0;
            int Ventas_ej1 = 0;
            int Costo_Ventas = 0;
            string NombreProduc = "";

            for (int i = 0; i < 3; i++)
            {
                while (CodigoProducto != 0)
                {
                    Console.WriteLine("Ingrese el codigo del producto (con 0 se finaliza):");
                    CodigoProducto = int.Parse(Console.ReadLine());

                    if (CodigoProducto != 0)
                    {
                        Console.WriteLine("Ingrese el nombre del producto: ");
                        NombreProduc = Console.ReadLine();

                        Console.WriteLine("Ingrese el costo");
                        Precio_ej1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese la cantidad:");
                        Cantidad_ej1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese las Ventas por cada Producto: ");
                        Ventas_ej1 = int.Parse(Console.ReadLine());

                        Costo_Ventas = Cantidad_ej1 - Ventas_ej1;

                        if (Cantidad_ej1 > may_ej1)
                        {
                            may_ej1 = Cantidad_ej1;
                            Codigo_may = CodigoProducto;
                        }
                        if (Costo_Ventas <= 0)
                        {
                            Console.WriteLine("La cantidad menos las ventas del producto: " + CodigoProducto + "es: " + Costo_Ventas);
                        }
                        if (Ventas_ej1 < 10)
                        {
                            Console.WriteLine("El producto: " + NombreProduc + "tiene un total de ventas menor a 10 unidades");
                        }
                    }
                }
            }
            Console.WriteLine("El codigo con mayor cantidad es: " + Codigo_may);
            */
    using System;
    using System.Collections.Generic;

    class Repaso3
    {
        static void Main(string[] args)
        {
            List<string[]> clientes = new List<string[]>();

            while (true)
            {
                Console.WriteLine("Ingrese código del cliente (0 para terminar): ");
                string codigo = Console.ReadLine();

                if (codigo == "0")
                {
                    break;
                }

                Console.WriteLine("Ingrese nombre del cliente: ");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese dirección del cliente: ");
                string direccion = Console.ReadLine();

                Console.WriteLine("Ingrese correo electrónico del cliente: ");
                string correo = Console.ReadLine();

                string[] datosCliente = { codigo, nombre, direccion, correo };
                clientes.Add(datosCliente);
            }

            Console.WriteLine("Lista de clientes ingresados:");
            foreach (string[] cliente in clientes)
            {
                Console.WriteLine("Código: " + cliente[0]);
                Console.WriteLine("Nombre: " + cliente[1]);
                Console.WriteLine("Dirección: " + cliente[2]);
                Console.WriteLine("Correo electrónico: " + cliente[3]);
                Console.WriteLine("-----------------------------");
            }

            Console.ReadLine();
            
            while (true)
            {
                Console.WriteLine("Codigo de cliente, factura: ");
                string code = Console.ReadLine();
                if (code == "0")
                {
                    break;
                }

            }
        }
    }
}