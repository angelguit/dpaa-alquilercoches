namespace AlquilerCoches
{
    partial class NuevaFactura
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
            this.TLabelCrearFactura = new System.Windows.Forms.Label();
            this.TRadioButtonReservas = new System.Windows.Forms.RadioButton();
            this.TRadioButtonVentas = new System.Windows.Forms.RadioButton();
            this.TLabelSelFac = new System.Windows.Forms.Label();
            this.TGroupBoxReservas = new System.Windows.Forms.GroupBox();
            this.TButtonQuitarCliente = new System.Windows.Forms.Button();
            this.TButtonOcultarFechas = new System.Windows.Forms.Button();
            this.TButtonBuscarFechas = new System.Windows.Forms.Button();
            this.TButtonBuscar = new System.Windows.Forms.Button();
            this.TButtonCambiarCliente = new System.Windows.Forms.Button();
            this.TLabelCliente = new System.Windows.Forms.Label();
            this.TButtonBuscarCliente = new System.Windows.Forms.Button();
            this.TTextBoxNumeroReserva = new System.Windows.Forms.TextBox();
            this.TDateTimePickerFechaFin = new System.Windows.Forms.DateTimePicker();
            this.TDateTimePickerFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.TLabelFechaFin = new System.Windows.Forms.Label();
            this.TLabelNRes = new System.Windows.Forms.Label();
            this.TLabelFechaInicio = new System.Windows.Forms.Label();
            this.TDataGridViewReservas = new System.Windows.Forms.DataGridView();
            this.TGroupBoxReservas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TDataGridViewReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // TLabelCrearFactura
            // 
            this.TLabelCrearFactura.AutoSize = true;
            this.TLabelCrearFactura.BackColor = System.Drawing.Color.Transparent;
            this.TLabelCrearFactura.Location = new System.Drawing.Point(1, 2);
            this.TLabelCrearFactura.Name = "TLabelCrearFactura";
            this.TLabelCrearFactura.Size = new System.Drawing.Size(71, 13);
            this.TLabelCrearFactura.TabIndex = 0;
            this.TLabelCrearFactura.Text = "Crear Factura";
            // 
            // TRadioButtonReservas
            // 
            this.TRadioButtonReservas.AutoSize = true;
            this.TRadioButtonReservas.BackColor = System.Drawing.Color.Transparent;
            this.TRadioButtonReservas.Location = new System.Drawing.Point(44, 63);
            this.TRadioButtonReservas.Name = "TRadioButtonReservas";
            this.TRadioButtonReservas.Size = new System.Drawing.Size(70, 17);
            this.TRadioButtonReservas.TabIndex = 1;
            this.TRadioButtonReservas.TabStop = true;
            this.TRadioButtonReservas.Text = "Reservas";
            this.TRadioButtonReservas.UseVisualStyleBackColor = false;
            this.TRadioButtonReservas.CheckedChanged += new System.EventHandler(this.TRadioButtonReservas_CheckedChanged);
            // 
            // TRadioButtonVentas
            // 
            this.TRadioButtonVentas.AutoSize = true;
            this.TRadioButtonVentas.BackColor = System.Drawing.Color.Transparent;
            this.TRadioButtonVentas.Location = new System.Drawing.Point(120, 63);
            this.TRadioButtonVentas.Name = "TRadioButtonVentas";
            this.TRadioButtonVentas.Size = new System.Drawing.Size(58, 17);
            this.TRadioButtonVentas.TabIndex = 2;
            this.TRadioButtonVentas.TabStop = true;
            this.TRadioButtonVentas.Text = "Ventas";
            this.TRadioButtonVentas.UseVisualStyleBackColor = false;
            // 
            // TLabelSelFac
            // 
            this.TLabelSelFac.AutoSize = true;
            this.TLabelSelFac.BackColor = System.Drawing.Color.Transparent;
            this.TLabelSelFac.Location = new System.Drawing.Point(41, 38);
            this.TLabelSelFac.Name = "TLabelSelFac";
            this.TLabelSelFac.Size = new System.Drawing.Size(93, 13);
            this.TLabelSelFac.TabIndex = 3;
            this.TLabelSelFac.Text = "Selecciona Modo:";
            // 
            // TGroupBoxReservas
            // 
            this.TGroupBoxReservas.BackColor = System.Drawing.Color.Transparent;
            this.TGroupBoxReservas.Controls.Add(this.TLabelFechaInicio);
            this.TGroupBoxReservas.Controls.Add(this.TButtonQuitarCliente);
            this.TGroupBoxReservas.Controls.Add(this.TButtonOcultarFechas);
            this.TGroupBoxReservas.Controls.Add(this.TButtonBuscarFechas);
            this.TGroupBoxReservas.Controls.Add(this.TButtonBuscar);
            this.TGroupBoxReservas.Controls.Add(this.TButtonCambiarCliente);
            this.TGroupBoxReservas.Controls.Add(this.TLabelCliente);
            this.TGroupBoxReservas.Controls.Add(this.TButtonBuscarCliente);
            this.TGroupBoxReservas.Controls.Add(this.TTextBoxNumeroReserva);
            this.TGroupBoxReservas.Controls.Add(this.TDateTimePickerFechaFin);
            this.TGroupBoxReservas.Controls.Add(this.TDateTimePickerFechaInicio);
            this.TGroupBoxReservas.Controls.Add(this.TLabelFechaFin);
            this.TGroupBoxReservas.Controls.Add(this.TLabelNRes);
            this.TGroupBoxReservas.Location = new System.Drawing.Point(195, 117);
            this.TGroupBoxReservas.Name = "TGroupBoxReservas";
            this.TGroupBoxReservas.Size = new System.Drawing.Size(460, 253);
            this.TGroupBoxReservas.TabIndex = 4;
            this.TGroupBoxReservas.TabStop = false;
            this.TGroupBoxReservas.Visible = false;
            // 
            // TButtonQuitarCliente
            // 
            this.TButtonQuitarCliente.Location = new System.Drawing.Point(151, 148);
            this.TButtonQuitarCliente.Name = "TButtonQuitarCliente";
            this.TButtonQuitarCliente.Size = new System.Drawing.Size(79, 23);
            this.TButtonQuitarCliente.TabIndex = 27;
            this.TButtonQuitarCliente.Text = "Quitar Cliente";
            this.TButtonQuitarCliente.UseVisualStyleBackColor = true;
            this.TButtonQuitarCliente.Visible = false;
            this.TButtonQuitarCliente.Click += new System.EventHandler(this.TButtonQuitarCliente_Click);
            // 
            // TButtonOcultarFechas
            // 
            this.TButtonOcultarFechas.Location = new System.Drawing.Point(331, 71);
            this.TButtonOcultarFechas.Name = "TButtonOcultarFechas";
            this.TButtonOcultarFechas.Size = new System.Drawing.Size(97, 23);
            this.TButtonOcultarFechas.TabIndex = 25;
            this.TButtonOcultarFechas.Text = "Ocultar Fechas";
            this.TButtonOcultarFechas.UseVisualStyleBackColor = true;
            this.TButtonOcultarFechas.Visible = false;
            this.TButtonOcultarFechas.Click += new System.EventHandler(this.TButtonOcultarFechas_Click);
            // 
            // TButtonBuscarFechas
            // 
            this.TButtonBuscarFechas.Location = new System.Drawing.Point(34, 71);
            this.TButtonBuscarFechas.Name = "TButtonBuscarFechas";
            this.TButtonBuscarFechas.Size = new System.Drawing.Size(129, 23);
            this.TButtonBuscarFechas.TabIndex = 24;
            this.TButtonBuscarFechas.Text = "Buscar por Fechas";
            this.TButtonBuscarFechas.UseVisualStyleBackColor = true;
            this.TButtonBuscarFechas.Click += new System.EventHandler(this.TButtonBuscarFechas_Click);
            // 
            // TButtonBuscar
            // 
            this.TButtonBuscar.Image = global::AlquilerCoches.Properties.Resources.Search_icon;
            this.TButtonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TButtonBuscar.Location = new System.Drawing.Point(327, 195);
            this.TButtonBuscar.Name = "TButtonBuscar";
            this.TButtonBuscar.Size = new System.Drawing.Size(101, 32);
            this.TButtonBuscar.TabIndex = 23;
            this.TButtonBuscar.Text = "Buscar";
            this.TButtonBuscar.UseVisualStyleBackColor = true;
            this.TButtonBuscar.Click += new System.EventHandler(this.TButtonBuscar_Click);
            // 
            // TButtonCambiarCliente
            // 
            this.TButtonCambiarCliente.Location = new System.Drawing.Point(34, 148);
            this.TButtonCambiarCliente.Name = "TButtonCambiarCliente";
            this.TButtonCambiarCliente.Size = new System.Drawing.Size(100, 23);
            this.TButtonCambiarCliente.TabIndex = 22;
            this.TButtonCambiarCliente.Text = "Cambiar Cliente";
            this.TButtonCambiarCliente.UseVisualStyleBackColor = true;
            this.TButtonCambiarCliente.Visible = false;
            this.TButtonCambiarCliente.Click += new System.EventHandler(this.TButtonBuscarCliente_Click);
            // 
            // TLabelCliente
            // 
            this.TLabelCliente.AutoSize = true;
            this.TLabelCliente.Location = new System.Drawing.Point(31, 119);
            this.TLabelCliente.Name = "TLabelCliente";
            this.TLabelCliente.Size = new System.Drawing.Size(35, 13);
            this.TLabelCliente.TabIndex = 21;
            this.TLabelCliente.Text = "label1";
            this.TLabelCliente.Visible = false;
            // 
            // TButtonBuscarCliente
            // 
            this.TButtonBuscarCliente.Location = new System.Drawing.Point(34, 114);
            this.TButtonBuscarCliente.Name = "TButtonBuscarCliente";
            this.TButtonBuscarCliente.Size = new System.Drawing.Size(129, 23);
            this.TButtonBuscarCliente.TabIndex = 20;
            this.TButtonBuscarCliente.Text = "Buscar por Cliente";
            this.TButtonBuscarCliente.UseVisualStyleBackColor = true;
            this.TButtonBuscarCliente.Click += new System.EventHandler(this.TButtonBuscarCliente_Click);
            // 
            // TTextBoxNumeroReserva
            // 
            this.TTextBoxNumeroReserva.Location = new System.Drawing.Point(127, 38);
            this.TTextBoxNumeroReserva.Name = "TTextBoxNumeroReserva";
            this.TTextBoxNumeroReserva.Size = new System.Drawing.Size(36, 20);
            this.TTextBoxNumeroReserva.TabIndex = 19;
            // 
            // TDateTimePickerFechaFin
            // 
            this.TDateTimePickerFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TDateTimePickerFechaFin.Location = new System.Drawing.Point(215, 71);
            this.TDateTimePickerFechaFin.Name = "TDateTimePickerFechaFin";
            this.TDateTimePickerFechaFin.Size = new System.Drawing.Size(86, 20);
            this.TDateTimePickerFechaFin.TabIndex = 18;
            this.TDateTimePickerFechaFin.Visible = false;
            // 
            // TDateTimePickerFechaInicio
            // 
            this.TDateTimePickerFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TDateTimePickerFechaInicio.Location = new System.Drawing.Point(105, 71);
            this.TDateTimePickerFechaInicio.Name = "TDateTimePickerFechaInicio";
            this.TDateTimePickerFechaInicio.Size = new System.Drawing.Size(86, 20);
            this.TDateTimePickerFechaInicio.TabIndex = 17;
            this.TDateTimePickerFechaInicio.Visible = false;
            // 
            // TLabelFechaFin
            // 
            this.TLabelFechaFin.AutoSize = true;
            this.TLabelFechaFin.Location = new System.Drawing.Point(197, 77);
            this.TLabelFechaFin.Name = "TLabelFechaFin";
            this.TLabelFechaFin.Size = new System.Drawing.Size(12, 13);
            this.TLabelFechaFin.TabIndex = 16;
            this.TLabelFechaFin.Text = "y";
            this.TLabelFechaFin.Visible = false;
            // 
            // TLabelNRes
            // 
            this.TLabelNRes.AutoSize = true;
            this.TLabelNRes.Location = new System.Drawing.Point(31, 41);
            this.TLabelNRes.Name = "TLabelNRes";
            this.TLabelNRes.Size = new System.Drawing.Size(90, 13);
            this.TLabelNRes.TabIndex = 15;
            this.TLabelNRes.Text = "Numero Reserva:";
            // 
            // TLabelFechaInicio
            // 
            this.TLabelFechaInicio.AutoSize = true;
            this.TLabelFechaInicio.Location = new System.Drawing.Point(31, 76);
            this.TLabelFechaInicio.Name = "TLabelFechaInicio";
            this.TLabelFechaInicio.Size = new System.Drawing.Size(67, 13);
            this.TLabelFechaInicio.TabIndex = 28;
            this.TLabelFechaInicio.Text = "Fecha entre:";
            this.TLabelFechaInicio.Visible = false;
            // 
            // TDataGridViewReservas
            // 
            this.TDataGridViewReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TDataGridViewReservas.Location = new System.Drawing.Point(195, 38);
            this.TDataGridViewReservas.Name = "TDataGridViewReservas";
            this.TDataGridViewReservas.Size = new System.Drawing.Size(558, 285);
            this.TDataGridViewReservas.TabIndex = 5;
            this.TDataGridViewReservas.Visible = false;
            // 
            // NuevaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AlquilerCoches.Properties.Resources.rentacar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 608);
            this.ControlBox = false;
            this.Controls.Add(this.TGroupBoxReservas);
            this.Controls.Add(this.TLabelSelFac);
            this.Controls.Add(this.TRadioButtonVentas);
            this.Controls.Add(this.TRadioButtonReservas);
            this.Controls.Add(this.TLabelCrearFactura);
            this.Controls.Add(this.TDataGridViewReservas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(894, 608);
            this.MinimumSize = new System.Drawing.Size(894, 608);
            this.Name = "NuevaFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevaFactura";
            this.Load += new System.EventHandler(this.NuevaFactura_Load);
            this.TGroupBoxReservas.ResumeLayout(false);
            this.TGroupBoxReservas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TDataGridViewReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TLabelCrearFactura;
        private System.Windows.Forms.RadioButton TRadioButtonReservas;
        private System.Windows.Forms.RadioButton TRadioButtonVentas;
        private System.Windows.Forms.Label TLabelSelFac;
        private System.Windows.Forms.GroupBox TGroupBoxReservas;
        private System.Windows.Forms.Button TButtonQuitarCliente;
        private System.Windows.Forms.Button TButtonOcultarFechas;
        private System.Windows.Forms.Button TButtonBuscarFechas;
        private System.Windows.Forms.Button TButtonBuscar;
        private System.Windows.Forms.Button TButtonCambiarCliente;
        private System.Windows.Forms.Label TLabelCliente;
        private System.Windows.Forms.Button TButtonBuscarCliente;
        private System.Windows.Forms.TextBox TTextBoxNumeroReserva;
        private System.Windows.Forms.DateTimePicker TDateTimePickerFechaFin;
        private System.Windows.Forms.DateTimePicker TDateTimePickerFechaInicio;
        private System.Windows.Forms.Label TLabelFechaFin;
        private System.Windows.Forms.Label TLabelNRes;
        private System.Windows.Forms.Label TLabelFechaInicio;
        private System.Windows.Forms.DataGridView TDataGridViewReservas;
    }
}