namespace TheVirtualTianguisProyect.Formas.Editar
{
    partial class FormGerentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGerentes));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AgregarButton = new System.Windows.Forms.ToolStripButton();
            this.ModifButton = new System.Windows.Forms.ToolStripButton();
            this.ElmButton = new System.Windows.Forms.ToolStripButton();
            this.GuarButton = new System.Windows.Forms.ToolStripButton();
            this.CanButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SalButton = new System.Windows.Forms.ToolStripButton();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosTianguis = new TheVirtualTianguisProyect.DatosTianguis();
            this.conTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.salNumeric = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.fechAltDateTime = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.ofiTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.edadNumeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.usuTextBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.aMatTextBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.aPatTextBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nomtTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.empleadoTableAdapter = new TheVirtualTianguisProyect.DatosTianguisTableAdapters.EmpleadoTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosTianguis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edadNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DodgerBlue;
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
            this.toolStrip1.Size = new System.Drawing.Size(618, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AgregarButton
            // 
            this.AgregarButton.Image = ((System.Drawing.Image)(resources.GetObject("AgregarButton.Image")));
            this.AgregarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(73, 24);
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // ModifButton
            // 
            this.ModifButton.Image = ((System.Drawing.Image)(resources.GetObject("ModifButton.Image")));
            this.ModifButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ModifButton.Name = "ModifButton";
            this.ModifButton.Size = new System.Drawing.Size(82, 24);
            this.ModifButton.Text = "Modificar";
            this.ModifButton.Click += new System.EventHandler(this.ModifButton_Click);
            // 
            // ElmButton
            // 
            this.ElmButton.Image = ((System.Drawing.Image)(resources.GetObject("ElmButton.Image")));
            this.ElmButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ElmButton.Name = "ElmButton";
            this.ElmButton.Size = new System.Drawing.Size(74, 24);
            this.ElmButton.Text = "Eliminar";
            this.ElmButton.Click += new System.EventHandler(this.ElmButton_Click);
            // 
            // GuarButton
            // 
            this.GuarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuarButton.Image")));
            this.GuarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GuarButton.Name = "GuarButton";
            this.GuarButton.Size = new System.Drawing.Size(73, 24);
            this.GuarButton.Text = "Guardar";
            this.GuarButton.Click += new System.EventHandler(this.GuarButton_Click);
            // 
            // CanButton
            // 
            this.CanButton.Image = ((System.Drawing.Image)(resources.GetObject("CanButton.Image")));
            this.CanButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CanButton.Name = "CanButton";
            this.CanButton.Size = new System.Drawing.Size(77, 24);
            this.CanButton.Text = "Cancelar";
            this.CanButton.Click += new System.EventHandler(this.CanButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // SalButton
            // 
            this.SalButton.Image = ((System.Drawing.Image)(resources.GetObject("SalButton.Image")));
            this.SalButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SalButton.Name = "SalButton";
            this.SalButton.Size = new System.Drawing.Size(53, 24);
            this.SalButton.Text = "Salir";
            this.SalButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SalButton.Click += new System.EventHandler(this.SalButton_Click);
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "Empleado";
            this.empleadoBindingSource.DataSource = this.datosTianguis;
            // 
            // datosTianguis
            // 
            this.datosTianguis.DataSetName = "DatosTianguis";
            this.datosTianguis.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // conTextBox
            // 
            this.conTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conTextBox.Location = new System.Drawing.Point(351, 390);
            this.conTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.conTextBox.Name = "conTextBox";
            this.conTextBox.Size = new System.Drawing.Size(158, 29);
            this.conTextBox.TabIndex = 75;
            this.conTextBox.TextChanged += new System.EventHandler(this.conTextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(351, 366);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 21);
            this.label9.TabIndex = 74;
            this.label9.Text = "Contraseña:";
            // 
            // salNumeric
            // 
            this.salNumeric.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salNumeric.Location = new System.Drawing.Point(351, 317);
            this.salNumeric.Margin = new System.Windows.Forms.Padding(2);
            this.salNumeric.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.salNumeric.Name = "salNumeric";
            this.salNumeric.Size = new System.Drawing.Size(90, 29);
            this.salNumeric.TabIndex = 73;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(351, 292);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 21);
            this.label8.TabIndex = 72;
            this.label8.Text = "Salario:";
            // 
            // fechAltDateTime
            // 
            this.fechAltDateTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechAltDateTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechAltDateTime.Location = new System.Drawing.Point(351, 244);
            this.fechAltDateTime.Margin = new System.Windows.Forms.Padding(2);
            this.fechAltDateTime.Name = "fechAltDateTime";
            this.fechAltDateTime.Size = new System.Drawing.Size(248, 29);
            this.fechAltDateTime.TabIndex = 71;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(351, 219);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 21);
            this.label7.TabIndex = 70;
            this.label7.Text = "Fecha de Alta:";
            // 
            // ofiTextBox
            // 
            this.ofiTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ofiTextBox.Location = new System.Drawing.Point(180, 390);
            this.ofiTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ofiTextBox.Name = "ofiTextBox";
            this.ofiTextBox.Size = new System.Drawing.Size(158, 29);
            this.ofiTextBox.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(180, 366);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 21);
            this.label6.TabIndex = 68;
            this.label6.Text = "Oficio:";
            // 
            // edadNumeric
            // 
            this.edadNumeric.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edadNumeric.Location = new System.Drawing.Point(180, 317);
            this.edadNumeric.Margin = new System.Windows.Forms.Padding(2);
            this.edadNumeric.Name = "edadNumeric";
            this.edadNumeric.Size = new System.Drawing.Size(90, 29);
            this.edadNumeric.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(180, 292);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 21);
            this.label5.TabIndex = 66;
            this.label5.Text = "Edad:";
            // 
            // usuTextBox1
            // 
            this.usuTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuTextBox1.Location = new System.Drawing.Point(180, 244);
            this.usuTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.usuTextBox1.Name = "usuTextBox1";
            this.usuTextBox1.Size = new System.Drawing.Size(158, 29);
            this.usuTextBox1.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(180, 219);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 21);
            this.label4.TabIndex = 64;
            this.label4.Text = "Usuario:";
            // 
            // aMatTextBox1
            // 
            this.aMatTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aMatTextBox1.Location = new System.Drawing.Point(9, 390);
            this.aMatTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.aMatTextBox1.Name = "aMatTextBox1";
            this.aMatTextBox1.Size = new System.Drawing.Size(158, 29);
            this.aMatTextBox1.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 366);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 62;
            this.label3.Text = "A. Materno:";
            // 
            // aPatTextBox2
            // 
            this.aPatTextBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aPatTextBox2.Location = new System.Drawing.Point(9, 317);
            this.aPatTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.aPatTextBox2.Name = "aPatTextBox2";
            this.aPatTextBox2.Size = new System.Drawing.Size(158, 29);
            this.aPatTextBox2.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 292);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 60;
            this.label2.Text = "A. Paterno:";
            // 
            // nomtTextBox
            // 
            this.nomtTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomtTextBox.Location = new System.Drawing.Point(9, 244);
            this.nomtTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nomtTextBox.Name = "nomtTextBox";
            this.nomtTextBox.Size = new System.Drawing.Size(158, 29);
            this.nomtTextBox.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 219);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 58;
            this.label1.Text = "Nombre:";
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(14, 39);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(562, 146);
            this.dataGridView1.TabIndex = 76;
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
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 69;
            // 
            // apaternoDataGridViewTextBoxColumn
            // 
            this.apaternoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.apaternoDataGridViewTextBoxColumn.DataPropertyName = "Apaterno";
            this.apaternoDataGridViewTextBoxColumn.HeaderText = "A. Paterno";
            this.apaternoDataGridViewTextBoxColumn.Name = "apaternoDataGridViewTextBoxColumn";
            this.apaternoDataGridViewTextBoxColumn.ReadOnly = true;
            this.apaternoDataGridViewTextBoxColumn.Width = 82;
            // 
            // amaternoDataGridViewTextBoxColumn
            // 
            this.amaternoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.amaternoDataGridViewTextBoxColumn.DataPropertyName = "Amaterno";
            this.amaternoDataGridViewTextBoxColumn.HeaderText = "A. Materno";
            this.amaternoDataGridViewTextBoxColumn.Name = "amaternoDataGridViewTextBoxColumn";
            this.amaternoDataGridViewTextBoxColumn.ReadOnly = true;
            this.amaternoDataGridViewTextBoxColumn.Width = 84;
            // 
            // nombreusuarioDataGridViewTextBoxColumn
            // 
            this.nombreusuarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nombreusuarioDataGridViewTextBoxColumn.DataPropertyName = "Nombre_usuario";
            this.nombreusuarioDataGridViewTextBoxColumn.HeaderText = "Nom. Usuario";
            this.nombreusuarioDataGridViewTextBoxColumn.Name = "nombreusuarioDataGridViewTextBoxColumn";
            this.nombreusuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreusuarioDataGridViewTextBoxColumn.Width = 96;
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "Edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            this.edadDataGridViewTextBoxColumn.ReadOnly = true;
            this.edadDataGridViewTextBoxColumn.Width = 57;
            // 
            // oficioDataGridViewTextBoxColumn
            // 
            this.oficioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.oficioDataGridViewTextBoxColumn.DataPropertyName = "Oficio";
            this.oficioDataGridViewTextBoxColumn.HeaderText = "Oficio";
            this.oficioDataGridViewTextBoxColumn.Name = "oficioDataGridViewTextBoxColumn";
            this.oficioDataGridViewTextBoxColumn.ReadOnly = true;
            this.oficioDataGridViewTextBoxColumn.Width = 59;
            // 
            // editarDataGridViewCheckBoxColumn
            // 
            this.editarDataGridViewCheckBoxColumn.DataPropertyName = "Editar";
            this.editarDataGridViewCheckBoxColumn.HeaderText = "Editar";
            this.editarDataGridViewCheckBoxColumn.Name = "editarDataGridViewCheckBoxColumn";
            this.editarDataGridViewCheckBoxColumn.ReadOnly = true;
            this.editarDataGridViewCheckBoxColumn.Visible = false;
            // 
            // almacenDataGridViewCheckBoxColumn
            // 
            this.almacenDataGridViewCheckBoxColumn.DataPropertyName = "Almacen";
            this.almacenDataGridViewCheckBoxColumn.HeaderText = "Almacen";
            this.almacenDataGridViewCheckBoxColumn.Name = "almacenDataGridViewCheckBoxColumn";
            this.almacenDataGridViewCheckBoxColumn.ReadOnly = true;
            this.almacenDataGridViewCheckBoxColumn.Visible = false;
            // 
            // venderDataGridViewCheckBoxColumn
            // 
            this.venderDataGridViewCheckBoxColumn.DataPropertyName = "Vender";
            this.venderDataGridViewCheckBoxColumn.HeaderText = "Vender";
            this.venderDataGridViewCheckBoxColumn.Name = "venderDataGridViewCheckBoxColumn";
            this.venderDataGridViewCheckBoxColumn.ReadOnly = true;
            this.venderDataGridViewCheckBoxColumn.Visible = false;
            // 
            // fechaaltaDataGridViewTextBoxColumn
            // 
            this.fechaaltaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fechaaltaDataGridViewTextBoxColumn.DataPropertyName = "Fecha_alta";
            this.fechaaltaDataGridViewTextBoxColumn.HeaderText = "Fecha de alta";
            this.fechaaltaDataGridViewTextBoxColumn.Name = "fechaaltaDataGridViewTextBoxColumn";
            this.fechaaltaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaaltaDataGridViewTextBoxColumn.Width = 97;
            // 
            // salarioDataGridViewTextBoxColumn
            // 
            this.salarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.salarioDataGridViewTextBoxColumn.DataPropertyName = "Salario";
            this.salarioDataGridViewTextBoxColumn.HeaderText = "Salario";
            this.salarioDataGridViewTextBoxColumn.Name = "salarioDataGridViewTextBoxColumn";
            this.salarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.salarioDataGridViewTextBoxColumn.Width = 64;
            // 
            // contraseñaDataGridViewTextBoxColumn
            // 
            this.contraseñaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.contraseñaDataGridViewTextBoxColumn.DataPropertyName = "Contraseña";
            this.contraseñaDataGridViewTextBoxColumn.HeaderText = "Contraseña";
            this.contraseñaDataGridViewTextBoxColumn.Name = "contraseñaDataGridViewTextBoxColumn";
            this.contraseñaDataGridViewTextBoxColumn.ReadOnly = true;
            this.contraseñaDataGridViewTextBoxColumn.Width = 86;
            // 
            // empleadoActivoDataGridViewCheckBoxColumn
            // 
            this.empleadoActivoDataGridViewCheckBoxColumn.DataPropertyName = "EmpleadoActivo";
            this.empleadoActivoDataGridViewCheckBoxColumn.HeaderText = "EmpleadoActivo";
            this.empleadoActivoDataGridViewCheckBoxColumn.Name = "empleadoActivoDataGridViewCheckBoxColumn";
            this.empleadoActivoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.empleadoActivoDataGridViewCheckBoxColumn.Visible = false;
            // 
            // FormGerentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(618, 553);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.conTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.salNumeric);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.fechAltDateTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ofiTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.edadNumeric);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.usuTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.aMatTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aPatTextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomtTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(634, 592);
            this.MinimumSize = new System.Drawing.Size(634, 592);
            this.Name = "FormGerentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Gerentes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormGerentes_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosTianguis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edadNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TextBox conTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown salNumeric;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker fechAltDateTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ofiTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown edadNumeric;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox usuTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox aMatTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox aPatTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomtTextBox;
        private System.Windows.Forms.Label label1;
        private DatosTianguis datosTianguis;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private DatosTianguisTableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
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