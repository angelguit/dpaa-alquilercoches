namespace AlquilerCoches
{
    partial class Form1
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
            this.TlabelMarca = new System.Windows.Forms.Label();
            this.TtextBoxMarca = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TbotonOK
            // 
            this.TbotonOK.Location = new System.Drawing.Point(147, 174);
            this.TbotonOK.Name = "TbotonOK";
            this.TbotonOK.Size = new System.Drawing.Size(75, 23);
            this.TbotonOK.TabIndex = 0;
            this.TbotonOK.Text = "button1";
            this.TbotonOK.UseVisualStyleBackColor = true;
            // 
            // TlabelMarca
            // 
            this.TlabelMarca.AutoSize = true;
            this.TlabelMarca.Location = new System.Drawing.Point(37, 41);
            this.TlabelMarca.Name = "TlabelMarca";
            this.TlabelMarca.Size = new System.Drawing.Size(37, 13);
            this.TlabelMarca.TabIndex = 1;
            this.TlabelMarca.Text = "Marca";
            // 
            // TtextBoxMarca
            // 
            this.TtextBoxMarca.Location = new System.Drawing.Point(122, 41);
            this.TtextBoxMarca.Name = "TtextBoxMarca";
            this.TtextBoxMarca.Size = new System.Drawing.Size(100, 20);
            this.TtextBoxMarca.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.TtextBoxMarca);
            this.Controls.Add(this.TlabelMarca);
            this.Controls.Add(this.TbotonOK);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TbotonOK;
        private System.Windows.Forms.Label TlabelMarca;
        private System.Windows.Forms.TextBox TtextBoxMarca;
    }
}

