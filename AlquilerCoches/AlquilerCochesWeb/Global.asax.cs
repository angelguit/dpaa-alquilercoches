using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.IO;
using AlquilerCoches;

namespace AlquilerCochesWeb
{
    public class Global : System.Web.HttpApplication
    {
        protected String rutaBDOriginal = Path.GetFullPath(AppDomain.CurrentDomain.GetData("DataDirectory").ToString());
        protected String rutaBD;

        protected void Application_Start(object sender, EventArgs e)
        {
            rutaBD = rutaBDOriginal;
            if (rutaBD.Contains("AlquilerCochesWeb"))
            {
                rutaBD = Path.GetFullPath(AppDomain.CurrentDomain.GetData("DataDirectory").ToString() + "/../../AlquilerCoches");
                AppDomain.CurrentDomain.SetData("DataDirectory", rutaBD);
            }
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}