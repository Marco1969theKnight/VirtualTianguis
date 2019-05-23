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
    public partial class FormEmpleados : Form
    {
        public FormEmpleados()
        {
            InitializeComponent();
        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosTianguis.Empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.FillByEmpleados(this.datosTianguis.Empleado);

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

        private void SalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {

        }

        private void GuarButton_Click(object sender, EventArgs e)
        {

        }
    }
}
