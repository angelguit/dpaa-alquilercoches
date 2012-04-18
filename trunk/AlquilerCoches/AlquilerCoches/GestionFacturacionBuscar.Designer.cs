namespace AlquilerCoches
{
    partial class GestionFacturacionBuscar
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
            this.TButtonEliminar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TButtonBuscar = new System.Windows.Forms.Button();
            this.dataGridBuscarFacturas = new System.Windows.Forms.DataGridView();
            this.TPanelReservas = new System.Windows.Forms.Panel();
            this.TButtonQuitarCliente = new System.Windows.Forms.Button();
            this.TButtonCambiarCliente = new System.Windows.Forms.Button();
            this.TButtonBuscarCliente = new System.Windows.Forms.Button();
            this.TTextBoxNumeroFactura = new System.Windows.Forms.TextBox();
            this.TLabelNFactura = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.TLabelFechaInicio = new System.Windows.Forms.Label();
            this.TButtonBuscarFechas = new System.Windows.Forms.Button();
            this.TLabelCliente = new System.Windows.Forms.Label();
            this.TDateTimePickerFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.TLabelFechaFin = new System.Windows.Forms.Label();
            this.TButtonOcultarFechas = new System.Windows.Forms.Button();
            this.TDateTimePickerFechaFin = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBuscarFacturas)).BeginInit();
            this.TPanelReservas.SuspendLayout();
            this.SuspendLayout();
            // 
            // TButtonEliminar
            // 
            this.TButtonEliminar.Location = new System.Drawing.Point(174, 518);
            this.TButtonEliminar.Name = "TButtonEliminar";
            this.TButtonEliminar.Size = new System.Drawing.Size(75, 23);
            this.TButtonEliminar.TabIndex = 57;
            this.TButtonEliminar.Text = "Eliminar";
            this.TButtonEliminar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 55;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TButtonBuscar
            // 
            this.TButtonBuscar.Location = new System.Drawing.Point(78, 518);
            this.TButtonBuscar.Name = "TButtonBuscar";
            this.TButtonBuscar.Size = new System.Drawing.Size(75, 23);
            this.TButtonBuscar.TabIndex = 54;
            this.TButtonBuscar.Text = "Buscar";
            this.TButtonBuscar.UseVisualStyleBackColor = true;
            this.TButtonBuscar.Click += new System.EventHandler(this.TButtonBuscar_Click);
            // 
            // dataGridBuscarFacturas
            // 
            this.dataGridBuscarFacturas.AllowUserToOrderColumns = true;
            this.dataGridBuscarFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBuscarFacturas.Location = new System.Drawing.Point(78, 29);
            this.dataGridBuscarFacturas.Name = "dataGridBuscarFacturas";
            this.dataGridBuscarFacturas.Size = new System.Drawing.Size(722, 209);
            this.dataGridBuscarFacturas.TabIndex = 53;
            // 
            // TPanelReservas
            // 
            this.TPanelReservas.BackColor = System.Drawing.Color.Transparent;
            this.TPanelReservas.Controls.Add(this.TButtonQuitarCliente);
            this.TPanelReservas.Controls.Add(this.TButtonOcultarFechas);
            this.TPanelReservas.Controls.Add(this.TButtonBuscarFechas);
            this.TPanelReservas.Controls.Add(this.TButtonCambiarCliente);
            this.TPanelReservas.Controls.Add(this.TLabelCliente);
            this.TPanelReservas.Controls.Add(this.TButtonBuscarCliente);
            this.TPanelReservas.Controls.Add(this.TTextBoxNumeroFactura);
            this.TPanelReservas.Controls.Add(this.TDateTimePickerFechaFin);
            this.TPanelReservas.Controls.Add(this.TDateTimePickerFechaInicio);
            this.TPanelReservas.Controls.Add(this.TLabelFechaFin);
            this.TPanelReservas.Controls.Add(this.TLabelFechaInicio);
            this.TPanelReservas.Controls.Add(this.TLabelNFactura);
            this.TPanelReservas.Controls.Add(this.shapeContainer1);
            this.TPanelReservas.Location = new System.Drawing.Point(78, 29);
            this.TPanelReservas.Name = "TPanelReservas";
            this.TPanelReservas.Size = new System.Drawing.Size(615, 433);
            this.TPanelReservas.TabIndex = 58;
            // 
            // TButtonQuitarCliente
            // 
            this.TButtonQuitarCliente.Location = new System.Drawing.Point(141, 335);
            this.TButtonQuitarCliente.Name = "TButtonQuitarCliente";
            this.TButtonQuitarCliente.Size = new System.Drawing.Size(79, 23);
            this.TButtonQuitarCliente.TabIndex = 14;
            this.TButtonQuitarCliente.Text = "Quitar Cliente";
            this.TButtonQuitarCliente.UseVisualStyleBackColor = true;
            this.TButtonQuitarCliente.Visible = false;
            // 
            // TButtonCambiarCliente
            // 
            this.TButtonCambiarCliente.Location = new System.Drawing.Point(24, 335);
            this.TButtonCambiarCliente.Name = "TButtonCambiarCliente";
            this.TButtonCambiarCliente.Size = new System.Drawing.Size(100, 23);
            this.TButtonCambiarCliente.TabIndex = 8;
            this.TButtonCambiarCliente.Text = "Cambiar Cliente";
            this.TButtonCambiarCliente.UseVisualStyleBackColor = true;
            this.TButtonCambiarCliente.Visible = false;
            // 
            // TButtonBuscarCliente
            // 
            this.TButtonBuscarCliente.Location = new System.Drawing.Point(24, 301);
            this.TButtonBuscarCliente.Name = "TButtonBuscarCliente";
            this.TButtonBuscarCliente.Size = new System.Drawing.Size(129, 23);
            this.TButtonBuscarCliente.TabIndex = 6;
            this.TButtonBuscarCliente.Text = "Buscar por Cliente";
            this.TButtonBuscarCliente.UseVisualStyleBackColor = true;
            this.TButtonBuscarCliente.Click += new System.EventHandler(this.TButtonBuscarCliente_Click);
            // 
            // TTextBoxNumeroFactura
            // 
            this.TTextBoxNumeroFactura.Location = new System.Drawing.Point(117, 22);
            this.TTextBoxNumeroFactura.Name = "TTextBoxNumeroFactura";
            this.TTextBoxNumeroFactura.Size = new System.Drawing.Size(36, 20);
            this.TTextBoxNumeroFactura.TabIndex = 5;
            // 
            // TLabelNFactura
            // 
            this.TLabelNFactura.AutoSize = true;
            this.TLabelNFactura.Location = new System.Drawing.Point(21, 25);
            this.TLabelNFactura.Name = "TLabelNFactura";
            this.TLabelNFactura.Size = new System.Drawing.Size(86, 13);
            this.TLabelNFactura.TabIndex = 0;
            this.TLabelNFactura.Text = "Numero Factura:";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(615, 433);
            this.shapeContainer1.TabIndex = 12;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(8, 8);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(590, 412);
            // 
            // TLabelFechaInicio
            // 
            this.TLabelFechaInicio.AutoSize = true;
            this.TLabelFechaInicio.Location = new System.Drawing.Point(22, 192);
            this.TLabelFechaInicio.Name = "TLabelFechaInicio";
            this.TLabelFechaInicio.Size = new System.Drawing.Size(67, 13);
            this.TLabelFechaInicio.TabIndex = 1;
            this.TLabelFechaInicio.Text = "Fecha entre:";
            this.TLabelFechaInicio.Visible = false;
            // 
            // TButtonBuscarFechas
            // 
            this.TButtonBuscarFechas.Location = new System.Drawing.Point(24, 186);
            this.TButtonBuscarFechas.Name = "TButtonBuscarFechas";
            this.TButtonBuscarFechas.Size = new System.Drawing.Size(129, 23);
            this.TButtonBuscarFechas.TabIndex = 10;
            this.TButtonBuscarFechas.Text = "Buscar por Fechas";
            this.TButtonBuscarFechas.UseVisualStyleBackColor = true;
            this.TButtonBuscarFechas.Click += new System.EventHandler(this.TButtonBuscarFechas_Click);
            // 
            // TLabelCliente
            // 
            this.TLabelCliente.AutoSize = true;
            this.TLabelCliente.Location = new System.Drawing.Point(21, 306);
            this.TLabelCliente.Name = "TLabelCliente";
            this.TLabelCliente.Size = new System.Drawing.Size(35, 13);
            this.TLabelCliente.TabIndex = 7;
            this.TLabelCliente.Text = "label1";
            this.TLabelCliente.Visible = false;
            // 
            // TDateTimePickerFechaInicio
            // 
            this.TDateTimePickerFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TDateTimePickerFechaInicio.Location = new System.Drawing.Point(95, 186);
            this.TDateTimePickerFechaInicio.Name = "TDateTimePickerFechaInicio";
            this.TDateTimePickerFechaInicio.Size = new System.Drawing.Size(86, 20);
            this.TDateTimePickerFechaInicio.TabIndex = 3;
            this.TDateTimePickerFechaInicio.Visible = false;
            // 
            // TLabelFechaFin
            // 
            this.TLabelFechaFin.AutoSize = true;
            this.TLabelFechaFin.Location = new System.Drawing.Point(187, 192);
            this.TLabelFechaFin.Name = "TLabelFechaFin";
            this.TLabelFechaFin.Size = new System.Drawing.Size(12, 13);
            this.TLabelFechaFin.TabIndex = 2;
            this.TLabelFechaFin.Text = "y";
            this.TLabelFechaFin.Visible = false;
            // 
            // TButtonOcultarFechas
            // 
            this.TButtonOcultarFechas.Location = new System.Drawing.Point(321, 186);
            this.TButtonOcultarFechas.Name = "TButtonOcultarFechas";
            this.TButtonOcultarFechas.Size = new System.Drawing.Size(97, 23);
            this.TButtonOcultarFechas.TabIndex = 11;
            this.TButtonOcultarFechas.Text = "Ocultar Fechas";
            this.TButtonOcultarFechas.UseVisualStyleBackColor = true;
            this.TButtonOcultarFechas.Visible = false;
            this.TButtonOcultarFechas.Click += new System.EventHandler(this.TButtonOcultarFechas_Click);
            // 
            // TDateTimePickerFechaFin
            // 
            this.TDateTimePickerFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TDateTimePickerFechaFin.Location = new System.Drawing.Point(205, 186);
            this.TDateTimePickerFechaFin.Name = "TDateTimePickerFechaFin";
            this.TDateTimePickerFechaFin.Size = new System.Drawing.Size(86, 20);
            this.TDateTimePickerFechaFin.TabIndex = 4;
            this.TDateTimePickerFechaFin.Visible = false;
            // 
            // GestionFacturacionBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AlquilerCoches.Properties.Resources.rentacar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 570);
            this.Controls.Add(this.TPanelReservas);
            this.Controls.Add(this.TButtonEliminar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TButtonBuscar);
            this.Controls.Add(this.dataGridBuscarFacturas);
            this.Name = "GestionFacturacionBuscar";
            this.Text = "GestionBuscarFacturacion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBuscarFacturas)).EndInit();
            this.TPanelReservas.ResumeLayout(false);
            this.TPanelReservas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TButtonEliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button TButtonBuscar;
        private System.Windows.Forms.DataGridView dataGridBuscarFacturas;
        private System.Windows.Forms.Panel TPanelReservas;
        private System.Windows.Forms.Button TButtonQuitarCliente;
        private System.Windows.Forms.Button TButtonCambiarCliente;
        private System.Windows.Forms.Button TButtonBuscarCliente;
        private System.Windows.Forms.TextBox TTextBoxNumeroFactura;
        private System.Windows.Forms.Label TLabelNFactura;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Button TButtonBuscarFechas;
        private System.Windows.Forms.Label TLabelCliente;
        private System.Windows.Forms.Label TLabelFechaInicio;
        private System.Windows.Forms.Button TButtonOcultarFechas;
        private System.Windows.Forms.DateTimePicker TDateTimePickerFechaFin;
        private System.Windows.Forms.DateTimePicker TDateTimePickerFechaInicio;
        private System.Windows.Forms.Label TLabelFechaFin;
    }
}