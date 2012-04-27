<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Situacion.aspx.cs" Inherits="AlquilerCochesWeb.Situacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server" onload="initialize()">
<link rel="stylesheet" href="Css/Situacion.css"/>
      <script type="text/javascript" src="https://maps.googleapis.com/maps/api/js?sensor=false"></script>
      <script type="text/javascript">
        var map;
        var alicante = new google.maps.LatLng(38.384189, -0.514841);
        
        function initialize() {
            var myOptions = {
                zoom: 8,
                center: alicante,
                mapTypeId: google.maps.MapTypeId.ROADMAP
            };
            map = new google.maps.Map(document.getElementById('map_canvas'),myOptions);

             var contenidoString = '<div id="content">' +
            '<div id="siteNotice">' +
            '</div>' + '<p> Rent a Car</p>'+
            '</div>';

             var infowindow = new google.maps.InfoWindow({
                 content: contenidoString
             });

             var marker = new google.maps.Marker({
                 position: myLatlng,
                 map: map,
                 title: 'RAC'
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
    <p>MAPA</p>
        <div id="map_canvas"></div>
    </div>
    <div id="SituacionContacta">
    Formulario Contacto</br>
        <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label><asp:TextBox ID="TextBox1"
            runat="server"></asp:TextBox></br>
            <asp:Label ID="Label2" runat="server" Text="Apellidos"></asp:Label><asp:TextBox ID="TextBox2"
            runat="server"></asp:TextBox></br>
            <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label><asp:TextBox ID="TextBox3"
            runat="server"></asp:TextBox></br>
            <asp:Label ID="Label4" runat="server" Text="Consulta"></asp:Label><asp:TextBox ID="TextBox4"
            runat="server"></asp:TextBox></br>

    </div>

</asp:Content>
