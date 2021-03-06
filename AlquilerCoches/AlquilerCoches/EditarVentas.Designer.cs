﻿namespace AlquilerCoches
{
    partial class EditarVentas
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
            this.TCheckBoxReservado = new System.Windows.Forms.CheckBox();
            this.TLabelReservado = new System.Windows.Forms.Label();
            this.TButtonBorrar = new System.Windows.Forms.Button();
            this.TLabelObligatorio = new System.Windows.Forms.Label();
            this.TTextBoxMeses = new System.Windows.Forms.TextBox();
            this.TCheckBoxGarantia = new System.Windows.Forms.CheckBox();
            this.TButtonCancelar = new System.Windows.Forms.Button();
            this.TButtonAceptar = new System.Windows.Forms.Button();
            this.TTextBoxPrecioVenta = new System.Windows.Forms.TextBox();
            this.TLabelPrecioVenta = new System.Windows.Forms.Label();
            this.TTextBoxKm = new System.Windows.Forms.TextBox();
            this.TLabelKM = new System.Windows.Forms.Label();
            this.TTextBoxModelo = new System.Windows.Forms.TextBox();
            this.TLabelModelo = new System.Windows.Forms.Label();
            this.TTextBoxMarca = new System.Windows.Forms.TextBox();
            this.TLabelGarantia = new System.Windows.Forms.Label();
            this.TLabelMarca = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TTextBoxMatricula = new System.Windows.Forms.TextBox();
            this.TLabelMatricula = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TLabelTitulo = new System.Windows.Forms.Label();
            this.TLabelCategoria = new System.Windows.Forms.Label();
            this.TComboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.TGroupBoxDatosVehiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TButtonAtras
            // 
            this.TButtonAtras.Image = global::AlquilerCoches.Properties.Resources.Close_icon;
            this.TButtonAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TButtonAtras.Location = new System.Drawing.Point(21, 475);
            this.TButtonAtras.Name = "TButtonAtras";
            this.TButtonAtras.Size = new System.Drawing.Size(75, 32);
            this.TButtonAtras.TabIndex = 10;
            this.TButtonAtras.Text = "Cerrar";
            this.TButtonAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TButtonAtras.UseVisualStyleBackColor = true;
            this.TButtonAtras.Click += new System.EventHandler(this.TButtonAtras_Click);
            // 
            // TListBoxMatriculas
            // 
            this.TListBoxMatriculas.FormattingEnabled = true;
            this.TListBoxMatriculas.Location = new System.Drawing.Point(529, 43);
            this.TListBoxMatriculas.Name = "TListBoxMatriculas";
            this.TListBoxMatriculas.Size = new System.Drawing.Size(253, 147);
            this.TListBoxMatriculas.TabIndex = 58;
            this.TListBoxMatriculas.SelectedIndexChanged += new System.EventHandler(this.TListBoxMatriculas_SelectedIndexChanged);
            // 
            // TListBoxModelos
            // 
            this.TListBoxModelos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TListBoxModelos.FormattingEnabled = true;
            this.TListBoxModelos.Location = new System.Drawing.Point(270, 43);
            this.TListBoxModelos.Name = "TListBoxModelos";
            this.TListBoxModelos.Size = new System.Drawing.Size(253, 147);
            this.TListBoxModelos.TabIndex = 57;
            this.TListBoxModelos.SelectedIndexChanged += new System.EventHandler(this.TListBoxModelos_SelectedIndexChanged);
            // 
            // TListBoxMarcas
            // 
            this.TListBoxMarcas.FormattingEnabled = true;
            this.TListBoxMarcas.Location = new System.Drawing.Point(12, 43);
            this.TListBoxMarcas.Name = "TListBoxMarcas";
            this.TListBoxMarcas.Size = new System.Drawing.Size(253, 147);
            this.TListBoxMarcas.TabIndex = 56;
            this.TListBoxMarcas.SelectedIndexChanged += new System.EventHandler(this.TListBoxMarcas_SelectedIndexChanged);
            // 
            // TLabelMatriculas
            // 
            this.TLabelMatriculas.AutoSize = true;
            this.TLabelMatriculas.BackColor = System.Drawing.Color.Transparent;
            this.TLabelMatriculas.Location = new System.Drawing.Point(526, 27);
            this.TLabelMatriculas.Name = "TLabelMatriculas";
            this.TLabelMatriculas.Size = new System.Drawing.Size(57, 13);
            this.TLabelMatriculas.TabIndex = 54;
            this.TLabelMatriculas.Text = "Matrículas";
            // 
            // TLabelModelos
            // 
            this.TLabelModelos.AutoSize = true;
            this.TLabelModelos.BackColor = System.Drawing.Color.Transparent;
            this.TLabelModelos.Location = new System.Drawing.Point(268, 27);
            this.TLabelModelos.Name = "TLabelModelos";
            this.TLabelModelos.Size = new System.Drawing.Size(47, 13);
            this.TLabelModelos.TabIndex = 53;
            this.TLabelModelos.Text = "Modelos";
            // 
            // TLabelMarcas
            // 
            this.TLabelMarcas.AutoSize = true;
            this.TLabelMarcas.BackColor = System.Drawing.Color.Transparent;
            this.TLabelMarcas.Location = new System.Drawing.Point(9, 27);
            this.TLabelMarcas.Name = "TLabelMarcas";
            this.TLabelMarcas.Size = new System.Drawing.Size(42, 13);
            this.TLabelMarcas.TabIndex = 52;
            this.TLabelMarcas.Text = "Marcas";
            // 
            // TGroupBoxDatosVehiculo
            // 
            this.TGroupBoxDatosVehiculo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TGroupBoxDatosVehiculo.BackColor = System.Drawing.Color.Transparent;
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TComboBoxCategoria);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TLabelCategoria);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TCheckBoxReservado);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TLabelReservado);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TButtonBorrar);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TLabelObligatorio);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TTextBoxMeses);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TCheckBoxGarantia);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TButtonCancelar);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TButtonAceptar);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TTextBoxPrecioVenta);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TLabelPrecioVenta);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TTextBoxKm);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TLabelKM);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TTextBoxModelo);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TLabelModelo);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TTextBoxMarca);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TLabelGarantia);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TLabelMarca);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.pictureBox1);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TTextBoxMatricula);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TLabelMatricula);
            this.TGroupBoxDatosVehiculo.Location = new System.Drawing.Point(21, 207);
            this.TGroupBoxDatosVehiculo.Name = "TGroupBoxDatosVehiculo";
            this.TGroupBoxDatosVehiculo.Size = new System.Drawing.Size(546, 262);
            this.TGroupBoxDatosVehiculo.TabIndex = 51;
            this.TGroupBoxDatosVehiculo.TabStop = false;
            this.TGroupBoxDatosVehiculo.Text = "DatosVehiculo";
            this.TGroupBoxDatosVehiculo.Enter += new System.EventHandler(this.TGroupBoxDatosVehiculo_Enter);
            // 
            // TCheckBoxReservado
            // 
            this.TCheckBoxReservado.AutoSize = true;
            this.TCheckBoxReservado.Location = new System.Drawing.Point(95, 183);
            this.TCheckBoxReservado.Name = "TCheckBoxReservado";
            this.TCheckBoxReservado.Size = new System.Drawing.Size(56, 17);
            this.TCheckBoxReservado.TabIndex = 51;
            this.TCheckBoxReservado.Text = "Sí/No";
            this.TCheckBoxReservado.UseVisualStyleBackColor = true;
            // 
            // TLabelReservado
            // 
            this.TLabelReservado.AutoSize = true;
            this.TLabelReservado.Location = new System.Drawing.Point(30, 187);
            this.TLabelReservado.Name = "TLabelReservado";
            this.TLabelReservado.Size = new System.Drawing.Size(59, 13);
            this.TLabelReservado.TabIndex = 50;
            this.TLabelReservado.Text = "Reservado";
            // 
            // TButtonBorrar
            // 
            this.TButtonBorrar.Image = global::AlquilerCoches.Properties.Resources.Delete_icon;
            this.TButtonBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TButtonBorrar.Location = new System.Drawing.Point(465, 204);
            this.TButtonBorrar.Name = "TButtonBorrar";
            this.TButtonBorrar.Size = new System.Drawing.Size(72, 33);
            this.TButtonBorrar.TabIndex = 9;
            this.TButtonBorrar.Text = "Borrar";
            this.TButtonBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TButtonBorrar.UseVisualStyleBackColor = true;
            this.TButtonBorrar.Click += new System.EventHandler(this.TButtonBorrar_Click);
            // 
            // TLabelObligatorio
            // 
            this.TLabelObligatorio.AutoSize = true;
            this.TLabelObligatorio.Location = new System.Drawing.Point(6, 240);
            this.TLabelObligatorio.Name = "TLabelObligatorio";
            this.TLabelObligatorio.Size = new System.Drawing.Size(217, 13);
            this.TLabelObligatorio.TabIndex = 49;
            this.TLabelObligatorio.Text = "Los campos marcados con * son obligatorios";
            // 
            // TTextBoxMeses
            // 
            this.TTextBoxMeses.Enabled = false;
            this.TTextBoxMeses.Location = new System.Drawing.Point(159, 130);
            this.TTextBoxMeses.Name = "TTextBoxMeses";
            this.TTextBoxMeses.Size = new System.Drawing.Size(84, 20);
            this.TTextBoxMeses.TabIndex = 5;
            this.TTextBoxMeses.Text = "Meses";
            this.TTextBoxMeses.Click += new System.EventHandler(this.TTextBoxMeses_Click);
            this.TTextBoxMeses.Leave += new System.EventHandler(this.TTextBoxMeses_Leave);
            // 
            // TCheckBoxGarantia
            // 
            this.TCheckBoxGarantia.AutoSize = true;
            this.TCheckBoxGarantia.Location = new System.Drawing.Point(97, 133);
            this.TCheckBoxGarantia.Name = "TCheckBoxGarantia";
            this.TCheckBoxGarantia.Size = new System.Drawing.Size(56, 17);
            this.TCheckBoxGarantia.TabIndex = 4;
            this.TCheckBoxGarantia.Text = "Sí/No";
            this.TCheckBoxGarantia.UseVisualStyleBackColor = true;
            this.TCheckBoxGarantia.CheckedChanged += new System.EventHandler(this.TCheckBoxGarantia_CheckedChanged);
            // 
            // TButtonCancelar
            // 
            this.TButtonCancelar.Image = global::AlquilerCoches.Properties.Resources.Close_icon;
            this.TButtonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TButtonCancelar.Location = new System.Drawing.Point(357, 204);
            this.TButtonCancelar.Name = "TButtonCancelar";
            this.TButtonCancelar.Size = new System.Drawing.Size(86, 33);
            this.TButtonCancelar.TabIndex = 8;
            this.TButtonCancelar.Text = "Cancelar";
            this.TButtonCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TButtonCancelar.UseVisualStyleBackColor = true;
            this.TButtonCancelar.Click += new System.EventHandler(this.TButtonCancelar_Click);
            // 
            // TButtonAceptar
            // 
            this.TButtonAceptar.Image = global::AlquilerCoches.Properties.Resources.Add_icon;
            this.TButtonAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TButtonAceptar.Location = new System.Drawing.Point(265, 204);
            this.TButtonAceptar.Name = "TButtonAceptar";
            this.TButtonAceptar.Size = new System.Drawing.Size(86, 33);
            this.TButtonAceptar.TabIndex = 7;
            this.TButtonAceptar.Text = "Guardar";
            this.TButtonAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TButtonAceptar.UseVisualStyleBackColor = true;
            this.TButtonAceptar.Click += new System.EventHandler(this.TButtonAceptar_Click);
            // 
            // TTextBoxPrecioVenta
            // 
            this.TTextBoxPrecioVenta.Location = new System.Drawing.Point(97, 157);
            this.TTextBoxPrecioVenta.Name = "TTextBoxPrecioVenta";
            this.TTextBoxPrecioVenta.Size = new System.Drawing.Size(146, 20);
            this.TTextBoxPrecioVenta.TabIndex = 6;
            this.TTextBoxPrecioVenta.Leave += new System.EventHandler(this.TTextBoxPrecioVenta_Leave);
            // 
            // TLabelPrecioVenta
            // 
            this.TLabelPrecioVenta.AutoSize = true;
            this.TLabelPrecioVenta.Location = new System.Drawing.Point(6, 164);
            this.TLabelPrecioVenta.Name = "TLabelPrecioVenta";
            this.TLabelPrecioVenta.Size = new System.Drawing.Size(87, 13);
            this.TLabelPrecioVenta.TabIndex = 43;
            this.TLabelPrecioVenta.Text = "Precio de Venta*";
            // 
            // TTextBoxKm
            // 
            this.TTextBoxKm.Location = new System.Drawing.Point(97, 105);
            this.TTextBoxKm.Name = "TTextBoxKm";
            this.TTextBoxKm.Size = new System.Drawing.Size(146, 20);
            this.TTextBoxKm.TabIndex = 3;
            this.TTextBoxKm.Leave += new System.EventHandler(this.TTextBoxKm_Leave);
            // 
            // TLabelKM
            // 
            this.TLabelKM.AutoSize = true;
            this.TLabelKM.Location = new System.Drawing.Point(66, 108);
            this.TLabelKM.Name = "TLabelKM";
            this.TLabelKM.Size = new System.Drawing.Size(27, 13);
            this.TLabelKM.TabIndex = 39;
            this.TLabelKM.Text = "KM*";
            // 
            // TTextBoxModelo
            // 
            this.TTextBoxModelo.Location = new System.Drawing.Point(97, 79);
            this.TTextBoxModelo.Name = "TTextBoxModelo";
            this.TTextBoxModelo.Size = new System.Drawing.Size(146, 20);
            this.TTextBoxModelo.TabIndex = 2;
            this.TTextBoxModelo.Leave += new System.EventHandler(this.TTextBoxModelo_Leave);
            // 
            // TLabelModelo
            // 
            this.TLabelModelo.AutoSize = true;
            this.TLabelModelo.Location = new System.Drawing.Point(47, 82);
            this.TLabelModelo.Name = "TLabelModelo";
            this.TLabelModelo.Size = new System.Drawing.Size(46, 13);
            this.TLabelModelo.TabIndex = 37;
            this.TLabelModelo.Text = "Modelo*";
            // 
            // TTextBoxMarca
            // 
            this.TTextBoxMarca.Location = new System.Drawing.Point(97, 49);
            this.TTextBoxMarca.Name = "TTextBoxMarca";
            this.TTextBoxMarca.Size = new System.Drawing.Size(146, 20);
            this.TTextBoxMarca.TabIndex = 1;
            this.TTextBoxMarca.Leave += new System.EventHandler(this.TTextBoxMarca_Leave);
            // 
            // TLabelGarantia
            // 
            this.TLabelGarantia.AutoSize = true;
            this.TLabelGarantia.Location = new System.Drawing.Point(44, 137);
            this.TLabelGarantia.Name = "TLabelGarantia";
            this.TLabelGarantia.Size = new System.Drawing.Size(49, 13);
            this.TLabelGarantia.TabIndex = 41;
            this.TLabelGarantia.Text = "Garantía";
            // 
            // TLabelMarca
            // 
            this.TLabelMarca.AutoSize = true;
            this.TLabelMarca.Location = new System.Drawing.Point(52, 52);
            this.TLabelMarca.Name = "TLabelMarca";
            this.TLabelMarca.Size = new System.Drawing.Size(41, 13);
            this.TLabelMarca.TabIndex = 35;
            this.TLabelMarca.Text = "Marca*";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AlquilerCoches.Properties.Resources.portada1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(274, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 179);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // TTextBoxMatricula
            // 
            this.TTextBoxMatricula.Location = new System.Drawing.Point(97, 23);
            this.TTextBoxMatricula.Name = "TTextBoxMatricula";
            this.TTextBoxMatricula.Size = new System.Drawing.Size(146, 20);
            this.TTextBoxMatricula.TabIndex = 20;
            this.TTextBoxMatricula.Leave += new System.EventHandler(this.TextBoxMatricula_Leave);
            // 
            // TLabelMatricula
            // 
            this.TLabelMatricula.AutoSize = true;
            this.TLabelMatricula.Location = new System.Drawing.Point(39, 26);
            this.TLabelMatricula.Name = "TLabelMatricula";
            this.TLabelMatricula.Size = new System.Drawing.Size(56, 13);
            this.TLabelMatricula.TabIndex = 19;
            this.TLabelMatricula.Text = "Matrícula*";
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
            this.TLabelTitulo.Size = new System.Drawing.Size(107, 18);
            this.TLabelTitulo.TabIndex = 59;
            this.TLabelTitulo.Text = "Ver y Editar Ventas";
            // 
            // TLabelCategoria
            // 
            this.TLabelCategoria.AutoSize = true;
            this.TLabelCategoria.Location = new System.Drawing.Point(37, 207);
            this.TLabelCategoria.Name = "TLabelCategoria";
            this.TLabelCategoria.Size = new System.Drawing.Size(52, 13);
            this.TLabelCategoria.TabIndex = 52;
            this.TLabelCategoria.Text = "Categoria";
            // 
            // TComboBoxCategoria
            // 
            this.TComboBoxCategoria.FormattingEnabled = true;
            this.TComboBoxCategoria.Items.AddRange(new object[] {
            "Turismos",
            "Familiares",
            "Furgonetas",
            "Especiales"});
            this.TComboBoxCategoria.Location = new System.Drawing.Point(95, 204);
            this.TComboBoxCategoria.Name = "TComboBoxCategoria";
            this.TComboBoxCategoria.Size = new System.Drawing.Size(148, 21);
            this.TComboBoxCategoria.TabIndex = 53;
            // 
            // EditarVentas
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
            this.Name = "EditarVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver y Editar Ventas";
            this.TGroupBoxDatosVehiculo.ResumeLayout(false);
            this.TGroupBoxDatosVehiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox TTextBoxPrecioVenta;
        private System.Windows.Forms.Label TLabelPrecioVenta;
        private System.Windows.Forms.TextBox TTextBoxKm;
        private System.Windows.Forms.Label TLabelKM;
        private System.Windows.Forms.TextBox TTextBoxModelo;
        private System.Windows.Forms.Label TLabelModelo;
        private System.Windows.Forms.TextBox TTextBoxMarca;
        private System.Windows.Forms.Label TLabelGarantia;
        private System.Windows.Forms.Label TLabelMarca;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TTextBoxMatricula;
        private System.Windows.Forms.Label TLabelMatricula;
        private System.Windows.Forms.Button TButtonCancelar;
        private System.Windows.Forms.Button TButtonAceptar;
        private System.Windows.Forms.TextBox TTextBoxMeses;
        private System.Windows.Forms.CheckBox TCheckBoxGarantia;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label TLabelObligatorio;
        private System.Windows.Forms.Button TButtonBorrar;
        private System.Windows.Forms.Label TLabelTitulo;
        private System.Windows.Forms.CheckBox TCheckBoxReservado;
        private System.Windows.Forms.Label TLabelReservado;
        private System.Windows.Forms.ComboBox TComboBoxCategoria;
        private System.Windows.Forms.Label TLabelCategoria;
    }
}