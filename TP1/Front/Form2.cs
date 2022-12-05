using Persona;
using Materias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using Asignaciones;

namespace Front
{
    public partial class Form2 : Form
    {
        public List<Admin> administradores;
        public List<Alumno> alumnos;
        public List<Profesor> profesores;
        public List<Materia> materias;
        public List<Asignacion> asignaciones;
        public List<Materia> materiasAux;
        public Alumno alumnoAux;
        public Profesor profesorAux;


        public Form2(List<Admin> admins, List<Alumno> alumn, List<Profesor> profes, List<Materia> mate, List<Asignacion> asig)
        {
            administradores = new List<Admin>();
            alumnos = new List<Alumno>();
            profesores = new List<Profesor>();
            materias = new List<Materia>();
            asignaciones = new List<Asignacion>();
            administradores = admins;
            alumnos = alumn;
            profesores = profes;
            materias = mate;
            asignaciones = asig;
            materiasAux = new List<Materia>();
            alumnoAux = new Alumno();
            profesorAux = new Profesor();
            InitializeComponent();
        }


        private void toolStripMenuItem1_MouseHover(object sender, EventArgs e)
        {
            this.toolStripMenuItem1.ShowDropDown();
        }

        private void linkLabelAu_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.groupBoxLinkLabelAltaU.Visible = true;
            this.groupBoxAlta.Visible = true;
            this.labelUser.Visible = true;
            this.labelLastName.Visible = true;
            this.labelName.Visible = true;
            this.labelDni.Visible = true;
            this.labelPasswd.Visible = true;
            this.AltaUserComboBox.Visible = true;
            this.AltaTextBoxUserSureName.Visible = true;
            this.AltaTextBoxUserName.Visible = true;
            this.AltaTextBoxUserDni.Visible = true;
            this.AltaTextBoxUserPasswd.Visible = true;
            this.linkLabelAu.Visible = false;
            this.linkLabelRa.Visible = false;
            this.linkLabelAm.Visible = false;
            this.linkLabelAp.Visible = false;
            this.linkLabelAu2.Visible = true;
            this.buttonCerrarAlta.Visible = true;
            this.buttonAgregarAlta.Visible = true;
        }

        public void buttonCerrarAlta_Click(object sender, EventArgs e)
        {
            this.groupBoxLinkLabelAltaU.Visible = false;
            this.groupBoxAlta.Visible = false;
            this.labelUser.Visible = false;
            this.labelLastName.Visible = false;
            this.labelName.Visible = false;
            this.labelDni.Visible = false;
            this.labelPasswd.Visible = false;
            this.AltaUserComboBox.Visible = false;
            this.AltaTextBoxUserSureName.Visible = false;
            this.AltaTextBoxUserName.Visible = false;
            this.AltaTextBoxUserDni.Visible = false;
            this.AltaTextBoxUserPasswd.Visible = false;
            this.linkLabelAu.Visible = true;
            this.linkLabelRa.Visible = true;
            this.linkLabelAm.Visible = true;
            this.linkLabelAp.Visible = true;
            this.buttonCerrarAlta.Visible = false;
            this.buttonAgregarAlta.Visible = false;
            this.AltaUserComboBox.ResetText();
            this.AltaTextBoxUserSureName.ResetText();
            this.AltaTextBoxUserName.ResetText();
            this.AltaTextBoxUserDni.ResetText();
            this.AltaTextBoxUserPasswd.ResetText();

        }



        public void buttonAgregarAlta_Click(object sender, EventArgs e)
        {
            if (this.AltaUserComboBox.Text.Length == 0 || this.AltaTextBoxUserSureName.Text.Length == 0 || this.AltaTextBoxUserName.Text.Length == 0
                || this.AltaTextBoxUserDni.Text.Length == 0 || this.AltaTextBoxUserPasswd.Text.Length == 0)
            {
                MessageBox.Show("Error, campos incompletos ", "Faltal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.AltaUserComboBox.ResetText();
                this.AltaTextBoxUserSureName.ResetText();
                this.AltaTextBoxUserName.ResetText();
                this.AltaTextBoxUserDni.ResetText();
                this.AltaTextBoxUserPasswd.ResetText();
            }

            if (this.AltaUserComboBox.Text == "Administrativo" & !(string.IsNullOrEmpty(this.AltaTextBoxUserName.Text)) && !(string.IsNullOrEmpty(this.AltaTextBoxUserSureName.Text))
                && !(string.IsNullOrEmpty(this.AltaTextBoxUserDni.Text)))
            {
                Admin auxAdmin = new Admin(int.Parse(this.AltaTextBoxUserDni.Text), this.AltaTextBoxUserName.Text, this.AltaTextBoxUserSureName.Text);
                auxAdmin.Passwd = this.AltaTextBoxUserPasswd.Text;
                if (auxAdmin.AddUsuario(administradores, auxAdmin) && (!(Persona.Profesor.Contain(profesores, auxAdmin)) && !(Persona.Alumno.Contain(alumnos, auxAdmin))))
                {
                    buttonAgregarAlta.DialogResult = DialogResult.OK;
                    MensajeExito();
                    InvokeOnClick(buttonCerrarAlta, e);

                }
                else
                {
                    MensajeError();
                    InvokeOnClick(buttonCerrarAlta, e);
                }

            }
            if (this.AltaUserComboBox.Text == "Alumno" && !(string.IsNullOrEmpty(this.AltaTextBoxUserName.Text)) &&
                !(string.IsNullOrEmpty(this.AltaTextBoxUserSureName.Text)) && !(string.IsNullOrEmpty(this.AltaTextBoxUserDni.Text)))
            {
                Alumno auxAlumno = new Alumno(int.Parse(this.AltaTextBoxUserDni.Text), this.AltaTextBoxUserName.Text, this.AltaTextBoxUserSureName.Text);
                auxAlumno.Passwd = this.AltaTextBoxUserPasswd.Text;
                if (auxAlumno.AddUsuario(alumnos, auxAlumno) && (!(Persona.Profesor.Contain(profesores, auxAlumno)) && !(Persona.Admin.Contain(administradores, auxAlumno))))
                {
                    buttonAgregarAlta.DialogResult = DialogResult.OK;
                    MensajeExito();
                    InvokeOnClick(buttonCerrarAlta, e);
                }
                else
                {
                    MensajeError();
                    InvokeOnClick(buttonCerrarAlta, e);
                }
            }
            if (this.AltaUserComboBox.Text == "Profesor" && !(string.IsNullOrEmpty(this.AltaTextBoxUserName.Text)) &&
                !(string.IsNullOrEmpty(this.AltaTextBoxUserSureName.Text)) && !(string.IsNullOrEmpty(this.AltaTextBoxUserDni.Text)))
            {
                Profesor auxProfesor = new Profesor(int.Parse(this.AltaTextBoxUserDni.Text), this.AltaTextBoxUserName.Text, this.AltaTextBoxUserSureName.Text);
                auxProfesor.Passwd = this.AltaTextBoxUserPasswd.Text;
                if (Profesor.AddUsuario(profesores, auxProfesor) && (!(Persona.Admin.Contain(administradores, auxProfesor)) && !(Persona.Alumno.Contain(alumnos, auxProfesor))))
                {
                    buttonAgregarAlta.DialogResult = DialogResult.OK;
                    MensajeExito();
                    InvokeOnClick(buttonCerrarAlta, e);

                }
                else
                {
                    MensajeError();
                    InvokeOnClick(buttonCerrarAlta, e);
                }
            }
            
        }

        private void linkLabelRa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.groupBoxLinkLabelRa.Visible = true;
            this.buttonAgregarRa.Visible = true;
            this.buttonCerrarRa.Visible = true;
            this.groupBoxRa.Visible = true;
            this.linkLabelRa2.Visible = true;
            this.linkLabelRa.Visible = false;
            this.linkLabelAp.Visible = false;
            this.linkLabelAm.Visible = false;
            this.linkLabelAu.Visible = false;
            this.comboBoxAlumnosRa.Visible = true;
            this.comboBoxMateriasRa.Visible = true;
            this.comboBoxRegularRa.Visible = true;
            this.labelRa.Visible = true;
            this.comboBoxAlumnosRa.Text = "Seleccione alumno...";
            this.comboBoxMateriasRa.Text = "Seleccione materia...";
            this.comboBoxRegularRa.Text = "Condicion...";
            this.comboBoxAlumnosRa.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.comboBoxRegularRa.ForeColor = SystemColors.ButtonShadow;
            this.comboBoxMateriasRa.ForeColor = SystemColors.ButtonShadow;
        }

        private void buttonCerrarRa_Click(object sender, EventArgs e)
        {
            this.groupBoxLinkLabelRa.Visible = false;
            this.groupBoxRa.Visible = false;
            this.linkLabelRa2.Visible = false;
            this.linkLabelRa.Visible = true;
            this.buttonAgregarRa.Visible = false;
            this.buttonCerrarRa.Visible = false;
            this.linkLabelAp.Visible = true;
            this.linkLabelAm.Visible = true;
            this.linkLabelAu.Visible = true;
            this.comboBoxAlumnosRa.Visible = false;
            this.comboBoxMateriasRa.Visible = false;
            this.comboBoxRegularRa.Visible = false;
            this.labelRa.Visible = true; 
            this.comboBoxMateriasRa.Enabled = false;
        }

        public void buttonAgregarRa_Click(object sender, EventArgs e)
        {
            if(this.comboBoxRegularRa.SelectedIndex== -1 || this.comboBoxMateriasRa.SelectedIndex == -1 || this.comboBoxRegularRa.SelectedIndex == -1)
            {
                MessageBox.Show("Error, campos incompletos ", "Faltal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Asignacion asignacion = new Asignacion(materiasAux[comboBoxMateriasRa.SelectedIndex], alumnoAux, comboBoxRegularRa.SelectedIndex);
                bool case1 = Asignacion.ModificarAsignacion(asignaciones, asignacion, comboBoxRegularRa.SelectedIndex);
                bool case2 = Asignacion.AddAsignaciones(asignaciones, asignacion);
                if (case1)
                {
                    MessageBox.Show("Asignacion realiza", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InvokeOnClick(buttonCerrarRa, e);
                }
                if(case2)
                {
                    MessageBox.Show("Asignacion realiza", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InvokeOnClick(buttonCerrarRa, e);
                }
                else if (case1 == false && case2 == false)
                {
                    DialogResult result;
                    result = MessageBox.Show("Error cambio ya realizado.", "Fatal", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (result == System.Windows.Forms.DialogResult.Cancel)
                    {
                        InvokeOnClick(buttonCerrarRa, e);
                    }
                    
                }
            }

           
            
        }

        private void linkLabelAm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabelRa.Visible = false;
            this.linkLabelAp.Visible = false;
            this.linkLabelAm.Visible = false;
            this.linkLabelAu.Visible = false;
            this.groupBoxLinkAm.Visible = true;
            this.linkLabelAm2.Visible = true;
            this.groupBoxAm.Visible = true;
            this.textBoxNombreAm.Visible = true;
            this.buttonAgregarAm.Visible = true;
            this.buttonCerrarAm.Visible = true;
            this.labelNombreMateriaAm.Visible = true;
            this.checkBoxCorrelativa1.Visible = true;
            this.labelCorrelativaAm.Visible = true;
            this.comboBoxSeleccionarMateriaAm.Text = "Seleccione correlativa...";
            this.comboBoxSeleccionarMateriaAm.ForeColor = SystemColors.ButtonShadow;
        }


        private void buttonCerrarAm_Click(object sender, EventArgs e)
        {
            this.linkLabelRa.Visible = true;
            this.linkLabelAp.Visible = true;
            this.linkLabelAm.Visible = true;
            this.linkLabelAu.Visible = true;
            this.groupBoxLinkAm.Visible = false;
            this.linkLabelAm2.Visible = false;
            this.groupBoxAm.Visible = false;
            this.textBoxNombreAm.Visible = false;
            this.comboBoxSeleccionarMateriaAm.Visible = false;
            this.buttonAgregarAm.Visible = false;
            this.buttonCerrarAm.Visible = false;
            this.checkBoxCorrelativa1.Visible = false;
            this.labelCorrelativaAm.Visible = false;
            this.textBoxNombreAm.ResetText();
            this.textBoxCodigoAm.ResetText();
            if(checkBoxCorrelativa1.Checked == true)
            {
                checkBoxCorrelativa1.Checked = false;
            }

        }

        public void buttonAgregarAm_Click(object sender, EventArgs e)
        {
            if(this.textBoxNombreAm.Text.Length == 0 || this.textBoxCodigoAm.Text.Length == 0)
            {
                MessageBox.Show("Error, campos incompletos ", "Faltal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Materia materiaAdd;
                if(this.checkBoxCorrelativa1.Checked == true && this.comboBoxSeleccionarMateriaAm.SelectedIndex >= 0)
                {
                    materiaAdd = new Materia(this.textBoxNombreAm.Text, int.Parse(this.textBoxCodigoAm.Text), materias[this.comboBoxSeleccionarMateriaAm.SelectedIndex]);
                    
                    if(materiaAdd.AddMateria(materias, materiaAdd))
                    {
                        buttonAgregarAm.DialogResult = DialogResult.OK;
                        InvokeOnClick(buttonCerrarAm, e);
                        MessageBox.Show("Alta materia exitosa.", "ATENCION!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        buttonAgregarAm.DialogResult = DialogResult.OK;
                        InvokeOnClick(buttonCerrarAm, e);
                        MessageBox.Show("Error al cargar.", "ATENCION!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    materiaAdd = new Materia(this.textBoxNombreAm.Text, int.Parse(this.textBoxCodigoAm.Text));
                    if(materiaAdd.AddMateria(materias, materiaAdd))
                    {
                        buttonAgregarAm.DialogResult = DialogResult.OK;
                        InvokeOnClick(buttonCerrarAm, e);
                        MessageBox.Show("Alta materia exitosa.", "ATENCION!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        buttonAgregarAm.DialogResult = DialogResult.OK;
                        InvokeOnClick(buttonCerrarAm, e);
                        MessageBox.Show("Error al cargar.", "ATENCION!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void linkLabelAp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabelRa.Visible = false;
            this.linkLabelAu.Visible = false;
            this.linkLabelAp.Visible = false;
            this.linkLabelAm.Visible = false;
            this.groupBoxAp.Visible = true;
            this.groupBoxLinkAp.Visible = true;
            this.linkLabelAp2.Visible = true;
            this.buttonAgregarAp.Visible = true;
            this.buttonCerrarAp.Visible = true;
            this.comboBoxMateriasAp.Visible = true;
            this.comboBoxProfesorAp.Visible = true;
            this.labelMateriaSeleccionar.Visible = true;
            this.labelProfesorSeleccionar.Visible = true; 
            this.comboBoxProfesorAp.Text = "Seleccione...";
            this.comboBoxMateriasAp.Text = "Seleccione...";
            this.comboBoxProfesorAp.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.comboBoxMateriasAp.ForeColor = SystemColors.ButtonShadow;
        }

        private void buttonCerrarAp_Click(object sender, EventArgs e)
        {
            this.linkLabelRa.Visible = true;
            this.linkLabelAu.Visible = true;
            this.linkLabelAp.Visible = true;
            this.linkLabelAm.Visible = true;
            this.groupBoxAp.Visible = false;
            this.groupBoxLinkAp.Visible = false;
            this.linkLabelAp2.Visible = false;
            this.buttonAgregarAp.Visible = false;
            this.buttonCerrarAp.Visible = false;
            this.comboBoxMateriasAp.Visible = false;
            this.comboBoxProfesorAp.Visible = false;
            this.labelMateriaSeleccionar.Visible = false;
            this.labelProfesorSeleccionar.Visible = false;

        }
        private void buttonAgregarAp_Click(object sender, EventArgs e)
        {

            if (this.comboBoxProfesorAp.SelectedIndex == -1 || this.comboBoxMateriasAp.SelectedIndex == -1)
            {
                MessageBox.Show("Error, campos incompletos ", "Faltal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Materia matAux; 
                matAux = materiasAux[comboBoxMateriasAp.SelectedIndex];
                int indice = Materia.IndexOfMateria(materias, matAux);
                if(indice >= 0)
                {
                    if(Profesor.AddUsuario(materias[indice].profesores, profesores[comboBoxProfesorAp.SelectedIndex]))
                    {
                        MessageBox.Show("Asigancion realiza", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        InvokeOnClick(buttonCerrarAp, e);
                    }
                    else
                    {
                        buttonAgregarAm.DialogResult = DialogResult.OK;
                        InvokeOnClick(buttonCerrarAp, e);
                        MessageBox.Show("Error al cargar.", "ATENCION!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }

        }

        public void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void MensajeError()
        {
            MessageBox.Show("Error DNI ya registrado.", "ATENCION!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void MensajeExito()
        {
            MessageBox.Show("Alta exitosa.", "AVISO: ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        #region Regularidad Alumno

        private void comboBoxAlumnosRa_Enter(object sender, EventArgs e)
        {

            alumnoBindingSource.Clear();

            comboBoxAlumnosRa.ForeColor = Color.Black;
            
            comboBoxMateriasRa.Enabled = false;
            if (alumnos.Count > 0 && alumnos != null)
            {
                foreach (Alumno a in alumnos)
                {
                    alumnoBindingSource.Add(a);
                }
            }   
           
        }

        private void comboBoxMateriasRa_Enter(object sender, EventArgs e)
        {
            comboBoxMateriasRa.ResetText();
            materiaBindingSource.Clear();   
            comboBoxMateriasRa.ForeColor = Color.Black;
            foreach (Materia b in materiasAux)
            {
                materiaBindingSource.Add(b);
            }
        }


        public void LoadComboBoxMateriaRa()
        {
            
            string buffer = comboBoxAlumnosRa.Text;
  
            foreach (Alumno a in alumnos)
            {
                if (buffer.Contains(a.Dni.ToString()))
                {
                    alumnoAux = a;
                    break;
                }
            }
            foreach (Materia a in materias)
            {
                if ((Persona.Alumno.Contain(a.alumnos, alumnoAux)))
                {
                    materiasAux.Add(a);
                }
            }
        }

        private void comboBoxAlumnosRa_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMateriasRa.ForeColor = SystemColors.ButtonShadow;
            comboBoxMateriasRa.Text = "Seleccione materia...";
        }

        private void comboBoxAlumnosRa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            materiasAux.Clear();
            comboBoxAlumnosRa.ForeColor = Color.Black;
            comboBoxMateriasRa.Enabled = true;
            LoadComboBoxMateriaRa();
        }
        private void comboBoxRegularRa_Enter(object sender, EventArgs e)
        {
            comboBoxRegularRa.ForeColor = Color.Black;
        }

        #endregion

        #region Alta Materia
        private void checkBoxCorrelativa1_CheckedChanged(object sender, EventArgs e)
        {
            if(this.checkBoxCorrelativa1.Checked == true)
            {
                materiaBindingSource.Clear();
                this.comboBoxSeleccionarMateriaAm.Text = "Seleccione correlativa...";
                this.comboBoxSeleccionarMateriaAm.ForeColor = SystemColors.ButtonShadow;
                this.comboBoxSeleccionarMateriaAm.Visible = true;
            }
            if (this.checkBoxCorrelativa1.Checked == false)
            {
                this.comboBoxSeleccionarMateriaAm.Text = "Seleccione correlativa...";
                this.comboBoxSeleccionarMateriaAm.ForeColor = SystemColors.ButtonShadow;
                this.comboBoxSeleccionarMateriaAm.Visible = false;
            }

        }

        private void comboBoxSeleccionarMateriaAm_Enter(object sender, EventArgs e)
        {
            comboBoxSeleccionarMateriaAm.ForeColor = Color.Black;
            materiaBindingSource.Clear();

            if (materias.Count > 0 && materias != null)
            {
                foreach (Materia a in materias)
                {
                    materiaBindingSource.Add(a);
                }
            }
        }

        #endregion

        #region Asiganar Profesor

        private void comboBoxProfesorAp_Enter(object sender, EventArgs e)
        {
            profesorBindingSource.Clear();

            comboBoxProfesorAp.ForeColor = Color.Black;
            

            comboBoxMateriasAp.Enabled = false;
            if (profesores.Count > 0 && profesores != null)
            {
                foreach (Profesor a in profesores)
                {
                    profesorBindingSource.Add(a);
                }
            }
        }

        private void comboBoxProfesorAp_SelectedIndexChanged(object sender, EventArgs e)
        {
            materiasAux.Clear();
            materiaBindingSource.Clear();
            comboBoxProfesorAp.ForeColor = Color.Black;
            comboBoxMateriasAp.Enabled = true;
            this.comboBoxMateriasAp.ForeColor = SystemColors.ButtonShadow;
            comboBoxMateriasAp.Text = "Seleccione...";
            LoadComboBoxMateriaAp();
        }

        private void comboBoxMateriasAp_Enter(object sender, EventArgs e)
        {
            comboBoxMateriasAp.ResetText();
            comboBoxMateriasAp.Enabled = true;
            comboBoxMateriasAp.ForeColor = Color.Black;
            foreach (Materia b in materiasAux)
            {
                materiaBindingSource.Add(b);
            }
        }

        public void LoadComboBoxMateriaAp()
        {

            string buffer = comboBoxProfesorAp.Text;

            foreach (Profesor a in profesores)
            {
                if (buffer.Contains(a.Dni.ToString()))
                {
                    profesorAux = a;
                    break;
                }
            }
            foreach (Materia a in materias)
            {
                if (!(Persona.Profesor.Contain(a.profesores, profesorAux)))
                {
                    materiasAux.Add(a);
                }
            }
        }

        #endregion
    }

    

}
