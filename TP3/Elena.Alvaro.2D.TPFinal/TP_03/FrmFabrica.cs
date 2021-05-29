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

namespace TP_03
{
    public partial class FrmFabrica : Form
    {
        public FrmFabrica()
        {
            InitializeComponent();
            
        }
        Fabrica<Producto> alvaroFabrica = new Fabrica<Producto>("Alvaro");


        /// <summary>
        /// Consulta si se desea cerrar el programa con un cuadro de si o no
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmFabrica_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿Desea cerrar el programa?",
            "Cerrar el programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.No)
                e.Cancel = true;
        }

        private void FrmFabrica_Load(object sender, EventArgs e)
        {
          

            
        }

        private void rbComida_MouseClick(object sender, MouseEventArgs e)
        {
            ActivarBotones(1);
        }

        private void rbHerramienta_MouseClick(object sender, MouseEventArgs e)
        {
            ActivarBotones(0);
        }


        protected void ActivarBotones(int Estado)
        {

            nudCalorias.Enabled=false;
            tbIngredientes.Enabled = false;
            tbSabor.Enabled = false;

            tbMaterial.Enabled = false;
            tbMarca.Enabled = false;


            if (Estado == 1)
            {
                nudCalorias.Enabled = true;
                tbIngredientes.Enabled = true;
                tbSabor.Enabled = true;
            }
            else if(Estado== 0)
            {
                tbMaterial.Enabled = true;
                tbMarca.Enabled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(rbComida.Checked)
            {
                if (ValidarCasillas(1))
                {
                    Alimento aux = new Alimento((int)nudId.Value, (int)nudValor.Value, (int)nudStock.Value, tbNombre.Text, (int)nudPeso.Value, (int)nudCalorias.Value, tbSabor.Text, tbIngredientes.Text);
                    if (alvaroFabrica + aux)
                    {
                        lstStock.Items.Add(aux);
                        MessageBox.Show("Se agreo correctamente un alimento");
                        CleanAll();
                    }
                }


                //MessageBox.Show("id = "+nudId.Value.ToString()+ "\nvalor = " + nudValor.Value.ToString()+ "\nStock = " + nudStock.Value.ToString()+ "\nNombre = " +  tbNombre.Text, "\nCalorias = " +  nudCalorias.Value.ToString()+ "\nSabor = " +  tbSabor.Text+ "\nIngredientes = " +  tbIngredientes.Text);

            }
            else if(rbHerramienta.Checked )
            {
                if(ValidarCasillas(0))
                {
                    Herramienta aux = new Herramienta((int)nudId.Value, (int)nudValor.Value, (int)nudStock.Value, tbNombre.Text, (int)nudPeso.Value, tbMaterial.Text, tbMarca.Text);
                    if (alvaroFabrica + aux)
                    {
                        lstStock.Items.Add(aux);
                        MessageBox.Show("Se agreo correctamente una herramienta");
                        CleanAll();
                    }
                }
               
            }
            else
                MessageBox.Show("Es necesario marcar un tipo de producto", "Error");
            
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            if(lstStock.SelectedItem!=null)
            {
                Producto aux = (Producto)lstStock.SelectedItem;
                MessageBox.Show(aux.Informacion(), "Informacion del producto");
            }else
            {
                MessageBox.Show("No marcaste ningun producto para ver la informacion " , "Error");
            }
            
        }


        private bool ValidarCasillas(int tipoDeProducto)
        {
            if (nudId.Value != 0 && nudValor.Value != 0 && nudStock.Value != 0 && tbNombre.Text != "" && nudPeso.Value != 0)
            {
                if (tipoDeProducto == 0 && tbMaterial.Text != "" && tbMarca.Text != "")
                    return true;
                else if (tipoDeProducto == 1 && nudCalorias.Value != 0 && tbSabor.Text != "" && tbIngredientes.Text != "")
                    return true;
                else
                    MessageBox.Show("No ingresaste dato de Alimentos o Herramientas", "Error");

            }else
                MessageBox.Show("No ingresaste datos de la primera columna o unos de los valores es 0", "Error");

            return false;

            //if (nudId.Value != 0) 
            //    if (nudValor.Value != 0)
            //        if (nudStock.Value != 0)
            //            if (tbNombre.Text != "")
            //                if (nudPeso.Value != 0)
            //                    return true;
            //                else 
            //                    MessageBox.Show( "El peso esta vacio o es igual a 0","Error");
            //            else
            //                MessageBox.Show( "El nombre esta vacio", "Error");
            //        else
            //            MessageBox.Show("El Stock esta vacio o es igual a 0", "Error");
            //    else
            //        MessageBox.Show("El Valor esta vacio o es igual a 0", "Error");
            //else
            //    MessageBox.Show("El Id esta vacio o es igual a 0", "Error");
            //return false;

        }

        private void CleanAll()
        {
            nudId.Value = 0;
            nudValor.Value = 0;
            nudStock.Value = 0;
            tbNombre.Text = "";
            nudPeso.Value = 0;

            nudCalorias.Value = 0;
            tbIngredientes.Text = "";
            tbSabor.Text = "";

            tbMaterial.Text = "";
            tbMarca.Text = "";
        }

        private void btnVerInforme_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ValidarCasillas(1).ToString());
            //MessageBox.Show(nudId.Value.ToString());
        }
    }
}
