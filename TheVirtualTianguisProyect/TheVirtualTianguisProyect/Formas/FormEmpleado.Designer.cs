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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SalButton = new System.Windows.Forms.ToolStripButton();
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
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosTianguis = new TheVirtualTianguisProyect.DatosTianguis();
            this.empleadoTableAdapter = new TheVirtualTianguisProyect.DatosTianguisTableAdapters.EmpleadoTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.nomtTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.aPatTextBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.aMatTextBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.usuTextBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.edadNumeric = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.ofiTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fechAltDateTime = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.salNumeric = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.conTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosTianguis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edadNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salNumeric)).BeginInit();
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
            this.dataGridView1.Size = new System.Drawing.Size(798, 180);
            this.dataGridView1.TabIndex = 1;
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
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // nomtTextBox
            // 
            this.nomtTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomtTextBox.Location = new System.Drawing.Point(12, 270);
            this.nomtTextBox.Name = "nomtTextBox";
            this.nomtTextBox.Size = new System.Drawing.Size(210, 30);
            this.nomtTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "A. Paterno:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // aPatTextBox2
            // 
            this.aPatTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aPatTextBox2.Location = new System.Drawing.Point(12, 360);
            this.aPatTextBox2.Name = "aPatTextBox2";
            this.aPatTextBox2.Size = new System.Drawing.Size(210, 30);
            this.aPatTextBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "A. Materno:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // aMatTextBox1
            // 
            this.aMatTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aMatTextBox1.Location = new System.Drawing.Point(12, 450);
            this.aMatTextBox1.Name = "aMatTextBox1";
            this.aMatTextBox1.Size = new System.Drawing.Size(210, 30);
            this.aMatTextBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(240, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Usuario:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // usuTextBox1
            // 
            this.usuTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuTextBox1.Location = new System.Drawing.Point(240, 270);
            this.usuTextBox1.Name = "usuTextBox1";
            this.usuTextBox1.Size = new System.Drawing.Size(210, 30);
            this.usuTextBox1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(240, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Edad:";
            // 
            // edadNumeric
            // 
            this.edadNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edadNumeric.Location = new System.Drawing.Point(240, 360);
            this.edadNumeric.Name = "edadNumeric";
            this.edadNumeric.Size = new System.Drawing.Size(120, 30);
            this.edadNumeric.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(240, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Oficio:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ofiTextBox
            // 
            this.ofiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ofiTextBox.Location = new System.Drawing.Point(240, 450);
            this.ofiTextBox.Name = "ofiTextBox";
            this.ofiTextBox.Size = new System.Drawing.Size(210, 30);
            this.ofiTextBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(468, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fecha de Alta:";
            // 
            // fechAltDateTime
            // 
            this.fechAltDateTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechAltDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechAltDateTime.Location = new System.Drawing.Point(468, 270);
            this.fechAltDateTime.Name = "fechAltDateTime";
            this.fechAltDateTime.Size = new System.Drawing.Size(330, 30);
            this.fechAltDateTime.TabIndex = 15;
            this.fechAltDateTime.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(468, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Salario:";
            // 
            // salNumeric
            // 
            this.salNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salNumeric.Location = new System.Drawing.Point(468, 360);
            this.salNumeric.Name = "salNumeric";
            this.salNumeric.Size = new System.Drawing.Size(120, 30);
            this.salNumeric.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(468, 420);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Contraseña:";
            // 
            // conTextBox
            // 
            this.conTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conTextBox.Location = new System.Drawing.Point(468, 450);
            this.conTextBox.Name = "conTextBox";
            this.conTextBox.Size = new System.Drawing.Size(210, 30);
            this.conTextBox.TabIndex = 19;
            // 
            // FormEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 523);
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
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormEmpleado";
            this.Text = "Editar Empleados";
            this.Load += new System.EventHandler(this.FormEmpleado_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosTianguis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edadNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salNumeric)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomtTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox aPatTextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox aMatTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usuTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown edadNumeric;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ofiTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker fechAltDateTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown salNumeric;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox conTextBox;
    }
}