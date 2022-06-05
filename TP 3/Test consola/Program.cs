using System;
using System.Collections.Generic;
using System.IO;
using Entidades;

namespace Test_consola
{
    class Program
    {
        static void Main(string[] args)
        {
            string path_deposito = CrearDirectorioYArchivo("deposito.xml", "XML_Productos");
            string path_ventas = CrearDirectorioYArchivo("ventas.xml", "XML_Ventas");
            string path_clientes = CrearDirectorioYArchivo("clientes.xml", "XML_Clientes");

            Deposito<Producto> deposito = new Deposito<Producto>(50);

            Libro l1 = new Libro(5010, 111000, EOrigen.Importado, 500, EGeneroLiterario.Informatica, "Diego", "Manual Java");
            Libro l2 = new Libro(3050, 111001, EOrigen.Importado, 600, EGeneroLiterario.Informatica, "Esteban", "Manual Linux");
            Libro l3 = new Libro(4050, 111002, EOrigen.Importado, 700, EGeneroLiterario.Informatica, "Lucas", "Manual C#");
            Libro l4 = new Libro(5050, 111003, EOrigen.Importado, 800, EGeneroLiterario.Informatica, "Ludmia", "Manual Javascript");
            Libro l5 = new Libro(4050, 111004, EOrigen.Importado, 900, EGeneroLiterario.Informatica, "Luciana", "Manual GO");
            Libro l6 = new Libro(5050, 111005, EOrigen.Importado, 500, EGeneroLiterario.Informatica, "Karina", "Manual Typescript");
            Libro l7 = new Libro(4050, 111006, EOrigen.Importado, 600, EGeneroLiterario.Informatica, "Javier", "Manual Cobol");
            Libro l8 = new Libro(5050, 111007, EOrigen.Importado, 700, EGeneroLiterario.Informatica, "Jorge", "Manual .NET");
            Libro l9 = new Libro(4050, 111008, EOrigen.Importado, 800, EGeneroLiterario.Informatica, "Susana", "Manual Angular");
            Libro l10 = new Libro(5050, 111009, EOrigen.Importado, 900, EGeneroLiterario.Informatica, "Sara", "Manual Laravel");

            deposito.Agregar(l1);
            deposito.Agregar(l2);
            deposito.Agregar(l3);
            deposito.Agregar(l4);
            deposito.Agregar(l5);
            deposito.Agregar(l6);
            deposito.Agregar(l7);
            deposito.Agregar(l8);
            deposito.Agregar(l9);
            deposito.Agregar(l10);



            Factura f1 = new Factura(DateTime.Now, l1, 5010, 24423456);
            Factura f2 = new Factura(DateTime.Now, l2, 3050, 22423456);
            Factura f3 = new Factura(DateTime.Now, l3, 4050, 23423456);
            Factura f4 = new Factura(DateTime.Now, l1, 5050, 44423456);
            Factura f5 = new Factura(DateTime.Now, l5, 5050, 54423456);
            Factura f6 = new Factura(DateTime.Now, l6, 6080, 24789123);
            Factura f7 = new Factura(DateTime.Now, l7, 7100, 21789951);
            Factura f8 = new Factura(DateTime.Now, l7, 4500, 18789456);
            Factura f9 = new Factura(DateTime.Now, l7, 4605, 13456123);
            Factura f10 = new Factura(new DateTime(2022, 05, 31), l7, 3500, 26778456);

            Ventas ventas = new Ventas();

            ventas.Lista.Add(f1);
            ventas.Lista.Add(f2);
            ventas.Lista.Add(f3);
            ventas.Lista.Add(f4);
            ventas.Lista.Add(f5);
            ventas.Lista.Add(f6);
            ventas.Lista.Add(f7);
            ventas.Lista.Add(f8);
            ventas.Lista.Add(f9);
            ventas.Lista.Add(f10);

            List<Cliente> listaClientes = new List<Cliente>();

            Cliente c1 = new Cliente("Susana", "Lopez", 24423456, "Balvin 3164");
            Cliente c2 = new Cliente("Romina", "Gonzalez", 22423456, "Saraza 324");
            Cliente c3 = new Cliente("Julieta", "Salvador", 23423456, "Corrientes 354");
            Cliente c4 = new Cliente("Antonio", "Gutierrez", 44423456, "Callao 346");
            Cliente c5 = new Cliente("Karin", "Fernandez", 54423456, "Hornos 314");

            listaClientes.Add(c1);
            listaClientes.Add(c2);
            listaClientes.Add(c3);
            listaClientes.Add(c4);
            listaClientes.Add(c5);

            c1.ListaCompras.Add(f1);
            c2.ListaCompras.Add(f2);
            c3.ListaCompras.Add(f3);
            c4.ListaCompras.Add(f4);
            c5.ListaCompras.Add(f5);

            deposito.Serializar(path_deposito);
            XML<List<Cliente>>.SerializarXML(listaClientes,path_clientes);
            XML<Ventas>.SerializarXML(ventas, path_ventas);

        }
        private static string CrearDirectorioYArchivo(string nombreArchivo, string nombreCarpeta)
        {
            if (nombreArchivo is not null && nombreCarpeta is not null)
            {
                string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), nombreCarpeta);
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                return ruta = Path.Combine(ruta, nombreArchivo);
            }
            return null;
        }


    }
}
