namespace AlquilerCoches
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TGroupBoxCliente = new System.Windows.Forms.GroupBox();
            this.TLabelVehiculosAlquiler = new System.Windows.Forms.Label();
            this.listBoxCoches = new System.Windows.Forms.ListBox();
            this.TLabelSexo = new System.Windows.Forms.Label();
            this.TRadioButtonM = new System.Windows.Forms.RadioButton();
            this.TRadioButtonH = new System.Windows.Forms.RadioButton();
            this.TTextBoxDireccion = new System.Windows.Forms.TextBox();
            this.TLabelDireccion = new System.Windows.Forms.Label();
            this.TTextBoxEmail = new System.Windows.Forms.TextBox();
            this.TLabelEmail = new System.Windows.Forms.Label();
            this.TTextBoxProvincia = new System.Windows.Forms.TextBox();
            this.TTextBoxCiudad = new System.Windows.Forms.TextBox();
            this.TTextBoxTelefono = new System.Windows.Forms.TextBox();
            this.TTextBoxApellidos = new System.Windows.Forms.TextBox();
            this.TTextBoxNombre = new System.Windows.Forms.TextBox();
            this.TTextBoxDNI = new System.Windows.Forms.TextBox();
            this.TLabelProvincia = new System.Windows.Forms.Label();
            this.TLabelCiudad = new System.Windows.Forms.Label();
            this.TLabelTelefono1 = new System.Windows.Forms.Label();
            this.TLabelApellidos = new System.Windows.Forms.Label();
            this.TLabelNombre = new System.Windows.Forms.Label();
            this.TLabelDNI = new System.Windows.Forms.Label();
            this.TButtonFoto = new System.Windows.Forms.Button();
            this.TButtonAceptar = new System.Windows.Forms.Button();
            this.TButtonBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TGroupBoxCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AlquilerCoches.Properties.Resources.Desconocido;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(444, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 110);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // TGroupBoxCliente
            // 
            this.TGroupBoxCliente.BackColor = System.Drawing.SystemColors.Control;
            this.TGroupBoxCliente.Controls.Add(this.TLabelVehiculosAlquiler);
            this.TGroupBoxCliente.Controls.Add(this.listBoxCoches);
            this.TGroupBoxCliente.Controls.Add(this.TLabelSexo);
            this.TGroupBoxCliente.Controls.Add(this.TRadioButtonM);
            this.TGroupBoxCliente.Controls.Add(this.TRadioButtonH);
            this.TGroupBoxCliente.Controls.Add(this.TTextBoxDireccion);
            this.TGroupBoxCliente.Controls.Add(this.TLabelDireccion);
            this.TGroupBoxCliente.Controls.Add(this.TTextBoxEmail);
            this.TGroupBoxCliente.Controls.Add(this.TLabelEmail);
            this.TGroupBoxCliente.Controls.Add(this.TTextBoxProvincia);
            this.TGroupBoxCliente.Controls.Add(this.TTextBoxCiudad);
            this.TGroupBoxCliente.Controls.Add(this.TTextBoxTelefono);
            this.TGroupBoxCliente.Controls.Add(this.TTextBoxApellidos);
            this.TGroupBoxCliente.Controls.Add(this.TTextBoxNombre);
            this.TGroupBoxCliente.Controls.Add(this.TTextBoxDNI);
            this.TGroupBoxCliente.Controls.Add(this.TLabelProvincia);
            this.TGroupBoxCliente.Controls.Add(this.TLabelCiudad);
            this.TGroupBoxCliente.Controls.Add(this.TLabelTelefono1);
            this.TGroupBoxCliente.Controls.Add(this.TLabelApellidos);
            this.TGroupBoxCliente.Controls.Add(this.TLabelNombre);
            this.TGroupBoxCliente.Controls.Add(this.TLabelDNI);
            this.TGroupBoxCliente.Location = new System.Drawing.Point(12, 12);
            this.TGroupBoxCliente.Name = "TGroupBoxCliente";
            this.TGroupBoxCliente.Size = new System.Drawing.Size(341, 390);
            this.TGroupBoxCliente.TabIndex = 46;
            this.TGroupBoxCliente.TabStop = false;
            this.TGroupBoxCliente.Text = "Datos Cliente";
            // 
            // TLabelVehiculosAlquiler
            // 
            this.TLabelVehiculosAlquiler.AutoSize = true;
            this.TLabelVehiculosAlquiler.Location = new System.Drawing.Point(11, 263);
            this.TLabelVehiculosAlquiler.Name = "TLabelVehiculosAlquiler";
            this.TLabelVehiculosAlquiler.Size = new System.Drawing.Size(104, 13);
            this.TLabelVehiculosAlquiler.TabIndex = 64;
            this.TLabelVehiculosAlquiler.Text = "Vehiculos en alquiler";
            this.TLabelVehiculosAlquiler.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // listBoxCoches
            // 
            this.listBoxCoches.FormattingEnabled = true;
            this.listBoxCoches.Location = new System.Drawing.Point(136, 263);
            this.listBoxCoches.Name = "listBoxCoches";
            this.listBoxCoches.Size = new System.Drawing.Size(158, 121);
            this.listBoxCoches.TabIndex = 49;
            // 
            // TLabelSexo
            // 
            this.TLabelSexo.AutoSize = true;
            this.TLabelSexo.Location = new System.Drawing.Point(37, 228);
            this.TLabelSexo.Name = "TLabelSexo";
            this.TLabelSexo.Size = new System.Drawing.Size(31, 13);
            this.TLabelSexo.TabIndex = 63;
            this.TLabelSexo.Text = "Sexo";
            // 
            // TRadioButtonM
            // 
            this.TRadioButtonM.AutoSize = true;
            this.TRadioButtonM.Location = new System.Drawing.Point(136, 224);
            this.TRadioButtonM.Name = "TRadioButtonM";
            this.TRadioButtonM.Size = new System.Drawing.Size(34, 17);
            this.TRadioButtonM.TabIndex = 62;
            this.TRadioButtonM.TabStop = true;
            this.TRadioButtonM.Text = "M";
            this.TRadioButtonM.UseVisualStyleBackColor = true;
            // 
            // TRadioButtonH
            // 
            this.TRadioButtonH.AutoSize = true;
            this.TRadioButtonH.Location = new System.Drawing.Point(87, 224);
            this.TRadioButtonH.Name = "TRadioButtonH";
            this.TRadioButtonH.Size = new System.Drawing.Size(33, 17);
            this.TRadioButtonH.TabIndex = 61;
            this.TRadioButtonH.TabStop = true;
            this.TRadioButtonH.Text = "H";
            this.TRadioButtonH.UseVisualStyleBackColor = true;
            // 
            // TTextBoxDireccion
            // 
            this.TTextBoxDireccion.Location = new System.Drawing.Point(87, 144);
            this.TTextBoxDireccion.Name = "TTextBoxDireccion";
            this.TTextBoxDireccion.Size = new System.Drawing.Size(108, 20);
            this.TTextBoxDireccion.TabIndex = 60;
            // 
            // TLabelDireccion
            // 
            this.TLabelDireccion.AutoSize = true;
            this.TLabelDireccion.Location = new System.Drawing.Point(20, 151);
            this.TLabelDireccion.Name = "TLabelDireccion";
            this.TLabelDireccion.Size = new System.Drawing.Size(52, 13);
            this.TLabelDireccion.TabIndex = 59;
            this.TLabelDireccion.Text = "Direccion";
            // 
            // TTextBoxEmail
            // 
            this.TTextBoxEmail.Location = new System.Drawing.Point(87, 123);
            this.TTextBoxEmail.Name = "TTextBoxEmail";
            this.TTextBoxEmail.Size = new System.Drawing.Size(108, 20);
            this.TTextBoxEmail.TabIndex = 58;
            // 
            // TLabelEmail
            // 
            this.TLabelEmail.AutoSize = true;
            this.TLabelEmail.Location = new System.Drawing.Point(37, 130);
            this.TLabelEmail.Name = "TLabelEmail";
            this.TLabelEmail.Size = new System.Drawing.Size(32, 13);
            this.TLabelEmail.TabIndex = 57;
            this.TLabelEmail.Text = "Email";
            // 
            // TTextBoxProvincia
            // 
            this.TTextBoxProvincia.Location = new System.Drawing.Point(87, 188);
            this.TTextBoxProvincia.Name = "TTextBoxProvincia";
            this.TTextBoxProvincia.Size = new System.Drawing.Size(108, 20);
            this.TTextBoxProvincia.TabIndex = 56;
            // 
            // TTextBoxCiudad
            // 
            this.TTextBoxCiudad.Location = new System.Drawing.Point(87, 166);
            this.TTextBoxCiudad.Name = "TTextBoxCiudad";
            this.TTextBoxCiudad.Size = new System.Drawing.Size(108, 20);
            this.TTextBoxCiudad.TabIndex = 55;
            // 
            // TTextBoxTelefono
            // 
            this.TTextBoxTelefono.Location = new System.Drawing.Point(87, 100);
            this.TTextBoxTelefono.Name = "TTextBoxTelefono";
            this.TTextBoxTelefono.Size = new System.Drawing.Size(108, 20);
            this.TTextBoxTelefono.TabIndex = 54;
            // 
            // TTextBoxApellidos
            // 
            this.TTextBoxApellidos.Location = new System.Drawing.Point(87, 78);
            this.TTextBoxApellidos.Name = "TTextBoxApellidos";
            this.TTextBoxApellidos.Size = new System.Drawing.Size(108, 20);
            this.TTextBoxApellidos.TabIndex = 53;
            // 
            // TTextBoxNombre
            // 
            this.TTextBoxNombre.Location = new System.Drawing.Point(87, 56);
            this.TTextBoxNombre.Name = "TTextBoxNombre";
            this.TTextBoxNombre.Size = new System.Drawing.Size(70, 20);
            this.TTextBoxNombre.TabIndex = 52;
            // 
            // TTextBoxDNI
            // 
            this.TTextBoxDNI.Location = new System.Drawing.Point(87, 33);
            this.TTextBoxDNI.Name = "TTextBoxDNI";
            this.TTextBoxDNI.Size = new System.Drawing.Size(70, 20);
            this.TTextBoxDNI.TabIndex = 51;
            // 
            // TLabelProvincia
            // 
            this.TLabelProvincia.AutoSize = true;
            this.TLabelProvincia.Location = new System.Drawing.Point(20, 195);
            this.TLabelProvincia.Name = "TLabelProvincia";
            this.TLabelProvincia.Size = new System.Drawing.Size(51, 13);
            this.TLabelProvincia.TabIndex = 50;
            this.TLabelProvincia.Text = "Provincia";
            // 
            // TLabelCiudad
            // 
            this.TLabelCiudad.AutoSize = true;
            this.TLabelCiudad.Location = new System.Drawing.Point(29, 173);
            this.TLabelCiudad.Name = "TLabelCiudad";
            this.TLabelCiudad.Size = new System.Drawing.Size(40, 13);
            this.TLabelCiudad.TabIndex = 49;
            this.TLabelCiudad.Text = "Ciudad";
            // 
            // TLabelTelefono1
            // 
            this.TLabelTelefono1.AutoSize = true;
            this.TLabelTelefono1.Location = new System.Drawing.Point(11, 107);
            this.TLabelTelefono1.Name = "TLabelTelefono1";
            this.TLabelTelefono1.Size = new System.Drawing.Size(58, 13);
            this.TLabelTelefono1.TabIndex = 48;
            this.TLabelTelefono1.Text = "Telefono 1";
            // 
            // TLabelApellidos
            // 
            this.TLabelApellidos.AutoSize = true;
            this.TLabelApellidos.Location = new System.Drawing.Point(20, 85);
            this.TLabelApellidos.Name = "TLabelApellidos";
            this.TLabelApellidos.Size = new System.Drawing.Size(49, 13);
            this.TLabelApellidos.TabIndex = 47;
            this.TLabelApellidos.Text = "Apellidos";
            // 
            // TLabelNombre
            // 
            this.TLabelNombre.AutoSize = true;
            this.TLabelNombre.Location = new System.Drawing.Point(25, 63);
            this.TLabelNombre.Name = "TLabelNombre";
            this.TLabelNombre.Size = new System.Drawing.Size(44, 13);
            this.TLabelNombre.TabIndex = 46;
            this.TLabelNombre.Text = "Nombre";
            // 
            // TLabelDNI
            // 
            this.TLabelDNI.AutoSize = true;
            this.TLabelDNI.Location = new System.Drawing.Point(43, 40);
            this.TLabelDNI.Name = "TLabelDNI";
            this.TLabelDNI.Size = new System.Drawing.Size(26, 13);
            this.TLabelDNI.TabIndex = 45;
            this.TLabelDNI.Text = "DNI";
            // 
            // TButtonFoto
            // 
            this.TButtonFoto.Location = new System.Drawing.Point(459, 128);
            this.TButtonFoto.Name = "TButtonFoto";
            this.TButtonFoto.Size = new System.Drawing.Size(56, 23);
            this.TButtonFoto.TabIndex = 47;
            this.TButtonFoto.Text = "Foto";
            this.TButtonFoto.UseVisualStyleBackColor = true;
            this.TButtonFoto.Click += new System.EventHandler(this.button1_Click);
            // 
            // TButtonAceptar
            // 
            this.TButtonAceptar.Location = new System.Drawing.Point(440, 349);
            this.TButtonAceptar.Name = "TButtonAceptar";
            this.TButtonAceptar.Size = new System.Drawing.Size(75, 23);
            this.TButtonAceptar.TabIndex = 48;
            this.TButtonAceptar.Text = "Aceptar";
            this.TButtonAceptar.UseVisualStyleBackColor = true;
            // 
            // TButtonBuscar
            // 
            this.TButtonBuscar.Location = new System.Drawing.Point(521, 349);
            this.TButtonBuscar.Name = "TButtonBuscar";
            this.TButtonBuscar.Size = new System.Drawing.Size(75, 23);
            this.TButtonBuscar.TabIndex = 49;
            this.TButtonBuscar.Text = "Buscar";
            this.TButtonBuscar.UseVisualStyleBackColor = true;
            this.TButtonBuscar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // GestionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AlquilerCoches.Properties.Resources.rentacar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(718, 414);
            this.Controls.Add(this.TButtonBuscar);
            this.Controls.Add(this.TButtonAceptar);
            this.Controls.Add(this.TButtonFoto);
            this.Controls.Add(this.TGroupBoxCliente);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GestionClientes";
            this.Text = "GestionClientes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TGroupBoxCliente.ResumeLayout(false);
            this.TGroupBoxCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox TGroupBoxCliente;
        private System.Windows.Forms.TextBox TTextBoxDireccion;
        private System.Windows.Forms.Label TLabelDireccion;
        private System.Windows.Forms.TextBox TTextBoxEmail;
        private System.Windows.Forms.Label TLabelEmail;
        private System.Windows.Forms.TextBox TTextBoxProvincia;
        private System.Windows.Forms.TextBox TTextBoxCiudad;
        private System.Windows.Forms.TextBox TTextBoxTelefono;
        private System.Windows.Forms.TextBox TTextBoxApellidos;
        private System.Windows.Forms.TextBox TTextBoxNombre;
        private System.Windows.Forms.TextBox TTextBoxDNI;
        private System.Windows.Forms.Label TLabelProvincia;
        private System.Windows.Forms.Label TLabelCiudad;
        private System.Windows.Forms.Label TLabelTelefono1;
        private System.Windows.Forms.Label TLabelApellidos;
        private System.Windows.Forms.Label TLabelNombre;
        private System.Windows.Forms.Label TLabelDNI;
        private System.Windows.Forms.Button TButtonFoto;
        private System.Windows.Forms.Label TLabelVehiculosAlquiler;
        private System.Windows.Forms.ListBox listBoxCoches;
        private System.Windows.Forms.Label TLabelSexo;
        private System.Windows.Forms.RadioButton TRadioButtonM;
        private System.Windows.Forms.RadioButton TRadioButtonH;
        private System.Windows.Forms.Button TButtonAceptar;
        private System.Windows.Forms.Button TButtonBuscar;


    }
}