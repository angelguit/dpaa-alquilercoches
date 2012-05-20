<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="AlquilerCochesWeb.Perfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<link rel="stylesheet" href="Css/Perfil.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MaestraContenedor" runat="server">
 <div id="Cuerpo">	
          <div id="PerfilDatosUsuario">
            <p style="text-align:center;background-color:#e6e6e6">Datos Usuario</p>
            <div>
                <!--&nbsp;<img class="Foto" alt="usuario" src="/Imagenes/ImagenesPerfil/Desconocido.jpg" />-->
                <asp:Image ID="ImagenUsuario" class="Foto" runat="server" />
                <div class="Perfilbordes">
                
                    <asp:Label ID="Label1" runat="server" Text="Label">Nombre: </asp:Label>
                    <asp:Label ID="TLabelNombre" runat="server" Text="Label"></asp:Label></br></br>

                    <asp:Label ID="Label2" runat="server" Text="Label">Apellidos: </asp:Label>
                    <asp:Label ID="TLabelApellidos" runat="server" Text="Label"></asp:Label></br></br>

                    <asp:Label ID="Label3" runat="server" Text="Label">Provincia: </asp:Label>
                    <asp:Label ID="TLabelProvincia" runat="server" Text="Label"></asp:Label></br></br>

                    <asp:Label ID="Label4" runat="server" Text="Label">Ciudad: </asp:Label>
                    <asp:Label ID="TLabelCiudad" runat="server" Text="Label"></asp:Label></br></br>

                    <asp:Label ID="Label5" runat="server" Text="Label">Dirección: </asp:Label>
                    <asp:Label ID="TLabelDireccion" runat="server" Text="Label"></asp:Label></br></br>

                    <asp:Label ID="Label6" runat="server" Text="Label">Telefono: </asp:Label>
                    <asp:Label ID="TLabelTelefono" runat="server" Text="Label"></asp:Label></br></br>

                    <asp:Label ID="Label7" runat="server" Text="Label">Email: </asp:Label>
                    <asp:Label ID="TLabelEmail" runat="server" Text="Label"></asp:Label></br></br>
                </div>
                
                 <asp:Button ID="Button1"  CssClass="PerfilbotonUsuario" runat="server" Text="Editar" PostBackUrl="~/PerfilEditar.aspx"/>

            </div>        
          </div>	
          <div id="PerfilDatosReservas">
                <p style="text-align:center; background-color:#e6e6e6"">Ultimas reservas activas</p>
                <!--<ol style="width:5cm;height:5cm; position:absolute">
                    <li>Seat Ibiza</li>
                    <li>Renault Megane</li>
                    <li>Ford Fiesta</li>
                </ol>-->
              <asp:GridView ID="TDataGridViewReservas" CssClass="TDataGridViewReservas" runat="server" CellPadding="4" 
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
                <asp:Button ID="ButtonVerhistorial"  CssClass="PerfilbotonReserva" 
                    runat="server" Text="Historial completo" ToolTip="Todas las reservas que el usuario ha realizado" onclick="Button2_Click" />
            
          </div>		
          <div id="PerfilBuscadorFactura">
           <p style="text-align:center;background-color:#e6e6e6">Imprima una factura
           <p>Imprima una copia de una factura de un alquiler realizado. 
           Complete los detalles siguientes para encontrar los alquileres realizados</p>

               <div class="PerfilFechafactura">
             
                    <div id="Calendarios">
                       <asp:ScriptManager ID="ScriptManager1" runat="server" EnableScriptGlobalization="True"  ></asp:ScriptManager>

                            <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server"
                                TargetControlID="IndexTextFechaInicio"
                                CssClass="AspectoCalendario"
                                Format=" dd/MM/yyyy"
                                PopupButtonID="CalendarioInicio" />
                             <ajaxToolkit:CalendarExtender ID="CalendarExtender2" runat="server"
                                TargetControlID="IndexTextFechaFin"
                                CssClass="AspectoCalendario"
                                Format="dd/MM/yyyy"
                                PopupButtonID="CalendarioFin" 
                                />

                             &nbsp;Desde:
                            <asp:TextBox ID="IndexTextFechaInicio" runat="server" Height="21px" 
                                Width="82px"></asp:TextBox>

                            <input type="image" name="CalendarioInicio" 
                                id="CalendarioInicio" src="/Imagenes/ImagenesReserva/supercalendario.jpg" 
                                onclick="javascript:MostrarCalendario()" /></br>
                            &nbsp;Hasta:&nbsp;
                            <asp:TextBox ID="IndexTextFechaFin" runat="server" Height="21px" Width="82px"></asp:TextBox>

                            <input type="image" name="CalendarioFin" 
                                id="CalendarioFin" src="/Imagenes/ImagenesReserva/supercalendario.jpg" 
                                onclick="javascript:MostrarCalendario()" /><br />

                    </div>
                 <asp:Button ID="TButtonFechas"  CssClass="PerfilbotonFactura" runat="server" 
                       Text="Buscar" onclick="TButtonFechas_Click"  />
               </div>
     

            <div class="PerfilNumerofactura">
                <asp:Label ID="Label11" runat="server" Text="Label">Nº Reserva:</asp:Label>
                <asp:TextBox ID="TTextBoxNumeroFactura" runat="server"></asp:TextBox>
                <asp:Button ID="Button4"  CssClass="PerfilbotonNFactura" runat="server" 
                    Text="Imprimir" onclick="TButtonNumeroFactura_Click" />
            </div>
            
            
            <div id="Apis">
                <a href="https://twitter.com/share" class="twitter-share-button" data-lang="en" style="margin-top:1cm;">Tweet</a>
                <iframe src="http://www.facebook.com/plugins/like.php?href=www.rentacar.net" scrolling="no" frameborder="0" style="float:left; width:200px; height:100px"></iframe> 

                <script> !function (d, s, id) { var js, fjs = d.getElementsByTagName(s)[0]; if (!d.getElementById(id)) { js = d.createElement(s); js.id = id; js.src = "//platform.twitter.com/widgets.js"; fjs.parentNode.insertBefore(js, fjs); } } (document, "script", "twitter-wjs");</script>
            </div>
               
                <asp:CompareValidator ID="CompareValidatorFechas" runat="server"
                    ErrorMessage="Error, revise las fechas"
                    ControlToValidate="IndexTextFechaFin"
                    ControlToCompare="IndexTextFechaInicio"
                    Operator="GreaterThanEqual"
                    Type="Date"
                    EnableViewState="false"
                    Enabled="true"
                    CssClass="AspectoError"></asp:CompareValidator>
         </div>
    </div>
    
</asp:Content>
