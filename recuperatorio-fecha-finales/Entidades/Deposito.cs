using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(Producto))]
    [XmlInclude(typeof(Libro))]

    public class Deposito<T> where T : Producto, ISerializable
    {
        #region Atributos
        private int capacidadMaxima;
        private List<T> lista;
        #endregion

        #region Propiedades
        public int CapacidadMaxima { get => capacidadMaxima; set => capacidadMaxima = value; }
        public List<T> Lista { get => lista; set => lista = value; }
        #endregion

        #region Constructores
        public Deposito()
        {
        }
        public Deposito(int capacidad) : this()
        {
            this.CapacidadMaxima = capacidad;
            this.Lista = new List<T>();
        }
        #endregion

        #region Operadores

        public static bool operator ==(Deposito<T> depo, T producto)
        {
            foreach (T item in depo.Lista)
            {
                if (item == producto)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Deposito<T> depo, T producto)
        {
            return !(depo == producto);
        }
        public static bool operator +(Deposito<T> depo, T producto)
        {
            bool ret = false;

            if ((depo is not null && producto is not null) && (depo.capacidadMaxima > depo.lista.Count) && depo != producto)
            {
                depo.Lista.Add(producto);
                ret = true;
            }

            return ret;
        }
        public static bool operator -(Deposito<T> depo, T producto)
        {
            bool ret = false;

            if (depo is not null && producto is not null)
            {
                int index = depo.GetIndice(producto);

                if (index != -1)
                {
                    depo.Lista.RemoveAt(index);
                    ret = true;
                }
            }
            return ret;
        }


        #endregion

        #region Metodos
        private int GetIndice(T producto)
        {
            int ret = -1;

            if (producto is not null)
            {
                for (int i = 0; i < this.lista.Count; i++)
                {
                    if (lista[i] == producto)
                    {
                        ret = i;
                        break;
                    }
                }
            }
            return ret;
        }

        /// <summary>
        /// Está asociado al operador +.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public bool Agregar(T producto)
        {
            return this + producto;
        }

        /// <summary>
        /// Está asociado al operador -.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public bool Remover(T producto)
        {
            return this - producto;
        }
        #endregion

        #region SobreEscrituras
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Capacidad Deposito: {0}\r\n", this.capacidadMaxima);
            sb.AppendLine("Listado de Stock:\n");

            foreach (T item in this.lista)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
        #endregion


        public void Serializar(string path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(Deposito<T>));
                    xml.Serialize(sw, this);
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        public Deposito<Producto> DeserializarXml(string path)
        {
            try
            {
                using (StreamReader sw = new StreamReader(path))
                {

                    XmlSerializer xs = new XmlSerializer(typeof(Deposito<Producto>));
                    Deposito<Producto> depo = xs.Deserialize(sw) as Deposito<Producto>;
                    return depo;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}
