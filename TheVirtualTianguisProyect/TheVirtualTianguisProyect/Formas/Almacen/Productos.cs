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
    public partial class Productos : Form
    {
        public string pageAction;
        public Productos()
        {
            InitializeComponent();
            EstablecerEstadoEditable(false);
        }


        private void ClearFields()
        {
            nombre.Text = String.Empty;
            marca.Text = String.Empty;
            categoria.Text = String.Empty;
            descripcion.Text = String.Empty;
            proveedor.Text = String.Empty;
            precio.Text = String.Empty;
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosTianguis.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.FillBy1(this.datosTianguis.Producto);
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            pageAction = "add";
            ClearFields();
            EstablecerEstadoEditable(true);
            nombre.Focus();
        }

        private void NombretextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EstablecerEstadoEditable(bool edit)
        {
            AgregarButton.Enabled = !edit;
            ModifButton.Enabled = !edit;
            ElmButton.Enabled = !edit;

            dgproductos.Enabled = !edit;

            CanButton.Enabled = edit;
            GuarButton.Enabled = edit;

            nombre.ReadOnly = !edit;
            marca.ReadOnly = !edit;
            descripcion.ReadOnly = !edit;
            proveedor.Enabled = edit;
            precio.Enabled = edit;
            categoria.ReadOnly = !edit;

        }
        private void CargaProveedorActual()
        {
            if (dgproductos.CurrentCell == null)  // Is there any row selected now?
            {
                ModifButton.Enabled = false;
                ElmButton.Enabled = false;
                return;
            }

            double Id = double.Parse(dgproductos[0, dgproductos.CurrentRow.Index].Value.ToString());

            TheVirtualTianguisProyect.Negocios.Datos.DatosProducto DatosUsuario = TheVirtualTianguisProyect.Negocios.Administradores.AdministradorDatosProducto.ObtenerDatosProducto(Id);
            if (DatosUsuario == null)
            {
                MessageBox.Show("No se pueden obtener los datos del Producto", "Virtual Tianguis 2019", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            nombre.Text = DatosUsuario.Nombre;
            descripcion.Text = DatosUsuario.Descripcion;
            marca.Text = DatosUsuario.Marca;
            categoria.Text = DatosUsuario.Categoria;
            precio.Text = DatosUsuario.Precio.ToString();
            proveedor.Text = DatosUsuario.Proveedor.ToString();
        }

        private void GuarButton_Click_1(object sender, EventArgs e)
        {
            if (nombre.Text.Trim() == String.Empty)
            {
                MessageBox.Show("No has introducido el Nombre.", "Virtual Tianguis 2019", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nombre.Focus();
                return;
            }
            if (marca.Text.Trim() == String.Empty)
            {
                MessageBox.Show("No has introducido la marca.", "Virtual Tianguis 2019", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                marca.Focus();
                return;
            }
            if (categoria.Text.Trim() == String.Empty)
            {
                MessageBox.Show("No has introducido la categoria,", "Virtual Tianguis 2019", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                categoria.Focus();
                return;
            }
            if (descripcion.Text.Trim() == String.Empty)
            {
                MessageBox.Show("No has introducido la descripcion.", "Virtual Tianguis 2019", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                descripcion.Focus();
                return;
            }
            if (float.Parse(precio.Text) == 0)
            {
                MessageBox.Show("No has introducido el precio.", "Virtual Tianguis 2019", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                precio.Focus();
                return;
            }

            TheVirtualTianguisProyect.Negocios.Datos.DatosProducto DatosProductos = new TheVirtualTianguisProyect.Negocios.Datos.DatosProducto();

            Double Bandera;

            Bandera = TheVirtualTianguisProyect.Negocios.Administradores.AdministradorDatosProducto.VerificaProductoAlta(nombre.Text);
            if (pageAction == "add")
            {
                if (Bandera == -1)
                {
                    DatosProductos.Nombre = nombre.Text;
                    DatosProductos.Marca = marca.Text;
                    DatosProductos.Precio = float.Parse(precio.Text);
                    DatosProductos.Categoria = categoria.Text;
                    DatosProductos.Descripcion = descripcion.Text;
                    DatosProductos.Proveedor = Int32.Parse(proveedor.Text);
                    DatosProductos.ProductoActivo = true;

                    TheVirtualTianguisProyect.Negocios.Administradores.AdministradorDatosProducto.AltaProducto(DatosProductos);

                    MessageBox.Show("Producto ingresado");
                }
                else
                {
                    MessageBox.Show("Ya Existe un Producto con los mismos DATOS");
                    //EstablecerEstadoEditable(false);
                    ClearFields();
                }

                this.productoTableAdapter.Fill(this.datosTianguis.Producto);
            }
            if (pageAction == "mod")
            {
                double Id = double.Parse(dgproductos[0, dgproductos.CurrentRow.Index].Value.ToString());
                DatosProductos.Id_producto = int.Parse(Id.ToString());
                DatosProductos.Nombre = nombre.Text.ToUpper();
                DatosProductos.Marca = marca.Text.ToUpper();
                DatosProductos.Precio = float.Parse(precio.Text);
                DatosProductos.Categoria = categoria.Text.ToUpper();
                DatosProductos.Descripcion = descripcion.Text.ToUpper();
                DatosProductos.Proveedor = int.Parse(proveedor.Text);
                DatosProductos.ProductoActivo = true;

                TheVirtualTianguisProyect.Negocios.Administradores.AdministradorDatosProducto.ActualizaDatosProducto(DatosProductos);
            }

            EstablecerEstadoEditable(false);
        }

        private void ElmButton_Click_1(object sender, EventArgs e)
        {

            if (dgproductos.CurrentCell == null)
            {
                return;
            }

            double Id = double.Parse(dgproductos[0, dgproductos.CurrentRow.Index].Value.ToString());

            TheVirtualTianguisProyect.Negocios.Datos.DatosProducto DatosUsuario = TheVirtualTianguisProyect.Negocios.Administradores.AdministradorDatosProducto.ObtenerDatosProducto(Id);

            if (DatosUsuario == null)
            {
                return;
            }

            if (MessageBox.Show("Seguro que deseas eliminar el registro ?", "Virtual Tianguis", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                TheVirtualTianguisProyect.Negocios.Administradores.AdministradorDatosProducto.BajaProducto(DatosUsuario);
            }
            else
            {
                return;
            }

            this.productoTableAdapter.GetData();
            this.productoTableAdapter.Fill(this.datosTianguis.Producto);

            EstablecerEstadoEditable(false);

            ClearFields();

            CargaProveedorActual();
        }

        private void ModifButton_Click_1(object sender, EventArgs e)
        {
            pageAction = "mod";
            CargaProveedorActual();
            nombre.Focus();
            EstablecerEstadoEditable(true);
        }

        private void CanButton_Click(object sender, EventArgs e)
        {
            EstablecerEstadoEditable(false);
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productoTableAdapter.FillBy1(this.datosTianguis.Producto);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void SalButton_Click(object sender, EventArgs e)
        {
            TheVirtualTianguisProyect.Properties.Settings.Default.CloseApplication = true;
            Application.Exit();

        }
    }
}