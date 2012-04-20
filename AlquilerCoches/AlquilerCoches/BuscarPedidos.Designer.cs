namespace AlquilerCoches
{
    partial class BuscarPedidos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TModelocomboBox3 = new System.Windows.Forms.ComboBox();
            this.TMarcacomboBox2 = new System.Windows.Forms.ComboBox();
            this.TProveecomboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.TButtonBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TNamelabel = new System.Windows.Forms.Label();
            this.TNametextbox = new System.Windows.Forms.TextBox();
            this.TEstadogroupbox = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TIDtextBox = new System.Windows.Forms.TextBox();
            this.TDataGridViewPedidos = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TButtonCerrar = new System.Windows.Forms.Button();
            this.TButtonEliminar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.TEstadogroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TDataGridViewPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.TModelocomboBox3);
            this.groupBox1.Controls.Add(this.TMarcacomboBox2);
            this.groupBox1.Controls.Add(this.TProveecomboBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.TButtonBuscar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TNamelabel);
            this.groupBox1.Controls.Add(this.TNametextbox);
            this.groupBox1.Controls.Add(this.TEstadogroupbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TIDtextBox);
            this.groupBox1.Location = new System.Drawing.Point(37, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criterios de búsqueda ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TModelocomboBox3
            // 
            this.TModelocomboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TModelocomboBox3.FormattingEnabled = true;
            this.TModelocomboBox3.Location = new System.Drawing.Point(239, 174);
            this.TModelocomboBox3.Name = "TModelocomboBox3";
            this.TModelocomboBox3.Size = new System.Drawing.Size(234, 21);
            this.TModelocomboBox3.TabIndex = 41;
            this.TModelocomboBox3.Click += new System.EventHandler(this.TModelocomboBox3_Click);
            // 
            // TMarcacomboBox2
            // 
            this.TMarcacomboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TMarcacomboBox2.FormattingEnabled = true;
            this.TMarcacomboBox2.Location = new System.Drawing.Point(239, 135);
            this.TMarcacomboBox2.Name = "TMarcacomboBox2";
            this.TMarcacomboBox2.Size = new System.Drawing.Size(234, 21);
            this.TMarcacomboBox2.TabIndex = 40;
            this.TMarcacomboBox2.Click += new System.EventHandler(this.TMarcacomboBox2_Click);
            // 
            // TProveecomboBox1
            // 
            this.TProveecomboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TProveecomboBox1.FormattingEnabled = true;
            this.TProveecomboBox1.Items.AddRange(new object[] {
            "",
            "HERMANOS ESCLAPEZ S.L.",
            "MARTÍNEZ E HIJOS S.A.",
            "TOYOTA SANTA FAZ S.L.",
            "RENAULT BABEL S.L.",
            "MERCEDES-BENZ ATALAYAS S.L.",
            "DACIA LOGAN VIRGEN DEL REMEDIO S.A.",
            "CONCESIONARIO CAZORLA S.L.",
            "AUTOMOCIÓN SIERRA TRAMONTANA S.L.",
            "CONCESIONARIO IBAÑEZ E HIJOS S.L.",
            "ASOCIACIÓN AUTOMÓVIL FELIZ S.L."});
            this.TProveecomboBox1.Location = new System.Drawing.Point(238, 100);
            this.TProveecomboBox1.Name = "TProveecomboBox1";
            this.TProveecomboBox1.Size = new System.Drawing.Size(234, 21);
            this.TProveecomboBox1.TabIndex = 39;
            this.TProveecomboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Proveedor";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Location = new System.Drawing.Point(19, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(129, 73);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Envío";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter_1);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(39, 46);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(63, 17);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Urgente";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(39, 23);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(67, 17);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Ordinario";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // TButtonBuscar
            // 
            this.TButtonBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TButtonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.errorProvider1.SetIconAlignment(this.TButtonBuscar, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.TButtonBuscar.Image = global::AlquilerCoches.Properties.Resources.Search_icon;
            this.TButtonBuscar.Location = new System.Drawing.Point(521, 29);
            this.TButtonBuscar.Name = "TButtonBuscar";
            this.TButtonBuscar.Size = new System.Drawing.Size(71, 65);
            this.TButtonBuscar.TabIndex = 33;
            this.TButtonBuscar.Text = "Buscar";
            this.TButtonBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TButtonBuscar.UseVisualStyleBackColor = true;
            this.TButtonBuscar.Click += new System.EventHandler(this.TButtonBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Marca";
            // 
            // TNamelabel
            // 
            this.TNamelabel.AutoSize = true;
            this.TNamelabel.Location = new System.Drawing.Point(176, 67);
            this.TNamelabel.Name = "TNamelabel";
            this.TNamelabel.Size = new System.Drawing.Size(47, 13);
            this.TNamelabel.TabIndex = 7;
            this.TNamelabel.Text = "Nombre:";
            this.TNamelabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // TNametextbox
            // 
            this.TNametextbox.Location = new System.Drawing.Point(239, 67);
            this.TNametextbox.Name = "TNametextbox";
            this.TNametextbox.Size = new System.Drawing.Size(158, 20);
            this.TNametextbox.TabIndex = 6;
            this.TNametextbox.TextChanged += new System.EventHandler(this.TNametextbox_TextChanged);
            // 
            // TEstadogroupbox
            // 
            this.TEstadogroupbox.Controls.Add(this.radioButton2);
            this.TEstadogroupbox.Controls.Add(this.radioButton1);
            this.TEstadogroupbox.Location = new System.Drawing.Point(19, 26);
            this.TEstadogroupbox.Name = "TEstadogroupbox";
            this.TEstadogroupbox.Size = new System.Drawing.Size(129, 67);
            this.TEstadogroupbox.TabIndex = 5;
            this.TEstadogroupbox.TabStop = false;
            this.TEstadogroupbox.Text = "Estado";
            this.TEstadogroupbox.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(43, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "Cerrado";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(43, 18);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Abierto";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // TIDtextBox
            // 
            this.TIDtextBox.Location = new System.Drawing.Point(239, 26);
            this.TIDtextBox.Name = "TIDtextBox";
            this.TIDtextBox.Size = new System.Drawing.Size(158, 20);
            this.TIDtextBox.TabIndex = 2;
            // 
            // TDataGridViewPedidos
            // 
            this.TDataGridViewPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TDataGridViewPedidos.Location = new System.Drawing.Point(37, 239);
            this.TDataGridViewPedidos.Name = "TDataGridViewPedidos";
            this.TDataGridViewPedidos.Size = new System.Drawing.Size(818, 219);
            this.TDataGridViewPedidos.TabIndex = 3;
            this.TDataGridViewPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TDataGridViewPedidos_CellContentClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TButtonCerrar
            // 
            this.TButtonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TButtonCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TButtonCerrar.Image = global::AlquilerCoches.Properties.Resources.Close_icon;
            this.TButtonCerrar.Location = new System.Drawing.Point(291, 482);
            this.TButtonCerrar.Name = "TButtonCerrar";
            this.TButtonCerrar.Size = new System.Drawing.Size(121, 57);
            this.TButtonCerrar.TabIndex = 31;
            this.TButtonCerrar.Text = "Cerrar";
            this.TButtonCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TButtonCerrar.UseVisualStyleBackColor = true;
            this.TButtonCerrar.Click += new System.EventHandler(this.TButtonCerrar_Click);
            // 
            // TButtonEliminar
            // 
            this.TButtonEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TButtonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TButtonEliminar.Image = global::AlquilerCoches.Properties.Resources.Delete_icon;
            this.TButtonEliminar.Location = new System.Drawing.Point(99, 482);
            this.TButtonEliminar.Name = "TButtonEliminar";
            this.TButtonEliminar.Size = new System.Drawing.Size(75, 75);
            this.TButtonEliminar.TabIndex = 34;
            this.TButtonEliminar.Text = "Delete";
            this.TButtonEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TButtonEliminar.UseVisualStyleBackColor = true;
            this.TButtonEliminar.Click += new System.EventHandler(this.TButtonEliminar_Click);
            // 
            // BuscarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::AlquilerCoches.Properties.Resources.rentacar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 570);
            this.Controls.Add(this.TButtonEliminar);
            this.Controls.Add(this.TButtonCerrar);
            this.Controls.Add(this.TDataGridViewPedidos);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscarPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Pedidos";
            this.Activated += new System.EventHandler(this.BuscarPedidos_Activated);
            this.Load += new System.EventHandler(this.BuscarPedidos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.TEstadogroupbox.ResumeLayout(false);
            this.TEstadogroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TDataGridViewPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TIDtextBox;
        private System.Windows.Forms.GroupBox TEstadogroupbox;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridView TDataGridViewPedidos;
        private System.Windows.Forms.Label TNamelabel;
        private System.Windows.Forms.TextBox TNametextbox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button TButtonBuscar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button TButtonCerrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TModelocomboBox3;
        private System.Windows.Forms.ComboBox TMarcacomboBox2;
        private System.Windows.Forms.ComboBox TProveecomboBox1;
        private System.Windows.Forms.Button TButtonEliminar;
    }
}