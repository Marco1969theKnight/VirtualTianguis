using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace TheVirtualTianguisProyect.Negocios.Datos
{
    class DatosProveedor
    {
        public Int32 Id_proveedor;
        public String Nombre;
        public Boolean ProveedorActivo;

        public DatosProveedor()
        {

        }

        public DatosProveedor(DataRow dr)
        {
            if (dr["Id_proveedor"] != DBNull.Value)
            {
                this.Id_proveedor = Int32.Parse(dr["Id_proveedor"].ToString());
            }

            if (dr["Nombre"] != DBNull.Value)
            {
                this.Nombre = dr["Nombre"].ToString();
            }

            if (dr["ProveedorActivo"] != DBNull.Value)
            {
                this.ProveedorActivo = Boolean.Parse(dr["ProveedorActivo"].ToString());
            }
        }
    }
}
