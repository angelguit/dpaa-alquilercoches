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
            }
            else
            {
                TMenuMaster.Items[2].Enabled = true;
                TMenuMaster.Items[2].Text = "Perfil de Usuario";
            }
        }
    }
}