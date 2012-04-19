namespace AlquilerCoches
{
    partial class GestionClientesBuscar
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
            this.TDataGridViewCliente = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TComboBoxCiudades = new System.Windows.Forms.ComboBox();
            this.TComboBoxProvincias = new System.Windows.Forms.ComboBox();
            this.TLabelCiudad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TTextBoxApellidos = new System.Windows.Forms.TextBox();
            this.TTextBoxNombre = new System.Windows.Forms.TextBox();
            this.TTextBoxDNI = new System.Windows.Forms.TextBox();
            this.TLabelApellidos = new System.Windows.Forms.Label();
            this.TLabelNombre = new System.Windows.Forms.Label();
            this.TLabelDNI = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TButtonCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TDataGridViewCliente)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TButtonEliminar
            // 
            this.TButtonEliminar.Location = new System.Drawing.Point(139, 157);
            this.TButtonEliminar.Name = "TButtonEliminar";
            this.TButtonEliminar.Size = new System.Drawing.Size(75, 23);
            this.TButtonEliminar.TabIndex = 35;
            this.TButtonEliminar.Text = "Eliminar";
            this.TButtonEliminar.UseVisualStyleBackColor = true;
            this.TButtonEliminar.Visible = false;
            this.TButtonEliminar.Click += new System.EventHandler(this.TButtonEliminar_Click);
            // 
            // TButtonBuscar
            // 
            this.TButtonBuscar.Location = new System.Drawing.Point(34, 157);
            this.TButtonBuscar.Name = "TButtonBuscar";
            this.TButtonBuscar.Size = new System.Drawing.Size(75, 23);
            this.TButtonBuscar.TabIndex = 34;
            this.TButtonBuscar.Text = "Buscar";
            this.TButtonBuscar.UseVisualStyleBackColor = true;
            this.TButtonBuscar.Click += new System.EventHandler(this.TButtonBuscar_Click);
            // 
            // TDataGridViewCliente
            // 
            this.TDataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TDataGridViewCliente.Location = new System.Drawing.Point(66, 54);
            this.TDataGridViewCliente.Name = "TDataGridViewCliente";
            this.TDataGridViewCliente.Size = new System.Drawing.Size(661, 209);
            this.TDataGridViewCliente.TabIndex = 24;
            this.TDataGridViewCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TDataGridViewCliente_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TComboBoxCiudades);
            this.panel1.Controls.Add(this.TComboBoxProvincias);
            this.panel1.Controls.Add(this.TLabelCiudad);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TButtonEliminar);
            this.panel1.Controls.Add(this.TTextBoxApellidos);
            this.panel1.Controls.Add(this.TButtonBuscar);
            this.panel1.Controls.Add(this.TTextBoxNombre);
            this.panel1.Controls.Add(this.TTextBoxDNI);
            this.panel1.Controls.Add(this.TLabelApellidos);
            this.panel1.Controls.Add(this.TLabelNombre);
            this.panel1.Controls.Add(this.TLabelDNI);
            this.panel1.Location = new System.Drawing.Point(103, 292);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 209);
            this.panel1.TabIndex = 36;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // TComboBoxCiudades
            // 
            this.TComboBoxCiudades.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TComboBoxCiudades.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TComboBoxCiudades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TComboBoxCiudades.FormattingEnabled = true;
            this.TComboBoxCiudades.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TComboBoxCiudades.Location = new System.Drawing.Point(283, 99);
            this.TComboBoxCiudades.Name = "TComboBoxCiudades";
            this.TComboBoxCiudades.Size = new System.Drawing.Size(101, 21);
            this.TComboBoxCiudades.TabIndex = 45;
            this.TComboBoxCiudades.Click += new System.EventHandler(this.TComboBoxCiudades_Click);
            // 
            // TComboBoxProvincias
            // 
            this.TComboBoxProvincias.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TComboBoxProvincias.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TComboBoxProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TComboBoxProvincias.FormattingEnabled = true;
            this.TComboBoxProvincias.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TComboBoxProvincias.Location = new System.Drawing.Point(91, 99);
            this.TComboBoxProvincias.Name = "TComboBoxProvincias";
            this.TComboBoxProvincias.Size = new System.Drawing.Size(101, 21);
            this.TComboBoxProvincias.TabIndex = 42;
            this.TComboBoxProvincias.Click += new System.EventHandler(this.TComboBoxProvincias_Click);
            // 
            // TLabelCiudad
            // 
            this.TLabelCiudad.AutoSize = true;
            this.TLabelCiudad.BackColor = System.Drawing.Color.Transparent;
            this.TLabelCiudad.Location = new System.Drawing.Point(237, 107);
            this.TLabelCiudad.Name = "TLabelCiudad";
            this.TLabelCiudad.Size = new System.Drawing.Size(40, 13);
            this.TLabelCiudad.TabIndex = 44;
            this.TLabelCiudad.Text = "Ciudad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(28, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Pronvincia";
            // 
            // TTextBoxApellidos
            // 
            this.TTextBoxApellidos.Location = new System.Drawing.Point(284, 61);
            this.TTextBoxApellidos.Name = "TTextBoxApellidos";
            this.TTextBoxApellidos.Size = new System.Drawing.Size(100, 20);
            this.TTextBoxApellidos.TabIndex = 40;
            this.TTextBoxApellidos.Leave += new System.EventHandler(this.TTextBoxApellidos_Leave);
            // 
            // TTextBoxNombre
            // 
            this.TTextBoxNombre.Location = new System.Drawing.Point(91, 61);
            this.TTextBoxNombre.Name = "TTextBoxNombre";
            this.TTextBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.TTextBoxNombre.TabIndex = 39;
            this.TTextBoxNombre.Leave += new System.EventHandler(this.TTextBoxNombre_Leave);
            // 
            // TTextBoxDNI
            // 
            this.TTextBoxDNI.Location = new System.Drawing.Point(91, 19);
            this.TTextBoxDNI.Name = "TTextBoxDNI";
            this.TTextBoxDNI.Size = new System.Drawing.Size(100, 20);
            this.TTextBoxDNI.TabIndex = 38;
            this.TTextBoxDNI.Leave += new System.EventHandler(this.TTextBoxDNI_Leave);
            // 
            // TLabelApellidos
            // 
            this.TLabelApellidos.AutoSize = true;
            this.TLabelApellidos.Location = new System.Drawing.Point(229, 69);
            this.TLabelApellidos.Name = "TLabelApellidos";
            this.TLabelApellidos.Size = new System.Drawing.Size(49, 13);
            this.TLabelApellidos.TabIndex = 36;
            this.TLabelApellidos.Text = "Apellidos";
            // 
            // TLabelNombre
            // 
            this.TLabelNombre.AutoSize = true;
            this.TLabelNombre.Location = new System.Drawing.Point(40, 69);
            this.TLabelNombre.Name = "TLabelNombre";
            this.TLabelNombre.Size = new System.Drawing.Size(44, 13);
            this.TLabelNombre.TabIndex = 35;
            this.TLabelNombre.Text = "Nombre";
            // 
            // TLabelDNI
            // 
            this.TLabelDNI.AutoSize = true;
            this.TLabelDNI.BackColor = System.Drawing.Color.Transparent;
            this.TLabelDNI.Location = new System.Drawing.Point(58, 27);
            this.TLabelDNI.Name = "TLabelDNI";
            this.TLabelDNI.Size = new System.Drawing.Size(26, 13);
            this.TLabelDNI.TabIndex = 34;
            this.TLabelDNI.Text = "DNI";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TButtonCerrar
            // 
            this.TButtonCerrar.Location = new System.Drawing.Point(41, 556);
            this.TButtonCerrar.Name = "TButtonCerrar";
            this.TButtonCerrar.Size = new System.Drawing.Size(75, 23);
            this.TButtonCerrar.TabIndex = 37;
            this.TButtonCerrar.Text = "Cerrar";
            this.TButtonCerrar.UseVisualStyleBackColor = true;
            this.TButtonCerrar.Click += new System.EventHandler(this.TButtonCerrar_Click);
            // 
            // GestionClientesBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AlquilerCoches.Properties.Resources.rentacar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 608);
            this.Controls.Add(this.TButtonCerrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TDataGridViewCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(894, 608);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(894, 608);
            this.Name = "GestionClientesBuscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionClientesBuscar";
            this.Activated += new System.EventHandler(this.GestionClientesBuscar_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.TDataGridViewCliente)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TButtonEliminar;
        private System.Windows.Forms.Button TButtonBuscar;
        private System.Windows.Forms.DataGridView TDataGridViewCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TTextBoxApellidos;
        private System.Windows.Forms.TextBox TTextBoxNombre;
        private System.Windows.Forms.TextBox TTextBoxDNI;
        private System.Windows.Forms.Label TLabelApellidos;
        private System.Windows.Forms.Label TLabelNombre;
        private System.Windows.Forms.Label TLabelDNI;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button TButtonCerrar;
        private System.Windows.Forms.ComboBox TComboBoxCiudades;
        private System.Windows.Forms.ComboBox TComboBoxProvincias;
        private System.Windows.Forms.Label TLabelCiudad;
        private System.Windows.Forms.Label label1;
    }
}