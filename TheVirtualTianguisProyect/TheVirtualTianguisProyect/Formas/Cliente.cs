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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void ClearFields()
        {
            rfc.Text = String.Empty;
            nombre.Text = String.Empty;
            aPaterno.Text = String.Empty;
            aMaterno.Text = String.Empty;
            estado.Text = String.Empty;
            ciudad.Text = String.Empty;
            colonia.Text = String.Empty;
            calle.Text = String.Empty;
            NumExt.Value = 0;
            NumInt.Value = 0;
            CodPost.Value = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }

        private void crearCliente_Click(object sender, EventArgs e)
        {
            if (nombre.Text.Trim() == String.Empty)
            {
                MessageBox.Show("No has introducido el Nombre.", "Virtual Tianguis 2019", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nombre.Focus();
                return;
            }
            if (aPaterno.Text.Trim() == String.Empty)
            {
                MessageBox.Show("No has introducido el Apellido Paterno.", "Virtual Tianguis 2019", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                aPaterno.Focus();
                return;
            }
            if (rfc.Text.Trim() == String.Empty )
            {
                MessageBox.Show("No has introducido el RFC", "Virtual Tianguis 2019", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rfc.Focus();
                return;
            }

            TheVirtualTianguisProyect.Negocios.Datos.DatosCliente DatosCliente;

            DatosCliente = new TheVirtualTianguisProyect.Negocios.Datos.DatosCliente();

            DatosCliente.Nombre = nombre.Text;
            DatosCliente.APaterno = aPaterno.Text;
            DatosCliente.AMaterno = aMaterno.Text;
            DatosCliente.RFC = rfc.Text;
            DatosCliente.Estado = estado.Text;
            DatosCliente.Ciudad = ciudad.Text;
            DatosCliente.Colonia = colonia.Text;
            DatosCliente.Calle = calle.Text;
            DatosCliente.NoExt = Int32.Parse(NumExt.Value.ToString());
            DatosCliente.NoInt = Int32.Parse(NumInt.Value.ToString());
            DatosCliente.CodigoPostal = Int32.Parse(CodPost.Value.ToString());
            DatosCliente.ClienteActivo = true;

            TheVirtualTianguisProyect.Negocios.Administradores.AdministradorDatosCliente.AltaCliente(DatosCliente);

            MessageBox.Show("Cliente creado");

            ClearFields();
        }
    }
}
