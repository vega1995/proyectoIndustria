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
     
    public partial class frmProveedor : Comercializadora.formularios.mantenimiento
    {
        DataTable dt;
        SqlDataAdapter AdaptadorDB;
        conexionbd cn;
        public frmProveedor()
        {
            InitializeComponent();
        }

        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            cn = new conexionbd();
            cn.abrir();
            cn.vistas("vProveedores", dataGridView1);
            ((DataGridViewTextBoxColumn)dataGridView1.Columns["RTN"]).MaxInputLength = 14;
            ((DataGridViewTextBoxColumn)dataGridView1.Columns["Telefono"]).MaxInputLength = 8;
            //cn.llenarDataGridCombo(dataGridView1, "Tipo", "select TOP(2) tipo from vproveedores ");

        }

        protected override void DataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(soloNumeros);
            if (dataGridView1.CurrentCell.ColumnIndex == 0 || dataGridView1.CurrentCell.ColumnIndex == 3 || dataGridView1.CurrentCell.ColumnIndex == 5 || dataGridView1.CurrentCell.ColumnIndex == 6) //Numero de columna
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
        protected override void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 4)
            {
                String email = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                if (email_bien_escrito(email))
                {
                    
                }
                else
                {
                    MessageBox.Show("Invalido");
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                }
                
            }
             
            
        }

        protected override void DataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if(dataGridView1.CurrentCell.ColumnIndex == 4)
            {
                
            }
        }

        private Boolean email_bien_escrito(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
}
