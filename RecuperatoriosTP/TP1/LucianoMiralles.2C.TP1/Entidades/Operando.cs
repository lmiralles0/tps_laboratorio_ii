using System;

namespace Entidades
{
    public class Operando
    {
        private double numero;
        public Operando()
        {
            numero = 0;
        }

        public Operando(double numero) : this()
        {
            this.numero = numero;
        }

        public Operando(string strString)
        {
            Numero = strString;
        }

        private double ValidarOperando(string StrNumero)
        {
            if (string.IsNullOrEmpty(StrNumero))
                return Convert.ToDouble(StrNumero);
            return 0;
        }

        private string Numero 
        {
            set
            { 
                this.numero = ValidarOperando(value); 
            } 
        }

        private bool EsBinario(string binario)
        {
            bool respuesta = false;
            if (!(string.IsNullOrEmpty(binario)))
            {
                foreach(char c in binario)
                {
                    if (c != '0' && c !='1')
                    {
                        respuesta = false;
                        break;
                    }
                    respuesta = true;
                }
            }
            return respuesta;
        }





        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        public static double operator /(Operando n1, Operando n2)
        {
            if (n2.numero != 0)
                return n1.numero / n2.numero;
            return 0;
        }




    }
}
