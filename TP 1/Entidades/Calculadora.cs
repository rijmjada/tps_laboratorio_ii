using System;

namespace Entidades
{
    public class Calculadora
    {
        #region Metodos
        private static char ValidarOperador(char operador)
        {
            char ret = '+';
            if (operador == '-' || operador == '*' | operador == '/')
            {
                ret = operador;
            }
            return ret;
        }

        public double Operar(Operando num1, Operando num2, char operador)
        {
            double ret = 0;
            switch (Calculadora.ValidarOperador(operador))
            {
                case '-':
                    ret = num1 - num2;
                    break;
                case '/':
                    ret = num1 / num2;
                    break;
                case '*':
                    ret = num1 * num2;
                    break;
                default:
                    ret = num1 + num2;
                    break;
            }
            return ret;
        } 

        #endregion
    }
}
