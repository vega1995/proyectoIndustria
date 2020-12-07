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
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {

                Total += Convert.ToDouble(row.Cells[1].Value) * Convert.ToDouble(row.Cells[2].Value);
                row.Cells[3].Value = Total;
            }

            total.Text = Total.ToString();
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

        
    }
}
