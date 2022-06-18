using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class MyExtensions
    {
        public static string TotalFacturadoFecha(this Ventas v, DateTime fecha)
        {
            double total = 0;
            foreach(Factura f in v.Lista)
            {
                if(f.Fecha.DayOfYear == fecha.DayOfYear)
                    total += f.Monto;
            }
            return total.ToString();
        }
    }
}
