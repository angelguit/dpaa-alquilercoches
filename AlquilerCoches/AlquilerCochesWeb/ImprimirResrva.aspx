<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ImprimirResrva.aspx.cs" Inherits="AlquilerCochesWeb.WebForm2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Factura</title>
    <link rel="stylesheet" href="Css/ImpresionReserva.css"/>
</head>
    <body>
        <form id="form1" runat="server">
 
        <div id="Cuerpo" />   
        <div id="boton">
            <asp:Button ID="BotonImprimir" runat="server" Text="Imprimir" onclick="BotonImprimir_Click"/>
        </div>  
              <div id="datosCliente">
              <p style="font-family: Arial; font-size: 18px; font-weight: bold; text-decoration: underline; margin-left: 160px;"> Datos Cliente </p>
                  <asp:Label ID="TLabelDni" runat="server" Text="DNI:" style="margin-left:26px;"></asp:Label>
                  <asp:TextBox ID="TTextBoxDni" runat="server" Width="129px"></asp:TextBox></br></br>
                  &nbsp;<asp:Label ID="TLabelNombre" runat="server" Text="Nombre:"></asp:Label>
                  <asp:TextBox ID="TTextBoxNombre" runat="server"></asp:TextBox>&nbsp;&nbsp;
                  <asp:Label ID="TLabelApellidos" runat="server" Text="Apellidos:"></asp:Label>
                  <asp:TextBox ID="TTextBoxApellidos" runat="server"></asp:TextBox></br></br>
                  &nbsp;<asp:Label ID="TLabelTelefono" runat="server" Text="Telefono:"></asp:Label>
                  <asp:TextBox ID="TTextBoxTelefono" runat="server"></asp:TextBox>&nbsp;&nbsp;
                  <asp:Label ID="TLabelEmail" runat="server" Text="Email:" style="margin-left:24px;"></asp:Label>
                  <asp:TextBox ID="TTextBoxEmail" runat="server"></asp:TextBox>
              </div>
              <div id="datosReserva">
                <p style="font-family: Arial; font-size: 18px; font-weight: bold; text-decoration: underline; margin-left: 160px;"> Datos Reserva </p>
                  <asp:Label ID="TLabelReserva" runat="server" Text="NºReserva:" style="margin-left:26px;"></asp:Label>
                  <asp:TextBox ID="TTextBoxReserva" runat="server" Width="54px"></asp:TextBox>&nbsp;&nbsp;
                  &nbsp;<asp:Label ID="TLabelMatricula" runat="server" Text="Matricula:" style="margin-left:31px;"></asp:Label>
                  <asp:TextBox ID="TTextBoxMatricula" runat="server"></asp:TextBox></br></br>
                  &nbsp;<asp:Label ID="TLabelMarca" runat="server" Text="Marca:"></asp:Label>
                  <asp:TextBox ID="TTextBoxMarca" runat="server"></asp:TextBox>&nbsp;&nbsp;
                  &nbsp;<asp:Label ID="TLabelModelo" runat="server" Text="Modelo:"></asp:Label>
                  <asp:TextBox ID="TTextBoxModelo" runat="server"></asp:TextBox></br></br>
                  <asp:Label ID="TLabelFechaReserva" runat="server" Text="Fecha Reserva:" style="margin-left:24px;"></asp:Label>
                  <asp:TextBox ID="TTextBoxFechaReserva" runat="server"></asp:TextBox>
              </div>

              <div id="Decoracion1" style="font-family: 'Rage Italic'; font-size: 35px">
                  <p>F</p>
                  <p>A</p>
                  <p>C</p>
                  <p>T</p>
                  <p>U</p>
                  <p>R</p>
                  <p>A</p>
              </div>
        </div>
        <div id="Pie">
            &reg Rent A Car  Telf: 967 123 123 Fax: 967 231 231
            <a id="MaestraContacto" href="mailto:contacto@rentacar.com">Contacto</a>
        </div>
        </form>
    </body>
</html>
