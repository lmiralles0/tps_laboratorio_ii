using System;
using System.Net.Mail;

namespace Persona
{
    internal abstract class Persona
    {
        public int dni;
        public string nombre;
        public string apellido;

        internal Persona()
        {
            dni = 0;
            nombre = "";
            apellido = "";
        }
    }
}
