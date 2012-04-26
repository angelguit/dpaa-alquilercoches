<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="AlquilerCochesWeb.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<link rel="stylesheet" href="Css/Registro.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MaestraContenedor" runat="server">
 <div id="Cuerpo">	
          <div id="RegistroDatosUsuario">
            <div id="NuevoRegistro" style="height: 487px; width: 401px; margin-top: 0px;">
                   <p style="text-align:center;background-color:#e6e6e6; width: 398px; font-family: verdana;">Nuevo registro</p>
                   <p style="font-family: verdana;">
                    <asp:Label ID="Label1" runat="server" Text="Label">Nombre</asp:Label>
                       <asp:TextBox ID="TextBox1" runat="server" Width="164px"></asp:TextBox>
                       </br></br>
                    <asp:Label ID="Label2" runat="server" Text="Label">Apellidos</asp:Label></br></br>
                    <asp:Label ID="Label3" runat="server" Text="Label">Provincia</asp:Label></br></br>
                    <asp:Label ID="Label4" runat="server" Text="Label">Ciudad</asp:Label></br></br>
                    <asp:Label ID="Label5" runat="server" Text="Label">Dirección</asp:Label></br></br>
                    <asp:Label ID="Label6" runat="server" Text="Label">Teléfono</asp:Label></br></br>
                    <asp:Label ID="Label7" runat="server" Text="Label">E-Mail</asp:Label></br></br>
                    </p>
            </div>        
          </div>	
    
    </div>
</asp:Content>
