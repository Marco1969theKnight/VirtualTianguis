using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;

namespace TheVirtualTianguisProyect
{
    public partial class VirtualTianguis : Form
    {
        CNegocios_Login.Class1 objn = new CNegocios_Login.Class1();
        CEntidades_Login.Class1 obje = new CEntidades_Login.Class1();



        public VirtualTianguis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TheVirtualTianguisProyect.Formas.Cliente Forma = new TheVirtualTianguisProyect.Formas.Cliente();
            Forma.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /* logins();
             NomUsuTB.Text = String.Empty;
             ConTB.Text = String.Empty;
             NomUsuTB.Focus();*/

            DataTable dt = new DataTable();
            obje.usuario1 = NomUsuTB .Text;
            obje.password1 = ConTB.Text;
            dt = objn.N_Login(obje);

            if(dt.Rows.Count > 0)
            {
                obje.usuario1 = dt.Rows[0][0].ToString();
                obje.password1 = dt.Rows[0][0].ToString();
                MessageBox.Show("Bienvenido" + obje.usuario1);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void VirtualTianguis_Load(object sender, EventArgs e)
        {

        }

        private void ConTB_TextChanged(object sender, EventArgs e)
        {

        }

        /* public void logins()
         {
             try
             {
                 //string cnn = ConfigurationManager.ConnectionStrings["TheVirtualTianguisProyect.Properties.Settings.Conexion"].ConnectionString;
                 string cnn = ConfigurationManager.ConnectionStrings["TheVirtualTianguisProyect.Properties.Settings.Conexion"].ConnectionString;
                 using (SqlConnection conexion = new SqlConnection(cnn))
                 {
                     conexion.Open();
                     using (SqlCommand cmd = new SqlCommand("SELECT Nombre_usuario, Contraseña, Editar, Almacen, Vender FROM Empleado WHERE Nombre_usuario ='" + NomUsuTB.Text + "'AND Contraseña='" + ConTB.Text + "'", conexion))
                     {
                         SqlDataReader dr = cmd.ExecuteReader();

                         if (dr.Read())
                         {
                             Boolean Editar = dr.GetBoolean(2);
                             Boolean Almacen = dr.GetBoolean(3);
                             Boolean Vender = dr.GetBoolean(4);


                             {
                                 if (!Editar && Vender && !Almacen)
                                 {
                                     MessageBox.Show("Login Vendedor");
                                     TheVirtualTianguisProyect.Formas.FormPrincipal FormaP = new TheVirtualTianguisProyect.Formas.FormPrincipal();
                                     FormaP.ShowDialog();
                                 }


                                 else if (Almacen && Vender && !Editar)
                                 {
                                     MessageBox.Show("Login Supervisor");

                                     TheVirtualTianguisProyect.Formas.FormPrincipal FormaP = new TheVirtualTianguisProyect.Formas.FormPrincipal();
                                     FormaP.ShowDialog();
                                 }


                                 else if (Editar && Vender && Almacen)
                                 {
                                     MessageBox.Show("Login Gerente");

                                     TheVirtualTianguisProyect.Formas.FormPrincipal FormaP = new TheVirtualTianguisProyect.Formas.FormPrincipal();
                                     FormaP.ShowDialog();

                                 }


                                 else if (!(Editar && !Vender && !Almacen))
                                 {
                                     MessageBox.Show("Login Otros");
                                     TheVirtualTianguisProyect.Formas.FormPrincipal FormaP = new TheVirtualTianguisProyect.Formas.FormPrincipal();
                                     FormaP.ShowDialog();
                                 }

                             }
                         }
                         else
                         {
                             MessageBox.Show("Datos incorrectos");
                         }

                     }
                 }

             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.ToString());
             }
         }*/


    }
}
