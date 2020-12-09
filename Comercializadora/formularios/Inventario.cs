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
    public partial class Inventario : Comercializadora.formularios.mantenimiento
    {
        DataTable dt;
        SqlDataAdapter AdaptadorDB;
        conexionbd cn;
        public Inventario()
        {
            InitializeComponent();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            cn = new conexionbd();
            cn.abrir();
            cn.vistas("Inventario", dataGridView1);
            rbRTN.Text = "ID";
            dataGridView1.Columns[0].ReadOnly = true;
       
        }

        protected override void DataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(soloNumeros);
            if (dataGridView1.CurrentCell.ColumnIndex == 1 || dataGridView1.CurrentCell.ColumnIndex == 2 || dataGridView1.CurrentCell.ColumnIndex == 4 || dataGridView1.CurrentCell.ColumnIndex == 8) //Numero de columna
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(soloNumeros);
                }
            }

        }

        private void soloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        protected override void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                cn.guardar();
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        protected override void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            conexionbd con = new conexionbd();
            if (rbNombre.Checked)
            {
                con.vistas("inventario WHERE nombre LIKE '%" + txtBuscar.Text + "%'", dataGridView1);
            }
            else
            {
                con.vistas("inventario WHERE ProductoID LIKE '%" + txtBuscar.Text + "%'", dataGridView1);
            }

        }
    }
}
