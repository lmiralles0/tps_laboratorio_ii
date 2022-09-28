﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    internal sealed class Profesor : Persona
    {
        internal Profesor(int dni, string nombre, string apellido) : base()
        {
            if (dni > 999999 && !(string.IsNullOrEmpty(nombre)) && !(string.IsNullOrEmpty(apellido)))
            {
                this.dni = dni;
                this.apellido = apellido;
                this.nombre = nombre;
            }
        }

        public override int Dni { get => dni; }
        public override string Nombre { get => nombre; }
        public override string Apellido { get => apellido; }
        public override string Passwd { get => passwd; set => this.passwd = value; }
    }
}
