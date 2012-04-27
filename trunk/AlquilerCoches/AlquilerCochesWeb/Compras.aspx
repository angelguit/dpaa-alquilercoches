<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Compras.aspx.cs" Inherits="AlquilerCochesWeb.Compras" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<link rel="stylesheet" href="Css/Compras.css"/>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MaestraContenedor" runat="server">
    <div id="Cuerpo">

        <div id="ComprasCuerpoTitulo">
                <p style="text-align:center; background-color:#e6e6e6; text-transform: capitalize; font-size: 14pt;">Vehículos en Venta</p>

            <div style="width: 382px; margin-left: 240px">
                <asp:Menu ID="MenuCompras" runat="server" Orientation="Horizontal" StaticSelectedStyle-BackColor="#C0C0C0" 
                    ForeColor="Black" Font-Italic="True" Font-Size="Medium" 
                    StaticHoverStyle-ForeColor="#666666" BackColor="White" StaticMenuItemStyle-BackColor="#FFFFFF">
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

                <div style="height: 154px; border-bottom-style: outset; border-bottom-width: medium;">
                    <br />
                    <asp:Label ID="Label1" runat="server" Text="SEAT LEON, 1.9" Font-Overline="False" Font-Underline="True" Font-Size="Medium" Font-Bold="True"></asp:Label>
                    <br />
                    <asp:Image ID="Image2" runat="server" Height="96px" 
                    ImageUrl="~/Imagenes/ImagenesCompras/seat-leon.jpg" Width="165px"/>

                    <label id="ComprasLabelDescripcion">Seat León 1.9 en perfecto estado, modelo de 2002, 5 puertas, 115CV con 125.000 Km.</label>
                    <label id="ComprasLabelPrecio">Precio: 9.500 €</label>
                    <label id="ComprasLabelGarantia">Garantia: 6 meses</label>
                    <button type="button" id="ComprasBotonComprar">Comprar</button> 
                </div>

                <div style="border-width: medium; height: 154px; border-bottom-style: outset;">
                    <br />
                    <asp:Label ID="Label2" runat="server" Text="AUDI A4, 2.2" Font-Overline="False" Font-Underline="True" Font-Size="Medium" Font-Bold="True"></asp:Label>
                    <br />
                    <asp:Image ID="Image1" runat="server" Height="96px" 
                    ImageUrl="~/Imagenes/ImagenesCompras/a4.jpg" Width="165px"/>

                    <label id="ComprasLabelDescripcion">Audi A4 2.2 recién revisado y con ITV pasada, modelo de 2009, 5 puertas, 205CV con 75.000 Km.</label>
                    <label id="ComprasLabelPrecio">Precio: 14.300 €</label>
                    <label id="ComprasLabelGarantia">Garantia: 12 meses</label>
                    <button type="button" id="ComprasBotonComprar">Comprar</button> 
                </div>

                <div style="border-width: medium; height: 154px; border-bottom-style: outset;">
                    <br />
                    <asp:Label ID="Label3" runat="server" Text="FORD FIESTA, 1.2" Font-Overline="False" Font-Underline="True" Font-Size="Medium" Font-Bold="True"></asp:Label>
                    <br />
                    <asp:Image ID="Image3" runat="server" Height="96px" 
                    ImageUrl="~/Imagenes/ImagenesCompras/fiesta.jpg" Width="165px"/>

                    <label id="ComprasLabelDescripcion">Ford Fiesta 1.2, pequeñas rayaduras en los paragolpes, mecánica en perfecto estado, modelo de 2010, 5 puertas, 60CV con 212.500 Km.</label>
                    <label id="ComprasLabelPrecio">Precio: 3.100 €</label>
                    <label id="ComprasLabelGarantia">Garantia: No</label>
                    <button type="button" id="ComprasBotonComprar">Comprar</button> 
                </div>
            </div>
    </div>
</asp:Content>
