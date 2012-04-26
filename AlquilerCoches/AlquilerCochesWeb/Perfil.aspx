<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="AlquilerCochesWeb.Perfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<link rel="stylesheet" href="Css/Perfil.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MaestraContenedor" runat="server">
 <div id="Cuerpo">	
          <div id="PerfilDatosUsuario">
            <p style="text-align:center">Datos Usuario</p>
            <div>
                <asp:Label ID="Label1" runat="server" Text="Label">Nombre usuario</asp:Label></br></br>
                <asp:Label ID="Label2" runat="server" Text="Label">Apellido usuario</asp:Label></br></br>
                <asp:Label ID="Label3" runat="server" Text="Label">Provincia</asp:Label></br></br>
                <asp:Label ID="Label4" runat="server" Text="Label">Ciudad</asp:Label></br></br>
                <asp:Label ID="Label5" CssClass="botonderecho" runat="server" Text="Editar" 
                    BackColor="#999999" ForeColor="White"></asp:Label>
            </div>        
          </div>	
          <div id="PerfilDatosReservas">Ultimas reservas</div>		
    </div>
</asp:Content>
