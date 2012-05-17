<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="PerfilFactura.aspx.cs" Inherits="AlquilerCochesWeb.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<link rel="stylesheet" href="Css/ImpresionReserva.css" media="print" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MaestraContenedor" runat="server">
    <asp:GridView ID="TDataGridViewFacturaFechas" style="margin: 0 auto; margin-top:20px;" runat="server" CellPadding="4" 
        ForeColor="#333333"  GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
    <asp:Label ID="LabelAnuncio" runat="server" style="font-size:40px; margin-left:7cm" Text="No hay resultados"></asp:Label></br></br>
    <asp:Button ID="Button1" runat="server" 
        style="-moz-border-radius: 10px; -webkit-border-radius: 10px; cursor: pointer; margin-left:10cm" Text="Volver" 
        onclick="Button1_Click" />
</asp:Content>
