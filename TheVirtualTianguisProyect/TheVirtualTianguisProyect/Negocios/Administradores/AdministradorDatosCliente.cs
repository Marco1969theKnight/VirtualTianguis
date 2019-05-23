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
    class AdministradorDatosCliente
    {
        public static TheVirtualTianguisProyect.Negocios.Datos.DatosCliente ObtenerDatosCliente(System.Double IDPaciente)
        {
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "select * from Clientes where ID = " + IDPaciente;

            DataTable Dt = TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteQuery(ConnectionString, query, "Clientes");
            if (Dt.Rows.Count == 0)
            {
                return null;
            }

            return new TheVirtualTianguisProyect.Negocios.Datos.DatosCliente(Dt.Rows[0]);
        }

        public static void BajaCliente(TheVirtualTianguisProyect.Negocios.Datos.DatosCliente DatosUsuario)
        {
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "update Clientes set Activo = '" + false + "' where ID = " + DatosUsuario.ID;

            TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteNonQuery(ConnectionString, query);
        }

        public static void AltaCliente(TheVirtualTianguisProyect.Negocios.Datos.DatosCliente DatosUsuario)
        {
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "insert into Clientes( RFC, Nombre, APaterno, AMaterno, Estado, Ciudad, Calle, NoExt, NoInt, Colonia, CodigoPostal, ClienteActivo) values ( " + "'" + DatosUsuario.RFC + "', " + "'" + DatosUsuario.Nombre + "', " + "'" + DatosUsuario.APaterno + "', " + "'" + DatosUsuario.AMaterno + "', " + "'" + DatosUsuario.Estado + "', " + "'" + DatosUsuario.Ciudad + "', " +  "'" + DatosUsuario.Calle + "', " + DatosUsuario.NoExt + ", " + DatosUsuario.NoInt + ", " + "'" + DatosUsuario.Colonia + "', " + DatosUsuario.CodigoPostal + ", " + "'" + DatosUsuario.ClienteActivo + "') ";

            TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteNonQuery(ConnectionString, query);
        }

        public static Double VerificaClienteAlta(System.String Nombre, System.String APaterno, System.String AMaterno)
        {
            int Bandera;
            SqlDataReader Encontrado;
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "SELECT * FROM Clientes WHERE Nombre= '" + Nombre + "' And APaterno= '" + APaterno + "' And AMaterno= '" + AMaterno + "'";

            SqlConnection myConnection = new SqlConnection(ConnectionString);
            try
            {
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                Encontrado = myCommand.ExecuteReader();
                if (Encontrado.Read() == false)
                {
                    Bandera = -1;
                }
                else
                {
                    Bandera = 1;
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                MessageBox.Show(message);
                throw ex;
            }
            finally
            {
                if (myConnection.State == ConnectionState.Open)
                    myConnection.Close();
            }
            return Bandera;
        }

        public static TheVirtualTianguisProyect.Negocios.Datos.DatosCliente ObtenerDatos(System.String Nombre, System.String APaterno, System.String AMaterno)
        {
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "SELECT * FROM Clientes WHERE Nombre= '" + Nombre + "' And APaterno= '" + APaterno + "' And AMaterno= '" + AMaterno + "'";

            DataTable Dt = TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteQuery(ConnectionString, query, "Clientes");
            if (Dt.Rows.Count == 0)
            {
                return null;
            }

            return new TheVirtualTianguisProyect.Negocios.Datos.DatosCliente(Dt.Rows[0]);
        }

        public static void ActualizaDatosCliente(TheVirtualTianguisProyect.Negocios.Datos.DatosCliente DatosUsuario)
        {
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "update Clientes set RFC = " + "'" + DatosUsuario.RFC + "', Nombre = " + "'" + DatosUsuario.Nombre + "', APaterno = " + "'" + DatosUsuario.APaterno + "', AMaterno = " + "'" + DatosUsuario.AMaterno + "', Estado = " + "'" + DatosUsuario.Estado + "', Ciudad = " + "'" + DatosUsuario.Ciudad + "', Calle = " + "'" + DatosUsuario.Calle + "', NoExt = " + DatosUsuario.NoExt + ", NoInt = " + DatosUsuario.NoInt + ", Colonia = " + "'" + DatosUsuario.Colonia + "', CodigoPostal = " + DatosUsuario.CodigoPostal + ", ClienteActivo = " + DatosUsuario.ClienteActivo + "' where ID = " + DatosUsuario.ID;

            TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteNonQuery(ConnectionString, query);
        }

        public static TheVirtualTianguisProyect.Negocios.Datos.DatosCliente ObtenerDatosCompleto(System.String NombreCompleto)
        {
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "SELECT * FROM Clientes WHERE Nombre+' '+APaterno+' '+AMaterno = '" + NombreCompleto + "'";

            DataTable dt = TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteQuery(ConnectionString, query, "Pacientes");
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            return new TheVirtualTianguisProyect.Negocios.Datos.DatosCliente(dt.Rows[0]); ;
        }
    }
}
