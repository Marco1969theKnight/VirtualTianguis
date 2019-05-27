using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheVirtualTianguisProyect.Formas.Vender
{
    public partial class FormAgregarNuevoProducto : Form
    {
        public FormAgregarNuevoProducto()
        {
            InitializeComponent();
        }

        private void FormAgregarNuevoProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosTianguis.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.FillByAgregarProducto(this.datosTianguis.Producto);

        }

        private void fillByNombre2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productoTableAdapter.FillByNombre2(this.datosTianguis.Producto, nombreToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByMarcaToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productoTableAdapter.FillByMarca(this.datosTianguis.Producto, marcaToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByCategoriaToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productoTableAdapter.FillByCategoria(this.datosTianguis.Producto, categoriaToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null)  // Is there any row selected now?
            {
                return;
            }
            Int32 id_producto = Int32.Parse(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());

            TheVirtualTianguisProyect.Negocios.Datos.DatosInventario DatosInventario = new TheVirtualTianguisProyect.Negocios.Datos.DatosInventario();
            DatosInventario = TheVirtualTianguisProyect.Negocios.Administradores.AdministradorDatosInventario.ObtenerDatosInventario(id_producto);

            TheVirtualTianguisProyect.Negocios.Datos.DatosProducto DatosProducto = new TheVirtualTianguisProyect.Negocios.Datos.DatosProducto();

            DatosProducto = TheVirtualTianguisProyect.Negocios.Administradores.AdministradorDatosProducto.ObtenerDatosProducto(Double.Parse(id_producto.ToString()));

            TheVirtualTianguisProyect.Negocios.Datos.DatosDetalleVenta DatosDetalleVenta = new TheVirtualTianguisProyect.Negocios.Datos.DatosDetalleVenta();

            DatosDetalleVenta.IdDetalleVenta = TheVirtualTianguisProyect.Persistencia.AdministradorDatos.SiguienteID("DetalleVentas", "IdDetalleVenta");
            DatosDetalleVenta.NoVenta = TheVirtualTianguisProyect.Properties.Settings.Default.NoVentaAct;
            DatosDetalleVenta.Producto = DatosProducto.Id_producto;
            DatosDetalleVenta.Cantidad = Int32.Parse(numericUpDown1.Value.ToString());

            TheVirtualTianguisProyect.Negocios.Administradores.AdministradorDetalleVenta.AltaDetalleVenta(DatosDetalleVenta);

            Int32 Vendido = DatosInventario.NumeroExistencias - DatosDetalleVenta.Cantidad;

            TheVirtualTianguisProyect.Negocios.Administradores.AdministradorDatosInventario.ActualizaExistenciasInventario(id_producto, Vendido);

            this.Close();
        }
    }
}
