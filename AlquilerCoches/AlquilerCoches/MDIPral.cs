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
            if (Application.OpenForms["GestionVehiculos"] != null)
            {

                Application.OpenForms["GestionVehiculos"].Activate();
            }
            else
            {
                GestionVehiculos F2 = new GestionVehiculos();
                F2.MdiParent = this;
                F2.Show();
                //F2.WindowState = FormWindowState.Maximized;
            }
        }

        private void darAltaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["GestionPersonal"] != null)
            {

                Application.OpenForms["GestionPersonal"].Activate();
            }
            else
            {
                GestionPersonal F3 = new GestionPersonal();    
                F3.MdiParent = this;
                F3.Show();
               // F3.WindowState = FormWindowState.Maximized;

            }
         
        }

        private void TButtonCliente_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["GestionClientesBuscar"] != null)
            {

                Application.OpenForms["GestionClientesBuscar"].Activate();
            }
            else
            {
                GestionClientesBuscar F4 = new GestionClientesBuscar();
                F4.MdiParent = this;
                F4.Show();
              //  F4.WindowState = FormWindowState.Maximized;
            }
        }

        

        private void TButtonVehiculos_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["GestionVehiculos"] != null)
            {

                Application.OpenForms["GestionVehiculos"].Activate();
            }
            else
            {
                GestionVehiculos F5 = new GestionVehiculos();
                F5.MdiParent = this;
                F5.Show();
                F5.WindowState = FormWindowState.Maximized;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TToolStripMenuItemNuevaFactura_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Facturacion"] != null)
            {

                Application.OpenForms["Facturacion"].Activate();
            }
            else
            {
                Facturacion F6 = new Facturacion();
                F6.MdiParent = this;
                F6.Show();
                F6.WindowState = FormWindowState.Maximized;
            }
        }

        private void TToolStripMenuItemBuscarFactura_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["GestionFacturacion"] != null)
            {

                Application.OpenForms["GestionFacturacion"].Activate();
            }
            else
            {
                GestionFacturacion F7 = new GestionFacturacion();
                F7.MdiParent = this;
                F7.Show();
                F7.WindowState = FormWindowState.Maximized;
            }
        }

        private void ponerEnVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["PonerVenta"] != null)
            {
                Application.OpenForms["PonerVenta"].Activate();
            }
            else
            {
                PonerVenta F8 = new PonerVenta();
                F8.MdiParent = this;
                F8.Show();
                F8.WindowState = FormWindowState.Maximized;
             }
        }

        private void mostrarVehículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["EditarVentas"] != null)
            {
                Application.OpenForms["EditarVentas"].Activate();
            }
            else
            {
                EditarVentas F9 = new EditarVentas();
                F9.MdiParent = this;
                F9.Show();
                F9.WindowState = FormWindowState.Maximized;
            }
        }

        private void mostrarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["GestionVentas"] != null)
            {
                Application.OpenForms["GestionVentas"].Activate();
            }
            else
            {
                GestionVentas F10 = new GestionVentas();
                F10.MdiParent = this;
                F10.Show();
                F10.WindowState = FormWindowState.Maximized;
            }
        }

   
        private void buscarOModificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["GestionPersonalBuscar"] != null)
            {
                Application.OpenForms["GestionPersonalBuscar"].Activate();
            }
            else
            {
                GestionPersonalBuscar F11 = new GestionPersonalBuscar();
                F11.MdiParent = this;
                F11.Show();
                //F11.WindowState = FormWindowState.Maximized;
            }
        }

        private void TButtonSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea realmente salir de la aplicación?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
                Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Application.OpenForms[""].Close();
            //Application.OpenForms.GetEnumerator();

            //this.f
            
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                //this.MdiChildren[i].WindowState = FormWindowState.Minimized;
                this.MdiChildren[i].Close();
            }
        }

     
     }
}
