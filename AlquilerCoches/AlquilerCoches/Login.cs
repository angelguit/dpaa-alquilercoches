using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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

        private bool incorrecto = false;
        private int Intentos = 3;
        private void TbotonOK_Click(object sender, EventArgs e)
        {
            bool contraseñaCorrecta = false;
            errorProvider1.SetError(TLabelError, "");
            TLabelError.Visible= false;

            if (true && !incorrecto && TTextBoxPassword.Text!="" && TTextBoxUsuario.Text!="" )//(TTextBoxUsuario.Text.Equals("root") && TTextBoxPassword.Text.Equals("root"))
            {
                
                EN.ENPersonal comprobar = new EN.ENPersonal();
                DataSet dspers = new DataSet();
                string cadena=" dni = '"+TTextBoxUsuario.Text+"'";
                dspers =comprobar.ObtenerListaPersonal(cadena);
                if (dspers.Tables["Personal"].Rows.Count == 1 && dspers.Tables["Personal"].Rows[0][8].ToString() == "Gerente")
                {
                    if (dspers.Tables["Personal"].Rows[0][9].ToString() == TTextBoxPassword.Text)
                    {
                        this.Hide();
                        MDIPral F2 = new MDIPral(TTextBoxUsuario.Text);
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
                            MessageBox.Show("Numero de intentos superado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            Application.Exit();
                        }
                    }
                    
                }
                else
                {
                    if (dspers.Tables["Personal"].Rows.Count == 1 && dspers.Tables["Personal"].Rows[0][8].ToString() == "Oficinista")
                    {
                        if ( dspers.Tables["Personal"].Rows[0][9].ToString() == TTextBoxPassword.Text)
                        {
                            this.Hide();
                            MDIPral F2 = new MDIPral(TTextBoxUsuario.Text);
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
                                MessageBox.Show("Numero de intentos superado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                                Application.Exit();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No tienes suficientes privilegios");
                        Application.Exit();
                    }
                }
            }
            else
            {
                NIntento++;
                errorProvider1.SetError(TLabelError, "ERROR USUARIO O CONTRASENYA NO VALIDOS");
                TLabelError.Visible = true;
                if (NIntento >= Intentos)
                {
                    MessageBox.Show("Numero de intentos superado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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

        private void TTextBoxUsuario_Leave(object sender, EventArgs e)
        {
            if (!Regex.Match(TTextBoxUsuario.Text, @"^(([A-Z]\d{8})|(\d{8}[A-Z]))$").Success)
            {
                errorProvider1.SetError(TTextBoxUsuario, "Formato correcto: X00000000");
                incorrecto = true;
            }
            else
            {
                incorrecto = false;
                errorProvider1.SetError(TTextBoxUsuario, "");
            }
        }

    }
}
