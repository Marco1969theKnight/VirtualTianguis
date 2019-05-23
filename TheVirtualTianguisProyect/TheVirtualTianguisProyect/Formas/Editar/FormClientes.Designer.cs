namespace TheVirtualTianguisProyect.Formas.Editar
{
    partial class FormClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AgregarButton = new System.Windows.Forms.ToolStripButton();
            this.ModifButton = new System.Windows.Forms.ToolStripButton();
            this.ElmButton = new System.Windows.Forms.ToolStripButton();
            this.GuarButton = new System.Windows.Forms.ToolStripButton();
            this.CanButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SalButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.datosTianguis = new TheVirtualTianguisProyect.DatosTianguis();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new TheVirtualTianguisProyect.DatosTianguisTableAdapters.ClientesTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rFCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aMaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noExtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noIntDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coloniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoPostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteActivoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RFCTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NomtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.APattextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AMattextBox = new System.Windows.Forms.TextBox();
            this.EsttextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CiutextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ColtextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CaltextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NoExtnumeric = new System.Windows.Forms.NumericUpDown();
            this.NoIntnumeric = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.CPosnumeric = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosTianguis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoExtnumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoIntnumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPosnumeric)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(822, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AgregarButton
            // 
            this.AgregarButton.Image = ((System.Drawing.Image)(resources.GetObject("AgregarButton.Image")));
            this.AgregarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(87, 24);
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
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
            this.SalButton.Size = new System.Drawing.Size(62, 24);
            this.SalButton.Text = "Salir";
            this.SalButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.rFCDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.aPaternoDataGridViewTextBoxColumn,
            this.aMaternoDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.ciudadDataGridViewTextBoxColumn,
            this.calleDataGridViewTextBoxColumn,
            this.noExtDataGridViewTextBoxColumn,
            this.noIntDataGridViewTextBoxColumn,
            this.coloniaDataGridViewTextBoxColumn,
            this.codigoPostalDataGridViewTextBoxColumn,
            this.clienteActivoDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.clientesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(750, 180);
            this.dataGridView1.TabIndex = 3;
            // 
            // datosTianguis
            // 
            this.datosTianguis.DataSetName = "DatosTianguis";
            this.datosTianguis.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.datosTianguis;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // rFCDataGridViewTextBoxColumn
            // 
            this.rFCDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.rFCDataGridViewTextBoxColumn.DataPropertyName = "RFC";
            this.rFCDataGridViewTextBoxColumn.HeaderText = "RFC";
            this.rFCDataGridViewTextBoxColumn.Name = "rFCDataGridViewTextBoxColumn";
            this.rFCDataGridViewTextBoxColumn.Width = 64;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 87;
            // 
            // aPaternoDataGridViewTextBoxColumn
            // 
            this.aPaternoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.aPaternoDataGridViewTextBoxColumn.DataPropertyName = "APaterno";
            this.aPaternoDataGridViewTextBoxColumn.HeaderText = "A. Paterno";
            this.aPaternoDataGridViewTextBoxColumn.Name = "aPaternoDataGridViewTextBoxColumn";
            this.aPaternoDataGridViewTextBoxColumn.Width = 104;
            // 
            // aMaternoDataGridViewTextBoxColumn
            // 
            this.aMaternoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.aMaternoDataGridViewTextBoxColumn.DataPropertyName = "AMaterno";
            this.aMaternoDataGridViewTextBoxColumn.HeaderText = "A. Materno";
            this.aMaternoDataGridViewTextBoxColumn.Name = "aMaternoDataGridViewTextBoxColumn";
            this.aMaternoDataGridViewTextBoxColumn.Width = 106;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.Width = 81;
            // 
            // ciudadDataGridViewTextBoxColumn
            // 
            this.ciudadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ciudadDataGridViewTextBoxColumn.DataPropertyName = "Ciudad";
            this.ciudadDataGridViewTextBoxColumn.HeaderText = "Ciudad";
            this.ciudadDataGridViewTextBoxColumn.Name = "ciudadDataGridViewTextBoxColumn";
            this.ciudadDataGridViewTextBoxColumn.Width = 81;
            // 
            // calleDataGridViewTextBoxColumn
            // 
            this.calleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.calleDataGridViewTextBoxColumn.DataPropertyName = "Calle";
            this.calleDataGridViewTextBoxColumn.HeaderText = "Calle";
            this.calleDataGridViewTextBoxColumn.Name = "calleDataGridViewTextBoxColumn";
            this.calleDataGridViewTextBoxColumn.Width = 68;
            // 
            // noExtDataGridViewTextBoxColumn
            // 
            this.noExtDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.noExtDataGridViewTextBoxColumn.DataPropertyName = "NoExt";
            this.noExtDataGridViewTextBoxColumn.HeaderText = "No. Ext";
            this.noExtDataGridViewTextBoxColumn.Name = "noExtDataGridViewTextBoxColumn";
            this.noExtDataGridViewTextBoxColumn.Width = 82;
            // 
            // noIntDataGridViewTextBoxColumn
            // 
            this.noIntDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.noIntDataGridViewTextBoxColumn.DataPropertyName = "NoInt";
            this.noIntDataGridViewTextBoxColumn.HeaderText = "No. Int";
            this.noIntDataGridViewTextBoxColumn.Name = "noIntDataGridViewTextBoxColumn";
            this.noIntDataGridViewTextBoxColumn.Width = 78;
            // 
            // coloniaDataGridViewTextBoxColumn
            // 
            this.coloniaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.coloniaDataGridViewTextBoxColumn.DataPropertyName = "Colonia";
            this.coloniaDataGridViewTextBoxColumn.HeaderText = "Colonia";
            this.coloniaDataGridViewTextBoxColumn.Name = "coloniaDataGridViewTextBoxColumn";
            this.coloniaDataGridViewTextBoxColumn.Width = 84;
            // 
            // codigoPostalDataGridViewTextBoxColumn
            // 
            this.codigoPostalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.codigoPostalDataGridViewTextBoxColumn.DataPropertyName = "CodigoPostal";
            this.codigoPostalDataGridViewTextBoxColumn.HeaderText = "CodigoPostal";
            this.codigoPostalDataGridViewTextBoxColumn.Name = "codigoPostalDataGridViewTextBoxColumn";
            this.codigoPostalDataGridViewTextBoxColumn.Width = 120;
            // 
            // clienteActivoDataGridViewCheckBoxColumn
            // 
            this.clienteActivoDataGridViewCheckBoxColumn.DataPropertyName = "ClienteActivo";
            this.clienteActivoDataGridViewCheckBoxColumn.HeaderText = "ClienteActivo";
            this.clienteActivoDataGridViewCheckBoxColumn.Name = "clienteActivoDataGridViewCheckBoxColumn";
            this.clienteActivoDataGridViewCheckBoxColumn.Visible = false;
            // 
            // RFCTextBox
            // 
            this.RFCTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RFCTextBox.Location = new System.Drawing.Point(12, 300);
            this.RFCTextBox.Name = "RFCTextBox";
            this.RFCTextBox.Size = new System.Drawing.Size(210, 30);
            this.RFCTextBox.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "RFC:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NomtextBox
            // 
            this.NomtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomtextBox.Location = new System.Drawing.Point(12, 390);
            this.NomtextBox.Name = "NomtextBox";
            this.NomtextBox.Size = new System.Drawing.Size(210, 30);
            this.NomtextBox.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 450);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "A. Paterno:";
            // 
            // APattextBox
            // 
            this.APattextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APattextBox.Location = new System.Drawing.Point(12, 480);
            this.APattextBox.Name = "APattextBox";
            this.APattextBox.Size = new System.Drawing.Size(210, 30);
            this.APattextBox.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 540);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "A. Materno:";
            // 
            // AMattextBox
            // 
            this.AMattextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AMattextBox.Location = new System.Drawing.Point(12, 570);
            this.AMattextBox.Name = "AMattextBox";
            this.AMattextBox.Size = new System.Drawing.Size(210, 30);
            this.AMattextBox.TabIndex = 31;
            // 
            // EsttextBox
            // 
            this.EsttextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EsttextBox.Location = new System.Drawing.Point(240, 300);
            this.EsttextBox.Name = "EsttextBox";
            this.EsttextBox.Size = new System.Drawing.Size(210, 30);
            this.EsttextBox.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(240, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 32;
            this.label5.Text = "Estado:";
            // 
            // CiutextBox
            // 
            this.CiutextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CiutextBox.Location = new System.Drawing.Point(240, 390);
            this.CiutextBox.Name = "CiutextBox";
            this.CiutextBox.Size = new System.Drawing.Size(210, 30);
            this.CiutextBox.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(240, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 25);
            this.label6.TabIndex = 34;
            this.label6.Text = "Ciudad:";
            // 
            // ColtextBox
            // 
            this.ColtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColtextBox.Location = new System.Drawing.Point(240, 480);
            this.ColtextBox.Name = "ColtextBox";
            this.ColtextBox.Size = new System.Drawing.Size(210, 30);
            this.ColtextBox.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(240, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 25);
            this.label7.TabIndex = 36;
            this.label7.Text = "Colonia:";
            // 
            // CaltextBox
            // 
            this.CaltextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaltextBox.Location = new System.Drawing.Point(240, 570);
            this.CaltextBox.Name = "CaltextBox";
            this.CaltextBox.Size = new System.Drawing.Size(210, 30);
            this.CaltextBox.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(240, 540);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 25);
            this.label8.TabIndex = 38;
            this.label8.Text = "Calle:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(468, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 25);
            this.label9.TabIndex = 40;
            this.label9.Text = "No. Ext:";
            // 
            // NoExtnumeric
            // 
            this.NoExtnumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoExtnumeric.Location = new System.Drawing.Point(473, 300);
            this.NoExtnumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NoExtnumeric.Name = "NoExtnumeric";
            this.NoExtnumeric.Size = new System.Drawing.Size(120, 30);
            this.NoExtnumeric.TabIndex = 41;
            // 
            // NoIntnumeric
            // 
            this.NoIntnumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoIntnumeric.Location = new System.Drawing.Point(473, 391);
            this.NoIntnumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NoIntnumeric.Name = "NoIntnumeric";
            this.NoIntnumeric.Size = new System.Drawing.Size(120, 30);
            this.NoIntnumeric.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(468, 361);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 25);
            this.label10.TabIndex = 42;
            this.label10.Text = "No. Int:";
            // 
            // CPosnumeric
            // 
            this.CPosnumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPosnumeric.Location = new System.Drawing.Point(473, 481);
            this.CPosnumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.CPosnumeric.Name = "CPosnumeric";
            this.CPosnumeric.Size = new System.Drawing.Size(120, 30);
            this.CPosnumeric.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(468, 451);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 25);
            this.label11.TabIndex = 44;
            this.label11.Text = "Cod. Postal:";
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 673);
            this.Controls.Add(this.CPosnumeric);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.NoIntnumeric);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.NoExtnumeric);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CaltextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ColtextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CiutextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EsttextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AMattextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.APattextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NomtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RFCTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.MaximumSize = new System.Drawing.Size(840, 720);
            this.MinimumSize = new System.Drawing.Size(840, 720);
            this.Name = "FormClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormClientes_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosTianguis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoExtnumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoIntnumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPosnumeric)).EndInit();
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
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DatosTianguisTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rFCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noExtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noIntDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coloniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoPostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clienteActivoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox RFCTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NomtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox APattextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AMattextBox;
        private System.Windows.Forms.TextBox EsttextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CiutextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ColtextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CaltextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown NoExtnumeric;
        private System.Windows.Forms.NumericUpDown NoIntnumeric;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown CPosnumeric;
        private System.Windows.Forms.Label label11;
    }
}