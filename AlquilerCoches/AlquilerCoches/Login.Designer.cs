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
            this.components = new System.ComponentModel.Container();
            this.TbotonOK = new System.Windows.Forms.Button();
            this.TLabelUsuario = new System.Windows.Forms.Label();
            this.TTextBoxUsuario = new System.Windows.Forms.TextBox();
            this.TLabelContrasenya = new System.Windows.Forms.Label();
            this.TTextBoxPassword = new System.Windows.Forms.TextBox();
            this.TButtonSalir = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TLabelError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TbotonOK
            // 
            this.TbotonOK.Location = new System.Drawing.Point(102, 126);
            this.TbotonOK.Name = "TbotonOK";
            this.TbotonOK.Size = new System.Drawing.Size(75, 23);
            this.TbotonOK.TabIndex = 0;
            this.TbotonOK.Text = "OK";
            this.TbotonOK.UseVisualStyleBackColor = true;
            this.TbotonOK.Click += new System.EventHandler(this.TbotonOK_Click);
            // 
            // TLabelUsuario
            // 
            this.TLabelUsuario.AutoSize = true;
            this.TLabelUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.TLabelUsuario.Location = new System.Drawing.Point(99, 32);
            this.TLabelUsuario.Name = "TLabelUsuario";
            this.TLabelUsuario.Size = new System.Drawing.Size(59, 13);
            this.TLabelUsuario.TabIndex = 1;
            this.TLabelUsuario.Text = "USUARIO:";
            // 
            // TTextBoxUsuario
            // 
            this.TTextBoxUsuario.Location = new System.Drawing.Point(181, 29);
            this.TTextBoxUsuario.Name = "TTextBoxUsuario";
            this.TTextBoxUsuario.Size = new System.Drawing.Size(100, 20);
            this.TTextBoxUsuario.TabIndex = 2;
            this.TTextBoxUsuario.Text = "Usuario";
            this.TTextBoxUsuario.DoubleClick += new System.EventHandler(this.TTextBoxUsuario_DoubleClick);
            // 
            // TLabelContrasenya
            // 
            this.TLabelContrasenya.AutoSize = true;
            this.TLabelContrasenya.BackColor = System.Drawing.SystemColors.Window;
            this.TLabelContrasenya.Location = new System.Drawing.Point(74, 68);
            this.TLabelContrasenya.Name = "TLabelContrasenya";
            this.TLabelContrasenya.Size = new System.Drawing.Size(84, 13);
            this.TLabelContrasenya.TabIndex = 3;
            this.TLabelContrasenya.Text = "CONTRASEÑA:";
            // 
            // TTextBoxPassword
            // 
            this.TTextBoxPassword.Location = new System.Drawing.Point(181, 65);
            this.TTextBoxPassword.Name = "TTextBoxPassword";
            this.TTextBoxPassword.PasswordChar = '*';
            this.TTextBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.TTextBoxPassword.TabIndex = 4;
            this.TTextBoxPassword.Text = "contraseña";
            this.TTextBoxPassword.DoubleClick += new System.EventHandler(this.TTextBoxPassword_DoubleClick);
            // 
            // TButtonSalir
            // 
            this.TButtonSalir.Location = new System.Drawing.Point(206, 126);
            this.TButtonSalir.Name = "TButtonSalir";
            this.TButtonSalir.Size = new System.Drawing.Size(75, 23);
            this.TButtonSalir.TabIndex = 5;
            this.TButtonSalir.Text = "SALIR";
            this.TButtonSalir.UseVisualStyleBackColor = true;
            this.TButtonSalir.Click += new System.EventHandler(this.TButtonSalir_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TLabelError
            // 
            this.TLabelError.AutoSize = true;
            this.TLabelError.BackColor = System.Drawing.SystemColors.Window;
            this.TLabelError.Enabled = false;
            this.TLabelError.Location = new System.Drawing.Point(32, 101);
            this.TLabelError.Name = "TLabelError";
            this.TLabelError.Size = new System.Drawing.Size(261, 13);
            this.TLabelError.TabIndex = 6;
            this.TLabelError.Text = "ERROR USUARIO O CONTRASENYA NO VALIDOS";
            this.TLabelError.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AlquilerCoches.Properties.Resources.portada1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(305, 262);
            this.Controls.Add(this.TLabelError);
            this.Controls.Add(this.TButtonSalir);
            this.Controls.Add(this.TTextBoxPassword);
            this.Controls.Add(this.TLabelContrasenya);
            this.Controls.Add(this.TTextBoxUsuario);
            this.Controls.Add(this.TLabelUsuario);
            this.Controls.Add(this.TbotonOK);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TbotonOK;
        private System.Windows.Forms.Label TLabelUsuario;
        private System.Windows.Forms.TextBox TTextBoxUsuario;
        private System.Windows.Forms.Label TLabelContrasenya;
        private System.Windows.Forms.TextBox TTextBoxPassword;
        private System.Windows.Forms.Button TButtonSalir;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label TLabelError;
    }
}

