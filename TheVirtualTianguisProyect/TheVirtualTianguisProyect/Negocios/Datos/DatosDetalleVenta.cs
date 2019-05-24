using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace TheVirtualTianguisProyect.Negocios.Datos
{
    class DatosDetalleVenta
    {
        public Int32 IdDetalleVenta;
        public Int32 Producto;
        public Int32 Cantidad;
        public Int32 NoVenta;

        public DatosDetalleVenta()
        {

        }

        public DatosDetalleVenta(DataRow dr)
        {
            if (dr["IdDetalleVenta"] != DBNull.Value)
            {
                this.IdDetalleVenta = Int32.Parse(dr["IdDetalleVenta"].ToString());
            }

            if (dr["Producto"] != DBNull.Value)
            {
                this.Producto = Int32.Parse(dr["Producto"].ToString());
            }

            if (dr["Cantidad"] != DBNull.Value)
            {
                this.Cantidad = Int32.Parse(dr["Cantidad"].ToString());
            }

            if (dr["NoVenta"] != DBNull.Value)
            {
                this.NoVenta = Int32.Parse(dr["NoVenta"].ToString());
            }
        }
    }
}
