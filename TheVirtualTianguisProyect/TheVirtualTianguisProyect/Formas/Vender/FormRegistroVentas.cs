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
    public partial class FormRegistroVentas : Form
    {
        public FormRegistroVentas()
        {
            InitializeComponent();
        }

        private void FormRegistroVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosTianguis.DetalleVentas' Puede moverla o quitarla según sea necesario.
            this.detalleVentasTableAdapter.Fill(this.datosTianguis.DetalleVentas);

        }
    }
}
