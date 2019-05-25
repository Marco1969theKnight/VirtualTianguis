namespace TheVirtualTianguisProyect.Formas.Vender
{
    partial class FormAgregarNuevoProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarNuevoProducto));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoActivoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosTianguis = new TheVirtualTianguisProyect.DatosTianguis();
            this.fillByNombre2ToolStrip = new System.Windows.Forms.ToolStrip();
            this.nombreToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nombreToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByNombre2ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.marcaToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.marcaToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByMarcaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillByCategoriaToolStrip = new System.Windows.Forms.ToolStrip();
            this.categoriaToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.categoriaToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByCategoriaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.productoTableAdapter = new TheVirtualTianguisProyect.DatosTianguisTableAdapters.ProductoTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosTianguis)).BeginInit();
            this.fillByNombre2ToolStrip.SuspendLayout();
            this.fillByCategoriaToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproductoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.proveedorDataGridViewTextBoxColumn,
            this.productoActivoDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.productoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 49);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(540, 219);
            this.dataGridView1.TabIndex = 0;
            // 
            // idproductoDataGridViewTextBoxColumn
            // 
            this.idproductoDataGridViewTextBoxColumn.DataPropertyName = "Id_producto";
            this.idproductoDataGridViewTextBoxColumn.HeaderText = "Id_producto";
            this.idproductoDataGridViewTextBoxColumn.Name = "idproductoDataGridViewTextBoxColumn";
            this.idproductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idproductoDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // proveedorDataGridViewTextBoxColumn
            // 
            this.proveedorDataGridViewTextBoxColumn.DataPropertyName = "Proveedor";
            this.proveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor";
            this.proveedorDataGridViewTextBoxColumn.Name = "proveedorDataGridViewTextBoxColumn";
            this.proveedorDataGridViewTextBoxColumn.Visible = false;
            // 
            // productoActivoDataGridViewCheckBoxColumn
            // 
            this.productoActivoDataGridViewCheckBoxColumn.DataPropertyName = "ProductoActivo";
            this.productoActivoDataGridViewCheckBoxColumn.HeaderText = "ProductoActivo";
            this.productoActivoDataGridViewCheckBoxColumn.Name = "productoActivoDataGridViewCheckBoxColumn";
            this.productoActivoDataGridViewCheckBoxColumn.Visible = false;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.datosTianguis;
            // 
            // datosTianguis
            // 
            this.datosTianguis.DataSetName = "DatosTianguis";
            this.datosTianguis.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillByNombre2ToolStrip
            // 
            this.fillByNombre2ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByNombre2ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombreToolStripLabel,
            this.nombreToolStripTextBox,
            this.fillByNombre2ToolStripButton,
            this.toolStripSeparator1,
            this.marcaToolStripLabel,
            this.marcaToolStripTextBox,
            this.fillByMarcaToolStripButton});
            this.fillByNombre2ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByNombre2ToolStrip.Name = "fillByNombre2ToolStrip";
            this.fillByNombre2ToolStrip.Size = new System.Drawing.Size(600, 25);
            this.fillByNombre2ToolStrip.TabIndex = 1;
            this.fillByNombre2ToolStrip.Text = "fillByNombre2ToolStrip";
            // 
            // nombreToolStripLabel
            // 
            this.nombreToolStripLabel.Name = "nombreToolStripLabel";
            this.nombreToolStripLabel.Size = new System.Drawing.Size(54, 22);
            this.nombreToolStripLabel.Text = "Nombre:";
            // 
            // nombreToolStripTextBox
            // 
            this.nombreToolStripTextBox.Name = "nombreToolStripTextBox";
            this.nombreToolStripTextBox.Size = new System.Drawing.Size(76, 25);
            // 
            // fillByNombre2ToolStripButton
            // 
            this.fillByNombre2ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByNombre2ToolStripButton.Name = "fillByNombre2ToolStripButton";
            this.fillByNombre2ToolStripButton.Size = new System.Drawing.Size(89, 22);
            this.fillByNombre2ToolStripButton.Text = "FillByNombre2";
            this.fillByNombre2ToolStripButton.Click += new System.EventHandler(this.fillByNombre2ToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // marcaToolStripLabel
            // 
            this.marcaToolStripLabel.Name = "marcaToolStripLabel";
            this.marcaToolStripLabel.Size = new System.Drawing.Size(43, 22);
            this.marcaToolStripLabel.Text = "Marca:";
            // 
            // marcaToolStripTextBox
            // 
            this.marcaToolStripTextBox.Name = "marcaToolStripTextBox";
            this.marcaToolStripTextBox.Size = new System.Drawing.Size(76, 25);
            // 
            // fillByMarcaToolStripButton
            // 
            this.fillByMarcaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByMarcaToolStripButton.Name = "fillByMarcaToolStripButton";
            this.fillByMarcaToolStripButton.Size = new System.Drawing.Size(72, 22);
            this.fillByMarcaToolStripButton.Text = "FillByMarca";
            // 
            // fillByCategoriaToolStrip
            // 
            this.fillByCategoriaToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByCategoriaToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaToolStripLabel,
            this.categoriaToolStripTextBox,
            this.fillByCategoriaToolStripButton});
            this.fillByCategoriaToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillByCategoriaToolStrip.Name = "fillByCategoriaToolStrip";
            this.fillByCategoriaToolStrip.Size = new System.Drawing.Size(600, 25);
            this.fillByCategoriaToolStrip.TabIndex = 2;
            this.fillByCategoriaToolStrip.Text = "fillByCategoriaToolStrip";
            // 
            // categoriaToolStripLabel
            // 
            this.categoriaToolStripLabel.Name = "categoriaToolStripLabel";
            this.categoriaToolStripLabel.Size = new System.Drawing.Size(61, 22);
            this.categoriaToolStripLabel.Text = "Categoria:";
            // 
            // categoriaToolStripTextBox
            // 
            this.categoriaToolStripTextBox.Name = "categoriaToolStripTextBox";
            this.categoriaToolStripTextBox.Size = new System.Drawing.Size(76, 25);
            // 
            // fillByCategoriaToolStripButton
            // 
            this.fillByCategoriaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByCategoriaToolStripButton.Name = "fillByCategoriaToolStripButton";
            this.fillByCategoriaToolStripButton.Size = new System.Drawing.Size(90, 22);
            this.fillByCategoriaToolStripButton.Text = "FillByCategoria";
            this.fillByCategoriaToolStripButton.Click += new System.EventHandler(this.fillByCategoriaToolStripButton_Click);
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(22, 280);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "Agregar Producto Seleccionado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 305);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cantidad a agregar:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(382, 301);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(90, 26);
            this.numericUpDown1.TabIndex = 5;
            // 
            // FormAgregarNuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fillByCategoriaToolStrip);
            this.Controls.Add(this.fillByNombre2ToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAgregarNuevoProducto";
            this.Text = "FormAgregarNuevoProducto";
            this.Load += new System.EventHandler(this.FormAgregarNuevoProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosTianguis)).EndInit();
            this.fillByNombre2ToolStrip.ResumeLayout(false);
            this.fillByNombre2ToolStrip.PerformLayout();
            this.fillByCategoriaToolStrip.ResumeLayout(false);
            this.fillByCategoriaToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DatosTianguis datosTianguis;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private DatosTianguisTableAdapters.ProductoTableAdapter productoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn productoActivoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ToolStrip fillByNombre2ToolStrip;
        private System.Windows.Forms.ToolStripLabel nombreToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nombreToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByNombre2ToolStripButton;
        private System.Windows.Forms.ToolStripLabel marcaToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox marcaToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByMarcaToolStripButton;
        private System.Windows.Forms.ToolStrip fillByCategoriaToolStrip;
        private System.Windows.Forms.ToolStripLabel categoriaToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox categoriaToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByCategoriaToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}