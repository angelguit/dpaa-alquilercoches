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
            this.TButtonBuscarCliente = new System.Windows.Forms.Button();
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
            this.TLabelMarca = new System.Windows.Forms.Label();
            this.TComboBoxMarca = new System.Windows.Forms.ComboBox();
            this.TButtonCerrar = new System.Windows.Forms.Button();
            this.TLabelInfoCliente = new System.Windows.Forms.Label();
            this.TButtonEditar = new System.Windows.Forms.Button();
            this.TButtonBuscarOtro = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.TRectangleShapeCliente = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.TRectangleShaperReservas = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.TLabelInfoVehiculo = new System.Windows.Forms.Label();
            this.TLabelDNI = new System.Windows.Forms.Label();
            this.TLabelNombre = new System.Windows.Forms.Label();
            this.TLabelDirec = new System.Windows.Forms.Label();
            this.TLabelTitulo = new System.Windows.Forms.Label();
            this.TRadioButtonFavorito = new System.Windows.Forms.RadioButton();
            this.TRadioButtonUltimoCoche = new System.Windows.Forms.RadioButton();
            this.TLabelResRapida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TButtonBuscarCliente
            // 
            this.TButtonBuscarCliente.Image = global::AlquilerCoches.Properties.Resources.Search_icon2;
            this.TButtonBuscarCliente.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TButtonBuscarCliente.Location = new System.Drawing.Point(375, 67);
            this.TButtonBuscarCliente.Name = "TButtonBuscarCliente";
            this.TButtonBuscarCliente.Size = new System.Drawing.Size(144, 76);
            this.TButtonBuscarCliente.TabIndex = 26;
            this.TButtonBuscarCliente.Text = "Buscar Cliente";
            this.TButtonBuscarCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TButtonBuscarCliente.UseVisualStyleBackColor = true;
            this.TButtonBuscarCliente.Click += new System.EventHandler(this.TButtonBuscarCliente_Click);
            // 
            // TComboBoxCategoria
            // 
            this.TComboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TComboBoxCategoria.FormattingEnabled = true;
            this.TComboBoxCategoria.Location = new System.Drawing.Point(258, 232);
            this.TComboBoxCategoria.Name = "TComboBoxCategoria";
            this.TComboBoxCategoria.Size = new System.Drawing.Size(121, 21);
            this.TComboBoxCategoria.TabIndex = 27;
            this.TComboBoxCategoria.TextChanged += new System.EventHandler(this.TComboBoxCategoria_TextChanged);
            // 
            // TComboBoxModelo
            // 
            this.TComboBoxModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TComboBoxModelo.FormattingEnabled = true;
            this.TComboBoxModelo.Location = new System.Drawing.Point(258, 308);
            this.TComboBoxModelo.Name = "TComboBoxModelo";
            this.TComboBoxModelo.Size = new System.Drawing.Size(121, 21);
            this.TComboBoxModelo.TabIndex = 28;
            this.TComboBoxModelo.TextChanged += new System.EventHandler(this.TComboBoxModelo_TextChanged);
            // 
            // TLabelCategoria
            // 
            this.TLabelCategoria.AutoSize = true;
            this.TLabelCategoria.BackColor = System.Drawing.Color.Transparent;
            this.TLabelCategoria.Location = new System.Drawing.Point(197, 235);
            this.TLabelCategoria.Name = "TLabelCategoria";
            this.TLabelCategoria.Size = new System.Drawing.Size(55, 13);
            this.TLabelCategoria.TabIndex = 29;
            this.TLabelCategoria.Text = "Categoria:";
            // 
            // TLabelModelo
            // 
            this.TLabelModelo.AutoSize = true;
            this.TLabelModelo.BackColor = System.Drawing.Color.Transparent;
            this.TLabelModelo.Location = new System.Drawing.Point(206, 316);
            this.TLabelModelo.Name = "TLabelModelo";
            this.TLabelModelo.Size = new System.Drawing.Size(45, 13);
            this.TLabelModelo.TabIndex = 30;
            this.TLabelModelo.Text = "Modelo:";
            // 
            // TLabelMatricula
            // 
            this.TLabelMatricula.AutoSize = true;
            this.TLabelMatricula.BackColor = System.Drawing.Color.Transparent;
            this.TLabelMatricula.Location = new System.Drawing.Point(199, 353);
            this.TLabelMatricula.Name = "TLabelMatricula";
            this.TLabelMatricula.Size = new System.Drawing.Size(53, 13);
            this.TLabelMatricula.TabIndex = 31;
            this.TLabelMatricula.Text = "Matricula:";
            // 
            // TComboBoxMatricula
            // 
            this.TComboBoxMatricula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TComboBoxMatricula.FormattingEnabled = true;
            this.TComboBoxMatricula.Location = new System.Drawing.Point(258, 350);
            this.TComboBoxMatricula.Name = "TComboBoxMatricula";
            this.TComboBoxMatricula.Size = new System.Drawing.Size(121, 21);
            this.TComboBoxMatricula.TabIndex = 32;
            this.TComboBoxMatricula.TextChanged += new System.EventHandler(this.TComboBoxMatricula_TextChanged);
            // 
            // TLabelConductores
            // 
            this.TLabelConductores.AutoSize = true;
            this.TLabelConductores.BackColor = System.Drawing.Color.Transparent;
            this.TLabelConductores.Location = new System.Drawing.Point(500, 235);
            this.TLabelConductores.Name = "TLabelConductores";
            this.TLabelConductores.Size = new System.Drawing.Size(70, 13);
            this.TLabelConductores.TabIndex = 33;
            this.TLabelConductores.Text = "Conductores:";
            // 
            // TComboBoxConductores
            // 
            this.TComboBoxConductores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.TComboBoxConductores.Location = new System.Drawing.Point(576, 232);
            this.TComboBoxConductores.Name = "TComboBoxConductores";
            this.TComboBoxConductores.Size = new System.Drawing.Size(61, 21);
            this.TComboBoxConductores.TabIndex = 34;
            this.TComboBoxConductores.TextChanged += new System.EventHandler(this.TComboBoxConductores_TextChanged);
            // 
            // TLabelFechaInicio
            // 
            this.TLabelFechaInicio.AutoSize = true;
            this.TLabelFechaInicio.BackColor = System.Drawing.Color.Transparent;
            this.TLabelFechaInicio.Location = new System.Drawing.Point(500, 329);
            this.TLabelFechaInicio.Name = "TLabelFechaInicio";
            this.TLabelFechaInicio.Size = new System.Drawing.Size(68, 13);
            this.TLabelFechaInicio.TabIndex = 35;
            this.TLabelFechaInicio.Text = "Fecha Inicio:";
            // 
            // TDateTimePickerFechaInicio
            // 
            this.TDateTimePickerFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TDateTimePickerFechaInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TDateTimePickerFechaInicio.Location = new System.Drawing.Point(574, 326);
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
            this.TLabelFechaFin.Location = new System.Drawing.Point(511, 359);
            this.TLabelFechaFin.Name = "TLabelFechaFin";
            this.TLabelFechaFin.Size = new System.Drawing.Size(57, 13);
            this.TLabelFechaFin.TabIndex = 37;
            this.TLabelFechaFin.Text = "Fecha Fin:";
            // 
            // TDateTimePickerFechaFin
            // 
            this.TDateTimePickerFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TDateTimePickerFechaFin.Location = new System.Drawing.Point(574, 352);
            this.TDateTimePickerFechaFin.Name = "TDateTimePickerFechaFin";
            this.TDateTimePickerFechaFin.Size = new System.Drawing.Size(98, 20);
            this.TDateTimePickerFechaFin.TabIndex = 38;
            this.TDateTimePickerFechaFin.ValueChanged += new System.EventHandler(this.TDateTimePickerFechaFin_ValueChanged);
            // 
            // TButtonReserva
            // 
            this.TButtonReserva.Image = global::AlquilerCoches.Properties.Resources.Accept_icon;
            this.TButtonReserva.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TButtonReserva.Location = new System.Drawing.Point(268, 503);
            this.TButtonReserva.Name = "TButtonReserva";
            this.TButtonReserva.Size = new System.Drawing.Size(125, 78);
            this.TButtonReserva.TabIndex = 39;
            this.TButtonReserva.Text = "Realizar Reserva";
            this.TButtonReserva.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TButtonReserva.UseVisualStyleBackColor = true;
            this.TButtonReserva.Click += new System.EventHandler(this.TButtonReserva_Click);
            // 
            // TLabelMarca
            // 
            this.TLabelMarca.AutoSize = true;
            this.TLabelMarca.BackColor = System.Drawing.Color.Transparent;
            this.TLabelMarca.Location = new System.Drawing.Point(211, 275);
            this.TLabelMarca.Name = "TLabelMarca";
            this.TLabelMarca.Size = new System.Drawing.Size(40, 13);
            this.TLabelMarca.TabIndex = 43;
            this.TLabelMarca.Text = "Marca:";
            // 
            // TComboBoxMarca
            // 
            this.TComboBoxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TComboBoxMarca.FormattingEnabled = true;
            this.TComboBoxMarca.Location = new System.Drawing.Point(258, 272);
            this.TComboBoxMarca.Name = "TComboBoxMarca";
            this.TComboBoxMarca.Size = new System.Drawing.Size(121, 21);
            this.TComboBoxMarca.TabIndex = 44;
            this.TComboBoxMarca.TextChanged += new System.EventHandler(this.TComboBoxMarca_TextChanged);
            // 
            // TButtonCerrar
            // 
            this.TButtonCerrar.Image = global::AlquilerCoches.Properties.Resources.Close_icon;
            this.TButtonCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TButtonCerrar.Location = new System.Drawing.Point(45, 524);
            this.TButtonCerrar.Name = "TButtonCerrar";
            this.TButtonCerrar.Size = new System.Drawing.Size(94, 36);
            this.TButtonCerrar.TabIndex = 47;
            this.TButtonCerrar.Text = "      Cerrar";
            this.TButtonCerrar.UseVisualStyleBackColor = true;
            this.TButtonCerrar.Click += new System.EventHandler(this.TButtonCerrar_Click);
            // 
            // TLabelInfoCliente
            // 
            this.TLabelInfoCliente.AutoSize = true;
            this.TLabelInfoCliente.BackColor = System.Drawing.Color.Transparent;
            this.TLabelInfoCliente.Location = new System.Drawing.Point(197, 49);
            this.TLabelInfoCliente.Name = "TLabelInfoCliente";
            this.TLabelInfoCliente.Size = new System.Drawing.Size(111, 13);
            this.TLabelInfoCliente.TabIndex = 48;
            this.TLabelInfoCliente.Text = "Información de cliente";
            this.TLabelInfoCliente.Visible = false;
            // 
            // TButtonEditar
            // 
            this.TButtonEditar.Image = global::AlquilerCoches.Properties.Resources.Edit_icon2;
            this.TButtonEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TButtonEditar.Location = new System.Drawing.Point(720, 143);
            this.TButtonEditar.Name = "TButtonEditar";
            this.TButtonEditar.Size = new System.Drawing.Size(135, 35);
            this.TButtonEditar.TabIndex = 50;
            this.TButtonEditar.Text = "Editar Cliente";
            this.TButtonEditar.UseVisualStyleBackColor = true;
            this.TButtonEditar.Visible = false;
            this.TButtonEditar.Click += new System.EventHandler(this.TButtonEditar_Click);
            // 
            // TButtonBuscarOtro
            // 
            this.TButtonBuscarOtro.Image = global::AlquilerCoches.Properties.Resources.Search_icon;
            this.TButtonBuscarOtro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TButtonBuscarOtro.Location = new System.Drawing.Point(720, 76);
            this.TButtonBuscarOtro.Name = "TButtonBuscarOtro";
            this.TButtonBuscarOtro.Size = new System.Drawing.Size(135, 35);
            this.TButtonBuscarOtro.TabIndex = 51;
            this.TButtonBuscarOtro.Text = "Buscar Cliente";
            this.TButtonBuscarOtro.UseVisualStyleBackColor = true;
            this.TButtonBuscarOtro.Visible = false;
            this.TButtonBuscarOtro.Click += new System.EventHandler(this.TButtonBuscarCliente_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.TRectangleShapeCliente,
            this.TRectangleShaperReservas});
            this.shapeContainer1.Size = new System.Drawing.Size(894, 608);
            this.shapeContainer1.TabIndex = 52;
            this.shapeContainer1.TabStop = false;
            // 
            // TRectangleShapeCliente
            // 
            this.TRectangleShapeCliente.BorderColor = System.Drawing.Color.White;
            this.TRectangleShapeCliente.Location = new System.Drawing.Point(178, 56);
            this.TRectangleShapeCliente.Name = "TRectangleShapeCliente";
            this.TRectangleShapeCliente.Size = new System.Drawing.Size(529, 137);
            this.TRectangleShapeCliente.Visible = false;
            // 
            // TRectangleShaperReservas
            // 
            this.TRectangleShaperReservas.BorderColor = System.Drawing.Color.White;
            this.TRectangleShaperReservas.Location = new System.Drawing.Point(178, 215);
            this.TRectangleShaperReservas.Name = "TRectangleShaperReservas";
            this.TRectangleShaperReservas.Size = new System.Drawing.Size(528, 209);
            // 
            // TLabelInfoVehiculo
            // 
            this.TLabelInfoVehiculo.AutoSize = true;
            this.TLabelInfoVehiculo.BackColor = System.Drawing.Color.Transparent;
            this.TLabelInfoVehiculo.Location = new System.Drawing.Point(197, 208);
            this.TLabelInfoVehiculo.Name = "TLabelInfoVehiculo";
            this.TLabelInfoVehiculo.Size = new System.Drawing.Size(122, 13);
            this.TLabelInfoVehiculo.TabIndex = 53;
            this.TLabelInfoVehiculo.Text = "Información del vehiculo";
            // 
            // TLabelDNI
            // 
            this.TLabelDNI.AutoSize = true;
            this.TLabelDNI.BackColor = System.Drawing.Color.Transparent;
            this.TLabelDNI.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TLabelDNI.Location = new System.Drawing.Point(210, 120);
            this.TLabelDNI.Name = "TLabelDNI";
            this.TLabelDNI.Size = new System.Drawing.Size(49, 19);
            this.TLabelDNI.TabIndex = 41;
            this.TLabelDNI.Text = "label1";
            this.TLabelDNI.Visible = false;
            // 
            // TLabelNombre
            // 
            this.TLabelNombre.AutoSize = true;
            this.TLabelNombre.BackColor = System.Drawing.Color.Transparent;
            this.TLabelNombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TLabelNombre.Location = new System.Drawing.Point(210, 83);
            this.TLabelNombre.Name = "TLabelNombre";
            this.TLabelNombre.Size = new System.Drawing.Size(49, 19);
            this.TLabelNombre.TabIndex = 40;
            this.TLabelNombre.Text = "label1";
            this.TLabelNombre.Visible = false;
            this.TLabelNombre.VisibleChanged += new System.EventHandler(this.TLabelNombre_VisibleChanged);
            // 
            // TLabelDirec
            // 
            this.TLabelDirec.AutoSize = true;
            this.TLabelDirec.BackColor = System.Drawing.Color.Transparent;
            this.TLabelDirec.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TLabelDirec.Location = new System.Drawing.Point(210, 161);
            this.TLabelDirec.Name = "TLabelDirec";
            this.TLabelDirec.Size = new System.Drawing.Size(49, 19);
            this.TLabelDirec.TabIndex = 54;
            this.TLabelDirec.Text = "label1";
            this.TLabelDirec.Visible = false;
            // 
            // TLabelTitulo
            // 
            this.TLabelTitulo.AutoSize = true;
            this.TLabelTitulo.BackColor = System.Drawing.Color.Transparent;
            this.TLabelTitulo.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Italic);
            this.TLabelTitulo.Location = new System.Drawing.Point(2, -1);
            this.TLabelTitulo.Name = "TLabelTitulo";
            this.TLabelTitulo.Size = new System.Drawing.Size(87, 18);
            this.TLabelTitulo.TabIndex = 55;
            this.TLabelTitulo.Text = "Nueva Reserva";
            // 
            // TRadioButtonFavorito
            // 
            this.TRadioButtonFavorito.AutoSize = true;
            this.TRadioButtonFavorito.BackColor = System.Drawing.Color.Transparent;
            this.TRadioButtonFavorito.Location = new System.Drawing.Point(720, 236);
            this.TRadioButtonFavorito.Name = "TRadioButtonFavorito";
            this.TRadioButtonFavorito.Size = new System.Drawing.Size(109, 17);
            this.TRadioButtonFavorito.TabIndex = 56;
            this.TRadioButtonFavorito.TabStop = true;
            this.TRadioButtonFavorito.Tag = "";
            this.TRadioButtonFavorito.Text = "Vehículo Favorito";
            this.TRadioButtonFavorito.UseVisualStyleBackColor = false;
            this.TRadioButtonFavorito.Visible = false;
            this.TRadioButtonFavorito.CheckedChanged += new System.EventHandler(this.TRadioButtonFavorito_CheckedChanged);
            // 
            // TRadioButtonUltimoCoche
            // 
            this.TRadioButtonUltimoCoche.AutoSize = true;
            this.TRadioButtonUltimoCoche.BackColor = System.Drawing.Color.Transparent;
            this.TRadioButtonUltimoCoche.Location = new System.Drawing.Point(720, 259);
            this.TRadioButtonUltimoCoche.Name = "TRadioButtonUltimoCoche";
            this.TRadioButtonUltimoCoche.Size = new System.Drawing.Size(100, 17);
            this.TRadioButtonUltimoCoche.TabIndex = 57;
            this.TRadioButtonUltimoCoche.TabStop = true;
            this.TRadioButtonUltimoCoche.Text = "Último Vehículo";
            this.TRadioButtonUltimoCoche.UseVisualStyleBackColor = false;
            this.TRadioButtonUltimoCoche.Visible = false;
            this.TRadioButtonUltimoCoche.CheckedChanged += new System.EventHandler(this.TRadioButtonUltimoCoche_CheckedChanged);
            // 
            // TLabelResRapida
            // 
            this.TLabelResRapida.AutoSize = true;
            this.TLabelResRapida.BackColor = System.Drawing.Color.Transparent;
            this.TLabelResRapida.Location = new System.Drawing.Point(717, 215);
            this.TLabelResRapida.Name = "TLabelResRapida";
            this.TLabelResRapida.Size = new System.Drawing.Size(87, 13);
            this.TLabelResRapida.TabIndex = 58;
            this.TLabelResRapida.Text = "Reserva Rápida:";
            this.TLabelResRapida.Visible = false;
            // 
            // AltaReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AlquilerCoches.Properties.Resources.rentacar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 608);
            this.Controls.Add(this.TLabelResRapida);
            this.Controls.Add(this.TRadioButtonUltimoCoche);
            this.Controls.Add(this.TRadioButtonFavorito);
            this.Controls.Add(this.TLabelTitulo);
            this.Controls.Add(this.TLabelDirec);
            this.Controls.Add(this.TLabelInfoVehiculo);
            this.Controls.Add(this.TButtonEditar);
            this.Controls.Add(this.TButtonBuscarOtro);
            this.Controls.Add(this.TLabelInfoCliente);
            this.Controls.Add(this.TButtonCerrar);
            this.Controls.Add(this.TComboBoxMarca);
            this.Controls.Add(this.TLabelMarca);
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
            this.Controls.Add(this.TButtonBuscarCliente);
            this.Controls.Add(this.TLabelNombre);
            this.Controls.Add(this.TLabelDNI);
            this.Controls.Add(this.shapeContainer1);
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

        private System.Windows.Forms.Button TButtonBuscarCliente;
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
        private System.Windows.Forms.Label TLabelMarca;
        private System.Windows.Forms.ComboBox TComboBoxMarca;
        private System.Windows.Forms.Button TButtonCerrar;
        private System.Windows.Forms.Label TLabelInfoCliente;
        private System.Windows.Forms.Button TButtonEditar;
        private System.Windows.Forms.Button TButtonBuscarOtro;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape TRectangleShapeCliente;
        private System.Windows.Forms.Label TLabelInfoVehiculo;
        private System.Windows.Forms.Label TLabelDNI;
        private System.Windows.Forms.Label TLabelNombre;
        private System.Windows.Forms.Label TLabelDirec;
        private System.Windows.Forms.Label TLabelTitulo;
        private System.Windows.Forms.RadioButton TRadioButtonFavorito;
        private System.Windows.Forms.RadioButton TRadioButtonUltimoCoche;
        private System.Windows.Forms.Label TLabelResRapida;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape TRectangleShaperReservas;
    }
}