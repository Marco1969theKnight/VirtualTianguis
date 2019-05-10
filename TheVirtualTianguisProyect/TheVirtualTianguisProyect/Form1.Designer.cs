namespace TheVirtualTianguisProyect
{
    partial class VirtualTianguis
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.NomUsuLabel = new System.Windows.Forms.Label();
            this.ConLabel = new System.Windows.Forms.Label();
            this.LogoEmpresa = new System.Windows.Forms.PictureBox();
            this.NomUsuTB = new System.Windows.Forms.TextBox();
            this.ConTB = new System.Windows.Forms.TextBox();
            this.RegButon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // NomUsuLabel
            // 
            this.NomUsuLabel.AutoSize = true;
            this.NomUsuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomUsuLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.NomUsuLabel.Location = new System.Drawing.Point(350, 60);
            this.NomUsuLabel.Name = "NomUsuLabel";
            this.NomUsuLabel.Size = new System.Drawing.Size(312, 39);
            this.NomUsuLabel.TabIndex = 0;
            this.NomUsuLabel.Text = "Nombre de Usuario";
            // 
            // ConLabel
            // 
            this.ConLabel.AutoSize = true;
            this.ConLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ConLabel.Location = new System.Drawing.Point(350, 240);
            this.ConLabel.Name = "ConLabel";
            this.ConLabel.Size = new System.Drawing.Size(193, 39);
            this.ConLabel.TabIndex = 1;
            this.ConLabel.Text = "Contraseña";
            // 
            // LogoEmpresa
            // 
            this.LogoEmpresa.Location = new System.Drawing.Point(36, 36);
            this.LogoEmpresa.Name = "LogoEmpresa";
            this.LogoEmpresa.Size = new System.Drawing.Size(260, 210);
            this.LogoEmpresa.TabIndex = 2;
            this.LogoEmpresa.TabStop = false;
            // 
            // NomUsuTB
            // 
            this.NomUsuTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomUsuTB.Location = new System.Drawing.Point(350, 120);
            this.NomUsuTB.Name = "NomUsuTB";
            this.NomUsuTB.Size = new System.Drawing.Size(360, 45);
            this.NomUsuTB.TabIndex = 3;
            // 
            // ConTB
            // 
            this.ConTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConTB.Location = new System.Drawing.Point(350, 300);
            this.ConTB.Name = "ConTB";
            this.ConTB.PasswordChar = '*';
            this.ConTB.Size = new System.Drawing.Size(360, 45);
            this.ConTB.TabIndex = 4;
            this.ConTB.UseSystemPasswordChar = true;
            // 
            // RegButon
            // 
            this.RegButon.BackColor = System.Drawing.SystemColors.ControlDark;
            this.RegButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegButon.ForeColor = System.Drawing.SystemColors.Highlight;
            this.RegButon.Location = new System.Drawing.Point(60, 285);
            this.RegButon.Name = "RegButon";
            this.RegButon.Size = new System.Drawing.Size(210, 60);
            this.RegButon.TabIndex = 5;
            this.RegButon.Text = "Registrar";
            this.RegButon.UseVisualStyleBackColor = false;
            this.RegButon.Click += new System.EventHandler(this.button1_Click);
            // 
            // VirtualTianguis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 403);
            this.Controls.Add(this.RegButon);
            this.Controls.Add(this.ConTB);
            this.Controls.Add(this.NomUsuTB);
            this.Controls.Add(this.LogoEmpresa);
            this.Controls.Add(this.ConLabel);
            this.Controls.Add(this.NomUsuLabel);
            this.Name = "VirtualTianguis";
            this.Text = "Virtual Tianguis";
            ((System.ComponentModel.ISupportInitialize)(this.LogoEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NomUsuLabel;
        private System.Windows.Forms.Label ConLabel;
        private System.Windows.Forms.PictureBox LogoEmpresa;
        private System.Windows.Forms.TextBox NomUsuTB;
        private System.Windows.Forms.TextBox ConTB;
        private System.Windows.Forms.Button RegButon;
    }
}

