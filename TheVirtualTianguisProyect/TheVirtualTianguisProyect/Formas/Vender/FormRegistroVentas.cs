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
            // TODO: esta línea de código carga datos en la tabla 'datosTianguis1.Ventas' Puede moverla o quitarla según sea necesario.
            this.ventasTableAdapter.Fill(this.datosTianguis1.Ventas);
            // TODO: esta línea de código carga datos en la tabla 'datosTianguis.DetalleVentas' Puede moverla o quitarla según sea necesario.
            this.detalleVentasTableAdapter.FillByRNoVenta(this.datosTianguis.DetalleVentas);
            dataGridView1.AutoGenerateColumns = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.detalleVentasTableAdapter.FillBySNoVenta(this.datosTianguis.DetalleVentas, new System.Nullable<int>(((int)(System.Convert.ChangeType(noVentaToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.ventasTableAdapter.FillBy(this.datosTianguis.Ventas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
