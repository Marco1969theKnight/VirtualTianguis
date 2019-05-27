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
    class AdministradorDetalleVenta
    {
        public static TheVirtualTianguisProyect.Negocios.Datos.DatosDetalleVenta ObtenerDatosDetalleVenta(System.Double IdDetalleVenta)
        {
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "select * from DetalleVentas where IdDetalleVenta = " + IdDetalleVenta;

            DataTable Dt = TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteQuery(ConnectionString, query, "DetalleVentas");
            if (Dt.Rows.Count == 0)
            {
                return null;
            }

            return new TheVirtualTianguisProyect.Negocios.Datos.DatosDetalleVenta(Dt.Rows[0]);
        }

        public static void AltaDetalleVenta(TheVirtualTianguisProyect.Negocios.Datos.DatosDetalleVenta DatosDetalleVenta)
        {
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "insert into DetalleVentas( Producto, Cantidad, NoVenta ) values ( " + DatosDetalleVenta.Producto + ", " + DatosDetalleVenta.Cantidad + ", " + DatosDetalleVenta.NoVenta + ") ";

            TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteNonQuery(ConnectionString, query);
        }

        public static TheVirtualTianguisProyect.Negocios.Datos.DatosDetalleVenta ObtenerDetalleVenta(System.Int32 IdDetalleVenta)
        {
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "SELECT * FROM DetalleVentas WHERE NoVenta= " + IdDetalleVenta;

            DataTable Dt = TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteQuery(ConnectionString, query, "DetalleVentas");
            if (Dt.Rows.Count == 0)
            {
                return null;
            }

            return new TheVirtualTianguisProyect.Negocios.Datos.DatosDetalleVenta(Dt.Rows[0]);
        }

        public static Double VerificaExistVenta(System.Int32 NoVenta)
        {
            int Bandera;
            SqlDataReader Encontrado;
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "SELECT * FROM DetalleVentas WHERE NoVenta = " + NoVenta;

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
    }
}
