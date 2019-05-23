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
        public string pageAction;

        public FormEmpleados()
        {
            InitializeComponent();
        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosTianguis.Empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.FillByEmpleados(this.datosTianguis.Empleado);

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

            nomtTextBox.ReadOnly = !edit;
            aPatTextBox2.ReadOnly = !edit;
            aMatTextBox1.ReadOnly = !edit;
            usuTextBox1.ReadOnly = !edit;
            edadNumeric.ReadOnly = !edit;
            ofiTextBox.ReadOnly = !edit;
            fechAltDateTime.Enabled = edit;
            salNumeric.ReadOnly = !edit;
            conTextBox.ReadOnly = !edit;

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

            TheVirtualTianguisProyect.Negocios.Datos.DatosEmpleado DatosEmpleado = TheVirtualTianguisProyect.Negocios.Administradores.AdministradorDatosEmpleado.ObtenerDatosEmpleado(Id);
            if (DatosEmpleado == null)
            {
                MessageBox.Show("No se pueden obtener los datos del Empleado", "Virtual Tianguis 2019", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            nomtTextBox.Text = DatosEmpleado.Nombre;
            aPatTextBox2.Text = DatosEmpleado.APaterno;
            aMatTextBox1.Text = DatosEmpleado.AMaterno;
            usuTextBox1.Text = DatosEmpleado.Nombre_usuario;
            edadNumeric.Value = DatosEmpleado.Edad;
            ofiTextBox.Text = DatosEmpleado.Oficio;
            fechAltDateTime.Text = DatosEmpleado.Fecha_alta;
            salNumeric.Value = DatosEmpleado.Salario;
            conTextBox.Text = DatosEmpleado.Contraseña;
        }

        private void ClearFields()
        {
            nomtTextBox.Text = String.Empty;
            aPatTextBox2.Text = String.Empty;
            aMatTextBox1.Text = String.Empty;
            usuTextBox1.Text = String.Empty;
            edadNumeric.Value = 0;
            ofiTextBox.Text = String.Empty;
            fechAltDateTime.Text = String.Empty;
            salNumeric.Value = 0;
            conTextBox.Text = String.Empty;
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
            nomtTextBox.Focus();
        }

        private void GuarButton_Click(object sender, EventArgs e)
        {
            if (nomtTextBox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("No has introducido el Nombre.", "Virtual Tianguis 2019", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nomtTextBox.Focus();
                return;
            }
            if (aPatTextBox2.Text.Trim() == String.Empty)
            {
                MessageBox.Show("No has introducido el Apellido Paterno.", "Virtual Tianguis 2019", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                aPatTextBox2.Focus();
                return;
            }
            if (usuTextBox1.Text.Trim() == String.Empty || conTextBox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("No has introducido el Usuario y/0 Contraseña", "Virtual Tianguis 2019", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                aPatTextBox2.Focus();
                return;
            }

            TheVirtualTianguisProyect.Negocios.Datos.DatosEmpleado DatosEmpleado;
            Double Bandera;

            Bandera = TheVirtualTianguisProyect.Negocios.Administradores.AdministradorDatosEmpleado.VerificaEmpleadoAlta(nomtTextBox.Text, aPatTextBox2.Text, aMatTextBox1.Text);

            if (Bandera == -1)
            {
                if (pageAction == "ADD")
                {
                    DatosEmpleado = new Negocios.Datos.DatosEmpleado();
                    Int32 id = TheVirtualTianguisProyect.Persistencia.AdministradorDatos.SiguienteID("Empleado", "id_empleado");
                    DatosEmpleado.id_empleado = id;
                }
                else
                {
                    if (pageAction != "EDIT")
                    {
                        MessageBox.Show("No hay EMPLEADOS_Empleados dados de alta en el sistema", "Virtual Tianguis 2019", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        EstablecerEstadoEditable(false);
                        return;
                    }
                    else
                    {
                        DatosEmpleado = new Negocios.Datos.DatosEmpleado();
                    }
                }
            }
            else
            {
                DatosEmpleado = TheVirtualTianguisProyect.Negocios.Administradores.AdministradorDatosEmpleado.ObtenerDatos(nomtTextBox.Text, aPatTextBox2.Text, aMatTextBox1.Text);
            }

            DatosEmpleado.Nombre = nomtTextBox.Text;
            DatosEmpleado.APaterno = aPatTextBox2.Text;
            DatosEmpleado.AMaterno = aMatTextBox1.Text;
            DatosEmpleado.Nombre_usuario = usuTextBox1.Text;
            DatosEmpleado.Edad = Int32.Parse(edadNumeric.Value.ToString());
            DatosEmpleado.Oficio = ofiTextBox.Text;
            DatosEmpleado.Editar = false;
            DatosEmpleado.Almacen = false;
            DatosEmpleado.Vender = true;
            DatosEmpleado.Fecha_alta = fechAltDateTime.Value.ToShortDateString();
            DatosEmpleado.Salario = Int32.Parse(salNumeric.Value.ToString());
            DatosEmpleado.Contraseña = conTextBox.Text;
            DatosEmpleado.EmpleadoActivo = true;

            if (Bandera == -1)
            {
                Int32 id = TheVirtualTianguisProyect.Persistencia.AdministradorDatos.SiguienteID("Empleado", "id_empleado");
                DatosEmpleado.id_empleado = id;
                TheVirtualTianguisProyect.Negocios.Administradores.AdministradorDatosEmpleado.AltaEmpleado(DatosEmpleado);
            }
            else
            {
                if (DatosEmpleado.id_empleado == 1)
                {
                    MessageBox.Show("No se puede Modificar al Empleado ya que es el Administrador del Sistema", "DigitalDent 2013", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    EstablecerEstadoEditable(false);
                    return;
                }
                else
                {
                    TheVirtualTianguisProyect.Negocios.Administradores.AdministradorDatosEmpleado.ActualizaDatosEmpleado(DatosEmpleado);
                }
            }

            this.empleadoTableAdapter.GetData();
            this.empleadoTableAdapter.FillByEmpleados(this.datosTianguis.Empleado);
            EstablecerEstadoEditable(false);
        }

        private void ModifButton_Click(object sender, EventArgs e)
        {
            pageAction = "EDIT";
            CargaProveedorActual();
            nomtTextBox.Focus();
            EstablecerEstadoEditable(true);
            nomtTextBox.ReadOnly = true;
            aPatTextBox2.ReadOnly = true;
            aMatTextBox1.ReadOnly = true;
        }

        private void ElmButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null)
            {
                return;
            }

            Int32 Id = Int32.Parse(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());

            TheVirtualTianguisProyect.Negocios.Datos.DatosEmpleado DatosEmpleado = TheVirtualTianguisProyect.Negocios.Administradores.AdministradorDatosEmpleado.ObtenerDatosEmpleado(Id);

            if (DatosEmpleado == null)
            {
                return;
            }

            if (Id == 1)
            {
                MessageBox.Show("No se pueden dar de baja al Usuario ya que es el Administrador del Sistema", "Virtual Tianguis 2019", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show("Seguro que deseas eliminar el registro ?", "Virtual Tianguis 2019", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    TheVirtualTianguisProyect.Negocios.Administradores.AdministradorDatosEmpleado.BajaEmpleado(DatosEmpleado);
                }
                else
                {
                    return;
                }

                this.empleadoTableAdapter.GetData();
                this.empleadoTableAdapter.FillByEmpleados(this.datosTianguis.Empleado);

                EstablecerEstadoEditable(false);

                ClearFields();

                CargaProveedorActual();
            }
        }

        private void CanButton_Click(object sender, EventArgs e)
        {
            EstablecerEstadoEditable(false);
        }
    }
}
