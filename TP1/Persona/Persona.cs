using System;
using System.Net.Mail;

namespace Persona
{
    internal abstract class Persona
    {
        internal int dni;
        internal string nombre;
        internal string apellido;

        internal Persona()
        {
            dni = 0;
            nombre = "";
            apellido = "";
        }
    }
}
