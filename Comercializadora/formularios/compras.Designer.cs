namespace Comercializadora.formularios
{
    partial class compras
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
            this.button1 = new System.Windows.Forms.Button();
            this.rdbContado = new System.Windows.Forms.RadioButton();
            this.rtbCredito = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Size = new System.Drawing.Size(149, 26);
            // 
            // button3
            // 
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1008, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 27);
            this.button1.TabIndex = 20;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // rdbContado
            // 
            this.rdbContado.AutoSize = true;
            this.rdbContado.Enabled = false;
            this.rdbContado.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbContado.Location = new System.Drawing.Point(921, 70);
            this.rdbContado.Name = "rdbContado";
            this.rdbContado.Size = new System.Drawing.Size(87, 23);
            this.rdbContado.TabIndex = 29;
            this.rdbContado.TabStop = true;
            this.rdbContado.Text = "Credito";
            this.rdbContado.UseVisualStyleBackColor = true;
            // 
            // rtbCredito
            // 
            this.rtbCredito.AutoSize = true;
            this.rtbCredito.Enabled = false;
            this.rtbCredito.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbCredito.Location = new System.Drawing.Point(828, 70);
            this.rtbCredito.Name = "rtbCredito";
            this.rtbCredito.Size = new System.Drawing.Size(95, 23);
            this.rtbCredito.TabIndex = 28;
            this.rtbCredito.TabStop = true;
            this.rtbCredito.Text = "Contado";
            this.rtbCredito.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(696, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 19);
            this.label9.TabIndex = 27;
            this.label9.Text = "Tipo de compra";
            // 
            // compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.ClientSize = new System.Drawing.Size(1370, 490);
            this.Controls.Add(this.rdbContado);
            this.Controls.Add(this.rtbCredito);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Name = "compras";
            this.Load += new System.EventHandler(this.Compras_Load);
            this.Controls.SetChildIndex(this.txtSubTotal, 0);
            this.Controls.SetChildIndex(this.txtISV, 0);
            this.Controls.SetChildIndex(this.txtTotal, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.rtbCredito, 0);
            this.Controls.SetChildIndex(this.rdbContado, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.RadioButton rdbContado;
        public System.Windows.Forms.RadioButton rtbCredito;
        private System.Windows.Forms.Label label9;
    }
}
