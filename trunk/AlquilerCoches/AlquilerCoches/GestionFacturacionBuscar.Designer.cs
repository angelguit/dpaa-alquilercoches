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
            this.components = new System.ComponentModel.Container();
            this.TButtonEliminar = new System.Windows.Forms.Button();
            this.TButtonBuscar = new System.Windows.Forms.Button();
            this.TDataGridBuscarFacturas = new System.Windows.Forms.DataGridView();
            this.TPanelReservas = new System.Windows.Forms.Panel();
            this.TButtonQuitarCliente = new System.Windows.Forms.Button();
            this.TButtonOcultarFechas = new System.Windows.Forms.Button();
            this.TButtonBuscarFechas = new System.Windows.Forms.Button();
            this.TButtonCambiarCliente = new System.Windows.Forms.Button();
            this.TLabelCliente = new System.Windows.Forms.Label();
            this.TButtonBuscarCliente = new System.Windows.Forms.Button();
            this.TTextBoxNumeroFactura = new System.Windows.Forms.TextBox();
            this.TDateTimePickerFechaFin = new System.Windows.Forms.DateTimePicker();
            this.TDateTimePickerFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.TLabelFechaFin = new System.Windows.Forms.Label();
            this.TLabelFechaInicio = new System.Windows.Forms.Label();
            this.TLabelNFactura = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TButtonCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TDataGridBuscarFacturas)).BeginInit();
            this.TPanelReservas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TButtonEliminar
            // 
            this.TButtonEliminar.Image = global::AlquilerCoches.Properties.Resources.Delete_icon;
            this.TButtonEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TButtonEliminar.Location = new System.Drawing.Point(368, 166);
            this.TButtonEliminar.Name = "TButtonEliminar";
            this.TButtonEliminar.Size = new System.Drawing.Size(79, 34);
            this.TButtonEliminar.TabIndex = 57;
            this.TButtonEliminar.Text = "Eliminar";
            this.TButtonEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TButtonEliminar.UseVisualStyleBackColor = true;
            this.TButtonEliminar.Visible = false;
            // 
            // TButtonBuscar
            // 
            this.TButtonBuscar.Image = global::AlquilerCoches.Properties.Resources.Search_icon;
            this.TButtonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TButtonBuscar.Location = new System.Drawing.Point(254, 166);
            this.TButtonBuscar.Name = "TButtonBuscar";
            this.TButtonBuscar.Size = new System.Drawing.Size(82, 34);
            this.TButtonBuscar.TabIndex = 54;
            this.TButtonBuscar.Text = "Buscar";
            this.TButtonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TButtonBuscar.UseVisualStyleBackColor = true;
            this.TButtonBuscar.Click += new System.EventHandler(this.TButtonBuscar_Click);
            // 
            // TDataGridBuscarFacturas
            // 
            this.TDataGridBuscarFacturas.AllowUserToAddRows = false;
            this.TDataGridBuscarFacturas.AllowUserToDeleteRows = false;
            this.TDataGridBuscarFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TDataGridBuscarFacturas.Location = new System.Drawing.Point(62, 38);
            this.TDataGridBuscarFacturas.Name = "TDataGridBuscarFacturas";
            this.TDataGridBuscarFacturas.Size = new System.Drawing.Size(729, 243);
            this.TDataGridBuscarFacturas.TabIndex = 53;
            this.TDataGridBuscarFacturas.Visible = false;
            this.TDataGridBuscarFacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TDataGridBuscarFacturas_CellContentClick);
            // 
            // TPanelReservas
            // 
            this.TPanelReservas.BackColor = System.Drawing.Color.Transparent;
            this.TPanelReservas.Controls.Add(this.TButtonEliminar);
            this.TPanelReservas.Controls.Add(this.TButtonBuscar);
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
            this.TPanelReservas.Location = new System.Drawing.Point(62, 39);
            this.TPanelReservas.Name = "TPanelReservas";
            this.TPanelReservas.Size = new System.Drawing.Size(462, 208);
            this.TPanelReservas.TabIndex = 58;
            // 
            // TButtonQuitarCliente
            // 
            this.TButtonQuitarCliente.Location = new System.Drawing.Point(164, 129);
            this.TButtonQuitarCliente.Name = "TButtonQuitarCliente";
            this.TButtonQuitarCliente.Size = new System.Drawing.Size(79, 23);
            this.TButtonQuitarCliente.TabIndex = 14;
            this.TButtonQuitarCliente.Text = "Quitar Cliente";
            this.TButtonQuitarCliente.UseVisualStyleBackColor = true;
            this.TButtonQuitarCliente.Visible = false;
            this.TButtonQuitarCliente.Click += new System.EventHandler(this.TButtonQuitarCliente_Click_1);
            // 
            // TButtonOcultarFechas
            // 
            this.TButtonOcultarFechas.Location = new System.Drawing.Point(310, 50);
            this.TButtonOcultarFechas.Name = "TButtonOcultarFechas";
            this.TButtonOcultarFechas.Size = new System.Drawing.Size(97, 23);
            this.TButtonOcultarFechas.TabIndex = 11;
            this.TButtonOcultarFechas.Text = "Ocultar Fechas";
            this.TButtonOcultarFechas.UseVisualStyleBackColor = true;
            this.TButtonOcultarFechas.Visible = false;
            this.TButtonOcultarFechas.Click += new System.EventHandler(this.TButtonOcultarFechas_Click);
            // 
            // TButtonBuscarFechas
            // 
            this.TButtonBuscarFechas.Location = new System.Drawing.Point(31, 50);
            this.TButtonBuscarFechas.Name = "TButtonBuscarFechas";
            this.TButtonBuscarFechas.Size = new System.Drawing.Size(129, 23);
            this.TButtonBuscarFechas.TabIndex = 10;
            this.TButtonBuscarFechas.Text = "Buscar por Fechas";
            this.TButtonBuscarFechas.UseVisualStyleBackColor = true;
            this.TButtonBuscarFechas.Click += new System.EventHandler(this.TButtonBuscarFechas_Click);
            // 
            // TButtonCambiarCliente
            // 
            this.TButtonCambiarCliente.Location = new System.Drawing.Point(31, 129);
            this.TButtonCambiarCliente.Name = "TButtonCambiarCliente";
            this.TButtonCambiarCliente.Size = new System.Drawing.Size(100, 23);
            this.TButtonCambiarCliente.TabIndex = 8;
            this.TButtonCambiarCliente.Text = "Cambiar Cliente";
            this.TButtonCambiarCliente.UseVisualStyleBackColor = true;
            this.TButtonCambiarCliente.Visible = false;
            this.TButtonCambiarCliente.Click += new System.EventHandler(this.TButtonBuscarCliente_Click);
            // 
            // TLabelCliente
            // 
            this.TLabelCliente.AutoSize = true;
            this.TLabelCliente.Location = new System.Drawing.Point(33, 93);
            this.TLabelCliente.Name = "TLabelCliente";
            this.TLabelCliente.Size = new System.Drawing.Size(35, 13);
            this.TLabelCliente.TabIndex = 7;
            this.TLabelCliente.Text = "label1";
            this.TLabelCliente.Visible = false;
            // 
            // TButtonBuscarCliente
            // 
            this.TButtonBuscarCliente.Location = new System.Drawing.Point(31, 88);
            this.TButtonBuscarCliente.Name = "TButtonBuscarCliente";
            this.TButtonBuscarCliente.Size = new System.Drawing.Size(129, 23);
            this.TButtonBuscarCliente.TabIndex = 6;
            this.TButtonBuscarCliente.Text = "Buscar por Cliente";
            this.TButtonBuscarCliente.UseVisualStyleBackColor = true;
            this.TButtonBuscarCliente.Click += new System.EventHandler(this.TButtonBuscarCliente_Click);
            // 
            // TTextBoxNumeroFactura
            // 
            this.TTextBoxNumeroFactura.Location = new System.Drawing.Point(128, 15);
            this.TTextBoxNumeroFactura.Name = "TTextBoxNumeroFactura";
            this.TTextBoxNumeroFactura.Size = new System.Drawing.Size(36, 20);
            this.TTextBoxNumeroFactura.TabIndex = 5;
            // 
            // TDateTimePickerFechaFin
            // 
            this.TDateTimePickerFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TDateTimePickerFechaFin.Location = new System.Drawing.Point(194, 50);
            this.TDateTimePickerFechaFin.Name = "TDateTimePickerFechaFin";
            this.TDateTimePickerFechaFin.Size = new System.Drawing.Size(86, 20);
            this.TDateTimePickerFechaFin.TabIndex = 4;
            this.TDateTimePickerFechaFin.Visible = false;
            // 
            // TDateTimePickerFechaInicio
            // 
            this.TDateTimePickerFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TDateTimePickerFechaInicio.Location = new System.Drawing.Point(84, 50);
            this.TDateTimePickerFechaInicio.Name = "TDateTimePickerFechaInicio";
            this.TDateTimePickerFechaInicio.Size = new System.Drawing.Size(86, 20);
            this.TDateTimePickerFechaInicio.TabIndex = 3;
            this.TDateTimePickerFechaInicio.Visible = false;
            // 
            // TLabelFechaFin
            // 
            this.TLabelFechaFin.AutoSize = true;
            this.TLabelFechaFin.Location = new System.Drawing.Point(176, 56);
            this.TLabelFechaFin.Name = "TLabelFechaFin";
            this.TLabelFechaFin.Size = new System.Drawing.Size(12, 13);
            this.TLabelFechaFin.TabIndex = 2;
            this.TLabelFechaFin.Text = "y";
            this.TLabelFechaFin.Visible = false;
            // 
            // TLabelFechaInicio
            // 
            this.TLabelFechaInicio.AutoSize = true;
            this.TLabelFechaInicio.Location = new System.Drawing.Point(11, 56);
            this.TLabelFechaInicio.Name = "TLabelFechaInicio";
            this.TLabelFechaInicio.Size = new System.Drawing.Size(67, 13);
            this.TLabelFechaInicio.TabIndex = 1;
            this.TLabelFechaInicio.Text = "Fecha entre:";
            this.TLabelFechaInicio.Visible = false;
            // 
            // TLabelNFactura
            // 
            this.TLabelNFactura.AutoSize = true;
            this.TLabelNFactura.Location = new System.Drawing.Point(32, 18);
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
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(462, 208);
            this.shapeContainer1.TabIndex = 58;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BorderColor = System.Drawing.Color.White;
            this.rectangleShape2.Location = new System.Drawing.Point(6, 5);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(449, 205);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.White;
            this.rectangleShape1.Location = new System.Drawing.Point(-107, -7);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(86, 217);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TButtonCerrar
            // 
            this.TButtonCerrar.Image = global::AlquilerCoches.Properties.Resources.Close_icon;
            this.TButtonCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TButtonCerrar.Location = new System.Drawing.Point(28, 559);
            this.TButtonCerrar.Name = "TButtonCerrar";
            this.TButtonCerrar.Size = new System.Drawing.Size(102, 37);
            this.TButtonCerrar.TabIndex = 59;
            this.TButtonCerrar.Text = "Cerrar";
            this.TButtonCerrar.UseVisualStyleBackColor = true;
            this.TButtonCerrar.Click += new System.EventHandler(this.TButtonCerrar_Click);
            // 
            // GestionFacturacionBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AlquilerCoches.Properties.Resources.rentacar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 608);
            this.Controls.Add(this.TButtonCerrar);
            this.Controls.Add(this.TPanelReservas);
            this.Controls.Add(this.TDataGridBuscarFacturas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionFacturacionBuscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionBuscarFacturacion";
            ((System.ComponentModel.ISupportInitialize)(this.TDataGridBuscarFacturas)).EndInit();
            this.TPanelReservas.ResumeLayout(false);
            this.TPanelReservas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TButtonEliminar;
        private System.Windows.Forms.Button TButtonBuscar;
        private System.Windows.Forms.DataGridView TDataGridBuscarFacturas;
        private System.Windows.Forms.Panel TPanelReservas;
        private System.Windows.Forms.Button TButtonQuitarCliente;
        private System.Windows.Forms.Button TButtonCambiarCliente;
        private System.Windows.Forms.Button TButtonBuscarCliente;
        private System.Windows.Forms.TextBox TTextBoxNumeroFactura;
        private System.Windows.Forms.Label TLabelNFactura;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Button TButtonBuscarFechas;
        private System.Windows.Forms.Label TLabelCliente;
        private System.Windows.Forms.Label TLabelFechaInicio;
        private System.Windows.Forms.Button TButtonOcultarFechas;
        private System.Windows.Forms.DateTimePicker TDateTimePickerFechaFin;
        private System.Windows.Forms.DateTimePicker TDateTimePickerFechaInicio;
        private System.Windows.Forms.Label TLabelFechaFin;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private System.Windows.Forms.Button TButtonCerrar;
    }
}