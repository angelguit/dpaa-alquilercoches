<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="PerfilFactura.aspx.cs" Inherits="AlquilerCochesWeb.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<link rel="stylesheet" href="Css/ImpresionReserva.css" media="print" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MaestraContenedor" runat="server">
    <asp:GridView ID="TDataGridViewFacturaFechas" runat="server" CellPadding="4" 
        ForeColor="#333333" GridLines="None">
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
       
        <div ID="PerfilFacturaDatos">
        <asp:Label ID="TLabelNombreEmpresa" runat="server" Text="Label">RENT A CAR</asp:Label></br>
            <asp:Label ID="TLabelNumeroFactura" runat="server" Text="Label">Numero Factura: </asp:Label>
            <asp:TextBox ID="TTextBoxNumeroFactura" runat="server"></asp:TextBox>
                <asp:Button ID="printButton" runat="server" Text="Print" OnClientClick="javascript:window.print();" />
        </div>

</asp:Content>
