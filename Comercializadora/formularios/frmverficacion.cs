using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Comercializadora.formularios
{
    public partial class frmverficacion : Comercializadora.formularios.vista
    {
        public frmverficacion()
        {
            InitializeComponent();
        }

        private void Verficacion_Load(object sender, EventArgs e)
        {
            label2.Text="Verificacion de Compras";
            label1.Text = "Selecccione la compra para su aprobación";

        }
    }
}
