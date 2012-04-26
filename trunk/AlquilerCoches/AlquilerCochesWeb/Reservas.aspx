<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Reservas.aspx.cs" Inherits="AlquilerCochesWeb.Reservas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<link rel="stylesheet" href="Css/Reserva.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MaestraContenedor" runat="server">
 <div id="Cuerpo">	
          <div id="ReservaCuerpoPaso1">
            <p style="text-align:center; text-decoration: underline;">Primer Paso: Seleccion de fechas</p>
            <div>
                <label for="male">Fecha Inicio:</label>
                <img src="supercalendario.jgp" alt="some_text"/>
                <input type="text" name="finicio" />
                <label for="male">Hora:</label>
                <input type="text" name="horainicio" />
                </br></br>
                <label for="male">Fecha Fin:</label>
                <input type="text" name="ffinal" />
                <label for="male">Hora:</label>
                <input type="text" name="horafinal" />
                </br></br>
            </div>        
          </div>	
          <div id="ReservaCuerpoPaso2">
                <p style="text-align:center; text-decoration: underline;">Segundo paso: Informacion del vehiculo</p>
                <label for="male">Categoria:</label>
                <select>
                  <option value="volvo">A</option>
                  <option value="saab">B</option>
                  <option value="mercedes">C</option>
                  <option value="audi">D</option>
                </select> 
                </br></br>
                <label for="male">Marca:</label>
                <select>
                  <option value="volvo">Opel</option>
                  <option value="saab">Ford</option>
                  <option value="mercedes">Toyota</option>
                  <option value="audi">Seat</option>
                </select> 
                </br></br>
                <label for="male">Modelo:</label>
                <select>
                  <option value="volvo">Astra</option>
                  <option value="saab">Saab</option>
                  <option value="mercedes">Mercedes</option>
                  <option value="audi">Audi</option>
                </select> 
                </br></br>
                <label for="male">Conductores:</label>
                <input type="text" name="conductores" />
                </br></br></br>
                <button type="button" id="ReservabotonConsulta">Consultar precio</button> 
          </div>		
    </div>
</asp:Content>
