namespace AlquilerCoches
{
    partial class GestionPersonal
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
            this.TLabelDNI = new System.Windows.Forms.Label();
            this.TLabelNombre = new System.Windows.Forms.Label();
            this.TLabelApellidos = new System.Windows.Forms.Label();
            this.TLabelTelefono = new System.Windows.Forms.Label();
            this.TLabelCiudad = new System.Windows.Forms.Label();
            this.TLabelProvincia = new System.Windows.Forms.Label();
            this.TLabelPuestoAc = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TLabelDNI
            // 
            this.TLabelDNI.AutoSize = true;
            this.TLabelDNI.Location = new System.Drawing.Point(37, 33);
            this.TLabelDNI.Name = "TLabelDNI";
            this.TLabelDNI.Size = new System.Drawing.Size(26, 13);
            this.TLabelDNI.TabIndex = 0;
            this.TLabelDNI.Text = "DNI";
            this.TLabelDNI.Click += new System.EventHandler(this.label1_Click);
            // 
            // TLabelNombre
            // 
            this.TLabelNombre.AutoSize = true;
            this.TLabelNombre.Location = new System.Drawing.Point(28, 56);
            this.TLabelNombre.Name = "TLabelNombre";
            this.TLabelNombre.Size = new System.Drawing.Size(44, 13);
            this.TLabelNombre.TabIndex = 1;
            this.TLabelNombre.Text = "Nombre";
            this.TLabelNombre.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TLabelApellidos
            // 
            this.TLabelApellidos.AutoSize = true;
            this.TLabelApellidos.Location = new System.Drawing.Point(28, 78);
            this.TLabelApellidos.Name = "TLabelApellidos";
            this.TLabelApellidos.Size = new System.Drawing.Size(49, 13);
            this.TLabelApellidos.TabIndex = 2;
            this.TLabelApellidos.Text = "Apellidos";
            // 
            // TLabelTelefono
            // 
            this.TLabelTelefono.AutoSize = true;
            this.TLabelTelefono.Location = new System.Drawing.Point(28, 100);
            this.TLabelTelefono.Name = "TLabelTelefono";
            this.TLabelTelefono.Size = new System.Drawing.Size(49, 13);
            this.TLabelTelefono.TabIndex = 3;
            this.TLabelTelefono.Text = "Telefono";
            // 
            // TLabelCiudad
            // 
            this.TLabelCiudad.AutoSize = true;
            this.TLabelCiudad.Location = new System.Drawing.Point(28, 122);
            this.TLabelCiudad.Name = "TLabelCiudad";
            this.TLabelCiudad.Size = new System.Drawing.Size(40, 13);
            this.TLabelCiudad.TabIndex = 4;
            this.TLabelCiudad.Text = "Ciudad";
            // 
            // TLabelProvincia
            // 
            this.TLabelProvincia.AutoSize = true;
            this.TLabelProvincia.Location = new System.Drawing.Point(28, 147);
            this.TLabelProvincia.Name = "TLabelProvincia";
            this.TLabelProvincia.Size = new System.Drawing.Size(51, 13);
            this.TLabelProvincia.TabIndex = 5;
            this.TLabelProvincia.Text = "Provincia";
            // 
            // TLabelPuestoAc
            // 
            this.TLabelPuestoAc.AutoSize = true;
            this.TLabelPuestoAc.Location = new System.Drawing.Point(28, 170);
            this.TLabelPuestoAc.Name = "TLabelPuestoAc";
            this.TLabelPuestoAc.Size = new System.Drawing.Size(56, 13);
            this.TLabelPuestoAc.TabIndex = 6;
            this.TLabelPuestoAc.Text = "Puesto Ac";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AlquilerCoches.Properties.Resources.Desconocido;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(497, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 85);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // GestionPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 303);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TLabelPuestoAc);
            this.Controls.Add(this.TLabelProvincia);
            this.Controls.Add(this.TLabelCiudad);
            this.Controls.Add(this.TLabelTelefono);
            this.Controls.Add(this.TLabelApellidos);
            this.Controls.Add(this.TLabelNombre);
            this.Controls.Add(this.TLabelDNI);
            this.Name = "GestionPersonal";
            this.Text = "GestionPersonal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TLabelDNI;
        private System.Windows.Forms.Label TLabelNombre;
        private System.Windows.Forms.Label TLabelApellidos;
        private System.Windows.Forms.Label TLabelTelefono;
        private System.Windows.Forms.Label TLabelCiudad;
        private System.Windows.Forms.Label TLabelProvincia;
        private System.Windows.Forms.Label TLabelPuestoAc;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}