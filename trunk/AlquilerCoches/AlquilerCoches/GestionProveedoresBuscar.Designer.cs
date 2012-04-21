namespace AlquilerCoches
{
    partial class GestionProveedoresBuscar
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
            this.TTextBoxMarca = new System.Windows.Forms.TextBox();
            this.TTextBoxCIF = new System.Windows.Forms.TextBox();
            this.TLabelProvincia = new System.Windows.Forms.Label();
            this.TLabelMarca = new System.Windows.Forms.Label();
            this.TLabelCIF = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TLabelCiudad = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TButtonEliminar = new System.Windows.Forms.Button();
            this.TButtonBuscar = new System.Windows.Forms.Button();
            this.TTextBoxCPostal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TComboBoxCiudades = new System.Windows.Forms.ComboBox();
            this.TComboBoxProvincias = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TLabelTitulo = new System.Windows.Forms.Label();
            this.TButtonCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TTextBoxMarca
            // 
            this.TTextBoxMarca.Location = new System.Drawing.Point(99, 58);
            this.TTextBoxMarca.Name = "TTextBoxMarca";
            this.TTextBoxMarca.Size = new System.Drawing.Size(100, 20);
            this.TTextBoxMarca.TabIndex = 43;
            // 
            // TTextBoxCIF
            // 
            this.TTextBoxCIF.Location = new System.Drawing.Point(99, 19);
            this.TTextBoxCIF.Name = "TTextBoxCIF";
            this.TTextBoxCIF.Size = new System.Drawing.Size(100, 20);
            this.TTextBoxCIF.TabIndex = 42;
            // 
            // TLabelProvincia
            // 
            this.TLabelProvincia.AutoSize = true;
            this.TLabelProvincia.Location = new System.Drawing.Point(227, 22);
            this.TLabelProvincia.Name = "TLabelProvincia";
            this.TLabelProvincia.Size = new System.Drawing.Size(51, 13);
            this.TLabelProvincia.TabIndex = 40;
            this.TLabelProvincia.Text = "Provincia";
            // 
            // TLabelMarca
            // 
            this.TLabelMarca.AutoSize = true;
            this.TLabelMarca.Location = new System.Drawing.Point(41, 65);
            this.TLabelMarca.Name = "TLabelMarca";
            this.TLabelMarca.Size = new System.Drawing.Size(37, 13);
            this.TLabelMarca.TabIndex = 39;
            this.TLabelMarca.Text = "Marca";
            // 
            // TLabelCIF
            // 
            this.TLabelCIF.AutoSize = true;
            this.TLabelCIF.BackColor = System.Drawing.Color.Transparent;
            this.TLabelCIF.Location = new System.Drawing.Point(41, 26);
            this.TLabelCIF.Name = "TLabelCIF";
            this.TLabelCIF.Size = new System.Drawing.Size(23, 13);
            this.TLabelCIF.TabIndex = 38;
            this.TLabelCIF.Text = "CIF";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(722, 209);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TLabelCiudad
            // 
            this.TLabelCiudad.AutoSize = true;
            this.TLabelCiudad.Location = new System.Drawing.Point(238, 62);
            this.TLabelCiudad.Name = "TLabelCiudad";
            this.TLabelCiudad.Size = new System.Drawing.Size(40, 13);
            this.TLabelCiudad.TabIndex = 48;
            this.TLabelCiudad.Text = "Ciudad";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.TButtonEliminar);
            this.groupBox1.Controls.Add(this.TButtonBuscar);
            this.groupBox1.Controls.Add(this.TTextBoxCPostal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TComboBoxCiudades);
            this.groupBox1.Controls.Add(this.TComboBoxProvincias);
            this.groupBox1.Controls.Add(this.TLabelCiudad);
            this.groupBox1.Controls.Add(this.TTextBoxMarca);
            this.groupBox1.Controls.Add(this.TTextBoxCIF);
            this.groupBox1.Controls.Add(this.TLabelProvincia);
            this.groupBox1.Controls.Add(this.TLabelMarca);
            this.groupBox1.Controls.Add(this.TLabelCIF);
            this.groupBox1.Location = new System.Drawing.Point(36, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 209);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            // 
            // TButtonEliminar
            // 
            this.TButtonEliminar.Image = global::AlquilerCoches.Properties.Resources.Delete_icon;
            this.TButtonEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TButtonEliminar.Location = new System.Drawing.Point(130, 154);
            this.TButtonEliminar.Name = "TButtonEliminar";
            this.TButtonEliminar.Size = new System.Drawing.Size(77, 32);
            this.TButtonEliminar.TabIndex = 58;
            this.TButtonEliminar.Text = "Eliminar";
            this.TButtonEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TButtonEliminar.UseVisualStyleBackColor = true;
            this.TButtonEliminar.Visible = false;
            this.TButtonEliminar.Click += new System.EventHandler(this.TButtonEliminar_Click);
            // 
            // TButtonBuscar
            // 
            this.TButtonBuscar.Image = global::AlquilerCoches.Properties.Resources.Search_icon;
            this.TButtonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TButtonBuscar.Location = new System.Drawing.Point(25, 154);
            this.TButtonBuscar.Name = "TButtonBuscar";
            this.TButtonBuscar.Size = new System.Drawing.Size(76, 32);
            this.TButtonBuscar.TabIndex = 57;
            this.TButtonBuscar.Text = "Buscar";
            this.TButtonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TButtonBuscar.UseVisualStyleBackColor = true;
            this.TButtonBuscar.Click += new System.EventHandler(this.TButtonBuscar_Click);
            // 
            // TTextBoxCPostal
            // 
            this.TTextBoxCPostal.Location = new System.Drawing.Point(99, 93);
            this.TTextBoxCPostal.Name = "TTextBoxCPostal";
            this.TTextBoxCPostal.Size = new System.Drawing.Size(100, 20);
            this.TTextBoxCPostal.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Codigo Postal";
            // 
            // TComboBoxCiudades
            // 
            this.TComboBoxCiudades.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TComboBoxCiudades.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TComboBoxCiudades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TComboBoxCiudades.FormattingEnabled = true;
            this.TComboBoxCiudades.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TComboBoxCiudades.Location = new System.Drawing.Point(293, 54);
            this.TComboBoxCiudades.Name = "TComboBoxCiudades";
            this.TComboBoxCiudades.Size = new System.Drawing.Size(101, 21);
            this.TComboBoxCiudades.TabIndex = 51;
            this.TComboBoxCiudades.Click += new System.EventHandler(this.TComboBoxCiudades_Click_1);
            // 
            // TComboBoxProvincias
            // 
            this.TComboBoxProvincias.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TComboBoxProvincias.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TComboBoxProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TComboBoxProvincias.FormattingEnabled = true;
            this.TComboBoxProvincias.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TComboBoxProvincias.Location = new System.Drawing.Point(293, 19);
            this.TComboBoxProvincias.Name = "TComboBoxProvincias";
            this.TComboBoxProvincias.Size = new System.Drawing.Size(101, 21);
            this.TComboBoxProvincias.TabIndex = 50;
            this.TComboBoxProvincias.Click += new System.EventHandler(this.TComboBoxProvincias_Click);
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
            this.TLabelTitulo.Location = new System.Drawing.Point(4, -1);
            this.TLabelTitulo.Name = "TLabelTitulo";
            this.TLabelTitulo.Size = new System.Drawing.Size(133, 18);
            this.TLabelTitulo.TabIndex = 56;
            this.TLabelTitulo.Text = "Buscador de Proveedores";
            // 
            // TButtonCerrar
            // 
            this.TButtonCerrar.Image = global::AlquilerCoches.Properties.Resources.Close_icon;
            this.TButtonCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TButtonCerrar.Location = new System.Drawing.Point(50, 551);
            this.TButtonCerrar.Name = "TButtonCerrar";
            this.TButtonCerrar.Size = new System.Drawing.Size(76, 32);
            this.TButtonCerrar.TabIndex = 59;
            this.TButtonCerrar.Text = "Cerrar";
            this.TButtonCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TButtonCerrar.UseVisualStyleBackColor = true;
            this.TButtonCerrar.Click += new System.EventHandler(this.TButtonCerrar_Click);
            // 
            // GestionProveedoresBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AlquilerCoches.Properties.Resources.rentacar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 608);
            this.Controls.Add(this.TButtonCerrar);
            this.Controls.Add(this.TLabelTitulo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GestionProveedoresBuscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionProveedoresBuscar";
            this.Activated += new System.EventHandler(this.GestionProveedoresBuscar_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TTextBoxMarca;
        private System.Windows.Forms.TextBox TTextBoxCIF;
        private System.Windows.Forms.Label TLabelProvincia;
        private System.Windows.Forms.Label TLabelMarca;
        private System.Windows.Forms.Label TLabelCIF;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label TLabelCiudad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox TComboBoxProvincias;
        private System.Windows.Forms.ComboBox TComboBoxCiudades;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox TTextBoxCPostal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TLabelTitulo;
        private System.Windows.Forms.Button TButtonEliminar;
        private System.Windows.Forms.Button TButtonBuscar;
        private System.Windows.Forms.Button TButtonCerrar;
    }
}