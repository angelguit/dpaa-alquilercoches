﻿namespace AlquilerCoches
{
    partial class GestionClientes
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TGroupBoxCliente = new System.Windows.Forms.GroupBox();
            this.TComboBoxTarifa = new System.Windows.Forms.ComboBox();
            this.TLabelTarifa = new System.Windows.Forms.Label();
            this.TComboBoxProvincias = new System.Windows.Forms.ComboBox();
            this.TComboBoxCiudades = new System.Windows.Forms.ComboBox();
            this.TLabelCiudades = new System.Windows.Forms.Label();
            this.TLabelProvincias = new System.Windows.Forms.Label();
            this.TLabelVehiculosAlquiler = new System.Windows.Forms.Label();
            this.TListBoxCoches = new System.Windows.Forms.ListBox();
            this.TLabelSexo = new System.Windows.Forms.Label();
            this.TRadioButtonM = new System.Windows.Forms.RadioButton();
            this.TRadioButtonH = new System.Windows.Forms.RadioButton();
            this.TTextBoxDireccion = new System.Windows.Forms.TextBox();
            this.TLabelDireccion = new System.Windows.Forms.Label();
            this.TTextBoxEmail = new System.Windows.Forms.TextBox();
            this.TLabelEmail = new System.Windows.Forms.Label();
            this.TTextBoxTelefono = new System.Windows.Forms.TextBox();
            this.TTextBoxApellidos = new System.Windows.Forms.TextBox();
            this.TTextBoxNombre = new System.Windows.Forms.TextBox();
            this.TTextBoxDNI = new System.Windows.Forms.TextBox();
            this.TLabelTelefono1 = new System.Windows.Forms.Label();
            this.TLabelApellidos = new System.Windows.Forms.Label();
            this.TLabelNombre = new System.Windows.Forms.Label();
            this.TLabelDNI = new System.Windows.Forms.Label();
            this.TButtonFoto = new System.Windows.Forms.Button();
            this.TButtonGuardarCliente = new System.Windows.Forms.Button();
            this.TButtonCerrar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TLabelTitulo = new System.Windows.Forms.Label();
            this.TTextBoxNumeroReservas = new System.Windows.Forms.TextBox();
            this.TLabelNumeroReserva = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TGroupBoxCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::AlquilerCoches.Properties.Resources.Desconocido;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(724, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 110);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // TGroupBoxCliente
            // 
            this.TGroupBoxCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TGroupBoxCliente.BackColor = System.Drawing.Color.Transparent;
            this.TGroupBoxCliente.Controls.Add(this.TTextBoxNumeroReservas);
            this.TGroupBoxCliente.Controls.Add(this.TLabelNumeroReserva);
            this.TGroupBoxCliente.Controls.Add(this.TComboBoxTarifa);
            this.TGroupBoxCliente.Controls.Add(this.TLabelTarifa);
            this.TGroupBoxCliente.Controls.Add(this.TComboBoxProvincias);
            this.TGroupBoxCliente.Controls.Add(this.TComboBoxCiudades);
            this.TGroupBoxCliente.Controls.Add(this.TLabelCiudades);
            this.TGroupBoxCliente.Controls.Add(this.TLabelProvincias);
            this.TGroupBoxCliente.Controls.Add(this.TLabelVehiculosAlquiler);
            this.TGroupBoxCliente.Controls.Add(this.TListBoxCoches);
            this.TGroupBoxCliente.Controls.Add(this.TLabelSexo);
            this.TGroupBoxCliente.Controls.Add(this.TRadioButtonM);
            this.TGroupBoxCliente.Controls.Add(this.TRadioButtonH);
            this.TGroupBoxCliente.Controls.Add(this.TTextBoxDireccion);
            this.TGroupBoxCliente.Controls.Add(this.TLabelDireccion);
            this.TGroupBoxCliente.Controls.Add(this.TTextBoxEmail);
            this.TGroupBoxCliente.Controls.Add(this.TLabelEmail);
            this.TGroupBoxCliente.Controls.Add(this.TTextBoxTelefono);
            this.TGroupBoxCliente.Controls.Add(this.TTextBoxApellidos);
            this.TGroupBoxCliente.Controls.Add(this.TTextBoxNombre);
            this.TGroupBoxCliente.Controls.Add(this.TTextBoxDNI);
            this.TGroupBoxCliente.Controls.Add(this.TLabelTelefono1);
            this.TGroupBoxCliente.Controls.Add(this.TLabelApellidos);
            this.TGroupBoxCliente.Controls.Add(this.TLabelNombre);
            this.TGroupBoxCliente.Controls.Add(this.TLabelDNI);
            this.TGroupBoxCliente.Location = new System.Drawing.Point(76, 90);
            this.TGroupBoxCliente.Name = "TGroupBoxCliente";
            this.TGroupBoxCliente.Size = new System.Drawing.Size(319, 334);
            this.TGroupBoxCliente.TabIndex = 46;
            this.TGroupBoxCliente.TabStop = false;
            this.TGroupBoxCliente.Text = "Datos Cliente";
            // 
            // TComboBoxTarifa
            // 
            this.TComboBoxTarifa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TComboBoxTarifa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TComboBoxTarifa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TComboBoxTarifa.FormattingEnabled = true;
            this.TComboBoxTarifa.Location = new System.Drawing.Point(87, 224);
            this.TComboBoxTarifa.Name = "TComboBoxTarifa";
            this.TComboBoxTarifa.Size = new System.Drawing.Size(137, 21);
            this.TComboBoxTarifa.TabIndex = 8;
            this.TComboBoxTarifa.Click += new System.EventHandler(this.TComboBoxTarifa_Click);
            this.TComboBoxTarifa.Leave += new System.EventHandler(this.TComboBoxTarifa_Leave);
            // 
            // TLabelTarifa
            // 
            this.TLabelTarifa.AutoSize = true;
            this.TLabelTarifa.Location = new System.Drawing.Point(29, 232);
            this.TLabelTarifa.Name = "TLabelTarifa";
            this.TLabelTarifa.Size = new System.Drawing.Size(34, 13);
            this.TLabelTarifa.TabIndex = 72;
            this.TLabelTarifa.Text = "Tarifa";
            // 
            // TComboBoxProvincias
            // 
            this.TComboBoxProvincias.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TComboBoxProvincias.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TComboBoxProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TComboBoxProvincias.FormattingEnabled = true;
            this.TComboBoxProvincias.Location = new System.Drawing.Point(87, 178);
            this.TComboBoxProvincias.Name = "TComboBoxProvincias";
            this.TComboBoxProvincias.Size = new System.Drawing.Size(137, 21);
            this.TComboBoxProvincias.TabIndex = 6;
            this.TComboBoxProvincias.TextChanged += new System.EventHandler(this.TComboBoxProvincias_TextChanged);
            this.TComboBoxProvincias.Click += new System.EventHandler(this.TComboBoxProvincias_Click);
            this.TComboBoxProvincias.Leave += new System.EventHandler(this.TComboboxProvincia_Leave);
            // 
            // TComboBoxCiudades
            // 
            this.TComboBoxCiudades.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TComboBoxCiudades.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TComboBoxCiudades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TComboBoxCiudades.FormattingEnabled = true;
            this.TComboBoxCiudades.Location = new System.Drawing.Point(87, 200);
            this.TComboBoxCiudades.Name = "TComboBoxCiudades";
            this.TComboBoxCiudades.Size = new System.Drawing.Size(137, 21);
            this.TComboBoxCiudades.TabIndex = 7;
            this.TComboBoxCiudades.Click += new System.EventHandler(this.TComboBoxCiudades_Click);
            // 
            // TLabelCiudades
            // 
            this.TLabelCiudades.AutoSize = true;
            this.TLabelCiudades.Location = new System.Drawing.Point(29, 208);
            this.TLabelCiudades.Name = "TLabelCiudades";
            this.TLabelCiudades.Size = new System.Drawing.Size(40, 13);
            this.TLabelCiudades.TabIndex = 70;
            this.TLabelCiudades.Text = "Ciudad";
            // 
            // TLabelProvincias
            // 
            this.TLabelProvincias.AutoSize = true;
            this.TLabelProvincias.Location = new System.Drawing.Point(21, 186);
            this.TLabelProvincias.Name = "TLabelProvincias";
            this.TLabelProvincias.Size = new System.Drawing.Size(51, 13);
            this.TLabelProvincias.TabIndex = 69;
            this.TLabelProvincias.Text = "Provincia";
            // 
            // TLabelVehiculosAlquiler
            // 
            this.TLabelVehiculosAlquiler.AutoSize = true;
            this.TLabelVehiculosAlquiler.Location = new System.Drawing.Point(311, 95);
            this.TLabelVehiculosAlquiler.Name = "TLabelVehiculosAlquiler";
            this.TLabelVehiculosAlquiler.Size = new System.Drawing.Size(108, 26);
            this.TLabelVehiculosAlquiler.TabIndex = 64;
            this.TLabelVehiculosAlquiler.Text = "Vehiculos reservados\r\n       actualmente";
            this.TLabelVehiculosAlquiler.Visible = false;
            // 
            // TListBoxCoches
            // 
            this.TListBoxCoches.FormattingEnabled = true;
            this.TListBoxCoches.Location = new System.Drawing.Point(290, 124);
            this.TListBoxCoches.Name = "TListBoxCoches";
            this.TListBoxCoches.Size = new System.Drawing.Size(158, 121);
            this.TListBoxCoches.TabIndex = 11;
            this.TListBoxCoches.Visible = false;
            // 
            // TLabelSexo
            // 
            this.TLabelSexo.AutoSize = true;
            this.TLabelSexo.Location = new System.Drawing.Point(37, 276);
            this.TLabelSexo.Name = "TLabelSexo";
            this.TLabelSexo.Size = new System.Drawing.Size(31, 13);
            this.TLabelSexo.TabIndex = 63;
            this.TLabelSexo.Text = "Sexo";
            // 
            // TRadioButtonM
            // 
            this.TRadioButtonM.AutoSize = true;
            this.TRadioButtonM.Location = new System.Drawing.Point(136, 272);
            this.TRadioButtonM.Name = "TRadioButtonM";
            this.TRadioButtonM.Size = new System.Drawing.Size(34, 17);
            this.TRadioButtonM.TabIndex = 10;
            this.TRadioButtonM.TabStop = true;
            this.TRadioButtonM.Text = "M";
            this.TRadioButtonM.UseVisualStyleBackColor = true;
            // 
            // TRadioButtonH
            // 
            this.TRadioButtonH.AutoSize = true;
            this.TRadioButtonH.Location = new System.Drawing.Point(87, 272);
            this.TRadioButtonH.Name = "TRadioButtonH";
            this.TRadioButtonH.Size = new System.Drawing.Size(33, 17);
            this.TRadioButtonH.TabIndex = 9;
            this.TRadioButtonH.TabStop = true;
            this.TRadioButtonH.Text = "H";
            this.TRadioButtonH.UseVisualStyleBackColor = true;
            // 
            // TTextBoxDireccion
            // 
            this.TTextBoxDireccion.Location = new System.Drawing.Point(87, 156);
            this.TTextBoxDireccion.Name = "TTextBoxDireccion";
            this.TTextBoxDireccion.Size = new System.Drawing.Size(137, 20);
            this.TTextBoxDireccion.TabIndex = 5;
            this.TTextBoxDireccion.Leave += new System.EventHandler(this.TTextBoxDireccion_Leave);
            // 
            // TLabelDireccion
            // 
            this.TLabelDireccion.AutoSize = true;
            this.TLabelDireccion.Location = new System.Drawing.Point(20, 163);
            this.TLabelDireccion.Name = "TLabelDireccion";
            this.TLabelDireccion.Size = new System.Drawing.Size(52, 13);
            this.TLabelDireccion.TabIndex = 59;
            this.TLabelDireccion.Text = "Direccion";
            // 
            // TTextBoxEmail
            // 
            this.TTextBoxEmail.Location = new System.Drawing.Point(87, 135);
            this.TTextBoxEmail.Name = "TTextBoxEmail";
            this.TTextBoxEmail.Size = new System.Drawing.Size(137, 20);
            this.TTextBoxEmail.TabIndex = 4;
            this.TTextBoxEmail.Leave += new System.EventHandler(this.TTextBoxEmail_Leave);
            // 
            // TLabelEmail
            // 
            this.TLabelEmail.AutoSize = true;
            this.TLabelEmail.Location = new System.Drawing.Point(37, 142);
            this.TLabelEmail.Name = "TLabelEmail";
            this.TLabelEmail.Size = new System.Drawing.Size(32, 13);
            this.TLabelEmail.TabIndex = 57;
            this.TLabelEmail.Text = "Email";
            // 
            // TTextBoxTelefono
            // 
            this.TTextBoxTelefono.Location = new System.Drawing.Point(87, 113);
            this.TTextBoxTelefono.Name = "TTextBoxTelefono";
            this.TTextBoxTelefono.Size = new System.Drawing.Size(137, 20);
            this.TTextBoxTelefono.TabIndex = 3;
            this.TTextBoxTelefono.Leave += new System.EventHandler(this.TTextBoxTelefono_Leave);
            // 
            // TTextBoxApellidos
            // 
            this.TTextBoxApellidos.Location = new System.Drawing.Point(87, 91);
            this.TTextBoxApellidos.Name = "TTextBoxApellidos";
            this.TTextBoxApellidos.Size = new System.Drawing.Size(137, 20);
            this.TTextBoxApellidos.TabIndex = 2;
            this.TTextBoxApellidos.Leave += new System.EventHandler(this.TTextBoxApellidos_Leave);
            // 
            // TTextBoxNombre
            // 
            this.TTextBoxNombre.Location = new System.Drawing.Point(87, 69);
            this.TTextBoxNombre.Name = "TTextBoxNombre";
            this.TTextBoxNombre.Size = new System.Drawing.Size(137, 20);
            this.TTextBoxNombre.TabIndex = 1;
            this.TTextBoxNombre.Leave += new System.EventHandler(this.TTextBoxNombre_Leave);
            // 
            // TTextBoxDNI
            // 
            this.TTextBoxDNI.Location = new System.Drawing.Point(87, 47);
            this.TTextBoxDNI.Name = "TTextBoxDNI";
            this.TTextBoxDNI.Size = new System.Drawing.Size(137, 20);
            this.TTextBoxDNI.TabIndex = 0;
            this.TTextBoxDNI.Leave += new System.EventHandler(this.TTextBoxDNI_Leave);
            // 
            // TLabelTelefono1
            // 
            this.TLabelTelefono1.AutoSize = true;
            this.TLabelTelefono1.Location = new System.Drawing.Point(24, 120);
            this.TLabelTelefono1.Name = "TLabelTelefono1";
            this.TLabelTelefono1.Size = new System.Drawing.Size(49, 13);
            this.TLabelTelefono1.TabIndex = 48;
            this.TLabelTelefono1.Text = "Telefono";
            // 
            // TLabelApellidos
            // 
            this.TLabelApellidos.AutoSize = true;
            this.TLabelApellidos.Location = new System.Drawing.Point(24, 97);
            this.TLabelApellidos.Name = "TLabelApellidos";
            this.TLabelApellidos.Size = new System.Drawing.Size(49, 13);
            this.TLabelApellidos.TabIndex = 47;
            this.TLabelApellidos.Text = "Apellidos";
            // 
            // TLabelNombre
            // 
            this.TLabelNombre.AutoSize = true;
            this.TLabelNombre.Location = new System.Drawing.Point(29, 76);
            this.TLabelNombre.Name = "TLabelNombre";
            this.TLabelNombre.Size = new System.Drawing.Size(44, 13);
            this.TLabelNombre.TabIndex = 46;
            this.TLabelNombre.Text = "Nombre";
            // 
            // TLabelDNI
            // 
            this.TLabelDNI.AutoSize = true;
            this.TLabelDNI.Location = new System.Drawing.Point(46, 54);
            this.TLabelDNI.Name = "TLabelDNI";
            this.TLabelDNI.Size = new System.Drawing.Size(26, 13);
            this.TLabelDNI.TabIndex = 45;
            this.TLabelDNI.Text = "DNI";
            // 
            // TButtonFoto
            // 
            this.TButtonFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TButtonFoto.Location = new System.Drawing.Point(739, 207);
            this.TButtonFoto.Name = "TButtonFoto";
            this.TButtonFoto.Size = new System.Drawing.Size(56, 23);
            this.TButtonFoto.TabIndex = 0;
            this.TButtonFoto.Text = "Foto";
            this.TButtonFoto.UseVisualStyleBackColor = true;
            this.TButtonFoto.Click += new System.EventHandler(this.TButtonFoto_Click);
            // 
            // TButtonGuardarCliente
            // 
            this.TButtonGuardarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TButtonGuardarCliente.Image = global::AlquilerCoches.Properties.Resources.Add_icon;
            this.TButtonGuardarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TButtonGuardarCliente.Location = new System.Drawing.Point(69, 524);
            this.TButtonGuardarCliente.Name = "TButtonGuardarCliente";
            this.TButtonGuardarCliente.Size = new System.Drawing.Size(80, 33);
            this.TButtonGuardarCliente.TabIndex = 1;
            this.TButtonGuardarCliente.Text = "Guardar";
            this.TButtonGuardarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TButtonGuardarCliente.UseVisualStyleBackColor = true;
            this.TButtonGuardarCliente.Click += new System.EventHandler(this.TButtonGuardarCliente_Click);
            // 
            // TButtonCerrar
            // 
            this.TButtonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TButtonCerrar.Image = global::AlquilerCoches.Properties.Resources.Close_icon;
            this.TButtonCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TButtonCerrar.Location = new System.Drawing.Point(192, 524);
            this.TButtonCerrar.Name = "TButtonCerrar";
            this.TButtonCerrar.Size = new System.Drawing.Size(78, 33);
            this.TButtonCerrar.TabIndex = 2;
            this.TButtonCerrar.Text = "Cerrar";
            this.TButtonCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TButtonCerrar.UseVisualStyleBackColor = true;
            this.TButtonCerrar.Click += new System.EventHandler(this.TButtonCerrar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TLabelTitulo
            // 
            this.TLabelTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TLabelTitulo.AutoSize = true;
            this.TLabelTitulo.BackColor = System.Drawing.Color.Transparent;
            this.TLabelTitulo.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TLabelTitulo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TLabelTitulo.Location = new System.Drawing.Point(3, 0);
            this.TLabelTitulo.Name = "TLabelTitulo";
            this.TLabelTitulo.Size = new System.Drawing.Size(97, 18);
            this.TLabelTitulo.TabIndex = 50;
            this.TLabelTitulo.Text = "Datos del Cliente";
            // 
            // TTextBoxNumeroReservas
            // 
            this.TTextBoxNumeroReservas.Location = new System.Drawing.Point(365, 47);
            this.TTextBoxNumeroReservas.Name = "TTextBoxNumeroReservas";
            this.TTextBoxNumeroReservas.Size = new System.Drawing.Size(32, 20);
            this.TTextBoxNumeroReservas.TabIndex = 73;
            this.TTextBoxNumeroReservas.Visible = false;
            // 
            // TLabelNumeroReserva
            // 
            this.TLabelNumeroReserva.AutoSize = true;
            this.TLabelNumeroReserva.Location = new System.Drawing.Point(287, 54);
            this.TLabelNumeroReserva.Name = "TLabelNumeroReserva";
            this.TLabelNumeroReserva.Size = new System.Drawing.Size(64, 13);
            this.TLabelNumeroReserva.TabIndex = 74;
            this.TLabelNumeroReserva.Text = "NºReservas";
            this.TLabelNumeroReserva.Visible = false;
            // 
            // GestionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AlquilerCoches.Properties.Resources.rentacar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 608);
            this.Controls.Add(this.TLabelTitulo);
            this.Controls.Add(this.TButtonCerrar);
            this.Controls.Add(this.TButtonGuardarCliente);
            this.Controls.Add(this.TButtonFoto);
            this.Controls.Add(this.TGroupBoxCliente);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionClientes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GestionClientes_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TGroupBoxCliente.ResumeLayout(false);
            this.TGroupBoxCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox TGroupBoxCliente;
        private System.Windows.Forms.TextBox TTextBoxDireccion;
        private System.Windows.Forms.Label TLabelDireccion;
        private System.Windows.Forms.TextBox TTextBoxEmail;
        private System.Windows.Forms.Label TLabelEmail;
        private System.Windows.Forms.TextBox TTextBoxTelefono;
        private System.Windows.Forms.TextBox TTextBoxApellidos;
        private System.Windows.Forms.TextBox TTextBoxNombre;
        private System.Windows.Forms.TextBox TTextBoxDNI;
        private System.Windows.Forms.Label TLabelTelefono1;
        private System.Windows.Forms.Label TLabelApellidos;
        private System.Windows.Forms.Label TLabelNombre;
        private System.Windows.Forms.Label TLabelDNI;
        private System.Windows.Forms.Button TButtonFoto;
        private System.Windows.Forms.Label TLabelVehiculosAlquiler;
        private System.Windows.Forms.ListBox TListBoxCoches;
        private System.Windows.Forms.Label TLabelSexo;
        private System.Windows.Forms.RadioButton TRadioButtonM;
        private System.Windows.Forms.RadioButton TRadioButtonH;
        private System.Windows.Forms.Button TButtonGuardarCliente;
        private System.Windows.Forms.Button TButtonCerrar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox TComboBoxProvincias;
        private System.Windows.Forms.ComboBox TComboBoxCiudades;
        private System.Windows.Forms.Label TLabelCiudades;
        private System.Windows.Forms.Label TLabelProvincias;
        private System.Windows.Forms.ComboBox TComboBoxTarifa;
        private System.Windows.Forms.Label TLabelTarifa;
        private System.Windows.Forms.Label TLabelTitulo;
        private System.Windows.Forms.TextBox TTextBoxNumeroReservas;
        private System.Windows.Forms.Label TLabelNumeroReserva;


    }
}