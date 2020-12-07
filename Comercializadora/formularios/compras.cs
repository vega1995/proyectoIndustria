using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Comercializadora.formularios
{
    public partial class compras : Comercializadora.formularios.vista
    {
        DataGridViewTextBoxColumn columna3;
        public compras()
        {
            InitializeComponent();
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            codigo.conexionbd cn = new codigo.conexionbd();
            cn.abrir();
            cn.vistas("select * from vinventario order by Existencia asc, [Fecha de Vencimiento] asc", dataGridView1);
            cn.vistasCombos("select nombre from proveedor", comboBox1, "nombre");

            DataGridViewTextBoxColumn columna1 = new DataGridViewTextBoxColumn();
            columna1.HeaderText = "Nombre";
            columna1.Width = 200;
            columna1.ReadOnly = true;
            dataGridView2.Columns.Add(columna1);
            DataGridViewTextBoxColumn columna2 = new DataGridViewTextBoxColumn();
            columna2.HeaderText = "Cantidad a Pedir";
            columna2.Width = 200;
            dataGridView2.Columns.Add(columna2);
            columna3 = new DataGridViewTextBoxColumn();
            columna3.HeaderText = "Precio";
            columna3.Width = 200;
            dataGridView2.Columns.Add(columna3);

            DataGridViewTextBoxColumn columna4 = new DataGridViewTextBoxColumn();
            columna4.HeaderText = "SubTotal";
            columna4.Width = 200;
            columna4.ReadOnly = true;
            dataGridView2.Columns.Add(columna4);

            /*Poner columna solo lectura*/
            bloquearColumna();

        }
       
        public void calcular()
        {
            double Total = 0;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                Total += Convert.ToDouble(row.Cells[1].Value) * Convert.ToDouble(row.Cells[2].Value);

            }

            total.Text = Total.ToString();

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
                        fila.Cells[3].Value = row.Cells[4].Value;
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
    }
}
