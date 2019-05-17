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
        public static Double VerificaEmpleado(System.String Usuario, System.String Contraseña, String TablaEmpleado)
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
                    DataTable Dt = TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteQuery(ConnectionString, query, TablaEmpleado);
                    if(TablaEmpleado == "Otros")
                        TheVirtualTianguisProyect.Properties.Settings.Default.IDOtros = Int32.Parse(Dt.Rows[0].ItemArray[0].ToString());
                    else if (TablaEmpleado == "Empleado")
                        TheVirtualTianguisProyect.Properties.Settings.Default.IDEmpleados = Int32.Parse(Dt.Rows[0].ItemArray[0].ToString());
                    else if (TablaEmpleado == "Supervisiores")
                        TheVirtualTianguisProyect.Properties.Settings.Default.IDSupervisores = Int32.Parse(Dt.Rows[0].ItemArray[0].ToString());
                    else
                        TheVirtualTianguisProyect.Properties.Settings.Default.IDGerentes = Int32.Parse(Dt.Rows[0].ItemArray[0].ToString());
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

        public static TheVirtualTianguisProyect.Negocios.Datos.DatosEmpleado ObtenerDatosEmpleado(System.Int32 IDEmpleado, String TablaEmpleado)
        {
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "select * from Empleado where id_empleado = " + IDEmpleado;
            DataTable Dt = TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteQuery(ConnectionString, query, TablaEmpleado);
            if (Dt.Rows.Count == 0)
            {
                return null;
            }

            return new TheVirtualTianguisProyect.Negocios.Datos.DatosEmpleado(Dt.Rows[0]);
        }

        public static void BajaEmpleado(TheVirtualTianguisProyect.Negocios.Datos.DatosEmpleado DatosEmpleado)
        {
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "update Empleado set Activo = '" + false + "' where id_empleado = " + DatosEmpleado.id_empleado;

            TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteNonQuery(ConnectionString, query);
        }

        public static void AltaEmpleado(TheVirtualTianguisProyect.Negocios.Datos.DatosEmpleado DatosEmpleado)
        {
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "insert into Empleado( id_empleado, Nombre, APaterno, AMaterno, Nombre_usuario, Edad, Oficio, Editar, Almacen, Vender, Fecha_alta, Salario, Contraseña, EmpleadoActivo ) values ( " + DatosEmpleado.id_empleado + ", " + "'" + DatosEmpleado.Nombre + "',  " + "'" + DatosEmpleado.APaterno + "', " + "'" + DatosEmpleado.AMaterno + "', " + "'" + DatosEmpleado.Nombre_usuario + "'," + DatosEmpleado.Edad + ", " + "'" + DatosEmpleado.Oficio + "', " + DatosEmpleado.Editar + ", " + DatosEmpleado.Almacen + ", " + DatosEmpleado.Vender + ", " + "'" + DatosEmpleado.Fecha_alta + "', " + DatosEmpleado.Salario + ", " + "'" + DatosEmpleado.Contraseña + "', " + "'" + DatosEmpleado.EmpleadoActivo + "') ";

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

        public static TheVirtualTianguisProyect.Negocios.Datos.DatosEmpleado ObtenerDatos(System.String Nombre, System.String APaterno, System.String AMaterno, String TablaEmpleado)
        {
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            String query = "SELECT * FROM Empleado WHERE Nombre= '" + Nombre + "' And APaterno= '" + APaterno + "' And AMaterno= '" + AMaterno + "'";

            DataTable Dt = TheVirtualTianguisProyect.Persistencia.AdministradorDatos.ExecuteQuery(ConnectionString, query, TablaEmpleado);
            if (Dt.Rows.Count == 0)
            {
                return null;
            }

            return new TheVirtualTianguisProyect.Negocios.Datos.DatosUsuario(Dt.Rows[0]);
        }

        public static void ActualizaDatosUsuario(DigitalDent.Negocios.Datos.DatosUsuario DatosUsuario)
        {
            String ConnectionString = String.Format(DigitalDent.Properties.Settings.Default.ConexionDB);
            String query = "update Usuarios set IDUsuario = " + DatosUsuario.IDUsuario + ", IDTipoUsuario = " + DatosUsuario.IDTipoUsuario + ", APaterno = '" + DatosUsuario.APaterno + "', AMaterno = '" + DatosUsuario.AMaterno + "', Direccion = '" + DatosUsuario.Direccion + "', Telefono = '" + DatosUsuario.Telefono + "', Ciudad = '" + DatosUsuario.Ciudad + "', Estado = '" + DatosUsuario.Estado + "', Usuario = '" + DatosUsuario.Usuario + "', Contraseña = '" + DatosUsuario.Contraseña + "', Activo = '" + DatosUsuario.Activo + "' where IDUsuario = " + DatosUsuario.IDUsuario;

            DigitalDent.Persistencia.AdministradorDatos.ExecuteNonQuery(ConnectionString, query);
        }

        public static DigitalDent.Negocios.Datos.DatosUsuario ObtenerDatosCompleto(System.String NombreCompleto)
        {
            String ConnectionString = String.Format(DigitalDent.Properties.Settings.Default.ConexionDB);
            String query = "SELECT * FROM Usuarios WHERE Nombre+' '+APaterno+' '+AMaterno = '" + NombreCompleto + "'";

            DataTable dt = DigitalDent.Persistencia.AdministradorDatos.ExecuteQuery(ConnectionString, query, "Usuarios");
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            return new DigitalDent.Negocios.Datos.DatosUsuario(dt.Rows[0]); ;
        }

        public static DigitalDent.Negocios.Datos.DatosUsuario VerificaMedico(System.String Nombre)
        {
            String ConnectionString = String.Format(DigitalDent.Properties.Settings.Default.ConexionDB);
            String query = "select * from Empleados where Nombre + ' ' + APaterno + ' ' + AMaterno = '" + Nombre + "'";

            DataTable Dt = DigitalDent.Persistencia.AdministradorDatos.ExecuteQuery(ConnectionString, query, "Usuarios");
            if (Dt.Rows.Count == 0)
            {
                return null;
            }

            return new DigitalDent.Negocios.Datos.DatosUsuario(Dt.Rows[0]);
        }
    }
