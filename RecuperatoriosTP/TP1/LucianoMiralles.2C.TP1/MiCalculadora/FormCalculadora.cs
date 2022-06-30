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
            Operando num1 = new Operando(this.txtNumero1.Text);
            Operando num2 = new Operando(this.txtNumero2.Text);
            string operador = this.cmbOperador.ProductName;
            double n = Calculadora.Operar(num1, num2, '+');
            this.lblResultado.Text = n.ToString();
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

        }

        private void cmbOperador_SelectedIndexChanged(object sender, EventArgs e)
        {
            string operador = this.cmbOperador.ProductName;
        }
    }
}
