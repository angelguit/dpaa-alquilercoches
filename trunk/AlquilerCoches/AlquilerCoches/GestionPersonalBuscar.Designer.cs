﻿namespace AlquilerCoches
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
            this.TTextBoxPuestoAc = new System.Windows.Forms.TextBox();
            this.TTextBoxApellidos = new System.Windows.Forms.TextBox();
            this.TTextBoxNombre = new System.Windows.Forms.TextBox();
            this.TTextBoxDNI = new System.Windows.Forms.TextBox();
            this.TLabelPuestoAc = new System.Windows.Forms.Label();
            this.TLabelApellidos = new System.Windows.Forms.Label();
            this.TLabelNombre = new System.Windows.Forms.Label();
            this.TLabelDNI = new System.Windows.Forms.Label();
            this.TButtonAlta = new System.Windows.Forms.Button();
            this.TDataGridViewPersonal = new System.Windows.Forms.DataGridView();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TDataGridViewPersonal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TButtonEliminar
            // 
            this.TButtonEliminar.Location = new System.Drawing.Point(141, 390);
            this.TButtonEliminar.Name = "TButtonEliminar";
            this.TButtonEliminar.Size = new System.Drawing.Size(75, 23);
            this.TButtonEliminar.TabIndex = 23;
            this.TButtonEliminar.Text = "Eliminar";
            this.TButtonEliminar.UseVisualStyleBackColor = true;
            this.TButtonEliminar.Visible = false;
            // 
            // TButtonBuscar
            // 
            this.TButtonBuscar.Location = new System.Drawing.Point(36, 390);
            this.TButtonBuscar.Name = "TButtonBuscar";
            this.TButtonBuscar.Size = new System.Drawing.Size(75, 23);
            this.TButtonBuscar.TabIndex = 22;
            this.TButtonBuscar.Text = "Buscar";
            this.TButtonBuscar.UseVisualStyleBackColor = true;
            this.TButtonBuscar.Click += new System.EventHandler(this.TButtonBuscar_Click);
            // 
            // TTextBoxPuestoAc
            // 
            this.TTextBoxPuestoAc.Location = new System.Drawing.Point(305, 321);
            this.TTextBoxPuestoAc.Name = "TTextBoxPuestoAc";
            this.TTextBoxPuestoAc.Size = new System.Drawing.Size(100, 20);
            this.TTextBoxPuestoAc.TabIndex = 21;
            this.TTextBoxPuestoAc.Leave += new System.EventHandler(this.TTextBoxPuestoAc_Leave);
            // 
            // TTextBoxApellidos
            // 
            this.TTextBoxApellidos.Location = new System.Drawing.Point(305, 282);
            this.TTextBoxApellidos.Name = "TTextBoxApellidos";
            this.TTextBoxApellidos.Size = new System.Drawing.Size(100, 20);
            this.TTextBoxApellidos.TabIndex = 20;
            this.TTextBoxApellidos.Leave += new System.EventHandler(this.TTextBoxApellidos_Leave);
            // 
            // TTextBoxNombre
            // 
            this.TTextBoxNombre.Location = new System.Drawing.Point(84, 321);
            this.TTextBoxNombre.Name = "TTextBoxNombre";
            this.TTextBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.TTextBoxNombre.TabIndex = 19;
            this.TTextBoxNombre.Leave += new System.EventHandler(this.TTextBoxNombre_Leave);
            // 
            // TTextBoxDNI
            // 
            this.TTextBoxDNI.Location = new System.Drawing.Point(84, 282);
            this.TTextBoxDNI.Name = "TTextBoxDNI";
            this.TTextBoxDNI.Size = new System.Drawing.Size(100, 20);
            this.TTextBoxDNI.TabIndex = 18;
            this.TTextBoxDNI.Leave += new System.EventHandler(this.TTextBoxDNI_Leave);
            // 
            // TLabelPuestoAc
            // 
            this.TLabelPuestoAc.AutoSize = true;
            this.TLabelPuestoAc.BackColor = System.Drawing.Color.Transparent;
            this.TLabelPuestoAc.Location = new System.Drawing.Point(240, 329);
            this.TLabelPuestoAc.Name = "TLabelPuestoAc";
            this.TLabelPuestoAc.Size = new System.Drawing.Size(59, 13);
            this.TLabelPuestoAc.TabIndex = 17;
            this.TLabelPuestoAc.Text = "Puesto Ac.";
            // 
            // TLabelApellidos
            // 
            this.TLabelApellidos.AutoSize = true;
            this.TLabelApellidos.BackColor = System.Drawing.Color.Transparent;
            this.TLabelApellidos.Location = new System.Drawing.Point(250, 290);
            this.TLabelApellidos.Name = "TLabelApellidos";
            this.TLabelApellidos.Size = new System.Drawing.Size(49, 13);
            this.TLabelApellidos.TabIndex = 16;
            this.TLabelApellidos.Text = "Apellidos";
            // 
            // TLabelNombre
            // 
            this.TLabelNombre.AutoSize = true;
            this.TLabelNombre.BackColor = System.Drawing.Color.Transparent;
            this.TLabelNombre.Location = new System.Drawing.Point(33, 329);
            this.TLabelNombre.Name = "TLabelNombre";
            this.TLabelNombre.Size = new System.Drawing.Size(44, 13);
            this.TLabelNombre.TabIndex = 15;
            this.TLabelNombre.Text = "Nombre";
            // 
            // TLabelDNI
            // 
            this.TLabelDNI.AutoSize = true;
            this.TLabelDNI.BackColor = System.Drawing.Color.Transparent;
            this.TLabelDNI.Location = new System.Drawing.Point(51, 290);
            this.TLabelDNI.Name = "TLabelDNI";
            this.TLabelDNI.Size = new System.Drawing.Size(26, 13);
            this.TLabelDNI.TabIndex = 14;
            this.TLabelDNI.Text = "DNI";
            // 
            // TButtonAlta
            // 
            this.TButtonAlta.Location = new System.Drawing.Point(255, 390);
            this.TButtonAlta.Name = "TButtonAlta";
            this.TButtonAlta.Size = new System.Drawing.Size(75, 23);
            this.TButtonAlta.TabIndex = 13;
            this.TButtonAlta.Text = "Dar de alta";
            this.TButtonAlta.UseVisualStyleBackColor = true;
            // 
            // TDataGridViewPersonal
            // 
            this.TDataGridViewPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TDataGridViewPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI,
            this.Nombre,
            this.Apellidos,
            this.Telefono,
            this.Email});
            this.TDataGridViewPersonal.Location = new System.Drawing.Point(64, 35);
            this.TDataGridViewPersonal.Name = "TDataGridViewPersonal";
            this.TDataGridViewPersonal.Size = new System.Drawing.Size(544, 209);
            this.TDataGridViewPersonal.TabIndex = 12;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // GestionPersonalBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AlquilerCoches.Properties.Resources.rentacar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(662, 447);
            this.Controls.Add(this.TButtonEliminar);
            this.Controls.Add(this.TButtonBuscar);
            this.Controls.Add(this.TTextBoxPuestoAc);
            this.Controls.Add(this.TTextBoxApellidos);
            this.Controls.Add(this.TTextBoxNombre);
            this.Controls.Add(this.TTextBoxDNI);
            this.Controls.Add(this.TLabelPuestoAc);
            this.Controls.Add(this.TLabelApellidos);
            this.Controls.Add(this.TLabelNombre);
            this.Controls.Add(this.TLabelDNI);
            this.Controls.Add(this.TButtonAlta);
            this.Controls.Add(this.TDataGridViewPersonal);
            this.Name = "GestionPersonalBuscar";
            this.Text = "GestionPersonalBuscar";
            ((System.ComponentModel.ISupportInitialize)(this.TDataGridViewPersonal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.Button TButtonEliminar;
        private System.Windows.Forms.Button TButtonBuscar;
        private System.Windows.Forms.TextBox TTextBoxPuestoAc;
        private System.Windows.Forms.TextBox TTextBoxApellidos;
        private System.Windows.Forms.TextBox TTextBoxNombre;
        private System.Windows.Forms.TextBox TTextBoxDNI;
        private System.Windows.Forms.Label TLabelPuestoAc;
        private System.Windows.Forms.Label TLabelApellidos;
        private System.Windows.Forms.Label TLabelNombre;
        private System.Windows.Forms.Label TLabelDNI;
        private System.Windows.Forms.Button TButtonAlta;
        private System.Windows.Forms.DataGridView TDataGridViewPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}