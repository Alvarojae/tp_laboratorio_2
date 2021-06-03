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



        /// <summary>
        /// Activa los botones cuando es cliqueado el radio buton de comida
        /// </summary>

        private void rbComida_MouseClick(object sender, MouseEventArgs e)
        {
            ActivarBotones(1);
        }

        /// <summary>
        /// Activa los botones cuando es cliqueado el radio buton de herramita
        /// </summary>

        private void rbHerramienta_MouseClick(object sender, MouseEventArgs e)
        {
            ActivarBotones(0);
        }


        /// <summary>
        /// Agrega el producto tomando todos los datos del form y validando todo(Creo)
        /// </summary>

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(rbComida.Checked)
            {
                if (ValidarCasillas(1))
                {
                    try 
                    {
                    Alimento aux = new Alimento((int)nudId.Value, (int)nudValor.Value, (int)nudStock.Value, tbNombre.Text, (int)nudPeso.Value, (int)nudCalorias.Value, tbSabor.Text);
                    if (((Materiales)cmbIngredientes.SelectedItem).ConsumirMateriales((int)nudStock.Value) && alvaroFabrica + aux)
                    {
                        lstProductos.Items.Add(aux);
                        MessageBox.Show("Se agreo correctamente un alimento");
                        CleanAll();
                    }else
                        MessageBox.Show("No tiene suficiente materiales para crear el producto", "Error");
                    }catch(Exception)
                    {
                        MessageBox.Show("Hubo un problema con los datos ingresados", "Error");
                    }

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

        /// <summary>
        /// Muestra la informacion de la lista de productos creados
        /// </summary>
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



        /// <summary>
        /// Valida que segun el tipo de producto elegido esten las casillas completadas
        /// </summary>
        /// <param name="tipoDeProducto">Tipo del producto </param>
        /// <returns></returns>
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

        }

        /// <summary>
        /// Limpia todo los valores del form
        /// </summary>
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

        /// <summary>
        /// Actualiza los materiales de la lista de materiales
        /// </summary>
        private void ActualizarMateriales()
        {
            lstMateriales.Items.Clear();
            foreach (Materiales item in listaMateriales)
            {
                lstMateriales.Items.Add(item);
                
            }
        }

        /// <summary>
        /// Actualiza el ComboBox segun el estado recibido
        /// </summary>
        /// <param name="estado">Revibe el el estado del tipo de producto</param>
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


        /// <summary>
        /// Activa los botones segun el parametro recibido
        /// </summary>
        /// <param name="estado">1-Alimentos | 2-Herrramientas</param>
        protected void ActivarBotones(int estado)
        {
            nudCalorias.Enabled = false;
            tbSabor.Enabled = false;
            tbMaterial.Enabled = false;
            tbMarca.Enabled = false;

            if (estado == 1)
            {
                ActualizarIngredientes(estado);
                nudCalorias.Enabled = true;
                tbSabor.Enabled = true;
                cmbIngredientes.Text = "";
            }
            else if (estado == 0)
            {
                ActualizarIngredientes(estado);
                tbMaterial.Enabled = true;
                tbMarca.Enabled = true;
                cmbIngredientes.Text = "";
            }
        }

    }
}
