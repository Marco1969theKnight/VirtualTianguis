using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheVirtualTianguisProyect
{
    public partial class VirtualTianguis : Form
    {
        public VirtualTianguis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TheVirtualTianguisProyect.Formas.Cliente Forma = new TheVirtualTianguisProyect.Formas.Cliente();
            Forma.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
