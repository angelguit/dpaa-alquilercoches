﻿namespace AlquilerCoches
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
            this.TButtonBuscar = new System.Windows.Forms.Button();
            this.TTextBoxProvincia = new System.Windows.Forms.TextBox();
            this.TTextBoxMarca = new System.Windows.Forms.TextBox();
            this.TTextBoxCIF = new System.Windows.Forms.TextBox();
            this.TLabelProvincia = new System.Windows.Forms.Label();
            this.TLabelMarca = new System.Windows.Forms.Label();
            this.TLabelCIF = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TTextBoxCiudad = new System.Windows.Forms.TextBox();
            this.TLabelCiudad = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TButtonEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TButtonBuscar
            // 
            this.TButtonBuscar.Location = new System.Drawing.Point(36, 544);
            this.TButtonBuscar.Name = "TButtonBuscar";
            this.TButtonBuscar.Size = new System.Drawing.Size(75, 23);
            this.TButtonBuscar.TabIndex = 46;
            this.TButtonBuscar.Text = "Buscar";
            this.TButtonBuscar.UseVisualStyleBackColor = true;
            this.TButtonBuscar.Click += new System.EventHandler(this.TButtonBuscar_Click);
            // 
            // TTextBoxProvincia
            // 
            this.TTextBoxProvincia.Location = new System.Drawing.Point(255, 25);
            this.TTextBoxProvincia.Name = "TTextBoxProvincia";
            this.TTextBoxProvincia.Size = new System.Drawing.Size(100, 20);
            this.TTextBoxProvincia.TabIndex = 44;
            // 
            // TTextBoxMarca
            // 
            this.TTextBoxMarca.Location = new System.Drawing.Point(62, 65);
            this.TTextBoxMarca.Name = "TTextBoxMarca";
            this.TTextBoxMarca.Size = new System.Drawing.Size(100, 20);
            this.TTextBoxMarca.TabIndex = 43;
            // 
            // TTextBoxCIF
            // 
            this.TTextBoxCIF.Location = new System.Drawing.Point(62, 26);
            this.TTextBoxCIF.Name = "TTextBoxCIF";
            this.TTextBoxCIF.Size = new System.Drawing.Size(100, 20);
            this.TTextBoxCIF.TabIndex = 42;
            // 
            // TLabelProvincia
            // 
            this.TLabelProvincia.AutoSize = true;
            this.TLabelProvincia.Location = new System.Drawing.Point(189, 33);
            this.TLabelProvincia.Name = "TLabelProvincia";
            this.TLabelProvincia.Size = new System.Drawing.Size(51, 13);
            this.TLabelProvincia.TabIndex = 40;
            this.TLabelProvincia.Text = "Provincia";
            // 
            // TLabelMarca
            // 
            this.TLabelMarca.AutoSize = true;
            this.TLabelMarca.Location = new System.Drawing.Point(11, 73);
            this.TLabelMarca.Name = "TLabelMarca";
            this.TLabelMarca.Size = new System.Drawing.Size(37, 13);
            this.TLabelMarca.TabIndex = 39;
            this.TLabelMarca.Text = "Marca";
            // 
            // TLabelCIF
            // 
            this.TLabelCIF.AutoSize = true;
            this.TLabelCIF.BackColor = System.Drawing.Color.Transparent;
            this.TLabelCIF.Location = new System.Drawing.Point(29, 34);
            this.TLabelCIF.Name = "TLabelCIF";
            this.TLabelCIF.Size = new System.Drawing.Size(23, 13);
            this.TLabelCIF.TabIndex = 38;
            this.TLabelCIF.Text = "CIF";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI,
            this.Marca,
            this.Provincia,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(36, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(722, 209);
            this.dataGridView1.TabIndex = 36;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            // 
            // Provincia
            // 
            this.Provincia.HeaderText = "Direccion";
            this.Provincia.Name = "Provincia";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Telefono";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Email";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ciudad";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Provincia";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Horario";
            this.Column5.Name = "Column5";
            // 
            // TTextBoxCiudad
            // 
            this.TTextBoxCiudad.Location = new System.Drawing.Point(255, 65);
            this.TTextBoxCiudad.Name = "TTextBoxCiudad";
            this.TTextBoxCiudad.Size = new System.Drawing.Size(100, 20);
            this.TTextBoxCiudad.TabIndex = 49;
            this.TTextBoxCiudad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TLabelCiudad
            // 
            this.TLabelCiudad.AutoSize = true;
            this.TLabelCiudad.Location = new System.Drawing.Point(200, 73);
            this.TLabelCiudad.Name = "TLabelCiudad";
            this.TLabelCiudad.Size = new System.Drawing.Size(40, 13);
            this.TLabelCiudad.TabIndex = 48;
            this.TLabelCiudad.Text = "Ciudad";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 544);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 50;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.TTextBoxCiudad);
            this.groupBox1.Controls.Add(this.TLabelCiudad);
            this.groupBox1.Controls.Add(this.TTextBoxProvincia);
            this.groupBox1.Controls.Add(this.TTextBoxMarca);
            this.groupBox1.Controls.Add(this.TTextBoxCIF);
            this.groupBox1.Controls.Add(this.TLabelProvincia);
            this.groupBox1.Controls.Add(this.TLabelMarca);
            this.groupBox1.Controls.Add(this.TLabelCIF);
            this.groupBox1.Location = new System.Drawing.Point(36, 315);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 117);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            // 
            // TButtonEliminar
            // 
            this.TButtonEliminar.Location = new System.Drawing.Point(132, 544);
            this.TButtonEliminar.Name = "TButtonEliminar";
            this.TButtonEliminar.Size = new System.Drawing.Size(75, 23);
            this.TButtonEliminar.TabIndex = 52;
            this.TButtonEliminar.Text = "Eliminar";
            this.TButtonEliminar.UseVisualStyleBackColor = true;
            // 
            // GestionProveedoresBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AlquilerCoches.Properties.Resources.rentacar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.TButtonEliminar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TButtonBuscar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GestionProveedoresBuscar";
            this.Text = "GestionProveedoresBuscar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TButtonBuscar;
        private System.Windows.Forms.TextBox TTextBoxProvincia;
        private System.Windows.Forms.TextBox TTextBoxMarca;
        private System.Windows.Forms.TextBox TTextBoxCIF;
        private System.Windows.Forms.Label TLabelProvincia;
        private System.Windows.Forms.Label TLabelMarca;
        private System.Windows.Forms.Label TLabelCIF;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TTextBoxCiudad;
        private System.Windows.Forms.Label TLabelCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button TButtonEliminar;
    }
}