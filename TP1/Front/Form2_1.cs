using Asignaciones;
using Materias;
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
    public partial class Form2_1 : Form
    {
        public List<Alumno> alumnos;
        public List<Asignacion> asignaciones;
        public Alumno alumno;
        public List<Materia> materias;
        public List<Materia> materiasAux;

        public Form2_1(List<Materia> mate, List<Alumno> alum, List<Asignacion> asig, Alumno al)
        {
            InitializeComponent();
            alumnos = new List<Alumno>();
            asignaciones = new List<Asignacion>();
            materias = new List<Materia>();
            materiasAux = new List<Materia>();
            materias = mate;
            alumnos = alum;
            asignaciones = asig;
            alumno = al;

        }

        private void linkLabelInscripcion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.groupBoxInscripcion.Visible = true;
            this.buttonInscripcionC.Visible= true;
            this.buttonInscripcionI.Visible= true;
            this.comboBoxInscripcion.Visible= true;
            this.linkLabelAsistencia.Visible = false;
            this.comboBoxInscripcion.Text = "Seleccione materia...";
            this.comboBoxInscripcion.ForeColor = SystemColors.ButtonShadow;
        }

        private void buttonInscripcionC_Click(object sender, EventArgs e)
        {

            this.groupBoxInscripcion.Visible = false;
            this.buttonInscripcionC.Visible = false;
            this.buttonInscripcionI.Visible = false;
            this.comboBoxInscripcion.Visible = false;
            this.linkLabelAsistencia.Visible = true;
        }

        private void buttonInscripcionI_Click(object sender, EventArgs e)
        {
            if(comboBoxInscripcion.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione una materia.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                if()
                if(Asignacion.SimultaniedadMaterias(asignaciones, alumno))
                {
                    int indice;
                    Asignacion asig = new Asignacion(materiasAux[comboBoxInscripcion.SelectedIndex], alumno);
                    asig.simultaniedadInscripcion = 1;
                    asignaciones.Add(asig);
                    indice = Materia.IndexOfMateria(materias, materiasAux[comboBoxInscripcion.SelectedIndex]);
                    if(indice > -1)
                    {
                        if(Persona.Alumno.AddUsuario(materias[indice].alumnos, alumno))
                        {

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Alumno supero la simultaniedad para la inscripcion de materias.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void linkLabelAsistencia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.groupBoxAsistencia.Visible = true;
            this.checkBoxPresente.Visible = true;
            this.monthCalendar.Visible = true;
            this.buttonAsistenciaC.Visible = true;
            this.buttonAsistenciaConfirmar.Visible = true;
            
        }

        private void buttonAsistenciaC_Click(object sender, EventArgs e)
        {
            this.groupBoxAsistencia.Visible = false;
            this.checkBoxPresente.Visible = false;
            this.monthCalendar.Visible = false;
            this.buttonAsistenciaC.Visible = false;
            this.buttonAsistenciaConfirmar.Visible = false;
        }

        private void buttonAsistenciaConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxInscripcion_Enter(object sender, EventArgs e)
        {
            materiasAux.Clear();
            materiaBindingSource.Clear();
            this.comboBoxInscripcion.ForeColor = Color.Black;

            foreach(Materia a in materias)
            {
                if (!(Persona.Alumno.Contain(a.alumnos, alumno)))
                {
                    materiasAux.Add(a);
                }
            }

            foreach(Materia b in materiasAux)
            {
                materiaBindingSource.Add(b);
            }

        }

    }
}
