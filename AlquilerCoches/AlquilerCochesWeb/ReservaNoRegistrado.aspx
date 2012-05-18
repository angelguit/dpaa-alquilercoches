<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="ReservaNoRegistrado.aspx.cs" Inherits="AlquilerCochesWeb.ReservaNoRegistrado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MaestraContenedor" runat="server">
Para realizar una reserva debe estar registrado. 
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Registro.aspx">Registrese</asp:HyperLink>
    o entre con su 
    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Index.aspx">cuenta</asp:HyperLink>
</asp:Content>
