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
        List<Materiales> listaMateriales = new List<Materiales>();

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
            listaMateriales.Add(new Materiales("Harina", 25, true));
            listaMateriales.Add(new Materiales("Leche", 25, true));
            listaMateriales.Add(new Materiales("Chocolate", 25, true));

            listaMateriales.Add(new Materiales("Hierro", 35, false));
            listaMateriales.Add(new Materiales("Aluminio", 35, false)); 
            listaMateriales.Add(new Materiales("Cobre", 35, false));

            ActualizarMateriales();
            
        }

        private void rbComida_MouseClick(object sender, MouseEventArgs e)
        {
            ActivarBotones(1);
        }

        private void rbHerramienta_MouseClick(object sender, MouseEventArgs e)
        {
            ActivarBotones(0);
        }


        protected void ActivarBotones(int estado)
        {

            nudCalorias.Enabled=false;
            tbSabor.Enabled = false;

            tbMaterial.Enabled = false;
            tbMarca.Enabled = false;


            if (estado == 1)
            {
                CleanAll();
                ActualizarIngredientes(estado);
                nudCalorias.Enabled = true;
                tbSabor.Enabled = true;
            }
            else if(estado == 0)
            {
                CleanAll();
                ActualizarIngredientes(estado);
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
                    Alimento aux = new Alimento((int)nudId.Value, (int)nudValor.Value, (int)nudStock.Value, tbNombre.Text, (int)nudPeso.Value, (int)nudCalorias.Value, tbSabor.Text);
                    if (((Materiales)cmbIngredientes.SelectedItem).ConsumirMateriales((int)nudStock.Value) && alvaroFabrica + aux)
                    {
                        lstProductos.Items.Add(aux);
                        MessageBox.Show("Se agreo correctamente un alimento");
                        CleanAll();
                    }else
                        MessageBox.Show("No tiene suficiente materiales para crear el producto", "Error");
                }


                //MessageBox.Show("id = "+nudId.Value.ToString()+ "\nvalor = " + nudValor.Value.ToString()+ "\nStock = " + nudStock.Value.ToString()+ "\nNombre = " +  tbNombre.Text, "\nCalorias = " +  nudCalorias.Value.ToString()+ "\nSabor = " +  tbSabor.Text+ "\nIngredientes = " +  tbIngredientes.Text);

            }
            else if(rbHerramienta.Checked )
            {
                if(ValidarCasillas(0))
                {
                    Herramienta aux = new Herramienta((int)nudId.Value, (int)nudValor.Value, (int)nudStock.Value, tbNombre.Text, (int)nudPeso.Value, tbMaterial.Text, tbMarca.Text);
                    if (((Materiales)cmbIngredientes.SelectedItem).ConsumirMateriales((int)nudStock.Value) && alvaroFabrica + aux)
                    {
                        lstProductos.Items.Add(aux);
                        MessageBox.Show("Se agreo correctamente una herramienta");
                        CleanAll();
                    }else
                        MessageBox.Show("No tiene suficiente materiales para crear el producto", "Error");
                }
               
            }
            else
                MessageBox.Show("Es necesario marcar un tipo de producto", "Error");

            ActualizarMateriales();
            ActivarBotones(3);
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            if(lstProductos.SelectedItem!=null)
            {
                Producto aux = (Producto)lstProductos.SelectedItem;
                MessageBox.Show(aux.Informacion(), "Informacion del producto");
            }else
            {
                MessageBox.Show("No marcaste ningun producto para ver la informacion " , "Error");
            }
            
        }



        private bool ValidarCasillas(int tipoDeProducto)
        {
            if (nudId.Value != 0 && nudValor.Value != 0 && nudStock.Value != 0 && tbNombre.Text != "" && nudPeso.Value != 0 && cmbIngredientes.Text != "")
            {
                if (tipoDeProducto == 0 && tbMaterial.Text != "" && tbMarca.Text != "")
                    return true;
                else if (tipoDeProducto == 1 && nudCalorias.Value != 0 && tbSabor.Text != "" )
                    return true;
                else
                    MessageBox.Show("No ingresaste dato de Alimentos o Herramientas", "Error");
            }
            else
                MessageBox.Show("No ingresaste datos de la primera columna o unos de los valores es 0", "Error");

            return false;

            //if (nudId.Value != 0)
            //    if (nudValor.Value != 0)
            //        if (nudStock.Value != 0)
            //            if (tbNombre.Text != "")
            //                if (nudPeso.Value != 0)
            //                    return true;
            //                else
            //                    MessageBox.Show("El peso esta vacio o es igual a 0", "Error");
            //            else
            //                MessageBox.Show("El nombre esta vacio", "Error");
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
            tbSabor.Text = "";

            tbMaterial.Text = "";
            tbMarca.Text = "";

            cmbIngredientes.Text = "";
        }

        private void btnVerInforme_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ValidarCasillas(1).ToString());
            //MessageBox.Show(nudId.Value.ToString());
        }

        private void ActualizarMateriales()
        {
            lstMateriales.Items.Clear();
            foreach (Materiales item in listaMateriales)
            {
                lstMateriales.Items.Add(item);
                
            }
        }

        private void ActualizarIngredientes(int estado)
        {
            cmbIngredientes.Items.Clear();
            foreach (Materiales item in listaMateriales)
            {
                if(estado == 1 && item.Material)
                    cmbIngredientes.Items.Add(item);
                else if (estado == 0 && !item.Material)
                    cmbIngredientes.Items.Add(item);
            }        
        }
    }
}
