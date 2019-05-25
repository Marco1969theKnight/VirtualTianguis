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
    public partial class FormBuscarCliente : Form
    {
        public FormBuscarCliente()
        {
            InitializeComponent();
        }

        private void FormBuscarCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosTianguis.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.datosTianguis.Clientes);

        }

        private void fillByRFCToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clientesTableAdapter.FillByRFC(this.datosTianguis.Clientes, rFCToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByNombre1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clientesTableAdapter.FillByNombre1(this.datosTianguis.Clientes, nombreToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void nombreToolStripTextBox_Click(object sender, EventArgs e)
        {

        }

        private void fillByNombre1ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fillByAPaterno1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clientesTableAdapter.FillByAPaterno1(this.datosTianguis.Clientes, aPaternoToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByAMaterno1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clientesTableAdapter.FillByAMaterno1(this.datosTianguis.Clientes, aMaternoToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByCodigoPostalToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clientesTableAdapter.FillByCodigoPostal(this.datosTianguis.Clientes, new System.Nullable<int>(((int)(System.Convert.ChangeType(codigoPostalToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByEstadoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clientesTableAdapter.FillByEstado(this.datosTianguis.Clientes, estadoToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByColoniaToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clientesTableAdapter.FillByColonia(this.datosTianguis.Clientes, coloniaToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByCiudadToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clientesTableAdapter.FillByCiudad(this.datosTianguis.Clientes, ciudadToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void ciudadToolStripLabel_Click(object sender, EventArgs e)
        {

        }

        private void fillByCalleToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clientesTableAdapter.FillByCalle(this.datosTianguis.Clientes, calleToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByNoExtToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clientesTableAdapter.FillByNoExt(this.datosTianguis.Clientes, new System.Nullable<int>(((int)(System.Convert.ChangeType(noExtToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByNoIntToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clientesTableAdapter.FillByNoInt(this.datosTianguis.Clientes, new System.Nullable<int>(((int)(System.Convert.ChangeType(noIntToolStripTextBox.Text, typeof(int))))));
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
            String RFC = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();

            TheVirtualTianguisProyect.Properties.Settings.Default.RFCCliente = RFC;

            this.Close();
        }
    }
}
