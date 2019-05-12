namespace TheVirtualTianguisProyect.Formas
{
    partial class FormEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpleado));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AgregarButton = new System.Windows.Forms.ToolStripButton();
            this.ModifButton = new System.Windows.Forms.ToolStripButton();
            this.ElmButton = new System.Windows.Forms.ToolStripButton();
            this.GuarButton = new System.Windows.Forms.ToolStripButton();
            this.CanButton = new System.Windows.Forms.ToolStripButton();
            this.SalButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.datosTianguis = new TheVirtualTianguisProyect.DatosTianguis();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoTableAdapter = new TheVirtualTianguisProyect.DatosTianguisTableAdapters.EmpleadoTableAdapter();
            this.idempleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oficioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editarDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.almacenDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.venderDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fechaaltaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseñaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadoActivoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosTianguis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AgregarButton,
            this.ModifButton,
            this.ElmButton,
            this.GuarButton,
            this.CanButton,
            this.toolStripSeparator1,
            this.SalButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(792, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AgregarButton
            // 
            this.AgregarButton.Image = ((System.Drawing.Image)(resources.GetObject("AgregarButton.Image")));
            this.AgregarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(87, 24);
            this.AgregarButton.Text = "Agregar";
            // 
            // ModifButton
            // 
            this.ModifButton.Image = ((System.Drawing.Image)(resources.GetObject("ModifButton.Image")));
            this.ModifButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ModifButton.Name = "ModifButton";
            this.ModifButton.Size = new System.Drawing.Size(97, 24);
            this.ModifButton.Text = "Modificar";
            // 
            // ElmButton
            // 
            this.ElmButton.Image = ((System.Drawing.Image)(resources.GetObject("ElmButton.Image")));
            this.ElmButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ElmButton.Name = "ElmButton";
            this.ElmButton.Size = new System.Drawing.Size(87, 24);
            this.ElmButton.Text = "Eliminar";
            // 
            // GuarButton
            // 
            this.GuarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuarButton.Image")));
            this.GuarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GuarButton.Name = "GuarButton";
            this.GuarButton.Size = new System.Drawing.Size(86, 24);
            this.GuarButton.Text = "Guardar";
            // 
            // CanButton
            // 
            this.CanButton.Image = ((System.Drawing.Image)(resources.GetObject("CanButton.Image")));
            this.CanButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CanButton.Name = "CanButton";
            this.CanButton.Size = new System.Drawing.Size(90, 24);
            this.CanButton.Text = "Cancelar";
            // 
            // SalButton
            // 
            this.SalButton.Image = ((System.Drawing.Image)(resources.GetObject("SalButton.Image")));
            this.SalButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SalButton.Name = "SalButton";
            this.SalButton.Size = new System.Drawing.Size(62, 24);
            this.SalButton.Text = "Salir";
            this.SalButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idempleadoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apaternoDataGridViewTextBoxColumn,
            this.amaternoDataGridViewTextBoxColumn,
            this.nombreusuarioDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn,
            this.oficioDataGridViewTextBoxColumn,
            this.editarDataGridViewCheckBoxColumn,
            this.almacenDataGridViewCheckBoxColumn,
            this.venderDataGridViewCheckBoxColumn,
            this.fechaaltaDataGridViewTextBoxColumn,
            this.salarioDataGridViewTextBoxColumn,
            this.contraseñaDataGridViewTextBoxColumn,
            this.empleadoActivoDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.empleadoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(768, 180);
            this.dataGridView1.TabIndex = 1;
            // 
            // datosTianguis
            // 
            this.datosTianguis.DataSetName = "DatosTianguis";
            this.datosTianguis.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "Empleado";
            this.empleadoBindingSource.DataSource = this.datosTianguis;
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // idempleadoDataGridViewTextBoxColumn
            // 
            this.idempleadoDataGridViewTextBoxColumn.DataPropertyName = "Id_empleado";
            this.idempleadoDataGridViewTextBoxColumn.HeaderText = "Id_empleado";
            this.idempleadoDataGridViewTextBoxColumn.Name = "idempleadoDataGridViewTextBoxColumn";
            this.idempleadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idempleadoDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apaternoDataGridViewTextBoxColumn
            // 
            this.apaternoDataGridViewTextBoxColumn.DataPropertyName = "Apaterno";
            this.apaternoDataGridViewTextBoxColumn.HeaderText = "A. Paterno";
            this.apaternoDataGridViewTextBoxColumn.Name = "apaternoDataGridViewTextBoxColumn";
            // 
            // amaternoDataGridViewTextBoxColumn
            // 
            this.amaternoDataGridViewTextBoxColumn.DataPropertyName = "Amaterno";
            this.amaternoDataGridViewTextBoxColumn.HeaderText = "A. Materno";
            this.amaternoDataGridViewTextBoxColumn.Name = "amaternoDataGridViewTextBoxColumn";
            // 
            // nombreusuarioDataGridViewTextBoxColumn
            // 
            this.nombreusuarioDataGridViewTextBoxColumn.DataPropertyName = "Nombre_usuario";
            this.nombreusuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.nombreusuarioDataGridViewTextBoxColumn.Name = "nombreusuarioDataGridViewTextBoxColumn";
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "Edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            // 
            // oficioDataGridViewTextBoxColumn
            // 
            this.oficioDataGridViewTextBoxColumn.DataPropertyName = "Oficio";
            this.oficioDataGridViewTextBoxColumn.HeaderText = "Oficio";
            this.oficioDataGridViewTextBoxColumn.Name = "oficioDataGridViewTextBoxColumn";
            // 
            // editarDataGridViewCheckBoxColumn
            // 
            this.editarDataGridViewCheckBoxColumn.DataPropertyName = "Editar";
            this.editarDataGridViewCheckBoxColumn.HeaderText = "Editar";
            this.editarDataGridViewCheckBoxColumn.Name = "editarDataGridViewCheckBoxColumn";
            this.editarDataGridViewCheckBoxColumn.Visible = false;
            // 
            // almacenDataGridViewCheckBoxColumn
            // 
            this.almacenDataGridViewCheckBoxColumn.DataPropertyName = "Almacen";
            this.almacenDataGridViewCheckBoxColumn.HeaderText = "Almacen";
            this.almacenDataGridViewCheckBoxColumn.Name = "almacenDataGridViewCheckBoxColumn";
            this.almacenDataGridViewCheckBoxColumn.Visible = false;
            // 
            // venderDataGridViewCheckBoxColumn
            // 
            this.venderDataGridViewCheckBoxColumn.DataPropertyName = "Vender";
            this.venderDataGridViewCheckBoxColumn.HeaderText = "Vender";
            this.venderDataGridViewCheckBoxColumn.Name = "venderDataGridViewCheckBoxColumn";
            this.venderDataGridViewCheckBoxColumn.Visible = false;
            // 
            // fechaaltaDataGridViewTextBoxColumn
            // 
            this.fechaaltaDataGridViewTextBoxColumn.DataPropertyName = "Fecha_alta";
            this.fechaaltaDataGridViewTextBoxColumn.HeaderText = "Fecha de alta";
            this.fechaaltaDataGridViewTextBoxColumn.Name = "fechaaltaDataGridViewTextBoxColumn";
            // 
            // salarioDataGridViewTextBoxColumn
            // 
            this.salarioDataGridViewTextBoxColumn.DataPropertyName = "Salario";
            this.salarioDataGridViewTextBoxColumn.HeaderText = "Salario";
            this.salarioDataGridViewTextBoxColumn.Name = "salarioDataGridViewTextBoxColumn";
            // 
            // contraseñaDataGridViewTextBoxColumn
            // 
            this.contraseñaDataGridViewTextBoxColumn.DataPropertyName = "Contraseña";
            this.contraseñaDataGridViewTextBoxColumn.HeaderText = "Contraseña";
            this.contraseñaDataGridViewTextBoxColumn.Name = "contraseñaDataGridViewTextBoxColumn";
            // 
            // empleadoActivoDataGridViewCheckBoxColumn
            // 
            this.empleadoActivoDataGridViewCheckBoxColumn.DataPropertyName = "EmpleadoActivo";
            this.empleadoActivoDataGridViewCheckBoxColumn.HeaderText = "EmpleadoActivo";
            this.empleadoActivoDataGridViewCheckBoxColumn.Name = "empleadoActivoDataGridViewCheckBoxColumn";
            this.empleadoActivoDataGridViewCheckBoxColumn.Visible = false;
            // 
            // FormEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 443);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormEmpleado";
            this.Text = "Editar Empleados";
            this.Load += new System.EventHandler(this.FormEmpleado_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosTianguis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AgregarButton;
        private System.Windows.Forms.ToolStripButton ModifButton;
        private System.Windows.Forms.ToolStripButton ElmButton;
        private System.Windows.Forms.ToolStripButton GuarButton;
        private System.Windows.Forms.ToolStripButton CanButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton SalButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DatosTianguis datosTianguis;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private DatosTianguisTableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idempleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oficioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn editarDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn almacenDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn venderDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaaltaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseñaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn empleadoActivoDataGridViewCheckBoxColumn;
    }
}