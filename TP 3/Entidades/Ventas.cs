using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ventas 
    {
        List<Factura> lista;

        public List<Factura> Lista { get => lista; set => lista = value; }

        public Ventas()
        {
            this.Lista = new List<Factura>();
        }
       
    }
}
