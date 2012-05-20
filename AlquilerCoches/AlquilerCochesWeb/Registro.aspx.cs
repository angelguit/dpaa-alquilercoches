using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EN;
using System.Text.RegularExpressions;

namespace AlquilerCochesWeb
{
    public partial class Registro : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TDropDownListProvincia_TextChanged(object sender, EventArgs e)
        {


        }
        protected void TDropDownListProvincia_Load(object sender, EventArgs e)
        {
       
        }

        protected void TDropDownListProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            
        }

        protected void ComprobarUsuario(object source, ServerValidateEventArgs args)
        {

           

        }

        protected void ComprobarTelefono(object source, ServerValidateEventArgs args)
        {

        }

        protected void CustomValidator3_ServerValidate(object source, ServerValidateEventArgs args)
        {
          
        }

        protected void TTextBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TTextBoxEmail_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void CustomValidator5_ServerValidate(object source, ServerValidateEventArgs args)
        {

        }

        protected void CustomValidator4_ServerValidate(object source, ServerValidateEventArgs args)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void CustomValidator4_ServerValidate1(object source, ServerValidateEventArgs args)
        {
            if (Regex.Match(TTextBoxEmail.Text, @"^[0-9]{9}$").Success)
            {

                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;

            }
        }

        protected void CustomSexo_ServerValidate1(object source, ServerValidateEventArgs args)
        {
            if (CheckBox1.Checked || CheckBox2.Checked)
            {
                args.IsValid = true;
            }
            else { args.IsValid = false; } 
        }

        protected void CustomEmail_ServerValidate1(object source, ServerValidateEventArgs args)
        {
            if (Regex.Match(TTextBoxEmail.Text, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$").Success)
            {

                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;

            }
        }

        protected void CustomValidatorDNI_ServerValidate1(object source, ServerValidateEventArgs args)
        {

        }

        protected void CustomValidator6_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (Regex.Match(TextBox5.Text, @"\^[0-9]{8}[A-Za-z]{1}$").Success)
            {
                CAD.CADCliente cad_cliente = new CAD.CADCliente();
                bool parar=false;
                DataSet ds = new DataSet();
                string todo="DNI="+TextBox5.Text;

                ds = cad_cliente.ObtenerTablaCliente(todo);

                for (int i = 0; i < 16 && !parar; i++)
                {
                    if (ds.Tables["Clientes"].Rows[i][0].ToString() == TextBox5.Text)
                    {

                        args.IsValid = false;
                        parar = true;
                    }
                }
                if (!parar)
                {
                    args.IsValid = true;
                }
            }
            else
            {
                args.IsValid = false;
            }
        }


    }
}