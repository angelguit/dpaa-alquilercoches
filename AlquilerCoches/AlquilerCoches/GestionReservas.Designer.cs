namespace AlquilerCoches
{
    partial class GestionReservas
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
            this.TDataGridViewReservas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TDataGridViewReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // TDataGridViewReservas
            // 
            this.TDataGridViewReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TDataGridViewReservas.Location = new System.Drawing.Point(72, 41);
            this.TDataGridViewReservas.Name = "TDataGridViewReservas";
            this.TDataGridViewReservas.Size = new System.Drawing.Size(339, 239);
            this.TDataGridViewReservas.TabIndex = 0;
            // 
            // GestionReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 375);
            this.Controls.Add(this.TDataGridViewReservas);
            this.Name = "GestionReservas";
            this.Text = "GestionReservas";
            this.Load += new System.EventHandler(this.GestionReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TDataGridViewReservas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TDataGridViewReservas;
    }
}