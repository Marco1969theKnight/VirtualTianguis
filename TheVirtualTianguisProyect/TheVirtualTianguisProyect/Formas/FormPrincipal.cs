using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheVirtualTianguisProyect.Formas
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void cerrarEsiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void venderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void almacénToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TheVirtualTianguisProyect.Properties.Settings.Default.CloseApplication = true;
            Application.Exit();
        }

        private void gerenteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TheVirtualTianguisProyect.Formas.Editar.FormGerentes Forma = new TheVirtualTianguisProyect.Formas.Editar.FormGerentes();
            Forma.MdiParent = this;
            Forma.Show();
        }

        private void supervisorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TheVirtualTianguisProyect.Formas.Editar.FormSupervisores Forma = new TheVirtualTianguisProyect.Formas.Editar.FormSupervisores();
            Forma.MdiParent = this;
            Forma.Show();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TheVirtualTianguisProyect.Formas.Editar.FormEmpleados Forma = new TheVirtualTianguisProyect.Formas.Editar.FormEmpleados();
            Forma.MdiParent = this;
            Forma.Show();
        }

        private void otrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TheVirtualTianguisProyect.Formas.Editar.FormOtros Forma = new TheVirtualTianguisProyect.Formas.Editar.FormOtros();
            Forma.MdiParent = this;
            Forma.Show();
        }
    }
}
