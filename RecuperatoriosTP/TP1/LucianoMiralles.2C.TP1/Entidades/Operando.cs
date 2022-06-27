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
            bool pase = true;
            if (string.IsNullOrEmpty(StrNumero))
            {
                foreach (char digito in StrNumero)
                {
                    if (digito < '0' && digito > '9')
                    {
                        pase = false;
                        break;
                    }
                }
                if (pase)
                    return Convert.ToDouble(StrNumero);
            }
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


        public string BinarioDecimal(string binario)
        {
            double aux = 0;
            string buffer = "Valor invalido";
            if (!(string.IsNullOrEmpty(binario)) && EsBinario(binario))
            {
                for(int i = binario.Length - 1; i >= 0 ; i--)
                {
                    int y = 1;
                    if (binario[i] == '1')
                    {
                        if (i == 0)
                            aux -= 2 ^ y;
                        aux += 2 ^ (y + 1);
                    }
                    y++;
                }
                buffer = aux.ToString();
            }
            return buffer;
        }

        public string DecimalBinario(double numero)
        {
            string buffer = string.Empty;
            string buffer_2 = "Valor invalido";
            if (numero >= 0)
            {
                while(numero > 0)
                {
                    buffer += (numero % 2).ToString();
                    numero /= 2;
                }
                for(int i = buffer.Length - 1; i >= 0; i--)
                {
                    buffer_2 += buffer[i]; 
                }
                return buffer_2;
            }
            return buffer_2;
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
            return double.MinValue;
        }




    }
}
