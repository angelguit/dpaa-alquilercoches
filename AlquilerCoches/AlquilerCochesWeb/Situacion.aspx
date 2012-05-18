<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Situacion.aspx.cs" Inherits="AlquilerCochesWeb.Situacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server" onload="initialize()">
<link rel="stylesheet" href="Css/Situacion.css"/>
      <script type="text/javascript" src="https://maps.googleapis.com/maps/api/js?sensor=false"></script>
      <script type="text/javascript">
          function initialize() {
              var myLatlng = new google.maps.LatLng(38.181529, -3.6866);
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
    <form id="formContacto" action="EnviarMail.aspx" target="_blank" method="post">
        <div id="SituacionContacto">
             <p style="background-color:#e6e6e6; text-align:center"> Formulario Contacto</p>
               &nbsp <asp:Label ID="Label1" CssClass="SituacionContactoLabel" runat="server" Text="Nombre:"></asp:Label>
               <input name="Nombre" type="text" />
               <asp:TextBox ID="TTextBoxNombre" runat="server" CssClass="SituacionContactoTextBox"></asp:TextBox>

               <asp:CustomValidator ID="CustomValidatorNombre" runat="server" 
                 ErrorMessage="Formato incorrecto" 
                 ControlToValidate="TTextboxNombre"
                 onservervalidate="CustomValidatorNombre_ServerValidate" 
                 ForeColor="#CC0000"></asp:CustomValidator>
                </br></br>

                <asp:Label ID="Label2" CssClass="SituacionContactoLabel" runat="server" Text="Apellidos:"></asp:Label>
                <asp:TextBox ID="TTextBoxApellidos" runat="server" CssClass="SituacionContactoTextBox"></asp:TextBox>
              
                <asp:CustomValidator ID="CustomValidatorApellidos" runat="server" 
                 ErrorMessage="Apellidos incorrecto" 
                 ControlToValidate="TTextboxApellidos"
                 onservervalidate="CustomValidatorApellidos_ServerValidate" 
                 ForeColor="#CC0000"></asp:CustomValidator>
                </br></br>

               &nbsp&nbsp&nbsp&nbsp&nbsp <asp:Label ID="Label3" CssClass="SituacionContactoLabel" runat="server" Text="Email:"></asp:Label>
               <asp:TextBox ID="TTextBoxEmail" runat="server" CssClass="SituacionContactoTextBox"></asp:TextBox>

                 <asp:CustomValidator ID="CustomValidatorEmail" runat="server" 
                 ErrorMessage="Email incorrecto" 
                 ControlToValidate="TTextboxEmail"
                 onservervalidate="CustomValidatorEmail_ServerValidate" 
                 ForeColor="#CC0000"></asp:CustomValidator>
                </br></br>


               &nbsp<asp:Label ID="Label4" CssClass="SituacionContactoLabel" runat="server" Text="Consulta:"></asp:Label> 
               <textarea ID="TTextArea" style="margin-left:50px" rows="5" cols="26" runat="server"></textarea><br />
        
              <!--<asp:Button ID="Button1"  CssClass="RegistrobotonContacto" runat="server" Text="Enviar" onclick="Button1_Click" />-->
          <input type="submit" value="Enviar"  />
           <input type="reset" value="Borrar" />
          
        </div>
    </form>

    <div id="SituacionDatosEmpresa">
    <img class="Foto" alt="logo" src="/Imagenes/ImagenesPerfil/logo.jpg" />
    <p style="text-align:center">Telf: 967 123 123 Fax: 967 231 231 Provincia: Jaén Ciudad: Guarromán Dirección: Albatera Nº 123, Centro Comercial Las Castañas</p>
    </div>
</asp:Content>
