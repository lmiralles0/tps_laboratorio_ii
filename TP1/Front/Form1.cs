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
            profesores = new List<Profesor>();
            alumnos = new List<Alumno>();
        }

        
        private void Acceder_Click(object sender, EventArgs e)
        {
            if(this.KindUser.Text.Length == 0 || this.txtBoxPasswd.Text.Length == 0 || this.txtBoxDNI.Text.Length == 0)
            {
                MessageBox.Show("Error, campos incompletos ", "Faltal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.KindUser.ResetText();
                this.txtBoxDNI.ResetText();
                this.txtBoxPasswd.ResetText();
            }


            ///ADMIN 
            if (KindUser.Text == "Administrador" &&  !(string.IsNullOrEmpty(txtBoxDNI.Text)) && !(string.IsNullOrEmpty(txtBoxPasswd.Text)))
            {
                
                Admin ad = new Admin(37882165, "Luciano", "Miralles");
                ad.Passwd = "123";
                ad.AddUsuario(administradores, ad);                
                ad = ad.LookUp(administradores, int.Parse(txtBoxDNI.Text), txtBoxPasswd.Text);

                if (ad != null)
                {
                    Hide();
                    Form2 form2 = new Form2(this.administradores,this.alumnos, this.profesores);
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
                        this.KindUser.ResetText();
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
                        this.KindUser.ResetText();
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
                    Form2_1 form3 = new Form2_1();
                    form3.ShowDialog();
                    if (form3.Validate())
                    {
                        this.Show();
                        this.KindUser.ResetText();
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
                        this.KindUser.ResetText();
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
                        this.KindUser.ResetText();
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
                        this.KindUser.ResetText();
                        this.txtBoxDNI.ResetText();
                        this.txtBoxPasswd.ResetText();
                    }
                }
            }

        }
    }
}
