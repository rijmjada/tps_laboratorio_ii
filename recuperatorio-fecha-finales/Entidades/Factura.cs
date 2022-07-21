using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Factura
    {

        #region Atributos

        private int id;
        private DateTime fecha;
        private string producto;
        private double monto;
        private int id_cliente;
        private static string nombreFactura;

        #endregion

        #region Constructores
        public Factura(int id, DateTime fecha, string producto, double monto, int id_cliente)
            : this(fecha, producto, monto, id_cliente)
        {
            this.Id = id;
        }

        public Factura(DateTime fecha, string producto, double monto, int id_cliente)
        {
            Fecha = fecha;
            Producto = producto;
            Monto = monto;
            Id_cliente = id_cliente;
        }
        #endregion

        #region Propiedades
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public double Monto { get => monto; set => monto = value; }
        public static string NombreFactura { get => nombreFactura; set => nombreFactura = value; }
        public int Id { get => id; set => id = value; }
        public string Producto { get => producto; set => producto = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        #endregion

        #region Metodos
        public static bool ImprimirFactura(Factura f, string datosExtra)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Facturacion";

            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }
            string nombreArchivo = $"IDCliente({f.Id_cliente})__Fecha({DateTime.Now.ToString("yyyy-MM-dd")})__Hora({DateTime.Now.ToString("HH.mm")})__.txt";
            NombreFactura = nombreArchivo;
            string path = Path.Combine(ruta, nombreArchivo);

            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(f.ToString());
                    sw.WriteLine(datosExtra);
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        } 
        #endregion

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Fecha: {this.Fecha.ToString("yyyy-MM-dd")}");
            sb.AppendLine($"Producto: {this.Producto}");
            sb.AppendLine($"Monto: {this.Monto}");
            sb.AppendLine($"ID cliente: {this.Id_cliente}");

            return sb.ToString();
        }
    }
}
