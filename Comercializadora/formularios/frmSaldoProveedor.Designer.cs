namespace Comercializadora.formularios
{
    partial class frmSaldoProveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(229, 23);
            this.txtBuscar.Size = new System.Drawing.Size(161, 26);
            // 
            // rbNombre
            // 
            this.rbNombre.Checked = true;
            this.rbNombre.Location = new System.Drawing.Point(145, 24);
            // 
            // rbRTN
            // 
            this.rbRTN.Location = new System.Drawing.Point(410, 23);
            this.rbRTN.Size = new System.Drawing.Size(65, 22);
            this.rbRTN.TabStop = false;
            this.rbRTN.Text = "Fecha";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 356);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(481, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(115, 26);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = new System.DateTime(2020, 12, 10, 0, 0, 0, 0);
            // 
            // frmSaldoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.ClientSize = new System.Drawing.Size(677, 401);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "frmSaldoProveedor";
            this.Load += new System.EventHandler(this.frmSaldoProveedor_Load);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.txtBuscar, 0);
            this.Controls.SetChildIndex(this.rbNombre, 0);
            this.Controls.SetChildIndex(this.rbRTN, 0);
            this.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
