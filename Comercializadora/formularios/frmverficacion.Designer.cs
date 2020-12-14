namespace Comercializadora.formularios
{
    partial class frmverficacion
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
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Size = new System.Drawing.Size(297, 26);
            // 
            // verficacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.ClientSize = new System.Drawing.Size(1370, 535);
            this.Name = "verficacion";
            this.Load += new System.EventHandler(this.Verficacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
