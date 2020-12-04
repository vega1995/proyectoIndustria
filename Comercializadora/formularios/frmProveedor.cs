using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Comercializadora.formularios
{
    public partial class frmProveedor : Comercializadora.formularios.mantenimiento
    {
        public frmProveedor()
        {
            InitializeComponent();
        }

        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            codigo.conexionbd cn = new codigo.conexionbd();
            cn.abrir();
            cn.vistas(dataGridView1);

        }

       
    }
}
