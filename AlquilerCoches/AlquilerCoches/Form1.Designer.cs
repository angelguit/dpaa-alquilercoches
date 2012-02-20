namespace AlquilerCoches
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TbotonOK = new System.Windows.Forms.Button();
            this.TLabelUsuario = new System.Windows.Forms.Label();
            this.TTextBoxUsuario = new System.Windows.Forms.TextBox();
            this.TLabelContrasenya = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TButtonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbotonOK
            // 
            this.TbotonOK.Location = new System.Drawing.Point(62, 178);
            this.TbotonOK.Name = "TbotonOK";
            this.TbotonOK.Size = new System.Drawing.Size(75, 23);
            this.TbotonOK.TabIndex = 0;
            this.TbotonOK.Text = "OK";
            this.TbotonOK.UseVisualStyleBackColor = true;
            // 
            // TLabelUsuario
            // 
            this.TLabelUsuario.AutoSize = true;
            this.TLabelUsuario.Location = new System.Drawing.Point(59, 77);
            this.TLabelUsuario.Name = "TLabelUsuario";
            this.TLabelUsuario.Size = new System.Drawing.Size(59, 13);
            this.TLabelUsuario.TabIndex = 1;
            this.TLabelUsuario.Text = "USUARIO:";
            // 
            // TTextBoxUsuario
            // 
            this.TTextBoxUsuario.Location = new System.Drawing.Point(141, 74);
            this.TTextBoxUsuario.Name = "TTextBoxUsuario";
            this.TTextBoxUsuario.Size = new System.Drawing.Size(100, 20);
            this.TTextBoxUsuario.TabIndex = 2;
            this.TTextBoxUsuario.Text = "Usuario";
            // 
            // TLabelContrasenya
            // 
            this.TLabelContrasenya.AutoSize = true;
            this.TLabelContrasenya.Location = new System.Drawing.Point(34, 118);
            this.TLabelContrasenya.Name = "TLabelContrasenya";
            this.TLabelContrasenya.Size = new System.Drawing.Size(84, 13);
            this.TLabelContrasenya.TabIndex = 3;
            this.TLabelContrasenya.Text = "CONTRASEÑA:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "contraseña";
            // 
            // TButtonSalir
            // 
            this.TButtonSalir.Location = new System.Drawing.Point(166, 178);
            this.TButtonSalir.Name = "TButtonSalir";
            this.TButtonSalir.Size = new System.Drawing.Size(75, 23);
            this.TButtonSalir.TabIndex = 5;
            this.TButtonSalir.Text = "SALIR";
            this.TButtonSalir.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.TButtonSalir);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TLabelContrasenya);
            this.Controls.Add(this.TTextBoxUsuario);
            this.Controls.Add(this.TLabelUsuario);
            this.Controls.Add(this.TbotonOK);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TbotonOK;
        private System.Windows.Forms.Label TLabelUsuario;
        private System.Windows.Forms.TextBox TTextBoxUsuario;
        private System.Windows.Forms.Label TLabelContrasenya;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button TButtonSalir;
    }
}

