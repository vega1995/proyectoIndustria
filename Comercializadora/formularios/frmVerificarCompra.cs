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
    public partial class frmVerificarCompra : Comercializadora.formularios.mantenimiento
    {
        conexionbd cn;
        public frmVerificarCompra()
        {
            InitializeComponent();
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void frmVerificarCompra_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;

            conexionbd cn = new conexionbd();
            cn.vistas(" vCompras where Estado='Pendiente'", dataGridView1);

        }

        protected override void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                cn.guardar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            /**
             AdaptadorDB = new SqlDataAdapter();
             AdaptadorDB.SelectCommand = new SqlCommand("spAgregarProveedor", cn.Conectarbd);
             AdaptadorDB.SelectCommand.CommandType = CommandType.StoredProcedure;
            
             AdaptadorDB.InsertCommand = new SqlCommand("spAgregarProveedor", cn.Conectarbd);
             AdaptadorDB.InsertCommand.CommandType = CommandType.StoredProcedure;
             AdaptadorDB.InsertCommand.Parameters.Add("@proveedorID", SqlDbType.VarChar, 14, "ProveedorID");
             AdaptadorDB.InsertCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50, "Nombre");
             AdaptadorDB.InsertCommand.Parameters.Add("@tipo", SqlDbType.VarChar, 50, "Tipo");
             AdaptadorDB.InsertCommand.Parameters.Add("@credito", SqlDbType.Float, 99999, "credito");
             AdaptadorDB.InsertCommand.Parameters.Add("@direccion", SqlDbType.VarChar, 50, "direccion");
             AdaptadorDB.InsertCommand.Parameters.Add("@telefono", SqlDbType.VarChar, 8, "telefono");
             AdaptadorDB.InsertCommand.Parameters.Add("@correo", SqlDbType.VarChar, 60, "correo");
             AdaptadorDB.InsertCommand.Parameters[0].Direction = ParameterDirection.Output;

              */


        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
