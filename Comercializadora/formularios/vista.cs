using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comercializadora.formularios
{
    public partial class vista : Form
    {
        public vista()
        {
            InitializeComponent();
        }

        

        private void Vista_Load(object sender, EventArgs e)
        {
            fecha.Text = DateTime.Now.ToShortDateString();
        }



        public void DataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

           
            double Total = 0;
            int i = 0;
            double ISV=0;
            foreach (DataGridViewRow row in dataGridView2.Rows )
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

        private void DataGridView2_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void DataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            
        }

        private void soloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DataGridView2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(soloNumeros);
            if (dataGridView2.CurrentCell.ColumnIndex == 1) //Numero de columna
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(soloNumeros);
                }
            }
        }

        protected virtual void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }
    }
}
