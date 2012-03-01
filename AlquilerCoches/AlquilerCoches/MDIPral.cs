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
    public partial class MDIPral : Form
    {
        private int childFormNumber = 0;

        public class User
        {
            string nombre;
            string id;
            string status;
            public User(string Nombre, string ID, string Status)
            {
                nombre = Nombre;
                id = ID;
                status = Status;
            }
            public string Nombre
            {
                set { nombre = Nombre; }
                get { return nombre; }
            }
            public string ID
            {
                set { id = ID; }
                get { return id; }
            }
            public string Status
            {
                set { status = Status; }
                get { return status; }
            }
        }
        User UsuarioSistema;
             

        public MDIPral(User usuario)
        {
            InitializeComponent();
            UsuarioSistema = usuario;

            toolStripStatusLabel.Text = "Nombre:" + usuario.Nombre;
            toolStripStatusLabel1.Text = "ID:" + usuario.ID;
            toolStripStatusLabel2.Text = "Status:" + usuario.Status;

            toolStripLabel1.Text = "Nombre: " + usuario.Nombre;
            toolStripLabel2.Text = "ID: " + usuario.ID;
            toolStripLabel3.Text = "Status: " + usuario.Status;
        }

        
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIPral_Load(object sender, EventArgs e)
        {

        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionVehiculos F2 = new GestionVehiculos();
            F2.MdiParent=this;
            F2.Show();
            F2.WindowState = FormWindowState.Maximized;
        }

        private void darAltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionPersonal F3 = new GestionPersonal();
            F3.MdiParent = this;
            F3.Show();
            F3.WindowState = FormWindowState.Maximized;
        }

        private void TButtonCliente_Click(object sender, EventArgs e)
        {
            GestionClientesBuscar F4 = new GestionClientesBuscar();

            F4.MdiParent = this;
            F4.Show();
            F4.WindowState = FormWindowState.Maximized;
        }
    }
}
