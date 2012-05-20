<%@ Page Title="Rent A Car" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Reservas.aspx.cs" Inherits="AlquilerCochesWeb.Reservas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<link rel="stylesheet" href="Css/Reserva.css"/>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MaestraContenedor" runat="server">
 <div id="Cuerpo">
     
    <form id="formularioReserva" onsubmit="return enviar()">
            <asp:Panel id="errorRegistrado" runat="server" Visible="False">
          Para realizar una reserva debe estar registrado. 
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Registro.aspx">Registrese</asp:HyperLink>
            o entre con su 
            <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/Index.aspx">cuenta</asp:HyperLink>
        </asp:Panel>
        <asp:Panel id="errorReserva" runat="server" Visible="False">
          El coche ya esta reservado. A continuacion le mostramos un modelo similar.
        </asp:Panel>
          <div id="ReservaCuerpoPaso1">
            <p style="text-align:center; text-decoration: underline; background-color:#e6e6e6">Primer Paso: Seleccion de fecha</p>
                <label for="male"">&nbsp Desde:</label>
                <asp:TextBox ID="IndexTextFechaInicio" runat="server" Height="21px" Width="82px"></asp:TextBox>

                <input type="image" name="CalendarioInicio" 
                id="CalendarioInicio" src="Imagenes/ImagenesReserva/supercalendario.jpg" 
                onclick="javascript:MostrarCalendario()" alt="Click para mostrar calendario" 
                style="border-width:0px;" />

                <ajaxToolkit:CalendarExtender ID="IndexFechaInicio" runat="server"
                    TargetControlID="IndexTextFechaInicio"
                    CssClass="AspectoCalendario"
                    Format="dd/MM/yyyy"
                    PopupButtonID="CalendarioInicio" />

                <ajaxToolkit:CalendarExtender ID="IndexFechaFin" runat="server"
                    TargetControlID="IndexTextFechaFin"
                    CssClass="AspectoCalendario"
                    Format="dd/MM/yyyy"
                    PopupButtonID="CalendarioFin" />

                <asp:ScriptManager ID="ScriptManager1" runat="server" EnableScriptGlobalization="True"  ></asp:ScriptManager>

                <label for="male"">&nbsp Hasta:</label>
                <asp:TextBox ID="IndexTextFechaFin" runat="server" Height="21px" Width="82px"></asp:TextBox>
                <input type="image" name="CalendarioFin" 
                    id="CalendarioFin" src="Imagenes/ImagenesReserva/supercalendario.jpg" 
                    onclick="javascript:MostrarCalendario()" alt="Click para mostrar calendario" 
                    style="border-width:0px;" />
                </br>
                     
                                     
                <asp:CompareValidator ID="Posterior" runat="server"
                    ErrorMessage="Error, revise las fechas"
                    ControlToValidate="IndexTextFechaInicio"
                    Operator="GreaterThan"
                    Type="String"
                    EnableViewState="false"
                    Enabled="true"
                    CssClass="AspectoError"></asp:CompareValidator>
                
                <asp:CompareValidator ID="CompareValidatorFechas" runat="server"
                    ErrorMessage="Error, revise las fechas"
                    ControlToValidate="IndexTextFechaFin"
                    ControlToCompare="IndexTextFechaInicio"
                    Operator="GreaterThanEqual"
                    Type="Date"
                    EnableViewState="false"
                    Enabled="true"
                    CssClass="AspectoError"></asp:CompareValidator>
                    </br>     
          </div>	
          <div id="ReservaCuerpoPaso2">
                <p style="text-align:center; text-decoration: underline; background-color: #e6e6e6">Segundo paso: Informacion del vehiculo</p>
                <asp:Image ID="ImagenCoche" runat="server" CssClass="ReservasFotoCoche" />
                <label for="male">&nbsp Categoria:</label>
              <asp:DropDownList ID="comboCategorias" runat="server"
                    ontextchanged="comboCategorias_TextChanged"
                     AutoPostBack="True">
              </asp:DropDownList>
                </br></br>
                <label for="marcas">&nbsp Marca:</label>
              <asp:DropDownList ID="comboMarcas" runat="server" AutoPostBack="True" 
                    ontextchanged="comboMarcas_TextChanged">
              </asp:DropDownList>
                </br></br>
                <label for="male">&nbsp Modelo:</label>
              <asp:DropDownList ID="comboModelos" runat="server" AutoPostBack="True">
              </asp:DropDownList>
                </br></br>
                <label for="male">&nbsp Conductores:</label>
                <asp:TextBox ID="conductores" runat="server" ></asp:TextBox>
              <asp:CustomValidator ID="CustomValidator1" runat="server" 
                    ErrorMessage="Incorrecto" 
                     ControlToValidate="conductores"
                    onservervalidate="validacionConductores">
              </asp:CustomValidator>
                </br></br>
                &nbsp
          </div>		
          <div id="ReservaCuerpoPaso3">
                <p style="text-align:center; text-decoration: underline; background-color:#e6e6e6">Tercer Paso: Descuentos</p>
                <label for="male">&nbsp Codigo promocional:</label>
                <asp:TextBox ID="codigo" runat="server" ></asp:TextBox>
          
          <asp:Button ID="ReservaBotonPrecio" CssClass="ReservabotonPrecio" 
              runat="server" Text="Consultar precio" onclick="ReservabotonPrecio_Click"/>
          </div>

          <div id="ReservaCuerpoPaso4">
                <p style="text-align:center; text-decoration: underline; background-color:#e6e6e6">Cuarto Paso: Confirmar reserva</p>
                <label for="male">&nbsp Precio:</label>
                <asp:TextBox ID="precio" runat="server" ></asp:TextBox>
          
              <asp:Button ID="ReservabotonConsulta" CssClass="ReservabotonConsulta" 
                  runat="server" Text="Realizar reserva" onclick="ReservabotonConsulta_Click" Enabled="True" Visible="False" />
          </div>
          </br>

          
       </form>
    </div>
</asp:Content>
