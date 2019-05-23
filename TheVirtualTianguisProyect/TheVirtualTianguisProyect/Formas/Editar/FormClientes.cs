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
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {

        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosTianguis.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.datosTianguis.Clientes);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
