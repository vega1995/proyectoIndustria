using Comercializadora.codigo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Comercializadora.formularios
{
  //  public conexionbd con;
    public partial class frmverficacion : Comercializadora.formularios.mantenimiento
    {
        conexionbd cn;
        public frmverficacion()
        {
            InitializeComponent();
        }

        private void Verficacion_Load(object sender, EventArgs e)
        {
            //label2.Text="Verificacion de Compras";
            // label1.Text = "Selecccione la compra para su aprobación";
            cn = new conexionbd();
            cn.vistas(" vCompras where Estado='Pendiente'", dataGridView1);
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

            frmPagar pague = new frmPagar();
            pague.ShowDialog();
        }
    }
}
