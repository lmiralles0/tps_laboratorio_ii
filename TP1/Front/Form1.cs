using Persona;
using Materias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Asignaciones;

namespace Front
{
    public partial class Ingreso : Form
    {
        public List<Admin> administradores;
        public List<Alumno> alumnos;
        public List<Profesor> profesores;
        public List<Materia> materias;
        public List<Asignacion> asignaciones;

        public Ingreso()
        {
            InitializeComponent();
            administradores = new List<Admin>();
            profesores = new List<Profesor>();
            alumnos = new List<Alumno>();
            materias= new List<Materia>();
            asignaciones = new List<Asignacion>();
            Harcodeo();
        }

        
        private void Acceder_Click(object sender, EventArgs e)
        {
            if(this.KindUser.Text.Length == 0 || this.txtBoxPasswd.Text.Length == 0 || this.txtBoxDNI.Text.Length == 0)
            {
                MessageBox.Show("Error, campos incompletos ", "Faltal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.KindUser.SelectedIndex = -1;
                this.txtBoxDNI.ResetText();
                this.txtBoxPasswd.ResetText();
            }


            ///ADMIN 
            if(KindUser.Text == "Administrador" && !(string.IsNullOrEmpty(txtBoxDNI.Text)) && !(string.IsNullOrEmpty(txtBoxPasswd.Text)))
            {

                Admin ad = new Admin();           
                ad = ad.LookUp(administradores, int.Parse(txtBoxDNI.Text), txtBoxPasswd.Text);

                if (ad != null)
                {
                    Hide();
                    Form2 form2 = new Form2(this.administradores,this.alumnos, this.profesores, this.materias, this.asignaciones);
                    form2.toolStripMenuItem1.Text = ($"{ad.Apellido}  {ad.Nombre}");
                    form2.ShowDialog();
                    
                    if(form2.buttonAgregarAlta.DialogResult == DialogResult.OK && form2.AltaUserComboBox.Text == "Administrativo")
                    {
                        administradores = form2.administradores;
                    }

                    if (form2.buttonAgregarAlta.DialogResult == DialogResult.OK && form2.AltaUserComboBox.Text == "Alumno")
                    {
                        alumnos = form2.alumnos;
                    }

                    if (form2.buttonAgregarAlta.DialogResult == DialogResult.OK && form2.AltaUserComboBox.Text == "Profesor")
                    {
                        profesores = form2.profesores;
                    }

                    


                    if (form2.Validate())
                    {
                        this.Show();
                        this.KindUser.SelectedIndex = -1;
                        this.txtBoxDNI.ResetText();
                        this.txtBoxPasswd.ResetText();
                    }
                }
                else
                {
                    DialogResult result;
                    result = MessageBox.Show("Error usuario no logueado.", "ATENCION!!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    if(result == System.Windows.Forms.DialogResult.Cancel)
                    {
                        this.KindUser.SelectedIndex = -1;
                        this.txtBoxDNI.ResetText();
                        this.txtBoxPasswd.ResetText();
                    }
                }
            }

            ///ALUMNO
            if(KindUser.Text == "Alumno" && !(string.IsNullOrEmpty(txtBoxDNI.Text)) && !(string.IsNullOrEmpty(txtBoxPasswd.Text)))
            {
                
                Alumno aux = new Alumno();
                aux = aux.LookUp(alumnos, int.Parse(txtBoxDNI.Text), txtBoxPasswd.Text);

                if(aux != null)
                {
                    Hide();
                    Form2_1 form3 = new Form2_1(this.materias, this.alumnos);
                    form3.ShowDialog();
                    
                    
                    
                    
                    
                    if (form3.Validate())
                    {
                        this.Show();
                        this.KindUser.SelectedIndex = -1;
                        this.txtBoxDNI.ResetText();
                        this.txtBoxPasswd.ResetText();
                    }

                }
                else
                {
                    DialogResult result;
                    result = MessageBox.Show("Error usuario no logueado.", "ATENCION!!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    if (result == System.Windows.Forms.DialogResult.Cancel)
                    {
                        this.KindUser.SelectedIndex = -1;
                        this.txtBoxDNI.ResetText();
                        this.txtBoxPasswd.ResetText();
                    }
                }
            }

            ///PROFESOR
            if (KindUser.Text == "Profesor" && !(string.IsNullOrEmpty(txtBoxDNI.Text)) && !(string.IsNullOrEmpty(txtBoxPasswd.Text)))
            {
                Profesor aux = new Profesor();
                aux = aux.LookUp(profesores, int.Parse(txtBoxDNI.Text), txtBoxPasswd.Text);

                if (aux != null)
                {
                    Hide();
                    //Form2_1 form3 = new Form2_1();
                    //form3.ShowDialog();
                    /*if (form3.Validate())
                    {
                        this.Show();
                        this.KindUser.SelectedIndex = -1;
                        this.txtBoxDNI.ResetText();
                        this.txtBoxPasswd.ResetText();
                    }*/

                }
                else
                {
                    DialogResult result;
                    result = MessageBox.Show("Error usuario no logueado.", "ATENCION!!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    if (result == System.Windows.Forms.DialogResult.Cancel)
                    {
                        this.KindUser.SelectedIndex = -1;
                        this.txtBoxDNI.ResetText();
                        this.txtBoxPasswd.ResetText();
                    }
                }
            }

        }

        public void Harcodeo()
        {
            Materia mat1 = new Materia("Matematica", 100);
            Materia mat2 = new Materia("Programacion II", 115);
            Materia mat3 = new Materia("Laboratorio II", 116);
            Materia mat4 = new Materia("Programacion", 110, mat2);
            Materia mat5 = new Materia("Laboratorio", 111, mat3);
            Materia mat6 = new Materia("SPD", 109);

            materias.Add(mat1);
            materias.Add(mat2);
            materias.Add(mat3);
            materias.Add(mat4);
            materias.Add(mat5);
            materias.Add(mat6);

            Alumno auxa = new Alumno(17042552, "Horacio", "Miralles");
            auxa.Passwd = "456";
            auxa.AddUsuario(alumnos, auxa);

            Admin ad = new Admin(37882165, "Luciano", "Miralles");
            ad.Passwd = "123";
            ad.AddUsuario(administradores, ad);
            Alumno auxas = new Alumno(4267148, "Oscar", "Miralles");
            auxas.Passwd = "456";
            auxas.AddUsuario(alumnos, auxas);
            
            mat1.alumnos.Add(auxa);
           

        }

        private void buttonAdminSession_Click(object sender, EventArgs e)
        {
            if(administradores != null)
            {
                KindUser.SelectedIndex = 0;
                txtBoxDNI.Text = administradores[0].Dni.ToString();
                txtBoxPasswd.Text = administradores[0].Passwd;

            }
        }

        private void buttonSessionAlumno_Click(object sender, EventArgs e)
        {
            if (alumnos != null)
            {
                KindUser.SelectedIndex = 1;
                txtBoxDNI.Text = alumnos[0].Dni.ToString();
                txtBoxPasswd.Text = alumnos[0].Passwd;

            }
        }

        private void buttonSessionTeacher_Click(object sender, EventArgs e)
        {
            if(profesores != null)
            {
                KindUser.SelectedIndex = 2;
                txtBoxDNI.Text = profesores[0].Dni.ToString();
                txtBoxPasswd.Text = profesores[0].Passwd;
            }

        }
    }
}
