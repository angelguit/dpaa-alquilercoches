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
                            <br />No hay ninguna oferta de clase A
                            
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

