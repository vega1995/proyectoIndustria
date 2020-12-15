using Comercializadora.codigo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            cn.vistas(" vCompras where Estado='Pendiente'  OR Estado='ANULADA'", dataGridView1);

        }

        protected override void Button1_Click(object sender, EventArgs e)
        {
            string proveedorID = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string compraID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string TOTAL = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            string stado = "";
            if (rbtAceptar.Checked)
            {
                stado = "A";
                cn = new conexionbd();
                cn.abrir();
                using (SqlCommand update = new SqlCommand("spVerificarCompra ", cn.Conectarbd))
                {
                    SqlParameter[] param = new SqlParameter[2];
                    param[0] = new SqlParameter("@CompraID", SqlDbType.Int);
                    param[0].Value = compraID;
                    param[1] = new SqlParameter("@estado", SqlDbType.NChar);
                    param[1].Value = "A";


                    update.CommandType = CommandType.StoredProcedure;
         
                    //txtnCompra.Text
                    update.Parameters.AddRange(param);

                    int n1 = update.ExecuteNonQuery();
                    if (n1>0)
                    {
                        MessageBox.Show("Compra aceptada");
                        cn.vistas(" vCompras where Estado='Pendiente' OR Estado='ANULADA'", dataGridView1);

                    }
                }


            }
            if (rbtDevolver.Checked)
            {
                stado = "X";
                cn = new conexionbd();
                cn.abrir();
                using (SqlCommand update = new SqlCommand("spAnularCompra ", cn.Conectarbd))
                {
                    SqlParameter[] param = new SqlParameter[1];
                    param[0] = new SqlParameter("@CompraID", SqlDbType.Int);
                    param[0].Value = compraID;
                    update.CommandType = CommandType.StoredProcedure;

                    //txtnCompra.Text
                    update.Parameters.AddRange(param);

                     int n2 = update.ExecuteNonQuery();
                    if (n2>0)
                    {
                        MessageBox.Show("Compra anulada");
                    }
                }
            }
               

            if (rdbPendiente.Checked)
            {
                stado = "P";
               
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
