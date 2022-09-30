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
        //public List<Persona.Persona> alumnos;
        //public List<Persona.Persona> profesores;
        public Ingreso()
        {
            InitializeComponent();
            administradores = new List<Admin>();
            Admin ad = new Admin(37882165, "Luciano", "Miralles");
            ad.Passwd = "123";
            ad.AddUsuario(administradores, ad);
        }

        private void Acceder_Click(object sender, EventArgs e)
        {
            switch(KindUser.Text)
            {
                case "Administrador":
                    break;

            }
            if(KindUser.Text == "Administrador" &&  !(string.IsNullOrEmpty(txtBoxDNI.Text)) && !(string.IsNullOrEmpty(txtBoxPasswd.Text)))
            {
                Admin ad = new Admin();
                ad = ad.LookUp(administradores, int.Parse(txtBoxDNI.Text), txtBoxPasswd.Text);
                if(ad != null)
                {
                    Form2 form = new Form2();
                    form.ShowDialog(this);  
                                
                }
                else
                {
                    MessageBox.Show("Error", " holass", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Error", "Atencio", MessageBoxButtons.OKCancel);
            }
        }
    }
}
