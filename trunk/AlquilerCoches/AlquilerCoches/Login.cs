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
            errorProvider1.SetError(TLabelError, "");
            TLabelError.Visible= false;
            if (true)//(TTextBoxUsuario.Text.Equals("root") && TTextBoxPassword.Text.Equals("root"))
            {
                this.Hide();
                MDIPral F2 = new MDIPral("33456789E");
                F2.WindowState = FormWindowState.Maximized;
                F2.ShowDialog();
                Application.Exit();
                TTextBoxUsuario.Text = "";
                TTextBoxPassword.Text = "";
                NIntento = 0;
                this.Show();
            }
            else
            {
                NIntento++;
                errorProvider1.SetError(TLabelError, "ERROR USUARIO O CONTRASENYA NO VALIDOS");
                TLabelError.Visible = true;
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
