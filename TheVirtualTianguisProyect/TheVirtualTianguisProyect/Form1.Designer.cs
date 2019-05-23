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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VirtualTianguis));
            this.NomUsuLabel = new System.Windows.Forms.Label();
            this.ConLabel = new System.Windows.Forms.Label();
            this.LogoEmpresa = new System.Windows.Forms.PictureBox();
            this.NomUsuTB = new System.Windows.Forms.TextBox();
            this.ConTB = new System.Windows.Forms.TextBox();
            this.RegButon = new System.Windows.Forms.Button();
            this.InButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // NomUsuLabel
            // 
            this.NomUsuLabel.AutoSize = true;
            this.NomUsuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomUsuLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.NomUsuLabel.Location = new System.Drawing.Point(262, 29);
            this.NomUsuLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NomUsuLabel.Name = "NomUsuLabel";
            this.NomUsuLabel.Size = new System.Drawing.Size(248, 31);
            this.NomUsuLabel.TabIndex = 0;
            this.NomUsuLabel.Text = "Nombre de Usuario";
            // 
            // ConLabel
            // 
            this.ConLabel.AutoSize = true;
            this.ConLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ConLabel.Location = new System.Drawing.Point(262, 128);
            this.ConLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConLabel.Name = "ConLabel";
            this.ConLabel.Size = new System.Drawing.Size(155, 31);
            this.ConLabel.TabIndex = 1;
            this.ConLabel.Text = "Contraseña";
            // 
            // LogoEmpresa
            // 
            this.LogoEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("LogoEmpresa.Image")));
            this.LogoEmpresa.Location = new System.Drawing.Point(27, 29);
            this.LogoEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.LogoEmpresa.Name = "LogoEmpresa";
            this.LogoEmpresa.Size = new System.Drawing.Size(195, 171);
            this.LogoEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoEmpresa.TabIndex = 2;
            this.LogoEmpresa.TabStop = false;
            // 
            // NomUsuTB
            // 
            this.NomUsuTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomUsuTB.Location = new System.Drawing.Point(262, 79);
            this.NomUsuTB.Margin = new System.Windows.Forms.Padding(2);
            this.NomUsuTB.Name = "NomUsuTB";
            this.NomUsuTB.Size = new System.Drawing.Size(271, 37);
            this.NomUsuTB.TabIndex = 3;
            // 
            // ConTB
            // 
            this.ConTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConTB.Location = new System.Drawing.Point(262, 177);
            this.ConTB.Margin = new System.Windows.Forms.Padding(2);
            this.ConTB.Name = "ConTB";
            this.ConTB.PasswordChar = '*';
            this.ConTB.Size = new System.Drawing.Size(271, 37);
            this.ConTB.TabIndex = 4;
            this.ConTB.UseSystemPasswordChar = true;
            this.ConTB.TextChanged += new System.EventHandler(this.ConTB_TextChanged);
            // 
            // RegButon
            // 
            this.RegButon.BackColor = System.Drawing.SystemColors.ControlDark;
            this.RegButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegButon.ForeColor = System.Drawing.SystemColors.Highlight;
            this.RegButon.Location = new System.Drawing.Point(45, 232);
            this.RegButon.Margin = new System.Windows.Forms.Padding(2);
            this.RegButon.Name = "RegButon";
            this.RegButon.Size = new System.Drawing.Size(158, 49);
            this.RegButon.TabIndex = 5;
            this.RegButon.Text = "Registrar";
            this.RegButon.UseVisualStyleBackColor = false;
            this.RegButon.Click += new System.EventHandler(this.button1_Click);
            // 
            // InButton
            // 
            this.InButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.InButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.InButton.Location = new System.Drawing.Point(310, 232);
            this.InButton.Margin = new System.Windows.Forms.Padding(2);
            this.InButton.Name = "InButton";
            this.InButton.Size = new System.Drawing.Size(158, 49);
            this.InButton.TabIndex = 6;
            this.InButton.Text = "Iniciar Sesión";
            this.InButton.UseVisualStyleBackColor = false;
            this.InButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // VirtualTianguis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 327);
            this.Controls.Add(this.InButton);
            this.Controls.Add(this.RegButon);
            this.Controls.Add(this.ConTB);
            this.Controls.Add(this.NomUsuTB);
            this.Controls.Add(this.LogoEmpresa);
            this.Controls.Add(this.ConLabel);
            this.Controls.Add(this.NomUsuLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VirtualTianguis";
            this.Text = "Virtual Tianguis";
            this.Load += new System.EventHandler(this.VirtualTianguis_Load);
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
        private System.Windows.Forms.Button InButton;
    }
}

