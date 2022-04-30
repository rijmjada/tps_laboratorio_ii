using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        #region Enumerados
        public enum ETipo { CuatroPuertas, CincoPuertas }

        #endregion

        #region Atributos

        ETipo tipo;

        #endregion

        #region Constructores

        /// <summary>
        /// Por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo)
            : this(marca, chasis, color)
        {
            this.tipo = tipo;
        }

        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : base(marca, chasis, color) { }


        #endregion

        #region Propiedades

        /// <summary>
        /// Sedan son 'Mediano'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }

        #endregion

        #region Metodos
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("SEDAN");
            sb.Append(base.Mostrar());
            sb.AppendFormat($"TAMAÑO: {this.Tamanio}");
            sb.AppendFormat($"TIPO: {this.tipo}");
            sb.AppendLine("\n---------------------");

            return sb.ToString();
        }

        #endregion
    }
}
