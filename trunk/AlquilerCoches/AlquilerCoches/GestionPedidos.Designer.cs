namespace AlquilerCoches
{
    partial class GestionPedidos
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
            this.TEnviogroupBox3 = new System.Windows.Forms.GroupBox();
            this.TEnvioButtonUrgente = new System.Windows.Forms.RadioButton();
            this.TEnvioButtonOrdinario = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.TErrorModelo = new System.Windows.Forms.Label();
            this.TErrorMarca = new System.Windows.Forms.Label();
            this.TErrorProvee = new System.Windows.Forms.Label();
            this.TModelocomboBox3 = new System.Windows.Forms.ComboBox();
            this.TMarcacomboBox2 = new System.Windows.Forms.ComboBox();
            this.TProveecomboBox1 = new System.Windows.Forms.ComboBox();
            this.TProveLabel = new System.Windows.Forms.Label();
            this.TObservTextBox = new System.Windows.Forms.TextBox();
            this.TObserLabel = new System.Windows.Forms.Label();
            this.TCantidadLabel = new System.Windows.Forms.Label();
            this.TModeloLabel = new System.Windows.Forms.Label();
            this.TMarca = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TVendedorText = new System.Windows.Forms.TextBox();
            this.TDateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.TLabelFecha = new System.Windows.Forms.Label();
            this.TEstadoTextBox = new System.Windows.Forms.TextBox();
            this.TEstadoLabel = new System.Windows.Forms.Label();
            this.TEmpLabel = new System.Windows.Forms.Label();
            this.TIDlabel = new System.Windows.Forms.Label();
            this.TIDtextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TButtonCerrar = new System.Windows.Forms.Button();
            this.TButtonBorrar = new System.Windows.Forms.Button();
            this.TButtonOK = new System.Windows.Forms.Button();
            this.TLabelTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.TEnviogroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.TEnviogroupBox3);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.TErrorModelo);
            this.groupBox1.Controls.Add(this.TErrorMarca);
            this.groupBox1.Controls.Add(this.TErrorProvee);
            this.groupBox1.Controls.Add(this.TModelocomboBox3);
            this.groupBox1.Controls.Add(this.TMarcacomboBox2);
            this.groupBox1.Controls.Add(this.TProveecomboBox1);
            this.groupBox1.Controls.Add(this.TProveLabel);
            this.groupBox1.Controls.Add(this.TObservTextBox);
            this.groupBox1.Controls.Add(this.TObserLabel);
            this.groupBox1.Controls.Add(this.TCantidadLabel);
            this.groupBox1.Controls.Add(this.TModeloLabel);
            this.groupBox1.Controls.Add(this.TMarca);
            this.groupBox1.Location = new System.Drawing.Point(75, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 326);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Pedido";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TEnviogroupBox3
            // 
            this.TEnviogroupBox3.Controls.Add(this.TEnvioButtonUrgente);
            this.TEnviogroupBox3.Controls.Add(this.TEnvioButtonOrdinario);
            this.TEnviogroupBox3.Location = new System.Drawing.Point(109, 161);
            this.TEnviogroupBox3.Name = "TEnviogroupBox3";
            this.TEnviogroupBox3.Size = new System.Drawing.Size(344, 51);
            this.TEnviogroupBox3.TabIndex = 42;
            this.TEnviogroupBox3.TabStop = false;
            this.TEnviogroupBox3.Text = "Envio";
            this.TEnviogroupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // TEnvioButtonUrgente
            // 
            this.TEnvioButtonUrgente.AutoSize = true;
            this.TEnvioButtonUrgente.Location = new System.Drawing.Point(207, 19);
            this.TEnvioButtonUrgente.Name = "TEnvioButtonUrgente";
            this.TEnvioButtonUrgente.Size = new System.Drawing.Size(63, 17);
            this.TEnvioButtonUrgente.TabIndex = 33;
            this.TEnvioButtonUrgente.Text = "Urgente";
            this.TEnvioButtonUrgente.UseVisualStyleBackColor = true;
            // 
            // TEnvioButtonOrdinario
            // 
            this.TEnvioButtonOrdinario.AutoSize = true;
            this.TEnvioButtonOrdinario.Checked = true;
            this.TEnvioButtonOrdinario.Location = new System.Drawing.Point(64, 19);
            this.TEnvioButtonOrdinario.Name = "TEnvioButtonOrdinario";
            this.TEnvioButtonOrdinario.Size = new System.Drawing.Size(67, 17);
            this.TEnvioButtonOrdinario.TabIndex = 32;
            this.TEnvioButtonOrdinario.TabStop = true;
            this.TEnvioButtonOrdinario.Text = "Ordinario";
            this.TEnvioButtonOrdinario.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(207, 135);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(86, 20);
            this.numericUpDown1.TabIndex = 41;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // TErrorModelo
            // 
            this.TErrorModelo.AutoSize = true;
            this.TErrorModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TErrorModelo.ForeColor = System.Drawing.Color.Red;
            this.TErrorModelo.Location = new System.Drawing.Point(389, 101);
            this.TErrorModelo.Name = "TErrorModelo";
            this.TErrorModelo.Size = new System.Drawing.Size(0, 13);
            this.TErrorModelo.TabIndex = 39;
            // 
            // TErrorMarca
            // 
            this.TErrorMarca.AutoSize = true;
            this.TErrorMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TErrorMarca.ForeColor = System.Drawing.Color.Red;
            this.TErrorMarca.Location = new System.Drawing.Point(390, 72);
            this.TErrorMarca.Name = "TErrorMarca";
            this.TErrorMarca.Size = new System.Drawing.Size(0, 13);
            this.TErrorMarca.TabIndex = 38;
            // 
            // TErrorProvee
            // 
            this.TErrorProvee.AutoSize = true;
            this.TErrorProvee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TErrorProvee.ForeColor = System.Drawing.Color.Red;
            this.TErrorProvee.Location = new System.Drawing.Point(390, 39);
            this.TErrorProvee.Name = "TErrorProvee";
            this.TErrorProvee.Size = new System.Drawing.Size(0, 13);
            this.TErrorProvee.TabIndex = 37;
            this.TErrorProvee.Click += new System.EventHandler(this.label1_Click);
            // 
            // TModelocomboBox3
            // 
            this.TModelocomboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TModelocomboBox3.FormattingEnabled = true;
            this.TModelocomboBox3.Location = new System.Drawing.Point(205, 98);
            this.TModelocomboBox3.Name = "TModelocomboBox3";
            this.TModelocomboBox3.Size = new System.Drawing.Size(248, 21);
            this.TModelocomboBox3.TabIndex = 36;
            this.TModelocomboBox3.SelectedIndexChanged += new System.EventHandler(this.TModelocomboBox3_SelectedIndexChanged);
            this.TModelocomboBox3.Click += new System.EventHandler(this.TModelocomboBox3_Click);
            this.TModelocomboBox3.Leave += new System.EventHandler(this.TModelocomboBox3_Leave);
            // 
            // TMarcacomboBox2
            // 
            this.TMarcacomboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TMarcacomboBox2.FormattingEnabled = true;
            this.TMarcacomboBox2.Location = new System.Drawing.Point(205, 64);
            this.TMarcacomboBox2.Name = "TMarcacomboBox2";
            this.TMarcacomboBox2.Size = new System.Drawing.Size(248, 21);
            this.TMarcacomboBox2.TabIndex = 35;
            this.TMarcacomboBox2.TextChanged += new System.EventHandler(this.TMarcacomboBox2_TextChanged);
            this.TMarcacomboBox2.Click += new System.EventHandler(this.TMarcacomboBox2_Click);
            this.TMarcacomboBox2.Leave += new System.EventHandler(this.TMarcacomboBox2_Leave);
            // 
            // TProveecomboBox1
            // 
            this.TProveecomboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TProveecomboBox1.FormattingEnabled = true;
            this.TProveecomboBox1.Location = new System.Drawing.Point(205, 31);
            this.TProveecomboBox1.Name = "TProveecomboBox1";
            this.TProveecomboBox1.Size = new System.Drawing.Size(248, 21);
            this.TProveecomboBox1.TabIndex = 34;
            this.TProveecomboBox1.SelectedIndexChanged += new System.EventHandler(this.TProveecomboBox1_SelectedIndexChanged);
            this.TProveecomboBox1.Click += new System.EventHandler(this.TProveecomboBox1_Click);
            this.TProveecomboBox1.Leave += new System.EventHandler(this.TProveecomboBox1_Leave);
            // 
            // TProveLabel
            // 
            this.TProveLabel.AutoSize = true;
            this.TProveLabel.Location = new System.Drawing.Point(109, 34);
            this.TProveLabel.Name = "TProveLabel";
            this.TProveLabel.Size = new System.Drawing.Size(56, 13);
            this.TProveLabel.TabIndex = 32;
            this.TProveLabel.Text = "Proveedor";
            // 
            // TObservTextBox
            // 
            this.TObservTextBox.Location = new System.Drawing.Point(205, 231);
            this.TObservTextBox.Multiline = true;
            this.TObservTextBox.Name = "TObservTextBox";
            this.TObservTextBox.Size = new System.Drawing.Size(283, 86);
            this.TObservTextBox.TabIndex = 29;
            this.TObservTextBox.Leave += new System.EventHandler(this.TObservTextBox_Leave);
            // 
            // TObserLabel
            // 
            this.TObserLabel.AutoSize = true;
            this.TObserLabel.Location = new System.Drawing.Point(106, 234);
            this.TObserLabel.Name = "TObserLabel";
            this.TObserLabel.Size = new System.Drawing.Size(78, 13);
            this.TObserLabel.TabIndex = 28;
            this.TObserLabel.Text = "Observaciones";
            // 
            // TCantidadLabel
            // 
            this.TCantidadLabel.AutoSize = true;
            this.TCantidadLabel.Location = new System.Drawing.Point(106, 135);
            this.TCantidadLabel.Name = "TCantidadLabel";
            this.TCantidadLabel.Size = new System.Drawing.Size(49, 13);
            this.TCantidadLabel.TabIndex = 23;
            this.TCantidadLabel.Text = "Cantidad";
            // 
            // TModeloLabel
            // 
            this.TModeloLabel.AutoSize = true;
            this.TModeloLabel.Location = new System.Drawing.Point(109, 101);
            this.TModeloLabel.Name = "TModeloLabel";
            this.TModeloLabel.Size = new System.Drawing.Size(42, 13);
            this.TModeloLabel.TabIndex = 22;
            this.TModeloLabel.Text = "Modelo";
            // 
            // TMarca
            // 
            this.TMarca.AutoSize = true;
            this.TMarca.Location = new System.Drawing.Point(109, 67);
            this.TMarca.Name = "TMarca";
            this.TMarca.Size = new System.Drawing.Size(37, 13);
            this.TMarca.TabIndex = 21;
            this.TMarca.Text = "Marca";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.TVendedorText);
            this.groupBox2.Controls.Add(this.TDateTimePickerFecha);
            this.groupBox2.Controls.Add(this.TLabelFecha);
            this.groupBox2.Controls.Add(this.TEstadoTextBox);
            this.groupBox2.Controls.Add(this.TEstadoLabel);
            this.groupBox2.Controls.Add(this.TEmpLabel);
            this.groupBox2.Controls.Add(this.TIDlabel);
            this.groupBox2.Controls.Add(this.TIDtextBox);
            this.groupBox2.Location = new System.Drawing.Point(113, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 89);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos transacción";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // TVendedorText
            // 
            this.TVendedorText.BackColor = System.Drawing.SystemColors.Control;
            this.TVendedorText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TVendedorText.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TVendedorText.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.TVendedorText.Location = new System.Drawing.Point(258, 27);
            this.TVendedorText.Name = "TVendedorText";
            this.TVendedorText.ReadOnly = true;
            this.TVendedorText.Size = new System.Drawing.Size(204, 25);
            this.TVendedorText.TabIndex = 32;
            this.TVendedorText.Leave += new System.EventHandler(this.TVendedorText_Leave);
            // 
            // TDateTimePickerFecha
            // 
            this.TDateTimePickerFecha.CalendarMonthBackground = System.Drawing.Color.White;
            this.TDateTimePickerFecha.CustomFormat = "";
            this.TDateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TDateTimePickerFecha.Location = new System.Drawing.Point(258, 58);
            this.TDateTimePickerFecha.Name = "TDateTimePickerFecha";
            this.TDateTimePickerFecha.Size = new System.Drawing.Size(90, 20);
            this.TDateTimePickerFecha.TabIndex = 31;
            // 
            // TLabelFecha
            // 
            this.TLabelFecha.AutoSize = true;
            this.TLabelFecha.Location = new System.Drawing.Point(212, 60);
            this.TLabelFecha.Name = "TLabelFecha";
            this.TLabelFecha.Size = new System.Drawing.Size(40, 13);
            this.TLabelFecha.TabIndex = 29;
            this.TLabelFecha.Text = "Fecha:";
            // 
            // TEstadoTextBox
            // 
            this.TEstadoTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.TEstadoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEstadoTextBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEstadoTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.TEstadoTextBox.Location = new System.Drawing.Point(95, 55);
            this.TEstadoTextBox.Name = "TEstadoTextBox";
            this.TEstadoTextBox.ReadOnly = true;
            this.TEstadoTextBox.Size = new System.Drawing.Size(84, 23);
            this.TEstadoTextBox.TabIndex = 28;
            this.TEstadoTextBox.TextChanged += new System.EventHandler(this.TEstadoTextBox_TextChanged);
            // 
            // TEstadoLabel
            // 
            this.TEstadoLabel.AutoSize = true;
            this.TEstadoLabel.Location = new System.Drawing.Point(12, 58);
            this.TEstadoLabel.Name = "TEstadoLabel";
            this.TEstadoLabel.Size = new System.Drawing.Size(78, 13);
            this.TEstadoLabel.TabIndex = 27;
            this.TEstadoLabel.Text = "Estado pedido:";
            // 
            // TEmpLabel
            // 
            this.TEmpLabel.AutoSize = true;
            this.TEmpLabel.Location = new System.Drawing.Point(196, 31);
            this.TEmpLabel.Name = "TEmpLabel";
            this.TEmpLabel.Size = new System.Drawing.Size(54, 13);
            this.TEmpLabel.TabIndex = 25;
            this.TEmpLabel.Text = "Empleado\r\n";
            // 
            // TIDlabel
            // 
            this.TIDlabel.AutoSize = true;
            this.TIDlabel.Location = new System.Drawing.Point(12, 31);
            this.TIDlabel.Name = "TIDlabel";
            this.TIDlabel.Size = new System.Drawing.Size(79, 13);
            this.TIDlabel.TabIndex = 24;
            this.TIDlabel.Text = "ID transacción:";
            // 
            // TIDtextBox
            // 
            this.TIDtextBox.BackColor = System.Drawing.SystemColors.Control;
            this.TIDtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TIDtextBox.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIDtextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.TIDtextBox.Location = new System.Drawing.Point(95, 27);
            this.TIDtextBox.Name = "TIDtextBox";
            this.TIDtextBox.ReadOnly = true;
            this.TIDtextBox.Size = new System.Drawing.Size(84, 25);
            this.TIDtextBox.TabIndex = 23;
            this.TIDtextBox.TextChanged += new System.EventHandler(this.TIDtextBox_TextChanged);
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
            this.TButtonCerrar.Location = new System.Drawing.Point(758, 207);
            this.TButtonCerrar.Name = "TButtonCerrar";
            this.TButtonCerrar.Size = new System.Drawing.Size(77, 67);
            this.TButtonCerrar.TabIndex = 31;
            this.TButtonCerrar.Text = "Cerrar";
            this.TButtonCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TButtonCerrar.UseVisualStyleBackColor = true;
            this.TButtonCerrar.Click += new System.EventHandler(this.TButtonCerrar_Click);
            // 
            // TButtonBorrar
            // 
            this.TButtonBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TButtonBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TButtonBorrar.Image = global::AlquilerCoches.Properties.Resources.Delete_icon;
            this.TButtonBorrar.Location = new System.Drawing.Point(342, 480);
            this.TButtonBorrar.Name = "TButtonBorrar";
            this.TButtonBorrar.Size = new System.Drawing.Size(82, 69);
            this.TButtonBorrar.TabIndex = 34;
            this.TButtonBorrar.Text = "Borrar";
            this.TButtonBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TButtonBorrar.UseVisualStyleBackColor = true;
            this.TButtonBorrar.Click += new System.EventHandler(this.TButtonBorrar_Click);
            // 
            // TButtonOK
            // 
            this.TButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TButtonOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TButtonOK.Image = global::AlquilerCoches.Properties.Resources.Accept_icon;
            this.TButtonOK.Location = new System.Drawing.Point(164, 480);
            this.TButtonOK.Name = "TButtonOK";
            this.TButtonOK.Size = new System.Drawing.Size(86, 69);
            this.TButtonOK.TabIndex = 37;
            this.TButtonOK.Text = "Enviar";
            this.TButtonOK.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TButtonOK.UseVisualStyleBackColor = true;
            this.TButtonOK.Click += new System.EventHandler(this.TButtonOK_Click);
            // 
            // TLabelTitulo
            // 
            this.TLabelTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TLabelTitulo.AutoSize = true;
            this.TLabelTitulo.BackColor = System.Drawing.Color.Transparent;
            this.TLabelTitulo.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TLabelTitulo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TLabelTitulo.Location = new System.Drawing.Point(-1, -1);
            this.TLabelTitulo.Name = "TLabelTitulo";
            this.TLabelTitulo.Size = new System.Drawing.Size(94, 18);
            this.TLabelTitulo.TabIndex = 41;
            this.TLabelTitulo.Text = "Datos del Pedido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(110, 457);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 42;
            // 
            // GestionPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AlquilerCoches.Properties.Resources.rentacar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 570);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TLabelTitulo);
            this.Controls.Add(this.TButtonOK);
            this.Controls.Add(this.TButtonBorrar);
            this.Controls.Add(this.TButtonCerrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Pedidos";
            this.Load += new System.EventHandler(this.GestionPedidos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TEnviogroupBox3.ResumeLayout(false);
            this.TEnviogroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label TProveLabel;
        private System.Windows.Forms.TextBox TObservTextBox;
        private System.Windows.Forms.Label TObserLabel;
        private System.Windows.Forms.Label TCantidadLabel;
        private System.Windows.Forms.Label TModeloLabel;
        private System.Windows.Forms.Label TMarca;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TEstadoTextBox;
        private System.Windows.Forms.Label TEstadoLabel;
        private System.Windows.Forms.Label TEmpLabel;
        private System.Windows.Forms.Label TIDlabel;
        private System.Windows.Forms.TextBox TIDtextBox;
        private System.Windows.Forms.Label TLabelFecha;
        private System.Windows.Forms.ComboBox TModelocomboBox3;
        private System.Windows.Forms.ComboBox TMarcacomboBox2;
        private System.Windows.Forms.ComboBox TProveecomboBox1;
        private System.Windows.Forms.Label TErrorProvee;
        private System.Windows.Forms.Label TErrorMarca;
        private System.Windows.Forms.Label TErrorModelo;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox TEnviogroupBox3;
        private System.Windows.Forms.RadioButton TEnvioButtonUrgente;
        private System.Windows.Forms.RadioButton TEnvioButtonOrdinario;
        private System.Windows.Forms.Button TButtonCerrar;
        private System.Windows.Forms.Button TButtonBorrar;
        private System.Windows.Forms.Button TButtonOK;
        private System.Windows.Forms.Label TLabelTitulo;
        private System.Windows.Forms.DateTimePicker TDateTimePickerFecha;
        private System.Windows.Forms.TextBox TVendedorText;
        private System.Windows.Forms.Label label1;
    }
}