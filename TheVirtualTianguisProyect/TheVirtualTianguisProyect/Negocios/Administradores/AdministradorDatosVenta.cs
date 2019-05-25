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
    class AdministradorDatosVenta
    {
        public static TheVirtualTianguisProyect.Negocios.Datos.DatosVenta ObtenerDatosVenta(System.Double NoVenta)
        {
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "select * from Ventas where NoVenta = " + NoVenta;

            DataTable Dt = TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteQuery(ConnectionString, query, "Ventas");
            if (Dt.Rows.Count == 0)
            {
                return null;
            }

            return new TheVirtualTianguisProyect.Negocios.Datos.DatosVenta(Dt.Rows[0]);
        }

        public static void BajaVenta(TheVirtualTianguisProyect.Negocios.Datos.DatosVenta DatosVenta)
        {
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "update Ventas set VentaActiva = '" + false + "' where NoVenta = " + DatosVenta.NoVenta;

            TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteNonQuery(ConnectionString, query);
        }

        public static void AltaVenta(TheVirtualTianguisProyect.Negocios.Datos.DatosVenta DatosVenta)
        {
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "insert into Ventas( Fecha, Total, Empleado, Detalle, VentaActiva ) values ( '" + DatosVenta.Fecha + "', " + DatosVenta.Total + ", " + DatosVenta.Empleado + ", " + DatosVenta.Detalle + ", '" + DatosVenta.VentaActiva + "') ";

            TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteNonQuery(ConnectionString, query);
        }

        public static Double VerificaVentaAlta(System.Int32 NoVenta)
        {
            int Bandera;
            SqlDataReader Encontrado;
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "SELECT * FROM Ventas WHERE NoVenta = '" + NoVenta + "'";

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

        public static void ActualizaDatosVenta(TheVirtualTianguisProyect.Negocios.Datos.DatosVenta DatosVenta)
        {
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "update Ventas set Fecha = '" + DatosVenta.Fecha + "', " + ", Total = " + DatosVenta.Total + ", Empleado = " + DatosVenta.Empleado + ", Detalle = " + DatosVenta.Detalle + ", VentaActiva = '" + DatosVenta.VentaActiva + "' where NoVenta = " + DatosVenta.NoVenta;

            TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteNonQuery(ConnectionString, query);
        }

        public static TheVirtualTianguisProyect.Negocios.Datos.DatosVenta ObtenerVenta(System.Int32 NoVenta)
        {
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "SELECT * FROM Ventas WHERE NoVenta= " + NoVenta;

            DataTable Dt = TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteQuery(ConnectionString, query, "Ventas");
            if (Dt.Rows.Count == 0)
            {
                return null;
            }

            return new TheVirtualTianguisProyect.Negocios.Datos.DatosVenta(Dt.Rows[0]);
        }
    }
}
