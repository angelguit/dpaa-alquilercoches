using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlquilerCochesWeb
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void BotonImprimir_Click(object sender, EventArgs e)
        {
            BotonImprimir.Visible = false;
            

            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Prueba","window.print();", true);

            //BotonImprimir.Visible = true;
                
        }
       
    }
}