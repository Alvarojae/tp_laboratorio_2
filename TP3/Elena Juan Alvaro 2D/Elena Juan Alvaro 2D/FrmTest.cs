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
namespace Elena_Juan_Alvaro_2D
{
    public partial class FrmTest : Form
    {
        Vendedor vendedor;
        public FrmTest()
        {
            InitializeComponent();
            vendedor = new Vendedor("Alvaro\n");
        }

        private void frmTesterApp_Load(object sender, EventArgs e)
        {

            Biografia p1 = (Biografia)"Life (Keith Richards)";
            Biografia p2 = new Biografia("White line fever (Lemmy)", 5);
            Biografia p3 = new Biografia("Commando (Johnny Ramone)", 2, 5000);
            Comic p4 = new Comic("La Muerte de Superman (Superman)", true, 1, 1850);
            Comic p5 = new Comic("Año Uno (Batman)", false, 3, 1270);
            //Comic p6 = new Comic("Año Uno (Batman)", false, -3, 1270);

            lstStock.Items.Add(p1);
            lstStock.Items.Add(p2);
            lstStock.Items.Add(p3);
            lstStock.Items.Add(p4);
            lstStock.Items.Add(p5);

            //lstStock.Items.Add(p6);
            //MessageBox.Show("El valor es =" +p6.Stock.ToString());


        }

        /// <summary>
        /// boton vender
        /// </summary>
        private void btnVender_Click(object sender, EventArgs e)
        { 
            if (lstStock.SelectedItem != null)
            {
                if (this.vendedor + (Publicacion)lstStock.SelectedItem)
                    MessageBox.Show("Venta concretada");
                else
                    MessageBox.Show("No hay stock papu");
            }else
                MessageBox.Show("No selecionaste nada");
        }


        /// <summary>
        /// boton salir
        /// </summary>
        private void btnSalir_Click(object sender, EventArgs e)
        {
           //DialogResult res = MessageBox.Show("Desea salir", "Salir del programa", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
           // if(res== DialogResult.OK)
                this.Close();
        }

     /// <summary>
     /// Consulta si se desea cerrar el programa con un cuadro de si o no
     /// </summary>
     /// <param name="sender"></param>
     /// <param name="e"></param>
        private void FrmTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿Desea cerrar el programa?",
               "Cerrar el programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.No)
                e.Cancel = true;
        }

        /// <summary>
        /// boton ver informe
        /// </summary>

        private void btnVerInforme_Click(object sender, EventArgs e)
        {
            rtbLnInforme.Text = Vendedor.InformeDeVentas(vendedor);
        }
    }
}
