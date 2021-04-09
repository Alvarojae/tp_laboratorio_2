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
        Numero aux = new Numero(0);

        public FormCalculadora()
        {
            InitializeComponent();
            ActivarBotones(0);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
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
                    ActivarBotones(1);
                else
                    ActivarBotones(0);              
            }
            else
                lblResultado.Text = "Ingrese un numero en las casillas";
        }
      
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            lblResultado.Text = aux.BinarioDecimal(lblResultado.Text);
            ActivarBotones(1);
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if (aux.DecimalBinario(lblResultado.Text) != "-1")
            {
                lblResultado.Text = aux.DecimalBinario(lblResultado.Text);
                ActivarBotones(2);
            }
            else
                lblResultado.Text = "Valor invalido";
        }

        /// <summary>
        /// create 2 objects and send it to the methods Operar
        /// </summary>
        /// <param name="numero1">string with the number to operate</param>
        /// <param name="numero2">string with the number to operate</param>
        /// <param name="operador">string with the operator symbol</param>
        /// <returns>returns the resulto of the operations</returns>
        private double Operar(string numero1, string numero2,string operador)
        {
            Numero objNum1 = new Numero(numero1);
            Numero objNum2 = new Numero(numero2);

            return Calculadora.Operar(objNum1, objNum2, operador);
        }

        /// <summary>
        /// validate if the user completes the text box
        /// </summary>
        /// <returns></returns>
        private bool ValidarTextBox()
        {
            if (txtNumero1.Text != "" && txtNumero2.Text != "")
                return true;
            return false;
        }

        /// <summary>
        /// Clean the form 
        /// </summary>
        private void limpiar()
        {
            txtNumero1.Text = "0";
            txtNumero2.Text = "0";
            lblResultado.Text = "";
            cmbOperador.Text = "+";
            ActivarBotones(0);
        }

        /// <summary>
        /// enable the botons according to the number sended
        /// </summary>
        /// <param name="estado">1-binario enabled|2-decimal enabled</param>
        private void ActivarBotones(int estado)
        {
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = false;
            if (estado == 1)
                btnConvertirABinario.Enabled = Enabled;
            else if (estado == 2)
                btnConvertirADecimal.Enabled = Enabled;
        }
    }
}
