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
        public List<Admin> administradores;
        public List<Alumno> alumnos;
        public List<Profesor> profesores;
        public Ingreso()
        {
            InitializeComponent();
            administradores = new List<Admin>();
            Admin ad = new Admin(37882165, "Luciano", "Miralles");
            ad.Passwd = "123";

        }

    }
}
