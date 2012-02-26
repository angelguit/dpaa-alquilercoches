namespace AlquilerCoches
{
    partial class Facturacion
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
            this.TLabelUsuario = new System.Windows.Forms.Label();
            this.TLabelEmpresa = new System.Windows.Forms.Label();
            this.TLabelCategoria = new System.Windows.Forms.Label();
            this.TLabelVehiculo = new System.Windows.Forms.Label();
            this.TLabelConductores = new System.Windows.Forms.Label();
            this.TLabelTarifa = new System.Windows.Forms.Label();
            this.TLabelTiempo = new System.Windows.Forms.Label();
            this.TLabelNFactura = new System.Windows.Forms.Label();
            this.TLabelPSinIva = new System.Windows.Forms.Label();
            this.TLabelTIva = new System.Windows.Forms.Label();
            this.TLabelPTotal = new System.Windows.Forms.Label();
            this.TTextBoxCategoria = new System.Windows.Forms.TextBox();
            this.TTextBoxVehiculo = new System.Windows.Forms.TextBox();
            this.TTextBoxConductores = new System.Windows.Forms.TextBox();
            this.TTextBoxTarifa = new System.Windows.Forms.TextBox();
            this.TTextBoxTiempo = new System.Windows.Forms.TextBox();
            this.TTextBoxNFactura = new System.Windows.Forms.TextBox();
            this.TTextBoxTPSinIva = new System.Windows.Forms.TextBox();
            this.TTextBoxTIva = new System.Windows.Forms.TextBox();
            this.TTextBoxPTotal = new System.Windows.Forms.TextBox();
            this.TButtonRFactura = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.SuspendLayout();
            // 
            // TLabelUsuario
            // 
            this.TLabelUsuario.AutoSize = true;
            this.TLabelUsuario.Location = new System.Drawing.Point(27, 14);
            this.TLabelUsuario.Name = "TLabelUsuario";
            this.TLabelUsuario.Size = new System.Drawing.Size(83, 13);
            this.TLabelUsuario.TabIndex = 0;
            this.TLabelUsuario.Text = "Nombre Usuario";
            // 
            // TLabelEmpresa
            // 
            this.TLabelEmpresa.AutoSize = true;
            this.TLabelEmpresa.Location = new System.Drawing.Point(271, 14);
            this.TLabelEmpresa.Name = "TLabelEmpresa";
            this.TLabelEmpresa.Size = new System.Drawing.Size(78, 13);
            this.TLabelEmpresa.TabIndex = 1;
            this.TLabelEmpresa.Text = "Datos empresa";
            // 
            // TLabelCategoria
            // 
            this.TLabelCategoria.AutoSize = true;
            this.TLabelCategoria.Location = new System.Drawing.Point(49, 56);
            this.TLabelCategoria.Name = "TLabelCategoria";
            this.TLabelCategoria.Size = new System.Drawing.Size(57, 13);
            this.TLabelCategoria.TabIndex = 2;
            this.TLabelCategoria.Text = "Categoría:";
            this.TLabelCategoria.Click += new System.EventHandler(this.TLabelCategoria_Click);
            // 
            // TLabelVehiculo
            // 
            this.TLabelVehiculo.AutoSize = true;
            this.TLabelVehiculo.Location = new System.Drawing.Point(53, 88);
            this.TLabelVehiculo.Name = "TLabelVehiculo";
            this.TLabelVehiculo.Size = new System.Drawing.Size(53, 13);
            this.TLabelVehiculo.TabIndex = 3;
            this.TLabelVehiculo.Text = "Vehículo:";
            // 
            // TLabelConductores
            // 
            this.TLabelConductores.AutoSize = true;
            this.TLabelConductores.Location = new System.Drawing.Point(36, 118);
            this.TLabelConductores.Name = "TLabelConductores";
            this.TLabelConductores.Size = new System.Drawing.Size(70, 13);
            this.TLabelConductores.TabIndex = 4;
            this.TLabelConductores.Text = "Conductores:";
            // 
            // TLabelTarifa
            // 
            this.TLabelTarifa.AutoSize = true;
            this.TLabelTarifa.Location = new System.Drawing.Point(69, 150);
            this.TLabelTarifa.Name = "TLabelTarifa";
            this.TLabelTarifa.Size = new System.Drawing.Size(37, 13);
            this.TLabelTarifa.TabIndex = 5;
            this.TLabelTarifa.Text = "Tarifa:";
            // 
            // TLabelTiempo
            // 
            this.TLabelTiempo.AutoSize = true;
            this.TLabelTiempo.Location = new System.Drawing.Point(31, 180);
            this.TLabelTiempo.Name = "TLabelTiempo";
            this.TLabelTiempo.Size = new System.Drawing.Size(75, 13);
            this.TLabelTiempo.TabIndex = 6;
            this.TLabelTiempo.Text = "Tiempo (días):";
            // 
            // TLabelNFactura
            // 
            this.TLabelNFactura.AutoSize = true;
            this.TLabelNFactura.Location = new System.Drawing.Point(216, 200);
            this.TLabelNFactura.Name = "TLabelNFactura";
            this.TLabelNFactura.Size = new System.Drawing.Size(58, 13);
            this.TLabelNFactura.TabIndex = 7;
            this.TLabelNFactura.Text = "Nº Factura";
            // 
            // TLabelPSinIva
            // 
            this.TLabelPSinIva.AutoSize = true;
            this.TLabelPSinIva.Location = new System.Drawing.Point(35, 249);
            this.TLabelPSinIva.Name = "TLabelPSinIva";
            this.TLabelPSinIva.Size = new System.Drawing.Size(75, 13);
            this.TLabelPSinIva.TabIndex = 8;
            this.TLabelPSinIva.Text = "Precio Sin IVA";
            // 
            // TLabelTIva
            // 
            this.TLabelTIva.AutoSize = true;
            this.TLabelTIva.Location = new System.Drawing.Point(163, 249);
            this.TLabelTIva.Name = "TLabelTIva";
            this.TLabelTIva.Size = new System.Drawing.Size(51, 13);
            this.TLabelTIva.TabIndex = 9;
            this.TLabelTIva.Text = "Total IVA";
            // 
            // TLabelPTotal
            // 
            this.TLabelPTotal.AutoSize = true;
            this.TLabelPTotal.Location = new System.Drawing.Point(285, 249);
            this.TLabelPTotal.Name = "TLabelPTotal";
            this.TLabelPTotal.Size = new System.Drawing.Size(64, 13);
            this.TLabelPTotal.TabIndex = 10;
            this.TLabelPTotal.Text = "Precio Total";
            // 
            // TTextBoxCategoria
            // 
            this.TTextBoxCategoria.Location = new System.Drawing.Point(118, 53);
            this.TTextBoxCategoria.Name = "TTextBoxCategoria";
            this.TTextBoxCategoria.Size = new System.Drawing.Size(61, 20);
            this.TTextBoxCategoria.TabIndex = 11;
            // 
            // TTextBoxVehiculo
            // 
            this.TTextBoxVehiculo.Location = new System.Drawing.Point(118, 85);
            this.TTextBoxVehiculo.Name = "TTextBoxVehiculo";
            this.TTextBoxVehiculo.Size = new System.Drawing.Size(61, 20);
            this.TTextBoxVehiculo.TabIndex = 12;
            // 
            // TTextBoxConductores
            // 
            this.TTextBoxConductores.Location = new System.Drawing.Point(118, 115);
            this.TTextBoxConductores.Name = "TTextBoxConductores";
            this.TTextBoxConductores.Size = new System.Drawing.Size(60, 20);
            this.TTextBoxConductores.TabIndex = 13;
            // 
            // TTextBoxTarifa
            // 
            this.TTextBoxTarifa.Location = new System.Drawing.Point(118, 147);
            this.TTextBoxTarifa.Name = "TTextBoxTarifa";
            this.TTextBoxTarifa.Size = new System.Drawing.Size(60, 20);
            this.TTextBoxTarifa.TabIndex = 14;
            // 
            // TTextBoxTiempo
            // 
            this.TTextBoxTiempo.Location = new System.Drawing.Point(118, 177);
            this.TTextBoxTiempo.Name = "TTextBoxTiempo";
            this.TTextBoxTiempo.Size = new System.Drawing.Size(61, 20);
            this.TTextBoxTiempo.TabIndex = 15;
            // 
            // TTextBoxNFactura
            // 
            this.TTextBoxNFactura.Location = new System.Drawing.Point(290, 197);
            this.TTextBoxNFactura.Name = "TTextBoxNFactura";
            this.TTextBoxNFactura.Size = new System.Drawing.Size(51, 20);
            this.TTextBoxNFactura.TabIndex = 16;
            // 
            // TTextBoxTPSinIva
            // 
            this.TTextBoxTPSinIva.Location = new System.Drawing.Point(34, 272);
            this.TTextBoxTPSinIva.Name = "TTextBoxTPSinIva";
            this.TTextBoxTPSinIva.Size = new System.Drawing.Size(76, 20);
            this.TTextBoxTPSinIva.TabIndex = 17;
            // 
            // TTextBoxTIva
            // 
            this.TTextBoxTIva.Location = new System.Drawing.Point(166, 271);
            this.TTextBoxTIva.Name = "TTextBoxTIva";
            this.TTextBoxTIva.Size = new System.Drawing.Size(48, 20);
            this.TTextBoxTIva.TabIndex = 18;
            // 
            // TTextBoxPTotal
            // 
            this.TTextBoxPTotal.Location = new System.Drawing.Point(288, 269);
            this.TTextBoxPTotal.Name = "TTextBoxPTotal";
            this.TTextBoxPTotal.Size = new System.Drawing.Size(61, 20);
            this.TTextBoxPTotal.TabIndex = 19;
            // 
            // TButtonRFactura
            // 
            this.TButtonRFactura.Location = new System.Drawing.Point(134, 305);
            this.TButtonRFactura.Name = "TButtonRFactura";
            this.TButtonRFactura.Size = new System.Drawing.Size(114, 31);
            this.TButtonRFactura.TabIndex = 20;
            this.TButtonRFactura.Text = "Realizar Factura";
            this.TButtonRFactura.UseVisualStyleBackColor = true;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(391, 348);
            this.shapeContainer1.TabIndex = 21;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(0, 1);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(391, 39);
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 348);
            this.Controls.Add(this.TButtonRFactura);
            this.Controls.Add(this.TTextBoxPTotal);
            this.Controls.Add(this.TTextBoxTIva);
            this.Controls.Add(this.TTextBoxTPSinIva);
            this.Controls.Add(this.TTextBoxNFactura);
            this.Controls.Add(this.TTextBoxTiempo);
            this.Controls.Add(this.TTextBoxTarifa);
            this.Controls.Add(this.TTextBoxConductores);
            this.Controls.Add(this.TTextBoxVehiculo);
            this.Controls.Add(this.TTextBoxCategoria);
            this.Controls.Add(this.TLabelPTotal);
            this.Controls.Add(this.TLabelTIva);
            this.Controls.Add(this.TLabelPSinIva);
            this.Controls.Add(this.TLabelNFactura);
            this.Controls.Add(this.TLabelTiempo);
            this.Controls.Add(this.TLabelTarifa);
            this.Controls.Add(this.TLabelConductores);
            this.Controls.Add(this.TLabelVehiculo);
            this.Controls.Add(this.TLabelCategoria);
            this.Controls.Add(this.TLabelEmpresa);
            this.Controls.Add(this.TLabelUsuario);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Facturacion";
            this.Text = "Facturación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TLabelUsuario;
        private System.Windows.Forms.Label TLabelEmpresa;
        private System.Windows.Forms.Label TLabelCategoria;
        private System.Windows.Forms.Label TLabelVehiculo;
        private System.Windows.Forms.Label TLabelConductores;
        private System.Windows.Forms.Label TLabelTarifa;
        private System.Windows.Forms.Label TLabelTiempo;
        private System.Windows.Forms.Label TLabelNFactura;
        private System.Windows.Forms.Label TLabelPSinIva;
        private System.Windows.Forms.Label TLabelTIva;
        private System.Windows.Forms.Label TLabelPTotal;
        private System.Windows.Forms.TextBox TTextBoxCategoria;
        private System.Windows.Forms.TextBox TTextBoxVehiculo;
        private System.Windows.Forms.TextBox TTextBoxConductores;
        private System.Windows.Forms.TextBox TTextBoxTarifa;
        private System.Windows.Forms.TextBox TTextBoxTiempo;
        private System.Windows.Forms.TextBox TTextBoxNFactura;
        private System.Windows.Forms.TextBox TTextBoxTPSinIva;
        private System.Windows.Forms.TextBox TTextBoxTIva;
        private System.Windows.Forms.TextBox TTextBoxPTotal;
        private System.Windows.Forms.Button TButtonRFactura;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
    }
}