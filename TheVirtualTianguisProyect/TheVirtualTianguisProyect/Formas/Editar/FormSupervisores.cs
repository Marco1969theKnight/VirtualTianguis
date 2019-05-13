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
    public partial class FormSupervisores : Form
    {
        public FormSupervisores()
        {
            InitializeComponent();
        }

        private void FormSupervisores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosTianguis.Supervisor' Puede moverla o quitarla según sea necesario.
            this.supervisorTableAdapter.Fill(this.datosTianguis.Supervisor);

        }
    }
}
