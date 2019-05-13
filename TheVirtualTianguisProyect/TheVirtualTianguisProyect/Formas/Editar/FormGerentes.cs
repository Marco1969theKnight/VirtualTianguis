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
    public partial class FormGerentes : Form
    {
        public FormGerentes()
        {
            InitializeComponent();
        }

        private void conTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormGerentes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosTianguis.Gerente' Puede moverla o quitarla según sea necesario.
            this.gerenteTableAdapter.Fill(this.datosTianguis.Gerente);

        }
    }
}
