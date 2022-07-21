    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(Libro))]

    public abstract class Producto : ISerializable
    {
    
        #region Atributos
        private double precio;
        private int codigo;
        private EOrigen origen;
        #endregion

        #region Propiedades
        public double Precio { get => precio; set => precio = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public EOrigen Origen { get => origen; set => origen = value; }

        #endregion

        #region Constructores
        protected Producto()
        {
        }
        public Producto(double precio, int codigo, EOrigen origen)
        {
            this.Precio = precio;
            this.Codigo = codigo;
            this.Origen = origen;
        }

        #endregion

        #region SobreCargas
        public static bool operator ==(Producto a, Producto b)
        {
            return a.Codigo == b.Codigo;
        }
        public static bool operator !=(Producto a, Producto b)
        {
            return !(a == b);
        }
        #endregion

        #region Metodos
        private static string MostrarDatos(Producto p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Precio: ${p.Precio}");
            sb.AppendLine($"Codigo: {p.Codigo}");
            sb.AppendLine($"Origen: {p.Origen.ToString()}");

            return sb.ToString();
        }
        #endregion

        #region SobreEscrituras
        public override string ToString()
        {
            return Producto.MostrarDatos(this);
        }

        public override bool Equals(object obj)
        {
            return obj is not null && (obj as Producto) == this;
        }

        #endregion

        public void Serializar(string path)
        {
            throw new NotImplementedException();
        }

        public Deposito<Producto> Deserializar(string path)
        {
            throw new NotImplementedException();
        }
    }
}
