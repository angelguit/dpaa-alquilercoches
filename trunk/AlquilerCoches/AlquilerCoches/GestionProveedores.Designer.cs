namespace AlquilerCoches
{
    partial class GestionProveedores
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
            this.TButtonFoto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TButtonGuardarProveedor = new System.Windows.Forms.Button();
            this.TButtonCancelar = new System.Windows.Forms.Button();
            this.TGroupBoxProveedores = new System.Windows.Forms.GroupBox();
            this.TComboBoxCiudades = new System.Windows.Forms.ComboBox();
            this.TComboBoxProvincias = new System.Windows.Forms.ComboBox();
            this.TLabelProvincia = new System.Windows.Forms.Label();
            this.TTextBoxNumero = new System.Windows.Forms.TextBox();
            this.TLabelNumero = new System.Windows.Forms.Label();
            this.TTextBoxHorario = new System.Windows.Forms.TextBox();
            this.TLabelHorario = new System.Windows.Forms.Label();
            this.TTextBoxEmail = new System.Windows.Forms.TextBox();
            this.TLabelEmail = new System.Windows.Forms.Label();
            this.TTextBoxCPostal = new System.Windows.Forms.TextBox();
            this.TTextBoxTelefono = new System.Windows.Forms.TextBox();
            this.TTextBoxCalle = new System.Windows.Forms.TextBox();
            this.TTextBoxMarca = new System.Windows.Forms.TextBox();
            this.TTextBoxCIF = new System.Windows.Forms.TextBox();
            this.TLabelCPostal = new System.Windows.Forms.Label();
            this.TLabelCiudad = new System.Windows.Forms.Label();
            this.TLabelTelefono = new System.Windows.Forms.Label();
            this.TLabelCalle = new System.Windows.Forms.Label();
            this.TLabelNombre = new System.Windows.Forms.Label();
            this.TLabelCIF = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TLabelTitulo = new System.Windows.Forms.Label();
            this.TButtonCerrar = new System.Windows.Forms.Button();
            this.TButtonGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TGroupBoxProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TButtonFoto
            // 
            this.TButtonFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TButtonFoto.Location = new System.Drawing.Point(724, 206);
            this.TButtonFoto.Name = "TButtonFoto";
            this.TButtonFoto.Size = new System.Drawing.Size(56, 23);
            this.TButtonFoto.TabIndex = 49;
            this.TButtonFoto.Text = "Foto";
            this.TButtonFoto.UseVisualStyleBackColor = true;
            this.TButtonFoto.Click += new System.EventHandler(this.TButtonFoto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::AlquilerCoches.Properties.Resources.Desconocido;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(706, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 110);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // TButtonGuardarProveedor
            // 
            this.TButtonGuardarProveedor.Location = new System.Drawing.Point(26, 367);
            this.TButtonGuardarProveedor.Name = "TButtonGuardarProveedor";
            this.TButtonGuardarProveedor.Size = new System.Drawing.Size(77, 24);
            this.TButtonGuardarProveedor.TabIndex = 50;
            this.TButtonGuardarProveedor.Text = "Guardar";
            this.TButtonGuardarProveedor.UseVisualStyleBackColor = true;
            // 
            // TButtonCancelar
            // 
            this.TButtonCancelar.Location = new System.Drawing.Point(109, 368);
            this.TButtonCancelar.Name = "TButtonCancelar";
            this.TButtonCancelar.Size = new System.Drawing.Size(75, 23);
            this.TButtonCancelar.TabIndex = 51;
            this.TButtonCancelar.Text = "Cancelar";
            this.TButtonCancelar.UseVisualStyleBackColor = true;
            this.TButtonCancelar.Click += new System.EventHandler(this.TButtonCancelar_Click);
            // 
            // TGroupBoxProveedores
            // 
            this.TGroupBoxProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TGroupBoxProveedores.BackColor = System.Drawing.Color.Transparent;
            this.TGroupBoxProveedores.Controls.Add(this.TComboBoxCiudades);
            this.TGroupBoxProveedores.Controls.Add(this.TComboBoxProvincias);
            this.TGroupBoxProveedores.Controls.Add(this.TLabelProvincia);
            this.TGroupBoxProveedores.Controls.Add(this.TTextBoxNumero);
            this.TGroupBoxProveedores.Controls.Add(this.TLabelNumero);
            this.TGroupBoxProveedores.Controls.Add(this.TTextBoxHorario);
            this.TGroupBoxProveedores.Controls.Add(this.TLabelHorario);
            this.TGroupBoxProveedores.Controls.Add(this.TTextBoxEmail);
            this.TGroupBoxProveedores.Controls.Add(this.TLabelEmail);
            this.TGroupBoxProveedores.Controls.Add(this.TTextBoxCPostal);
            this.TGroupBoxProveedores.Controls.Add(this.TTextBoxTelefono);
            this.TGroupBoxProveedores.Controls.Add(this.TTextBoxCalle);
            this.TGroupBoxProveedores.Controls.Add(this.TTextBoxMarca);
            this.TGroupBoxProveedores.Controls.Add(this.TTextBoxCIF);
            this.TGroupBoxProveedores.Controls.Add(this.TLabelCPostal);
            this.TGroupBoxProveedores.Controls.Add(this.TLabelCiudad);
            this.TGroupBoxProveedores.Controls.Add(this.TLabelTelefono);
            this.TGroupBoxProveedores.Controls.Add(this.TLabelCalle);
            this.TGroupBoxProveedores.Controls.Add(this.TLabelNombre);
            this.TGroupBoxProveedores.Controls.Add(this.TLabelCIF);
            this.TGroupBoxProveedores.Location = new System.Drawing.Point(26, 83);
            this.TGroupBoxProveedores.Name = "TGroupBoxProveedores";
            this.TGroupBoxProveedores.Size = new System.Drawing.Size(620, 330);
            this.TGroupBoxProveedores.TabIndex = 52;
            this.TGroupBoxProveedores.TabStop = false;
            this.TGroupBoxProveedores.Text = "Datos Proveedor";
            // 
            // TComboBoxCiudades
            // 
            this.TComboBoxCiudades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TComboBoxCiudades.FormattingEnabled = true;
            this.TComboBoxCiudades.Location = new System.Drawing.Point(98, 205);
            this.TComboBoxCiudades.Name = "TComboBoxCiudades";
            this.TComboBoxCiudades.Size = new System.Drawing.Size(154, 21);
            this.TComboBoxCiudades.TabIndex = 7;
            this.TComboBoxCiudades.Click += new System.EventHandler(this.TComboBoxCiudades_Click);
            this.TComboBoxCiudades.Leave += new System.EventHandler(this.TComboBoxCiudades_Leave_1);
            // 
            // TComboBoxProvincias
            // 
            this.TComboBoxProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TComboBoxProvincias.FormattingEnabled = true;
            this.TComboBoxProvincias.Location = new System.Drawing.Point(98, 179);
            this.TComboBoxProvincias.Name = "TComboBoxProvincias";
            this.TComboBoxProvincias.Size = new System.Drawing.Size(154, 21);
            this.TComboBoxProvincias.TabIndex = 6;
            this.TComboBoxProvincias.TextChanged += new System.EventHandler(this.TComboBoxProvincias_TextChanged);
            this.TComboBoxProvincias.Click += new System.EventHandler(this.TComboBoxProvincias_Click);
            this.TComboBoxProvincias.Leave += new System.EventHandler(this.TComboBoxProvincias_Leave_1);
            // 
            // TLabelProvincia
            // 
            this.TLabelProvincia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TLabelProvincia.AutoSize = true;
            this.TLabelProvincia.Location = new System.Drawing.Point(32, 191);
            this.TLabelProvincia.Name = "TLabelProvincia";
            this.TLabelProvincia.Size = new System.Drawing.Size(51, 13);
            this.TLabelProvincia.TabIndex = 66;
            this.TLabelProvincia.Text = "Provincia";
            // 
            // TTextBoxNumero
            // 
            this.TTextBoxNumero.Location = new System.Drawing.Point(289, 110);
            this.TTextBoxNumero.Name = "TTextBoxNumero";
            this.TTextBoxNumero.Size = new System.Drawing.Size(53, 20);
            this.TTextBoxNumero.TabIndex = 3;
            this.TTextBoxNumero.Leave += new System.EventHandler(this.TTextBoxNumero_Leave);
            // 
            // TLabelNumero
            // 
            this.TLabelNumero.AutoSize = true;
            this.TLabelNumero.Location = new System.Drawing.Point(266, 113);
            this.TLabelNumero.Name = "TLabelNumero";
            this.TLabelNumero.Size = new System.Drawing.Size(17, 13);
            this.TLabelNumero.TabIndex = 64;
            this.TLabelNumero.Text = "nº";
            // 
            // TTextBoxHorario
            // 
            this.TTextBoxHorario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TTextBoxHorario.Location = new System.Drawing.Point(98, 267);
            this.TTextBoxHorario.Name = "TTextBoxHorario";
            this.TTextBoxHorario.Size = new System.Drawing.Size(154, 20);
            this.TTextBoxHorario.TabIndex = 9;
            // 
            // TLabelHorario
            // 
            this.TLabelHorario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TLabelHorario.AutoSize = true;
            this.TLabelHorario.Location = new System.Drawing.Point(42, 274);
            this.TLabelHorario.Name = "TLabelHorario";
            this.TLabelHorario.Size = new System.Drawing.Size(41, 13);
            this.TLabelHorario.TabIndex = 63;
            this.TLabelHorario.Text = "Horario";
            // 
            // TTextBoxEmail
            // 
            this.TTextBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TTextBoxEmail.Location = new System.Drawing.Point(98, 155);
            this.TTextBoxEmail.Name = "TTextBoxEmail";
            this.TTextBoxEmail.Size = new System.Drawing.Size(154, 20);
            this.TTextBoxEmail.TabIndex = 5;
            this.TTextBoxEmail.Leave += new System.EventHandler(this.TTextBoxEmail_Leave_1);
            // 
            // TLabelEmail
            // 
            this.TLabelEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TLabelEmail.AutoSize = true;
            this.TLabelEmail.Location = new System.Drawing.Point(51, 162);
            this.TLabelEmail.Name = "TLabelEmail";
            this.TLabelEmail.Size = new System.Drawing.Size(32, 13);
            this.TLabelEmail.TabIndex = 61;
            this.TLabelEmail.Text = "Email";
            // 
            // TTextBoxCPostal
            // 
            this.TTextBoxCPostal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TTextBoxCPostal.Location = new System.Drawing.Point(98, 241);
            this.TTextBoxCPostal.Name = "TTextBoxCPostal";
            this.TTextBoxCPostal.Size = new System.Drawing.Size(154, 20);
            this.TTextBoxCPostal.TabIndex = 8;
            this.TTextBoxCPostal.Leave += new System.EventHandler(this.TTextBoxCPostal_Leave);
            // 
            // TTextBoxTelefono
            // 
            this.TTextBoxTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TTextBoxTelefono.Location = new System.Drawing.Point(98, 132);
            this.TTextBoxTelefono.Name = "TTextBoxTelefono";
            this.TTextBoxTelefono.Size = new System.Drawing.Size(154, 20);
            this.TTextBoxTelefono.TabIndex = 4;
            this.TTextBoxTelefono.Leave += new System.EventHandler(this.TTextBoxTelefono_Leave_1);
            // 
            // TTextBoxCalle
            // 
            this.TTextBoxCalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TTextBoxCalle.Location = new System.Drawing.Point(98, 110);
            this.TTextBoxCalle.Name = "TTextBoxCalle";
            this.TTextBoxCalle.Size = new System.Drawing.Size(154, 20);
            this.TTextBoxCalle.TabIndex = 2;
            this.TTextBoxCalle.Leave += new System.EventHandler(this.TTextBoxCalle_Leave);
            // 
            // TTextBoxMarca
            // 
            this.TTextBoxMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TTextBoxMarca.Location = new System.Drawing.Point(98, 88);
            this.TTextBoxMarca.Name = "TTextBoxMarca";
            this.TTextBoxMarca.Size = new System.Drawing.Size(154, 20);
            this.TTextBoxMarca.TabIndex = 1;
            this.TTextBoxMarca.Leave += new System.EventHandler(this.TTextBoxMarca_Leave);
            // 
            // TTextBoxCIF
            // 
            this.TTextBoxCIF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TTextBoxCIF.Location = new System.Drawing.Point(98, 65);
            this.TTextBoxCIF.Name = "TTextBoxCIF";
            this.TTextBoxCIF.Size = new System.Drawing.Size(154, 20);
            this.TTextBoxCIF.TabIndex = 0;
            this.TTextBoxCIF.Leave += new System.EventHandler(this.TTextBoxCIF_Leave);
            // 
            // TLabelCPostal
            // 
            this.TLabelCPostal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TLabelCPostal.AutoSize = true;
            this.TLabelCPostal.Location = new System.Drawing.Point(11, 248);
            this.TLabelCPostal.Name = "TLabelCPostal";
            this.TLabelCPostal.Size = new System.Drawing.Size(72, 13);
            this.TLabelCPostal.TabIndex = 51;
            this.TLabelCPostal.Text = "Codigo Postal";
            // 
            // TLabelCiudad
            // 
            this.TLabelCiudad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TLabelCiudad.AutoSize = true;
            this.TLabelCiudad.Location = new System.Drawing.Point(43, 217);
            this.TLabelCiudad.Name = "TLabelCiudad";
            this.TLabelCiudad.Size = new System.Drawing.Size(40, 13);
            this.TLabelCiudad.TabIndex = 49;
            this.TLabelCiudad.Text = "Ciudad";
            // 
            // TLabelTelefono
            // 
            this.TLabelTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TLabelTelefono.AutoSize = true;
            this.TLabelTelefono.Location = new System.Drawing.Point(34, 139);
            this.TLabelTelefono.Name = "TLabelTelefono";
            this.TLabelTelefono.Size = new System.Drawing.Size(49, 13);
            this.TLabelTelefono.TabIndex = 48;
            this.TLabelTelefono.Text = "Telefono";
            // 
            // TLabelCalle
            // 
            this.TLabelCalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TLabelCalle.AutoSize = true;
            this.TLabelCalle.Location = new System.Drawing.Point(53, 117);
            this.TLabelCalle.Name = "TLabelCalle";
            this.TLabelCalle.Size = new System.Drawing.Size(30, 13);
            this.TLabelCalle.TabIndex = 47;
            this.TLabelCalle.Text = "Calle";
            // 
            // TLabelNombre
            // 
            this.TLabelNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TLabelNombre.AutoSize = true;
            this.TLabelNombre.Location = new System.Drawing.Point(46, 95);
            this.TLabelNombre.Name = "TLabelNombre";
            this.TLabelNombre.Size = new System.Drawing.Size(37, 13);
            this.TLabelNombre.TabIndex = 46;
            this.TLabelNombre.Text = "Marca";
            // 
            // TLabelCIF
            // 
            this.TLabelCIF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TLabelCIF.AutoSize = true;
            this.TLabelCIF.Location = new System.Drawing.Point(60, 72);
            this.TLabelCIF.Name = "TLabelCIF";
            this.TLabelCIF.Size = new System.Drawing.Size(23, 13);
            this.TLabelCIF.TabIndex = 45;
            this.TLabelCIF.Text = "CIF";
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
            this.TLabelTitulo.Location = new System.Drawing.Point(3, -1);
            this.TLabelTitulo.Name = "TLabelTitulo";
            this.TLabelTitulo.Size = new System.Drawing.Size(111, 18);
            this.TLabelTitulo.TabIndex = 55;
            this.TLabelTitulo.Text = "Datos del Proveedor";
            // 
            // TButtonCerrar
            // 
            this.TButtonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TButtonCerrar.Image = global::AlquilerCoches.Properties.Resources.Close_icon;
            this.TButtonCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TButtonCerrar.Location = new System.Drawing.Point(127, 546);
            this.TButtonCerrar.Name = "TButtonCerrar";
            this.TButtonCerrar.Size = new System.Drawing.Size(78, 33);
            this.TButtonCerrar.TabIndex = 56;
            this.TButtonCerrar.Text = "Cerrar";
            this.TButtonCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TButtonCerrar.UseVisualStyleBackColor = true;
            this.TButtonCerrar.Click += new System.EventHandler(this.TButtonCerrar_Click);
            // 
            // TButtonGuardar
            // 
            this.TButtonGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TButtonGuardar.Image = global::AlquilerCoches.Properties.Resources.Add_icon;
            this.TButtonGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TButtonGuardar.Location = new System.Drawing.Point(29, 546);
            this.TButtonGuardar.Name = "TButtonGuardar";
            this.TButtonGuardar.Size = new System.Drawing.Size(80, 33);
            this.TButtonGuardar.TabIndex = 57;
            this.TButtonGuardar.Text = "Guardar";
            this.TButtonGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TButtonGuardar.UseVisualStyleBackColor = true;
            this.TButtonGuardar.Click += new System.EventHandler(this.TButtonGuardarCliente_Click);
            // 
            // GestionProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AlquilerCoches.Properties.Resources.rentacar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 608);
            this.Controls.Add(this.TButtonGuardar);
            this.Controls.Add(this.TButtonCerrar);
            this.Controls.Add(this.TLabelTitulo);
            this.Controls.Add(this.TGroupBoxProveedores);
            this.Controls.Add(this.TButtonCancelar);
            this.Controls.Add(this.TButtonGuardarProveedor);
            this.Controls.Add(this.TButtonFoto);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GestionProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionProveedores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GestionProveedores_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TGroupBoxProveedores.ResumeLayout(false);
            this.TGroupBoxProveedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TButtonFoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button TButtonGuardarProveedor;
        private System.Windows.Forms.Button TButtonCancelar;
        private System.Windows.Forms.GroupBox TGroupBoxProveedores;
        private System.Windows.Forms.TextBox TTextBoxEmail;
        private System.Windows.Forms.Label TLabelEmail;
        private System.Windows.Forms.TextBox TTextBoxCPostal;
        private System.Windows.Forms.TextBox TTextBoxTelefono;
        private System.Windows.Forms.TextBox TTextBoxCalle;
        private System.Windows.Forms.TextBox TTextBoxMarca;
        private System.Windows.Forms.TextBox TTextBoxCIF;
        private System.Windows.Forms.Label TLabelCPostal;
        private System.Windows.Forms.Label TLabelCiudad;
        private System.Windows.Forms.Label TLabelTelefono;
        private System.Windows.Forms.Label TLabelCalle;
        private System.Windows.Forms.Label TLabelNombre;
        private System.Windows.Forms.Label TLabelCIF;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox TTextBoxHorario;
        private System.Windows.Forms.Label TLabelHorario;
        private System.Windows.Forms.TextBox TTextBoxNumero;
        private System.Windows.Forms.Label TLabelNumero;
        private System.Windows.Forms.ComboBox TComboBoxCiudades;
        private System.Windows.Forms.ComboBox TComboBoxProvincias;
        private System.Windows.Forms.Label TLabelProvincia;
        private System.Windows.Forms.Label TLabelTitulo;
        private System.Windows.Forms.Button TButtonCerrar;
        private System.Windows.Forms.Button TButtonGuardar;
    }
}