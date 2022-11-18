using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    public sealed class Profesor : Persona
    {
        public Profesor(): base()
        {

        }
        public Profesor(int dni, string nombre, string apellido) : base()
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


        public static bool Contain(List<Profesor> p, Persona op)
        {
            bool result = false;
            if (p != null && op != null)
            {
                foreach (Profesor a in p)
                {
                    if (a.dni == op.dni)
                    {
                        result = true;
                        break;
                    }
                }
            }
            return result;
        }


        public bool AddUsuario(List<Profesor> p, Profesor op)
        {
            bool result = false;
            if (!(Contain(p, op)))
            {
                p.Add(op);
                result = true;
            }
            return result;
        }

        public Profesor LookUp(List<Profesor> ad, int dni, string passwd)
        {
            Profesor result = null;
            if (ad != null && dni > 999999 && !(string.IsNullOrWhiteSpace(passwd)))
            {
                foreach (Profesor a in ad)
                {
                    if (a.dni == dni && a.passwd == passwd)
                    {
                        result = a;
                        break;
                    }
                }

            }
            return result;
        }
    }
}
