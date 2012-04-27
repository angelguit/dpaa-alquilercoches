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
                <div style="height: 154px">
                <br />
                    <asp:Label ID="Label1" runat="server" Text="SEAT LEON 1.9" Font-Overline="False" Font-Underline="True" Font-Size="Medium" Font-Bold="True"></asp:Label>
                <br />
                    <asp:Image ID="ComprasFotoCoche" runat="server" Height="96px" 
                    ImageUrl="~/Imagenes/ImagenesCompras/seat-leon.jpg" Width="165px"/>

                    <label id="ComprasLabelDescripcion">Seat León 1.9 en perfecto estado, modelo de 2002, 5 puertas, 115CV con 125.000 Km.</label>
                    <label id="ComprasLabelPrecio">Precio: 9.500 €</label>
                    <button type="button" id="ComprasBotonComprar">Comprar</button> 
                </div>

            </div>

    </div>
</asp:Content>
