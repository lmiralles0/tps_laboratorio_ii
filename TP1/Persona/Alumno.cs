using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    public sealed class Alumno : Persona
    {
        public Alumno(): base()
        {

        }

        public Alumno(int dni, string nombre, string apellido) : base()
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
        public override string Passwd
        {
            get
            {
                return passwd;
            }
            set
            {
                this.passwd = value;
            }
        }

        
    }


}
