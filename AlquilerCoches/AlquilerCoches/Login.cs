using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AlquilerCoches
{
    public partial class Login : Form
    {
        private int NIntento;
        public Login()
        {
            InitializeComponent();
            NIntento = 0;
        }

        private int Intentos = 3;
        private void TbotonOK_Click(object sender, EventArgs e)
        {
            if (TTextBoxUsuario.Text.Equals("root") && TTextBoxPassword.Text.Equals("root"))
            {
                this.Hide();
                (new GestionVehiculos()).ShowDialog();
                TTextBoxUsuario.Text = "";
                TTextBoxPassword.Text = "";
                NIntento = 0;
                this.Show();
            }
            else
            {
                NIntento++;
                if (NIntento >= Intentos)
                {
                    MessageBox.Show("Numero de intentos Superado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    Application.Exit();
                }
            }

        }

        private void TTextBoxPassword_DoubleClick(object sender, EventArgs e)
        {
            //TTextBoxUsuario.Text = "";
            TTextBoxPassword.Text = "";
        }

        private void TButtonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TTextBoxUsuario_DoubleClick(object sender, EventArgs e)
        {
            TTextBoxUsuario.Text = "";
            TTextBoxPassword.Text = "";
        }
    }
}
