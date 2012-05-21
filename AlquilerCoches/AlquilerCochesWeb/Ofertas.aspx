<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true"
    CodeBehind="Ofertas.aspx.cs" Inherits="AlquilerCochesWeb.Ofertas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="Css/Ofertas.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MaestraContenedor" runat="server">
    <div id="Cuerpo">
        <div id="Ofertas" title="Ofertas">
            <p style="text-align: center; background-color: #e6e6e6; font-family: verdana;">
                Ofertas</p>
            <div id="menuContainer">
                <asp:Menu ID="mnuMainMenu" runat="server" BackColor="#F7F6F3" DynamicHorizontalOffset="2"
                    Font-Names="Verdana" Font-Size="Medium" ForeColor="#7C6F57" Orientation="Horizontal"
                    Font-Bold="True" OnMenuItemClick="mnuMainMenu_MenuItemClick">
                    <StaticSelectedStyle BackColor="#5D7B9D" />
                    <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                    <Items>
                        <asp:MenuItem Text="Turismos"></asp:MenuItem>
                        <asp:MenuItem Text="Familiares"></asp:MenuItem>
                        <asp:MenuItem Text="Furgonetas"></asp:MenuItem>
                        <asp:MenuItem Text="Especiales"></asp:MenuItem>
                    </Items>
                </asp:Menu>
            </div>
            <div id="multiview" class="tabContents">
                <asp:MultiView ID="MultiView1" ActiveViewIndex="0" runat="server">
                    <asp:View ID="View1" runat="server">
                        <asp:ListView runat="server" ID="VehiculosListView" 
                            onitemcommand="VehiculosListView_ItemCommand">
                            <LayoutTemplate>
                                <table cellpadding="0" runat="server" id="Vehiculo"  width="100%" border="0">
                                    <tr runat="server" id="itemPlaceholder"></tr>
                                </table>
                                <div id="aspectobotoneslistview">
                                    <asp:DataPager runat="server" ID="DataPager" PageSize="3">
                                        <Fields>
                                            <asp:NumericPagerField ButtonCount="5" PreviousPageText="&lt; " NextPageText=" &gt;" />
                                        </Fields>
                                    </asp:DataPager>
                                </div>
                            </LayoutTemplate>
                            <ItemTemplate>
                                <tr id="Tr1" runat="server">
                                    <td valign="top" colspan="3" align="center" class="Vehiculo">
                                        <asp:Label ID="Matricula" runat="server" Text='<%#Eval("Matricula") %>' Font-Overline="False"
                                            Font-Underline="True" Font-Size="Medium" Font-Bold="True"></asp:Label>
                                    </td>
                                </tr>
                                <tr id="Tr2" runat="server">
                                    <td valign="top" class="Imagen" style="text-align: center; vertical-align: middle">
                                        <asp:Image ID="Image2" runat="server" Height="96px" ImageUrl='<%#"/Imagenes/ImagenesCompra/CochesCompra/Turismos/" + Eval("Matricula") + ".jpg" %>'
                                            Width="165px" ImageAlign="Left" />
                                    </td>
                                    <td valign="top" class="DescOferta">
                                        <asp:Label ID="Marca" runat="server" Text='<%#Eval("Marca") %>' Font-Bold="True"> </asp:Label>
                                        <asp:Label ID="Modelo" runat="server" Text='<%#Eval("Modelo") %>' Font-Bold="True"></asp:Label>
                                        <br></br>
                                        <asp:Label ID="Precio" runat="server" Text='<%# "Precio: " + Eval("PrecioVenta")%>' Font-Bold="True"></asp:Label>
                                        <br></br>
                                        <asp:Label ID="KM" runat="server" Text='<%#"KM: " + Eval("KM")%>' Font-Bold="True"></asp:Label>
                                    </td>
                                    <td valign="top" class="DescOferta" style="text-align: center; vertical-align: middle;">
                                        <asp:LinkButton ID="OfertaBotonComprar" runat="server" Text='Ver Descuento'  CommandName='Alquilar' CommandArgument='<%#Eval("Matricula") %>'></asp:LinkButton>
                                    </td>
                                </tr>
                            </ItemTemplate>
                        </asp:ListView>
                    </asp:View>
                    <asp:View ID="View2" runat="server">
                        <asp:ListView runat="server" ID="ListView1" 
                            onitemcommand="VehiculosListView_ItemCommand">
                            <LayoutTemplate>
                                <table cellpadding="0" runat="server" id="Vehiculo"  width="100%" border="0">
                                    <tr runat="server" id="itemPlaceholder"></tr>
                                </table>
                                <div id="aspectobotoneslistview">
                                    <asp:DataPager runat="server" ID="DataPager" PageSize="3">
                                        <Fields>
                                            <asp:NumericPagerField ButtonCount="5" PreviousPageText="&lt; " NextPageText=" &gt;" />
                                        </Fields>
                                    </asp:DataPager>
                                </div>
                            </LayoutTemplate>
                            <ItemTemplate>
                                <tr id="Tr1" runat="server">
                                    <td valign="top" colspan="3" align="center" class="Vehiculo">
                                        <asp:Label ID="Matricula" runat="server" Text='<%#Eval("Matricula") %>' Font-Overline="False"
                                            Font-Underline="True" Font-Size="Medium" Font-Bold="True"></asp:Label>
                                    </td>
                                </tr>
                                <tr id="Tr2" runat="server">
                                    <td valign="top" class="Imagen" style="text-align: center; vertical-align: middle">
                                        <asp:Image ID="Image2" runat="server" Height="96px" ImageUrl='<%#"/Imagenes/ImagenesCompra/CochesCompra/Familiares/" + Eval("Matricula") + ".jpg" %>'
                                            Width="165px" ImageAlign="Left" />
                                    </td>
                                    <td valign="top" class="DescOferta">
                                        <asp:Label ID="Marca" runat="server" Text='<%#Eval("Marca") %>' Font-Bold="True"> </asp:Label>
                                        <asp:Label ID="Modelo" runat="server" Text='<%#Eval("Modelo") %>' Font-Bold="True"></asp:Label>
                                        <br></br>
                                        <asp:Label ID="Precio" runat="server" Text='<%# "Precio: " + Eval("PrecioVenta")%>' Font-Bold="True"></asp:Label>
                                        <br></br>
                                        <asp:Label ID="KM" runat="server" Text='<%#"KM: " + Eval("KM")%>' Font-Bold="True"></asp:Label>
                                    </td>
                                    <td valign="top" class="DescOferta" style="text-align: center; vertical-align: middle;">
                                        <asp:LinkButton ID="OfertaBotonComprar" runat="server" Text='Ver Descuento'  CommandName='Alquilar' CommandArgument='<%#Eval("Matricula") %>'></asp:LinkButton>
                                    </td>
                                </tr>
                            </ItemTemplate>
                        </asp:ListView>
                    </asp:View><asp:View ID="View3" runat="server">
                        <asp:ListView runat="server" ID="ListView2" 
                            onitemcommand="VehiculosListView_ItemCommand">
                            <LayoutTemplate>
                                <table cellpadding="0" runat="server" id="Vehiculo"  width="100%" border="0">
                                    <tr runat="server" id="itemPlaceholder"></tr>
                                </table>
                                <div id="aspectobotoneslistview">
                                    <asp:DataPager runat="server" ID="DataPager" PageSize="3">
                                        <Fields>
                                            <asp:NumericPagerField ButtonCount="5" PreviousPageText="&lt; " NextPageText=" &gt;" />
                                        </Fields>
                                    </asp:DataPager>
                                </div>
                            </LayoutTemplate>
                            <ItemTemplate>
                                <tr id="Tr1" runat="server">
                                    <td valign="top" colspan="3" align="center" class="Vehiculo">
                                        <asp:Label ID="Matricula" runat="server" Text='<%#Eval("Matricula") %>' Font-Overline="False"
                                            Font-Underline="True" Font-Size="Medium" Font-Bold="True"></asp:Label>
                                    </td>
                                </tr>
                                <tr id="Tr2" runat="server">
                                    <td valign="top" class="Imagen" style="text-align: center; vertical-align: middle">
                                        <asp:Image ID="Image2" runat="server" Height="96px" ImageUrl='<%#"/Imagenes/ImagenesCompra/CochesCompra/Furgonetas/" + Eval("Matricula") + ".jpg" %>'
                                            Width="165px" ImageAlign="Left" />
                                    </td>
                                    <td valign="top" class="DescOferta">
                                        <asp:Label ID="Marca" runat="server" Text='<%#Eval("Marca") %>' Font-Bold="True"> </asp:Label>
                                        <asp:Label ID="Modelo" runat="server" Text='<%#Eval("Modelo") %>' Font-Bold="True"></asp:Label>
                                        <br></br>
                                        <asp:Label ID="Precio" runat="server" Text='<%# "Precio: " + Eval("PrecioVenta")%>' Font-Bold="True"></asp:Label>
                                        <br></br>
                                        <asp:Label ID="KM" runat="server" Text='<%#"KM: " + Eval("KM")%>' Font-Bold="True"></asp:Label>
                                    </td>
                                    <td valign="top" class="DescOferta" style="text-align: center; vertical-align: middle;">
                                        <asp:LinkButton ID="OfertaBotonComprar" runat="server" Text='Ver Descuento'  CommandName='Alquilar' CommandArgument='<%#Eval("Matricula") %>'></asp:LinkButton>
                                    </td>
                                </tr>
                            </ItemTemplate>
                        </asp:ListView>
                    </asp:View>
                    <asp:View ID="View4" runat="server">
                        <asp:ListView runat="server" ID="ListView3" 
                            onitemcommand="VehiculosListView_ItemCommand">
                            <LayoutTemplate>
                                <table cellpadding="0" runat="server" id="Vehiculo"  width="100%" border="0">
                                    <tr runat="server" id="itemPlaceholder"></tr>
                                </table>
                                <div id="aspectobotoneslistview">
                                    <asp:DataPager runat="server" ID="DataPager" PageSize="3">
                                        <Fields>
                                            <asp:NumericPagerField ButtonCount="5" PreviousPageText="&lt; " NextPageText=" &gt;" />
                                        </Fields>
                                    </asp:DataPager>
                                </div>
                            </LayoutTemplate>
                            <ItemTemplate>
                                <tr id="Tr1" runat="server">
                                    <td valign="top" colspan="3" align="center" class="Vehiculo">
                                        <asp:Label ID="Matricula" runat="server" Text='<%#Eval("Matricula") %>' Font-Overline="False"
                                            Font-Underline="True" Font-Size="Medium" Font-Bold="True"></asp:Label>
                                    </td>
                                </tr>
                                <tr id="Tr2" runat="server">
                                    <td valign="top" class="Imagen" style="text-align: center; vertical-align: middle">
                                        <asp:Image ID="Image2" runat="server" Height="96px" ImageUrl='<%#"/Imagenes/ImagenesCompra/CochesCompra/Especiales/" + Eval("Matricula") + ".jpg" %>'
                                            Width="165px" ImageAlign="Left" />
                                    </td>
                                    <td valign="top" class="DescOferta">
                                        <asp:Label ID="Marca" runat="server" Text='<%#Eval("Marca") %>' Font-Bold="True"> </asp:Label>
                                        <asp:Label ID="Modelo" runat="server" Text='<%#Eval("Modelo") %>' Font-Bold="True"></asp:Label>
                                        <br></br>
                                        <asp:Label ID="Precio" runat="server" Text='<%# "Precio: " + Eval("PrecioVenta")%>' Font-Bold="True"></asp:Label>
                                        <br></br>
                                        <asp:Label ID="KM" runat="server" Text='<%#"KM: " + Eval("KM")%>' Font-Bold="True"></asp:Label>
                                    </td>
                                    <td valign="top" class="DescOferta" style="text-align: center; vertical-align: middle;">
                                        <asp:LinkButton ID="OfertaBotonComprar" runat="server" Text='Ver Descuento'  CommandName='Alquilar' CommandArgument='<%#Eval("Matricula") %>'></asp:LinkButton>
                                    </td>
                                </tr>
                            </ItemTemplate>
                        </asp:ListView>
                        <asp:Literal runat="server" ID="Literal1"></asp:Literal>
                    </asp:View>
                    <asp:View ID="View5" runat="server">
                        <table>
                                <tr id="Tr1" runat="server">
                                    <td valign="top" colspan="3" align="center" class="Vehiculo">
                                        <asp:Label ID="Label1" runat="server" Text="SEAT LEON, 1.9" Font-Overline="False" Font-Underline="True" Font-Size="Medium" Font-Bold="True"></asp:Label>
                                    </td>
                                </tr>
                                <tr id="Tr2" runat="server">
                                    <td valign="top" class="Imagen" style="text-align: center; vertical-align: middle">
                                        <asp:Image ID="Image3" runat="server" Height="96px" Width="165px"/>
                                    </td>
                                    <td valign="top" class="DescOferta">
                                        <asp:label ID="ComprasLabelDescripcion"  runat="server" ></asp:label>
                                        <br />
                                        <asp:label ID="ComprasLabelPrecio"  runat="server" ></asp:label>
                                        <br />
                                        <asp:label ID="ComprasLabelGarantia"  runat="server" ></asp:label>
                                        <br />
                                    </td>
                                </tr>
                                <tr id="Tr3"  runat="server">
                                    <td valign="top" class="DescOferta" colspan="3" align="center">
                                        <button type="button" id="ComprasBotonComprar">Comprar</button> 
                                    </td>
                                </tr>
                            </table>
                    </asp:View>
                </asp:MultiView>
            </div>
        </div>
    </div>
</asp:Content>
