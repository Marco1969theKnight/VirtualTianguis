using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace TheVirtualTianguisProyect.Negocios.Datos
{
    class DatosFactura
    {
        public Int32 ID;
        public String FechaFacturacion;
        public String UsuarioEmisor;
        public float Pago;
        public Int32 Productos;
        public Int32 NoVenta;
        public Int32 Cliente;
        public Boolean FacturaActiva;

        public DatosFactura()
        {

        }

        public DatosFactura(DataRow dr)
        {
            if (dr["ID"] != DBNull.Value)
            {
                this.ID = Int32.Parse(dr["ID"].ToString());
            }

            if (dr["FechaFacturacion"] != DBNull.Value)
            {
                this.FechaFacturacion = dr["FechaFacturacion"].ToString();
            }

            if (dr["UsuarioEmisor"] != DBNull.Value)
            {
                this.UsuarioEmisor = dr["UsuarioEmisor"].ToString();
            }

            if (dr["Pago"] != DBNull.Value)
            {
                this.Pago = float.Parse(dr["Pago"].ToString());
            }

            if (dr["Productos"] != DBNull.Value)
            {
                this.Productos = Int32.Parse(dr["Productos"].ToString());
            }

            if (dr["NoVenta"] != DBNull.Value)
            {
                this.NoVenta = Int32.Parse(dr["NoVenta"].ToString());
            }

            if (dr["Cliente"] != DBNull.Value)
            {
                this.Cliente = Int32.Parse(dr["Cliente"].ToString());
            }

            if (dr["FacturaActiva"] != DBNull.Value)
            {
                this.FacturaActiva = Boolean.Parse(dr["FacturaActiva"].ToString());
            }
        }
    }
}
