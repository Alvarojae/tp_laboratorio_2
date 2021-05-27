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
            List<Producto> productos = new List<Producto>();
            productos.Add((Producto)new Comida(1, 15, 2, "Cindor", 500, 250, "Chocolate", "vaca batida"));
            productos.Add((Producto)new Herramienta(2, 1050, 5, "Pinza multiuso", 560, "Metal", "Black & Decker"));

            foreach (Producto item in productos)
            {
                lstStock.Items.Add(item);
            }

            
        }
    }
}
