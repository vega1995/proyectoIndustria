using Comercializadora.formularios;
using System;
using System.Collections;
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
        ComboBox cb;
        SqlCommand cmd;
        public String a;
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

        public void vistas( String query,DataGridView tabla)
        {
            
            da = new SqlDataAdapter("select * from " + query, Conectarbd);
            dt = new DataTable();
            SqlCommandBuilder constructor = new SqlCommandBuilder(da);
            constructor.QuotePrefix = "[";
            constructor.QuoteSuffix = "]";
             da.Fill(dt);
                
                tabla.DataSource = dt;
                tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
             
           
           /* try
            {
               
                da = new SqlDataAdapter(query, Conectarbd);
                dt = new DataTable();
                da.Fill(dt);
                
                tabla.DataSource = dt;
                tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error" + ex.Message);
                
            }*/
        }

        public void vistasCombos(String query, ComboBox combito, string campo)
        {

            try
            {

                cmd = new SqlCommand(query, Conectarbd);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    combito.Items.Add(dr[campo].ToString());
                }
                dr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error: " + e.Message);
            }
        }
        public void llenarDataGridCombo(DataGridView tabla, String campo,String query)
        {
            da = new SqlDataAdapter(query, Conectarbd);
            dt = new DataTable();
            da.Fill(dt);

            DataGridViewComboBoxColumn tipo = new DataGridViewComboBoxColumn();
            tipo.HeaderText = campo;
            tipo.Name = campo;
            ArrayList fila = new ArrayList();
            //Agregar los items
            foreach (DataRow dr in dt.Rows)
            {
                fila.Add(dr[campo].ToString());
            }

            tipo.Items.AddRange(fila.ToArray());
            tabla.Columns.Add(tipo);

        }
        public void guardar()
        {

            da.Update(dt);
            MessageBox.Show("Datos salvados correctamente", "Confirmacion");
        }

        public void validarUsuario(string usuario, string pass)
        {
            try
            {
                
                using (Conectarbd)
                {
                    Conectarbd.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT usuarioID, contraseña FROM usuario WHERE usuarioID='" + usuario + "' AND contraseña='" + pass + "'", Conectarbd))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                           //a = dr.GetSqlValue(0).ToString();
                           // MessageBox.Show(a);
                            MessageBox.Show("Login exitoso.");
                            
                           // Form1 f = new Form1();
                           // f.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Datos incorrectos.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
       



            /*            try
                        {

                            da = new SqlDataAdapter(query, Conectarbd);
                            cb = new ComboBox();

                            da.Fill(cb.);

                           // tabla.DataSource = dt;
                          //  tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Error" + ex.Message);

                        } */
        }
    }


