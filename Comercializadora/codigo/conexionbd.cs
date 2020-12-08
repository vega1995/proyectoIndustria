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
            try
            {
                da.Update(dt);
                MessageBox.Show("Datos salvados correctamente", "Confirmacion");
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        public void validarUsuario(string usuario, string pass)
        {
            try
            {
                
                using (Conectarbd)
                {
                    Conectarbd.Open();
                    //string f = "select a.UsuarioId,a.Contraseña,b.Nombre from usuario a inner join empleado b on a.EmpleadoId=b.EmpleadoID where usuarioID="+usuario+ "  AND contraseña='"+pass+"'";
                    using (SqlCommand cmd = new SqlCommand("select a.UsuarioId,a.Contraseña,b.Nombre from usuario a inner join empleado b on a.EmpleadoId=b.EmpleadoID where a.usuarioID=" + usuario + "  AND a.contraseña='" + pass + "'", Conectarbd))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            string nombre= dr.GetSqlValue(2).ToString();
                            //a = dr.GetSqlValue(0).ToString();
                            Login.usuarioLogeado = usuario;
                            Login.nombreLogeado = nombre;
                            // MessageBox.Show(a);
                            MessageBox.Show("Login exitoso.");
                            principal p = new principal();
                            p.Show();
                            Form1 f = new Form1();
                            f.Hide();
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

        public void verificarRadio(String nombre, RadioButton radio1, RadioButton radio2)
        {
            
            try
            {

                using (Conectarbd)
                {
                    Conectarbd.Open();
                    using (SqlCommand cmd = new SqlCommand("select nombre,tipo,ProveedorID from Proveedor where Nombre='" + nombre+"'", Conectarbd))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            Login.ProveedorIDlog = dr.GetSqlValue(2).ToString();
                            Login.tipoCompra = dr.GetSqlValue(0).ToString();
                            if (dr.GetSqlValue(1).ToString()=="Credito")
                            {
                                radio1.Checked = true;
                            }
                            else
                            {
                                radio2.Checked = true;
                            }
                           
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

        public void mostrarNombre(string usuario)
        {
            String nombre="";
            try
            {

                using (Conectarbd)
                {
                    Conectarbd.Open();
                    using (SqlCommand cmd = new SqlCommand("select Nombre from Empleado where EmpleadoID in(select UsuarioID from Usuario  where UsuarioID="+usuario+")", Conectarbd))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            Login.nombreLogeado = dr.GetSqlValue(0).ToString();

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

     
    }
    }


