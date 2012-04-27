<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Ofertas.aspx.cs" Inherits="AlquilerCochesWeb.Ofertas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<link rel="stylesheet" href="Css/Ofertas.css"/>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MaestraContenedor" runat="server">
<div id="Cuerpo">
    
    <div id="Ofertas" title="Ofertas">
    <p style="text-align:center;background-color:#e6e6e6; font-family: verdana;">Ofertas</p>
        
             <div id="menuContainer">
                 <asp:Menu ID="mnuMainMenu" runat="server" BackColor="#F7F6F3" 
                    DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="Medium" 
                    ForeColor="#7C6F57"  
                    Orientation="Horizontal" Font-Bold="True">
                    <StaticSelectedStyle BackColor="#5D7B9D" />
                    <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                    <Items>
                               <asp:MenuItem Text="Clase A"></asp:MenuItem>
                               <asp:MenuItem Text="Clase B"></asp:MenuItem>
                               <asp:MenuItem Text="Clase C"></asp:MenuItem>
                    </Items>
                </asp:Menu>
                </div>

                  <div id="multiview" class="tabContents">
                    <asp:MultiView
                        id="MultiView1"
                        ActiveViewIndex="0"
                        Runat="server">
                        <asp:View ID="View1" runat="server">
                            

                            <div style="height: 154px; border-bottom-style: outset; border-bottom-width: medium;">
                                <br />
                                <asp:Label ID="Label1" runat="server" Text="SEAT LEON, 1.9" Font-Overline="False" Font-Underline="True" Font-Size="Medium" Font-Bold="True"></asp:Label>
                                <br />
                                <asp:Image ID="Image2" runat="server" Height="96px" 
                                ImageUrl="~/Imagenes/ImagenesCompras/seat-leon.jpg" Width="165px"/>

                                <label id="OfertasLabelDescripcion">Seat León 1.9 en perfecto estado, modelo de 2002, 5 puertas, 115CV con 125.000 Km.</label>
                                <label id="OfertasLabelPrecio">Precio: 500 € - 20%</label>
                                <button type="button" id="OfertaBotonComprar">Alquilar</button> 
                            </div>
                            
                        </asp:View>        
                        <asp:View ID="View2" runat="server">
                            <br />No hay ninguna oferta de clase B
                            
                        </asp:View>        
                        <asp:View ID="View3" runat="server">
                            <br />No hay ninguna oferta de clase C
                            
                        </asp:View>        
                    </asp:MultiView>
                    </div>

       

    </div>
</div>
</asp:Content>

