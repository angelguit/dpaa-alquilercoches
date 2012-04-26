<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="AlquilerCochesWeb.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<link rel="stylesheet" href="Css/Registro.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MaestraContenedor" runat="server">
 <div id="Cuerpo">	
          <div id="RegistroDatosUsuario">
            <div id="NuevoRegistro" style="height: 487px; width: 401px; margin-top: 0px;">
                   <p style="text-align:center;background-color:#e6e6e6; width: 398px; font-family: verdana;">Nuevo registro</p>
                   <p style="font-family: verdana; height: 353px; margin-left: 28px;">
                    <asp:Label ID="Label1" runat="server" Text="Label" Width="90">Nombre</asp:Label>
                       <asp:TextBox ID="TextBox1" runat="server" Width="164px"></asp:TextBox>
                       </br></br></br>
                    <asp:Label ID="Label2" runat="server" Text="Label" Width="90">Apellidos</asp:Label>
                       <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                       </br></br></br>
                    <asp:Label ID="Label3" runat="server" Text="Label" Width="90">Provincia</asp:Label>
                       <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                       </br></br></br>
                    <asp:Label ID="Label4" runat="server" Text="Label" Width="90">Ciudad</asp:Label>
                       <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                       </br></br></br>
                    <asp:Label ID="Label5" runat="server" Text="Label" Width="90">Dirección</asp:Label>
                       <asp:DropDownList ID="DropDownList1" runat="server" Height="17px" Width="136px">
                       </asp:DropDownList>
                       </br></br></br>
                    <asp:Label ID="Label6" runat="server" Text="Label" Width="90">Teléfono</asp:Label>
                       <asp:DropDownList ID="DropDownList2" runat="server" Height="17px" Width="136px">
                       </asp:DropDownList>
                       </br></br></br>
                    <asp:Label ID="Label7" runat="server" Text="Label" Width="90" >E-Mail</asp:Label>
                       <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                       </br></br></br>
                    </p>
            </div>        
          </div>	
    
    </div>
</asp:Content>
