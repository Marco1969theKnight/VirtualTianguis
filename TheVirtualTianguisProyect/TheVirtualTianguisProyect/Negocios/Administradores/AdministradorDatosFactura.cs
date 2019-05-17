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
    class AdministradorDatosFactura
    {
        public static TheVirtualTianguisProyect.Negocios.Datos.DatosFactura ObtenerDatosFactura(System.Double IDFactura)
        {
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "select * from Factura where ID = " + IDFactura;

            DataTable Dt = TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteQuery(ConnectionString, query, "Factura");
            if (Dt.Rows.Count == 0)
            {
                return null;
            }

            return new TheVirtualTianguisProyect.Negocios.Datos.DatosFactura(Dt.Rows[0]);
        }

        public static void BajaFactura(TheVirtualTianguisProyect.Negocios.Datos.DatosFactura DatosFactura)
        {
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "update Factura set FacturaActiva = '" + false + "' where ID = " + DatosFactura.ID;

            TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteNonQuery(ConnectionString, query);
        }

        public static void AltaFactura(TheVirtualTianguisProyect.Negocios.Datos.DatosFactura DatosFactura)
        {
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "insert into Factura( ID, FechaFacturacion, UsuarioEmisor, Pago, Productos, NoVenta, Cliente, FacturaActiva ) values ( " + DatosFactura.ID + ",  " + "'" + DatosFactura.FechaFacturacion + "', " + "'" + DatosFactura.UsuarioEmisor + "', " + DatosFactura.Pago + ", " + DatosFactura.Productos + " , " + DatosFactura.NoVenta + ", " + DatosFactura.Cliente + ", '" + DatosFactura.FacturaActiva + "') ";

            TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteNonQuery(ConnectionString, query);
        }

        public static Double VerificaFacturaAlta(System.Int32 NoVenta)
        {
            int Bandera;
            SqlDataReader Encontrado;
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "SELECT * FROM Factura WHERE NoVenta= '" + NoVenta + "'";

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

        public static void ActualizaDatosFactura(TheVirtualTianguisProyect.Negocios.Datos.DatosFactura DatosFactura)
        {
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "update Factura set ID = " + DatosFactura.ID + ", FechaFacturacion = '" + DatosFactura.FechaFacturacion + "', UsuarioEmisor = '" + DatosFactura.UsuarioEmisor + "', Pago = " + DatosFactura.Pago + ", Productos = " + DatosFactura.Productos + ", NoVenta = " + DatosFactura.NoVenta + ", Cliente = " + DatosFactura.Cliente + ", FacturaActiva = '" + DatosFactura.FacturaActiva + "' where ID = " + DatosFactura.ID;

            TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteNonQuery(ConnectionString, query);
        }

        public static TheVirtualTianguisProyect.Negocios.Datos.DatosFactura ObtenerDatos(System.String NoVenta)
        {
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "SELECT * FROM Factura WHERE NoVenta= " + NoVenta;

            DataTable Dt = TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteQuery(ConnectionString, query, "Factura");
            if (Dt.Rows.Count == 0)
            {
                return null;
            }

            return new TheVirtualTianguisProyect.Negocios.Datos.DatosFactura(Dt.Rows[0]);
        }
    }
}
