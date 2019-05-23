using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace TheVirtualTianguisProyect.Negocios.Datos
{
    class DatosEmpleado
    {
        public Int32 id_empleado;
        public String Nombre;
        public String APaterno;
        public String AMaterno;
        public String Nombre_usuario;
        public Int32 Edad;
        public String Oficio;
        public Boolean Editar;
        public Boolean Almacen;
        public Boolean Vender;
        public String Fecha_alta;
        public Int32 Salario;
        public String Contraseña;
        public Boolean EmpleadoActivo;

        public DatosEmpleado()
        {

        }

        public DatosEmpleado(DataRow dr)
        {
            if (dr["id_empleado"] != DBNull.Value)
            {
                this.id_empleado = Int32.Parse(dr["id_empleado"].ToString());
            }
            
            if(dr["Nombre"] != DBNull.Value)
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

            if (dr["Nombre_usuario"] != DBNull.Value)
            {
                this.Nombre_usuario = dr["Nombre_usuario"].ToString();
            }

            if (dr["Edad"] != DBNull.Value)
            {
                this.Edad = Int32.Parse(dr["Edad"].ToString());
            }

            if (dr["Oficio"] != DBNull.Value)
            {
                this.Oficio = dr["Oficio"].ToString();
            }

            if (dr["Editar"] != DBNull.Value)
            {
                this.Editar = Boolean.Parse(dr["Editar"].ToString());
            }

            if (dr["Almacen"] != DBNull.Value)
            {
                this.Almacen = Boolean.Parse(dr["Almacen"].ToString());
            }

            if (dr["Vender"] != DBNull.Value)
            {
                this.Vender = Boolean.Parse(dr["Vender"].ToString());
            }

            if (dr["Fecha_alta"] != DBNull.Value)
            {
                this.Fecha_alta = dr["Fecha_alta"].ToString();
            }

            if (dr["Salario"] != DBNull.Value)
            {
                this.Salario = Int32.Parse(dr["Salario"].ToString());
            }

            if (dr["Contraseña"] != DBNull.Value)
            {
                this.Contraseña = dr["Contraseña"].ToString();
            }

            if (dr["EmpleadoActivo"] != DBNull.Value)
            {
                this.EmpleadoActivo = Boolean.Parse(dr["EmpleadoActivo"].ToString());
            }
        }
    }
    
}
