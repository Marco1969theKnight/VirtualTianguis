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
    public partial class FormNuevaVenta : Form
    {
        TheVirtualTianguisProyect.Negocios.Datos.DatosVenta DatosVenta = new TheVirtualTianguisProyect.Negocios.Datos.DatosVenta();
        TheVirtualTianguisProyect.Negocios.Datos.DatosDetalleVenta DatosDetalleVenta = new TheVirtualTianguisProyect.Negocios.Datos.DatosDetalleVenta();

        public FormNuevaVenta()
        {
            InitializeComponent();
            DateTime now = DateTime.Now;
            Int32 id = TheVirtualTianguisProyect.Persistencia.AdministradorDatos.SiguienteID("Ventas", "NoVenta");
            Int32 idDetalle = TheVirtualTianguisProyect.Persistencia.AdministradorDatos.SiguienteID("DetalleVentas", "IdDetalleVenta");
            DatosVenta.NoVenta = id;
            DatosVenta.Fecha = now.ToShortTimeString();
            DatosVenta.Total = 0;
            DatosVenta.Empleado = TheVirtualTianguisProyect.Properties.Settings.Default.IDEmpleados;
            DatosVenta.Detalle = idDetalle;
            DatosVenta.VentaActiva = true;
            TheVirtualTianguisProyect.Negocios.Administradores.AdministradorDatosVenta.AltaVenta(DatosVenta);
            TheVirtualTianguisProyect.Properties.Settings.Default.NoVentaAct = id;
        }

        private void FormNuevaVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosTianguis1.Ventas' Puede moverla o quitarla según sea necesario.
            this.ventasTableAdapter.FillByProductosVenta(this.datosTianguis1.Ventas);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Salbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Canbutton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null)
            {
                return;
            }

            Int32 NoVenta = Int32.Parse(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());

            TheVirtualTianguisProyect.Negocios.Datos.DatosVenta DatosVenta = TheVirtualTianguisProyect.Negocios.Administradores.AdministradorDatosVenta.ObtenerDatosVenta(NoVenta);

            if (DatosVenta == null)
            {
                return;
            }

            if (MessageBox.Show("Seguro que deseas eliminar la venta ?", "Virtual Tianguis 2019", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                TheVirtualTianguisProyect.Negocios.Administradores.AdministradorDatosVenta.BajaVenta(DatosVenta);
            }
            else
            {
                return;
            }

            this.ventasTableAdapter.GetData();
            this.ventasTableAdapter.FillByProductosVenta(this.datosTianguis.Ventas);
        }

        private void Busbutton_Click(object sender, EventArgs e)
        {
            TheVirtualTianguisProyect.Formas.Vender.FormBuscarCliente Form = new TheVirtualTianguisProyect.Formas.Vender.FormBuscarCliente();
            Form.Show();
            textBox1.Text = TheVirtualTianguisProyect.Properties.Settings.Default.RFCCliente;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Agrbutton_Click(object sender, EventArgs e)
        {
            TheVirtualTianguisProyect.Formas.Vender.FormAgregarNuevoProducto Form = new TheVirtualTianguisProyect.Formas.Vender.FormAgregarNuevoProducto();
            Form.Show();
        }
    }
}
