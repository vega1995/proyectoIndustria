using Comercializadora.codigo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comercializadora.formularios
{
    public partial class frmconfirm : Form
    {
        public frmconfirm()
        {
            InitializeComponent();
        }

        private void Frmconfirm_Load(object sender, EventArgs e)
        {
            lbFecha.Text= DateTime.Now.ToShortDateString();
            txtnCompra.Text = verificacion.nCompra;
            txtProveedor.Text = verificacion.proveedores;
            txtSubTotal.Text = verificacion.subTotal;
            txtTipo.Text = verificacion.tipoCompra;
            txtISV.Text = verificacion.impuesto;
            txtTotal.Text = verificacion.total;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult pos;
            pos = MessageBox.Show("Desea hacer la compra", "Mensaje", MessageBoxButtons.YesNoCancel);
            if (pos == DialogResult.Yes)
            {
                //verificacion.estadoCompra = true;
                //  MessageBox.Show("En Mantenimiento :)");
                //Aqui van los procedimientos almacenados
                //Agregando compra
                 try
                  {
                      string empleadoID = Login.usuarioLogeado;
                      string proveedorID = Login.ProveedorIDlog;
                    
                      string tipoCompra = verificacion.tipoCompra;
                    if (tipoCompra=="Credito")
                    {
                        tipoCompra = "CR";
                    }
                    // string fecha = dateTime.ToString("dd/MM/yyyy");
                    conexionbd cn = new conexionbd();
                    cn.Conectarbd.Open();
                    using (SqlCommand cmd = new SqlCommand("spAgregarCompra", cn.Conectarbd))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@ProveedorId", proveedorID));
                        cmd.Parameters.Add(new SqlParameter("@empleadoId", empleadoID));
                        cmd.Parameters.Add(new SqlParameter("@tipoCompra", tipoCompra));
                        cmd.Parameters.Add(new SqlParameter("@fecha", Convert.ToDateTime(lbFecha.Text)));
                        int n=cmd.ExecuteNonQuery();
                        if (n>0)
                        {
                            verificacion.estadoCompra = true;
                            this.Close();
                        }
                    }


                }
                catch (Exception)
                  {

                      throw;
                  }
            }
        }
    }
}
