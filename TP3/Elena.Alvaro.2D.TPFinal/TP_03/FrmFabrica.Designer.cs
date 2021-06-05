
namespace TP_03
{
    partial class FrmFabrica
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.btnGuardarInforme = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.rbComida = new System.Windows.Forms.RadioButton();
            this.rbHerramienta = new System.Windows.Forms.RadioButton();
            this.nudId = new System.Windows.Forms.NumericUpDown();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbSabor = new System.Windows.Forms.TextBox();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCalorias = new System.Windows.Forms.Label();
            this.lblSabor = new System.Windows.Forms.Label();
            this.lblIngredientes = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.nudPeso = new System.Windows.Forms.NumericUpDown();
            this.nudValor = new System.Windows.Forms.NumericUpDown();
            this.nudCalorias = new System.Windows.Forms.NumericUpDown();
            this.btMostrar = new System.Windows.Forms.Button();
            this.lstMateriales = new System.Windows.Forms.ListBox();
            this.cmbIngredientes = new System.Windows.Forms.ComboBox();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.tbMaterial = new System.Windows.Forms.TextBox();
            this.btnCargarMateriales = new System.Windows.Forms.Button();
            this.btnGuardarMateriales = new System.Windows.Forms.Button();
            this.btnAgregarMateriales = new System.Windows.Forms.Button();
            this.lblProductos = new System.Windows.Forms.Label();
            this.lbMateriales = new System.Windows.Forms.Label();
            this.lblInformacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCalorias)).BeginInit();
            this.SuspendLayout();
            // 
            // lstProductos
            // 
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.Location = new System.Drawing.Point(432, 25);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(280, 290);
            this.lstProductos.TabIndex = 9;
            // 
            // btnGuardarInforme
            // 
            this.btnGuardarInforme.Location = new System.Drawing.Point(15, 330);
            this.btnGuardarInforme.Name = "btnGuardarInforme";
            this.btnGuardarInforme.Size = new System.Drawing.Size(397, 35);
            this.btnGuardarInforme.TabIndex = 7;
            this.btnGuardarInforme.Text = "Guardar Informe";
            this.btnGuardarInforme.UseVisualStyleBackColor = true;
            this.btnGuardarInforme.Click += new System.EventHandler(this.btnGuardarInforme_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(15, 280);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(397, 35);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar Nuevo Producto";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // rbComida
            // 
            this.rbComida.AutoSize = true;
            this.rbComida.Enabled = false;
            this.rbComida.Location = new System.Drawing.Point(159, 30);
            this.rbComida.Name = "rbComida";
            this.rbComida.Size = new System.Drawing.Size(70, 17);
            this.rbComida.TabIndex = 6;
            this.rbComida.TabStop = true;
            this.rbComida.Text = "Alimentos";
            this.rbComida.UseVisualStyleBackColor = true;
            this.rbComida.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbComida_MouseClick);
            // 
            // rbHerramienta
            // 
            this.rbHerramienta.AutoSize = true;
            this.rbHerramienta.Enabled = false;
            this.rbHerramienta.Location = new System.Drawing.Point(292, 30);
            this.rbHerramienta.Name = "rbHerramienta";
            this.rbHerramienta.Size = new System.Drawing.Size(87, 17);
            this.rbHerramienta.TabIndex = 7;
            this.rbHerramienta.TabStop = true;
            this.rbHerramienta.Text = "Herramientas";
            this.rbHerramienta.UseVisualStyleBackColor = true;
            this.rbHerramienta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbHerramienta_MouseClick);
            // 
            // nudId
            // 
            this.nudId.Location = new System.Drawing.Point(15, 30);
            this.nudId.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudId.Name = "nudId";
            this.nudId.Size = new System.Drawing.Size(117, 20);
            this.nudId.TabIndex = 1;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(15, 88);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(117, 20);
            this.tbNombre.TabIndex = 2;
            // 
            // tbSabor
            // 
            this.tbSabor.Enabled = false;
            this.tbSabor.Location = new System.Drawing.Point(159, 131);
            this.tbSabor.Name = "tbSabor";
            this.tbSabor.Size = new System.Drawing.Size(117, 20);
            this.tbSabor.TabIndex = 9;
            // 
            // tbMarca
            // 
            this.tbMarca.Enabled = false;
            this.tbMarca.Location = new System.Drawing.Point(292, 131);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(117, 20);
            this.tbMarca.TabIndex = 11;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 12);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 22;
            this.lblId.Text = "Id";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(12, 115);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(49, 13);
            this.lblStock.TabIndex = 23;
            this.lblStock.Text = "Cantidad";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(12, 160);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 24;
            this.lblPeso.Text = "Peso";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(12, 206);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 25;
            this.lblValor.Text = "Valor";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 72);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 26;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCalorias
            // 
            this.lblCalorias.AutoSize = true;
            this.lblCalorias.Location = new System.Drawing.Point(156, 72);
            this.lblCalorias.Name = "lblCalorias";
            this.lblCalorias.Size = new System.Drawing.Size(44, 13);
            this.lblCalorias.TabIndex = 27;
            this.lblCalorias.Text = "Calorias";
            // 
            // lblSabor
            // 
            this.lblSabor.AutoSize = true;
            this.lblSabor.Location = new System.Drawing.Point(156, 117);
            this.lblSabor.Name = "lblSabor";
            this.lblSabor.Size = new System.Drawing.Size(35, 13);
            this.lblSabor.TabIndex = 28;
            this.lblSabor.Text = "Sabor";
            // 
            // lblIngredientes
            // 
            this.lblIngredientes.AutoSize = true;
            this.lblIngredientes.Location = new System.Drawing.Point(246, 163);
            this.lblIngredientes.Name = "lblIngredientes";
            this.lblIngredientes.Size = new System.Drawing.Size(65, 13);
            this.lblIngredientes.TabIndex = 29;
            this.lblIngredientes.Text = "Ingredientes";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(289, 115);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 31;
            this.lblMarca.Text = "Marca";
            // 
            // nudStock
            // 
            this.nudStock.Location = new System.Drawing.Point(15, 131);
            this.nudStock.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(117, 20);
            this.nudStock.TabIndex = 3;
            // 
            // nudPeso
            // 
            this.nudPeso.Location = new System.Drawing.Point(15, 179);
            this.nudPeso.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPeso.Name = "nudPeso";
            this.nudPeso.Size = new System.Drawing.Size(117, 20);
            this.nudPeso.TabIndex = 4;
            // 
            // nudValor
            // 
            this.nudValor.Location = new System.Drawing.Point(15, 222);
            this.nudValor.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudValor.Name = "nudValor";
            this.nudValor.Size = new System.Drawing.Size(117, 20);
            this.nudValor.TabIndex = 5;
            // 
            // nudCalorias
            // 
            this.nudCalorias.Enabled = false;
            this.nudCalorias.Location = new System.Drawing.Point(159, 88);
            this.nudCalorias.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCalorias.Name = "nudCalorias";
            this.nudCalorias.Size = new System.Drawing.Size(117, 20);
            this.nudCalorias.TabIndex = 8;
            // 
            // btMostrar
            // 
            this.btMostrar.Location = new System.Drawing.Point(432, 330);
            this.btMostrar.Name = "btMostrar";
            this.btMostrar.Size = new System.Drawing.Size(280, 35);
            this.btMostrar.TabIndex = 36;
            this.btMostrar.Text = "Mostrar informacion";
            this.btMostrar.UseVisualStyleBackColor = true;
            this.btMostrar.Click += new System.EventHandler(this.btMostrar_Click);
            // 
            // lstMateriales
            // 
            this.lstMateriales.FormattingEnabled = true;
            this.lstMateriales.Location = new System.Drawing.Point(735, 25);
            this.lstMateriales.Name = "lstMateriales";
            this.lstMateriales.Size = new System.Drawing.Size(280, 199);
            this.lstMateriales.TabIndex = 37;
            // 
            // cmbIngredientes
            // 
            this.cmbIngredientes.FormattingEnabled = true;
            this.cmbIngredientes.Location = new System.Drawing.Point(159, 179);
            this.cmbIngredientes.Name = "cmbIngredientes";
            this.cmbIngredientes.Size = new System.Drawing.Size(250, 21);
            this.cmbIngredientes.TabIndex = 12;
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(289, 72);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(44, 13);
            this.lblMaterial.TabIndex = 30;
            this.lblMaterial.Text = "Material";
            // 
            // tbMaterial
            // 
            this.tbMaterial.Enabled = false;
            this.tbMaterial.Location = new System.Drawing.Point(292, 87);
            this.tbMaterial.Name = "tbMaterial";
            this.tbMaterial.Size = new System.Drawing.Size(117, 20);
            this.tbMaterial.TabIndex = 10;
            // 
            // btnCargarMateriales
            // 
            this.btnCargarMateriales.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnCargarMateriales.Location = new System.Drawing.Point(735, 280);
            this.btnCargarMateriales.Name = "btnCargarMateriales";
            this.btnCargarMateriales.Size = new System.Drawing.Size(280, 35);
            this.btnCargarMateriales.TabIndex = 38;
            this.btnCargarMateriales.Text = "Cargar Materiales";
            this.btnCargarMateriales.UseVisualStyleBackColor = true;
            this.btnCargarMateriales.Click += new System.EventHandler(this.btnCargarMateriales_Click);
            // 
            // btnGuardarMateriales
            // 
            this.btnGuardarMateriales.Enabled = false;
            this.btnGuardarMateriales.Location = new System.Drawing.Point(735, 330);
            this.btnGuardarMateriales.Name = "btnGuardarMateriales";
            this.btnGuardarMateriales.Size = new System.Drawing.Size(280, 35);
            this.btnGuardarMateriales.TabIndex = 39;
            this.btnGuardarMateriales.Text = "Guardar Materiales";
            this.btnGuardarMateriales.UseVisualStyleBackColor = true;
            this.btnGuardarMateriales.Click += new System.EventHandler(this.btnGuardarMateriales_Click);
            // 
            // btnAgregarMateriales
            // 
            this.btnAgregarMateriales.Enabled = false;
            this.btnAgregarMateriales.Location = new System.Drawing.Point(735, 230);
            this.btnAgregarMateriales.Name = "btnAgregarMateriales";
            this.btnAgregarMateriales.Size = new System.Drawing.Size(280, 35);
            this.btnAgregarMateriales.TabIndex = 40;
            this.btnAgregarMateriales.Text = "Recargar materiales";
            this.btnAgregarMateriales.UseVisualStyleBackColor = true;
            this.btnAgregarMateriales.Click += new System.EventHandler(this.btnAgregarMateriales_Click);
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Location = new System.Drawing.Point(429, 9);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(55, 13);
            this.lblProductos.TabIndex = 41;
            this.lblProductos.Text = "Productos";
            // 
            // lbMateriales
            // 
            this.lbMateriales.AutoSize = true;
            this.lbMateriales.Location = new System.Drawing.Point(732, 9);
            this.lbMateriales.Name = "lbMateriales";
            this.lbMateriales.Size = new System.Drawing.Size(55, 13);
            this.lbMateriales.TabIndex = 42;
            this.lbMateriales.Text = "Materiales";
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Location = new System.Drawing.Point(156, 224);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(0, 13);
            this.lblInformacion.TabIndex = 43;
            // 
            // FrmFabrica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 383);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.lbMateriales);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.btnAgregarMateriales);
            this.Controls.Add(this.btnGuardarMateriales);
            this.Controls.Add(this.btnCargarMateriales);
            this.Controls.Add(this.cmbIngredientes);
            this.Controls.Add(this.lstMateriales);
            this.Controls.Add(this.btMostrar);
            this.Controls.Add(this.nudCalorias);
            this.Controls.Add(this.nudValor);
            this.Controls.Add(this.nudPeso);
            this.Controls.Add(this.nudStock);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.lblIngredientes);
            this.Controls.Add(this.lblSabor);
            this.Controls.Add(this.lblCalorias);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.tbMaterial);
            this.Controls.Add(this.tbSabor);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.nudId);
            this.Controls.Add(this.rbHerramienta);
            this.Controls.Add(this.rbComida);
            this.Controls.Add(this.lstProductos);
            this.Controls.Add(this.btnGuardarInforme);
            this.Controls.Add(this.btnAgregar);
            this.Name = "FrmFabrica";
            this.Text = "Tp3 - Alvaro Elena 2D";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFabrica_FormClosing);
            this.Load += new System.EventHandler(this.FrmFabrica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCalorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.Button btnGuardarInforme;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RadioButton rbComida;
        private System.Windows.Forms.RadioButton rbHerramienta;
        private System.Windows.Forms.NumericUpDown nudId;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbSabor;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCalorias;
        private System.Windows.Forms.Label lblSabor;
        private System.Windows.Forms.Label lblIngredientes;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.NumericUpDown nudStock;
        private System.Windows.Forms.NumericUpDown nudPeso;
        private System.Windows.Forms.NumericUpDown nudValor;
        private System.Windows.Forms.NumericUpDown nudCalorias;
        private System.Windows.Forms.Button btMostrar;
        private System.Windows.Forms.ListBox lstMateriales;
        private System.Windows.Forms.ComboBox cmbIngredientes;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.TextBox tbMaterial;
        private System.Windows.Forms.Button btnCargarMateriales;
        private System.Windows.Forms.Button btnGuardarMateriales;
        private System.Windows.Forms.Button btnAgregarMateriales;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Label lbMateriales;
        private System.Windows.Forms.Label lblInformacion;
    }
}

