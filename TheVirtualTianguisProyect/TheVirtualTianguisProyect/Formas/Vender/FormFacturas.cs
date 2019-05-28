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
    public partial class FormFacturas : Form
    {
        public FormFacturas()
        {
            InitializeComponent();
        }

        private void FormFacturas_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void FormFacturas_Load_1(object sender, EventArgs e)
        {

            this.reportViewer2.RefreshReport();
        }
    }
}
