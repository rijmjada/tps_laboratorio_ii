using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        #region Constructores
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color)
           : base(marca, chasis, color)
        {
        }

        #endregion

        #region Propiedades
        /// <summary>
        /// Ciclomotor son 'Chico'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }

        #endregion

        #region Metodos
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("CICLOMOTOR");
            sb.Append(base.Mostrar());
            sb.AppendFormat($"TAMAÑO: {this.Tamanio}");
            sb.AppendLine("\n---------------------");

            return sb.ToString();
        } 

        #endregion
    }
}
