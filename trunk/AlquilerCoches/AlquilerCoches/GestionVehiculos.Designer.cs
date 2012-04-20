namespace AlquilerCoches
{
    partial class GestionVehiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionVehiculos));
            this.TGroupBoxDatosVehiculo = new System.Windows.Forms.GroupBox();
            this.TComboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.TTextBoxGarantia = new System.Windows.Forms.TextBox();
            this.TLabelGarantia = new System.Windows.Forms.Label();
            this.TTextBoxKM = new System.Windows.Forms.TextBox();
            this.TLabelKM = new System.Windows.Forms.Label();
            this.TTextBoxModelo = new System.Windows.Forms.TextBox();
            this.TLabelModelo = new System.Windows.Forms.Label();
            this.TTextBoxMarca = new System.Windows.Forms.TextBox();
            this.TLabelMarca = new System.Windows.Forms.Label();
            this.TRadioButtonRevision = new System.Windows.Forms.RadioButton();
            this.TLabelEstado = new System.Windows.Forms.Label();
            this.TRadioButtonEstado = new System.Windows.Forms.RadioButton();
            this.TPictureBoxMatricula = new System.Windows.Forms.PictureBox();
            this.TLabelCategoria = new System.Windows.Forms.Label();
            this.TTextBoxPrecioVenta = new System.Windows.Forms.TextBox();
            this.TLabelPrecioVenta = new System.Windows.Forms.Label();
            this.TTextBoxPrecioCompra = new System.Windows.Forms.TextBox();
            this.TLabelPrecioCompra = new System.Windows.Forms.Label();
            this.TTextBoxMatricula = new System.Windows.Forms.TextBox();
            this.TLabelMatricula = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TButtonBuscar = new System.Windows.Forms.Button();
            this.TButtonCerrar = new System.Windows.Forms.Button();
            this.TGroupBoxSeleccion = new System.Windows.Forms.GroupBox();
            this.TListBoxMatriculas = new System.Windows.Forms.ListBox();
            this.TListBoxModelos = new System.Windows.Forms.ListBox();
            this.TListBoxMarcas = new System.Windows.Forms.ListBox();
            this.TLabelMatriculas = new System.Windows.Forms.Label();
            this.TLabelModelos = new System.Windows.Forms.Label();
            this.TLabelMarcas = new System.Windows.Forms.Label();
            this.TGroupBoxAccion = new System.Windows.Forms.GroupBox();
            this.TButtonBorrar = new System.Windows.Forms.Button();
            this.TButtonAnyadir = new System.Windows.Forms.Button();
            this.TButtonEditar = new System.Windows.Forms.Button();
            this.TButtonCancelar = new System.Windows.Forms.Button();
            this.TButtonOK = new System.Windows.Forms.Button();
            this.TGroupBoxDatosVehiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TPictureBoxMatricula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.TGroupBoxSeleccion.SuspendLayout();
            this.TGroupBoxAccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // TGroupBoxDatosVehiculo
            // 
            this.TGroupBoxDatosVehiculo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TGroupBoxDatosVehiculo.BackColor = System.Drawing.Color.Transparent;
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TComboBoxCategoria);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TTextBoxGarantia);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TLabelGarantia);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TTextBoxKM);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TLabelKM);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TTextBoxModelo);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TLabelModelo);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TTextBoxMarca);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TLabelMarca);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TRadioButtonRevision);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TLabelEstado);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TRadioButtonEstado);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TPictureBoxMatricula);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TLabelCategoria);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TTextBoxPrecioVenta);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TLabelPrecioVenta);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TTextBoxPrecioCompra);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TLabelPrecioCompra);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TTextBoxMatricula);
            this.TGroupBoxDatosVehiculo.Controls.Add(this.TLabelMatricula);
            this.TGroupBoxDatosVehiculo.Location = new System.Drawing.Point(238, 177);
            this.TGroupBoxDatosVehiculo.Name = "TGroupBoxDatosVehiculo";
            this.TGroupBoxDatosVehiculo.Size = new System.Drawing.Size(595, 344);
            this.TGroupBoxDatosVehiculo.TabIndex = 19;
            this.TGroupBoxDatosVehiculo.TabStop = false;
            this.TGroupBoxDatosVehiculo.Text = "3 DatosVehiculo";
            // 
            // TComboBoxCategoria
            // 
            this.TComboBoxCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TComboBoxCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TComboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TComboBoxCategoria.FormattingEnabled = true;
            this.TComboBoxCategoria.Location = new System.Drawing.Point(128, 165);
            this.TComboBoxCategoria.Name = "TComboBoxCategoria";
            this.TComboBoxCategoria.Size = new System.Drawing.Size(261, 21);
            this.TComboBoxCategoria.TabIndex = 6;
            // 
            // TTextBoxGarantia
            // 
            this.TTextBoxGarantia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TTextBoxGarantia.Location = new System.Drawing.Point(128, 216);
            this.TTextBoxGarantia.Name = "TTextBoxGarantia";
            this.TTextBoxGarantia.Size = new System.Drawing.Size(261, 20);
            this.TTextBoxGarantia.TabIndex = 8;
            this.TTextBoxGarantia.Leave += new System.EventHandler(this.TTextBoxGarantia_TextChanged);
            // 
            // TLabelGarantia
            // 
            this.TLabelGarantia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TLabelGarantia.AutoSize = true;
            this.TLabelGarantia.Location = new System.Drawing.Point(73, 219);
            this.TLabelGarantia.Name = "TLabelGarantia";
            this.TLabelGarantia.Size = new System.Drawing.Size(47, 13);
            this.TLabelGarantia.TabIndex = 41;
            this.TLabelGarantia.Text = "Garantia";
            // 
            // TTextBoxKM
            // 
            this.TTextBoxKM.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TTextBoxKM.Location = new System.Drawing.Point(128, 190);
            this.TTextBoxKM.Name = "TTextBoxKM";
            this.TTextBoxKM.Size = new System.Drawing.Size(261, 20);
            this.TTextBoxKM.TabIndex = 7;
            this.TTextBoxKM.Leave += new System.EventHandler(this.TTextBoxKM_TextChanged);
            // 
            // TLabelKM
            // 
            this.TLabelKM.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TLabelKM.AutoSize = true;
            this.TLabelKM.Location = new System.Drawing.Point(97, 197);
            this.TLabelKM.Name = "TLabelKM";
            this.TLabelKM.Size = new System.Drawing.Size(23, 13);
            this.TLabelKM.TabIndex = 39;
            this.TLabelKM.Text = "KM";
            // 
            // TTextBoxModelo
            // 
            this.TTextBoxModelo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TTextBoxModelo.Location = new System.Drawing.Point(128, 88);
            this.TTextBoxModelo.Name = "TTextBoxModelo";
            this.TTextBoxModelo.Size = new System.Drawing.Size(261, 20);
            this.TTextBoxModelo.TabIndex = 3;
            this.TTextBoxModelo.Leave += new System.EventHandler(this.TTextBoxModelo_TextChanged);
            // 
            // TLabelModelo
            // 
            this.TLabelModelo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TLabelModelo.AutoSize = true;
            this.TLabelModelo.Location = new System.Drawing.Point(78, 93);
            this.TLabelModelo.Name = "TLabelModelo";
            this.TLabelModelo.Size = new System.Drawing.Size(42, 13);
            this.TLabelModelo.TabIndex = 37;
            this.TLabelModelo.Text = "Modelo";
            // 
            // TTextBoxMarca
            // 
            this.TTextBoxMarca.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TTextBoxMarca.Location = new System.Drawing.Point(128, 60);
            this.TTextBoxMarca.Name = "TTextBoxMarca";
            this.TTextBoxMarca.Size = new System.Drawing.Size(261, 20);
            this.TTextBoxMarca.TabIndex = 2;
            this.TTextBoxMarca.Leave += new System.EventHandler(this.TTextBoxMarca_TextChanged);
            // 
            // TLabelMarca
            // 
            this.TLabelMarca.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TLabelMarca.AutoSize = true;
            this.TLabelMarca.Location = new System.Drawing.Point(83, 67);
            this.TLabelMarca.Name = "TLabelMarca";
            this.TLabelMarca.Size = new System.Drawing.Size(37, 13);
            this.TLabelMarca.TabIndex = 35;
            this.TLabelMarca.Text = "Marca";
            // 
            // TRadioButtonRevision
            // 
            this.TRadioButtonRevision.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TRadioButtonRevision.AutoSize = true;
            this.TRadioButtonRevision.Location = new System.Drawing.Point(208, 240);
            this.TRadioButtonRevision.Name = "TRadioButtonRevision";
            this.TRadioButtonRevision.Size = new System.Drawing.Size(66, 17);
            this.TRadioButtonRevision.TabIndex = 10;
            this.TRadioButtonRevision.TabStop = true;
            this.TRadioButtonRevision.Text = "Revision";
            this.TRadioButtonRevision.UseVisualStyleBackColor = true;
            // 
            // TLabelEstado
            // 
            this.TLabelEstado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TLabelEstado.AutoSize = true;
            this.TLabelEstado.Location = new System.Drawing.Point(80, 242);
            this.TLabelEstado.Name = "TLabelEstado";
            this.TLabelEstado.Size = new System.Drawing.Size(40, 13);
            this.TLabelEstado.TabIndex = 33;
            this.TLabelEstado.Text = "Estado";
            // 
            // TRadioButtonEstado
            // 
            this.TRadioButtonEstado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TRadioButtonEstado.AutoSize = true;
            this.TRadioButtonEstado.Location = new System.Drawing.Point(128, 240);
            this.TRadioButtonEstado.Name = "TRadioButtonEstado";
            this.TRadioButtonEstado.Size = new System.Drawing.Size(74, 17);
            this.TRadioButtonEstado.TabIndex = 9;
            this.TRadioButtonEstado.TabStop = true;
            this.TRadioButtonEstado.Text = "Disponible";
            this.TRadioButtonEstado.UseVisualStyleBackColor = true;
            // 
            // TPictureBoxMatricula
            // 
            this.TPictureBoxMatricula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TPictureBoxMatricula.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TPictureBoxMatricula.BackgroundImage")));
            this.TPictureBoxMatricula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TPictureBoxMatricula.Location = new System.Drawing.Point(395, 34);
            this.TPictureBoxMatricula.Name = "TPictureBoxMatricula";
            this.TPictureBoxMatricula.Size = new System.Drawing.Size(197, 231);
            this.TPictureBoxMatricula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TPictureBoxMatricula.TabIndex = 31;
            this.TPictureBoxMatricula.TabStop = false;
            // 
            // TLabelCategoria
            // 
            this.TLabelCategoria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TLabelCategoria.AutoSize = true;
            this.TLabelCategoria.Location = new System.Drawing.Point(68, 168);
            this.TLabelCategoria.Name = "TLabelCategoria";
            this.TLabelCategoria.Size = new System.Drawing.Size(52, 13);
            this.TLabelCategoria.TabIndex = 27;
            this.TLabelCategoria.Text = "Categoria";
            // 
            // TTextBoxPrecioVenta
            // 
            this.TTextBoxPrecioVenta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TTextBoxPrecioVenta.Location = new System.Drawing.Point(128, 138);
            this.TTextBoxPrecioVenta.Name = "TTextBoxPrecioVenta";
            this.TTextBoxPrecioVenta.Size = new System.Drawing.Size(261, 20);
            this.TTextBoxPrecioVenta.TabIndex = 5;
            this.TTextBoxPrecioVenta.Leave += new System.EventHandler(this.TTextBoxPrecioVenta_TextChanged);
            // 
            // TLabelPrecioVenta
            // 
            this.TLabelPrecioVenta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TLabelPrecioVenta.AutoSize = true;
            this.TLabelPrecioVenta.Location = new System.Drawing.Point(55, 145);
            this.TLabelPrecioVenta.Name = "TLabelPrecioVenta";
            this.TLabelPrecioVenta.Size = new System.Drawing.Size(65, 13);
            this.TLabelPrecioVenta.TabIndex = 25;
            this.TLabelPrecioVenta.Text = "PrecioVenta";
            // 
            // TTextBoxPrecioCompra
            // 
            this.TTextBoxPrecioCompra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TTextBoxPrecioCompra.Location = new System.Drawing.Point(128, 113);
            this.TTextBoxPrecioCompra.Name = "TTextBoxPrecioCompra";
            this.TTextBoxPrecioCompra.Size = new System.Drawing.Size(261, 20);
            this.TTextBoxPrecioCompra.TabIndex = 4;
            this.TTextBoxPrecioCompra.Leave += new System.EventHandler(this.TTextBoxPrecioCompra_TextChanged);
            // 
            // TLabelPrecioCompra
            // 
            this.TLabelPrecioCompra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TLabelPrecioCompra.AutoSize = true;
            this.TLabelPrecioCompra.Location = new System.Drawing.Point(47, 120);
            this.TLabelPrecioCompra.Name = "TLabelPrecioCompra";
            this.TLabelPrecioCompra.Size = new System.Drawing.Size(73, 13);
            this.TLabelPrecioCompra.TabIndex = 23;
            this.TLabelPrecioCompra.Text = "PrecioCompra";
            // 
            // TTextBoxMatricula
            // 
            this.TTextBoxMatricula.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TTextBoxMatricula.Location = new System.Drawing.Point(128, 34);
            this.TTextBoxMatricula.Name = "TTextBoxMatricula";
            this.TTextBoxMatricula.Size = new System.Drawing.Size(261, 20);
            this.TTextBoxMatricula.TabIndex = 1;
            this.TTextBoxMatricula.Leave += new System.EventHandler(this.TTextBoxMatricula_TextChanged);
            // 
            // TLabelMatricula
            // 
            this.TLabelMatricula.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TLabelMatricula.AutoSize = true;
            this.TLabelMatricula.Location = new System.Drawing.Point(70, 41);
            this.TLabelMatricula.Name = "TLabelMatricula";
            this.TLabelMatricula.Size = new System.Drawing.Size(50, 13);
            this.TLabelMatricula.TabIndex = 19;
            this.TLabelMatricula.Text = "Matricula";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TButtonBuscar
            // 
            this.TButtonBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TButtonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.errorProvider1.SetIconAlignment(this.TButtonBuscar, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.TButtonBuscar.Image = global::AlquilerCoches.Properties.Resources.Search_icon;
            this.TButtonBuscar.Location = new System.Drawing.Point(28, 32);
            this.TButtonBuscar.Name = "TButtonBuscar";
            this.TButtonBuscar.Size = new System.Drawing.Size(75, 73);
            this.TButtonBuscar.TabIndex = 32;
            this.TButtonBuscar.Text = "Buscar";
            this.TButtonBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TButtonBuscar.UseVisualStyleBackColor = true;
            this.TButtonBuscar.Click += new System.EventHandler(this.TButtonBuscar_Click);
            // 
            // TButtonCerrar
            // 
            this.TButtonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TButtonCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TButtonCerrar.Image = global::AlquilerCoches.Properties.Resources.Close_icon;
            this.TButtonCerrar.Location = new System.Drawing.Point(12, 524);
            this.TButtonCerrar.Name = "TButtonCerrar";
            this.TButtonCerrar.Size = new System.Drawing.Size(75, 72);
            this.TButtonCerrar.TabIndex = 30;
            this.TButtonCerrar.Text = "Cerrar";
            this.TButtonCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TButtonCerrar.UseVisualStyleBackColor = true;
            this.TButtonCerrar.Click += new System.EventHandler(this.TButtonCerrar_Click);
            // 
            // TGroupBoxSeleccion
            // 
            this.TGroupBoxSeleccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TGroupBoxSeleccion.BackColor = System.Drawing.Color.Transparent;
            this.TGroupBoxSeleccion.Controls.Add(this.TListBoxMatriculas);
            this.TGroupBoxSeleccion.Controls.Add(this.TListBoxModelos);
            this.TGroupBoxSeleccion.Controls.Add(this.TListBoxMarcas);
            this.TGroupBoxSeleccion.Controls.Add(this.TLabelMatriculas);
            this.TGroupBoxSeleccion.Controls.Add(this.TLabelModelos);
            this.TGroupBoxSeleccion.Controls.Add(this.TLabelMarcas);
            this.TGroupBoxSeleccion.Location = new System.Drawing.Point(34, 27);
            this.TGroupBoxSeleccion.Name = "TGroupBoxSeleccion";
            this.TGroupBoxSeleccion.Size = new System.Drawing.Size(799, 144);
            this.TGroupBoxSeleccion.TabIndex = 31;
            this.TGroupBoxSeleccion.TabStop = false;
            this.TGroupBoxSeleccion.Text = "2 Seleccion";
            // 
            // TListBoxMatriculas
            // 
            this.TListBoxMatriculas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TListBoxMatriculas.FormattingEnabled = true;
            this.TListBoxMatriculas.Items.AddRange(new object[] {
            "7777 DBD",
            "9999 ADF"});
            this.TListBoxMatriculas.Location = new System.Drawing.Point(587, 36);
            this.TListBoxMatriculas.Name = "TListBoxMatriculas";
            this.TListBoxMatriculas.Size = new System.Drawing.Size(187, 95);
            this.TListBoxMatriculas.TabIndex = 34;
            this.TListBoxMatriculas.SelectedIndexChanged += new System.EventHandler(this.TListBoxMatriculas_SelectedIndexChanged);
            // 
            // TListBoxModelos
            // 
            this.TListBoxModelos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TListBoxModelos.FormattingEnabled = true;
            this.TListBoxModelos.Items.AddRange(new object[] {
            "FIESTA",
            "FOCUS"});
            this.TListBoxModelos.Location = new System.Drawing.Point(308, 36);
            this.TListBoxModelos.Name = "TListBoxModelos";
            this.TListBoxModelos.Size = new System.Drawing.Size(187, 95);
            this.TListBoxModelos.TabIndex = 33;
            this.TListBoxModelos.SelectedIndexChanged += new System.EventHandler(this.TListBoxModelos_SelectedIndexChanged);
            // 
            // TListBoxMarcas
            // 
            this.TListBoxMarcas.FormattingEnabled = true;
            this.TListBoxMarcas.Items.AddRange(new object[] {
            "FORD",
            "AUDI",
            "SEAT",
            "MERCEDES"});
            this.TListBoxMarcas.Location = new System.Drawing.Point(28, 36);
            this.TListBoxMarcas.Name = "TListBoxMarcas";
            this.TListBoxMarcas.Size = new System.Drawing.Size(187, 95);
            this.TListBoxMarcas.TabIndex = 32;
            this.TListBoxMarcas.SelectedIndexChanged += new System.EventHandler(this.TListBoxMarcas_SelectedIndexChanged);
            // 
            // TLabelMatriculas
            // 
            this.TLabelMatriculas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TLabelMatriculas.AutoSize = true;
            this.TLabelMatriculas.Location = new System.Drawing.Point(588, 20);
            this.TLabelMatriculas.Name = "TLabelMatriculas";
            this.TLabelMatriculas.Size = new System.Drawing.Size(55, 13);
            this.TLabelMatriculas.TabIndex = 31;
            this.TLabelMatriculas.Text = "Matriculas";
            // 
            // TLabelModelos
            // 
            this.TLabelModelos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TLabelModelos.AutoSize = true;
            this.TLabelModelos.Location = new System.Drawing.Point(305, 20);
            this.TLabelModelos.Name = "TLabelModelos";
            this.TLabelModelos.Size = new System.Drawing.Size(47, 13);
            this.TLabelModelos.TabIndex = 30;
            this.TLabelModelos.Text = "Modelos";
            // 
            // TLabelMarcas
            // 
            this.TLabelMarcas.AutoSize = true;
            this.TLabelMarcas.Location = new System.Drawing.Point(25, 20);
            this.TLabelMarcas.Name = "TLabelMarcas";
            this.TLabelMarcas.Size = new System.Drawing.Size(42, 13);
            this.TLabelMarcas.TabIndex = 29;
            this.TLabelMarcas.Text = "Marcas";
            // 
            // TGroupBoxAccion
            // 
            this.TGroupBoxAccion.BackColor = System.Drawing.Color.Transparent;
            this.TGroupBoxAccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TGroupBoxAccion.Controls.Add(this.TButtonBorrar);
            this.TGroupBoxAccion.Controls.Add(this.TButtonBuscar);
            this.TGroupBoxAccion.Controls.Add(this.TButtonAnyadir);
            this.TGroupBoxAccion.Controls.Add(this.TButtonEditar);
            this.TGroupBoxAccion.Location = new System.Drawing.Point(34, 177);
            this.TGroupBoxAccion.Name = "TGroupBoxAccion";
            this.TGroupBoxAccion.Size = new System.Drawing.Size(198, 214);
            this.TGroupBoxAccion.TabIndex = 32;
            this.TGroupBoxAccion.TabStop = false;
            this.TGroupBoxAccion.Text = "1 Accion";
            // 
            // TButtonBorrar
            // 
            this.TButtonBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TButtonBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TButtonBorrar.Image = global::AlquilerCoches.Properties.Resources.Delete_icon;
            this.TButtonBorrar.Location = new System.Drawing.Point(109, 122);
            this.TButtonBorrar.Name = "TButtonBorrar";
            this.TButtonBorrar.Size = new System.Drawing.Size(75, 75);
            this.TButtonBorrar.TabIndex = 33;
            this.TButtonBorrar.Text = "Delete";
            this.TButtonBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TButtonBorrar.UseVisualStyleBackColor = true;
            this.TButtonBorrar.Click += new System.EventHandler(this.TButtonBorrar_Click);
            // 
            // TButtonAnyadir
            // 
            this.TButtonAnyadir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TButtonAnyadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TButtonAnyadir.Image = global::AlquilerCoches.Properties.Resources.Add_icon;
            this.TButtonAnyadir.Location = new System.Drawing.Point(109, 32);
            this.TButtonAnyadir.Name = "TButtonAnyadir";
            this.TButtonAnyadir.Size = new System.Drawing.Size(75, 73);
            this.TButtonAnyadir.TabIndex = 31;
            this.TButtonAnyadir.Text = "Add";
            this.TButtonAnyadir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TButtonAnyadir.UseVisualStyleBackColor = true;
            this.TButtonAnyadir.Click += new System.EventHandler(this.TButtonAnyadir_Click);
            // 
            // TButtonEditar
            // 
            this.TButtonEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TButtonEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TButtonEditar.Image = global::AlquilerCoches.Properties.Resources.Edit_icon;
            this.TButtonEditar.Location = new System.Drawing.Point(28, 122);
            this.TButtonEditar.Name = "TButtonEditar";
            this.TButtonEditar.Size = new System.Drawing.Size(75, 75);
            this.TButtonEditar.TabIndex = 30;
            this.TButtonEditar.Text = "Edit";
            this.TButtonEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TButtonEditar.UseVisualStyleBackColor = true;
            this.TButtonEditar.Click += new System.EventHandler(this.TButtonEditar_Click);
            // 
            // TButtonCancelar
            // 
            this.TButtonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TButtonCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TButtonCancelar.Image = global::AlquilerCoches.Properties.Resources.Cancel_icon;
            this.TButtonCancelar.Location = new System.Drawing.Point(62, 425);
            this.TButtonCancelar.Name = "TButtonCancelar";
            this.TButtonCancelar.Size = new System.Drawing.Size(75, 69);
            this.TButtonCancelar.TabIndex = 12;
            this.TButtonCancelar.Text = "Cancel";
            this.TButtonCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TButtonCancelar.UseVisualStyleBackColor = true;
            this.TButtonCancelar.Click += new System.EventHandler(this.TButtonCancelar_Click);
            // 
            // TButtonOK
            // 
            this.TButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TButtonOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TButtonOK.Image = global::AlquilerCoches.Properties.Resources.Accept_icon;
            this.TButtonOK.Location = new System.Drawing.Point(143, 425);
            this.TButtonOK.Name = "TButtonOK";
            this.TButtonOK.Size = new System.Drawing.Size(75, 69);
            this.TButtonOK.TabIndex = 11;
            this.TButtonOK.Text = "OK";
            this.TButtonOK.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TButtonOK.UseVisualStyleBackColor = true;
            this.TButtonOK.Click += new System.EventHandler(this.TButtonOK_Click);
            // 
            // GestionVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AlquilerCoches.Properties.Resources.rentacar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 608);
            this.Controls.Add(this.TButtonCancelar);
            this.Controls.Add(this.TButtonOK);
            this.Controls.Add(this.TGroupBoxAccion);
            this.Controls.Add(this.TGroupBoxSeleccion);
            this.Controls.Add(this.TButtonCerrar);
            this.Controls.Add(this.TGroupBoxDatosVehiculo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(894, 608);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(894, 608);
            this.Name = "GestionVehiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionVehiculos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestionVehiculos_FormClosing);
            this.TGroupBoxDatosVehiculo.ResumeLayout(false);
            this.TGroupBoxDatosVehiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TPictureBoxMatricula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.TGroupBoxSeleccion.ResumeLayout(false);
            this.TGroupBoxSeleccion.PerformLayout();
            this.TGroupBoxAccion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TGroupBoxDatosVehiculo;
        private System.Windows.Forms.Label TLabelEstado;
        private System.Windows.Forms.RadioButton TRadioButtonEstado;
        private System.Windows.Forms.PictureBox TPictureBoxMatricula;
        private System.Windows.Forms.Label TLabelCategoria;
        private System.Windows.Forms.TextBox TTextBoxPrecioVenta;
        private System.Windows.Forms.Label TLabelPrecioVenta;
        private System.Windows.Forms.TextBox TTextBoxPrecioCompra;
        private System.Windows.Forms.Label TLabelPrecioCompra;
        private System.Windows.Forms.TextBox TTextBoxMatricula;
        private System.Windows.Forms.Label TLabelMatricula;
        private System.Windows.Forms.RadioButton TRadioButtonRevision;
        private System.Windows.Forms.TextBox TTextBoxMarca;
        private System.Windows.Forms.Label TLabelMarca;
        private System.Windows.Forms.TextBox TTextBoxModelo;
        private System.Windows.Forms.Label TLabelModelo;
        private System.Windows.Forms.TextBox TTextBoxGarantia;
        private System.Windows.Forms.Label TLabelGarantia;
        private System.Windows.Forms.TextBox TTextBoxKM;
        private System.Windows.Forms.Label TLabelKM;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button TButtonCerrar;
        private System.Windows.Forms.GroupBox TGroupBoxSeleccion;
        private System.Windows.Forms.ListBox TListBoxMatriculas;
        private System.Windows.Forms.ListBox TListBoxModelos;
        private System.Windows.Forms.ListBox TListBoxMarcas;
        private System.Windows.Forms.Label TLabelMatriculas;
        private System.Windows.Forms.Label TLabelModelos;
        private System.Windows.Forms.Label TLabelMarcas;
        private System.Windows.Forms.Button TButtonCancelar;
        private System.Windows.Forms.Button TButtonOK;
        private System.Windows.Forms.GroupBox TGroupBoxAccion;
        private System.Windows.Forms.Button TButtonBorrar;
        private System.Windows.Forms.Button TButtonBuscar;
        private System.Windows.Forms.Button TButtonAnyadir;
        private System.Windows.Forms.Button TButtonEditar;
        private System.Windows.Forms.ComboBox TComboBoxCategoria;
    }
}