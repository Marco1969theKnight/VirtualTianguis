namespace TheVirtualTianguisProyect.Formas.Almacen
{
    partial class NuevoProveedor
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
            this.nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.agregar = new System.Windows.Forms.Button();
            this.dgproveedor = new System.Windows.Forms.DataGridView();
            this.datosTianguis = new TheVirtualTianguisProyect.DatosTianguis();
            this.datosTianguisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedorTableAdapter = new TheVirtualTianguisProyect.DatosTianguisTableAdapters.ProveedorTableAdapter();
            this.idproveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorActivoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgproveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosTianguis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosTianguisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(46, 241);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(287, 20);
            this.nombre.TabIndex = 0;
            this.nombre.TextChanged += new System.EventHandler(this.nombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre ";
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(503, 281);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 23);
            this.agregar.TabIndex = 2;
            this.agregar.Text = "Aceptar";
            this.agregar.UseVisualStyleBackColor = true;
            // 
            // dgproveedor
            // 
            this.dgproveedor.AutoGenerateColumns = false;
            this.dgproveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgproveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproveedorDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.proveedorActivoDataGridViewCheckBoxColumn});
            this.dgproveedor.DataSource = this.proveedorBindingSource;
            this.dgproveedor.Location = new System.Drawing.Point(32, 12);
            this.dgproveedor.Name = "dgproveedor";
            this.dgproveedor.Size = new System.Drawing.Size(546, 176);
            this.dgproveedor.TabIndex = 3;
            // 
            // datosTianguis
            // 
            this.datosTianguis.DataSetName = "DatosTianguis";
            this.datosTianguis.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datosTianguisBindingSource
            // 
            this.datosTianguisBindingSource.DataSource = this.datosTianguis;
            this.datosTianguisBindingSource.Position = 0;
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "Proveedor";
            this.proveedorBindingSource.DataSource = this.datosTianguisBindingSource;
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // idproveedorDataGridViewTextBoxColumn
            // 
            this.idproveedorDataGridViewTextBoxColumn.DataPropertyName = "Id_proveedor";
            this.idproveedorDataGridViewTextBoxColumn.HeaderText = "Id_proveedor";
            this.idproveedorDataGridViewTextBoxColumn.Name = "idproveedorDataGridViewTextBoxColumn";
            this.idproveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // proveedorActivoDataGridViewCheckBoxColumn
            // 
            this.proveedorActivoDataGridViewCheckBoxColumn.DataPropertyName = "ProveedorActivo";
            this.proveedorActivoDataGridViewCheckBoxColumn.HeaderText = "ProveedorActivo";
            this.proveedorActivoDataGridViewCheckBoxColumn.Name = "proveedorActivoDataGridViewCheckBoxColumn";
            // 
            // NuevoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 316);
            this.Controls.Add(this.dgproveedor);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombre);
            this.Name = "NuevoProveedor";
            this.Text = "Nuevo Proveedor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgproveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosTianguis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosTianguisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.DataGridView dgproveedor;
        private System.Windows.Forms.BindingSource datosTianguisBindingSource;
        private DatosTianguis datosTianguis;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private DatosTianguisTableAdapters.ProveedorTableAdapter proveedorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn proveedorActivoDataGridViewCheckBoxColumn;
    }
}