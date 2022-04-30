using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        #region Atributos
        /// <summary>
        /// El atributo numero es privado.
        /// </summary>
        private double numero;
        #endregion

        #region Constructores

        /// <summary>
        /// El constructor por defecto (sin parámetros) asignará valor 0 al atributo numero.
        /// </summary>
        public Operando() :this(0)
        {
        }

        /// <summary>
        /// Constructor publico recibe un double para asignar al atributo de la clase.
        /// </summary>
        /// <param name="numero"> Valor a asignar </param>
        public Operando(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Constructor publico recibe un string para asignar al atributo de la clase.
        /// </summary>
        /// <param name="strNumero"> Valor a asignar por medio de la propiedad 'Numero'</param>
        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }
        #endregion

        #region Propiedades

        /// <summary>
        /// La propiedad Numero asignará un valor al atributo número, previa validación. 
        /// En este lugar será el único en todo el código que llame al método ValidarOperando.
        /// </summary>
        public string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// ValidarOperando comprobará que el valor recibido sea numérico, y lo retornará en formato double. 
        /// Caso contrario, retornará 0.
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        private static double ValidarOperando(string strNumero)
        {
            double ret = 0;
            if (Double.TryParse(strNumero, out double number))
            {
                ret = number;
            }
            return ret;
        }

        /// <summary>
        /// El método privado EsBinario validará que la cadena de caracteres esté compuesta SOLAMENTE por caracteres '0' o '1'.
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        private bool EsBinario(string binario)
        {
            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] != '0' && binario[i] != '1')
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// El método BinarioDecimal validará que se trate de un binario y luego convertirá ese número binario a decimal, en caso de ser posible. 
        /// Caso contrario retornará "Valor inválido".
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        public string BinarioDecimal(string binario)
        {
            string ret = "Valor inválido";
            if (EsBinario(binario) == true)
            {
                ret = Convert.ToString(Convert.ToInt64(binario, 2));
            }
            return ret;
        }

        /// <summary>
        /// Ambas opciones del método DecimalBinario convertirán un número decimal a binario, en caso de ser posible. 
        /// Caso contrario retornará "Valor inválido". Reutilizar código.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(double numero)
        {
            string ret = "Valor inválido";
            if (numero >= 1)
            {
                ret = Convert.ToString((long)numero, 2);
            }
            return ret;
        }
        public string DecimalBinario(string numero)
        {
            if (double.TryParse(numero, out double toDouble))
            {
                return DecimalBinario(toDouble);
            }
            return "Valor inválido";
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// os operadores realizarán las operaciones correspondientes entre dos números. Si se tratara de una división por 0, retornará double.MinValue.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }
        public static double operator /(Operando n1, Operando n2)
        {
            double ret = double.MinValue;

            if (n2.numero != 0)
            {
                ret = n1.numero / n2.numero;
            }

            return ret;
        }
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        #endregion
    }
}
