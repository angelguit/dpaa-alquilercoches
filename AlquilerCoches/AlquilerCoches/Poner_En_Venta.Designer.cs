namespace AlquilerCoches
{
    partial class Poner_En_Venta
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
            this.TListBoxModelo = new System.Windows.Forms.ListBox();
            this.TLabelModeloVehiculo = new System.Windows.Forms.Label();
            this.TListBoxVehiculo = new System.Windows.Forms.ListBox();
            this.TLabelNid = new System.Windows.Forms.Label();
            this.TLabelKm = new System.Windows.Forms.Label();
            this.TLabelAno = new System.Windows.Forms.Label();
            this.TTextBoxNid = new System.Windows.Forms.TextBox();
            this.TTextBoxKm = new System.Windows.Forms.TextBox();
            this.TTextBoxAno = new System.Windows.Forms.TextBox();
            this.TLabelPrecioAlquiler = new System.Windows.Forms.Label();
            this.TTextBoxPrecioAlquiler = new System.Windows.Forms.TextBox();
            this.TLabelPrecioVenta = new System.Windows.Forms.Label();
            this.TTextBoxPrecioVenta = new System.Windows.Forms.TextBox();
            this.TTextBoxGarantia = new System.Windows.Forms.TextBox();
            this.TLabelGarantia = new System.Windows.Forms.Label();
            this.TPictureBoxImagen = new System.Windows.Forms.PictureBox();
            this.TLabelPonerEnVenta = new System.Windows.Forms.Label();
            this.TButtonAtras = new System.Windows.Forms.Button();
            this.TButtonVender = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TPictureBoxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // TListBoxModelo
            // 
            this.TListBoxModelo.Cursor = System.Windows.Forms.Cursors.Default;
            this.TListBoxModelo.FormattingEnabled = true;
            this.TListBoxModelo.Location = new System.Drawing.Point(15, 65);
            this.TListBoxModelo.Name = "TListBoxModelo";
            this.TListBoxModelo.Size = new System.Drawing.Size(85, 212);
            this.TListBoxModelo.TabIndex = 0;
            // 
            // TLabelModeloVehiculo
            // 
            this.TLabelModeloVehiculo.AutoSize = true;
            this.TLabelModeloVehiculo.Location = new System.Drawing.Point(12, 39);
            this.TLabelModeloVehiculo.Name = "TLabelModeloVehiculo";
            this.TLabelModeloVehiculo.Size = new System.Drawing.Size(88, 13);
            this.TLabelModeloVehiculo.TabIndex = 1;
            this.TLabelModeloVehiculo.Text = "Modelo Vehículo";
            // 
            // TListBoxVehiculo
            // 
            this.TListBoxVehiculo.FormattingEnabled = true;
            this.TListBoxVehiculo.Location = new System.Drawing.Point(119, 65);
            this.TListBoxVehiculo.Name = "TListBoxVehiculo";
            this.TListBoxVehiculo.Size = new System.Drawing.Size(85, 212);
            this.TListBoxVehiculo.TabIndex = 3;
            // 
            // TLabelNid
            // 
            this.TLabelNid.AutoSize = true;
            this.TLabelNid.Location = new System.Drawing.Point(245, 39);
            this.TLabelNid.Name = "TLabelNid";
            this.TLabelNid.Size = new System.Drawing.Size(33, 13);
            this.TLabelNid.TabIndex = 4;
            this.TLabelNid.Text = "Nº ID";
            // 
            // TLabelKm
            // 
            this.TLabelKm.AutoSize = true;
            this.TLabelKm.Location = new System.Drawing.Point(255, 65);
            this.TLabelKm.Name = "TLabelKm";
            this.TLabelKm.Size = new System.Drawing.Size(23, 13);
            this.TLabelKm.TabIndex = 5;
            this.TLabelKm.Text = "KM";
            this.TLabelKm.Click += new System.EventHandler(this.label3_Click);
            // 
            // TLabelAno
            // 
            this.TLabelAno.AutoSize = true;
            this.TLabelAno.Location = new System.Drawing.Point(252, 91);
            this.TLabelAno.Name = "TLabelAno";
            this.TLabelAno.Size = new System.Drawing.Size(26, 13);
            this.TLabelAno.TabIndex = 6;
            this.TLabelAno.Text = "Año";
            // 
            // TTextBoxNid
            // 
            this.TTextBoxNid.Location = new System.Drawing.Point(284, 39);
            this.TTextBoxNid.Name = "TTextBoxNid";
            this.TTextBoxNid.Size = new System.Drawing.Size(117, 20);
            this.TTextBoxNid.TabIndex = 7;
            // 
            // TTextBoxKm
            // 
            this.TTextBoxKm.Location = new System.Drawing.Point(284, 65);
            this.TTextBoxKm.Name = "TTextBoxKm";
            this.TTextBoxKm.Size = new System.Drawing.Size(117, 20);
            this.TTextBoxKm.TabIndex = 8;
            // 
            // TTextBoxAno
            // 
            this.TTextBoxAno.Location = new System.Drawing.Point(284, 91);
            this.TTextBoxAno.Name = "TTextBoxAno";
            this.TTextBoxAno.Size = new System.Drawing.Size(117, 20);
            this.TTextBoxAno.TabIndex = 9;
            // 
            // TLabelPrecioAlquiler
            // 
            this.TLabelPrecioAlquiler.AutoSize = true;
            this.TLabelPrecioAlquiler.Location = new System.Drawing.Point(223, 117);
            this.TLabelPrecioAlquiler.Name = "TLabelPrecioAlquiler";
            this.TLabelPrecioAlquiler.Size = new System.Drawing.Size(55, 13);
            this.TLabelPrecioAlquiler.TabIndex = 10;
            this.TLabelPrecioAlquiler.Text = "Precio Alq";
            // 
            // TTextBoxPrecioAlquiler
            // 
            this.TTextBoxPrecioAlquiler.Location = new System.Drawing.Point(284, 117);
            this.TTextBoxPrecioAlquiler.Name = "TTextBoxPrecioAlquiler";
            this.TTextBoxPrecioAlquiler.Size = new System.Drawing.Size(117, 20);
            this.TTextBoxPrecioAlquiler.TabIndex = 11;
            // 
            // TLabelPrecioVenta
            // 
            this.TLabelPrecioVenta.AutoSize = true;
            this.TLabelPrecioVenta.Location = new System.Drawing.Point(210, 143);
            this.TLabelPrecioVenta.Name = "TLabelPrecioVenta";
            this.TLabelPrecioVenta.Size = new System.Drawing.Size(68, 13);
            this.TLabelPrecioVenta.TabIndex = 12;
            this.TLabelPrecioVenta.Text = "Precio Venta";
            // 
            // TTextBoxPrecioVenta
            // 
            this.TTextBoxPrecioVenta.Location = new System.Drawing.Point(284, 143);
            this.TTextBoxPrecioVenta.Name = "TTextBoxPrecioVenta";
            this.TTextBoxPrecioVenta.Size = new System.Drawing.Size(117, 20);
            this.TTextBoxPrecioVenta.TabIndex = 13;
            // 
            // TTextBoxGarantia
            // 
            this.TTextBoxGarantia.Location = new System.Drawing.Point(284, 169);
            this.TTextBoxGarantia.Name = "TTextBoxGarantia";
            this.TTextBoxGarantia.Size = new System.Drawing.Size(117, 20);
            this.TTextBoxGarantia.TabIndex = 14;
            // 
            // TLabelGarantia
            // 
            this.TLabelGarantia.AutoSize = true;
            this.TLabelGarantia.Location = new System.Drawing.Point(229, 169);
            this.TLabelGarantia.Name = "TLabelGarantia";
            this.TLabelGarantia.Size = new System.Drawing.Size(49, 13);
            this.TLabelGarantia.TabIndex = 15;
            this.TLabelGarantia.Text = "Garantía";
            // 
            // TPictureBoxImagen
            // 
            this.TPictureBoxImagen.Location = new System.Drawing.Point(229, 208);
            this.TPictureBoxImagen.Name = "TPictureBoxImagen";
            this.TPictureBoxImagen.Size = new System.Drawing.Size(172, 61);
            this.TPictureBoxImagen.TabIndex = 16;
            this.TPictureBoxImagen.TabStop = false;
            // 
            // TLabelPonerEnVenta
            // 
            this.TLabelPonerEnVenta.AutoSize = true;
            this.TLabelPonerEnVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TLabelPonerEnVenta.Location = new System.Drawing.Point(15, 13);
            this.TLabelPonerEnVenta.Name = "TLabelPonerEnVenta";
            this.TLabelPonerEnVenta.Size = new System.Drawing.Size(141, 16);
            this.TLabelPonerEnVenta.TabIndex = 17;
            this.TLabelPonerEnVenta.Text = "PONER EN VENTA";
            // 
            // TButtonAtras
            // 
            this.TButtonAtras.Location = new System.Drawing.Point(229, 288);
            this.TButtonAtras.Name = "TButtonAtras";
            this.TButtonAtras.Size = new System.Drawing.Size(75, 23);
            this.TButtonAtras.TabIndex = 18;
            this.TButtonAtras.Text = "Atrás";
            this.TButtonAtras.UseVisualStyleBackColor = true;
            // 
            // TButtonVender
            // 
            this.TButtonVender.Location = new System.Drawing.Point(325, 288);
            this.TButtonVender.Name = "TButtonVender";
            this.TButtonVender.Size = new System.Drawing.Size(75, 23);
            this.TButtonVender.TabIndex = 19;
            this.TButtonVender.Text = "Vender";
            this.TButtonVender.UseVisualStyleBackColor = true;
            // 
            // Gestion_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 327);
            this.Controls.Add(this.TButtonVender);
            this.Controls.Add(this.TButtonAtras);
            this.Controls.Add(this.TLabelPonerEnVenta);
            this.Controls.Add(this.TPictureBoxImagen);
            this.Controls.Add(this.TLabelGarantia);
            this.Controls.Add(this.TTextBoxGarantia);
            this.Controls.Add(this.TTextBoxPrecioVenta);
            this.Controls.Add(this.TLabelPrecioVenta);
            this.Controls.Add(this.TTextBoxPrecioAlquiler);
            this.Controls.Add(this.TLabelPrecioAlquiler);
            this.Controls.Add(this.TTextBoxAno);
            this.Controls.Add(this.TTextBoxKm);
            this.Controls.Add(this.TTextBoxNid);
            this.Controls.Add(this.TLabelAno);
            this.Controls.Add(this.TLabelKm);
            this.Controls.Add(this.TLabelNid);
            this.Controls.Add(this.TListBoxVehiculo);
            this.Controls.Add(this.TLabelModeloVehiculo);
            this.Controls.Add(this.TListBoxModelo);
            this.Name = "Gestion_Ventas";
            this.Text = "Gestión de Ventas";
            this.Load += new System.EventHandler(this.Gestion_Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TPictureBoxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox TListBoxModelo;
        private System.Windows.Forms.Label TLabelModeloVehiculo;
        private System.Windows.Forms.ListBox TListBoxVehiculo;
        private System.Windows.Forms.Label TLabelNid;
        private System.Windows.Forms.Label TLabelKm;
        private System.Windows.Forms.Label TLabelAno;
        private System.Windows.Forms.TextBox TTextBoxNid;
        private System.Windows.Forms.TextBox TTextBoxKm;
        private System.Windows.Forms.TextBox TTextBoxAno;
        private System.Windows.Forms.Label TLabelPrecioAlquiler;
        private System.Windows.Forms.TextBox TTextBoxPrecioAlquiler;
        private System.Windows.Forms.Label TLabelPrecioVenta;
        private System.Windows.Forms.TextBox TTextBoxPrecioVenta;
        private System.Windows.Forms.TextBox TTextBoxGarantia;
        private System.Windows.Forms.Label TLabelGarantia;
        private System.Windows.Forms.PictureBox TPictureBoxImagen;
        private System.Windows.Forms.Label TLabelPonerEnVenta;
        private System.Windows.Forms.Button TButtonAtras;
        private System.Windows.Forms.Button TButtonVender;
    }
}