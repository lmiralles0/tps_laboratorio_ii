﻿using Materias;
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
        public List<Materia> materias;
        public List<Alumno> alumnos;

        public Form2_1(List<Materia> mate, List<Alumno> alum)
        {
            InitializeComponent();
            materias = new List<Materia>();
            alumnos = new List<Alumno>();
        }

        private void linkLabelInscripcion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.groupBoxAsistencia.Visible = true;
            this.buttonInscripcionC.Visible= true;
            this.buttonInscripcionI.Visible= true;
            this.comboBoxInscripcion.Visible= true;
            this.linkLabelAsistencia.Visible = false;
        }

        private void buttonInscripcionC_Click(object sender, EventArgs e)
        {
            this.groupBoxAsistencia.Visible = false;
            this.buttonInscripcionC.Visible = false;
            this.buttonInscripcionI.Visible = false;
            this.comboBoxInscripcion.Visible = false;
            this.linkLabelAsistencia.Visible = true;
        }

        private void buttonInscripcionI_Click(object sender, EventArgs e)
        {

        }

        private void linkLabelAsistencia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void buttonAsistenciaC_Click(object sender, EventArgs e)
        {

        }

        private void buttonAsistenciaConfirmar_Click(object sender, EventArgs e)
        {

        }
    }
}