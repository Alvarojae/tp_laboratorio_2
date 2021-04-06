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
        Numero primerNumero;
        Numero segundoNumero;
        Numero aux = new Numero(0);

        public FormCalculadora()
        {
            InitializeComponent();
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = false;
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            txtNumero1.Text = "0";
            txtNumero2.Text = "0";
            lblResultado.Text = "";
            cmbOperador.Text = "/";
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            primerNumero = new Numero(txtNumero1.Text);
            segundoNumero= new Numero(txtNumero2.Text);
            lblResultado.Text =Calculadora.Operar(primerNumero, segundoNumero, cmbOperador.Text).ToString();
            if (double.Parse(lblResultado.Text)>0)
            {
                btnConvertirABinario.Enabled = Enabled;
                btnConvertirADecimal.Enabled = Enabled;
            }else
            {
                btnConvertirABinario.Enabled = false;
                btnConvertirADecimal.Enabled = false;
            }
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
             lblResultado.Text = Numero.BinarioDecimal(lblResultado.Text);
            
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Numero.DecimalBinario(lblResultado.Text);
        }
    }
}
