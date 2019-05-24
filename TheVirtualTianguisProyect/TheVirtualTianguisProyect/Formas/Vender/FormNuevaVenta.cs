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
        }

        private void FormNuevaVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosTianguis1.Ventas' Puede moverla o quitarla según sea necesario.
            this.ventasTableAdapter.FillByProductosVenta(this.datosTianguis1.Ventas);
            DateTime now = DateTime.Now;
            Int32 id = TheVirtualTianguisProyect.Persistencia.AdministradorDatos.SiguienteID("Ventas", "NoVenta");
            Int32 idDetalle = TheVirtualTianguisProyect.Persistencia.AdministradorDatos.SiguienteID("DetalleVentas", "IdDetalleVenta");
            DatosVenta.NoVenta = id;
            DatosVenta.Fecha = now.ToShortTimeString();
            DatosVenta.Total = 0;
            DatosVenta.Empleado = TheVirtualTianguisProyect.Properties.Settings.Default.IDEmpleados;
            DatosVenta.Detalle = idDetalle;
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
    }
}
