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
        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
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
            this.linkLabel1.Visible = false;
            this.linkLabel2.Visible = false;
            this.linkLabel3.Visible = false;
            this.linkLabel4.Visible = false;
        }
    }
}
