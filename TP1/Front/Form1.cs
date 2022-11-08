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
            if(KindUser.Text == "Administrador" &&  !(string.IsNullOrEmpty(txtBoxDNI.Text)) && !(string.IsNullOrEmpty(txtBoxPasswd.Text)))
            {
                Admin ad = new Admin(37882165, "Luciano", "Miralles");
                ad.Passwd = "123";
                ad.AddUsuario(administradores, ad);                
                ad = ad.LookUp(administradores, int.Parse(txtBoxDNI.Text), txtBoxPasswd.Text);
                
                if(ad != null)
                {
                    Hide();
                    Form2 form2 = new Form2();
                    form2.toolStripMenuItem1.Text = ($"{ad.Apellido}  {ad.Nombre}");
                    form2.ShowDialog();
                    if(form2.Validate())
                    {
                        this.KindUser.ResetText();
                        this.txtBoxDNI.Text = "";
                        this.txtBoxPasswd.Text = "";
                        this.Show();
                    }
                                        
                    
                }
                else
                {
                    MessageBox.Show("Error", " holass", MessageBoxButtons.OK);
                    this.KindUser.ResetText();
                    this.txtBoxDNI.Text = "";
                    this.txtBoxPasswd.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Error", "Atencio", MessageBoxButtons.OKCancel);
                this.KindUser.ResetText();
                this.txtBoxDNI.Text = "";
                this.txtBoxPasswd.Text = "";
            }
            if(KindUser.Text == "Alumno" && !(string.IsNullOrEmpty(txtBoxDNI.Text)) && !(string.IsNullOrEmpty(txtBoxPasswd.Text)))
            {

            }
        }
    }
}
