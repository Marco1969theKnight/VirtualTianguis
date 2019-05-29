namespace TheVirtualTianguisProyect.Formas.Vender
{
    partial class FormDetalleVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetalleVenta));
            this.dgDetalleVenta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.datosTianguis = new TheVirtualTianguisProyect.DatosTianguis();
            this.detalleVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalleVentasTableAdapter = new TheVirtualTianguisProyect.DatosTianguisTableAdapters.DetalleVentasTableAdapter();
            this.idDetalleVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datosTianguis1 = new TheVirtualTianguisProyect.DatosTianguis();
            this.detalleVentasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosTianguis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosTianguis1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDetalleVenta
            // 
            this.dgDetalleVenta.AutoGenerateColumns = false;
            this.dgDetalleVenta.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetalleVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDetalleVentaDataGridViewTextBoxColumn,
            this.productoDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.noVentaDataGridViewTextBoxColumn});
            this.dgDetalleVenta.DataSource = this.detalleVentasBindingSource1;
            this.dgDetalleVenta.Location = new System.Drawing.Point(27, 49);
            this.dgDetalleVenta.Name = "dgDetalleVenta";
            this.dgDetalleVenta.Size = new System.Drawing.Size(482, 279);
            this.dgDetalleVenta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mostrandose Detalle de Venta seleccionada:";
            // 
            // datosTianguis
            // 
            this.datosTianguis.DataSetName = "DatosTianguis";
            this.datosTianguis.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detalleVentasBindingSource
            // 
            this.detalleVentasBindingSource.DataMember = "DetalleVentas";
            this.detalleVentasBindingSource.DataSource = this.datosTianguis;
            // 
            // detalleVentasTableAdapter
            // 
            this.detalleVentasTableAdapter.ClearBeforeFill = true;
            // 
            // idDetalleVentaDataGridViewTextBoxColumn
            // 
            this.idDetalleVentaDataGridViewTextBoxColumn.DataPropertyName = "IdDetalleVenta";
            this.idDetalleVentaDataGridViewTextBoxColumn.HeaderText = "IdDetalleVenta";
            this.idDetalleVentaDataGridViewTextBoxColumn.Name = "idDetalleVentaDataGridViewTextBoxColumn";
            this.idDetalleVentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productoDataGridViewTextBoxColumn
            // 
            this.productoDataGridViewTextBoxColumn.DataPropertyName = "Producto";
            this.productoDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.productoDataGridViewTextBoxColumn.Name = "productoDataGridViewTextBoxColumn";
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // noVentaDataGridViewTextBoxColumn
            // 
            this.noVentaDataGridViewTextBoxColumn.DataPropertyName = "NoVenta";
            this.noVentaDataGridViewTextBoxColumn.HeaderText = "NoVenta";
            this.noVentaDataGridViewTextBoxColumn.Name = "noVentaDataGridViewTextBoxColumn";
            // 
            // datosTianguis1
            // 
            this.datosTianguis1.DataSetName = "DatosTianguis";
            this.datosTianguis1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detalleVentasBindingSource1
            // 
            this.detalleVentasBindingSource1.DataMember = "DetalleVentas";
            this.detalleVentasBindingSource1.DataSource = this.datosTianguis1;
            // 
            // FormDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(534, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgDetalleVenta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormDetalleVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle Venta";
            this.Load += new System.EventHandler(this.FormDetalleVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosTianguis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosTianguis1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentasBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDetalleVenta;
        private System.Windows.Forms.Label label1;
        private DatosTianguis datosTianguis;
        private System.Windows.Forms.BindingSource detalleVentasBindingSource;
        private DatosTianguisTableAdapters.DetalleVentasTableAdapter detalleVentasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetalleVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noVentaDataGridViewTextBoxColumn;
        private DatosTianguis datosTianguis1;
        private System.Windows.Forms.BindingSource detalleVentasBindingSource1;
    }
}