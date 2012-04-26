<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="AlquilerCochesWeb.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<link rel="stylesheet" href="Css/Registro.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MaestraContenedor" runat="server">
 <div id="Cuerpo">	
          <div id="PerfilDatosUsuario">
            <p style="text-align:center; text-decoration: underline;">Registro Usuario</p>
            <div style="height: 318px">
                <asp:Image ID="PerfilImagenCliente" runat="server" />
                <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 26px" 
                    Width="165px"></asp:TextBox>
                </br></br>
                <asp:Label ID="Label2" runat="server" Text="Apellidos"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 6px" 
                    Width="232px"></asp:TextBox>
                </br></br>
                <asp:Label ID="Label3" runat="server" Text="Label">Provincia</asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox3" runat="server" Width="162px"></asp:TextBox>
                </br></br>
                <asp:Label ID="Label4" runat="server" Text="Label">Ciudad</asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox4" runat="server" Width="160px"></asp:TextBox>
                </br></br>
            </div>        
          </div>	
    </div>
</asp:Content>
