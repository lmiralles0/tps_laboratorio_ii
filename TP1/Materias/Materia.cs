using Persona;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Materias
{
    public class Materia
    {
        private string _nombre;
        private int _codigo;
        private Materia _correlativa;
        public List<Profesor> profesores;
        public List<Alumno> alumnos;

        public Materia(string asignatura, int codigo)
        {
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




    }
}
