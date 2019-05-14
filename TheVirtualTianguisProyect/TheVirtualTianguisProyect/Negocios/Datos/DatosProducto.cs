using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace TheVirtualTianguisProyect.Negocios.Datos
{
    class DatosProducto
    {
        public Int32 Id_producto;
        public String Nombre;
        public String Marca;
        public float Precio;
        public String Categoria;
        public String Descripcion;
        public Int32 Proveedor;
        public Boolean ProductoActivo;

        public DatosProducto()
        {

        }

        public DatosProducto(DataRow dr)
        {
            if (dr["Id_producto"] != DBNull.Value)
            {
                this.Id_producto = Int32.Parse(dr["Id_producto"].ToString());
            }

            if (dr["Nombre"] != DBNull.Value)
            {
                this.Nombre = dr["Nombre"].ToString();
            }

            if (dr["Marca"] != DBNull.Value)
            {
                this.Marca = dr["Marca"].ToString();
            }

            if (dr["Precio"] != DBNull.Value)
            {
                this.Precio = float.Parse(dr["Precio"].ToString());
            }

            if (dr["Categoria"] != DBNull.Value)
            {
                this.Categoria = dr["Categoria"].ToString();
            }

            if (dr["Descripcion"] != DBNull.Value)
            {
                this.Descripcion = dr["Descripcion"].ToString();
            }

            if (dr["Proveedor"] != DBNull.Value)
            {
                this.Proveedor = Int32.Parse(dr["Proveedor"].ToString());
            }

            if (dr["ProductoActivo"] != DBNull.Value)
            {
                this.ProductoActivo = Boolean.Parse(dr["ProductoActivo"].ToString());
            }
        }
    }
}
