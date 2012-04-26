﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="AlquilerCochesWeb.Perfil" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>Rent A Car</title>
      <link rel="stylesheet" href="Css/Perfil.css"/>
</head>
<body>
    <form id="form1" runat="server">
    <div id="Menu">
             <asp:Menu ID="TMenuPerfil" runat="server" BackColor="#F7F6F3" 
                DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" 
                ForeColor="#7C6F57" Orientation="Horizontal" StaticSubMenuIndent="10px">
                <DynamicHoverStyle BackColor="#7C6F57" ForeColor="White" />
                <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                <DynamicMenuStyle BackColor="#F7F6F3" />
                <DynamicSelectedStyle BackColor="#5D7B9D" />
                <Items>
                    <asp:MenuItem NavigateUrl="~/Index.aspx" Text="Inicio" Value="Inicio">
                    </asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/Registro.aspx" Text="Registrarse" 
                        Value="Registrarse"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/Perfil.aspx" Text="Perfil de Usuario" 
                        Value="Perfil de Usuario"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/Reservas.aspx" Text="Reservas" Value="Reservas">
                    </asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/Ofertas.aspx" Text="Ofertas" Value="Ofertas">
                    </asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/Situacion.aspx" Text="¿Donde estamos?" 
                        Value="¿Donde estamos?"></asp:MenuItem>
                </Items>
                <StaticHoverStyle BackColor="#7C6F57" ForeColor="White" />
                <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                <StaticSelectedStyle BackColor="#5D7B9D" />
            </asp:Menu>
    </div>
    <div id="Cuerpo">
            <p>ESTO ES EL PERFIL</p>				
    </div>
    <div id="Pie">
        &reg Rent A Car  Telf: 967 123 123 Fax: 967 231 231
        <a id="PerfilContacto" href="mailto:contacto@rentacar.com">Contacto</a>
    </div>
    </form>
</body>
</html>
