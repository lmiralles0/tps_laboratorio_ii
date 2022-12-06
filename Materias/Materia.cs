using Persona;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Net;
using System.Text;

namespace Materias
{
    public class Materia
    {
        private string _nombre;
        private int _codigo;
        private Materia _correlativa;
        public List<DateTime> examenes;
        public List<Profesor> profesores;
        public List<Alumno> alumnos;
        
        static Materia()
        {

        }

        public Materia(string asignatura, int codigo)
        {
            examenes= new List<DateTime>();
            profesores = new List<Profesor>();
            alumnos = new List<Alumno>();
            Asignatura = asignatura;
            Codigo = codigo;
        }

        public Materia(string asignatura, int codigo, Materia correlativa) : this(asignatura, codigo)
        {
            Correlativa = correlativa;
        }


        public string Asignatura
        { get { return _nombre; } set { _nombre = value; } }

        public int Codigo
        { get { return _codigo; } set { _codigo = value; } }

        public Materia Correlativa
        { get { return _correlativa; }set { _correlativa = value; } }

        public string SelectedMateria
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(Codigo);
                sb.Append(" - ");
                sb.Append(Asignatura);
                return sb.ToString();
            }
        }

        public static int IndexOfMateria(List<Materia> p, Materia op)
        {
            int result = -1;
            for(int i = 0; i < p.Count; i++)
            {
                if(p[i] == op)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }

        public static bool Contain(List<Materia> p, Materia op)
        {
            bool result = false;
            if (p != null && op != null)
            {
                foreach (Materia a in p)
                {
                    if(op.Asignatura == a.Asignatura || op.Codigo == a.Codigo) 
                    {
                        result = true;
                        break;
                    }
                }
            }
            return result;
        }


        public bool AddMateria(List<Materia> p, Materia pa)
        {
            bool result = false;
            if (!(Contain(p, pa)))
            {
                p.Add(pa);
                result = true;
            }
            return result;
        }

        public static bool operator ==(Materia a, Materia b)
        {
            return a.Asignatura == b.Asignatura && a.Asignatura == b.Asignatura;
        }

        public static bool operator !=(Materia a, Materia b)
        { return !(a == b); }

    }
}
