<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Compras.aspx.cs" Inherits="AlquilerCochesWeb.Compras" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<link rel="stylesheet" href="Css/Compras.css"/>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MaestraContenedor" runat="server">
    <div id="Cuerpo">

        <div id="ComprasCuerpoTitulo">
                <p style="text-align:center; background-color:#e6e6e6; text-transform: capitalize; font-size: 14pt;">Vehículos en Venta</p>

            <div style="width: 382px; margin-left: 240px">
                <asp:Menu ID="MenuCompras" runat="server" Orientation="Horizontal" StaticSelectedStyle-BackColor="#666666" 
                    ForeColor="Black" Font-Italic="True" Font-Size="Medium" StaticHoverStyle-ForeColor="#666666">
                <Items>
                    <asp:MenuItem Text="Turismos"></asp:MenuItem>
                    <asp:MenuItem Text="Familiares"></asp:MenuItem>
                    <asp:MenuItem Text="Furgonetas"></asp:MenuItem>
                    <asp:MenuItem Text="Especiales"></asp:MenuItem>
                </Items>
                </asp:Menu>
            </div>
        </div>

            <div id="ComprasCuerpoCoches">
                <p style="text-align:left; background-color:#e6e6e6; text-transform: capitalize; font-size: 12pt;">Resultados</p>
                <div>
                    <asp:MultiView ID="MultiViewCompras" runat="server">

                    </asp:MultiView>
                </div>

            </div>

    </div>
</asp:Content>
