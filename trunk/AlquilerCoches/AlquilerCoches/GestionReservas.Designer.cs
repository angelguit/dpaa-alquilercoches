namespace AlquilerCoches
{
    partial class GestionReservas
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
            this.TDataGridViewReservas = new System.Windows.Forms.DataGridView();
            this.TButtonCerrar = new System.Windows.Forms.Button();
            this.TPanelReservas = new System.Windows.Forms.Panel();
            this.TLabelNRes = new System.Windows.Forms.Label();
            this.TLabelFechaInicio = new System.Windows.Forms.Label();
            this.TLabelFechaFin = new System.Windows.Forms.Label();
            this.TDateTimePickerFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.TDateTimePickerFechaFin = new System.Windows.Forms.DateTimePicker();
            this.TTextBoxNumeroReserva = new System.Windows.Forms.TextBox();
            this.TButtonBuscarCliente = new System.Windows.Forms.Button();
            this.TLabelCliente = new System.Windows.Forms.Label();
            this.TButtonCambiarCliente = new System.Windows.Forms.Button();
            this.TButtonBuscar = new System.Windows.Forms.Button();
            this.TButtonBuscarFechas = new System.Windows.Forms.Button();
            this.TButtonOcultarFechas = new System.Windows.Forms.Button();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.TButtonEliminar = new System.Windows.Forms.Button();
            this.TButtonQuitarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TDataGridViewReservas)).BeginInit();
            this.TPanelReservas.SuspendLayout();
            this.SuspendLayout();
            // 
            // TDataGridViewReservas
            // 
            this.TDataGridViewReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TDataGridViewReservas.Location = new System.Drawing.Point(130, 48);
            this.TDataGridViewReservas.Name = "TDataGridViewReservas";
            this.TDataGridViewReservas.Size = new System.Drawing.Size(598, 318);
            this.TDataGridViewReservas.TabIndex = 0;
            this.TDataGridViewReservas.Visible = false;
            // 
            // TButtonCerrar
            // 
            this.TButtonCerrar.Location = new System.Drawing.Point(66, 535);
            this.TButtonCerrar.Name = "TButtonCerrar";
            this.TButtonCerrar.Size = new System.Drawing.Size(75, 23);
            this.TButtonCerrar.TabIndex = 38;
            this.TButtonCerrar.Text = "Cerrar";
            this.TButtonCerrar.UseVisualStyleBackColor = true;
            this.TButtonCerrar.Click += new System.EventHandler(this.TButtonCerrar_Click);
            // 
            // TPanelReservas
            // 
            this.TPanelReservas.BackColor = System.Drawing.Color.Transparent;
            this.TPanelReservas.Controls.Add(this.TButtonQuitarCliente);
            this.TPanelReservas.Controls.Add(this.TButtonEliminar);
            this.TPanelReservas.Controls.Add(this.TButtonOcultarFechas);
            this.TPanelReservas.Controls.Add(this.TButtonBuscarFechas);
            this.TPanelReservas.Controls.Add(this.TButtonBuscar);
            this.TPanelReservas.Controls.Add(this.TButtonCambiarCliente);
            this.TPanelReservas.Controls.Add(this.TLabelCliente);
            this.TPanelReservas.Controls.Add(this.TButtonBuscarCliente);
            this.TPanelReservas.Controls.Add(this.TTextBoxNumeroReserva);
            this.TPanelReservas.Controls.Add(this.TDateTimePickerFechaFin);
            this.TPanelReservas.Controls.Add(this.TDateTimePickerFechaInicio);
            this.TPanelReservas.Controls.Add(this.TLabelFechaFin);
            this.TPanelReservas.Controls.Add(this.TLabelFechaInicio);
            this.TPanelReservas.Controls.Add(this.TLabelNRes);
            this.TPanelReservas.Controls.Add(this.shapeContainer1);
            this.TPanelReservas.Location = new System.Drawing.Point(175, 89);
            this.TPanelReservas.Name = "TPanelReservas";
            this.TPanelReservas.Size = new System.Drawing.Size(439, 217);
            this.TPanelReservas.TabIndex = 39;
            // 
            // TLabelNRes
            // 
            this.TLabelNRes.AutoSize = true;
            this.TLabelNRes.Location = new System.Drawing.Point(21, 25);
            this.TLabelNRes.Name = "TLabelNRes";
            this.TLabelNRes.Size = new System.Drawing.Size(90, 13);
            this.TLabelNRes.TabIndex = 0;
            this.TLabelNRes.Text = "Numero Reserva:";
            // 
            // TLabelFechaInicio
            // 
            this.TLabelFechaInicio.AutoSize = true;
            this.TLabelFechaInicio.Location = new System.Drawing.Point(21, 61);
            this.TLabelFechaInicio.Name = "TLabelFechaInicio";
            this.TLabelFechaInicio.Size = new System.Drawing.Size(67, 13);
            this.TLabelFechaInicio.TabIndex = 1;
            this.TLabelFechaInicio.Text = "Fecha entre:";
            this.TLabelFechaInicio.Visible = false;
            // 
            // TLabelFechaFin
            // 
            this.TLabelFechaFin.AutoSize = true;
            this.TLabelFechaFin.Location = new System.Drawing.Point(187, 61);
            this.TLabelFechaFin.Name = "TLabelFechaFin";
            this.TLabelFechaFin.Size = new System.Drawing.Size(12, 13);
            this.TLabelFechaFin.TabIndex = 2;
            this.TLabelFechaFin.Text = "y";
            this.TLabelFechaFin.Visible = false;
            // 
            // TDateTimePickerFechaInicio
            // 
            this.TDateTimePickerFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TDateTimePickerFechaInicio.Location = new System.Drawing.Point(95, 55);
            this.TDateTimePickerFechaInicio.Name = "TDateTimePickerFechaInicio";
            this.TDateTimePickerFechaInicio.Size = new System.Drawing.Size(86, 20);
            this.TDateTimePickerFechaInicio.TabIndex = 3;
            this.TDateTimePickerFechaInicio.Visible = false;
            // 
            // TDateTimePickerFechaFin
            // 
            this.TDateTimePickerFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TDateTimePickerFechaFin.Location = new System.Drawing.Point(205, 55);
            this.TDateTimePickerFechaFin.Name = "TDateTimePickerFechaFin";
            this.TDateTimePickerFechaFin.Size = new System.Drawing.Size(86, 20);
            this.TDateTimePickerFechaFin.TabIndex = 4;
            this.TDateTimePickerFechaFin.Visible = false;
            // 
            // TTextBoxNumeroReserva
            // 
            this.TTextBoxNumeroReserva.Location = new System.Drawing.Point(117, 22);
            this.TTextBoxNumeroReserva.Name = "TTextBoxNumeroReserva";
            this.TTextBoxNumeroReserva.Size = new System.Drawing.Size(36, 20);
            this.TTextBoxNumeroReserva.TabIndex = 5;
            // 
            // TButtonBuscarCliente
            // 
            this.TButtonBuscarCliente.Location = new System.Drawing.Point(24, 98);
            this.TButtonBuscarCliente.Name = "TButtonBuscarCliente";
            this.TButtonBuscarCliente.Size = new System.Drawing.Size(129, 23);
            this.TButtonBuscarCliente.TabIndex = 6;
            this.TButtonBuscarCliente.Text = "Buscar por Cliente";
            this.TButtonBuscarCliente.UseVisualStyleBackColor = true;
            this.TButtonBuscarCliente.Click += new System.EventHandler(this.TButtonBuscarCliente_Click);
            // 
            // TLabelCliente
            // 
            this.TLabelCliente.AutoSize = true;
            this.TLabelCliente.Location = new System.Drawing.Point(21, 103);
            this.TLabelCliente.Name = "TLabelCliente";
            this.TLabelCliente.Size = new System.Drawing.Size(35, 13);
            this.TLabelCliente.TabIndex = 7;
            this.TLabelCliente.Text = "label1";
            this.TLabelCliente.Visible = false;
            // 
            // TButtonCambiarCliente
            // 
            this.TButtonCambiarCliente.Location = new System.Drawing.Point(24, 132);
            this.TButtonCambiarCliente.Name = "TButtonCambiarCliente";
            this.TButtonCambiarCliente.Size = new System.Drawing.Size(100, 23);
            this.TButtonCambiarCliente.TabIndex = 8;
            this.TButtonCambiarCliente.Text = "Cambiar Cliente";
            this.TButtonCambiarCliente.UseVisualStyleBackColor = true;
            this.TButtonCambiarCliente.Visible = false;
            this.TButtonCambiarCliente.Click += new System.EventHandler(this.TButtonBuscarCliente_Click);
            // 
            // TButtonBuscar
            // 
            this.TButtonBuscar.Location = new System.Drawing.Point(190, 170);
            this.TButtonBuscar.Name = "TButtonBuscar";
            this.TButtonBuscar.Size = new System.Drawing.Size(75, 23);
            this.TButtonBuscar.TabIndex = 9;
            this.TButtonBuscar.Text = "Buscar";
            this.TButtonBuscar.UseVisualStyleBackColor = true;
            this.TButtonBuscar.Click += new System.EventHandler(this.TButtonBuscar_Click);
            // 
            // TButtonBuscarFechas
            // 
            this.TButtonBuscarFechas.Location = new System.Drawing.Point(24, 55);
            this.TButtonBuscarFechas.Name = "TButtonBuscarFechas";
            this.TButtonBuscarFechas.Size = new System.Drawing.Size(129, 23);
            this.TButtonBuscarFechas.TabIndex = 10;
            this.TButtonBuscarFechas.Text = "Buscar por Fechas";
            this.TButtonBuscarFechas.UseVisualStyleBackColor = true;
            this.TButtonBuscarFechas.Click += new System.EventHandler(this.TButtonBuscarFechas_Click);
            // 
            // TButtonOcultarFechas
            // 
            this.TButtonOcultarFechas.Location = new System.Drawing.Point(321, 55);
            this.TButtonOcultarFechas.Name = "TButtonOcultarFechas";
            this.TButtonOcultarFechas.Size = new System.Drawing.Size(97, 23);
            this.TButtonOcultarFechas.TabIndex = 11;
            this.TButtonOcultarFechas.Text = "Ocultar Fechas";
            this.TButtonOcultarFechas.UseVisualStyleBackColor = true;
            this.TButtonOcultarFechas.Visible = false;
            this.TButtonOcultarFechas.Click += new System.EventHandler(this.TButtonOcultarFechas_Click);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(8, 8);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(416, 195);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(439, 217);
            this.shapeContainer1.TabIndex = 12;
            this.shapeContainer1.TabStop = false;
            // 
            // TButtonEliminar
            // 
            this.TButtonEliminar.Location = new System.Drawing.Point(287, 170);
            this.TButtonEliminar.Name = "TButtonEliminar";
            this.TButtonEliminar.Size = new System.Drawing.Size(75, 23);
            this.TButtonEliminar.TabIndex = 13;
            this.TButtonEliminar.Text = "Eliminar";
            this.TButtonEliminar.UseVisualStyleBackColor = true;
            this.TButtonEliminar.Visible = false;
            // 
            // TButtonQuitarCliente
            // 
            this.TButtonQuitarCliente.Location = new System.Drawing.Point(141, 132);
            this.TButtonQuitarCliente.Name = "TButtonQuitarCliente";
            this.TButtonQuitarCliente.Size = new System.Drawing.Size(79, 23);
            this.TButtonQuitarCliente.TabIndex = 14;
            this.TButtonQuitarCliente.Text = "Quitar Cliente";
            this.TButtonQuitarCliente.UseVisualStyleBackColor = true;
            this.TButtonQuitarCliente.Visible = false;
            this.TButtonQuitarCliente.Click += new System.EventHandler(this.TButtonQuitarCliente_Click);
            // 
            // GestionReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AlquilerCoches.Properties.Resources.rentacar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 608);
            this.Controls.Add(this.TPanelReservas);
            this.Controls.Add(this.TButtonCerrar);
            this.Controls.Add(this.TDataGridViewReservas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(894, 608);
            this.MinimumSize = new System.Drawing.Size(894, 608);
            this.Name = "GestionReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionReservas";
            this.Load += new System.EventHandler(this.GestionReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TDataGridViewReservas)).EndInit();
            this.TPanelReservas.ResumeLayout(false);
            this.TPanelReservas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TDataGridViewReservas;
        private System.Windows.Forms.Button TButtonCerrar;
        private System.Windows.Forms.Panel TPanelReservas;
        private System.Windows.Forms.Button TButtonBuscar;
        private System.Windows.Forms.Button TButtonCambiarCliente;
        private System.Windows.Forms.Label TLabelCliente;
        private System.Windows.Forms.Button TButtonBuscarCliente;
        private System.Windows.Forms.TextBox TTextBoxNumeroReserva;
        private System.Windows.Forms.DateTimePicker TDateTimePickerFechaFin;
        private System.Windows.Forms.DateTimePicker TDateTimePickerFechaInicio;
        private System.Windows.Forms.Label TLabelFechaFin;
        private System.Windows.Forms.Label TLabelFechaInicio;
        private System.Windows.Forms.Label TLabelNRes;
        private System.Windows.Forms.Button TButtonBuscarFechas;
        private System.Windows.Forms.Button TButtonOcultarFechas;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Button TButtonEliminar;
        private System.Windows.Forms.Button TButtonQuitarCliente;
    }
}