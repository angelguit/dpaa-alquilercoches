<%@ Page Title="Rent A Car" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AlquilerCochesWeb.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="IndexIzquierda" ContentPlaceHolderID="MaestraContenedor" runat="server">
<div id="IndexPresentacion">
    <div id="IndexTextoPresentacion">
        <p>Rent A Car es una empresa con años de experiencia.</p>
        <p>Nuestros clientes son nuestra mayor prioridad y esperamos ofrecerle un servicio de su agrado. </p>
    </div>
</div>
<div id="IndexLogin">
    <asp:Login ID="IndexLogin" runat="server" Height="149px" Width="169px">
    </asp:Login>
</div>
<div id="IndexRegistro">
</div>
<div id="IndexOfertas">
</div>
<div id="IndexReserva">
</div>
</asp:Content>

