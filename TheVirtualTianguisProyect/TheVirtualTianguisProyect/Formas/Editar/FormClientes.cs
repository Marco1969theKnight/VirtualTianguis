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
        public string pageAction;

        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosTianguis.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.datosTianguis.Clientes);

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

            RFCTextBox.ReadOnly = !edit;
            NomtextBox.ReadOnly = !edit;
            APattextBox.ReadOnly = !edit;
            AMattextBox.ReadOnly = !edit;
            EsttextBox.ReadOnly = !edit;
            CiutextBox.ReadOnly = !edit;
            ColtextBox.ReadOnly = !edit;
            CaltextBox.ReadOnly = !edit;
            NoExtnumeric.ReadOnly = !edit;
            NoIntnumeric.ReadOnly = !edit;
            CPosnumeric.ReadOnly = !edit;

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

            TheVirtualTianguisProyect.Negocios.Datos.DatosCliente DatosCliente = TheVirtualTianguisProyect.Negocios.Administradores.AdministradorDatosCliente.ObtenerDatosCliente(Id);
            if (DatosCliente == null)
            {
                MessageBox.Show("No se pueden obtener los datos del Cliente", "Virtual Tianguis 2019", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RFCTextBox.Text = DatosCliente.RFC;
            NomtextBox.Text = DatosCliente.Nombre;
            APattextBox.Text = DatosCliente.APaterno;
            AMattextBox.Text = DatosCliente.AMaterno;
            EsttextBox.Text = DatosCliente.Estado;
            CiutextBox.Text = DatosCliente.Ciudad;
            ColtextBox.Text = DatosCliente.Colonia;
            CaltextBox.Text = DatosCliente.Calle;
            NoExtnumeric.Value = DatosCliente.NoExt;
            NoIntnumeric.Value = DatosCliente.NoInt;
            CPosnumeric.Value = DatosCliente.CodigoPostal;
        }

        private void ClearFields()
        {
            RFCTextBox.Text = String.Empty;
            NomtextBox.Text = String.Empty;
            APattextBox.Text = String.Empty;
            AMattextBox.Text = String.Empty;
            EsttextBox.Text = String.Empty;
            CiutextBox.Text = String.Empty;
            ColtextBox.Text = String.Empty;
            CaltextBox.Text = String.Empty;
            NoExtnumeric.Value = 0;
            NoIntnumeric.Value = 0;
            CPosnumeric.Value = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            pageAction = "ADD";
            ClearFields();
            EstablecerEstadoEditable(true);
            NomtextBox.Focus();
        }

        private void ModifButton_Click(object sender, EventArgs e)
        {
            pageAction = "EDIT";
            CargaProveedorActual();
            NomtextBox.Focus();
            EstablecerEstadoEditable(true);
            NomtextBox.ReadOnly = true;
            APattextBox.ReadOnly = true;
            AMattextBox.ReadOnly = true;
        }

        private void ElmButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null)
            {
                return;
            }

            Int32 Id = Int32.Parse(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());

            TheVirtualTianguisProyect.Negocios.Datos.DatosCliente DatosCliente = TheVirtualTianguisProyect.Negocios.Administradores.AdministradorDatosCliente.ObtenerDatosCliente(Id);

            if (DatosCliente == null)
            {
                return;
            }
            if (MessageBox.Show("Seguro que deseas eliminar el registro ?", "Virtual Tianguis 2019", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                TheVirtualTianguisProyect.Negocios.Administradores.AdministradorDatosCliente.BajaCliente(DatosCliente);
            }
            else
            {
                return;
            }

            this.clientesTableAdapter.GetData();
            this.clientesTableAdapter.Fill(this.datosTianguis.Clientes);

            EstablecerEstadoEditable(false);

            ClearFields();

            CargaProveedorActual();
        }

        private void GuarButton_Click(object sender, EventArgs e)
        {
            if (NomtextBox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("No has introducido el Nombre.", "Virtual Tianguis 2019", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NomtextBox.Focus();
                return;
            }
            if (APattextBox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("No has introducido el Apellido Paterno.", "Virtual Tianguis 2019", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                APattextBox.Focus();
                return;
            }
            if (RFCTextBox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("No has introducido el RFC", "Virtual Tianguis 2019", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RFCTextBox.Focus();
                return;
            }

            TheVirtualTianguisProyect.Negocios.Datos.DatosCliente DatosCliente;
            Double Bandera;

            Bandera = TheVirtualTianguisProyect.Negocios.Administradores.AdministradorDatosCliente.VerificaClienteAlta(NomtextBox.Text, APattextBox.Text, AMattextBox.Text);

            if (Bandera == -1)
            {
                if (pageAction == "ADD")
                {
                    DatosCliente = new Negocios.Datos.DatosCliente();
                    Int32 id = TheVirtualTianguisProyect.Persistencia.AdministradorDatos.SiguienteID("Clientes", "ID");
                    DatosCliente.ID = id;
                }
                else
                {
                    if (pageAction != "EDIT")
                    {
                        MessageBox.Show("No hay CLIENTES dados de alta en el sistema", "Virtual Tianguis 2019", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        EstablecerEstadoEditable(false);
                        return;
                    }
                    else
                    {
                        DatosCliente = new Negocios.Datos.DatosCliente();
                    }
                }
            }
            else
            {
                DatosCliente = TheVirtualTianguisProyect.Negocios.Administradores.AdministradorDatosCliente.ObtenerDatos(NomtextBox.Text, APattextBox.Text, AMattextBox.Text);
            }

            DatosCliente.RFC = RFCTextBox.Text;
            DatosCliente.Nombre = NomtextBox.Text;
            DatosCliente.APaterno = APattextBox.Text;
            DatosCliente.AMaterno = AMattextBox.Text;
            DatosCliente.Estado = EsttextBox.Text;
            DatosCliente.Ciudad = CiutextBox.Text;
            DatosCliente.Colonia = ColtextBox.Text;
            DatosCliente.Calle = CaltextBox.Text;
            DatosCliente.NoExt = Int32.Parse(NoExtnumeric.Value.ToString());
            DatosCliente.NoInt = Int32.Parse(NoIntnumeric.Value.ToString());
            DatosCliente.CodigoPostal = Int32.Parse(CPosnumeric.Value.ToString());
            DatosCliente.ClienteActivo = true;

            if (Bandera == -1)
            {
                Int32 id = TheVirtualTianguisProyect.Persistencia.AdministradorDatos.SiguienteID("Clientes", "ID");
                DatosCliente.ID = id;
                TheVirtualTianguisProyect.Negocios.Administradores.AdministradorDatosCliente.AltaCliente(DatosCliente);
            }
            else
            {
                TheVirtualTianguisProyect.Negocios.Administradores.AdministradorDatosCliente.ActualizaDatosCliente(DatosCliente);
            }

            this.clientesTableAdapter.GetData();
            this.clientesTableAdapter.Fill(this.datosTianguis.Clientes);
            EstablecerEstadoEditable(false);
        }

        private void CanButton_Click(object sender, EventArgs e)
        {
            EstablecerEstadoEditable(false);
        }
    }
}
