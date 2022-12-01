using System;
using System.Collections.Generic;
using Materias;
using Persona;

namespace Asignaciones
{
    public enum Regularidad
    {
        Libre, 
        Regular
    }
    public class Asignacion
    {
        private Materia _materia;
        private Alumno _alumno;
        private Regularidad _regularidad;
        public Dictionary<DateTime, int> parciales;

        public Asignacion(Materia materia, Alumno alumno, Regularidad regularidad, Dictionary<DateTime, int> parciales)
        {
            _materia = materia;
            _alumno = alumno;
            _regularidad = regularidad;
            this.parciales = parciales;
        }

        public Materia Materia
        {
            get { return _materia; }
            set { if (value != null) { _materia = value; } }
        }

        public Alumno Alumno
        {
            get { return _alumno; }
            set { if (value != null) { _alumno = value; } }
        }

        public Regularidad Regularidad
        {
            get { return _regularidad; }
            set {  _regularidad = value; }
        }
    }
}
