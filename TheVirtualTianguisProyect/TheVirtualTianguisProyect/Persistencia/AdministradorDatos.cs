using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;

namespace TheVirtualTianguisProyect.Persistencia
{
    class AdministradorDatos
    {
        public static DataTable ExecuteQuery(string ConnectionString, string query, string tableName)
        {
            try
            {
                SqlConnection myConnection = new SqlConnection(ConnectionString);
                SqlDataAdapter myAdapter = new SqlDataAdapter(query, myConnection);
                DataSet ds = new DataSet();
                myAdapter.Fill(ds, tableName);
                ds.Tables[0].TableName = tableName;
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                MessageBox.Show(message);
                throw ex;
            }
        }

        public static void ExecuteNonQuery(string ConnectionString, string query)
        {
            SqlConnection myConnection = new SqlConnection(ConnectionString);
            try
            {
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                MessageBox.Show(message);
                //throw ex;
            }
            finally
            {
                if (myConnection.State == ConnectionState.Open)
                    myConnection.Close();
            }
        }

        public static int SiguienteID(string tableName, string idField)
        {
            int val;
            String ConnectionString = String.Format(TheVirtualTianguisProyect.Properties.Settings.Default.Conexion);
            SqlConnection myConnection = new SqlConnection(ConnectionString);

            string Query = "select max(" + idField + ") from " + tableName;
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand(Query, myConnection);

            object maxValue = myCommand.ExecuteScalar();
            myConnection.Close();
            if (maxValue == DBNull.Value) return 1;
            else
                val = int.Parse((maxValue).ToString());
            return val + 1;
        }
    }
}
