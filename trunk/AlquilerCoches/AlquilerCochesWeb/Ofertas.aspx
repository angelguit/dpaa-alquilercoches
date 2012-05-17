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
                    Orientation="Horizontal" Font-Bold="True" 
                     onmenuitemclick="mnuMainMenu_MenuItemClick">
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
                            
                            <div id="Listview">
                            <asp:ListView runat="server" ID="VehiculosListView" >
                                <LayoutTemplate>
                                <table cellpadding="3" runat="server" id="Vehiculo">
                                    <tr runat="server" id="itemPlaceholder">
                                    </tr>
                                </table>
                                <div id="aspectobotoneslistview">
                                    <asp:DataPager runat="server" ID="DataPager" PageSize="3">
                                        <Fields >
                                        <asp:NumericPagerField 
                                            ButtonCount="5"
                                            PreviousPageText="&lt; "
                                            NextPageText=" &gt;" />
                                        </Fields>
                                    </asp:DataPager>
                                </div>
                                </LayoutTemplate>
                                <ItemTemplate>
                                    <br />
                                    <tr id="Tr1" runat="server">
                                    <td valign="top" colspan="2" align="center" class="Vehiculo">
	                                    <asp:Label ID="Label2" runat="server" Text='<%#Eval("Matricula") %>' 
                                         Font-Overline="False" Font-Underline="True" Font-Size="Medium" Font-Bold="True"></asp:Label>
                                    </td>
                                    </tr>


                                    <tr id="Tr2" style="height:72px" runat="server">
                                    <td valign="top" class="Imagen">
                                        <asp:Image ID="Image2" runat="server" Height="96px" 
                                        ImageUrl='<%#"/Imagenes/ImagenesReserva/fotosCoches/" + Eval("Matricula") + ".jpg" %>' Width="165px"/>
                                        
                                    </td>
                                    <td valign="top" class="DescOferta">
                                        <asp:Label id="Marca"  runat="server" Text='<%#Eval("Marca") %>'
                                        Font-Bold="True"> </asp:Label>
                                        <asp:Label id="Modelo"  runat="server" Text='<%#Eval("Modelo") %>'
                                        Font-Bold="True"></asp:Label>
                                        <br />
                                        <asp:Label id="Precio"  runat="server" Text='<%#Eval("PrecioVenta")%>'
                                        Font-Bold="True"></asp:Label>
                                        <br />
                                        <asp:Label id="KM"  runat="server" Text='<%#Eval("KM")%>'
                                        Font-Bold="True"></asp:Label>
                                        <br />
                                        <button type="button" id="OfertaBotonComprar">Alquilar</button> 
                                    </td>
                                    </tr>
                                </ItemTemplate>
                                
                                </asp:ListView>
                                </div>


                            
                            
                        </asp:View>        
                        <asp:View ID="View2" runat="server">
                            <div id="Div1">
                            <asp:ListView runat="server" ID="ListView1" >
                                <LayoutTemplate>
                                <table cellpadding="3" runat="server" id="Vehiculo">
                                    <tr runat="server" id="itemPlaceholder">
                                    </tr>
                                </table>
                                <div id="aspectobotoneslistview">
                                    <asp:DataPager runat="server" ID="DataPager" PageSize="3">
                                        <Fields >
                                        <asp:NumericPagerField 
                                            ButtonCount="5"
                                            PreviousPageText="<--"
                                            NextPageText="-->" />
                                        </Fields>
                                    </asp:DataPager>
                                </div>
                                </LayoutTemplate>
                                <ItemTemplate>
                                    <br />
                                    <tr id="Tr1" runat="server">
                                    <td valign="top" colspan="2" align="center" class="Vehiculo">
	                                    <asp:Label ID="Label2" runat="server" Text='<%#Eval("Matricula") %>' 
                                         Font-Overline="False" Font-Underline="True" Font-Size="Medium" Font-Bold="True"></asp:Label>
                                    </td>
                                    </tr>


                                    <tr id="Tr2" style="height:72px" runat="server">
                                    <td valign="top" class="Imagen">
                                        <asp:Image ID="Image2" runat="server" Height="96px" 
                                        ImageUrl='<%#"/Imagenes/ImagenesReserva/fotosCoches/" + Eval("Matricula") + ".jpg" %>' Width="165px"/>
                                        
                                    </td>
                                    <td valign="top" class="DescOferta">
                                        <asp:Label id="Marca"  runat="server" Text='<%#Eval("Marca") %>'
                                        Font-Bold="True"> </asp:Label>
                                        <asp:Label id="Modelo"  runat="server" Text='<%#Eval("Modelo") %>'
                                        Font-Bold="True"></asp:Label>
                                        <br />
                                        <asp:Label id="Precio"  runat="server" Text='<%#Eval("PrecioVenta")%>'
                                        Font-Bold="True"></asp:Label>
                                        <br />
                                        <asp:Label id="KM"  runat="server" Text='<%#Eval("KM")%>'
                                        Font-Bold="True"></asp:Label>
                                        <br />
                                        <button type="button" id="OfertaBotonComprar">Alquilar</button> 
                                    </td>
                                    </tr>
                                </ItemTemplate>
                                
                                </asp:ListView>
                                </div>
                            
                        </asp:View>        
                        <asp:View ID="View3" runat="server">
                            <div id="Div2">
                            <asp:ListView runat="server" ID="ListView2" >
                                <LayoutTemplate>
                                <table cellpadding="3" runat="server" id="Vehiculo">
                                    <tr runat="server" id="itemPlaceholder">
                                    </tr>
                                </table>
                                <div id="aspectobotoneslistview">
                                    <asp:DataPager runat="server" ID="DataPager" PageSize="3">
                                        <Fields >
                                        <asp:NumericPagerField 
                                            ButtonCount="5"
                                            PreviousPageText="<--"
                                            NextPageText="-->" />
                                        </Fields>
                                    </asp:DataPager>
                                </div>
                                </LayoutTemplate>
                                <ItemTemplate>
                                    <br />
                                    <tr id="Tr1" runat="server">
                                    <td valign="top" colspan="2" align="center" class="Vehiculo">
	                                    <asp:Label ID="Label2" runat="server" Text='<%#Eval("Matricula") %>' 
                                         Font-Overline="False" Font-Underline="True" Font-Size="Medium" Font-Bold="True"></asp:Label>
                                    </td>
                                    </tr>


                                    <tr id="Tr2" style="height:72px" runat="server">
                                    <td valign="top" class="Imagen">
                                        <asp:Image ID="Image2" runat="server" Height="96px" 
                                        ImageUrl='<%#"/Imagenes/ImagenesReserva/fotosCoches/" + Eval("Matricula") + ".jpg" %>' Width="165px"/>
                                        
                                    </td>
                                    <td valign="top" class="DescOferta">
                                        <asp:Label id="Marca"  runat="server" Text='<%#Eval("Marca") %>'
                                        Font-Bold="True"> </asp:Label>
                                        <asp:Label id="Modelo"  runat="server" Text='<%#Eval("Modelo") %>'
                                        Font-Bold="True"></asp:Label>
                                        <br />
                                        <asp:Label id="Precio"  runat="server" Text='<%#Eval("PrecioVenta")%>'
                                        Font-Bold="True"></asp:Label>
                                        <br />
                                        <asp:Label id="KM"  runat="server" Text='<%#Eval("KM")%>'
                                        Font-Bold="True"></asp:Label>
                                        <br />
                                        <button type="button" id="OfertaBotonComprar">Alquilar</button> 
                                    </td>
                                    </tr>
                                </ItemTemplate>
                                
                                </asp:ListView>
                                </div>
                            
                        </asp:View>        
                    </asp:MultiView>
                    </div>

       

    </div>
</div>
</asp:Content>

