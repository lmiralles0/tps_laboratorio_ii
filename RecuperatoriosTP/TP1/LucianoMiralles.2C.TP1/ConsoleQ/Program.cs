using System;
using Entidades;

namespace ConsoleQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operando num1 = new Operando(5);
            Operando num2 = new Operando(6);

            Console.WriteLine(Calculadora.Operar(num1, num2, '/'));

            Console.ReadKey();
        }
    }
}
