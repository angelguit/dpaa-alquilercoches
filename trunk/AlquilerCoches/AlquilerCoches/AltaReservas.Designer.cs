namespace AlquilerCoches
{
    partial class AltaReservas
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
            this.button1 = new System.Windows.Forms.Button();
            this.TComboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.TComboBoxModelo = new System.Windows.Forms.ComboBox();
            this.TLabelCategoria = new System.Windows.Forms.Label();
            this.TLabelModelo = new System.Windows.Forms.Label();
            this.TLabelMatricula = new System.Windows.Forms.Label();
            this.TComboBoxMatricula = new System.Windows.Forms.ComboBox();
            this.TLabelConductores = new System.Windows.Forms.Label();
            this.TComboBoxConductores = new System.Windows.Forms.ComboBox();
            this.TLabelFechaInicio = new System.Windows.Forms.Label();
            this.TDateTimePickerFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.TLabelFechaFin = new System.Windows.Forms.Label();
            this.TDateTimePickerFechaFin = new System.Windows.Forms.DateTimePicker();
            this.TButtonReserva = new System.Windows.Forms.Button();
            this.TLabelNombre = new System.Windows.Forms.Label();
            this.TLabelDNI = new System.Windows.Forms.Label();
            this.TLabelErrorFecha = new System.Windows.Forms.Label();
            this.TLabelMarca = new System.Windows.Forms.Label();
            this.TComboBoxMarca = new System.Windows.Forms.ComboBox();
            this.TLabelSinCoche = new System.Windows.Forms.Label();
            this.TLabelSinConductores = new System.Windows.Forms.Label();
            this.TButtonCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Buscar cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TComboBoxCategoria
            // 
            this.TComboBoxCategoria.FormattingEnabled = true;
            this.TComboBoxCategoria.Location = new System.Drawing.Point(75, 154);
            this.TComboBoxCategoria.Name = "TComboBoxCategoria";
            this.TComboBoxCategoria.Size = new System.Drawing.Size(121, 21);
            this.TComboBoxCategoria.TabIndex = 27;
            this.TComboBoxCategoria.Text = "Seleccione Categoria";
            this.TComboBoxCategoria.TextChanged += new System.EventHandler(this.TComboBoxCategoria_TextChanged);
            // 
            // TComboBoxModelo
            // 
            this.TComboBoxModelo.FormattingEnabled = true;
            this.TComboBoxModelo.Location = new System.Drawing.Point(493, 154);
            this.TComboBoxModelo.Name = "TComboBoxModelo";
            this.TComboBoxModelo.Size = new System.Drawing.Size(121, 21);
            this.TComboBoxModelo.TabIndex = 28;
            this.TComboBoxModelo.Text = "Seleccione Modelo";
            this.TComboBoxModelo.TextChanged += new System.EventHandler(this.TComboBoxModelo_TextChanged);
            // 
            // TLabelCategoria
            // 
            this.TLabelCategoria.AutoSize = true;
            this.TLabelCategoria.BackColor = System.Drawing.Color.Transparent;
            this.TLabelCategoria.Location = new System.Drawing.Point(14, 157);
            this.TLabelCategoria.Name = "TLabelCategoria";
            this.TLabelCategoria.Size = new System.Drawing.Size(55, 13);
            this.TLabelCategoria.TabIndex = 29;
            this.TLabelCategoria.Text = "Categoria:";
            // 
            // TLabelModelo
            // 
            this.TLabelModelo.AutoSize = true;
            this.TLabelModelo.BackColor = System.Drawing.Color.Transparent;
            this.TLabelModelo.Location = new System.Drawing.Point(441, 157);
            this.TLabelModelo.Name = "TLabelModelo";
            this.TLabelModelo.Size = new System.Drawing.Size(45, 13);
            this.TLabelModelo.TabIndex = 30;
            this.TLabelModelo.Text = "Modelo:";
            // 
            // TLabelMatricula
            // 
            this.TLabelMatricula.AutoSize = true;
            this.TLabelMatricula.BackColor = System.Drawing.Color.Transparent;
            this.TLabelMatricula.Location = new System.Drawing.Point(645, 157);
            this.TLabelMatricula.Name = "TLabelMatricula";
            this.TLabelMatricula.Size = new System.Drawing.Size(53, 13);
            this.TLabelMatricula.TabIndex = 31;
            this.TLabelMatricula.Text = "Matricula:";
            // 
            // TComboBoxMatricula
            // 
            this.TComboBoxMatricula.FormattingEnabled = true;
            this.TComboBoxMatricula.Location = new System.Drawing.Point(704, 154);
            this.TComboBoxMatricula.Name = "TComboBoxMatricula";
            this.TComboBoxMatricula.Size = new System.Drawing.Size(121, 21);
            this.TComboBoxMatricula.TabIndex = 32;
            this.TComboBoxMatricula.Text = "Seleccione Matricula";
            // 
            // TLabelConductores
            // 
            this.TLabelConductores.AutoSize = true;
            this.TLabelConductores.BackColor = System.Drawing.Color.Transparent;
            this.TLabelConductores.Location = new System.Drawing.Point(76, 223);
            this.TLabelConductores.Name = "TLabelConductores";
            this.TLabelConductores.Size = new System.Drawing.Size(70, 13);
            this.TLabelConductores.TabIndex = 33;
            this.TLabelConductores.Text = "Conductores:";
            // 
            // TComboBoxConductores
            // 
            this.TComboBoxConductores.FormattingEnabled = true;
            this.TComboBoxConductores.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.TComboBoxConductores.Location = new System.Drawing.Point(152, 220);
            this.TComboBoxConductores.Name = "TComboBoxConductores";
            this.TComboBoxConductores.Size = new System.Drawing.Size(61, 21);
            this.TComboBoxConductores.TabIndex = 34;
            this.TComboBoxConductores.Text = "Nº";
            // 
            // TLabelFechaInicio
            // 
            this.TLabelFechaInicio.AutoSize = true;
            this.TLabelFechaInicio.BackColor = System.Drawing.Color.Transparent;
            this.TLabelFechaInicio.Location = new System.Drawing.Point(292, 223);
            this.TLabelFechaInicio.Name = "TLabelFechaInicio";
            this.TLabelFechaInicio.Size = new System.Drawing.Size(68, 13);
            this.TLabelFechaInicio.TabIndex = 35;
            this.TLabelFechaInicio.Text = "Fecha Inicio:";
            // 
            // TDateTimePickerFechaInicio
            // 
            this.TDateTimePickerFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TDateTimePickerFechaInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TDateTimePickerFechaInicio.Location = new System.Drawing.Point(366, 220);
            this.TDateTimePickerFechaInicio.Name = "TDateTimePickerFechaInicio";
            this.TDateTimePickerFechaInicio.Size = new System.Drawing.Size(98, 20);
            this.TDateTimePickerFechaInicio.TabIndex = 36;
            this.TDateTimePickerFechaInicio.Value = new System.DateTime(2012, 4, 16, 0, 0, 0, 0);
            this.TDateTimePickerFechaInicio.ValueChanged += new System.EventHandler(this.TDateTimePickerFechaInicio_ValueChanged);
            // 
            // TLabelFechaFin
            // 
            this.TLabelFechaFin.AutoSize = true;
            this.TLabelFechaFin.BackColor = System.Drawing.Color.Transparent;
            this.TLabelFechaFin.Location = new System.Drawing.Point(544, 223);
            this.TLabelFechaFin.Name = "TLabelFechaFin";
            this.TLabelFechaFin.Size = new System.Drawing.Size(57, 13);
            this.TLabelFechaFin.TabIndex = 37;
            this.TLabelFechaFin.Text = "Fecha Fin:";
            // 
            // TDateTimePickerFechaFin
            // 
            this.TDateTimePickerFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TDateTimePickerFechaFin.Location = new System.Drawing.Point(607, 220);
            this.TDateTimePickerFechaFin.Name = "TDateTimePickerFechaFin";
            this.TDateTimePickerFechaFin.Size = new System.Drawing.Size(117, 20);
            this.TDateTimePickerFechaFin.TabIndex = 38;
            this.TDateTimePickerFechaFin.ValueChanged += new System.EventHandler(this.TDateTimePickerFechaFin_ValueChanged);
            // 
            // TButtonReserva
            // 
            this.TButtonReserva.Location = new System.Drawing.Point(339, 331);
            this.TButtonReserva.Name = "TButtonReserva";
            this.TButtonReserva.Size = new System.Drawing.Size(125, 78);
            this.TButtonReserva.TabIndex = 39;
            this.TButtonReserva.Text = "Realizar Reserva";
            this.TButtonReserva.UseVisualStyleBackColor = true;
            this.TButtonReserva.Click += new System.EventHandler(this.TButtonReserva_Click);
            // 
            // TLabelNombre
            // 
            this.TLabelNombre.AutoSize = true;
            this.TLabelNombre.BackColor = System.Drawing.Color.Transparent;
            this.TLabelNombre.Location = new System.Drawing.Point(41, 59);
            this.TLabelNombre.Name = "TLabelNombre";
            this.TLabelNombre.Size = new System.Drawing.Size(35, 13);
            this.TLabelNombre.TabIndex = 40;
            this.TLabelNombre.Text = "label1";
            this.TLabelNombre.Visible = false;
            // 
            // TLabelDNI
            // 
            this.TLabelDNI.AutoSize = true;
            this.TLabelDNI.BackColor = System.Drawing.Color.Transparent;
            this.TLabelDNI.Location = new System.Drawing.Point(41, 85);
            this.TLabelDNI.Name = "TLabelDNI";
            this.TLabelDNI.Size = new System.Drawing.Size(35, 13);
            this.TLabelDNI.TabIndex = 41;
            this.TLabelDNI.Text = "label1";
            this.TLabelDNI.Visible = false;
            // 
            // TLabelErrorFecha
            // 
            this.TLabelErrorFecha.AutoSize = true;
            this.TLabelErrorFecha.BackColor = System.Drawing.Color.Transparent;
            this.TLabelErrorFecha.Font = new System.Drawing.Font("Broadway", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TLabelErrorFecha.ForeColor = System.Drawing.Color.Red;
            this.TLabelErrorFecha.Location = new System.Drawing.Point(544, 256);
            this.TLabelErrorFecha.Name = "TLabelErrorFecha";
            this.TLabelErrorFecha.Size = new System.Drawing.Size(225, 12);
            this.TLabelErrorFecha.TabIndex = 42;
            this.TLabelErrorFecha.Text = "Fecha fin inferior a fecha inicio";
            this.TLabelErrorFecha.Visible = false;
            // 
            // TLabelMarca
            // 
            this.TLabelMarca.AutoSize = true;
            this.TLabelMarca.BackColor = System.Drawing.Color.Transparent;
            this.TLabelMarca.Location = new System.Drawing.Point(235, 157);
            this.TLabelMarca.Name = "TLabelMarca";
            this.TLabelMarca.Size = new System.Drawing.Size(40, 13);
            this.TLabelMarca.TabIndex = 43;
            this.TLabelMarca.Text = "Marca:";
            // 
            // TComboBoxMarca
            // 
            this.TComboBoxMarca.FormattingEnabled = true;
            this.TComboBoxMarca.Location = new System.Drawing.Point(282, 154);
            this.TComboBoxMarca.Name = "TComboBoxMarca";
            this.TComboBoxMarca.Size = new System.Drawing.Size(121, 21);
            this.TComboBoxMarca.TabIndex = 44;
            this.TComboBoxMarca.Text = "Seleccione Marca";
            this.TComboBoxMarca.TextChanged += new System.EventHandler(this.TComboBoxMarca_TextChanged);
            // 
            // TLabelSinCoche
            // 
            this.TLabelSinCoche.AutoSize = true;
            this.TLabelSinCoche.Font = new System.Drawing.Font("Broadway", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TLabelSinCoche.ForeColor = System.Drawing.Color.Red;
            this.TLabelSinCoche.Location = new System.Drawing.Point(337, 112);
            this.TLabelSinCoche.Name = "TLabelSinCoche";
            this.TLabelSinCoche.Size = new System.Drawing.Size(188, 12);
            this.TLabelSinCoche.TabIndex = 45;
            this.TLabelSinCoche.Text = "Falta seleccionar vehiculo";
            this.TLabelSinCoche.Visible = false;
            // 
            // TLabelSinConductores
            // 
            this.TLabelSinConductores.AutoSize = true;
            this.TLabelSinConductores.Font = new System.Drawing.Font("Broadway", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TLabelSinConductores.ForeColor = System.Drawing.Color.Red;
            this.TLabelSinConductores.Location = new System.Drawing.Point(77, 256);
            this.TLabelSinConductores.Name = "TLabelSinConductores";
            this.TLabelSinConductores.Size = new System.Drawing.Size(143, 12);
            this.TLabelSinConductores.TabIndex = 46;
            this.TLabelSinConductores.Text = "Faltan  conductores";
            this.TLabelSinConductores.Visible = false;
            // 
            // TButtonCerrar
            // 
            this.TButtonCerrar.Location = new System.Drawing.Point(58, 558);
            this.TButtonCerrar.Name = "TButtonCerrar";
            this.TButtonCerrar.Size = new System.Drawing.Size(75, 23);
            this.TButtonCerrar.TabIndex = 47;
            this.TButtonCerrar.Text = "Cerrar";
            this.TButtonCerrar.UseVisualStyleBackColor = true;
            this.TButtonCerrar.Click += new System.EventHandler(this.TButtonCerrar_Click);
            // 
            // AltaReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AlquilerCoches.Properties.Resources.rentacar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 608);
            this.Controls.Add(this.TButtonCerrar);
            this.Controls.Add(this.TLabelSinConductores);
            this.Controls.Add(this.TLabelSinCoche);
            this.Controls.Add(this.TComboBoxMarca);
            this.Controls.Add(this.TLabelMarca);
            this.Controls.Add(this.TLabelErrorFecha);
            this.Controls.Add(this.TLabelDNI);
            this.Controls.Add(this.TLabelNombre);
            this.Controls.Add(this.TButtonReserva);
            this.Controls.Add(this.TDateTimePickerFechaFin);
            this.Controls.Add(this.TLabelFechaFin);
            this.Controls.Add(this.TDateTimePickerFechaInicio);
            this.Controls.Add(this.TLabelFechaInicio);
            this.Controls.Add(this.TComboBoxConductores);
            this.Controls.Add(this.TLabelConductores);
            this.Controls.Add(this.TComboBoxMatricula);
            this.Controls.Add(this.TLabelMatricula);
            this.Controls.Add(this.TLabelModelo);
            this.Controls.Add(this.TLabelCategoria);
            this.Controls.Add(this.TComboBoxModelo);
            this.Controls.Add(this.TComboBoxCategoria);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(894, 608);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(894, 608);
            this.Name = "AltaReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Reserva";
            this.Load += new System.EventHandler(this.AltaReservas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox TComboBoxCategoria;
        private System.Windows.Forms.ComboBox TComboBoxModelo;
        private System.Windows.Forms.Label TLabelCategoria;
        private System.Windows.Forms.Label TLabelModelo;
        private System.Windows.Forms.Label TLabelMatricula;
        private System.Windows.Forms.ComboBox TComboBoxMatricula;
        private System.Windows.Forms.Label TLabelConductores;
        private System.Windows.Forms.ComboBox TComboBoxConductores;
        private System.Windows.Forms.Label TLabelFechaInicio;
        private System.Windows.Forms.DateTimePicker TDateTimePickerFechaInicio;
        private System.Windows.Forms.Label TLabelFechaFin;
        private System.Windows.Forms.DateTimePicker TDateTimePickerFechaFin;
        private System.Windows.Forms.Button TButtonReserva;
        private System.Windows.Forms.Label TLabelNombre;
        private System.Windows.Forms.Label TLabelDNI;
        private System.Windows.Forms.Label TLabelErrorFecha;
        private System.Windows.Forms.Label TLabelMarca;
        private System.Windows.Forms.ComboBox TComboBoxMarca;
        private System.Windows.Forms.Label TLabelSinCoche;
        private System.Windows.Forms.Label TLabelSinConductores;
        private System.Windows.Forms.Button TButtonCerrar;
    }
}