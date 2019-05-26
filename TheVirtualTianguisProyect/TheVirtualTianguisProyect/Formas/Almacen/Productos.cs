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
        public Productos()
        {
            InitializeComponent();
        }


        private void ClearFields()
        {
            nombre.Text = String.Empty;
            marca.Text = String.Empty;
            categoria.Text = String.Empty;
            descripcion.Text = String.Empty;
            proveedor.Value = 0;
            precio.Value = 0;
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosTianguis.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.datosTianguis.Producto);

        }

        private void AgregarButton_Click(object sender, EventArgs e)
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
            if (precio.Value == 0)
            {
                MessageBox.Show("No has introducido el precio.", "Virtual Tianguis 2019", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                precio.Focus();
                return;
            }

            TheVirtualTianguisProyect.Negocios.Datos.DatosProducto DatosProductos = new TheVirtualTianguisProyect.Negocios.Datos.DatosProducto();


            DatosProductos.Nombre = nombre.Text;
            DatosProductos.Marca = marca.Text;
            DatosProductos.Precio = float.Parse(precio.Value.ToString());
            DatosProductos.Categoria = categoria.Text;
            DatosProductos.Descripcion = descripcion.Text;
            DatosProductos.Proveedor = Int32.Parse(proveedor.Value.ToString());
            DatosProductos.ProductoActivo = true;

            TheVirtualTianguisProyect.Negocios.Administradores.AdministradorDatosProducto.AltaProducto(DatosProductos);

            MessageBox.Show("Producto ingresado");

            ClearFields();
            this.productoTableAdapter.Fill(this.datosTianguis.Producto);
        }

        private void NombretextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
