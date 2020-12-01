using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercializadora.codigo
{
    class conexionbd
    {
        //data source=DESKTOP-DF7P92M; initial Catalog=Comercializadora; integrated security=true
        string cadena = "data source=DESKTOP-DF7P92M; initial Catalog=Comercializadora; integrated security=true";

     public SqlConnection Conectarbd = new SqlConnection();
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
    }
}
