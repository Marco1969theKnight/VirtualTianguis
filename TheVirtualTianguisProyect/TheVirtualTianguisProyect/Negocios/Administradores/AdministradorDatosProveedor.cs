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
    class AdministradorDatosProveedor
    {
        public static TheVirtualTianguisProyect.Negocios.Datos.DatosProveedor ObtenerDatosProveedor(System.Double IDProveedor)
        {
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "select * from Proveedor where Id_proveedor = " + IDProveedor;

            DataTable Dt = TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteQuery(ConnectionString, query, "Proveedor");
            if (Dt.Rows.Count == 0)
            {
                return null;
            }

            return new TheVirtualTianguisProyect.Negocios.Datos.DatosProveedor(Dt.Rows[0]);
        }

        public static void BajaProveedor(TheVirtualTianguisProyect.Negocios.Datos.DatosProveedor DatosProveedor)
        {
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "update Proveedor set ProveedorActivo = '" + false + "' where Id_proveedor = " + DatosProveedor.Id_proveedor;

            TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteNonQuery(ConnectionString, query);
        }

        public static void AltaProveedor(TheVirtualTianguisProyect.Negocios.Datos.DatosProveedor DatosProveedor)
        {
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "insert into Proveedor( Nombre, ProveedorActivo ) values ( '" + DatosProveedor.Nombre + "', " + "'" + DatosProveedor.ProveedorActivo + "') ";

            TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteNonQuery(ConnectionString, query);
        }

        public static Double VerificaProveedorAlta(System.String Nombre)
        {
            int Bandera;
            SqlDataReader Encontrado;
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "SELECT * FROM Proveedor WHERE Nombre = '" + Nombre + "'";

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

        public static void ActualizaDatosProveedor(TheVirtualTianguisProyect.Negocios.Datos.DatosProveedor DatosProveedor)
        {
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "update Proveedor set ProveedorActivo = '" + DatosProveedor.ProveedorActivo + "' where Id_proveedor = " + DatosProveedor.Id_proveedor;

            TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteNonQuery(ConnectionString, query);
        }

        public static TheVirtualTianguisProyect.Negocios.Datos.DatosProducto ObtenerProveedor(System.String Nombre)
        {
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "SELECT * FROM Proveedor WHERE Nombre= " + Nombre;

            DataTable Dt = TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteQuery(ConnectionString, query, "Producto");
            if (Dt.Rows.Count == 0)
            {
                return null;
            }

            return new TheVirtualTianguisProyect.Negocios.Datos.DatosProducto(Dt.Rows[0]);
        }
    }
}
