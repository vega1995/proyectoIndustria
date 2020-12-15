namespace Comercializadora.formularios
{
    partial class frmVerificarCompra
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbPendiente = new System.Windows.Forms.RadioButton();
            this.rbtDevolver = new System.Windows.Forms.RadioButton();
            this.rbtAceptar = new System.Windows.Forms.RadioButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Location = new System.Drawing.Point(784, 27);
            this.txtBuscar.Size = new System.Drawing.Size(114, 19);
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged_1);
            // 
            // rbNombre
            // 
            this.rbNombre.Checked = true;
            this.rbNombre.Location = new System.Drawing.Point(459, 23);
            this.rbNombre.Size = new System.Drawing.Size(97, 22);
            this.rbNombre.Text = "N. Compra";
            // 
            // rbRTN
            // 
            this.rbRTN.Location = new System.Drawing.Point(142, 26);
            this.rbRTN.Size = new System.Drawing.Size(92, 22);
            this.rbRTN.TabStop = false;
            this.rbRTN.Text = "Proveedor";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(805, 439);
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(672, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 159);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Verificación";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(19, 111);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(200, 22);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Contiene producto Vencido";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(19, 72);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(99, 22);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Incompleto";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 34);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(87, 22);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Completo";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(12, 376);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(576, 96);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Observaciones:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbPendiente);
            this.groupBox2.Controls.Add(this.rbtDevolver);
            this.groupBox2.Controls.Add(this.rbtAceptar);
            this.groupBox2.Location = new System.Drawing.Point(672, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 134);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // rdbPendiente
            // 
            this.rdbPendiente.AutoSize = true;
            this.rdbPendiente.Location = new System.Drawing.Point(19, 101);
            this.rdbPendiente.Name = "rdbPendiente";
            this.rdbPendiente.Size = new System.Drawing.Size(89, 22);
            this.rdbPendiente.TabIndex = 3;
            this.rdbPendiente.TabStop = true;
            this.rdbPendiente.Text = "Pendiente";
            this.rdbPendiente.UseVisualStyleBackColor = true;
            // 
            // rbtDevolver
            // 
            this.rbtDevolver.AutoSize = true;
            this.rbtDevolver.Location = new System.Drawing.Point(19, 62);
            this.rbtDevolver.Name = "rbtDevolver";
            this.rbtDevolver.Size = new System.Drawing.Size(83, 22);
            this.rbtDevolver.TabIndex = 2;
            this.rbtDevolver.TabStop = true;
            this.rbtDevolver.Text = "Devolver";
            this.rbtDevolver.UseVisualStyleBackColor = true;
            // 
            // rbtAceptar
            // 
            this.rbtAceptar.AutoSize = true;
            this.rbtAceptar.Location = new System.Drawing.Point(19, 25);
            this.rbtAceptar.Name = "rbtAceptar";
            this.rbtAceptar.Size = new System.Drawing.Size(76, 22);
            this.rbtAceptar.TabIndex = 1;
            this.rbtAceptar.TabStop = true;
            this.rbtAceptar.Text = "Aceptar";
            this.rbtAceptar.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(562, 22);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(192, 26);
            this.comboBox2.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(240, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 26);
            this.comboBox1.TabIndex = 6;
            // 
            // frmVerificarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.ClientSize = new System.Drawing.Size(926, 494);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "frmVerificarCompra";
            this.Text = "Verificar Compra";
            this.Load += new System.EventHandler(this.frmVerificarCompra_Load);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.comboBox2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.richTextBox1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.txtBuscar, 0);
            this.Controls.SetChildIndex(this.rbNombre, 0);
            this.Controls.SetChildIndex(this.rbRTN, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbPendiente;
        private System.Windows.Forms.RadioButton rbtDevolver;
        private System.Windows.Forms.RadioButton rbtAceptar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
