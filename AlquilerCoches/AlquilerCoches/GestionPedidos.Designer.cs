﻿namespace AlquilerCoches
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
            this.TAceptarbutton1 = new System.Windows.Forms.Button();
            this.TSalirbutton2 = new System.Windows.Forms.Button();
            this.TBorrarbutton3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TProveLabel = new System.Windows.Forms.Label();
            this.TEnvioButtonUrgente = new System.Windows.Forms.RadioButton();
            this.TEnvioButtonOrdinario = new System.Windows.Forms.RadioButton();
            this.TObservTextBox = new System.Windows.Forms.TextBox();
            this.TObserLabel = new System.Windows.Forms.Label();
            this.TCantidadTextBox = new System.Windows.Forms.TextBox();
            this.TEnvioLabel = new System.Windows.Forms.Label();
            this.TCantidadLabel = new System.Windows.Forms.Label();
            this.TModeloLabel = new System.Windows.Forms.Label();
            this.TMarca = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TDateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.TLabelFecha = new System.Windows.Forms.Label();
            this.TEstadoTextBox = new System.Windows.Forms.TextBox();
            this.TEstadoLabel = new System.Windows.Forms.Label();
            this.TVendedorText = new System.Windows.Forms.TextBox();
            this.TEmpLabel = new System.Windows.Forms.Label();
            this.TIDlabel = new System.Windows.Forms.Label();
            this.TIDtextBox = new System.Windows.Forms.TextBox();
            this.TProveecomboBox1 = new System.Windows.Forms.ComboBox();
            this.TMarcacomboBox2 = new System.Windows.Forms.ComboBox();
            this.TModelocomboBox3 = new System.Windows.Forms.ComboBox();
            this.TErrorProvee = new System.Windows.Forms.Label();
            this.TErrorMarca = new System.Windows.Forms.Label();
            this.TErrorModelo = new System.Windows.Forms.Label();
            this.TErrorObser = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TAceptarbutton1
            // 
            this.TAceptarbutton1.Location = new System.Drawing.Point(85, 453);
            this.TAceptarbutton1.Name = "TAceptarbutton1";
            this.TAceptarbutton1.Size = new System.Drawing.Size(138, 23);
            this.TAceptarbutton1.TabIndex = 0;
            this.TAceptarbutton1.Text = "ACEPTAR";
            this.TAceptarbutton1.UseVisualStyleBackColor = true;
            this.TAceptarbutton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TSalirbutton2
            // 
            this.TSalirbutton2.Location = new System.Drawing.Point(444, 453);
            this.TSalirbutton2.Name = "TSalirbutton2";
            this.TSalirbutton2.Size = new System.Drawing.Size(132, 23);
            this.TSalirbutton2.TabIndex = 1;
            this.TSalirbutton2.Text = "SALIR";
            this.TSalirbutton2.UseVisualStyleBackColor = true;
            this.TSalirbutton2.Click += new System.EventHandler(this.TCancelarbutton2_Click);
            // 
            // TBorrarbutton3
            // 
            this.TBorrarbutton3.Location = new System.Drawing.Point(263, 453);
            this.TBorrarbutton3.Name = "TBorrarbutton3";
            this.TBorrarbutton3.Size = new System.Drawing.Size(126, 23);
            this.TBorrarbutton3.TabIndex = 2;
            this.TBorrarbutton3.Text = "BORRAR";
            this.TBorrarbutton3.UseVisualStyleBackColor = true;
            this.TBorrarbutton3.Click += new System.EventHandler(this.TBorrarbutton3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.TErrorObser);
            this.groupBox1.Controls.Add(this.TErrorModelo);
            this.groupBox1.Controls.Add(this.TErrorMarca);
            this.groupBox1.Controls.Add(this.TErrorProvee);
            this.groupBox1.Controls.Add(this.TModelocomboBox3);
            this.groupBox1.Controls.Add(this.TMarcacomboBox2);
            this.groupBox1.Controls.Add(this.TProveecomboBox1);
            this.groupBox1.Controls.Add(this.TProveLabel);
            this.groupBox1.Controls.Add(this.TEnvioButtonUrgente);
            this.groupBox1.Controls.Add(this.TEnvioButtonOrdinario);
            this.groupBox1.Controls.Add(this.TObservTextBox);
            this.groupBox1.Controls.Add(this.TObserLabel);
            this.groupBox1.Controls.Add(this.TCantidadTextBox);
            this.groupBox1.Controls.Add(this.TEnvioLabel);
            this.groupBox1.Controls.Add(this.TCantidadLabel);
            this.groupBox1.Controls.Add(this.TModeloLabel);
            this.groupBox1.Controls.Add(this.TMarca);
            this.groupBox1.Location = new System.Drawing.Point(75, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 312);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Pedido";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TProveLabel
            // 
            this.TProveLabel.AutoSize = true;
            this.TProveLabel.Location = new System.Drawing.Point(69, 25);
            this.TProveLabel.Name = "TProveLabel";
            this.TProveLabel.Size = new System.Drawing.Size(56, 13);
            this.TProveLabel.TabIndex = 32;
            this.TProveLabel.Text = "Proveedor";
            // 
            // TEnvioButtonUrgente
            // 
            this.TEnvioButtonUrgente.AutoSize = true;
            this.TEnvioButtonUrgente.Location = new System.Drawing.Point(251, 156);
            this.TEnvioButtonUrgente.Name = "TEnvioButtonUrgente";
            this.TEnvioButtonUrgente.Size = new System.Drawing.Size(63, 17);
            this.TEnvioButtonUrgente.TabIndex = 31;
            this.TEnvioButtonUrgente.TabStop = true;
            this.TEnvioButtonUrgente.Text = "Urgente";
            this.TEnvioButtonUrgente.UseVisualStyleBackColor = true;
            // 
            // TEnvioButtonOrdinario
            // 
            this.TEnvioButtonOrdinario.AutoSize = true;
            this.TEnvioButtonOrdinario.Location = new System.Drawing.Point(167, 156);
            this.TEnvioButtonOrdinario.Name = "TEnvioButtonOrdinario";
            this.TEnvioButtonOrdinario.Size = new System.Drawing.Size(67, 17);
            this.TEnvioButtonOrdinario.TabIndex = 30;
            this.TEnvioButtonOrdinario.TabStop = true;
            this.TEnvioButtonOrdinario.Text = "Ordinario";
            this.TEnvioButtonOrdinario.UseVisualStyleBackColor = true;
            // 
            // TObservTextBox
            // 
            this.TObservTextBox.Location = new System.Drawing.Point(165, 196);
            this.TObservTextBox.Multiline = true;
            this.TObservTextBox.Name = "TObservTextBox";
            this.TObservTextBox.Size = new System.Drawing.Size(248, 86);
            this.TObservTextBox.TabIndex = 29;
            // 
            // TObserLabel
            // 
            this.TObserLabel.AutoSize = true;
            this.TObserLabel.Location = new System.Drawing.Point(66, 199);
            this.TObserLabel.Name = "TObserLabel";
            this.TObserLabel.Size = new System.Drawing.Size(78, 13);
            this.TObserLabel.TabIndex = 28;
            this.TObserLabel.Text = "Observaciones";
            // 
            // TCantidadTextBox
            // 
            this.TCantidadTextBox.Location = new System.Drawing.Point(165, 124);
            this.TCantidadTextBox.Name = "TCantidadTextBox";
            this.TCantidadTextBox.Size = new System.Drawing.Size(152, 20);
            this.TCantidadTextBox.TabIndex = 27;
            // 
            // TEnvioLabel
            // 
            this.TEnvioLabel.AutoSize = true;
            this.TEnvioLabel.Location = new System.Drawing.Point(66, 160);
            this.TEnvioLabel.Name = "TEnvioLabel";
            this.TEnvioLabel.Size = new System.Drawing.Size(74, 13);
            this.TEnvioLabel.TabIndex = 24;
            this.TEnvioLabel.Text = "Tipo de envío";
            // 
            // TCantidadLabel
            // 
            this.TCantidadLabel.AutoSize = true;
            this.TCantidadLabel.Location = new System.Drawing.Point(66, 126);
            this.TCantidadLabel.Name = "TCantidadLabel";
            this.TCantidadLabel.Size = new System.Drawing.Size(49, 13);
            this.TCantidadLabel.TabIndex = 23;
            this.TCantidadLabel.Text = "Cantidad";
            // 
            // TModeloLabel
            // 
            this.TModeloLabel.AutoSize = true;
            this.TModeloLabel.Location = new System.Drawing.Point(69, 92);
            this.TModeloLabel.Name = "TModeloLabel";
            this.TModeloLabel.Size = new System.Drawing.Size(42, 13);
            this.TModeloLabel.TabIndex = 22;
            this.TModeloLabel.Text = "Modelo";
            // 
            // TMarca
            // 
            this.TMarca.AutoSize = true;
            this.TMarca.Location = new System.Drawing.Point(69, 58);
            this.TMarca.Name = "TMarca";
            this.TMarca.Size = new System.Drawing.Size(37, 13);
            this.TMarca.TabIndex = 21;
            this.TMarca.Text = "Marca";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.TDateTimePickerFecha);
            this.groupBox2.Controls.Add(this.TLabelFecha);
            this.groupBox2.Controls.Add(this.TEstadoTextBox);
            this.groupBox2.Controls.Add(this.TEstadoLabel);
            this.groupBox2.Controls.Add(this.TVendedorText);
            this.groupBox2.Controls.Add(this.TEmpLabel);
            this.groupBox2.Controls.Add(this.TIDlabel);
            this.groupBox2.Controls.Add(this.TIDtextBox);
            this.groupBox2.Location = new System.Drawing.Point(98, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 89);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos transacción";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // TDateTimePickerFecha
            // 
            this.TDateTimePickerFecha.CalendarMonthBackground = System.Drawing.Color.White;
            this.TDateTimePickerFecha.CustomFormat = "";
            this.TDateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TDateTimePickerFecha.Location = new System.Drawing.Point(264, 58);
            this.TDateTimePickerFecha.Name = "TDateTimePickerFecha";
            this.TDateTimePickerFecha.Size = new System.Drawing.Size(90, 20);
            this.TDateTimePickerFecha.TabIndex = 31;
            // 
            // TLabelFecha
            // 
            this.TLabelFecha.AutoSize = true;
            this.TLabelFecha.Location = new System.Drawing.Point(218, 60);
            this.TLabelFecha.Name = "TLabelFecha";
            this.TLabelFecha.Size = new System.Drawing.Size(40, 13);
            this.TLabelFecha.TabIndex = 29;
            this.TLabelFecha.Text = "Fecha:";
            // 
            // TEstadoTextBox
            // 
            this.TEstadoTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.TEstadoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEstadoTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.TEstadoTextBox.Location = new System.Drawing.Point(96, 58);
            this.TEstadoTextBox.Name = "TEstadoTextBox";
            this.TEstadoTextBox.ReadOnly = true;
            this.TEstadoTextBox.Size = new System.Drawing.Size(84, 20);
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
            // TVendedorText
            // 
            this.TVendedorText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TVendedorText.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.TVendedorText.Location = new System.Drawing.Point(264, 33);
            this.TVendedorText.Name = "TVendedorText";
            this.TVendedorText.ReadOnly = true;
            this.TVendedorText.Size = new System.Drawing.Size(146, 20);
            this.TVendedorText.TabIndex = 26;
            // 
            // TEmpLabel
            // 
            this.TEmpLabel.AutoSize = true;
            this.TEmpLabel.Location = new System.Drawing.Point(202, 33);
            this.TEmpLabel.Name = "TEmpLabel";
            this.TEmpLabel.Size = new System.Drawing.Size(54, 13);
            this.TEmpLabel.TabIndex = 25;
            this.TEmpLabel.Text = "Empleado\r\n";
            // 
            // TIDlabel
            // 
            this.TIDlabel.AutoSize = true;
            this.TIDlabel.Location = new System.Drawing.Point(13, 33);
            this.TIDlabel.Name = "TIDlabel";
            this.TIDlabel.Size = new System.Drawing.Size(79, 13);
            this.TIDlabel.TabIndex = 24;
            this.TIDlabel.Text = "ID transacción:";
            // 
            // TIDtextBox
            // 
            this.TIDtextBox.BackColor = System.Drawing.SystemColors.Control;
            this.TIDtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TIDtextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.TIDtextBox.Location = new System.Drawing.Point(96, 33);
            this.TIDtextBox.Name = "TIDtextBox";
            this.TIDtextBox.ReadOnly = true;
            this.TIDtextBox.Size = new System.Drawing.Size(84, 20);
            this.TIDtextBox.TabIndex = 23;
            // 
            // TProveecomboBox1
            // 
            this.TProveecomboBox1.FormattingEnabled = true;
            this.TProveecomboBox1.Location = new System.Drawing.Point(165, 22);
            this.TProveecomboBox1.Name = "TProveecomboBox1";
            this.TProveecomboBox1.Size = new System.Drawing.Size(179, 21);
            this.TProveecomboBox1.TabIndex = 34;
            // 
            // TMarcacomboBox2
            // 
            this.TMarcacomboBox2.FormattingEnabled = true;
            this.TMarcacomboBox2.Location = new System.Drawing.Point(165, 55);
            this.TMarcacomboBox2.Name = "TMarcacomboBox2";
            this.TMarcacomboBox2.Size = new System.Drawing.Size(179, 21);
            this.TMarcacomboBox2.TabIndex = 35;
            // 
            // TModelocomboBox3
            // 
            this.TModelocomboBox3.FormattingEnabled = true;
            this.TModelocomboBox3.Location = new System.Drawing.Point(165, 89);
            this.TModelocomboBox3.Name = "TModelocomboBox3";
            this.TModelocomboBox3.Size = new System.Drawing.Size(177, 21);
            this.TModelocomboBox3.TabIndex = 36;
            // 
            // TErrorProvee
            // 
            this.TErrorProvee.AutoSize = true;
            this.TErrorProvee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TErrorProvee.ForeColor = System.Drawing.Color.Red;
            this.TErrorProvee.Location = new System.Drawing.Point(350, 30);
            this.TErrorProvee.Name = "TErrorProvee";
            this.TErrorProvee.Size = new System.Drawing.Size(0, 13);
            this.TErrorProvee.TabIndex = 37;
            this.TErrorProvee.Click += new System.EventHandler(this.label1_Click);
            // 
            // TErrorMarca
            // 
            this.TErrorMarca.AutoSize = true;
            this.TErrorMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TErrorMarca.ForeColor = System.Drawing.Color.Red;
            this.TErrorMarca.Location = new System.Drawing.Point(350, 63);
            this.TErrorMarca.Name = "TErrorMarca";
            this.TErrorMarca.Size = new System.Drawing.Size(0, 13);
            this.TErrorMarca.TabIndex = 38;
            // 
            // TErrorModelo
            // 
            this.TErrorModelo.AutoSize = true;
            this.TErrorModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TErrorModelo.ForeColor = System.Drawing.Color.Red;
            this.TErrorModelo.Location = new System.Drawing.Point(349, 92);
            this.TErrorModelo.Name = "TErrorModelo";
            this.TErrorModelo.Size = new System.Drawing.Size(0, 13);
            this.TErrorModelo.TabIndex = 39;
            // 
            // TErrorObser
            // 
            this.TErrorObser.AutoSize = true;
            this.TErrorObser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TErrorObser.ForeColor = System.Drawing.Color.Red;
            this.TErrorObser.Location = new System.Drawing.Point(420, 199);
            this.TErrorObser.Name = "TErrorObser";
            this.TErrorObser.Size = new System.Drawing.Size(0, 13);
            this.TErrorObser.TabIndex = 40;
            // 
            // GestionPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AlquilerCoches.Properties.Resources.rentacar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(666, 502);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TBorrarbutton3);
            this.Controls.Add(this.TSalirbutton2);
            this.Controls.Add(this.TAceptarbutton1);
            this.Name = "GestionPedidos";
            this.Text = "Gestión de Pedidos";
            this.Load += new System.EventHandler(this.GestionPedidos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TAceptarbutton1;
        private System.Windows.Forms.Button TSalirbutton2;
        private System.Windows.Forms.Button TBorrarbutton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label TProveLabel;
        private System.Windows.Forms.RadioButton TEnvioButtonUrgente;
        private System.Windows.Forms.RadioButton TEnvioButtonOrdinario;
        private System.Windows.Forms.TextBox TObservTextBox;
        private System.Windows.Forms.Label TObserLabel;
        private System.Windows.Forms.TextBox TCantidadTextBox;
        private System.Windows.Forms.Label TEnvioLabel;
        private System.Windows.Forms.Label TCantidadLabel;
        private System.Windows.Forms.Label TModeloLabel;
        private System.Windows.Forms.Label TMarca;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TEstadoTextBox;
        private System.Windows.Forms.Label TEstadoLabel;
        private System.Windows.Forms.TextBox TVendedorText;
        private System.Windows.Forms.Label TEmpLabel;
        private System.Windows.Forms.Label TIDlabel;
        private System.Windows.Forms.TextBox TIDtextBox;
        private System.Windows.Forms.Label TLabelFecha;
        public System.Windows.Forms.DateTimePicker TDateTimePickerFecha;
        private System.Windows.Forms.ComboBox TModelocomboBox3;
        private System.Windows.Forms.ComboBox TMarcacomboBox2;
        private System.Windows.Forms.ComboBox TProveecomboBox1;
        private System.Windows.Forms.Label TErrorProvee;
        private System.Windows.Forms.Label TErrorMarca;
        private System.Windows.Forms.Label TErrorObser;
        private System.Windows.Forms.Label TErrorModelo;
    }
}