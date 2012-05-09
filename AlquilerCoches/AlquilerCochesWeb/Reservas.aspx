﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Reservas.aspx.cs" Inherits="AlquilerCochesWeb.Reservas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<link rel="stylesheet" href="Css/Reserva.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MaestraContenedor" runat="server">
 <div id="Cuerpo">

    <form id="formularioReserva" onsubmit="enviar">
          <div id="ReservaCuerpoPaso1">
            <p style="text-align:center; text-decoration: underline; background-color:#e6e6e6">Primer Paso: Seleccion de fecha</p>
                <label for="male"">&nbsp Fecha Inicio</label>
                </br>
                <label for="male"">&nbsp Dia:</label>
                <input type="text" name="finicio" value="01/01/2012" size="10"/>
                <img src="Imagenes/ImagenesReserva/supercalendario.jpg" alt="texto"/>
                <label for="male">&nbsp Hora:</label>
                <input type="text" name="horainicio" value="13:00" size="5"/>
                </br></br></br>
                <label for="male">&nbsp Fecha Fin</label>
                </br>
                <label for="male"">&nbsp Dia:</label>
                <input type="text" name="ffinal" value="01/01/2012" size="10"/>
                <img src="Imagenes/ImagenesReserva/supercalendario.jpg" alt="texto"/>
                <label for="male">&nbsp Hora:</label>
                <input type="text" name="horafinal" value="13:00" size="5"/>
                </br></br>     
          </div>	
          <div id="ReservaCuerpoPaso2">
                <p style="text-align:center; text-decoration: underline; background-color: #e6e6e6">Segundo paso: Informacion del vehiculo</p>
                </br>
                <img src="Imagenes/ImagenesReserva/astra.jpg" alt="texto" id="ReservasFotoCoche"/>
                <label for="male">&nbsp Categoria:</label>
              <asp:DropDownList ID="comboCategorias" runat="server" 
                    ontextchanged="comboCategorias_TextChanged" 
                    onselectedindexchanged="comboCategorias_SelectedIndexChanged">
              </asp:DropDownList>
                </br></br>
                <label for="marcas">&nbsp Marca:</label>
              <asp:DropDownList ID="comboMarcas" runat="server">
              </asp:DropDownList>
                </br></br>
                <label for="male">&nbsp Modelo:</label>
              <asp:DropDownList ID="comboModelos" runat="server">
              </asp:DropDownList>
                </br></br>
                <label for="male">&nbsp Conductores:</label>
                <asp:TextBox ID="conductores" runat="server" ></asp:TextBox>
              <asp:CustomValidator ID="CustomValidator1" runat="server" 
                    ErrorMessage="Solo numeros" 
                     ControlToValidate="conductores"
                    onservervalidate="validacionConductores">
              </asp:CustomValidator>
                </br></br>
                &nbsp
          </div>		
          <div id="ReservaCuerpoPaso3">
                <p style="text-align:center; text-decoration: underline; background-color:#e6e6e6">Tercer Paso: Descuentos</p>
                <label for="male">&nbsp Codigo promocional:</label>
                <input type="text" name="conductores" size="10"/>
          </div>
          <asp:Button ID="ReservabotonConsulta" CssClass="ReservabotonConsulta" runat="server" Text="Consultar precio"/>
       </form>
    </div>
</asp:Content>
