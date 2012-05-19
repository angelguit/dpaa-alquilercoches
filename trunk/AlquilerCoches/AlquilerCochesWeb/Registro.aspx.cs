using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EN;
using System.Text.RegularExpressions;
using System.Collections;


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



            if (Page.IsValid)
            {

                        EN.ENCliente en_cliente = new EN.ENCliente();

                        en_cliente.DNI = TextBoxDni.Text;
                        en_cliente.Nombre = TextBoxNombre.Text;
                        en_cliente.Apellidos = TTextBoxApellidos.Text;
                        en_cliente.Direccion = TTextBoxDireccion.Text;
                        en_cliente.PassWeb = TextBoxPass2.Text;
                        en_cliente.Provincia = TDropDownListProvincia.SelectedItem.ToString();
                        en_cliente.Ciudad = TDropDownListCiudad.SelectedItem.ToString();
                        en_cliente.Email = TTextBoxEmail.Text;
                        if (CheckBoxHombre.Checked)
                        {
                            en_cliente.Sexo = "H";
                        }
                        else
                        {
                            en_cliente.Sexo = "M";
                        }

                        en_cliente.AnyadirCliente();

                    
            }
       
        }

        protected void ComprobarUsuario(object source, ServerValidateEventArgs args)
        {

            string user = args.Value.ToLower();

            
            
            if (user =="hola") 
            {
                args.IsValid = false;
            }

        }

        protected void ComprobarTelefono(object source, ServerValidateEventArgs args)
        {

        }

        protected void CustomValidator3_ServerValidate(object source, ServerValidateEventArgs args)
        {
           /* string user = "";
            user = TTextBoxUsuario.Text;

            DataSet ds = new DataSet();
            EN.ENCliente en_cliente = new EN.ENCliente();

            en_cliente. */
        }
        protected void ComprobarDNI(object source, ServerValidateEventArgs args)
        {
           string dni = "";
           dni = TextBoxDni.Text;
           ArrayList array = new ArrayList();

           DataSet ds = new DataSet();
           
           EN.ENCliente en_cliente = new EN.ENCliente();
           CAD.CADCliente cad_cliente = new CAD.CADCliente();
           ds=cad_cliente.ObtenerDatosClienteConDni(dni);


            
        
               args.IsValid = false;
           
         // args.IsValid = false; }
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
            if (CheckBoxHombre.Checked || CheckBoxMujer.Checked)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }

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
                if (Regex.Match(TextBoxDni.Text, @"\^[0-9]{8}[A-Za-z]{1}$").Success)
                {

                    args.IsValid = true;
                }
                else
                {
                    args.IsValid = false;

                }


        }

        protected void CustomValidator6_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (Regex.Match(TextBoxDni.Text, @"\^[0-9]{8}[A-Za-z]{1}$").Success)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }
             
            
    }
}