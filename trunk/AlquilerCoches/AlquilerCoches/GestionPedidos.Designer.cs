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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TProveTextBox = new System.Windows.Forms.TextBox();
            this.TProveLabel = new System.Windows.Forms.Label();
            this.TEnvioButtonUrgente = new System.Windows.Forms.RadioButton();
            this.TEnvioButtonOrdinario = new System.Windows.Forms.RadioButton();
            this.TObservTextBox = new System.Windows.Forms.TextBox();
            this.TObserLabel = new System.Windows.Forms.Label();
            this.TCantidadTextBox = new System.Windows.Forms.TextBox();
            this.TModeloTextBox = new System.Windows.Forms.TextBox();
            this.TNameTextBox = new System.Windows.Forms.TextBox();
            this.TEnvioLabel = new System.Windows.Forms.Label();
            this.TCantidadLabel = new System.Windows.Forms.Label();
            this.TModeloLabel = new System.Windows.Forms.Label();
            this.TNombreLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TEstadoTextBox = new System.Windows.Forms.TextBox();
            this.TEstadoLabel = new System.Windows.Forms.Label();
            this.TVendedorText = new System.Windows.Forms.TextBox();
            this.TVendLabel = new System.Windows.Forms.Label();
            this.TIDlabel = new System.Windows.Forms.Label();
            this.TIDtextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "ACEPTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(261, 453);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(429, 453);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "BORRAR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TProveTextBox);
            this.groupBox1.Controls.Add(this.TProveLabel);
            this.groupBox1.Controls.Add(this.TEnvioButtonUrgente);
            this.groupBox1.Controls.Add(this.TEnvioButtonOrdinario);
            this.groupBox1.Controls.Add(this.TObservTextBox);
            this.groupBox1.Controls.Add(this.TObserLabel);
            this.groupBox1.Controls.Add(this.TCantidadTextBox);
            this.groupBox1.Controls.Add(this.TModeloTextBox);
            this.groupBox1.Controls.Add(this.TNameTextBox);
            this.groupBox1.Controls.Add(this.TEnvioLabel);
            this.groupBox1.Controls.Add(this.TCantidadLabel);
            this.groupBox1.Controls.Add(this.TModeloLabel);
            this.groupBox1.Controls.Add(this.TNombreLabel);
            this.groupBox1.Location = new System.Drawing.Point(75, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 312);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Pedido";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TProveTextBox
            // 
            this.TProveTextBox.Location = new System.Drawing.Point(165, 17);
            this.TProveTextBox.Name = "TProveTextBox";
            this.TProveTextBox.Size = new System.Drawing.Size(152, 20);
            this.TProveTextBox.TabIndex = 33;
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
            // TModeloTextBox
            // 
            this.TModeloTextBox.Location = new System.Drawing.Point(165, 86);
            this.TModeloTextBox.Name = "TModeloTextBox";
            this.TModeloTextBox.Size = new System.Drawing.Size(152, 20);
            this.TModeloTextBox.TabIndex = 26;
            // 
            // TNameTextBox
            // 
            this.TNameTextBox.Location = new System.Drawing.Point(165, 51);
            this.TNameTextBox.Name = "TNameTextBox";
            this.TNameTextBox.Size = new System.Drawing.Size(152, 20);
            this.TNameTextBox.TabIndex = 25;
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
            // TNombreLabel
            // 
            this.TNombreLabel.AutoSize = true;
            this.TNombreLabel.Location = new System.Drawing.Point(69, 58);
            this.TNombreLabel.Name = "TNombreLabel";
            this.TNombreLabel.Size = new System.Drawing.Size(44, 13);
            this.TNombreLabel.TabIndex = 21;
            this.TNombreLabel.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TEstadoTextBox);
            this.groupBox2.Controls.Add(this.TEstadoLabel);
            this.groupBox2.Controls.Add(this.TVendedorText);
            this.groupBox2.Controls.Add(this.TVendLabel);
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
            // TEstadoTextBox
            // 
            this.TEstadoTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.TEstadoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TEstadoTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.TEstadoTextBox.Location = new System.Drawing.Point(96, 58);
            this.TEstadoTextBox.Name = "TEstadoTextBox";
            this.TEstadoTextBox.ReadOnly = true;
            this.TEstadoTextBox.Size = new System.Drawing.Size(84, 13);
            this.TEstadoTextBox.TabIndex = 28;
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
            this.TVendedorText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TVendedorText.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.TVendedorText.Location = new System.Drawing.Point(264, 33);
            this.TVendedorText.Name = "TVendedorText";
            this.TVendedorText.ReadOnly = true;
            this.TVendedorText.Size = new System.Drawing.Size(166, 13);
            this.TVendedorText.TabIndex = 26;
            // 
            // TVendLabel
            // 
            this.TVendLabel.AutoSize = true;
            this.TVendLabel.Location = new System.Drawing.Point(202, 33);
            this.TVendLabel.Name = "TVendLabel";
            this.TVendLabel.Size = new System.Drawing.Size(56, 13);
            this.TVendLabel.TabIndex = 25;
            this.TVendLabel.Text = "Vendedor:";
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
            this.TIDtextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TIDtextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.TIDtextBox.Location = new System.Drawing.Point(96, 33);
            this.TIDtextBox.Name = "TIDtextBox";
            this.TIDtextBox.ReadOnly = true;
            this.TIDtextBox.Size = new System.Drawing.Size(84, 13);
            this.TIDtextBox.TabIndex = 23;
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
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TProveTextBox;
        private System.Windows.Forms.Label TProveLabel;
        private System.Windows.Forms.RadioButton TEnvioButtonUrgente;
        private System.Windows.Forms.RadioButton TEnvioButtonOrdinario;
        private System.Windows.Forms.TextBox TObservTextBox;
        private System.Windows.Forms.Label TObserLabel;
        private System.Windows.Forms.TextBox TCantidadTextBox;
        private System.Windows.Forms.TextBox TModeloTextBox;
        private System.Windows.Forms.TextBox TNameTextBox;
        private System.Windows.Forms.Label TEnvioLabel;
        private System.Windows.Forms.Label TCantidadLabel;
        private System.Windows.Forms.Label TModeloLabel;
        private System.Windows.Forms.Label TNombreLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TEstadoTextBox;
        private System.Windows.Forms.Label TEstadoLabel;
        private System.Windows.Forms.TextBox TVendedorText;
        private System.Windows.Forms.Label TVendLabel;
        private System.Windows.Forms.Label TIDlabel;
        private System.Windows.Forms.TextBox TIDtextBox;
    }
}