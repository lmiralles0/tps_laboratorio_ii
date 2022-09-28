using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace Persona
{
    public class Persona
    {
        internal int dni;
        internal string nombre;
        internal string apellido;
        internal string passwd;

        public Persona()
        {
            dni = 0;
            nombre = "";
            apellido = "";
            passwd = "";
        }

        public virtual int Dni { get;}
        public virtual string Nombre { get;}
        public virtual string Apellido { get;}
        public virtual string Passwd { get; set; }

        public virtual bool lookAt(List<Persona> ad, Persona a)
        {
            return true;
        }

    }
}
