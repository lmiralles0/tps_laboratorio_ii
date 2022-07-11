using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;



namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {

        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        

        private void btnOperar_Click(object sender, EventArgs e)
        {
            string num1 = this.txtNumero1.Text;
            string num2 = this.txtNumero2.Text;
            string operando = this.cmbOperador.Text;
            this.lblResultado.Text = (Operar(num1, num2, operando)).ToString();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Operando num1 = new Operando(this.txtNumero1.Text);
            Operando num2 = new Operando(this.txtNumero2.Text);
        }

        private void Limpiar ()
        {
            this.txtNumero1.Text = string.Empty;
            this.txtNumero2.Text = string.Empty;
            this.cmbOperador.SelectedIndex = 0;
            this.lblResultado.Text = string.Empty;

        }

        private void cmbOperador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public static double Operar(string numero1, string numero2, string operador)
        {
            Operando aux1 = new Operando(numero1);
            Operando aux2 = new Operando(numero2);
            return Calculadora.Operar(aux1, aux2, char.Parse(operador));
        }
         
        /*if(MessageBox.Show("Desea salir?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
            {
                e.Cancel = true;
            }*/
    }
}
