using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        string nombre;
        string apellido;
        int dni;
        string direccion;
        List<Factura> listaCompras;

        public Cliente()
        {
            this.ListaCompras = new List<Factura>();
        }
        public Cliente(string nombre, string apellido, int dni, string direccion)
            : this()
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Direccion = direccion;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public List<Factura> ListaCompras { get => listaCompras; set => listaCompras = value; }

       
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Apellido: {this.Apellido}");
            sb.AppendLine($"Dni: {this.Dni}");
            sb.AppendLine($"Direccion: {this.Direccion}");

            return sb.ToString();
        }
    }
}
