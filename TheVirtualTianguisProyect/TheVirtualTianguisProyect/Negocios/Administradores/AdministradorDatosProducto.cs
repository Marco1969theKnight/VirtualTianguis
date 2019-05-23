using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace TheVirtualTianguisProyect.Negocios.Administradores
{
    class AdministradorDatosProducto
    {
        public static TheVirtualTianguisProyect.Negocios.Datos.DatosProducto ObtenerDatosProducto(System.Double IDProducto)
        {
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "select * from Producto where Id_proveedor = " + IDProducto;

            DataTable Dt = TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteQuery(ConnectionString, query, "Producto");
            if (Dt.Rows.Count == 0)
            {
                return null;
            }

            return new TheVirtualTianguisProyect.Negocios.Datos.DatosProducto(Dt.Rows[0]);
        }

        public static void BajaProducto(TheVirtualTianguisProyect.Negocios.Datos.DatosProducto DatosProducto)
        {
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "update Producto set ProductoActivo = '" + false + "' where Id_producto = " + DatosProducto.Id_producto;

            TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteNonQuery(ConnectionString, query);
        }

        public static void AltaProducto(TheVirtualTianguisProyect.Negocios.Datos.DatosProducto DatosProducto)
        {
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "insert into Producto( Nombre, Marca, Precio, Categoria, Descripcion, Proveedor, ProductoActivo ) values ( " + "'" + DatosProducto.Nombre + "', " + "'" + DatosProducto.Marca + "', " + DatosProducto.Precio + ", '" + DatosProducto.Categoria + "' , '" + DatosProducto.Descripcion + "', " + DatosProducto.Proveedor + ", '" + DatosProducto.ProductoActivo + "') ";

            TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteNonQuery(ConnectionString, query);
        }

        public static Double VerificaProductoAlta(System.String Nombre)
        {
            int Bandera;
            SqlDataReader Encontrado;
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "SELECT * FROM Producto WHERE Nombre = '" + Nombre + "'";

            SqlConnection myConnection = new SqlConnection(ConnectionString);
            try
            {
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                Encontrado = myCommand.ExecuteReader();
                if (Encontrado.Read() == false)
                {
                    Bandera = -1;
                }
                else
                {
                    Bandera = 1;
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                MessageBox.Show(message);
                throw ex;
            }
            finally
            {
                if (myConnection.State == ConnectionState.Open)
                    myConnection.Close();
            }
            return Bandera;
        }

        public static void ActualizaDatosProducto(TheVirtualTianguisProyect.Negocios.Datos.DatosProducto DatosProducto)
        {
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "update Producto set Marca = '" + DatosProducto.Marca + "', Precio = " + DatosProducto.Precio + ", Categoria = '" + DatosProducto.Categoria + "', Descripcion = '" + DatosProducto.Descripcion + "', Proveedor = " + DatosProducto.Proveedor + ", ProductoActivo = '" + DatosProducto.ProductoActivo + "' where Id_producto = " + DatosProducto.Id_producto;

            TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteNonQuery(ConnectionString, query);
        }

        public static TheVirtualTianguisProyect.Negocios.Datos.DatosProducto ObtenerDatos(System.String Nombre)
        {
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "SELECT * FROM Producto WHERE Nombre= " + Nombre;

            DataTable Dt = TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteQuery(ConnectionString, query, "Producto");
            if (Dt.Rows.Count == 0)
            {
                return null;
            }

            return new TheVirtualTianguisProyect.Negocios.Datos.DatosProducto(Dt.Rows[0]);
        }
    }
}
