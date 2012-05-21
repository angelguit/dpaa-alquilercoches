<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="RegistroFinalizado.aspx.cs" Inherits="AlquilerCochesWeb.RegistroFinalizado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<link rel="stylesheet" href="Css/RegistroFinalizado.css"/>
    <style type="text/css">
        #ImagenUsuario
        {
            height: 120px;
            width: 299px;
            margin-left: 121px;
        }
        #CargarArchivo
        {
            height: 59px;
        }
        .style1
        {
            color: #3366FF;
        }
        .style2
        {
            color: #000099;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MaestraContenedor" runat="server">
 <div id="Cuerpo">	
          <div id="PerfilDatosUsuario">
            <div>
            <!--    &nbsp;<img class="Foto" alt="usuario" src="/Imagenes/ImagenesPerfil/Desconocido.jpg" /><div class="Perfilbordes">  -->
               
                  
                    <p style="text-align:center;background-color:#e6e6e6; width: 799px; font-family: verdana; height: 67px;">
                        <br />
                        ¡REGISTRO REALIZADO CON ÉXITO!</p>
                        <div id="EnviarMail">
                        
                        
                        <h3 style="width: 485px; color: #3366FF; margin-left: 174px">Le hemos enviado un resumen de registro a su e-mail.</h3>
                        <h3 style="height: 80px; width: 678px; margin-left: 79px; margin-top: 44px" 
                                class="style1"> Gracias por confiar en nosotros y no se olvide hacerse fan 
                            de nuestro <span class="style2">facebook</span>.<asp:Login ID="Login1" 
                                runat="server" 
                                
                                style="font-size: small; color: #000000; margin-left: 206px; margin-top: 72px" 
                                BorderColor="Black" onauthenticate="Login1_Authenticate">
                            </asp:Login>
                            </h3>
                        
                        </div>
                </div>
              <br />
                <iframe src="http://www.facebook.com/plugins/like.php?href=www.rentacar.net" 
                  scrolling="no" frameborder="0" 
                  style="float:left; width:200px; height:100px; margin-left: 315px; margin-top: 162px;" 
                  id="I1" name="I1"></iframe> 

            </div>        
          </div>	
          
                
            <asp:Label ID="Label12" CssClass="PerfilbotonNFactura" runat="server" Text="Imprimir" 
                    BackColor="Silver" ForeColor="White"></asp:Label>
          </div>
    </div>
</asp:Content>
