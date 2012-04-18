namespace AlquilerCoches
{
    partial class BuscarPedidos
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
            this.TNamelabel = new System.Windows.Forms.Label();
            this.TNametextbox = new System.Windows.Forms.TextBox();
            this.TEstadogroupbox = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.TBuscarbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TIDtextBox = new System.Windows.Forms.TextBox();
            this.TDataGridViewPedidos = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.TEstadogroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TDataGridViewPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.TNamelabel);
            this.groupBox1.Controls.Add(this.TNametextbox);
            this.groupBox1.Controls.Add(this.TEstadogroupbox);
            this.groupBox1.Controls.Add(this.TBuscarbutton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TIDtextBox);
            this.groupBox1.Location = new System.Drawing.Point(31, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criterios de búsqueda ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TNamelabel
            // 
            this.TNamelabel.AutoSize = true;
            this.TNamelabel.Location = new System.Drawing.Point(168, 67);
            this.TNamelabel.Name = "TNamelabel";
            this.TNamelabel.Size = new System.Drawing.Size(47, 13);
            this.TNamelabel.TabIndex = 7;
            this.TNamelabel.Text = "Nombre:";
            this.TNamelabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // TNametextbox
            // 
            this.TNametextbox.Location = new System.Drawing.Point(231, 67);
            this.TNametextbox.Name = "TNametextbox";
            this.TNametextbox.Size = new System.Drawing.Size(101, 20);
            this.TNametextbox.TabIndex = 6;
            this.TNametextbox.TextChanged += new System.EventHandler(this.TNametextbox_TextChanged);
            // 
            // TEstadogroupbox
            // 
            this.TEstadogroupbox.Controls.Add(this.radioButton2);
            this.TEstadogroupbox.Controls.Add(this.radioButton1);
            this.TEstadogroupbox.Location = new System.Drawing.Point(6, 26);
            this.TEstadogroupbox.Name = "TEstadogroupbox";
            this.TEstadogroupbox.Size = new System.Drawing.Size(129, 67);
            this.TEstadogroupbox.TabIndex = 5;
            this.TEstadogroupbox.TabStop = false;
            this.TEstadogroupbox.Text = "Estado";
            this.TEstadogroupbox.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(43, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "Cerrado";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(43, 18);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Abierto";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // TBuscarbutton
            // 
            this.TBuscarbutton.Location = new System.Drawing.Point(385, 44);
            this.TBuscarbutton.Name = "TBuscarbutton";
            this.TBuscarbutton.Size = new System.Drawing.Size(133, 23);
            this.TBuscarbutton.TabIndex = 4;
            this.TBuscarbutton.Text = "BUSCAR";
            this.TBuscarbutton.UseVisualStyleBackColor = true;
            this.TBuscarbutton.Click += new System.EventHandler(this.TBuscarbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // TIDtextBox
            // 
            this.TIDtextBox.Location = new System.Drawing.Point(231, 26);
            this.TIDtextBox.Name = "TIDtextBox";
            this.TIDtextBox.Size = new System.Drawing.Size(101, 20);
            this.TIDtextBox.TabIndex = 2;
            // 
            // TDataGridViewPedidos
            // 
            this.TDataGridViewPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TDataGridViewPedidos.Location = new System.Drawing.Point(31, 157);
            this.TDataGridViewPedidos.Name = "TDataGridViewPedidos";
            this.TDataGridViewPedidos.Size = new System.Drawing.Size(812, 203);
            this.TDataGridViewPedidos.TabIndex = 3;
            this.TDataGridViewPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TDataGridViewPedidos_CellContentClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BuscarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::AlquilerCoches.Properties.Resources.rentacar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 570);
            this.Controls.Add(this.TDataGridViewPedidos);
            this.Controls.Add(this.groupBox1);
            this.Name = "BuscarPedidos";
            this.Text = "Buscar Pedidos";
            this.Load += new System.EventHandler(this.BuscarPedidos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TEstadogroupbox.ResumeLayout(false);
            this.TEstadogroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TDataGridViewPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TIDtextBox;
        private System.Windows.Forms.GroupBox TEstadogroupbox;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button TBuscarbutton;
        private System.Windows.Forms.DataGridView TDataGridViewPedidos;
        private System.Windows.Forms.Label TNamelabel;
        private System.Windows.Forms.TextBox TNametextbox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}