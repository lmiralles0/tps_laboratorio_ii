using Persona;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front
{
    public partial class Ingreso : Form
    {
        
        public List<Persona.Persona> administradores;
        public List<Persona.Persona> alumnos;
        public List<Persona.Persona> profesores;
        public Ingreso()
        {
            InitializeComponent();
            administradores = new List<Persona.Persona>();
            Persona.Persona ad = new Admin(37882165, "Luciano", "Miralles");
            ad.Passwd = "123";

        }

    }
}
