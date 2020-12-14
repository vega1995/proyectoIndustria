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
    public partial class compras : vista
    {
        DataGridViewTextBoxColumn columna3;
        public compras()
        {
            InitializeComponent();
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            conexionbd cn = new conexionbd();
            cn.abrir();
            cn.vistas("vInventarioCompra order by Existencia asc, [Fecha de Vencimiento] asc", dataGridView1);
            cn.vistasCombos("select nombre from proveedor", comboBox1, "nombre");
            lbnCompra.Text = cn.compraid();
            DataGridViewTextBoxColumn columna6 = new DataGridViewTextBoxColumn();
            columna6.HeaderText = "ID";
            columna6.Name = "ID";
            columna6.Width = 100;
            columna6.ReadOnly = true;
            dataGridView2.Columns.Add(columna6);
            DataGridViewTextBoxColumn columna1 = new DataGridViewTextBoxColumn();
            columna1.HeaderText = "Nombre";
            columna1.Width = 200;
            columna1.ReadOnly = true;
            dataGridView2.Columns.Add(columna1);
            DataGridViewTextBoxColumn columna2 = new DataGridViewTextBoxColumn();
            columna2.HeaderText = "Cantidad a Pedir";
            columna2.Name = "Cantidad";
            columna2.Width = 100;
            dataGridView2.Columns.Add(columna2);
            columna3 = new DataGridViewTextBoxColumn();
            columna3.HeaderText = "Precio";
            columna3.Name = "Precio";
            columna3.Width = 100;
            dataGridView2.Columns.Add(columna3);

            DataGridViewTextBoxColumn columna4 = new DataGridViewTextBoxColumn();
            columna4.HeaderText = "ISV";
            columna4.Width = 100;
            dataGridView2.Columns.Add(columna4);

            DataGridViewTextBoxColumn columna5 = new DataGridViewTextBoxColumn();
            columna5.HeaderText = "SubTotal";
            columna5.Width = 100;
            columna5.ReadOnly = true;
            dataGridView2.Columns.Add(columna5);

           

            /*Poner columna solo lectura*/
            bloquearColumna();

        }
       
        public void calcular()
        {
            double Total = 0;
            int i = 0;
            double ISV = 0;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                ISV += 0;
                Total += Convert.ToDouble(row.Cells[2].Value) * Convert.ToDouble(row.Cells[3].Value);
                dataGridView2.Rows[i].Cells[4].Value = "0";
                //row.Cells[4].RowIndex[i].Value = Total;
                i++;
            }
            txtSubTotal.Text = Total.ToString("N");
            txtISV.Text = ISV.ToString("N");
            double granTotal = Total + ISV;
            txtTotal.Text = granTotal.ToString("N");

        }
        
        private void Button3_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                try
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {

                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(dataGridView2);
                        fila.Cells[0].Value = row.Cells[1].Value;
                        fila.Cells[1].Value = row.Cells[2].Value;
                        fila.Cells[2].Value = "1";
                        fila.Cells[3].Value = row.Cells[4].Value;
                        fila.Cells[4].Value = "0";
                        fila.Cells[5].Value= row.Cells[4].Value;
                       
                        dataGridView2.Rows.Add(fila);
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            calcular();
            bloquearColumna();
            
            
        }
       

            private void bloquearColumna()
        {
            dataGridView1.Columns["ID"].ReadOnly = true;
            dataGridView1.Columns["Nombre"].ReadOnly = true;
            dataGridView1.Columns["Existencia"].ReadOnly = true;
            dataGridView1.Columns["Precio"].ReadOnly = true;
            dataGridView1.Columns["Bodega"].ReadOnly = true;
            dataGridView1.Columns["Fecha De Vencimiento"].ReadOnly = true;


        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Por favor elija proveedor");
                return;
            }

            if (txtTotal.Text=="")
            {
                MessageBox.Show("Por Favor elija los productos");
                return;
            }

            //Querys para Compras y CompraDetalle


            //Validacion si es contado o credito

            if (rdbContado.Checked)
            {
                verificacion.estadoCompra = false;
                //Carga de form de verificacion
                frmconfirm confirmar = new frmconfirm();
                verificacion.subTotal = txtSubTotal.Text;
                verificacion.total= txtTotal.Text;
                verificacion.proveedores = comboBox1.Text;
               verificacion.nCompra = lbnCompra.Text;
                verificacion.tipoCompra="Credito";
                verificacion.impuesto = txtISV.Text;

                confirmar.Show();

               
                if (verificacion.estadoCompra)
                {
                    //Procedimiento almacenado de compradetalle
                    try
                    {
                        conexionbd conn = new conexionbd();
                        using (conn.Conectarbd)
                        {
                            conn.abrir();


                            int Contador = 0;
                            using (SqlCommand cmd = new SqlCommand("spCompraDetalle", conn.Conectarbd))
                            {
                                
                                cmd.CommandType = CommandType.StoredProcedure;
                                foreach (DataGridViewRow row in dataGridView2.Rows)
                                {
                                    cmd.Parameters.Clear();
                                    cmd.Parameters.AddWithValue("@CompraID", Convert.ToInt32(verificacion.nCompra));
                                    cmd.Parameters.AddWithValue("@ProductoID", Convert.ToString(row.Cells["ID"].Value));
                                    cmd.Parameters.AddWithValue("@Cantidad", Convert.ToInt32(row.Cells["cantidad"].Value));
                                    cmd.Parameters.AddWithValue("@Precio", Convert.ToDouble(row.Cells["Precio"].Value));
                                    cmd.Parameters.AddWithValue("@ISV",0 );
                                    cmd.ExecuteNonQuery();
                                    Contador++;
                                }
                                if (Contador>0)

                                {
                                    MessageBox.Show("Compra realizada correctamente");
                                    verificacion.estadoCompra = false;
                                }
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
        protected override void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           string combo = comboBox1.SelectedItem.ToString();
            conexionbd c = new conexionbd();
            c.verificarRadio(combo, rdbContado, rtbCredito, txtSaldo,labelSaldo);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            conexionbd con = new conexionbd();
            con.vistas(" vInventarioCompra where Nombre Like '%" + textBox1.Text+"%'", dataGridView1);
        }
    }
}
