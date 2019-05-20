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
        public FormOtros()
        {
            InitializeComponent();
        }

        private void FormOtros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosTianguis.Empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.FillByOtros(this.datosTianguis.Empleado);
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
    }
}
