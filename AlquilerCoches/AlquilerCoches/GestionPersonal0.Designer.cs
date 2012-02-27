namespace AlquilerCoches
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TButtonAlta = new System.Windows.Forms.Button();
            this.TLabelDNI = new System.Windows.Forms.Label();
            this.TLabelNombre = new System.Windows.Forms.Label();
            this.TLabelApellidos = new System.Windows.Forms.Label();
            this.TLabelPuestoAc = new System.Windows.Forms.Label();
            this.TTextBoxDNI = new System.Windows.Forms.TextBox();
            this.TTextBoxNombre = new System.Windows.Forms.TextBox();
            this.TTextBoxApellidos = new System.Windows.Forms.TextBox();
            this.TTextBoxPuestoAc = new System.Windows.Forms.TextBox();
            this.TButtonBuscar = new System.Windows.Forms.Button();
            this.TButtonEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI,
            this.Nombre,
            this.Apellidos});
            this.dataGridView1.Location = new System.Drawing.Point(30, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(582, 209);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // TButtonAlta
            // 
            this.TButtonAlta.Location = new System.Drawing.Point(514, 367);
            this.TButtonAlta.Name = "TButtonAlta";
            this.TButtonAlta.Size = new System.Drawing.Size(75, 23);
            this.TButtonAlta.TabIndex = 1;
            this.TButtonAlta.Text = "Dar de alta";
            this.TButtonAlta.UseVisualStyleBackColor = true;
            // 
            // TLabelDNI
            // 
            this.TLabelDNI.AutoSize = true;
            this.TLabelDNI.Location = new System.Drawing.Point(39, 267);
            this.TLabelDNI.Name = "TLabelDNI";
            this.TLabelDNI.Size = new System.Drawing.Size(26, 13);
            this.TLabelDNI.TabIndex = 2;
            this.TLabelDNI.Text = "DNI";
            // 
            // TLabelNombre
            // 
            this.TLabelNombre.AutoSize = true;
            this.TLabelNombre.Location = new System.Drawing.Point(21, 306);
            this.TLabelNombre.Name = "TLabelNombre";
            this.TLabelNombre.Size = new System.Drawing.Size(44, 13);
            this.TLabelNombre.TabIndex = 3;
            this.TLabelNombre.Text = "Nombre";
            // 
            // TLabelApellidos
            // 
            this.TLabelApellidos.AutoSize = true;
            this.TLabelApellidos.Location = new System.Drawing.Point(210, 266);
            this.TLabelApellidos.Name = "TLabelApellidos";
            this.TLabelApellidos.Size = new System.Drawing.Size(49, 13);
            this.TLabelApellidos.TabIndex = 4;
            this.TLabelApellidos.Text = "Apellidos";
            // 
            // TLabelPuestoAc
            // 
            this.TLabelPuestoAc.AutoSize = true;
            this.TLabelPuestoAc.Location = new System.Drawing.Point(200, 305);
            this.TLabelPuestoAc.Name = "TLabelPuestoAc";
            this.TLabelPuestoAc.Size = new System.Drawing.Size(59, 13);
            this.TLabelPuestoAc.TabIndex = 5;
            this.TLabelPuestoAc.Text = "Puesto Ac.";
            // 
            // TTextBoxDNI
            // 
            this.TTextBoxDNI.Location = new System.Drawing.Point(72, 259);
            this.TTextBoxDNI.Name = "TTextBoxDNI";
            this.TTextBoxDNI.Size = new System.Drawing.Size(100, 20);
            this.TTextBoxDNI.TabIndex = 6;
            // 
            // TTextBoxNombre
            // 
            this.TTextBoxNombre.Location = new System.Drawing.Point(72, 298);
            this.TTextBoxNombre.Name = "TTextBoxNombre";
            this.TTextBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.TTextBoxNombre.TabIndex = 7;
            // 
            // TTextBoxApellidos
            // 
            this.TTextBoxApellidos.Location = new System.Drawing.Point(265, 258);
            this.TTextBoxApellidos.Name = "TTextBoxApellidos";
            this.TTextBoxApellidos.Size = new System.Drawing.Size(100, 20);
            this.TTextBoxApellidos.TabIndex = 8;
            // 
            // TTextBoxPuestoAc
            // 
            this.TTextBoxPuestoAc.Location = new System.Drawing.Point(265, 297);
            this.TTextBoxPuestoAc.Name = "TTextBoxPuestoAc";
            this.TTextBoxPuestoAc.Size = new System.Drawing.Size(100, 20);
            this.TTextBoxPuestoAc.TabIndex = 9;
            // 
            // TButtonBuscar
            // 
            this.TButtonBuscar.Location = new System.Drawing.Point(24, 367);
            this.TButtonBuscar.Name = "TButtonBuscar";
            this.TButtonBuscar.Size = new System.Drawing.Size(75, 23);
            this.TButtonBuscar.TabIndex = 10;
            this.TButtonBuscar.Text = "Buscar";
            this.TButtonBuscar.UseVisualStyleBackColor = true;
            this.TButtonBuscar.Click += new System.EventHandler(this.TButtonBuscar_Click);
            // 
            // TButtonEliminar
            // 
            this.TButtonEliminar.Location = new System.Drawing.Point(129, 367);
            this.TButtonEliminar.Name = "TButtonEliminar";
            this.TButtonEliminar.Size = new System.Drawing.Size(75, 23);
            this.TButtonEliminar.TabIndex = 11;
            this.TButtonEliminar.Text = "Eliminar";
            this.TButtonEliminar.UseVisualStyleBackColor = true;
            this.TButtonEliminar.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 414);
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
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Gestion de Personal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.Button TButtonAlta;
        private System.Windows.Forms.Label TLabelDNI;
        private System.Windows.Forms.Label TLabelNombre;
        private System.Windows.Forms.Label TLabelApellidos;
        private System.Windows.Forms.Label TLabelPuestoAc;
        private System.Windows.Forms.TextBox TTextBoxDNI;
        private System.Windows.Forms.TextBox TTextBoxNombre;
        private System.Windows.Forms.TextBox TTextBoxApellidos;
        private System.Windows.Forms.TextBox TTextBoxPuestoAc;
        private System.Windows.Forms.Button TButtonBuscar;
        private System.Windows.Forms.Button TButtonEliminar;
    }
}