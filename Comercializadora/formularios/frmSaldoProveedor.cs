using Comercializadora.codigo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Comercializadora.formularios
{
    public partial class frmSaldoProveedor : Comercializadora.formularios.mantenimiento
    {
        conexionbd cn;

        public frmSaldoProveedor()
        {

            InitializeComponent();
        }

        private void frmSaldoProveedor_Load(object sender, EventArgs e)
        {
            string fecha = dateTimePicker1.Value.ToString();
            cn = new conexionbd();
            //cn.vistas(" vCompras where Estado='Pendiente'", dataGridView1);
            cn.vistas("vCuentaPagar", dataGridView1);
            rbRTN.Text = "ID";

            /*foreach (DataColumn col in dt.Columns)
                col.ReadOnly = true;*/
           

        }

    }
}
