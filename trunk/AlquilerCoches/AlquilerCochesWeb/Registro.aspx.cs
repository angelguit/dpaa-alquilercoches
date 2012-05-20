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
            EN.ENCliente en_cliente = new EN.ENCliente();
            if (Page.IsValid)
            {
                en_cliente.DNI = TextBox5.Text;
                en_cliente.Nombre = TTextBoxNombre.Text;
                en_cliente.Apellidos = TTextBoxApellidos.Text;
                en_cliente.PassWeb = TextBox1.Text;
                en_cliente.Direccion = TTextBoxDireccion.Text;
                en_cliente.Provincia = TDropDownListProvincia.SelectedItem.ToString();
                en_cliente.Ciudad = TDropDownListCiudad.SelectedItem.ToString();
                en_cliente.Email = TTextBoxEmail.Text;
                en_cliente.Telefono = Convert.ToInt32(TextBox3.Text);
                if (CheckBox1.Checked)
                {
                    en_cliente.Sexo = "Hombre";
                }
                else { en_cliente.Sexo = "Mujer"; }

                en_cliente.AnyadirCliente();
            }
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


            if (Regex.Match(TextBox5.Text, @"^(([A-Z]\d{8})|(\d{8}[A-Z]))$").Success)
            {
                EN.ENCliente en_cliente = new EN.ENCliente();
               // bool parar=false;
               // ArrayList array = new ArrayList();
               // string todo="DNI='"+TextBox5.Text+"'"; 

                string dni = TextBox5.Text;
                DataSet ds = new DataSet();
               
                ds = en_cliente.ObtenerDatosClienteConDni(dni);
                //DataColumn colum = new DataColumn();
                if (ds.Tables["Cliente"].Rows.Count == 0) // si el dataset no tiene ningun resultado quiere decir q no hay ningun dni con el valor que le hemos pasado en la base de datos
                {
                    //Label15.Text = ds.Tables["Cliente"].Rows[0][0].ToString();
                    args.IsValid = true;
                   
                }
                else
                {
                    args.IsValid = false;
                }
       

                /*

                for (int i = 0; i < 1; i++)
                {
                    array.Add(ds.Tables["Cliente"].Rows[i]["DNI"].ToString());
                }

                for (int j = 0; j < array.Count && !parar; j++)
                {
                    if (array[j].ToString() == TextBox5.Text)
                    {
                        parar = true;
                        args.IsValid = false;
                    }
                }

                
               /* for (int i = 0; i < 16; i++)
                {
                    if (ds.Tables["Cliente"].Rows[i][0].ToString() == TextBox5.Text)
                    {
                        parar = true;
                        args.IsValid = false;
                    }
                }*/ 
                /*
                if (!parar)
                {
                   
                    args.IsValid = false;

                }
               */
            }
            else
            {
                args.IsValid = false;
                 //Label15.Text = "falso";
                 
                
               
            }
        }


    }
}