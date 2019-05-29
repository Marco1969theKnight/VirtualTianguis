using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheVirtualTianguisProyect.Formas.Almacen
{
    public partial class NuevoProveedor : Form
    {
        public NuevoProveedor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosTianguis.Proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.datosTianguis.Proveedor);

        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void agregar_Click(object sender, EventArgs e)
        {
            if (nombre.Text.Trim() == String.Empty)
            {
                MessageBox.Show("No has introducido el Nombre.", "Virtual Tianguis 2019", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nombre.Focus();
                return;
            }

            TheVirtualTianguisProyect.Negocios.Datos.DatosProveedor DatosProveedor = new TheVirtualTianguisProyect.Negocios.Datos.DatosProveedor();

            Double Bandera;

            Bandera = TheVirtualTianguisProyect.Negocios.Administradores.AdministradorDatosProveedor.VerificaProveedorAlta(nombre.Text);
            if (Bandera == -1)
            {
                DatosProveedor.Nombre = nombre.Text;
                DatosProveedor.ProveedorActivo = true;

                TheVirtualTianguisProyect.Negocios.Administradores.AdministradorDatosProveedor.AltaProveedor(DatosProveedor);

                 MessageBox.Show("Proveedor ingresado");
            }
            else
            {
                MessageBox.Show("Ya Existe el Proveedor");
                //EstablecerEstadoEditable(false);
                //ClearFields();
            }

            this.proveedorTableAdapter.Fill(this.datosTianguis.Proveedor);
        }

        private void EstablecerEstadoEditable(bool edit)
        {
            nombre.ReadOnly = !edit;
            agregar.Enabled = !edit;
        }

    }
}
