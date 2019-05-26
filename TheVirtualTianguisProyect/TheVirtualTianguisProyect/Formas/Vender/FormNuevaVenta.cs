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

        public FormNuevaVenta()
        {
            InitializeComponent();
        }

        private void FormNuevaVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosTianguis.DetalleVentas' Puede moverla o quitarla según sea necesario.
            this.detalleVentasTableAdapter.FillByNoVenta(this.datosTianguis.DetalleVentas, 1);
            // TODO: esta línea de código carga datos en la tabla 'datosTianguis.Ventas' Puede moverla o quitarla según sea necesario.
            this.ventasTableAdapter.FillByAtctivo(this.datosTianguis.Ventas);
            dataGridView2.AutoGenerateColumns = true;
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
            this.ventasTableAdapter.FillByAtctivo(this.datosTianguis.Ventas);
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

            numericUpDown1.Value = Decimal.Parse(this.detalleVentasTableAdapter.TotalVenta(TheVirtualTianguisProyect.Properties.Settings.Default.NoVentaAct).ToString());
        }

        private void NVenbutton_Click(object sender, EventArgs e)
        {
            TheVirtualTianguisProyect.Negocios.Datos.DatosVenta DatosVenta = new TheVirtualTianguisProyect.Negocios.Datos.DatosVenta();
            TheVirtualTianguisProyect.Negocios.Datos.DatosDetalleVenta DatosDetalleVenta = new TheVirtualTianguisProyect.Negocios.Datos.DatosDetalleVenta();
            Int32 id = TheVirtualTianguisProyect.Persistencia.AdministradorDatos.SiguienteID("Ventas", "NoVenta");
            Int32 idDetalle = TheVirtualTianguisProyect.Persistencia.AdministradorDatos.SiguienteID("DetalleVentas", "IdDetalleVenta");
            DatosVenta.NoVenta = id;
            DatosVenta.Fecha = dateTimePicker1.Value.ToShortDateString();
            DatosVenta.Total = 0;
            DatosVenta.Detalle = idDetalle;
            DatosVenta.Empleado = TheVirtualTianguisProyect.Properties.Settings.Default.IDEmpleados;
            DatosVenta.VentaActiva = true;
            TheVirtualTianguisProyect.Negocios.Administradores.AdministradorDatosVenta.AltaVenta(DatosVenta);
            TheVirtualTianguisProyect.Properties.Settings.Default.NoVentaAct = id;
            this.ventasTableAdapter.FillByAtctivo(this.datosTianguis.Ventas);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SelVbutton_Click(object sender, EventArgs e)
        {
            Int32 NoVenta = Int32.Parse(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
            TheVirtualTianguisProyect.Properties.Settings.Default.NoVentaAct = NoVenta;

            try
            {
                this.detalleVentasTableAdapter.FillByNoVenta(this.datosTianguis.DetalleVentas, TheVirtualTianguisProyect.Properties.Settings.Default.NoVentaAct);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            numericUpDown1.Value = Decimal.Parse(this.detalleVentasTableAdapter.TotalVenta(TheVirtualTianguisProyect.Properties.Settings.Default.NoVentaAct).ToString());
        }
    }
}
