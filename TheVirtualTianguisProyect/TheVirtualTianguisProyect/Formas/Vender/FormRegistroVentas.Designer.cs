namespace TheVirtualTianguisProyect.Formas.Vender
{
    partial class FormRegistroVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistroVentas));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.datosTianguis = new TheVirtualTianguisProyect.DatosTianguis();
<<<<<<< HEAD
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
=======
            this.button1 = new System.Windows.Forms.Button();
>>>>>>> ebf0494c5d84aba24b75cc63e4b4e55bf76f68f0
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasTableAdapter = new TheVirtualTianguisProyect.DatosTianguisTableAdapters.VentasTableAdapter();
            this.noVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventaActivaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosTianguis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noVentaDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.empleadoDataGridViewTextBoxColumn,
            this.detalleDataGridViewTextBoxColumn,
            this.ventaActivaDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.ventasBindingSource;
<<<<<<< HEAD
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.dataGridView1.Location = new System.Drawing.Point(9, 44);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> ebf0494c5d84aba24b75cc63e4b4e55bf76f68f0
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 363);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // datosTianguis
            // 
            this.datosTianguis.DataSetName = "DatosTianguis";
            this.datosTianguis.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
<<<<<<< HEAD
            // fillByToolStrip
            // 
            this.fillByToolStrip.BackColor = System.Drawing.Color.DodgerBlue;
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(821, 25);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
=======
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(446, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Detalle Venta";
            this.button1.UseVisualStyleBackColor = false;
>>>>>>> ebf0494c5d84aba24b75cc63e4b4e55bf76f68f0
            // 
            // ventasBindingSource
            // 
            this.ventasBindingSource.DataMember = "Ventas";
            this.ventasBindingSource.DataSource = this.datosTianguis;
            // 
            // ventasTableAdapter
            // 
            this.ventasTableAdapter.ClearBeforeFill = true;
            // 
            // noVentaDataGridViewTextBoxColumn
            // 
            this.noVentaDataGridViewTextBoxColumn.DataPropertyName = "NoVenta";
            this.noVentaDataGridViewTextBoxColumn.HeaderText = "NoVenta";
            this.noVentaDataGridViewTextBoxColumn.Name = "noVentaDataGridViewTextBoxColumn";
            this.noVentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.noVentaDataGridViewTextBoxColumn.Width = 92;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
<<<<<<< HEAD
            this.fechaDataGridViewTextBoxColumn.Width = 76;
=======
            this.fechaDataGridViewTextBoxColumn.Width = 62;
>>>>>>> ebf0494c5d84aba24b75cc63e4b4e55bf76f68f0
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
<<<<<<< HEAD
            this.totalDataGridViewTextBoxColumn.Width = 69;
=======
            this.totalDataGridViewTextBoxColumn.Width = 56;
>>>>>>> ebf0494c5d84aba24b75cc63e4b4e55bf76f68f0
            // 
            // empleadoDataGridViewTextBoxColumn
            // 
            this.empleadoDataGridViewTextBoxColumn.DataPropertyName = "Empleado";
            this.empleadoDataGridViewTextBoxColumn.HeaderText = "Empleado";
            this.empleadoDataGridViewTextBoxColumn.Name = "empleadoDataGridViewTextBoxColumn";
            this.empleadoDataGridViewTextBoxColumn.ReadOnly = true;
<<<<<<< HEAD
=======
            this.empleadoDataGridViewTextBoxColumn.Width = 79;
>>>>>>> ebf0494c5d84aba24b75cc63e4b4e55bf76f68f0
            // 
            // detalleDataGridViewTextBoxColumn
            // 
            this.detalleDataGridViewTextBoxColumn.DataPropertyName = "Detalle";
            this.detalleDataGridViewTextBoxColumn.HeaderText = "Detalle";
            this.detalleDataGridViewTextBoxColumn.Name = "detalleDataGridViewTextBoxColumn";
            this.detalleDataGridViewTextBoxColumn.ReadOnly = true;
<<<<<<< HEAD
            this.detalleDataGridViewTextBoxColumn.Width = 81;
=======
            this.detalleDataGridViewTextBoxColumn.Width = 65;
>>>>>>> ebf0494c5d84aba24b75cc63e4b4e55bf76f68f0
            // 
            // ventaActivaDataGridViewCheckBoxColumn
            // 
            this.ventaActivaDataGridViewCheckBoxColumn.DataPropertyName = "VentaActiva";
            this.ventaActivaDataGridViewCheckBoxColumn.HeaderText = "VentaActiva";
            this.ventaActivaDataGridViewCheckBoxColumn.Name = "ventaActivaDataGridViewCheckBoxColumn";
            this.ventaActivaDataGridViewCheckBoxColumn.ReadOnly = true;
<<<<<<< HEAD
            this.ventaActivaDataGridViewCheckBoxColumn.Width = 89;
=======
            this.ventaActivaDataGridViewCheckBoxColumn.Width = 71;
>>>>>>> ebf0494c5d84aba24b75cc63e4b4e55bf76f68f0
            // 
            // FormRegistroVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(821, 671);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.ClientSize = new System.Drawing.Size(616, 427);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> ebf0494c5d84aba24b75cc63e4b4e55bf76f68f0
            this.Name = "FormRegistroVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegistroVentas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormRegistroVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosTianguis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DatosTianguis datosTianguis;
<<<<<<< HEAD
        private System.Windows.Forms.ToolStrip fillByToolStrip;
=======
        private System.Windows.Forms.Button button1;
>>>>>>> ebf0494c5d84aba24b75cc63e4b4e55bf76f68f0
        private System.Windows.Forms.BindingSource ventasBindingSource;
        private DatosTianguisTableAdapters.VentasTableAdapter ventasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn noVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ventaActivaDataGridViewCheckBoxColumn;
    }
}