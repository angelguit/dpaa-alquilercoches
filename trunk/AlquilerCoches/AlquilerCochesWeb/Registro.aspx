<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="AlquilerCochesWeb.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<link rel="stylesheet" href="Css/Registro.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MaestraContenedor" runat="server">
 <div id="Cuerpo">	
          <div id="RegistroDatosUsuario">
            <div id="NuevoRegistro" 
                  style="height: 487px; width: 401px; margin-top: 0px; margin-left: 28px;">
                   <p style="text-align:center;background-color:#e6e6e6; width: 398px; font-family: verdana;">Nuevo registro</p>
                   <p style="font-family: verdana; height: 447px; margin-left: 28px; width: 527px;">
                    <asp:Label ID="Label1" runat="server" Text="Label" Width="90">Nombre</asp:Label>
                       <asp:TextBox ID="TextBox1" runat="server" Width="178px" BorderStyle="Solid" 
                           BorderColor="Gray"></asp:TextBox>
                       </br></br></br>
                    <asp:Label ID="Label2" runat="server" Text="Label" Width="90" >Apellidos</asp:Label>
                       <asp:TextBox ID="TextBox2" runat="server" BorderStyle="Solid" 
                           BorderColor="Gray" Width="241px"></asp:TextBox>
                       </br></br></br>
                    <asp:Label ID="Label3" runat="server" Text="Label" Width="90">Provincia</asp:Label>
                       <asp:TextBox ID="TextBox3" runat="server" BorderStyle="Solid" 
                           BorderColor="Gray" Width="179px"></asp:TextBox>
                       </br></br></br>
                    <asp:Label ID="Label4" runat="server" Text="Label" Width="90">Ciudad</asp:Label>
                       <asp:TextBox ID="TextBox4" runat="server" BorderStyle="Solid" 
                           BorderColor="Gray" Height="22px" Width="178px"></asp:TextBox>
                       </br></br></br>
                    <asp:Label ID="Label5" runat="server" Text="Label" Width="90">Dirección</asp:Label>
                       <asp:DropDownList ID="DropDownList1" runat="server" Height="17px" Width="136px" BorderStyle="Solid" BorderColor="Gray">
                       </asp:DropDownList>
                       </br></br></br>
                    <asp:Label ID="Label6" runat="server" Text="Label" Width="90">Teléfono</asp:Label>
                       <asp:DropDownList ID="DropDownList2" runat="server" Height="17px" Width="136px" BorderStyle="Solid" BorderColor="Gray">
                       </asp:DropDownList>
                       </br></br></br>
                    <asp:Label ID="Label7" runat="server" Text="Label" Width="90" >E-Mail</asp:Label>
                       <asp:TextBox ID="TextBox7" runat="server" BorderStyle="Solid" 
                           BorderColor="Gray" Width="182px"></asp:TextBox>
                       </br></br></br>
                    </p>
            </div>        
          </div>	
    
    </div>
</asp:Content>
