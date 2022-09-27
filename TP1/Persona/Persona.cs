using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace Persona
{
    public abstract class Persona
    {
        internal int dni;
        internal string nombre;
        internal string apellido;
        internal string passwd;

        internal Persona()
        {
            dni = 0;
            nombre = "";
            apellido = "";
            passwd = "";
        }

        public abstract int Dni { get;}
        public abstract string Nombre { get;}
        public abstract string Apellido { get;}
        public abstract string Passwd { get; set; }

        public virtual bool lookAt(List<Persona> ad, Persona a)
        {
            return true;
        }

    }
}
