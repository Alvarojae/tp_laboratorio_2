using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

            this.ActivarComida += ActivarBotonesComida;
            this.ActivarHerramienta += ActivarBotonesHerramientas;

        }
        public delegate void Activar();

        public event Activar ActivarComida;
        public event Activar ActivarHerramienta;


        Fabrica<Producto> alvaroFabrica = new Fabrica<Producto>("Alvaro");
        List<Materiales> listaMateriales = new List<Materiales>();
        List<Thread> listaThreads;
        List<string> nombreMateriales = new List<string>();
        static int id = 1;
        
        private void FrmFabrica_Load(object sender, EventArgs e)
        {
            cmbIngredientes.DropDownStyle = ComboBoxStyle.DropDownList;
            ActualizarMateriales();
            lblInformacion.Text = "Es necesario cargar los Materiales para poder continuar";
            nombreMateriales.Add("Harina");
            nombreMateriales.Add("Leche");
            nombreMateriales.Add("Chocolate");
            nombreMateriales.Add("Hierro");
            nombreMateriales.Add("Aluminio");
            nombreMateriales.Add("Cobre");

            try
            {
                Conexion conexion = new Conexion();
                List<Materiales> materialesSql = conexion.LeerMaterial();
                if(materialesSql.Count>0)
                {
                    foreach (Materiales item in materialesSql)
                    {
                        listaMateriales.Add(item);
                    }
                    ActualizarMateriales();
                    ActivarBotonesCargaMateriales();
                }

            }catch
            {
                MessageBox.Show("Hubo un problema al cargar los archivos de la base de datos", "Error");
            }

            listaThreads = new List<Thread>();
            listaThreads.Add(new Thread(GuardarMateriales));

            foreach (Thread item in listaThreads)
            {
                if (!(item.ThreadState == ThreadState.Stopped) && !item.IsAlive)
                {
                    item.Start();
                }
            }
        }

        
        /// <summary>
        /// Consulta si se desea cerrar el programa con un cuadro de si o no
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmFabrica_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ("¿Desea cerrar el programa?".YesOrNo() == DialogResult.No)
                e.Cancel = true;
            else
                foreach (Thread item in listaThreads)
                    if (item.IsAlive)
                        item.Abort();
        }



        /// <summary>
        /// Activa los botones cuando es cliqueado el radio buton de comida
        /// </summary>

        private void rbComida_MouseClick(object sender, MouseEventArgs e)
        {
            this.ActivarComida.Invoke();
        }

        /// <summary>
        /// Activa los botones cuando es cliqueado el radio buton de herramita
        /// </summary>

        private void rbHerramienta_MouseClick(object sender, MouseEventArgs e)
        {
            this.ActivarHerramienta.Invoke();
        }

        /// <summary>
        /// Excepcion
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
                                CleanAll();
                                MessageBox.Show("Se agreo correctamente un alimento");
                            }else
                                MessageBox.Show("No tiene suficiente materiales para crear el producto", "Error");
                    }
                }
                else if(rbHerramienta.Checked)
                {
                    if(ValidarCasillas(0))
                    { 
                                Herramienta aux = new Herramienta(id, (int)nudValor.Value, (int)nudStock.Value, tbNombre.Text, (int)nudPeso.Value, tbMaterial.Text, tbMarca.Text);
                            if (((Materiales)cmbIngredientes.SelectedItem).ConsumirMateriales(aux) && alvaroFabrica + aux)
                            {
                                lstProductos.Items.Add(aux);
                                id++;
                                CleanAll();
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
                MessageBox.Show(new MisExcepciones("Hubo un problema al crear el producto", ex).Message, "Error");
            }

            SubirMaterialesSql();
            ActualizarMateriales();
            DesactivarBotones();
        }
    

        /// <summary>
        /// Muestra la informacion de la lista de productos creados
        /// </summary>
        private void btMostrar_Click(object sender, EventArgs e)
        {
            if(lstProductos.SelectedItem!=null)
            {
                MessageBox.Show(((Producto)lstProductos.SelectedItem).Informacion(), "Informacion del producto");
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
            if (nudValor.Value != 0 && nudStock.Value != 0 && tbNombre.Text != "" && nudPeso.Value != 0 )
            {
                if (tipoDeProducto == 0 && tbMaterial.Text != "" && tbMarca.Text != "" && cmbIngredientes.Text != "")
                    return true;
                else if (tipoDeProducto == 1 && nudCalorias.Value != 0 && tbSabor.Text != "" && cmbIngredientes.Text != "")
                    return true;
                else
                    MessageBox.Show("No ingresaste dato de Alimentos o Herramientas o falta completar los ingredientes", "Error");
            }
            else
                MessageBox.Show("No ingresaste datos de la primera columna o unos de los valores es 0", "Error");

            return false;

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
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
        /// Activa los botones de alimentos
        /// </summary>
        private void ActivarBotonesComida()
        {
            DesactivarBotones();
            ActualizarIngredientes(1);
            nudCalorias.Enabled = true;
            tbSabor.Enabled = true;
            cmbIngredientes.Text = "";
          
        }

        /// <summary>
        /// Activa los botones de herramientas
        /// </summary>
        private void ActivarBotonesHerramientas()
        {
            DesactivarBotones();
            ActualizarIngredientes(0);
            tbMaterial.Enabled = true;
            tbMarca.Enabled = true;
            cmbIngredientes.Text = "";
        }

        /// <summary>
        /// desactiva los botones de alimentos y herramientas
        /// </summary>
        private void DesactivarBotones()
        {
            nudCalorias.Enabled = false;
            tbSabor.Enabled = false;
            tbMaterial.Enabled = false;
            tbMarca.Enabled = false;
        }

            /// <summary>
            /// SERIALIZACION CARGA
            /// Boton que carga los materiales
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnCargarMateriales_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿Desea cargar el backUp de los materiales? sera necesario guardarlos antes de cerrar",
           "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.Yes)
            {

                Serializadora<Materiales> serializadora = new Serializadora<Materiales>();
                try 
                {
                    listaMateriales.Clear();
                    foreach (string nombre in nombreMateriales)
                    {
                        listaMateriales.Add((Materiales)serializadora.Leer(nombre));
                    }

                }catch(Exception cargarMateriales)
                {
                    MessageBox.Show(cargarMateriales.Message);
                }
                ActualizarMateriales();
                ActivarBotonesCargaMateriales();
            }
        }

        /// <summary>
        /// Activa todos los botenes si la carga fue de materiales fue existoso
        /// </summary>
        private void ActivarBotonesCargaMateriales()
        {
            //btnCargarMateriales.Enabled = false;
            btnAgregarMateriales.Enabled = true;
            btnGuardarMateriales.Enabled = true;
            btMostrar.Enabled = true;
            btnAgregar.Enabled = true;
            btnGuardarInforme.Enabled = true;


            lblInformacion.Text = "";
            rbComida.Enabled = true;
            rbHerramienta.Enabled = true;
        }

        /// <summary>
        /// /// SERIALIZACION GUARDAR
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
            }
            catch(Exception guardarMateriales)
            {
                MessageBox.Show(guardarMateriales.Message);
            }
            MessageBox.Show("Se guardaron los materiales exitosamente", "Exito");
        }

        /// <summary>
        /// Thread que guarda un backup de los materiales en la carpeta del proyecto
        /// </summary>
        private void GuardarMateriales()
        {
            Serializadora<Materiales> serializadora = new Serializadora<Materiales>();
            while (true)
            {
                foreach (Materiales item in listaMateriales)
                {
                    if (!(serializadora.Guardar(item.Nombre, item)))
                        MessageBox.Show("No se pudo guardar uno de los materiales", "Error");
                }
                Thread.Sleep(60000);
            }
        }
 

        /// <summary>
        /// Boton que agrega los materiales 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarMateriales_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion conexion = new Conexion();
                if (lstMateriales.SelectedItem != null)
                {
                    ((Materiales)lstMateriales.SelectedItem).AgregarMateriales();
                    SubirMaterialesSql();
                    ActualizarMateriales();
                }
                else
                    MessageBox.Show("No seleccionaste ningun material", "Error");
            }catch(Exception)
            {
                MessageBox.Show("No se pudo agregar materiales", "error");
            }
        }


        /// <summary>
        /// Actualiza la base de datos de sql
        /// </summary>
        private void SubirMaterialesSql()
        {
            try
            {
                Conexion conexion = new Conexion();
                conexion.GuardarMaterial(listaMateriales);
            }
            catch (Exception SqlGuardar)
            {
                MessageBox.Show(SqlGuardar.Message);
            }
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
            MessageBox.Show("Se guardo el informe exitosamente", "Exito"); 
        }
    }
}
