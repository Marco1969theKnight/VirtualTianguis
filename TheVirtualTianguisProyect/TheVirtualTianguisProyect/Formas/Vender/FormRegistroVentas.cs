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
            dataGridView1.AutoGenerateColumns = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
<<<<<<< HEAD
=======


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
>>>>>>> ebf0494c5d84aba24b75cc63e4b4e55bf76f68f0
    }
}
