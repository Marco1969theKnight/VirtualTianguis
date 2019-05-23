using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace TheVirtualTianguisProyect.Negocios.Datos
{
    class DatosCliente
    {
        public Int32 ID;
        public String RFC;
        public String Nombre;
        public String APaterno;
        public String AMaterno;
        public String Estado;
        public String Ciudad;
        public String Colonia;
        public String Calle;
        public Int32 NoExt;
        public Int32 NoInt;
        public Int32 CodigoPostal;
        public Boolean ClienteActivo;

        public DatosCliente()
        {

        }

        public DatosCliente(DataRow dr)
        {
            if(dr["ID"] != DBNull.Value)
            {
                this.ID = Int32.Parse(dr["ID"].ToString());
            }

            if (dr["RFC"] != DBNull.Value)
            {
                this.RFC = dr["RFC"].ToString();
            }

            if (dr["Nombre"] != DBNull.Value)
            {
                this.Nombre = dr["Nombre"].ToString();
            }

            if (dr["APaterno"] != DBNull.Value)
            {
                this.APaterno = dr["APaterno"].ToString();
            }

            if (dr["AMaterno"] != DBNull.Value)
            {
                this.AMaterno = dr["AMaterno"].ToString();
            }

            if (dr["Estado"] != DBNull.Value)
            {
                this.Estado = dr["Estado"].ToString();
            }

            if (dr["Ciudad"] != DBNull.Value)
            {
                this.Ciudad = dr["Ciudad"].ToString();
            }

            if (dr["Colonia"] != DBNull.Value)
            {
                this.Colonia = dr["Colonia"].ToString();
            }

            if (dr["Calle"] != DBNull.Value)
            {
                this.Calle = dr["Calle"].ToString();
            }

            if (dr["NoExt"] != DBNull.Value)
            {
                this.NoExt = Int32.Parse(dr["NoExt"].ToString());
            }

            if (dr["NoInt"] != DBNull.Value)
            {
                this.NoInt = Int32.Parse(dr["NoInt"].ToString());
            }

            if (dr["CodigoPostal"] != DBNull.Value)
            {
                this.CodigoPostal = Int32.Parse(dr["CodigoPostal"].ToString());
            }

            if (dr["ClienteActivo"] != DBNull.Value)
            {
                this.ClienteActivo = Boolean.Parse(dr["ClienteActivo"].ToString());
            }
        }
    }
}
