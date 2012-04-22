namespace AlquilerCoches
{
    partial class GestionPersonal
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
            this.TButtonCancelar = new System.Windows.Forms.Button();
            this.TButtonFoto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TButtonGuardarPersonal = new System.Windows.Forms.Button();
            this.TGroupBoxAlta = new System.Windows.Forms.GroupBox();
            this.TComboBoxProvincias = new System.Windows.Forms.ComboBox();
            this.TComboBoxCiudades = new System.Windows.Forms.ComboBox();
            this.TTextBoxDireccion = new System.Windows.Forms.TextBox();
            this.TLabelDireccion = new System.Windows.Forms.Label();
            this.TTextBoxEmail = new System.Windows.Forms.TextBox();
            this.TLabelEmail = new System.Windows.Forms.Label();
            this.TTextBoxPuestoAc = new System.Windows.Forms.TextBox();
            this.TTextBoxTelefono = new System.Windows.Forms.TextBox();
            this.TTextBoxApellidos = new System.Windows.Forms.TextBox();
            this.TTextBoxNombre = new System.Windows.Forms.TextBox();
            this.TTextBoxDNI = new System.Windows.Forms.TextBox();
            this.TLabelPuestoAc = new System.Windows.Forms.Label();
            this.TLabelCiudades = new System.Windows.Forms.Label();
            this.TLabelProvincias = new System.Windows.Forms.Label();
            this.TLabelTelefono1 = new System.Windows.Forms.Label();
            this.TLabelApellidos = new System.Windows.Forms.Label();
            this.TLabelNombre = new System.Windows.Forms.Label();
            this.TLabelDNI = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TLabelTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TGroupBoxAlta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TButtonCancelar
            // 
            this.TButtonCancelar.Image = global::AlquilerCoches.Properties.Resources.Close_icon;
            this.TButtonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TButtonCancelar.Location = new System.Drawing.Point(153, 543);
            this.TButtonCancelar.Name = "TButtonCancelar";
            this.TButtonCancelar.Size = new System.Drawing.Size(76, 33);
            this.TButtonCancelar.TabIndex = 2;
            this.TButtonCancelar.Text = "Cerrar";
            this.TButtonCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TButtonCancelar.UseVisualStyleBackColor = true;
            this.TButtonCancelar.Click += new System.EventHandler(this.TButtonCancelar_Click);
            // 
            // TButtonFoto
            // 
            this.TButtonFoto.Location = new System.Drawing.Point(662, 152);
            this.TButtonFoto.Name = "TButtonFoto";
            this.TButtonFoto.Size = new System.Drawing.Size(68, 19);
            this.TButtonFoto.TabIndex = 0;
            this.TButtonFoto.Text = "Foto";
            this.TButtonFoto.UseVisualStyleBackColor = true;
            this.TButtonFoto.Click += new System.EventHandler(this.TButtonFoto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AlquilerCoches.Properties.Resources.Desconocido;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(647, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 109);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // TButtonGuardarPersonal
            // 
            this.TButtonGuardarPersonal.Image = global::AlquilerCoches.Properties.Resources.Add_icon;
            this.TButtonGuardarPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TButtonGuardarPersonal.Location = new System.Drawing.Point(25, 543);
            this.TButtonGuardarPersonal.Name = "TButtonGuardarPersonal";
            this.TButtonGuardarPersonal.Size = new System.Drawing.Size(77, 33);
            this.TButtonGuardarPersonal.TabIndex = 1;
            this.TButtonGuardarPersonal.Text = "Guardar";
            this.TButtonGuardarPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TButtonGuardarPersonal.UseVisualStyleBackColor = true;
            this.TButtonGuardarPersonal.Click += new System.EventHandler(this.TButtonGuardarPersonal_Click);
            // 
            // TGroupBoxAlta
            // 
            this.TGroupBoxAlta.BackColor = System.Drawing.Color.Transparent;
            this.TGroupBoxAlta.Controls.Add(this.TComboBoxProvincias);
            this.TGroupBoxAlta.Controls.Add(this.TComboBoxCiudades);
            this.TGroupBoxAlta.Controls.Add(this.TTextBoxDireccion);
            this.TGroupBoxAlta.Controls.Add(this.TLabelDireccion);
            this.TGroupBoxAlta.Controls.Add(this.TTextBoxEmail);
            this.TGroupBoxAlta.Controls.Add(this.TLabelEmail);
            this.TGroupBoxAlta.Controls.Add(this.TTextBoxPuestoAc);
            this.TGroupBoxAlta.Controls.Add(this.TTextBoxTelefono);
            this.TGroupBoxAlta.Controls.Add(this.TTextBoxApellidos);
            this.TGroupBoxAlta.Controls.Add(this.TTextBoxNombre);
            this.TGroupBoxAlta.Controls.Add(this.TTextBoxDNI);
            this.TGroupBoxAlta.Controls.Add(this.TLabelPuestoAc);
            this.TGroupBoxAlta.Controls.Add(this.TLabelCiudades);
            this.TGroupBoxAlta.Controls.Add(this.TLabelProvincias);
            this.TGroupBoxAlta.Controls.Add(this.TLabelTelefono1);
            this.TGroupBoxAlta.Controls.Add(this.TLabelApellidos);
            this.TGroupBoxAlta.Controls.Add(this.TLabelNombre);
            this.TGroupBoxAlta.Controls.Add(this.TLabelDNI);
            this.TGroupBoxAlta.Location = new System.Drawing.Point(76, 37);
            this.TGroupBoxAlta.Name = "TGroupBoxAlta";
            this.TGroupBoxAlta.Size = new System.Drawing.Size(424, 337);
            this.TGroupBoxAlta.TabIndex = 27;
            this.TGroupBoxAlta.TabStop = false;
            this.TGroupBoxAlta.Text = "Datos Personal";
            // 
            // TComboBoxProvincias
            // 
            this.TComboBoxProvincias.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TComboBoxProvincias.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TComboBoxProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TComboBoxProvincias.FormattingEnabled = true;
            this.TComboBoxProvincias.Location = new System.Drawing.Point(150, 193);
            this.TComboBoxProvincias.Name = "TComboBoxProvincias";
            this.TComboBoxProvincias.Size = new System.Drawing.Size(137, 21);
            this.TComboBoxProvincias.TabIndex = 6;
            this.TComboBoxProvincias.TextChanged += new System.EventHandler(this.TComboBoxProvincias_TextChanged);
            this.TComboBoxProvincias.Click += new System.EventHandler(this.TComboBoxProvincias_Click_1);
            this.TComboBoxProvincias.Leave += new System.EventHandler(this.TComboboxProvincia_Leave);
            // 
            // TComboBoxCiudades
            // 
            this.TComboBoxCiudades.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TComboBoxCiudades.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TComboBoxCiudades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TComboBoxCiudades.FormattingEnabled = true;
            this.TComboBoxCiudades.Location = new System.Drawing.Point(150, 215);
            this.TComboBoxCiudades.Name = "TComboBoxCiudades";
            this.TComboBoxCiudades.Size = new System.Drawing.Size(137, 21);
            this.TComboBoxCiudades.TabIndex = 7;
            this.TComboBoxCiudades.Click += new System.EventHandler(this.TComboBoxCiudades_Click);
            // 
            // TTextBoxDireccion
            // 
            this.TTextBoxDireccion.Location = new System.Drawing.Point(150, 172);
            this.TTextBoxDireccion.Name = "TTextBoxDireccion";
            this.TTextBoxDireccion.Size = new System.Drawing.Size(137, 20);
            this.TTextBoxDireccion.TabIndex = 5;
            this.TTextBoxDireccion.Leave += new System.EventHandler(this.TTextBoxDireccion_Leave);
            // 
            // TLabelDireccion
            // 
            this.TLabelDireccion.AutoSize = true;
            this.TLabelDireccion.Location = new System.Drawing.Point(83, 179);
            this.TLabelDireccion.Name = "TLabelDireccion";
            this.TLabelDireccion.Size = new System.Drawing.Size(52, 13);
            this.TLabelDireccion.TabIndex = 45;
            this.TLabelDireccion.Text = "Direccion";
            // 
            // TTextBoxEmail
            // 
            this.TTextBoxEmail.Location = new System.Drawing.Point(150, 151);
            this.TTextBoxEmail.Name = "TTextBoxEmail";
            this.TTextBoxEmail.Size = new System.Drawing.Size(137, 20);
            this.TTextBoxEmail.TabIndex = 4;
            this.TTextBoxEmail.Leave += new System.EventHandler(this.TTextBoxEmail_Leave);
            // 
            // TLabelEmail
            // 
            this.TLabelEmail.AutoSize = true;
            this.TLabelEmail.Location = new System.Drawing.Point(100, 158);
            this.TLabelEmail.Name = "TLabelEmail";
            this.TLabelEmail.Size = new System.Drawing.Size(32, 13);
            this.TLabelEmail.TabIndex = 43;
            this.TLabelEmail.Text = "Email";
            // 
            // TTextBoxPuestoAc
            // 
            this.TTextBoxPuestoAc.Location = new System.Drawing.Point(150, 238);
            this.TTextBoxPuestoAc.Name = "TTextBoxPuestoAc";
            this.TTextBoxPuestoAc.Size = new System.Drawing.Size(137, 20);
            this.TTextBoxPuestoAc.TabIndex = 8;
            this.TTextBoxPuestoAc.Leave += new System.EventHandler(this.TTextBoxPuestoAc_Leave);
            // 
            // TTextBoxTelefono
            // 
            this.TTextBoxTelefono.Location = new System.Drawing.Point(150, 129);
            this.TTextBoxTelefono.Name = "TTextBoxTelefono";
            this.TTextBoxTelefono.Size = new System.Drawing.Size(137, 20);
            this.TTextBoxTelefono.TabIndex = 3;
            this.TTextBoxTelefono.Leave += new System.EventHandler(this.TTextBoxTelefono_Leave);
            // 
            // TTextBoxApellidos
            // 
            this.TTextBoxApellidos.Location = new System.Drawing.Point(150, 107);
            this.TTextBoxApellidos.Name = "TTextBoxApellidos";
            this.TTextBoxApellidos.Size = new System.Drawing.Size(137, 20);
            this.TTextBoxApellidos.TabIndex = 2;
            this.TTextBoxApellidos.Leave += new System.EventHandler(this.TTextBoxApellidos_Leave);
            // 
            // TTextBoxNombre
            // 
            this.TTextBoxNombre.Location = new System.Drawing.Point(150, 85);
            this.TTextBoxNombre.Name = "TTextBoxNombre";
            this.TTextBoxNombre.Size = new System.Drawing.Size(137, 20);
            this.TTextBoxNombre.TabIndex = 1;
            this.TTextBoxNombre.Leave += new System.EventHandler(this.TTextBoxNombre_Leave);
            // 
            // TTextBoxDNI
            // 
            this.TTextBoxDNI.Location = new System.Drawing.Point(150, 62);
            this.TTextBoxDNI.Name = "TTextBoxDNI";
            this.TTextBoxDNI.Size = new System.Drawing.Size(137, 20);
            this.TTextBoxDNI.TabIndex = 0;
            this.TTextBoxDNI.Leave += new System.EventHandler(this.TTextBoxDNI_Leave);
            // 
            // TLabelPuestoAc
            // 
            this.TLabelPuestoAc.AutoSize = true;
            this.TLabelPuestoAc.Location = new System.Drawing.Point(59, 245);
            this.TLabelPuestoAc.Name = "TLabelPuestoAc";
            this.TLabelPuestoAc.Size = new System.Drawing.Size(73, 13);
            this.TLabelPuestoAc.TabIndex = 33;
            this.TLabelPuestoAc.Text = "Puesto Actual";
            // 
            // TLabelCiudades
            // 
            this.TLabelCiudades.AutoSize = true;
            this.TLabelCiudades.Location = new System.Drawing.Point(92, 223);
            this.TLabelCiudades.Name = "TLabelCiudades";
            this.TLabelCiudades.Size = new System.Drawing.Size(40, 13);
            this.TLabelCiudades.TabIndex = 32;
            this.TLabelCiudades.Text = "Ciudad";
            // 
            // TLabelProvincias
            // 
            this.TLabelProvincias.AutoSize = true;
            this.TLabelProvincias.Location = new System.Drawing.Point(84, 201);
            this.TLabelProvincias.Name = "TLabelProvincias";
            this.TLabelProvincias.Size = new System.Drawing.Size(51, 13);
            this.TLabelProvincias.TabIndex = 31;
            this.TLabelProvincias.Text = "Provincia";
            // 
            // TLabelTelefono1
            // 
            this.TLabelTelefono1.AutoSize = true;
            this.TLabelTelefono1.Location = new System.Drawing.Point(74, 136);
            this.TLabelTelefono1.Name = "TLabelTelefono1";
            this.TLabelTelefono1.Size = new System.Drawing.Size(58, 13);
            this.TLabelTelefono1.TabIndex = 30;
            this.TLabelTelefono1.Text = "Telefono 1";
            // 
            // TLabelApellidos
            // 
            this.TLabelApellidos.AutoSize = true;
            this.TLabelApellidos.Location = new System.Drawing.Point(83, 114);
            this.TLabelApellidos.Name = "TLabelApellidos";
            this.TLabelApellidos.Size = new System.Drawing.Size(49, 13);
            this.TLabelApellidos.TabIndex = 29;
            this.TLabelApellidos.Text = "Apellidos";
            // 
            // TLabelNombre
            // 
            this.TLabelNombre.AutoSize = true;
            this.TLabelNombre.Location = new System.Drawing.Point(88, 92);
            this.TLabelNombre.Name = "TLabelNombre";
            this.TLabelNombre.Size = new System.Drawing.Size(44, 13);
            this.TLabelNombre.TabIndex = 28;
            this.TLabelNombre.Text = "Nombre";
            // 
            // TLabelDNI
            // 
            this.TLabelDNI.AutoSize = true;
            this.TLabelDNI.Location = new System.Drawing.Point(106, 69);
            this.TLabelDNI.Name = "TLabelDNI";
            this.TLabelDNI.Size = new System.Drawing.Size(26, 13);
            this.TLabelDNI.TabIndex = 27;
            this.TLabelDNI.Text = "DNI";
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
            this.TLabelTitulo.Location = new System.Drawing.Point(2, 0);
            this.TLabelTitulo.Name = "TLabelTitulo";
            this.TLabelTitulo.Size = new System.Drawing.Size(105, 18);
            this.TLabelTitulo.TabIndex = 40;
            this.TLabelTitulo.Text = "Datos del Personal";
            // 
            // GestionPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AlquilerCoches.Properties.Resources.rentacar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 608);
            this.Controls.Add(this.TLabelTitulo);
            this.Controls.Add(this.TGroupBoxAlta);
            this.Controls.Add(this.TButtonGuardarPersonal);
            this.Controls.Add(this.TButtonFoto);
            this.Controls.Add(this.TButtonCancelar);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(894, 608);
            this.MinimumSize = new System.Drawing.Size(894, 608);
            this.Name = "GestionPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionPersonal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GestionPersonal_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TGroupBoxAlta.ResumeLayout(false);
            this.TGroupBoxAlta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button TButtonCancelar;
        private System.Windows.Forms.Button TButtonFoto;
        private System.Windows.Forms.Button TButtonGuardarPersonal;
        private System.Windows.Forms.GroupBox TGroupBoxAlta;
        private System.Windows.Forms.TextBox TTextBoxDireccion;
        private System.Windows.Forms.Label TLabelDireccion;
        private System.Windows.Forms.TextBox TTextBoxEmail;
        private System.Windows.Forms.Label TLabelEmail;
        private System.Windows.Forms.TextBox TTextBoxPuestoAc;
        private System.Windows.Forms.TextBox TTextBoxTelefono;
        private System.Windows.Forms.TextBox TTextBoxApellidos;
        private System.Windows.Forms.TextBox TTextBoxNombre;
        private System.Windows.Forms.TextBox TTextBoxDNI;
        private System.Windows.Forms.Label TLabelPuestoAc;
        private System.Windows.Forms.Label TLabelProvincias;
        private System.Windows.Forms.Label TLabelTelefono1;
        private System.Windows.Forms.Label TLabelApellidos;
        private System.Windows.Forms.Label TLabelNombre;
        private System.Windows.Forms.Label TLabelDNI;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox TComboBoxProvincias;
        private System.Windows.Forms.ComboBox TComboBoxCiudades;
        private System.Windows.Forms.Label TLabelCiudades;
        private System.Windows.Forms.Label TLabelTitulo;
    }
}