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
        int id;
        string nombre;
        string apellido;
        int dni;
        string direccion;

        public Cliente(int id, string nombre, string apellido, int dni, string direccion)
            :this(nombre, apellido, dni, direccion)
        {
            this.Id = id;
        }
        public Cliente(string nombre, string apellido, int dni, string direccion)
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
        public int Id { get => id; set => id = value; }

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
