using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data.SqlClient;
using System.Data;

using CEntidades_Login;

namespace CDatos_Login
{
    public class Class1
    {
        SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["TheVirtualTianguisProyect.Properties.Settings.Conexion"].ConnectionString);

        public DataTable D_Login(CEntidades_Login.Class1 obje)
        {
            SqlCommand cmd = new SqlCommand("sp_login", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usu", obje.usuario1);
            cmd.Parameters.AddWithValue("@pass", obje.password1);
            cmd.Parameters.AddWithValue("@editar", obje.editar1);
            cmd.Parameters.AddWithValue("@almacen", obje.almacen1);
            cmd.Parameters.AddWithValue("@vender", obje.vender1);
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtable1 = new DataTable();
            da.Fill(dtable1);

            return dtable1;

        }
    }
}
