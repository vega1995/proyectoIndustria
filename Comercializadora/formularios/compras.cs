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

            DataGridViewTextBoxColumn columna1 = new DataGridViewTextBoxColumn();
            columna1.HeaderText = "Nombre";
            columna1.Width = 200;
            columna1.ReadOnly = true;
            dataGridView2.Columns.Add(columna1);
            DataGridViewTextBoxColumn columna2 = new DataGridViewTextBoxColumn();
            columna2.HeaderText = "Cantidad a Pedir";
            columna2.Width = 100;
            dataGridView2.Columns.Add(columna2);
            columna3 = new DataGridViewTextBoxColumn();
            columna3.HeaderText = "Precio";
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
                ISV += Convert.ToDouble(dataGridView2.Rows[i].Cells[1].Value) * Convert.ToDouble(dataGridView2.Rows[i].Cells[2].Value) * Convert.ToDouble(dataGridView2.Rows[i].Cells[3].Value);
                Total += Convert.ToDouble(row.Cells[1].Value) * Convert.ToDouble(row.Cells[2].Value);
                dataGridView2.Rows[i].Cells[4].Value = Convert.ToDouble(row.Cells[1].Value) * Convert.ToDouble(row.Cells[2].Value);
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
                        fila.Cells[0].Value = row.Cells[2].Value;
                        fila.Cells[1].Value = "1";
                        fila.Cells[2].Value = row.Cells[4].Value;
                        fila.Cells[3].Value = "0.15";
                        fila.Cells[4].Value= row.Cells[4].Value;
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
            DialogResult pos;
            //Querys para Compras y CompraDetalle


            //Validacion si es contado o credito

            if (rtbCredito.Checked)
            {
                //Carga de form de verificacion




            }







            pos=MessageBox.Show("Desea hacer la compra", "Mensaje", MessageBoxButtons.YesNoCancel);
            if (pos== DialogResult.Yes)
            {
                MessageBox.Show("En Mantenimiento :)");
                //Aqui van los procedimientos almacenados


                //Agregando compra
                /*  try
                  {
                      string empleadoID = Login.usuarioLogeado;
                      string proveedorID = Login.ProveedorIDlog;
                      string tipoCompra = Login.tipoCompra;
                     // string fecha = dateTime.ToString("dd/MM/yyyy");
                      conexionbd cn = new conexionbd();
                      using (SqlCommand cmd = new SqlCommand("spAgregarCompra", cn.Conectarbd))
                      {

                          cmd.CommandType = CommandType.StoredProcedure;
                          cmd.Parameters.Add(new SqlParameter("@ProveedorId",proveedorID));
                          cmd.Parameters.Add(new SqlParameter("@empleadoId", empleadoID));
                          cmd.Parameters.Add(new SqlParameter("@tipoCompra", tipoCompra));
                      }


                  }
                  catch (Exception)
                  {

                      throw;
                  }*/
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
