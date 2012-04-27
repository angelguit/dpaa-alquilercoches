<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Reservas.aspx.cs" Inherits="AlquilerCochesWeb.Reservas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<link rel="stylesheet" href="Css/Reserva.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MaestraContenedor" runat="server">
 <div id="Cuerpo">	
          <div id="ReservaCuerpoPaso1">
            <p style="text-align:center; text-decoration: underline; background-color:#e6e6e6">Primer Paso: Seleccion de fecha</p>
            <div>
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
          </div>	
          <div id="ReservaCuerpoPaso2">
                <p style="text-align:center; text-decoration: underline; background-color: #e6e6e6">Segundo paso: Informacion del vehiculo</p>
                </br>
                <img src="Imagenes/ImagenesReserva/astra.jpg" alt="texto" id="ReservasFotoCoche"/>
                <label for="male">&nbsp Categoria:</label>
                <select>
                  <option value="volvo">A</option>
                  <option value="saab">B</option>
                  <option value="mercedes">C</option>
                  <option value="audi">D</option>
                </select> 
                </br></br>
                <label for="male">&nbsp Marca:</label>
                <select>
                  <option value="volvo">Opel</option>
                  <option value="saab">Ford</option>
                  <option value="mercedes">Toyota</option>
                  <option value="audi">Seat</option>
                </select> 
                </br></br>
                <label for="male">&nbsp Modelo:</label>
                <select>
                  <option value="volvo">Astra</option>
                  <option value="saab">Saab</option>
                  <option value="mercedes">Mercedes</option>
                  <option value="audi">Audi</option>
                </select> 
                </br></br>
                <label for="male">&nbsp Conductores:</label>
                <input type="text" name="conductores" size="1"/>
                
                </br></br>
                &nbsp
                <button type="button" id="ReservabotonConsulta">Consultar precio</button> 
          </div>		
          <div id="ReservaCuerpoPaso3">
                <p style="text-align:center; text-decoration: underline; background-color:#e6e6e6">Tercer Paso: Descuentos</p>
                <label for="male">&nbsp Codigo promocional:</label>
                <input type="text" name="conductores" size="10"/>
          </div>
    </div>
</asp:Content>
