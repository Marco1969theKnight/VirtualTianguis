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
            // TODO: esta línea de código carga datos en la tabla 'datosTianguis.Ventas' Puede moverla o quitarla según sea necesario.
            this.ventasTableAdapter.Fill(this.datosTianguis.Ventas);
            dgVentas.AutoGenerateColumns = true;
        }

        private void CargaVentaSeleccionada()
        {
            /*if (dgVentas.CurrentCell == null)  // Is there any row selected now?
            {
                ModifButton.Enabled = false;
                ElmButton.Enabled = false;
                return;
            }*/
        

            double Id = double.Parse(dgVentas[0, dgVentas.CurrentRow.Index].Value.ToString());

            TheVirtualTianguisProyect.Negocios.Datos.DatosVenta DatosVentas = TheVirtualTianguisProyect.Negocios.Administradores.AdministradorDatosVenta.ObtenerDatosVenta(Id);
            if (DatosVentas == null)
            {
                MessageBox.Show("No se pueden obtener los datos del Producto", "Virtual Tianguis 2019", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            /*nombre.Text = DatosUsuario.Nombre;
            descripcion.Text = DatosUsuario.Descripcion;
            marca.Text = DatosUsuario.Marca;
            categoria.Text = DatosUsuario.Categoria;
            precio.Text = DatosUsuario.Precio.ToString();*/
            TheVirtualTianguisProyect.Formas.Vender.FormDetalleVenta formdv = new TheVirtualTianguisProyect.Formas.Vender.FormDetalleVenta(Id);
            formdv.Show();
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
           // TheVirtualTianguisProyect.Formas.Vender.FormDetalleVenta dv = new TheVirtualTianguisProyect.Formas.Vender.FormDetalleVenta(Id);
            CargaVentaSeleccionada();
            
        }
    }
}
