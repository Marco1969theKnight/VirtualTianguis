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
    class AdministradorDatosInventario
    {
        public static void ActualizaExistenciasInventario(Int32 Productos, Int32 NumeroExistencias)
        {
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "update Inventario set NumeroExistencias = " + NumeroExistencias + " where Productos = " + Productos;

            TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteNonQuery(ConnectionString, query);
        }
        public static TheVirtualTianguisProyect.Negocios.Datos.DatosInventario ObtenerDatosInventario(Int32 Productos)
        {
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "Select * From Inventario where Productos = " + Productos;

            DataTable Dt = TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteQuery(ConnectionString, query, "Inventario");
            if (Dt.Rows.Count == 0)
            {
                return null;
            }

            return new TheVirtualTianguisProyect.Negocios.Datos.DatosInventario(Dt.Rows[0]);
        }

    }
}
