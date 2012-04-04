namespace AlquilerCoches
{
	partial class GestionPersonalBuscar
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
            this.TDataGridViewPersonal = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TLabelDNI = new System.Windows.Forms.Label();
            this.TLabelNombre = new System.Windows.Forms.Label();
            this.TLabelApellidos = new System.Windows.Forms.Label();
            this.TLabelPuestoAc = new System.Windows.Forms.Label();
            this.TTextBoxDNI = new System.Windows.Forms.TextBox();
            this.TTextBoxNombre = new System.Windows.Forms.TextBox();
            this.TTextBoxApellidos = new System.Windows.Forms.TextBox();
            this.TTextBoxPuestoAc = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TComboBoxCiudades = new System.Windows.Forms.ComboBox();
            this.TComboBoxProvincias = new System.Windows.Forms.ComboBox();
            this.TLabelCiudad = new System.Windows.Forms.Label();
            this.TLabelProvincia = new System.Windows.Forms.Label();
            this.TButtonCerrar = new System.Windows.Forms.Button();
            this.bBDDDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TDataGridViewPersonal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bBDDDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TButtonEliminar
            // 
            this.TButtonEliminar.Location = new System.Drawing.Point(136, 166);
            this.TButtonEliminar.Name = "TButtonEliminar";
            this.TButtonEliminar.Size = new System.Drawing.Size(75, 23);
            this.TButtonEliminar.TabIndex = 23;
            this.TButtonEliminar.Text = "Eliminar";
            this.TButtonEliminar.UseVisualStyleBackColor = true;
            this.TButtonEliminar.Visible = false;
            // 
            // TButtonBuscar
            // 
            this.TButtonBuscar.Location = new System.Drawing.Point(31, 166);
            this.TButtonBuscar.Name = "TButtonBuscar";
            this.TButtonBuscar.Size = new System.Drawing.Size(75, 23);
            this.TButtonBuscar.TabIndex = 6;
            this.TButtonBuscar.Text = "Buscar";
            this.TButtonBuscar.UseVisualStyleBackColor = true;
            this.TButtonBuscar.Click += new System.EventHandler(this.TButtonBuscar_Click);
            // 
            // TDataGridViewPersonal
            // 
            this.TDataGridViewPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TDataGridViewPersonal.Location = new System.Drawing.Point(94, 35);
            this.TDataGridViewPersonal.Name = "TDataGridViewPersonal";
            this.TDataGridViewPersonal.Size = new System.Drawing.Size(719, 209);
            this.TDataGridViewPersonal.TabIndex = 12;
            this.TDataGridViewPersonal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TDataGridViewPersonal_CellContentClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TLabelDNI
            // 
            this.TLabelDNI.AutoSize = true;
            this.TLabelDNI.BackColor = System.Drawing.Color.Transparent;
            this.TLabelDNI.Location = new System.Drawing.Point(47, 30);
            this.TLabelDNI.Name = "TLabelDNI";
            this.TLabelDNI.Size = new System.Drawing.Size(26, 13);
            this.TLabelDNI.TabIndex = 22;
            this.TLabelDNI.Text = "DNI";
            // 
            // TLabelNombre
            // 
            this.TLabelNombre.AutoSize = true;
            this.TLabelNombre.BackColor = System.Drawing.Color.Transparent;
            this.TLabelNombre.Location = new System.Drawing.Point(29, 69);
            this.TLabelNombre.Name = "TLabelNombre";
            this.TLabelNombre.Size = new System.Drawing.Size(44, 13);
            this.TLabelNombre.TabIndex = 23;
            this.TLabelNombre.Text = "Nombre";
            // 
            // TLabelApellidos
            // 
            this.TLabelApellidos.AutoSize = true;
            this.TLabelApellidos.BackColor = System.Drawing.Color.Transparent;
            this.TLabelApellidos.Location = new System.Drawing.Point(246, 30);
            this.TLabelApellidos.Name = "TLabelApellidos";
            this.TLabelApellidos.Size = new System.Drawing.Size(49, 13);
            this.TLabelApellidos.TabIndex = 24;
            this.TLabelApellidos.Text = "Apellidos";
            // 
            // TLabelPuestoAc
            // 
            this.TLabelPuestoAc.AutoSize = true;
            this.TLabelPuestoAc.BackColor = System.Drawing.Color.Transparent;
            this.TLabelPuestoAc.Location = new System.Drawing.Point(236, 69);
            this.TLabelPuestoAc.Name = "TLabelPuestoAc";
            this.TLabelPuestoAc.Size = new System.Drawing.Size(59, 13);
            this.TLabelPuestoAc.TabIndex = 25;
            this.TLabelPuestoAc.Text = "Puesto Ac.";
            // 
            // TTextBoxDNI
            // 
            this.TTextBoxDNI.Location = new System.Drawing.Point(80, 22);
            this.TTextBoxDNI.Name = "TTextBoxDNI";
            this.TTextBoxDNI.Size = new System.Drawing.Size(100, 20);
            this.TTextBoxDNI.TabIndex = 0;
            // 
            // TTextBoxNombre
            // 
            this.TTextBoxNombre.Location = new System.Drawing.Point(80, 61);
            this.TTextBoxNombre.Name = "TTextBoxNombre";
            this.TTextBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.TTextBoxNombre.TabIndex = 2;
            // 
            // TTextBoxApellidos
            // 
            this.TTextBoxApellidos.Location = new System.Drawing.Point(301, 22);
            this.TTextBoxApellidos.Name = "TTextBoxApellidos";
            this.TTextBoxApellidos.Size = new System.Drawing.Size(100, 20);
            this.TTextBoxApellidos.TabIndex = 1;
            // 
            // TTextBoxPuestoAc
            // 
            this.TTextBoxPuestoAc.Location = new System.Drawing.Point(301, 61);
            this.TTextBoxPuestoAc.Name = "TTextBoxPuestoAc";
            this.TTextBoxPuestoAc.Size = new System.Drawing.Size(100, 20);
            this.TTextBoxPuestoAc.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TComboBoxCiudades);
            this.panel1.Controls.Add(this.TComboBoxProvincias);
            this.panel1.Controls.Add(this.TLabelCiudad);
            this.panel1.Controls.Add(this.TLabelProvincia);
            this.panel1.Controls.Add(this.TTextBoxPuestoAc);
            this.panel1.Controls.Add(this.TButtonEliminar);
            this.panel1.Controls.Add(this.TButtonBuscar);
            this.panel1.Controls.Add(this.TTextBoxApellidos);
            this.panel1.Controls.Add(this.TTextBoxNombre);
            this.panel1.Controls.Add(this.TTextBoxDNI);
            this.panel1.Controls.Add(this.TLabelPuestoAc);
            this.panel1.Controls.Add(this.TLabelApellidos);
            this.panel1.Controls.Add(this.TLabelNombre);
            this.panel1.Controls.Add(this.TLabelDNI);
            this.panel1.Location = new System.Drawing.Point(94, 267);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 216);
            this.panel1.TabIndex = 24;
            // 
            // TComboBoxCiudades
            // 
            this.TComboBoxCiudades.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TComboBoxCiudades.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TComboBoxCiudades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TComboBoxCiudades.FormattingEnabled = true;
            this.TComboBoxCiudades.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TComboBoxCiudades.Location = new System.Drawing.Point(300, 99);
            this.TComboBoxCiudades.Name = "TComboBoxCiudades";
            this.TComboBoxCiudades.Size = new System.Drawing.Size(101, 21);
            this.TComboBoxCiudades.TabIndex = 32;
            this.TComboBoxCiudades.Click += new System.EventHandler(this.TComboBoxCiudades_Click);
            // 
            // TComboBoxProvincias
            // 
            this.TComboBoxProvincias.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TComboBoxProvincias.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TComboBoxProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TComboBoxProvincias.FormattingEnabled = true;
            this.TComboBoxProvincias.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TComboBoxProvincias.Location = new System.Drawing.Point(79, 99);
            this.TComboBoxProvincias.Name = "TComboBoxProvincias";
            this.TComboBoxProvincias.Size = new System.Drawing.Size(101, 21);
            this.TComboBoxProvincias.TabIndex = 4;
            this.TComboBoxProvincias.Click += new System.EventHandler(this.TComboBoxProvincias_Click);
            // 
            // TLabelCiudad
            // 
            this.TLabelCiudad.AutoSize = true;
            this.TLabelCiudad.BackColor = System.Drawing.Color.Transparent;
            this.TLabelCiudad.Location = new System.Drawing.Point(255, 107);
            this.TLabelCiudad.Name = "TLabelCiudad";
            this.TLabelCiudad.Size = new System.Drawing.Size(40, 13);
            this.TLabelCiudad.TabIndex = 31;
            this.TLabelCiudad.Text = "Ciudad";
            // 
            // TLabelProvincia
            // 
            this.TLabelProvincia.AutoSize = true;
            this.TLabelProvincia.BackColor = System.Drawing.Color.Transparent;
            this.TLabelProvincia.Location = new System.Drawing.Point(16, 107);
            this.TLabelProvincia.Name = "TLabelProvincia";
            this.TLabelProvincia.Size = new System.Drawing.Size(57, 13);
            this.TLabelProvincia.TabIndex = 30;
            this.TLabelProvincia.Text = "Pronvincia";
            // 
            // TButtonCerrar
            // 
            this.TButtonCerrar.Location = new System.Drawing.Point(57, 547);
            this.TButtonCerrar.Name = "TButtonCerrar";
            this.TButtonCerrar.Size = new System.Drawing.Size(75, 23);
            this.TButtonCerrar.TabIndex = 30;
            this.TButtonCerrar.Text = "Cerrar";
            this.TButtonCerrar.UseVisualStyleBackColor = true;
            this.TButtonCerrar.Click += new System.EventHandler(this.TButtonCerrar_Click);
            // 
            // GestionPersonalBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AlquilerCoches.Properties.Resources.rentacar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 608);
            this.Controls.Add(this.TButtonCerrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TDataGridViewPersonal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(894, 608);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(894, 608);
            this.Name = "GestionPersonalBuscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionPersonalBuscar";
            ((System.ComponentModel.ISupportInitialize)(this.TDataGridViewPersonal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bBDDDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.Button TButtonEliminar;
        private System.Windows.Forms.Button TButtonBuscar;
        private System.Windows.Forms.DataGridView TDataGridViewPersonal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TTextBoxPuestoAc;
        private System.Windows.Forms.TextBox TTextBoxApellidos;
        private System.Windows.Forms.TextBox TTextBoxNombre;
        private System.Windows.Forms.TextBox TTextBoxDNI;
        private System.Windows.Forms.Label TLabelPuestoAc;
        private System.Windows.Forms.Label TLabelApellidos;
        private System.Windows.Forms.Label TLabelNombre;
        private System.Windows.Forms.Label TLabelDNI;
        private System.Windows.Forms.Button TButtonCerrar;
       // private BBDDDataSet bBDDDataSet;
        private System.Windows.Forms.BindingSource bBDDDataSetBindingSource;
        private System.Windows.Forms.Label TLabelCiudad;
        private System.Windows.Forms.Label TLabelProvincia;
        private System.Windows.Forms.ComboBox TComboBoxProvincias;
        private System.Windows.Forms.ComboBox TComboBoxCiudades;
	}
}