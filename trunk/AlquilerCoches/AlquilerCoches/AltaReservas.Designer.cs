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
            this.TComboBoxCategoria.Location = new System.Drawing.Point(102, 154);
            this.TComboBoxCategoria.Name = "TComboBoxCategoria";
            this.TComboBoxCategoria.Size = new System.Drawing.Size(121, 21);
            this.TComboBoxCategoria.TabIndex = 27;
            this.TComboBoxCategoria.Text = "Seleccione Categoria";
            // 
            // TComboBoxModelo
            // 
            this.TComboBoxModelo.FormattingEnabled = true;
            this.TComboBoxModelo.Location = new System.Drawing.Point(339, 154);
            this.TComboBoxModelo.Name = "TComboBoxModelo";
            this.TComboBoxModelo.Size = new System.Drawing.Size(121, 21);
            this.TComboBoxModelo.TabIndex = 28;
            this.TComboBoxModelo.Text = "Seleccione Modelo";
            // 
            // TLabelCategoria
            // 
            this.TLabelCategoria.AutoSize = true;
            this.TLabelCategoria.BackColor = System.Drawing.Color.Transparent;
            this.TLabelCategoria.Location = new System.Drawing.Point(41, 157);
            this.TLabelCategoria.Name = "TLabelCategoria";
            this.TLabelCategoria.Size = new System.Drawing.Size(55, 13);
            this.TLabelCategoria.TabIndex = 29;
            this.TLabelCategoria.Text = "Categoria:";
            // 
            // TLabelModelo
            // 
            this.TLabelModelo.AutoSize = true;
            this.TLabelModelo.BackColor = System.Drawing.Color.Transparent;
            this.TLabelModelo.Location = new System.Drawing.Point(288, 157);
            this.TLabelModelo.Name = "TLabelModelo";
            this.TLabelModelo.Size = new System.Drawing.Size(45, 13);
            this.TLabelModelo.TabIndex = 30;
            this.TLabelModelo.Text = "Modelo:";
            // 
            // TLabelMatricula
            // 
            this.TLabelMatricula.AutoSize = true;
            this.TLabelMatricula.BackColor = System.Drawing.Color.Transparent;
            this.TLabelMatricula.Location = new System.Drawing.Point(544, 157);
            this.TLabelMatricula.Name = "TLabelMatricula";
            this.TLabelMatricula.Size = new System.Drawing.Size(53, 13);
            this.TLabelMatricula.TabIndex = 31;
            this.TLabelMatricula.Text = "Matricula:";
            // 
            // TComboBoxMatricula
            // 
            this.TComboBoxMatricula.FormattingEnabled = true;
            this.TComboBoxMatricula.Location = new System.Drawing.Point(603, 154);
            this.TComboBoxMatricula.Name = "TComboBoxMatricula";
            this.TComboBoxMatricula.Size = new System.Drawing.Size(121, 21);
            this.TComboBoxMatricula.TabIndex = 32;
            this.TComboBoxMatricula.Text = "Seleccione Matricula";
            // 
            // TLabelConductores
            // 
            this.TLabelConductores.AutoSize = true;
            this.TLabelConductores.BackColor = System.Drawing.Color.Transparent;
            this.TLabelConductores.Location = new System.Drawing.Point(41, 223);
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
            this.TComboBoxConductores.Location = new System.Drawing.Point(117, 220);
            this.TComboBoxConductores.Name = "TComboBoxConductores";
            this.TComboBoxConductores.Size = new System.Drawing.Size(61, 21);
            this.TComboBoxConductores.TabIndex = 34;
            this.TComboBoxConductores.Text = "Nº";
            // 
            // TLabelFechaInicio
            // 
            this.TLabelFechaInicio.AutoSize = true;
            this.TLabelFechaInicio.BackColor = System.Drawing.Color.Transparent;
            this.TLabelFechaInicio.Location = new System.Drawing.Point(288, 223);
            this.TLabelFechaInicio.Name = "TLabelFechaInicio";
            this.TLabelFechaInicio.Size = new System.Drawing.Size(68, 13);
            this.TLabelFechaInicio.TabIndex = 35;
            this.TLabelFechaInicio.Text = "Fecha Inicio:";
            // 
            // TDateTimePickerFechaInicio
            // 
            this.TDateTimePickerFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TDateTimePickerFechaInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TDateTimePickerFechaInicio.Location = new System.Drawing.Point(362, 220);
            this.TDateTimePickerFechaInicio.Name = "TDateTimePickerFechaInicio";
            this.TDateTimePickerFechaInicio.Size = new System.Drawing.Size(98, 20);
            this.TDateTimePickerFechaInicio.TabIndex = 36;
            this.TDateTimePickerFechaInicio.Value = new System.DateTime(2012, 3, 22, 21, 10, 41, 0);
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
            // 
            // TButtonReserva
            // 
            this.TButtonReserva.Location = new System.Drawing.Point(339, 331);
            this.TButtonReserva.Name = "TButtonReserva";
            this.TButtonReserva.Size = new System.Drawing.Size(125, 78);
            this.TButtonReserva.TabIndex = 39;
            this.TButtonReserva.Text = "Realizar Reserva";
            this.TButtonReserva.UseVisualStyleBackColor = true;
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
            // AltaReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AlquilerCoches.Properties.Resources.rentacar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(837, 590);
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
            this.Name = "AltaReservas";
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
    }
}