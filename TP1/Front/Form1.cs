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
        public Ingreso()
        {
            InitializeComponent();
            administradores = new List<Admin>();
        }
        
        private void Acceder_Click(object sender, EventArgs e)
        {
            if (KindUser.Text == "Administrador" &&  !(string.IsNullOrEmpty(txtBoxDNI.Text)) && !(string.IsNullOrEmpty(txtBoxPasswd.Text)))
            {
                Admin ad = new Admin(37882165, "Luciano", "Miralles");
                ad.Passwd = "123";
                ad.AddUsuario(administradores, ad);
;                
                ad = ad.LookUp(administradores, int.Parse(txtBoxDNI.Text), txtBoxPasswd.Text);
                
                if(ad != null)
                {
                    Hide();
                    Form2 form2 = new Form2();
                    form2.toolStripMenuItem1.Text = ($"{ad.Apellido}  {ad.Nombre}");
                    form2.ShowDialog();
                    Close();
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
