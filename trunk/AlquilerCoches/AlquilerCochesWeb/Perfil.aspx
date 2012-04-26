<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="AlquilerCochesWeb.Perfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<link rel="stylesheet" href="Css/Perfil.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MaestraContenedor" runat="server">
 <div id="Cuerpo">	
          <div id="PerfilDatosUsuario">
            <p style="text-align:center;background-color:#e6e6e6">Datos Usuario</p>
            <div>
                &nbsp;<img class="Foto" alt="usuario" src="/Imagenes/ImagenesPerfil/Desconocido.jpg" /><div class="Perfilbordes">
                <asp:Label ID="Label1" runat="server" Text="Label">Nombre: Juan</asp:Label></br></br>
                <asp:Label ID="Label2" runat="server" Text="Label">Apellidos: Solo Saez</asp:Label></br></br>
                <asp:Label ID="Label3" runat="server" Text="Label">Provincia: Alicante</asp:Label></br></br>
                <asp:Label ID="Label4" runat="server" Text="Label">Ciudad: Alicante</asp:Label></br></br>
                <asp:Label ID="Label8" runat="server" Text="Label">Direccion: Victor Ruiz Espla nº10</asp:Label></br></br>
                <asp:Label ID="Label7" runat="server" Text="Label">Telefono: 645454578</asp:Label></br></br>
                <asp:Label ID="Label9" runat="server" Text="Label">Email: juanito@gmail.com</asp:Label></br></br>
                </div>
                <asp:Label ID="Label5" CssClass="PerfilbotonUsuario" runat="server" Text="Editar" 
                    BackColor="Silver" ForeColor="White"></asp:Label>
            </div>        
          </div>	
          <div id="PerfilDatosReservas">
                <p style="text-align:center; background-color:#e6e6e6"">Ultimas reservas</p>
                <asp:Label ID="Label6" CssClass="PerfilbotonReserva" runat="server" Text="Ver historial" 
                    BackColor="Silver" ForeColor="White"></asp:Label>
          </div>		
          <div id="PerfilBuscadorFactura">
           <p style="text-align:center;background-color:#e6e6e6">Imprima una factura</p>
           <div class="PerfilFechafactura">Fechas </div>
          
          </div>
    </div>
</asp:Content>
