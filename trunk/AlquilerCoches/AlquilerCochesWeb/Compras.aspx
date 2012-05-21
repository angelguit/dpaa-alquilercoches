<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Compras.aspx.cs" Inherits="AlquilerCochesWeb.Compras" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<link rel="stylesheet" href="Css/Compras.css"/>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MaestraContenedor" runat="server">
    <div id="Cuerpo">

        <div id="ComprasCuerpoTitulo">
                <p style="text-align:center; background-color:#e6e6e6; text-transform: capitalize; 
                    font-size: 14pt;">Vehículos en Venta</p>

            <div id="menuContainer">
                <asp:Menu ID="ComprasMenu" runat="server" BackColor="#F7F6F3" DynamicHorizontalOffset="2"
                    Font-Names="Verdana" Font-Size="Medium" ForeColor="#7C6F57" Orientation="Horizontal"
                    Font-Bold="True" OnMenuItemClick="ComprasMenu_MenuItemClick">
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
            <asp:MultiView id="ComprasMultiView" ActiveViewIndex="0" Runat="server">

            <!--CATEGORIA NUMERO 1-->

            <asp:View ID="View1" runat="server">
                <asp:ListView runat="server" ID="ComprasListView" onitemcommand="ComprasListView_ItemCommand">
                    <LayoutTemplate>
                        <table cellpadding="0" runat="server" id="Compra" width="100%" border="0">
                            <tr runat="server" id="itemPlaceholder">
                            </tr>
                        </table>
                        <div id="aspectobotoneslistview">
                            <asp:DataPager runat="server" ID="DataPager" PageSize="3">
                                <Fields >
                                    <asp:NumericPagerField ButtonCount="5" PreviousPageText="&lt; " NextPageText=" &gt;" />
                                </Fields>
                            </asp:DataPager>
                        </div>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <tr id="Tr1" runat="server">
                            <td valign="top" colspan="3" align="center" class="Compra">
	                            <asp:Label ID="Label2" runat="server" Text='<%#Eval("Matricula") %>' 
                                    Font-Overline="False" Font-Underline="True" Font-Size="Medium" Font-Bold="True">
                                 </asp:Label>
                            </td>
                        </tr>


                        <tr id="Tr2" style="height:72px" runat="server">
                            <td valign="top" class="Imagen" style="text-align: center; vertical-align: middle">
                                <asp:Image ID="Image2" runat="server" Height="96px" 
                                    ImageUrl='<%#"/Imagenes/ImagenesCompra/CochesCompra/Turismos/" + Eval("Matricula") + ".jpg" %>' Width="165px" ImageAlign="Left"/>
                            </td>
                            <td valign="top" class="DescOferta">
                                <asp:Label id="Marca"  runat="server" Text='<%#Eval("Marca") %>' Font-Bold="True"> </asp:Label>
                                <asp:Label id="Modelo"  runat="server" Text='<%#Eval("Modelo") %>' Font-Bold="True"></asp:Label>
                            <br />
                                <asp:Label id="Label1"  runat="server" Text='Precio:' Font-Bold="True"> </asp:Label>
                                <asp:Label id="Precio"  runat="server" Text='<%#Eval("PrecioVenta")%>' Font-Bold="True"></asp:Label>
                                <asp:Label id="Label4"  runat="server" Text='€' Font-Bold="True"> </asp:Label>
                            <br />
                                <asp:Label id="Label3"  runat="server" Text='KM:' Font-Bold="True"> </asp:Label>
                                <asp:Label id="KM"  runat="server" Text='<%#Eval("KM")%>' Font-Bold="True"></asp:Label>
                            <br />
                                <td valign="top" class="DescOferta" style="text-align: center; vertical-align: middle;">
                                    <asp:LinkButton ID="BotonComprar" runat="server" Text='Comprar'  CommandName='Comprar' CommandArgument='<%#Eval("Matricula") %>'></asp:LinkButton>
                                </td>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:ListView>
            </asp:View>  
                  
        <!--CATEGORIA NUMERO 2-->
        
        <asp:View ID="View2" runat="server">
                <asp:ListView runat="server" ID="ListView1" onitemcommand="ComprasListView_ItemCommand">
                    <LayoutTemplate>
                        <table cellpadding="0" runat="server" id="Compra" width="100%" border="0">
                            <tr runat="server" id="itemPlaceholder">
                            </tr>
                        </table>
                        <div id="aspectobotoneslistview">
                            <asp:DataPager runat="server" ID="DataPager" PageSize="3">
                                <Fields >
                                    <asp:NumericPagerField ButtonCount="5" PreviousPageText="&lt; " NextPageText=" &gt;" />
                                </Fields>
                            </asp:DataPager>
                        </div>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <tr id="Tr1" runat="server">
                            <td valign="top" colspan="3" align="center" class="Compra">
	                            <asp:Label ID="Label2" runat="server" Text='<%#Eval("Matricula") %>' 
                                    Font-Overline="False" Font-Underline="True" Font-Size="Medium" Font-Bold="True">
                                 </asp:Label>
                            </td>
                        </tr>


                        <tr id="Tr2" style="height:72px" runat="server">
                            <td valign="top" class="Imagen" style="text-align: center; vertical-align: middle">
                                <asp:Image ID="Image2" runat="server" Height="96px" 
                                    ImageUrl='<%#"/Imagenes/ImagenesCompra/CochesCompra/Familiares/" + Eval("Matricula") + ".jpg" %>' Width="165px" ImageAlign="Left"/>
                            </td>
                            <td valign="top" class="DescOferta">
                                <asp:Label id="Marca"  runat="server" Text='<%#Eval("Marca") %>' Font-Bold="True"> </asp:Label>
                                <asp:Label id="Modelo"  runat="server" Text='<%#Eval("Modelo") %>' Font-Bold="True"></asp:Label>
                            <br />
                                <asp:Label id="Label1"  runat="server" Text='Precio:' Font-Bold="True"> </asp:Label>
                                <asp:Label id="Precio"  runat="server" Text='<%#Eval("PrecioVenta")%>' Font-Bold="True"></asp:Label>
                                <asp:Label id="Label4"  runat="server" Text='€' Font-Bold="True"> </asp:Label>
                            <br />
                                <asp:Label id="Label3"  runat="server" Text='KM:' Font-Bold="True"> </asp:Label>
                                <asp:Label id="KM"  runat="server" Text='<%#Eval("KM")%>' Font-Bold="True"></asp:Label>
                            <br />
                                <td valign="top" class="DescOferta" style="text-align: center; vertical-align: middle;">
                                    <asp:LinkButton ID="BotonComprar" runat="server" Text='Comprar'  CommandName='Comprar' CommandArgument='<%#Eval("Matricula") %>'></asp:LinkButton>    
                                </td>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:ListView>
            </asp:View>                     

        <!--CATEGORIA NUMERO 3-->
            
        <asp:View ID="View3" runat="server">
                <asp:ListView runat="server" ID="ListView2" onitemcommand="ComprasListView_ItemCommand">
                    <LayoutTemplate>
                        <table cellpadding="0" runat="server" id="Compra" width="100%" border="0">
                            <tr runat="server" id="itemPlaceholder">
                            </tr>
                        </table>
                        <div id="aspectobotoneslistview">
                            <asp:DataPager runat="server" ID="DataPager" PageSize="3">
                                <Fields >
                                    <asp:NumericPagerField ButtonCount="5" PreviousPageText="&lt; " NextPageText=" &gt;" />
                                </Fields>
                            </asp:DataPager>
                        </div>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <tr id="Tr1" runat="server">
                            <td valign="top" colspan="3" align="center" class="Compra">
	                            <asp:Label ID="Label2" runat="server" Text='<%#Eval("Matricula") %>' 
                                    Font-Overline="False" Font-Underline="True" Font-Size="Medium" Font-Bold="True">
                                 </asp:Label>
                            </td>
                        </tr>


                        <tr id="Tr2" style="height:72px" runat="server">
                            <td valign="top" class="Imagen" style="text-align: center; vertical-align: middle">
                                <asp:Image ID="Image2" runat="server" Height="96px" 
                                    ImageUrl='<%#"/Imagenes/ImagenesCompra/CochesCompra/Furgonetas/" + Eval("Matricula") + ".jpg" %>' Width="165px" ImageAlign="Left"/>
                            </td>
                            <td valign="top" class="DescOferta">
                                <asp:Label id="Marca"  runat="server" Text='<%#Eval("Marca") %>' Font-Bold="True"> </asp:Label>
                                <asp:Label id="Modelo"  runat="server" Text='<%#Eval("Modelo") %>' Font-Bold="True"></asp:Label>
                            <br />
                                <asp:Label id="Label1"  runat="server" Text='Precio:' Font-Bold="True"> </asp:Label>
                                <asp:Label id="Precio"  runat="server" Text='<%#Eval("PrecioVenta")%>' Font-Bold="True"></asp:Label>
                                <asp:Label id="Label4"  runat="server" Text='€' Font-Bold="True"> </asp:Label>
                            <br />
                                <asp:Label id="Label3"  runat="server" Text='KM:' Font-Bold="True"> </asp:Label>
                                <asp:Label id="KM"  runat="server" Text='<%#Eval("KM")%>' Font-Bold="True"></asp:Label>
                            <br />
                                <td valign="top" class="DescOferta" style="text-align: center; vertical-align: middle;">
                                    <asp:LinkButton ID="BotonComprar" runat="server" Text='Comprar'  CommandName='Comprar' CommandArgument='<%#Eval("Matricula") %>'></asp:LinkButton>
                                </td>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:ListView>
            </asp:View>  
        
        <!--CATEGORIA NUMERO 4-->        
         
            <asp:View ID="View4" runat="server">
                <asp:ListView runat="server" ID="ListView3" onitemcommand="ComprasListView_ItemCommand">
                    <LayoutTemplate>
                        <table cellpadding="0" runat="server" id="Compra" width="100%" border="0">
                            <tr runat="server" id="itemPlaceholder">
                            </tr>
                        </table>
                        <div id="aspectobotoneslistview">
                            <asp:DataPager runat="server" ID="DataPager" PageSize="3">
                                <Fields >
                                    <asp:NumericPagerField ButtonCount="5" PreviousPageText="&lt; " NextPageText=" &gt;" />
                                </Fields>
                            </asp:DataPager>
                        </div>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <tr id="Tr1" runat="server">
                            <td valign="top" colspan="3" align="center" class="Compra">
	                            <asp:Label ID="Label2" runat="server" Text='<%#Eval("Matricula") %>' 
                                    Font-Overline="False" Font-Underline="True" Font-Size="Medium" Font-Bold="True">
                                 </asp:Label>
                            </td>
                        </tr>


                        <tr id="Tr2" style="height:72px" runat="server">
                            <td valign="top" class="Imagen" style="text-align: center; vertical-align: middle">
                                <asp:Image ID="Image2" runat="server" Height="96px" 
                                    ImageUrl='<%#"/Imagenes/ImagenesCompra/CochesCompra/Especiales/" + Eval("Matricula") + ".jpg" %>' Width="165px" ImageAlign="Left"/>
                            </td>
                            <td valign="top" class="DescOferta">
                                <asp:Label id="Marca"  runat="server" Text='<%#Eval("Marca") %>' Font-Bold="True"> </asp:Label>
                                <asp:Label id="Modelo"  runat="server" Text='<%#Eval("Modelo") %>' Font-Bold="True"></asp:Label>
                            <br />
                                <asp:Label id="Label1"  runat="server" Text='Precio:' Font-Bold="True"> </asp:Label>
                                <asp:Label id="Precio"  runat="server" Text='<%#Eval("PrecioVenta")%>' Font-Bold="True"></asp:Label>
                                <asp:Label id="Label4"  runat="server" Text='€' Font-Bold="True"> </asp:Label>
                            <br />
                                <asp:Label id="Label3"  runat="server" Text='KM:' Font-Bold="True"> </asp:Label>
                                <asp:Label id="KM"  runat="server" Text='<%#Eval("KM")%>' Font-Bold="True"></asp:Label>
                            <br />
                                <td valign="top" class="DescOferta" style="text-align: center; vertical-align: middle;">
                                    <asp:LinkButton ID="BotonComprar" runat="server" Text='Comprar'  CommandName='Comprar' CommandArgument='<%#Eval("Matricula") %>'></asp:LinkButton>
                                </td>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:ListView>
            </asp:View>  

        </asp:MultiView>
    </div>
    </div>
    </div>
</asp:Content>