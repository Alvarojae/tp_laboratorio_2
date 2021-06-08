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
using Serializadora;

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
        List<string> nombreMateriales = new List<string>();
        static int id = 1;

        private void FrmFabrica_Load(object sender, EventArgs e)
        {
            //cmbIngredientes.DropDownStyle = ComboBoxStyle.DropDownList;
            ActualizarMateriales();
            lblInformacion.Text = "Es necesario cargar los Materiales para poder continuar";
            nombreMateriales.Add("Harina");
            nombreMateriales.Add("Leche");
            nombreMateriales.Add("Chocolate");
            nombreMateriales.Add("Hierro");
            nombreMateriales.Add("Aluminio");
            nombreMateriales.Add("Cobre");
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
            try
            {
                if (rbComida.Checked)
                {
                    if (ValidarCasillas(1))
                    {
                            Alimento aux = new Alimento(id, (int)nudValor.Value, (int)nudStock.Value, tbNombre.Text, (int)nudPeso.Value, (int)nudCalorias.Value, tbSabor.Text);
                            if (((Materiales)cmbIngredientes.SelectedItem).ConsumirMateriales(aux) && alvaroFabrica + aux)
                            {
                                lstProductos.Items.Add(aux);
                                id++;
                                MessageBox.Show("Se agreo correctamente un alimento");
                            }else
                                MessageBox.Show("No tiene suficiente materiales para crear el producto", "Error");
                    }
                }
                else if(rbHerramienta.Checked )
                {
                    if(ValidarCasillas(0))
                    { 
                                Herramienta aux = new Herramienta(id, (int)nudValor.Value, (int)nudStock.Value, tbNombre.Text, (int)nudPeso.Value, tbMaterial.Text, tbMarca.Text);
                            if (((Materiales)cmbIngredientes.SelectedItem).ConsumirMateriales(aux) && alvaroFabrica + aux)
                            {
                                lstProductos.Items.Add(aux);
                                id++;
                                MessageBox.Show("Se agreo correctamente una herramienta");
                            }else
                                MessageBox.Show("No tiene suficiente materiales para crear el producto", "Error");
                    }
                  
                }
                else
                    MessageBox.Show("Es necesario marcar un tipo de producto", "Error");
            }
            catch (Exception ex)
            {
                new MisExcepciones("Hubo un problema al crear el producto", ex);
                MessageBox.Show("Hubo un problema al crear el producto", "Error");
            }

            CleanAll();
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
            if (nudValor.Value != 0 && nudStock.Value != 0 && tbNombre.Text != "" && nudPeso.Value != 0 && cmbIngredientes.Text != "")
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
            try
            {
                lstMateriales.Items.Clear();
                foreach (Materiales item in listaMateriales)
                {
                    lstMateriales.Items.Add(item);
                }
            }catch(Exception)
            {
                MessageBox.Show("Hubo un error al intentar actualizar la lista ");
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
        /// Limpia todo los valores del form
        /// </summary>
        private void CleanAll()
        {
            nudValor.Value = 0;
            nudStock.Value = 0;
            tbNombre.Text = "";
            nudPeso.Value = 0;

            nudCalorias.Value = 0;
            tbSabor.Text = "";

            tbMaterial.Text = "";
            tbMarca.Text = "";

            cmbIngredientes.Text = "";
            rbHerramienta.Checked = false;
            rbComida.Checked = false;
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

        /// <summary>
        /// Boton que carga los materiales
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargarMateriales_Click(object sender, EventArgs e)
        {
            Serializadora<Materiales> serializadora = new Serializadora<Materiales>();
            try 
            { 
                foreach (string nombre in nombreMateriales)
                {
                    listaMateriales.Add((Materiales)serializadora.Leer(nombre));
                }

            }catch(Exception cargarMateriales)
            {
                MessageBox.Show(cargarMateriales.Message);
            }
            ActualizarMateriales();
            btnCargarMateriales.Enabled = false;
            btnAgregarMateriales.Enabled = true;
            btnGuardarMateriales.Enabled = true;
            lblInformacion.Text = "";
            rbComida.Enabled = true;
            rbHerramienta.Enabled = true;
        }

        /// <summary>
        /// Boton que guarda los materiales
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarMateriales_Click(object sender, EventArgs e)
        {
            Serializadora<Materiales> serializadora = new Serializadora<Materiales>();
            try
            {
                foreach (Materiales item in listaMateriales)
                {
                    if (!(serializadora.Guardar(item.Nombre, item)))
                        MessageBox.Show("No se pudo guardar uno de los materiales", "Error");
                }
            }catch(Exception guardarMateriales)
            {
                MessageBox.Show(guardarMateriales.Message);
            }
            MessageBox.Show("Se guardaron los materiales exitosamente", "Exito");

        }

        /// <summary>
        /// Boton que agrega los materiales 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarMateriales_Click(object sender, EventArgs e)
        {
            if(lstMateriales.SelectedItem != null)
            {
                Materiales aux = (Materiales)lstMateriales.SelectedItem;
                aux.Cantidad = aux.Cantidad + 10;
                ActualizarMateriales();
            }else
                MessageBox.Show("No seleccionaste ningun material", "Error");
        }

        /// <summary>
        /// Boton que guarda el informe  de productos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarInforme_Click(object sender, EventArgs e)
        {
            
            try
            {
                StringBuilder sb = new StringBuilder();
                foreach (Producto item in alvaroFabrica.Listaproductos)
                {
                    sb.Append(item.Informacion());
                }
                Texto.EscribirTexto(sb.ToString());
            }
            catch(Exception GuardarInforme)
            {
                MessageBox.Show(GuardarInforme.Message, "Error");
            }
            MessageBox.Show("Se guardo le informe exitosamente", "Exito");
        }
    }
}
