using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.SymbolStore;
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
        public int simultaniedadInscripcion;


        public Asignacion(Materia materia, Alumno alumno)
        {
            Materia = materia;
            Alumno = alumno;
        }

        public Asignacion(Materia materia, Alumno alumno, int regularidad) : this(materia, alumno)
        {
            Regularidad = (Regularidad)regularidad;
        }

        public Asignacion(Materia materia, Alumno alumno, int regularidad, Dictionary<DateTime, int> parciales) : this(materia, alumno, regularidad)
        {
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
            set 
            {
                _regularidad = value;
            }
        }


        public static bool ContainAlumno(List<Asignacion> asig, Alumno alum)
        {
            bool result = false;
            if(asig != null && alum != null)
            {
                foreach(Asignacion a in asig) 
                {
                    if(a.Alumno.Dni == alum.Dni)
                    {
                        result = true;
                        break;
                    }
                }
            }
            return result;
        }

        public static bool ContainMateria(List<Asignacion> asig, Materia mate)
        {
            bool result = false;
            if (asig != null && mate != null)
            {
                foreach (Asignacion a in asig)
                {
                    if(a.Materia.Codigo == mate.Codigo)
                    {
                        result = true;
                        break;
                    }
                }
            }
            return result;
        }
        
        public static int IndexOfAlumnoMateria(List<Asignacion> asig, Alumno alum, Materia mat)
        {
            int result = -1;
            if(asig != null && alum != null)
            {
                for (int i = 0; i < asig.Count; i++)
                {
                    if (asig[i].Alumno.Dni == alum.Dni && asig[i].Materia.Codigo == mat.Codigo)
                    {
                        result = i;
                        break;
                    }
                }
            }
            return result;
        }

        public static bool AddAsignaciones(List<Asignacion> asig, Alumno alum, Materia mate)
        {
            bool result = false;
            Asignacion asignacion;
            if(!(ContainAlumno(asig, alum)) && !(ContainMateria(asig, mate)))
            {
                asignacion = new Asignacion(mate, alum);
                asig.Add(asignacion);
                result = true;
            }
            return result;
        }


        public static bool AddAsignaciones(List<Asignacion> asig, Asignacion asigAux)
        {
            bool result = false;
            if (asigAux != null && !(ContainAlumno(asig, asigAux.Alumno)) && !(ContainMateria(asig, asigAux.Materia)))
            {
                asig.Add(asigAux);
                result = true;
            }
            return result;
        }


        public static bool ModificarAsignacion(List<Asignacion> asig, Asignacion asigAux, int regularidad)
        {
            bool result = false;
            int indice;
            indice = IndexOfAlumnoMateria(asig, asigAux.Alumno, asigAux.Materia); 
            if (asig != null && asigAux != null && regularidad >= 0 && regularidad <= 1 && indice >= 0 && asig[indice].Regularidad != (Regularidad) regularidad)
            {
                asig[indice].Regularidad = (Regularidad)regularidad;
                result = true;
            }
            return result;
        }


        public static bool SimultaniedadMaterias(List<Asignacion> asignaciones, Alumno al)
        {
            bool result = false;
            int count = 0;
            if(asignaciones != null && al != null) 
            {
                if(asignaciones.Count == 0)
                {
                    result = true;
                }
                else
                {
                    for(int i = 0; i < asignaciones.Count; i++)
                    {
                        if(asignaciones[i].Alumno.Dni == al.Dni && asignaciones[i].simultaniedadInscripcion == 1)
                        {
                            result = true;
                            count++;
                        }
                        else
                        {
                            result = true;
                        }
                        if (count == 2)
                        {
                            result = false;
                            break;
                        }
                    }
                }
            }
            return result;
        }
    }
}
