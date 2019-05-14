using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace TheVirtualTianguisProyect.Negocios.Datos
{
    class DatosVenta
    {
        public Int32 NoVenta;
        public String Fecha;
        public Int32 Total;
        public Int32 Empleado;
        public Int32 Detalle;
        public Boolean VentaActiva;

        public DatosVenta()
        {

        }

        public DatosVenta(DataRow dr)
        {
            if (dr["NoVenta"] != DBNull.Value)
            {
                this.NoVenta = Int32.Parse(dr["NoVenta"].ToString());
            }

            if (dr["Fecha"] != DBNull.Value)
            {
                this.Fecha = dr["Fecha"].ToString();
            }

            if (dr["Total"] != DBNull.Value)
            {
                this.Total = Int32.Parse(dr["Total"].ToString());
            }

            if (dr["Empleado"] != DBNull.Value)
            {
                this.Empleado = Int32.Parse(dr["Empleado"].ToString());
            }

            if (dr["Detalle"] != DBNull.Value)
            {
                this.Detalle = Int32.Parse(dr["Detalle"].ToString());
            }

            if (dr["VentaActiva"] != DBNull.Value)
            {
                this.VentaActiva = Boolean.Parse(dr["VentaActiva"].ToString());
            }
        }
    }
}
