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
        private void linkLabelAu2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.groupBoxAlta2.Visible = true;
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

        private void buttonCerrarAlta_Click(object sender, EventArgs e)
        {
            this.groupBoxAlta2.Visible = false;
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
            this.linkLabelAu2.Visible = false;
            this.buttonCerrarAlta.Visible = false;
            this.buttonAgregarAlta.Visible = false;
        }

        private void linkLabelRa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
    }
}
