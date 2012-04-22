namespace AlquilerCoches
{
    partial class PonerVenta
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
            this.TButtonAtras = new System.Windows.Forms.Button();
            this.TListBoxMatriculas = new System.Windows.Forms.ListBox();
            this.TListBoxModelos = new System.Windows.Forms.ListBox();
            this.TListBoxMarcas = new System.Windows.Forms.ListBox();
            this.TLabelMatriculas = new System.Windows.Forms.Label();
            this.TLabelModelos = new System.Windows.Forms.Label();
            this.TLabelMarcas = new System.Windows.Forms.Label();
            this.TGroupBoxDatosVehiculo = new System.Windows.Forms.GroupBox();
            this.TButtonCancelar = new System.Windows.Forms.Button();
            this.TLabelObligatorio = new System.Windows.Forms.Label();
            this.TTextBoxMeses = new System.Windows.Forms.TextBox();
            this.TCheckBoxGarantia = new System.Windows.Forms.CheckBox();
            this.TLabelAviso = new System.Windows.Forms.Label();
            this.TButtonVender = new System.Windows.Forms.Button();
            this.TTextBoxPrecioVenta = new System.Windows.Forms.TextBox();
            this.TLabelPrecioVenta = new System.Windows.Forms.Label();
            this.TTextBoxKm = new System.Windows.Forms.TextBox();
            this.TLabelKM = new System.Windows.Forms.Label();
            this.TTextBoxModelo = new System.Windows.Forms.TextBox();
            this.TLabelModelo = new System.Windows.Forms.Label();
            this.TTextBoxMarca = new System.Windows.Forms.TextBox();
            this.TLabelGarantia = new System.Windows.Forms.Label();
            this.TLabelMarca = new System.Windows.Forms.Label();
            this.TPictureBoxCoche = new System.Windows.Forms.PictureBox();
            this.TTextBoxMatricula = new System.Windows.Forms.TextBox();
            this.TLabelMatricula = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TLabelTitulo = new System.Windows.Forms.Label();
            this.TGroupBoxDatosVehiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TPictureBoxCoche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TButtonAtras
            // 
            this.TButtonAtras.Image = global::AlquilerCoches.Properties.Resources.Close_icon;
            this.TButtonAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TButtonAtras.Location = new System.Drawing.Point(25, 477);
            this.TButtonAtras.Name = "TButtonAtras";
            this.TButtonAtras.Size = new System.Drawing.Size(75, 33);
            this.TButtonAtras.TabIndex = 7;
            this.TButtonAtras.Text = "Cerrar";
            this.TButtonAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TButtonAtras.UseVisualStyleBackColor = true;
            this.TButtonAtras.Click += new System.EventHandler(this.TButtonAtras_Click);
            // 
            // TListBoxMatriculas
            // 
            this.TListBoxMatriculas.FormattingEnabled = true;
            this.TListBoxMatriculas.Location = new System.Drawing.Point(530, 38);
            this.TListBoxMatriculas.Name = "TListBoxMatriculas";
            this.TListBoxMatriculas.Size = new System.Drawing.Size(253, 147);
            this.TListBoxMatriculas.TabIndex = 48;
            this.TListBoxMatriculas.SelectedIndexChanged += new System.EventHandler(this.TListBoxMatriculas_SelectedIndexChanged);
            // 
            // TListBoxModelos
            // 
            this.TListBoxModelos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TListBoxModelos.FormattingEnabled = true;
            this.TListBoxModelos.Location = new System.Drawing.Point(279, 38);
            this.TListBoxModelos.Name = "TListBoxModelos";
            this.TListBoxModelos.Size = new System.Drawing.Size(253, 147);
            this.TListBoxModelos.TabIndex = 47;
            this.TListBoxModelos.SelectedIndexChanged += new System.EventHandler(this.TListBoxModelos_SelectedIndexChanged);
            // 
            // TListBoxMarcas
            // 
            this.TListBoxMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TListBoxMarcas.FormattingEnabled = true;
            this.TListBoxMarcas.Location = new System.Drawing.Point(12, 38);
            this.TListBoxMarcas.Name = "TListBoxMarcas";
            this.TListBoxMarcas.Size = new System.Drawing.Size(269, 147);
            this.TListBoxMarcas.TabIndex = 46;
            this.TListBoxMarcas.SelectedIndexChanged += new System.EventHandler(this.TListBoxMarcas_SelectedIndexChanged);
            // 
            // TLabelMatriculas
            // 
            this.TLabelMatriculas.AutoSize = true;
            this.TLabelMatriculas.BackColor = System.Drawing.Color.Transparent;
            this.TLabelMatriculas.Location = new System.Drawing.Point(527, 22);
            this.TLabelMatriculas.Name = "TLabelMatriculas";
            this.TLabelMatriculas.Size = new System.Drawing.Size(57, 13);
            this.TLabelMatriculas.TabIndex = 44;
            this.TLabelMatriculas.Text = "Matrículas";
            // 
            // TLabelModelos
            // 
            this.TLabelModelos.AutoSize = true;
            this.TLabelModelos.BackColor = System.Drawing.Color.Transparent;
            this.TLabelModelos.Location = new System.Drawing.Point(268, 22);
            this.TLabelModelos.Name = "TLabelModelos";
            this.TLabelModelos.Size = new System.Drawing.Size(47, 13);
            this.TLabelModelos.TabIndex = 43;
            this.TLabelModelos.Text = "Modelos";
            // 
            // TLabelMarcas
            // 
            this.TLabelMarcas.AutoSize = true;
            this.TLabelMarcas.BackColor = System.Drawing.Color.Transparent;
            this.TLabelMarcas.Location = new System.Drawing.Point(9, 22);
            this.TLabelMarcas.Name = "TLabelMarcas";
            this.TLabelMarcas.Size = new System.Drawing.Size(42, 13);
            this.TLabelMarcas.TabIndex = 42;
            this.TLabelMarcas.Text = "Marcas";
            // 
            // TGroupBoxDatosVehiculo
            // 
            this.TGroupBoxDatosVehiculo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TGroupBoxDatosVehiculo.BackColor = System.Drawing.Color.Transparent;
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TButtonCancelar);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TLabelObligatorio);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TTextBoxMeses);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TCheckBoxGarantia);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TLabelAviso);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TButtonVender);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TTextBoxPrecioVenta);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TLabelPrecioVenta);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TTextBoxKm);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TLabelKM);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TTextBoxModelo);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TLabelModelo);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TTextBoxMarca);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TLabelGarantia);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TLabelMarca);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TPictureBoxCoche);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TTextBoxMatricula);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TLabelMatricula);
            this.TGroupBoxDatosVehiculo.Location = new System.Drawing.Point(25, 215);
            this.TGroupBoxDatosVehiculo.Name = "TGroupBoxDatosVehiculo";
            this.TGroupBoxDatosVehiculo.Size = new System.Drawing.Size(559, 246);
            this.TGroupBoxDatosVehiculo.TabIndex = 41;
            this.TGroupBoxDatosVehiculo.TabStop = false;
            this.TGroupBoxDatosVehiculo.Text = "DatosVehiculo";
            // 
            // TButtonCancelar
            // 
            this.TButtonCancelar.Image = global::AlquilerCoches.Properties.Resources.Close_icon;
            this.TButtonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TButtonCancelar.Location = new System.Drawing.Point(348, 190);
            this.TButtonCancelar.Name = "TButtonCancelar";
            this.TButtonCancelar.Size = new System.Drawing.Size(84, 37);
            this.TButtonCancelar.TabIndex = 6;
            this.TButtonCancelar.Tag = "";
            this.TButtonCancelar.Text = "Cancelar";
            this.TButtonCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TButtonCancelar.UseVisualStyleBackColor = true;
            this.TButtonCancelar.Click += new System.EventHandler(this.TButtonCancelar_Click);
            // 
            // TLabelObligatorio
            // 
            this.TLabelObligatorio.AutoSize = true;
            this.TLabelObligatorio.Location = new System.Drawing.Point(22, 202);
            this.TLabelObligatorio.Name = "TLabelObligatorio";
            this.TLabelObligatorio.Size = new System.Drawing.Size(217, 13);
            this.TLabelObligatorio.TabIndex = 49;
            this.TLabelObligatorio.Text = "Los campos marcados con * son obligatorios";
            // 
            // TTextBoxMeses
            // 
            this.TTextBoxMeses.Enabled = false;
            this.TTextBoxMeses.Location = new System.Drawing.Point(144, 129);
            this.TTextBoxMeses.Name = "TTextBoxMeses";
            this.TTextBoxMeses.Size = new System.Drawing.Size(95, 20);
            this.TTextBoxMeses.TabIndex = 3;
            this.TTextBoxMeses.Text = "Meses";
            this.TTextBoxMeses.Click += new System.EventHandler(this.TTextBoxMeses_Click);
            this.TTextBoxMeses.TextChanged += new System.EventHandler(this.TTextBoxMeses_TextChanged);
            this.TTextBoxMeses.Leave += new System.EventHandler(this.TTextBoxMeses_Leave);
            // 
            // TCheckBoxGarantia
            // 
            this.TCheckBoxGarantia.AutoSize = true;
            this.TCheckBoxGarantia.Location = new System.Drawing.Point(81, 133);
            this.TCheckBoxGarantia.Name = "TCheckBoxGarantia";
            this.TCheckBoxGarantia.Size = new System.Drawing.Size(56, 17);
            this.TCheckBoxGarantia.TabIndex = 2;
            this.TCheckBoxGarantia.Text = "Sí/No";
            this.TCheckBoxGarantia.UseVisualStyleBackColor = true;
            this.TCheckBoxGarantia.CheckedChanged += new System.EventHandler(this.TCheckBoxGarantia_CheckedChanged);
            // 
            // TLabelAviso
            // 
            this.TLabelAviso.AutoSize = true;
            this.TLabelAviso.ForeColor = System.Drawing.Color.Red;
            this.TLabelAviso.Location = new System.Drawing.Point(7, 221);
            this.TLabelAviso.Name = "TLabelAviso";
            this.TLabelAviso.Size = new System.Drawing.Size(0, 13);
            this.TLabelAviso.TabIndex = 46;
            // 
            // TButtonVender
            // 
            this.TButtonVender.Image = global::AlquilerCoches.Properties.Resources.Add_icon;
            this.TButtonVender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TButtonVender.Location = new System.Drawing.Point(246, 190);
            this.TButtonVender.Name = "TButtonVender";
            this.TButtonVender.Size = new System.Drawing.Size(78, 37);
            this.TButtonVender.TabIndex = 5;
            this.TButtonVender.Tag = "";
            this.TButtonVender.Text = "Añadir";
            this.TButtonVender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TButtonVender.UseVisualStyleBackColor = true;
            this.TButtonVender.Click += new System.EventHandler(this.TButtonVender_Click);
            this.TButtonVender.MouseLeave += new System.EventHandler(this.TButtonVender_MouseLeave);
            this.TButtonVender.MouseHover += new System.EventHandler(this.TButtonVender_MouseHover);
            // 
            // TTextBoxPrecioVenta
            // 
            this.TTextBoxPrecioVenta.Location = new System.Drawing.Point(80, 157);
            this.TTextBoxPrecioVenta.Name = "TTextBoxPrecioVenta";
            this.TTextBoxPrecioVenta.Size = new System.Drawing.Size(159, 20);
            this.TTextBoxPrecioVenta.TabIndex = 4;
            this.TTextBoxPrecioVenta.Leave += new System.EventHandler(this.TTextBoxPrecioVenta_Leave);
            // 
            // TLabelPrecioVenta
            // 
            this.TLabelPrecioVenta.AutoSize = true;
            this.TLabelPrecioVenta.Location = new System.Drawing.Point(9, 164);
            this.TLabelPrecioVenta.Name = "TLabelPrecioVenta";
            this.TLabelPrecioVenta.Size = new System.Drawing.Size(69, 13);
            this.TLabelPrecioVenta.TabIndex = 43;
            this.TLabelPrecioVenta.Text = "PrecioVenta*";
            // 
            // TTextBoxKm
            // 
            this.TTextBoxKm.Location = new System.Drawing.Point(80, 105);
            this.TTextBoxKm.Name = "TTextBoxKm";
            this.TTextBoxKm.Size = new System.Drawing.Size(159, 20);
            this.TTextBoxKm.TabIndex = 1;
            this.TTextBoxKm.Leave += new System.EventHandler(this.TTextBoxKm_Leave);
            // 
            // TLabelKM
            // 
            this.TLabelKM.AutoSize = true;
            this.TLabelKM.Location = new System.Drawing.Point(49, 112);
            this.TLabelKM.Name = "TLabelKM";
            this.TLabelKM.Size = new System.Drawing.Size(27, 13);
            this.TLabelKM.TabIndex = 39;
            this.TLabelKM.Text = "KM*";
            // 
            // TTextBoxModelo
            // 
            this.TTextBoxModelo.Location = new System.Drawing.Point(80, 79);
            this.TTextBoxModelo.Name = "TTextBoxModelo";
            this.TTextBoxModelo.ReadOnly = true;
            this.TTextBoxModelo.Size = new System.Drawing.Size(159, 20);
            this.TTextBoxModelo.TabIndex = 38;
            // 
            // TLabelModelo
            // 
            this.TLabelModelo.AutoSize = true;
            this.TLabelModelo.Location = new System.Drawing.Point(30, 86);
            this.TLabelModelo.Name = "TLabelModelo";
            this.TLabelModelo.Size = new System.Drawing.Size(42, 13);
            this.TLabelModelo.TabIndex = 37;
            this.TLabelModelo.Text = "Modelo";
            // 
            // TTextBoxMarca
            // 
            this.TTextBoxMarca.Location = new System.Drawing.Point(80, 49);
            this.TTextBoxMarca.Name = "TTextBoxMarca";
            this.TTextBoxMarca.ReadOnly = true;
            this.TTextBoxMarca.Size = new System.Drawing.Size(159, 20);
            this.TTextBoxMarca.TabIndex = 36;
            // 
            // TLabelGarantia
            // 
            this.TLabelGarantia.AutoSize = true;
            this.TLabelGarantia.Location = new System.Drawing.Point(25, 138);
            this.TLabelGarantia.Name = "TLabelGarantia";
            this.TLabelGarantia.Size = new System.Drawing.Size(49, 13);
            this.TLabelGarantia.TabIndex = 41;
            this.TLabelGarantia.Text = "Garantía";
            // 
            // TLabelMarca
            // 
            this.TLabelMarca.AutoSize = true;
            this.TLabelMarca.Location = new System.Drawing.Point(35, 56);
            this.TLabelMarca.Name = "TLabelMarca";
            this.TLabelMarca.Size = new System.Drawing.Size(37, 13);
            this.TLabelMarca.TabIndex = 35;
            this.TLabelMarca.Text = "Marca";
            // 
            // TPictureBoxCoche
            // 
            this.TPictureBoxCoche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TPictureBoxCoche.Location = new System.Drawing.Point(246, 19);
            this.TPictureBoxCoche.Name = "TPictureBoxCoche";
            this.TPictureBoxCoche.Size = new System.Drawing.Size(186, 158);
            this.TPictureBoxCoche.TabIndex = 31;
            this.TPictureBoxCoche.TabStop = false;
            // 
            // TTextBoxMatricula
            // 
            this.TTextBoxMatricula.Location = new System.Drawing.Point(80, 23);
            this.TTextBoxMatricula.Name = "TTextBoxMatricula";
            this.TTextBoxMatricula.ReadOnly = true;
            this.TTextBoxMatricula.Size = new System.Drawing.Size(159, 20);
            this.TTextBoxMatricula.TabIndex = 20;
            // 
            // TLabelMatricula
            // 
            this.TLabelMatricula.AutoSize = true;
            this.TLabelMatricula.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TLabelMatricula.Location = new System.Drawing.Point(22, 30);
            this.TLabelMatricula.Name = "TLabelMatricula";
            this.TLabelMatricula.Size = new System.Drawing.Size(52, 13);
            this.TLabelMatricula.TabIndex = 19;
            this.TLabelMatricula.Text = "Matrícula";
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
            this.TLabelTitulo.Size = new System.Drawing.Size(86, 18);
            this.TLabelTitulo.TabIndex = 49;
            this.TLabelTitulo.Text = "Poner en Venta";
            // 
            // PonerVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AlquilerCoches.Properties.Resources.rentacar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 608);
            this.Controls.Add(this.TLabelTitulo);
            this.Controls.Add(this.TButtonAtras);
            this.Controls.Add(this.TListBoxMatriculas);
            this.Controls.Add(this.TListBoxModelos);
            this.Controls.Add(this.TListBoxMarcas);
            this.Controls.Add(this.TLabelMatriculas);
            this.Controls.Add(this.TLabelModelos);
            this.Controls.Add(this.TLabelMarcas);
            this.Controls.Add(this.TGroupBoxDatosVehiculo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(894, 608);
            this.MinimumSize = new System.Drawing.Size(894, 608);
            this.Name = "PonerVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poner en Venta";
            this.TGroupBoxDatosVehiculo.ResumeLayout(false);
            this.TGroupBoxDatosVehiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TPictureBoxCoche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TButtonAtras;
        private System.Windows.Forms.ListBox TListBoxMatriculas;
        private System.Windows.Forms.ListBox TListBoxModelos;
        private System.Windows.Forms.ListBox TListBoxMarcas;
        private System.Windows.Forms.Label TLabelMatriculas;
        private System.Windows.Forms.Label TLabelModelos;
        private System.Windows.Forms.Label TLabelMarcas;
        private System.Windows.Forms.GroupBox TGroupBoxDatosVehiculo;
        private System.Windows.Forms.TextBox TTextBoxKm;
        private System.Windows.Forms.Label TLabelKM;
        private System.Windows.Forms.TextBox TTextBoxModelo;
        private System.Windows.Forms.Label TLabelModelo;
        private System.Windows.Forms.TextBox TTextBoxMarca;
        private System.Windows.Forms.Label TLabelGarantia;
        private System.Windows.Forms.Label TLabelMarca;
        private System.Windows.Forms.PictureBox TPictureBoxCoche;
        private System.Windows.Forms.TextBox TTextBoxMatricula;
        private System.Windows.Forms.Label TLabelMatricula;
        private System.Windows.Forms.TextBox TTextBoxPrecioVenta;
        private System.Windows.Forms.Label TLabelPrecioVenta;
        private System.Windows.Forms.Button TButtonVender;
        private System.Windows.Forms.Label TLabelAviso;
        private System.Windows.Forms.CheckBox TCheckBoxGarantia;
        private System.Windows.Forms.TextBox TTextBoxMeses;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label TLabelObligatorio;
        private System.Windows.Forms.Button TButtonCancelar;
        private System.Windows.Forms.Label TLabelTitulo;

    }
}