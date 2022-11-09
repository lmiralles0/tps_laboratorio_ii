using Persona;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace Front
{
    public partial class Form2 : Form
    {
 
        public Form2()
        {
            InitializeComponent();

        }
 
        private void toolStripMenuItem1_MouseHover(object sender, EventArgs e)
        {
            this.toolStripMenuItem1.ShowDropDown() ;
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

        }

        

        public void buttonAgregarAlta_Click(object sender, EventArgs e)
        {
            
            if ((this.AltaUserComboBox.Text == "Administrativo" || this.AltaUserComboBox.Text == "Alumno" || this.AltaUserComboBox.Text == "Profesor") &&
                !(string.IsNullOrEmpty(this.AltaTextBoxUserName.Text)) && !(string.IsNullOrEmpty(this.AltaTextBoxUserSureName.Text))
                && !(string.IsNullOrEmpty(this.AltaTextBoxUserDni.Text)))
            {
                buttonAgregarAlta.DialogResult = DialogResult.OK;
                MessageBox.Show("Ok");
                InvokeOnClick(buttonCerrarAlta, e);
            }
            else
            {
                MessageBox.Show("No");
                InvokeOnClick(buttonCerrarAlta, e);
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

        }

        public void buttonAgregarRa_Click(object sender, EventArgs e)
        {
            
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
            this.comboBoxSeleccionarMateriaAm.Visible = true;
            this.buttonAgregarAm.Visible = true;
            this.buttonCerrarAm.Visible = true;
            this.labelNombreMateriaAm.Visible = true;
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

        }

        public void buttonAgregarAm_Click(object sender, EventArgs e)
        {
            
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

        }

        private void buttonAgregarAp_Click(object sender, EventArgs e)
        {
            
        }

        public void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
