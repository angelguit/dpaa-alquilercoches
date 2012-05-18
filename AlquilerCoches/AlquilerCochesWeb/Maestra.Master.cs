using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlquilerCochesWeb
{
    public partial class Maestra : System.Web.UI.MasterPage
    {

        protected void TMenuMaster_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
            {
                TMenuMaster.Items[2].Enabled = false;
                TMenuMaster.Items[2].Text = "";
                TMenuMaster.Items[7].Enabled = false;
                TMenuMaster.Items[7].Text = "";
            }
            else
            {
                TMenuMaster.Items[2].Enabled = true;
                TMenuMaster.Items[2].Text = "Perfil de Usuario";
                TMenuMaster.Items[7].Enabled = true;
                TMenuMaster.Items[7].Text = "Salir";
                TMenuMaster.Items[1].Enabled = false;
                TMenuMaster.Items[1].Text = "";
            }
        }

        protected void TMenuMaster_MenuItemClick(object sender, MenuEventArgs e)
        {

        }
    }
}