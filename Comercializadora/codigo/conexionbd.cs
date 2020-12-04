using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comercializadora.codigo
{
    class conexionbd
    {
       
        //data source=DESKTOP-DF7P92M; initial Catalog=Comercializadora; integrated security=true
        string cadena = "Server=tcp:serverappx.database.windows.net,1433;Database=FarmaciaDB;User ID=administrador; Password=Unah-vs2020;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

     public SqlConnection Conectarbd = new SqlConnection();
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;
        //Constructor
        public conexionbd()
        {
            Conectarbd.ConnectionString = cadena;
        }

        //Metodo para abrir la conexion
        public void abrir()
        {
            try
            {
                Conectarbd.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error al abrir BD " ,ex.Message);
            }
        }

        //Metodo para cerrar la conexion
        public void cerrar()
        {
            Conectarbd.Close();
        }

        public void vistas( DataGridView tabla)
        {
            try
            {
               
                da = new SqlDataAdapter("SELECT * FROM proveedor", Conectarbd);
                dt = new DataTable();
                da.Fill(dt);
                tabla.DataSource = dt;

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error" + ex.Message);
                
            }
        }
    }
}
