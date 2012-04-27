<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Situacion.aspx.cs" Inherits="AlquilerCochesWeb.Situacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server" onload="initialize()">
<link rel="stylesheet" href="Css/Situacion.css"/>
      <script type="text/javascript" src="https://maps.googleapis.com/maps/api/js?sensor=false"></script>
      <script type="text/javascript">
          function initialize() {
              var myLatlng = new google.maps.LatLng(38.384189, -0.514841);
              var myOptions = {
                  zoom: 8,
                  center: myLatlng,
                  mapTypeId: google.maps.MapTypeId.ROADMAP
              }
              var map = new google.maps.Map(document.getElementById("map_canvas"), myOptions);

              var marker = new google.maps.Marker({
                  position: myLatlng,
                  map: map,
                  title: "RAC!"
              });

              var contenidoString = '<div id="content"> <p> Rent a Car</p> </div>';

              var infowindow = new google.maps.InfoWindow({
                  content: contenidoString
              });

              google.maps.event.addListener(marker, 'click', function () {
                  infowindow.open(map, marker);
              });
          }
           
            
             
            
        

    google.maps.event.addDomListener(window, 'load', initialize);
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MaestraContenedor" runat="server">
    <div id="SituacionMapa">
        <div id="map_canvas"></div>
    </div>
    <div id="SituacionContacto">
         <p style="background-color:#e6e6e6; text-align:center"> Formulario Contacto</p>
           &nbsp <asp:Label ID="Label1" CssClass="SituacionContactoLabel" runat="server" Text="Nombre:"></asp:Label><asp:TextBox ID="TextBox1" CssClass="SituacionContactoTextBox"
            runat="server"></asp:TextBox></br></br>
            <asp:Label ID="Label2" CssClass="SituacionContactoLabel" runat="server" Text="Apellidos:"></asp:Label><asp:TextBox ID="TextBox2" CssClass="SituacionContactoTextBox"
            runat="server"></asp:TextBox></br></br>
           &nbsp&nbsp&nbsp&nbsp&nbsp <asp:Label ID="Label3" CssClass="SituacionContactoLabel" runat="server" Text="Email:"></asp:Label><asp:TextBox ID="TextBox3" CssClass="SituacionContactoTextBox"
            runat="server"></asp:TextBox></br></br>
           &nbsp<asp:Label ID="Label4" CssClass="SituacionContactoLabel" runat="server" Text="Consulta:"></asp:Label> <textarea style="margin-left:50px" rows="5" cols="26"></textarea><br />
    
         <asp:Label ID="Label5" CssClass="RegistrobotonContacto" runat="server" Text="Enviar" 
                    BackColor="Silver" ForeColor="White"></asp:Label>
    </div>
    <div id="SituacionDatosEmpresa">
    <img class="Foto" alt="logo" src="/Imagenes/ImagenesPerfil/logo.jpg" />
    <p style="text-align:center">Telf: 967 123 123 Fax: 967 231 231 Provincia: Alicante Ciudad: Alicante Dirección: Masatusa nº10</p>
    </div>
</asp:Content>
