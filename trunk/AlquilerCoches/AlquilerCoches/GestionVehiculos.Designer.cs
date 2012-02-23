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
            this.TRadioButtonRevision = new System.Windows.Forms.RadioButton();
            this.TLabelEstado = new System.Windows.Forms.Label();
            this.TRadioButtonEstado = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TTextBoxPrecioAlquiler = new System.Windows.Forms.TextBox();
            this.TLabelPrecioAlquiler = new System.Windows.Forms.Label();
            this.TTextBoxPrecioVenta = new System.Windows.Forms.TextBox();
            this.TLabelPrecioVenta = new System.Windows.Forms.Label();
            this.TextBoxPrecioCompra = new System.Windows.Forms.TextBox();
            this.TLabelPrecioCompra = new System.Windows.Forms.Label();
            this.TTextBoxAnyo = new System.Windows.Forms.TextBox();
            this.TLabelAnyo = new System.Windows.Forms.Label();
            this.TextBoxMatricula = new System.Windows.Forms.TextBox();
            this.TLabelMatricula = new System.Windows.Forms.Label();
            this.TLabelMarcas = new System.Windows.Forms.Label();
            this.TLabelModelos = new System.Windows.Forms.Label();
            this.TLabelMatriculas = new System.Windows.Forms.Label();
            this.TButtonEditar = new System.Windows.Forms.Button();
            this.TButtonAnyadir = new System.Windows.Forms.Button();
            this.TButtonOK = new System.Windows.Forms.Button();
            this.TButtonCancelar = new System.Windows.Forms.Button();
            this.TButtonBuscar = new System.Windows.Forms.Button();
            this.TTextBoxMarca = new System.Windows.Forms.TextBox();
            this.TLabel = new System.Windows.Forms.Label();
            this.TTextBoxModelo = new System.Windows.Forms.TextBox();
            this.TLabelModelo = new System.Windows.Forms.Label();
            this.TGroupBoxDatosVehiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TListViewMarca
            // 
            this.TListViewMarca.Location = new System.Drawing.Point(45, 62);
            this.TListViewMarca.Name = "TListViewMarca";
            this.TListViewMarca.Size = new System.Drawing.Size(192, 93);
            this.TListViewMarca.TabIndex = 1;
            this.TListViewMarca.UseCompatibleStateImageBehavior = false;
            this.TListViewMarca.SelectedIndexChanged += new System.EventHandler(this.TListViewMarca_SelectedIndexChanged);
            // 
            // TListViewModelo
            // 
            this.TListViewModelo.Location = new System.Drawing.Point(265, 62);
            this.TListViewModelo.Name = "TListViewModelo";
            this.TListViewModelo.Size = new System.Drawing.Size(192, 93);
            this.TListViewModelo.TabIndex = 2;
            this.TListViewModelo.UseCompatibleStateImageBehavior = false;
            // 
            // TListViewMatriculas
            // 
            this.TListViewMatriculas.Location = new System.Drawing.Point(487, 62);
            this.TListViewMatriculas.Name = "TListViewMatriculas";
            this.TListViewMatriculas.Size = new System.Drawing.Size(192, 93);
            this.TListViewMatriculas.TabIndex = 3;
            this.TListViewMatriculas.UseCompatibleStateImageBehavior = false;
            // 
            // TGroupBoxDatosVehiculo
            // 
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TTextBoxModelo);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TLabelModelo);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TTextBoxMarca);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TLabel);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TButtonCancelar);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TRadioButtonRevision);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TButtonOK);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TLabelEstado);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TRadioButtonEstado);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.pictureBox1);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TTextBoxPrecioAlquiler);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TLabelPrecioAlquiler);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TTextBoxPrecioVenta);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TLabelPrecioVenta);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TextBoxPrecioCompra);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TLabelPrecioCompra);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TTextBoxAnyo);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TLabelAnyo);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TextBoxMatricula);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TLabelMatricula);
            this.TGroupBoxDatosVehiculo.Location = new System.Drawing.Point(238, 177);
            this.TGroupBoxDatosVehiculo.Name = "TGroupBoxDatosVehiculo";
            this.TGroupBoxDatosVehiculo.Size = new System.Drawing.Size(441, 266);
            this.TGroupBoxDatosVehiculo.TabIndex = 19;
            this.TGroupBoxDatosVehiculo.TabStop = false;
            this.TGroupBoxDatosVehiculo.Text = "DatosVehiculo";
            this.TGroupBoxDatosVehiculo.Enter += new System.EventHandler(this.TGroupBoxDatosVehiculo_Enter);
            // 
            // TRadioButtonRevision
            // 
            this.TRadioButtonRevision.AutoSize = true;
            this.TRadioButtonRevision.Location = new System.Drawing.Point(208, 208);
            this.TRadioButtonRevision.Name = "TRadioButtonRevision";
            this.TRadioButtonRevision.Size = new System.Drawing.Size(66, 17);
            this.TRadioButtonRevision.TabIndex = 34;
            this.TRadioButtonRevision.TabStop = true;
            this.TRadioButtonRevision.Text = "Revision";
            this.TRadioButtonRevision.UseVisualStyleBackColor = true;
            // 
            // TLabelEstado
            // 
            this.TLabelEstado.AutoSize = true;
            this.TLabelEstado.Location = new System.Drawing.Point(80, 210);
            this.TLabelEstado.Name = "TLabelEstado";
            this.TLabelEstado.Size = new System.Drawing.Size(40, 13);
            this.TLabelEstado.TabIndex = 33;
            this.TLabelEstado.Text = "Estado";
            // 
            // TRadioButtonEstado
            // 
            this.TRadioButtonEstado.AutoSize = true;
            this.TRadioButtonEstado.Location = new System.Drawing.Point(128, 208);
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
            // TTextBoxPrecioAlquiler
            // 
            this.TTextBoxPrecioAlquiler.Location = new System.Drawing.Point(128, 182);
            this.TTextBoxPrecioAlquiler.Name = "TTextBoxPrecioAlquiler";
            this.TTextBoxPrecioAlquiler.Size = new System.Drawing.Size(100, 20);
            this.TTextBoxPrecioAlquiler.TabIndex = 28;
            // 
            // TLabelPrecioAlquiler
            // 
            this.TLabelPrecioAlquiler.AutoSize = true;
            this.TLabelPrecioAlquiler.Location = new System.Drawing.Point(49, 189);
            this.TLabelPrecioAlquiler.Name = "TLabelPrecioAlquiler";
            this.TLabelPrecioAlquiler.Size = new System.Drawing.Size(71, 13);
            this.TLabelPrecioAlquiler.TabIndex = 27;
            this.TLabelPrecioAlquiler.Text = "PrecioAlquiler";
            // 
            // TTextBoxPrecioVenta
            // 
            this.TTextBoxPrecioVenta.Location = new System.Drawing.Point(128, 156);
            this.TTextBoxPrecioVenta.Name = "TTextBoxPrecioVenta";
            this.TTextBoxPrecioVenta.Size = new System.Drawing.Size(100, 20);
            this.TTextBoxPrecioVenta.TabIndex = 26;
            // 
            // TLabelPrecioVenta
            // 
            this.TLabelPrecioVenta.AutoSize = true;
            this.TLabelPrecioVenta.Location = new System.Drawing.Point(55, 163);
            this.TLabelPrecioVenta.Name = "TLabelPrecioVenta";
            this.TLabelPrecioVenta.Size = new System.Drawing.Size(65, 13);
            this.TLabelPrecioVenta.TabIndex = 25;
            this.TLabelPrecioVenta.Text = "PrecioVenta";
            // 
            // TextBoxPrecioCompra
            // 
            this.TextBoxPrecioCompra.Location = new System.Drawing.Point(128, 131);
            this.TextBoxPrecioCompra.Name = "TextBoxPrecioCompra";
            this.TextBoxPrecioCompra.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPrecioCompra.TabIndex = 24;
            // 
            // TLabelPrecioCompra
            // 
            this.TLabelPrecioCompra.AutoSize = true;
            this.TLabelPrecioCompra.Location = new System.Drawing.Point(47, 138);
            this.TLabelPrecioCompra.Name = "TLabelPrecioCompra";
            this.TLabelPrecioCompra.Size = new System.Drawing.Size(73, 13);
            this.TLabelPrecioCompra.TabIndex = 23;
            this.TLabelPrecioCompra.Text = "PrecioCompra";
            // 
            // TTextBoxAnyo
            // 
            this.TTextBoxAnyo.Location = new System.Drawing.Point(128, 105);
            this.TTextBoxAnyo.Name = "TTextBoxAnyo";
            this.TTextBoxAnyo.Size = new System.Drawing.Size(100, 20);
            this.TTextBoxAnyo.TabIndex = 22;
            // 
            // TLabelAnyo
            // 
            this.TLabelAnyo.AutoSize = true;
            this.TLabelAnyo.Location = new System.Drawing.Point(89, 112);
            this.TLabelAnyo.Name = "TLabelAnyo";
            this.TLabelAnyo.Size = new System.Drawing.Size(31, 13);
            this.TLabelAnyo.TabIndex = 21;
            this.TLabelAnyo.Text = "Anyo";
            // 
            // TextBoxMatricula
            // 
            this.TextBoxMatricula.Location = new System.Drawing.Point(128, 23);
            this.TextBoxMatricula.Name = "TextBoxMatricula";
            this.TextBoxMatricula.Size = new System.Drawing.Size(100, 20);
            this.TextBoxMatricula.TabIndex = 20;
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
            // TLabelMarcas
            // 
            this.TLabelMarcas.AutoSize = true;
            this.TLabelMarcas.Location = new System.Drawing.Point(45, 46);
            this.TLabelMarcas.Name = "TLabelMarcas";
            this.TLabelMarcas.Size = new System.Drawing.Size(42, 13);
            this.TLabelMarcas.TabIndex = 20;
            this.TLabelMarcas.Text = "Marcas";
            // 
            // TLabelModelos
            // 
            this.TLabelModelos.AutoSize = true;
            this.TLabelModelos.Location = new System.Drawing.Point(265, 46);
            this.TLabelModelos.Name = "TLabelModelos";
            this.TLabelModelos.Size = new System.Drawing.Size(47, 13);
            this.TLabelModelos.TabIndex = 21;
            this.TLabelModelos.Text = "Modelos";
            // 
            // TLabelMatriculas
            // 
            this.TLabelMatriculas.AutoSize = true;
            this.TLabelMatriculas.Location = new System.Drawing.Point(487, 46);
            this.TLabelMatriculas.Name = "TLabelMatriculas";
            this.TLabelMatriculas.Size = new System.Drawing.Size(55, 13);
            this.TLabelMatriculas.TabIndex = 22;
            this.TLabelMatriculas.Text = "Matriculas";
            // 
            // TButtonEditar
            // 
            this.TButtonEditar.Location = new System.Drawing.Point(70, 280);
            this.TButtonEditar.Name = "TButtonEditar";
            this.TButtonEditar.Size = new System.Drawing.Size(75, 23);
            this.TButtonEditar.TabIndex = 23;
            this.TButtonEditar.Text = "Editar";
            this.TButtonEditar.UseVisualStyleBackColor = true;
            // 
            // TButtonAnyadir
            // 
            this.TButtonAnyadir.Location = new System.Drawing.Point(70, 309);
            this.TButtonAnyadir.Name = "TButtonAnyadir";
            this.TButtonAnyadir.Size = new System.Drawing.Size(75, 23);
            this.TButtonAnyadir.TabIndex = 24;
            this.TButtonAnyadir.Text = "Anyadir";
            this.TButtonAnyadir.UseVisualStyleBackColor = true;
            // 
            // TButtonOK
            // 
            this.TButtonOK.Location = new System.Drawing.Point(285, 237);
            this.TButtonOK.Name = "TButtonOK";
            this.TButtonOK.Size = new System.Drawing.Size(75, 23);
            this.TButtonOK.TabIndex = 25;
            this.TButtonOK.Text = "OK";
            this.TButtonOK.UseVisualStyleBackColor = true;
            // 
            // TButtonCancelar
            // 
            this.TButtonCancelar.Location = new System.Drawing.Point(366, 237);
            this.TButtonCancelar.Name = "TButtonCancelar";
            this.TButtonCancelar.Size = new System.Drawing.Size(75, 23);
            this.TButtonCancelar.TabIndex = 26;
            this.TButtonCancelar.Text = "Cancelar";
            this.TButtonCancelar.UseVisualStyleBackColor = true;
            // 
            // TButtonBuscar
            // 
            this.TButtonBuscar.Location = new System.Drawing.Point(70, 251);
            this.TButtonBuscar.Name = "TButtonBuscar";
            this.TButtonBuscar.Size = new System.Drawing.Size(75, 23);
            this.TButtonBuscar.TabIndex = 25;
            this.TButtonBuscar.Text = "Buscar";
            this.TButtonBuscar.UseVisualStyleBackColor = true;
            // 
            // TTextBoxMarca
            // 
            this.TTextBoxMarca.Location = new System.Drawing.Point(128, 49);
            this.TTextBoxMarca.Name = "TTextBoxMarca";
            this.TTextBoxMarca.Size = new System.Drawing.Size(100, 20);
            this.TTextBoxMarca.TabIndex = 36;
            // 
            // TLabel
            // 
            this.TLabel.AutoSize = true;
            this.TLabel.Location = new System.Drawing.Point(83, 56);
            this.TLabel.Name = "TLabel";
            this.TLabel.Size = new System.Drawing.Size(37, 13);
            this.TLabel.TabIndex = 35;
            this.TLabel.Text = "Marca";
            this.TLabel.Click += new System.EventHandler(this.TLabel_Click);
            // 
            // TTextBoxModelo
            // 
            this.TTextBoxModelo.Location = new System.Drawing.Point(128, 79);
            this.TTextBoxModelo.Name = "TTextBoxModelo";
            this.TTextBoxModelo.Size = new System.Drawing.Size(100, 20);
            this.TTextBoxModelo.TabIndex = 38;
            // 
            // TLabelModelo
            // 
            this.TLabelModelo.AutoSize = true;
            this.TLabelModelo.Location = new System.Drawing.Point(78, 84);
            this.TLabelModelo.Name = "TLabelModelo";
            this.TLabelModelo.Size = new System.Drawing.Size(42, 13);
            this.TLabelModelo.TabIndex = 37;
            this.TLabelModelo.Text = "Modelo";
            // 
            // GestionVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 455);
            this.Controls.Add(this.TButtonBuscar);
            this.Controls.Add(this.TButtonAnyadir);
            this.Controls.Add(this.TButtonEditar);
            this.Controls.Add(this.TLabelMatriculas);
            this.Controls.Add(this.TLabelModelos);
            this.Controls.Add(this.TLabelMarcas);
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
        private System.Windows.Forms.TextBox TTextBoxPrecioAlquiler;
        private System.Windows.Forms.Label TLabelPrecioAlquiler;
        private System.Windows.Forms.TextBox TTextBoxPrecioVenta;
        private System.Windows.Forms.Label TLabelPrecioVenta;
        private System.Windows.Forms.TextBox TextBoxPrecioCompra;
        private System.Windows.Forms.Label TLabelPrecioCompra;
        private System.Windows.Forms.TextBox TTextBoxAnyo;
        private System.Windows.Forms.Label TLabelAnyo;
        private System.Windows.Forms.TextBox TextBoxMatricula;
        private System.Windows.Forms.Label TLabelMatricula;
        private System.Windows.Forms.Label TLabelMarcas;
        private System.Windows.Forms.Label TLabelModelos;
        private System.Windows.Forms.Label TLabelMatriculas;
        private System.Windows.Forms.Button TButtonEditar;
        private System.Windows.Forms.Button TButtonAnyadir;
        private System.Windows.Forms.Button TButtonOK;
        private System.Windows.Forms.Button TButtonCancelar;
        private System.Windows.Forms.RadioButton TRadioButtonRevision;
        private System.Windows.Forms.TextBox TTextBoxMarca;
        private System.Windows.Forms.Label TLabel;
        private System.Windows.Forms.Button TButtonBuscar;
        private System.Windows.Forms.TextBox TTextBoxModelo;
        private System.Windows.Forms.Label TLabelModelo;
    }
}