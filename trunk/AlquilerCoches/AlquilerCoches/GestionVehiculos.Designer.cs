namespace AlquilerCoches
{
    partial class GestionVehiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionVehiculos));
            this.TListViewMarca = new System.Windows.Forms.ListView();
            this.TListViewModelo = new System.Windows.Forms.ListView();
            this.TListViewMatriculas = new System.Windows.Forms.ListView();
            this.TGroupBoxDatosVehiculo = new System.Windows.Forms.GroupBox();
            this.TLabelEstado = new System.Windows.Forms.Label();
            this.TRadioButtonEstado = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.TLabelPrecioAlquiler = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.TLabelPrecioVenta = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.TLabelPrecioCompra = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TLabelAnyo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TLabelMatricula = new System.Windows.Forms.Label();
            this.TLabelMarca = new System.Windows.Forms.Label();
            this.TLabelModelo = new System.Windows.Forms.Label();
            this.TLabelMatriculas = new System.Windows.Forms.Label();
            this.TGroupBoxDatosVehiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TListViewMarca
            // 
            this.TListViewMarca.Location = new System.Drawing.Point(12, 80);
            this.TListViewMarca.Name = "TListViewMarca";
            this.TListViewMarca.Size = new System.Drawing.Size(192, 93);
            this.TListViewMarca.TabIndex = 1;
            this.TListViewMarca.UseCompatibleStateImageBehavior = false;
            this.TListViewMarca.SelectedIndexChanged += new System.EventHandler(this.TListViewMarca_SelectedIndexChanged);
            // 
            // TListViewModelo
            // 
            this.TListViewModelo.Location = new System.Drawing.Point(12, 204);
            this.TListViewModelo.Name = "TListViewModelo";
            this.TListViewModelo.Size = new System.Drawing.Size(192, 93);
            this.TListViewModelo.TabIndex = 2;
            this.TListViewModelo.UseCompatibleStateImageBehavior = false;
            // 
            // TListViewMatriculas
            // 
            this.TListViewMatriculas.Location = new System.Drawing.Point(12, 328);
            this.TListViewMatriculas.Name = "TListViewMatriculas";
            this.TListViewMatriculas.Size = new System.Drawing.Size(192, 93);
            this.TListViewMatriculas.TabIndex = 3;
            this.TListViewMatriculas.UseCompatibleStateImageBehavior = false;
            // 
            // TGroupBoxDatosVehiculo
            // 
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TLabelEstado);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TRadioButtonEstado);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.pictureBox1);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.textBox4);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.label4);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.textBox5);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TLabelPrecioAlquiler);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.textBox6);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TLabelPrecioVenta);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.textBox3);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TLabelPrecioCompra);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.textBox2);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TLabelAnyo);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.textBox1);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TLabelMatricula);
            this.TGroupBoxDatosVehiculo.Location = new System.Drawing.Point(244, 136);
            this.TGroupBoxDatosVehiculo.Name = "TGroupBoxDatosVehiculo";
            this.TGroupBoxDatosVehiculo.Size = new System.Drawing.Size(441, 215);
            this.TGroupBoxDatosVehiculo.TabIndex = 19;
            this.TGroupBoxDatosVehiculo.TabStop = false;
            this.TGroupBoxDatosVehiculo.Text = "DatosVehiculo";
            // 
            // TLabelEstado
            // 
            this.TLabelEstado.AutoSize = true;
            this.TLabelEstado.Location = new System.Drawing.Point(80, 180);
            this.TLabelEstado.Name = "TLabelEstado";
            this.TLabelEstado.Size = new System.Drawing.Size(40, 13);
            this.TLabelEstado.TabIndex = 33;
            this.TLabelEstado.Text = "Estado";
            // 
            // TRadioButtonEstado
            // 
            this.TRadioButtonEstado.AutoSize = true;
            this.TRadioButtonEstado.Location = new System.Drawing.Point(128, 178);
            this.TRadioButtonEstado.Name = "TRadioButtonEstado";
            this.TRadioButtonEstado.Size = new System.Drawing.Size(74, 17);
            this.TRadioButtonEstado.TabIndex = 32;
            this.TRadioButtonEstado.TabStop = true;
            this.TRadioButtonEstado.Text = "Disponible";
            this.TRadioButtonEstado.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(308, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 117);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(128, 152);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "label4";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(128, 126);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 28;
            // 
            // TLabelPrecioAlquiler
            // 
            this.TLabelPrecioAlquiler.AutoSize = true;
            this.TLabelPrecioAlquiler.Location = new System.Drawing.Point(49, 133);
            this.TLabelPrecioAlquiler.Name = "TLabelPrecioAlquiler";
            this.TLabelPrecioAlquiler.Size = new System.Drawing.Size(71, 13);
            this.TLabelPrecioAlquiler.TabIndex = 27;
            this.TLabelPrecioAlquiler.Text = "PrecioAlquiler";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(128, 100);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 26;
            // 
            // TLabelPrecioVenta
            // 
            this.TLabelPrecioVenta.AutoSize = true;
            this.TLabelPrecioVenta.Location = new System.Drawing.Point(55, 107);
            this.TLabelPrecioVenta.Name = "TLabelPrecioVenta";
            this.TLabelPrecioVenta.Size = new System.Drawing.Size(65, 13);
            this.TLabelPrecioVenta.TabIndex = 25;
            this.TLabelPrecioVenta.Text = "PrecioVenta";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(128, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 24;
            // 
            // TLabelPrecioCompra
            // 
            this.TLabelPrecioCompra.AutoSize = true;
            this.TLabelPrecioCompra.Location = new System.Drawing.Point(47, 82);
            this.TLabelPrecioCompra.Name = "TLabelPrecioCompra";
            this.TLabelPrecioCompra.Size = new System.Drawing.Size(73, 13);
            this.TLabelPrecioCompra.TabIndex = 23;
            this.TLabelPrecioCompra.Text = "PrecioCompra";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(128, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 22;
            // 
            // TLabelAnyo
            // 
            this.TLabelAnyo.AutoSize = true;
            this.TLabelAnyo.Location = new System.Drawing.Point(89, 56);
            this.TLabelAnyo.Name = "TLabelAnyo";
            this.TLabelAnyo.Size = new System.Drawing.Size(31, 13);
            this.TLabelAnyo.TabIndex = 21;
            this.TLabelAnyo.Text = "Anyo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 20;
            // 
            // TLabelMatricula
            // 
            this.TLabelMatricula.AutoSize = true;
            this.TLabelMatricula.Location = new System.Drawing.Point(70, 30);
            this.TLabelMatricula.Name = "TLabelMatricula";
            this.TLabelMatricula.Size = new System.Drawing.Size(50, 13);
            this.TLabelMatricula.TabIndex = 19;
            this.TLabelMatricula.Text = "Matricula";
            // 
            // TLabelMarca
            // 
            this.TLabelMarca.AutoSize = true;
            this.TLabelMarca.Location = new System.Drawing.Point(12, 64);
            this.TLabelMarca.Name = "TLabelMarca";
            this.TLabelMarca.Size = new System.Drawing.Size(37, 13);
            this.TLabelMarca.TabIndex = 20;
            this.TLabelMarca.Text = "Marca";
            // 
            // TLabelModelo
            // 
            this.TLabelModelo.AutoSize = true;
            this.TLabelModelo.Location = new System.Drawing.Point(12, 188);
            this.TLabelModelo.Name = "TLabelModelo";
            this.TLabelModelo.Size = new System.Drawing.Size(42, 13);
            this.TLabelModelo.TabIndex = 21;
            this.TLabelModelo.Text = "Modelo";
            // 
            // TLabelMatriculas
            // 
            this.TLabelMatriculas.AutoSize = true;
            this.TLabelMatriculas.Location = new System.Drawing.Point(12, 312);
            this.TLabelMatriculas.Name = "TLabelMatriculas";
            this.TLabelMatriculas.Size = new System.Drawing.Size(55, 13);
            this.TLabelMatriculas.TabIndex = 22;
            this.TLabelMatriculas.Text = "Matriculas";
            // 
            // GestionVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 455);
            this.Controls.Add(this.TLabelMatriculas);
            this.Controls.Add(this.TLabelModelo);
            this.Controls.Add(this.TLabelMarca);
            this.Controls.Add(this.TGroupBoxDatosVehiculo);
            this.Controls.Add(this.TListViewMatriculas);
            this.Controls.Add(this.TListViewModelo);
            this.Controls.Add(this.TListViewMarca);
            this.Name = "GestionVehiculos";
            this.Text = "GestionVehiculos";
            this.TGroupBoxDatosVehiculo.ResumeLayout(false);
            this.TGroupBoxDatosVehiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView TListViewMarca;
        private System.Windows.Forms.ListView TListViewModelo;
        private System.Windows.Forms.ListView TListViewMatriculas;
        private System.Windows.Forms.GroupBox TGroupBoxDatosVehiculo;
        private System.Windows.Forms.Label TLabelEstado;
        private System.Windows.Forms.RadioButton TRadioButtonEstado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label TLabelPrecioAlquiler;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label TLabelPrecioVenta;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label TLabelPrecioCompra;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label TLabelAnyo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label TLabelMatricula;
        private System.Windows.Forms.Label TLabelMarca;
        private System.Windows.Forms.Label TLabelModelo;
        private System.Windows.Forms.Label TLabelMatriculas;
    }
}