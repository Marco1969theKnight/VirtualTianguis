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
    class AdministradorDatosEmpleado
    {
        public static Double VerificaEmpleado(System.String Usuario, System.String Contraseña)
        {
            int Bandera;
            SqlDataReader Encontrado;

            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "SELECT * FROM Empleado WHERE Nombre_usuario= '" + Usuario + "' And contraseña= '" + Contraseña + "' And Activo = 'true'";

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
                    DataTable Dt = TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteQuery(ConnectionString, query, "Empleado");
                    TheVirtualTianguisProyect.Properties.Settings.Default.IDEmpleados = Int32.Parse(Dt.Rows[0].ItemArray[0].ToString());
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

        public static TheVirtualTianguisProyect.Negocios.Datos.DatosEmpleado ObtenerDatosEmpleado(System.Int32 IDEmpleado)
        {
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "select * from Empleado where id_empleado = " + IDEmpleado;
            DataTable Dt = TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteQuery(ConnectionString, query, "Empleado");
            if (Dt.Rows.Count == 0)
            {
                return null;
            }

            return new TheVirtualTianguisProyect.Negocios.Datos.DatosEmpleado(Dt.Rows[0]);
        }

        public static String ObtenerUsuarioEmpleado(System.Int32 IDEmpleado)
        {
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "select Nombre_usuario from Empleado where id_empleado = " + IDEmpleado;
            DataTable Dt = TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteQuery(ConnectionString, query, "Empleado");
            if (Dt.Rows.Count == 0)
            {
                return null;
            }

            return Dt.Rows[0].ToString();
        }

        public static TheVirtualTianguisProyect.Negocios.Datos.DatosEmpleado ObtenerDatosEmpleado_Usuario(System.String Usuario, System.String Contraseña)
        {
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "select * from Empleado where ( ( Nombre_usuario = '" + Usuario + "' ) AND ( Contraseña = '" + Contraseña + "' ) )";
            DataTable Dt = TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteQuery(ConnectionString, query, "Empleado");
            if (Dt.Rows.Count == 0)
            {
                return null;
            }
            return new TheVirtualTianguisProyect.Negocios.Datos.DatosEmpleado(Dt.Rows[0]);
        }

        public static void BajaEmpleado(TheVirtualTianguisProyect.Negocios.Datos.DatosEmpleado DatosEmpleado)
        {
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "update Empleado set EmpleadoActivo = '" + false + "' where id_empleado = " + DatosEmpleado.id_empleado;

            TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteNonQuery(ConnectionString, query);
        }

        public static void AltaEmpleado(TheVirtualTianguisProyect.Negocios.Datos.DatosEmpleado DatosEmpleado)
        {
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "insert into Empleado( Nombre, APaterno, AMaterno, Nombre_usuario, Edad, Oficio, Editar, Almacen, Vender, Fecha_alta, Salario, Contraseña, EmpleadoActivo ) values ( " + "'" + DatosEmpleado.Nombre + "',  " + "'" + DatosEmpleado.APaterno + "', " + "'" + DatosEmpleado.AMaterno + "', " + "'" + DatosEmpleado.Nombre_usuario + "'," + DatosEmpleado.Edad + ", " + "'" + DatosEmpleado.Oficio + "', '" + DatosEmpleado.Editar + "', '" + DatosEmpleado.Almacen + "', '" + DatosEmpleado.Vender + "', " + "'" + DatosEmpleado.Fecha_alta + "', " + DatosEmpleado.Salario + ", " + "'" + DatosEmpleado.Contraseña + "', " + "'" + DatosEmpleado.EmpleadoActivo + "') ";

            TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteNonQuery(ConnectionString, query);
        }

        public static Double VerificaEmpleadoAlta(System.String Nombre, System.String APaterno, System.String AMaterno)
        {
            int Bandera;
            SqlDataReader Encontrado;
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "SELECT * FROM Empleado WHERE Nombre= '" + Nombre + "' And APaterno= '" + APaterno + "' And AMaterno= '" + AMaterno + "'";

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

        public static TheVirtualTianguisProyect.Negocios.Datos.DatosEmpleado ObtenerDatos(System.String Nombre, System.String APaterno, System.String AMaterno)
        {
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "SELECT * FROM Empleado WHERE Nombre= '" + Nombre + "' And APaterno= '" + APaterno + "' And AMaterno= '" + AMaterno + "'";

            DataTable Dt = TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteQuery(ConnectionString, query, "Empleado");
            if (Dt.Rows.Count == 0)
            {
                return null;
            }

            return new TheVirtualTianguisProyect.Negocios.Datos.DatosEmpleado(Dt.Rows[0]);
        }

        public static void ActualizaDatosEmpleado(TheVirtualTianguisProyect.Negocios.Datos.DatosEmpleado DatosEmpleado)
        {
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "update Empleado set Nombre = '" + DatosEmpleado.Nombre + "', APaterno = '" + DatosEmpleado.APaterno + "', AMaterno = '" + DatosEmpleado.AMaterno + "', Nombre_usuario = '" + DatosEmpleado.Nombre_usuario + "', Edad = " + DatosEmpleado.Edad + ", Oficio = '" + DatosEmpleado.Oficio + "', Fecha_alta = '" + DatosEmpleado.Fecha_alta + "', Salario = " + DatosEmpleado.Salario + ", Contraseña = '" + DatosEmpleado.Contraseña + "', EmpleadoActivo = '" + DatosEmpleado.EmpleadoActivo + "' where id_empleado = " + DatosEmpleado.id_empleado;

            TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteNonQuery(ConnectionString, query);
        }

        public static TheVirtualTianguisProyect.Negocios.Datos.DatosEmpleado ObtenerDatosCompleto(System.String NombreCompleto)
        {
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "SELECT * FROM Empleado WHERE Nombre+' '+APaterno+' '+AMaterno = '" + NombreCompleto + "'";

            DataTable dt = TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteQuery(ConnectionString, query, "Empleado");
            if (dt.Rows.Count == 0)
            {
                return null;
            }
                return new TheVirtualTianguisProyect.Negocios.Datos.DatosEmpleado(dt.Rows[0]); ;
        }
    }
}
