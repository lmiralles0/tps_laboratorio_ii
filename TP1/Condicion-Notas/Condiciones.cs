using System;
using System.Collections.Generic;
using Materias;
using Persona;

namespace Condicion_Notas
{
    namespace Condicion_Notas
    {

        public enum Condicion
        {
            Libre,
            Regular,
            Aprobada
        }
        public class Condiciones
        {

            public Dictionary <(Alumno, Materia) , Condicion>  dictionary; 
            private int _nota;
            public Condiciones(int nota) 
            {
                if(nota > 0 && nota <= 10)
                {
                    dictionary = new Dictionary<(Alumno, Materia), Condicion>();
                    Nota = nota;
                }
            }

            public int Nota { get => this._nota; set => _nota = value; }



        }
    }

}
