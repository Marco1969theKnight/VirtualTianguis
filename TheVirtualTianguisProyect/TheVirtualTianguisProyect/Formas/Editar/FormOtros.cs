using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheVirtualTianguisProyect.Formas.Editar
{
    public partial class FormOtros : Form
    {
        public string pageAction;

        public FormOtros()
        {
            InitializeComponent();
        }

        private void FormOtros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosTianguis.Empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.FillByOtros(this.datosTianguis.Empleado);
            this.WindowState = FormWindowState.Maximized;
            this.ShowIcon = true;
        }

        private void EstablecerEstadoEditable(bool edit)
        {
            AgregarButton.Enabled = !edit;
            ModifButton.Enabled = !edit;
            ElmButton.Enabled = !edit;
            SalButton.Enabled = !edit;

            dataGridView1.Enabled = !edit;

            CanButton.Enabled = edit;
            GuarButton.Enabled = edit;

            nomtTextBox.ReadOnly = !edit;
            aPatTextBox2.ReadOnly = !edit;
            aMatTextBox1.ReadOnly = !edit;
            usuTextBox1.ReadOnly = !edit;
            edadNumeric.ReadOnly = !edit;
            ofiTextBox.ReadOnly = !edit;
            fechAltDateTime.Enabled = edit;
            salNumeric.ReadOnly = !edit;
            conTextBox.ReadOnly = !edit;

        }
        private void CargaProveedorActual()
        {
            if (dataGridView1.CurrentCell == null)  // Is there any row selected now?
            {
                ModifButton.Enabled = false;
                ElmButton.Enabled = false;
                return;
            }

            Int32 Id = Int32.Parse(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());

            TheVirtualTianguisProyect.Negocios.Datos.DatosEmpleado DatosEmpleado = TheVirtualTianguisProyect.Negocios.Administradores.AdministradorDatosEmpleado.ObtenerDatosEmpleado(Id);
            if (DatosEmpleado == null)
            {
                MessageBox.Show("No se pueden obtener los datos del Usuario", "DigitalDent 2013", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtNombre.Text = DatosUsuario.Nombre;
            txtAPaterno.Text = DatosUsuario.APaterno;
            txtAMaterno.Text = DatosUsuario.AMaterno;
            txtCiudad.Text = DatosUsuario.Ciudad;
            txtDireccion.Text = DatosUsuario.Direccion;
            mskTelefono.Text = DatosUsuario.Telefono;
            txtEstado.Text = DatosUsuario.Estado;
        }

        private void ClearFields()
        {
            txtNombre.Text = String.Empty;
            txtAMaterno.Text = String.Empty;
            txtAPaterno.Text = String.Empty;
            txtDireccion.Text = String.Empty;
            txtCiudad.Text = String.Empty;
            txtEstado.Text = String.Empty;
            mskTelefono.Text = String.Empty;
            txtUsuario.Text = String.Empty;
            txtContraseña.Text = String.Empty;
        }
        private void fechAltDateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void salNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ofiTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void edadNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void usuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void conTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void aPatTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nomtTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void aMatTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fillByOtrosToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.empleadoTableAdapter.FillByOtros(this.datosTianguis.Empleado);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByEmpleadosToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.empleadoTableAdapter.FillByEmpleados(this.datosTianguis.Empleado);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByEmpleadosToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.empleadoTableAdapter.FillByEmpleados(this.datosTianguis.Empleado);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByEmpleadosToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.empleadoTableAdapter.FillByEmpleados(this.datosTianguis.Empleado);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.empleadoTableAdapter.Fill(this.datosTianguis.Empleado);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByOtrosToolStripButton_Click_1(object sender, EventArgs e)
        {
           
        }

        private void SalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
