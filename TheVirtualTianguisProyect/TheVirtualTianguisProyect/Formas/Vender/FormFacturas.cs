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
    public partial class FormFacturas : Form
    {
        public FormFacturas()
        {
            InitializeComponent();
        }

        private void FormFacturas_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosTianguis.Factura' Puede moverla o quitarla según sea necesario.
            this.facturaTableAdapter.Fill(this.datosTianguis.Factura);
            TheVirtualTianguisProyect.Negocios.Datos.DatosFactura DatosFactura = TheVirtualTianguisProyect.Negocios.Administradores.AdministradorDatosFactura.ObtenerDatosFactura(TheVirtualTianguisProyect.Properties.Settings.Default.IDFacturaAct);

            // TODO: esta línea de código carga datos en la tabla 'datosTianguis.DetalleVentas' Puede moverla o quitarla según sea necesario.
            this.detalleVentasTableAdapter.FillByNoVenta(this.datosTianguis.DetalleVentas, DatosFactura.NoVenta);
            // TODO: esta línea de código carga datos en la tabla 'datosTianguis.Factura' Puede moverla o quitarla según sea necesario.
            this.facturaTableAdapter.FillByNoVentaFactura(this.datosTianguis.Factura, DatosFactura.ID);

            this.reportViewer2.RefreshReport();
        }
    }
}
