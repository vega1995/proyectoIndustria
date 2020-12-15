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
    public partial class frmPagos : Form
    {
        DataGridViewTextBoxColumn columna3;
        public frmPagos()
        {
            InitializeComponent();
        }

        private void frmPagos_Load(object sender, EventArgs e)
        {
            conexionbd cn = new conexionbd();
            cn.abrir();
            cn.vistas("vProveedoresCredito", dataGridView1);
            cn.vistasCombos("select nombre from proveedor", comboBox3, "nombre");
            cn.vistasCombos("select nombre from banco", comboBox1, "nombre");

            DataGridViewTextBoxColumn columna1 = new DataGridViewTextBoxColumn();
            columna1.HeaderText = "N.Compra";
            columna1.Width = 200;
            columna1.ReadOnly = true;
            /*
             dataGridView2.Columns.Add(columna1);
            DataGridViewTextBoxColumn columna2 = new DataGridViewTextBoxColumn();
            columna2.HeaderText = "Proveedor";
            columna2.Width = 100;
            dataGridView2.Columns.Add(columna2);
            columna3 = new DataGridViewTextBoxColumn();
            columna3.HeaderText = "Fecha";
            columna3.Width = 100;
            dataGridView2.Columns.Add(columna3);

            DataGridViewTextBoxColumn columna4 = new DataGridViewTextBoxColumn();
            columna4.HeaderText = "Saldo";
            columna4.Width = 100;
            dataGridView2.Columns.Add(columna4);
             
             */



            /*Poner columna solo lectura*/
            //bloquearColumna();

        }

        /* private void bloquearColumna()
         {
             dataGridView1.Columns["N.Compra"].ReadOnly = true;
             dataGridView1.Columns["Proveedor"].ReadOnly = true;
             dataGridView1.Columns["Fecha"].ReadOnly = true;
             dataGridView1.Columns["Saldo"].ReadOnly = true;



         }*/

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            conexionbd cn = new conexionbd();
            cn.abrir();
            string proveedor = comboBox3.Text; 
            cn.vistas("vCuentasPorCobrar WHERE Proveedor='"+proveedor+"'", dataGridView1);


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked==false || radioButton2.Checked == false)
            {
                MessageBox.Show("Seleccione tipo de pago");
            }
            conexionbd cn = new conexionbd();
            cn.abrir();
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            string banco = comboBox1.Text;
            cn.vistasCombos("select NumeroCuenta from vCuentas WHERE Tipo ='" + banco + "'", comboBox2, "NumeroCuenta");
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            if (radioButton1.Checked==true)
            {
                label4.Visible = true;
                txtNumero.Visible = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            if (radioButton2.Checked == true)
            {
                label4.Visible = false;
                txtNumero.Visible = false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //procedimiento almacenado pagos a proveedores
            DialogResult pos;
            pos = MessageBox.Show("Desea hacer el Pago", "Mensaje", MessageBoxButtons.YesNoCancel);
            if (pos == DialogResult.Yes)
            {
                //verificacion.estadoCompra = true;
                //  MessageBox.Show("En Mantenimiento :)");
                //Aqui van los procedimientos almacenados
                //Agregando compra
              
                try
                {
                    string descripicion = txtDescripcion.Text;
                    string monto = txtMonto.Text;
                    string tipoPago="null";
                    string empleadoID = Login.usuarioLogeado;
                    string proveedorID= dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    string numero = "";
                    if (txtNumero.Visible)
                    {
                       numero = txtNumero.Text;
                    }
                    else
                    {
                       numero = "";
                    }
                    



                    if (radioButton1.Checked)
                    {
                        
                        tipoPago = "Cheque";
                    }
                    if (radioButton2.Checked)
                    {

                        tipoPago = "Transferencia";
                    }

                    // string fecha = dateTime.ToString("dd/MM/yyyy");
                    conexionbd cn = new conexionbd();
                    cn.Conectarbd.Open();
                    using (SqlCommand cmd = new SqlCommand("spPagar", cn.Conectarbd))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@descripcion", descripicion));
                        cmd.Parameters.Add(new SqlParameter("@empleadoId", empleadoID));
                        cmd.Parameters.Add(new SqlParameter("@tipoPago", tipoPago));
                        cmd.Parameters.Add(new SqlParameter("@Proveedor", proveedorID));
                        cmd.Parameters.Add(new SqlParameter("@monto",Convert.ToDouble( monto)));
                        cmd.Parameters.Add(new SqlParameter("@numero", numero));
                        cmd.Parameters.Add(new SqlParameter("@fecha", Convert.ToDateTime(DateTime.Now.ToShortDateString())));

                        int n = cmd.ExecuteNonQuery();
                        if (n > 0)
                        {
                            MessageBox.Show("Datos guardados exitosamente :)");
                            
                            //this.Close();
                        }
                    }

                   // string query="UPDATE proveedores SET saldo=saldo-"++"WHERE proveedorID"
                    SqlCommand cmd2 = new SqlCommand("",cn.Conectarbd);


                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
