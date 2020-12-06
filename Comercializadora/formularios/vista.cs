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
    }
}
