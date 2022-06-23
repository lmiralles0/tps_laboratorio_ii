using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal static class Calculadora
    {
        private static char ValidarOperador(char operador)
        {
            if (operador != '+' && operador != '-' && operador != '/' && operador != '*')
                return '+';
            else
                return operador;
        }

        public static double Operar(Operando num1, Operando num2, char operador)
        {
            
     
        }
    }
}
