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
    public partial class FormDetalleVenta : Form
    {
        int NoVenta;
        public FormDetalleVenta(double venta)
        {
            InitializeComponent();
            NoVenta = (int)venta;
        }

        private void FormDetalleVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosTianguis1.DetalleVentas' Puede moverla o quitarla según sea necesario.
            this.detalleVentasTableAdapter.FillByNoVenta(this.datosTianguis1.DetalleVentas,NoVenta);
            

            dgDetalleVenta.AutoGenerateColumns = true;
        }
    }
}
