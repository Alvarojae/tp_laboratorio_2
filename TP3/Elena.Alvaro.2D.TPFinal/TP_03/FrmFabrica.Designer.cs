
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
            this.lstStock = new System.Windows.Forms.ListBox();
            this.rtbLnInforme = new System.Windows.Forms.RichTextBox();
            this.btnGuardarInforme = new System.Windows.Forms.Button();
            this.btnVerInforme = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.RbComida = new System.Windows.Forms.RadioButton();
            this.rbHerramienta = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lstStock
            // 
            this.lstStock.FormattingEnabled = true;
            this.lstStock.Location = new System.Drawing.Point(692, 12);
            this.lstStock.Name = "lstStock";
            this.lstStock.Size = new System.Drawing.Size(314, 368);
            this.lstStock.TabIndex = 9;
            // 
            // rtbLnInforme
            // 
            this.rtbLnInforme.Location = new System.Drawing.Point(367, 386);
            this.rtbLnInforme.Name = "rtbLnInforme";
            this.rtbLnInforme.ReadOnly = true;
            this.rtbLnInforme.Size = new System.Drawing.Size(639, 188);
            this.rtbLnInforme.TabIndex = 8;
            this.rtbLnInforme.Text = "";
            // 
            // btnGuardarInforme
            // 
            this.btnGuardarInforme.Location = new System.Drawing.Point(12, 544);
            this.btnGuardarInforme.Name = "btnGuardarInforme";
            this.btnGuardarInforme.Size = new System.Drawing.Size(302, 35);
            this.btnGuardarInforme.TabIndex = 7;
            this.btnGuardarInforme.Text = "Guardar Informe";
            this.btnGuardarInforme.UseVisualStyleBackColor = true;
            // 
            // btnVerInforme
            // 
            this.btnVerInforme.Location = new System.Drawing.Point(12, 503);
            this.btnVerInforme.Name = "btnVerInforme";
            this.btnVerInforme.Size = new System.Drawing.Size(302, 35);
            this.btnVerInforme.TabIndex = 6;
            this.btnVerInforme.Text = "Ver Informe";
            this.btnVerInforme.UseVisualStyleBackColor = true;
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(12, 462);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(302, 35);
            this.btnVender.TabIndex = 5;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            // 
            // RbComida
            // 
            this.RbComida.AutoSize = true;
            this.RbComida.Location = new System.Drawing.Point(12, 41);
            this.RbComida.Name = "RbComida";
            this.RbComida.Size = new System.Drawing.Size(60, 17);
            this.RbComida.TabIndex = 10;
            this.RbComida.TabStop = true;
            this.RbComida.Text = "Comida";
            this.RbComida.UseVisualStyleBackColor = true;
            // 
            // rbHerramienta
            // 
            this.rbHerramienta.AutoSize = true;
            this.rbHerramienta.Location = new System.Drawing.Point(105, 41);
            this.rbHerramienta.Name = "rbHerramienta";
            this.rbHerramienta.Size = new System.Drawing.Size(87, 17);
            this.rbHerramienta.TabIndex = 11;
            this.rbHerramienta.TabStop = true;
            this.rbHerramienta.Text = "Herramientas";
            this.rbHerramienta.UseVisualStyleBackColor = true;
            // 
            // FrmFabrica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 586);
            this.Controls.Add(this.rbHerramienta);
            this.Controls.Add(this.RbComida);
            this.Controls.Add(this.lstStock);
            this.Controls.Add(this.rtbLnInforme);
            this.Controls.Add(this.btnGuardarInforme);
            this.Controls.Add(this.btnVerInforme);
            this.Controls.Add(this.btnVender);
            this.Name = "FrmFabrica";
            this.Text = "Tp3 - Alvaro Elena 2D";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFabrica_FormClosing);
            this.Load += new System.EventHandler(this.FrmFabrica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstStock;
        private System.Windows.Forms.RichTextBox rtbLnInforme;
        private System.Windows.Forms.Button btnGuardarInforme;
        private System.Windows.Forms.Button btnVerInforme;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.RadioButton RbComida;
        private System.Windows.Forms.RadioButton rbHerramienta;
    }
}

