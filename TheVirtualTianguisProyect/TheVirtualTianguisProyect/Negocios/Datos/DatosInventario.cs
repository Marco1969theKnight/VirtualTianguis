using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace TheVirtualTianguisProyect.Negocios.Datos
{
    class DatosInventario
    {
        public Int32 Productos;
        public Int32 NumeroExistencias;

        public DatosInventario()
        {

        }

        public DatosInventario(DataRow dr)
        {
            if (dr["Productos"] != DBNull.Value)
            {
                this.Productos = Int32.Parse(dr["Productos"].ToString());
            }

            if (dr["NumeroExistencias"] != DBNull.Value)
            {
                this.Productos = Int32.Parse(dr["NumeroExistencias"].ToString());
            }
        }
    }
}
