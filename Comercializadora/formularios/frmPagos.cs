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
            cn.vistas("vCuentasPorCobrar", dataGridView1);
            cn.vistasCombos("select nombre from proveedor", comboBox3, "nombre");
            cn.vistasCombos("select nombre from banco", comboBox1, "nombre");

            DataGridViewTextBoxColumn columna1 = new DataGridViewTextBoxColumn();
            columna1.HeaderText = "N.Compra";
            columna1.Width = 200;
            columna1.ReadOnly = true;
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
            conexionbd cn = new conexionbd();
            cn.abrir();
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            string banco = comboBox1.Text;
            if(radioButton1.Checked==true)
            { 
                cn.vistasCombos("select NumeroCuenta from vCuentas WHERE nombre ='" + banco + "'AND tipo='Cheques'", comboBox2, "NumeroCuenta");
            }

            if (radioButton2.Checked == true)
            {
                cn.vistasCombos("select NumeroCuenta from vCuentas WHERE nombre ='" + banco + "'AND tipo='Ahorros'", comboBox2, "NumeroCuenta");
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            if (radioButton1.Checked==true)
            {
                label4.Visible = true;
                textBox1.Visible = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            if (radioButton2.Checked == true)
            {
                label4.Visible = false;
                textBox1.Visible = false;
            }
        }
    }
}
