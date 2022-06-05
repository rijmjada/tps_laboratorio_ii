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
        DateTime fecha;
        Producto producto;
        double monto;
        int dniCliente;
        static string nombreFactura;

        public Factura()
        {

        }
        public Factura(DateTime fecha, Producto producto, double monto, int dniCliente)
            :this()
        {
            Fecha = fecha;
            Producto = producto;
            Monto = monto;
            DniCliente = dniCliente;
        }

        
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public double Monto { get => monto; set => monto = value; }
        public int DniCliente { get => dniCliente; set => dniCliente = value; }
        public static string NombreFactura { get => nombreFactura; set => nombreFactura = value; }
        public Producto Producto { get => producto; set => producto = value; }

        public static bool ImprimirFactura(Factura f)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Facturacion";
            
            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }
            string nombreArchivo = $"DNI_{f.DniCliente}___Fecha_{DateTime.Now.ToString("MM_dd_yyyy")}.txt";
            NombreFactura  = nombreArchivo;
            string path = Path.Combine(ruta, nombreArchivo);

            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(f.ToString());
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Fecha: {this.Fecha}");
            sb.AppendLine($"Producto: {((Libro)this.Producto).Titulo}");
            sb.AppendLine($"Monto: {this.Monto}");
            sb.AppendLine($"DNI cliente: {this.DniCliente}");

            return sb.ToString();
        }
    }
}
