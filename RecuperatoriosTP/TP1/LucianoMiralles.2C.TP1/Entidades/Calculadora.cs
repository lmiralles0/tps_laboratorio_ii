using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
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
            if (operador == '+' && ValidarOperador(operador) != '+')
            {
                switch(operador)
                {
                    case '+':
                        return num1 + num2;
                    case '-':
                        return num1 - num2;
                    case '/':
                        return num1 / num2;
                    case '*':
                        return num1 * num2;
                }
            }
            return 0;
        }

    }
}
