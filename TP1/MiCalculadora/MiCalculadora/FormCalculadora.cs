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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            txtNumero1.Text = "0";
            txtNumero2.Text = "0";
            lblResultado.Text = "";
            cmbOperador.Text = "+";
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            if(ValidarTextBox())
            {
                lblResultado.Text = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text).ToString();

                if (lblResultado.Text != "0")
                {
                    btnConvertirADecimal.Enabled = false;
                    btnConvertirABinario.Enabled = Enabled;
                }
                else
                {
                    btnConvertirABinario.Enabled = false;
                    btnConvertirADecimal.Enabled = false;
                }
            }
            else
                lblResultado.Text = "Ingrese un numero en las dos casillas";


        }
        private bool ValidarTextBox()
        {
            if (txtNumero1.Text != "" && txtNumero2.Text != "")
                return true;
            return false;
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Numero.BinarioDecimal(lblResultado.Text);
            btnConvertirABinario.Enabled = Enabled;
            btnConvertirADecimal.Enabled = false;
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if (Numero.DecimalBinario(lblResultado.Text) != "-1")
            {
                lblResultado.Text = Numero.DecimalBinario(lblResultado.Text);
                btnConvertirABinario.Enabled = false;
                btnConvertirADecimal.Enabled = Enabled;
            }
            else
                lblResultado.Text = "Valor invalido";
        }


        private double Operar(string numero1, string numero2,string operador)
        {
            Numero objNum1 = new Numero(numero1);
            Numero objNum2 = new Numero(numero2);

            return Calculadora.Operar(objNum1, objNum2, operador);
        }
    }
}
