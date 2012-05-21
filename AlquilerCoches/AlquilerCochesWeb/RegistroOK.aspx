<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="AlquilerCochesWeb.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<link rel="stylesheet" href="Css/Registro.css"/>
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
            color: #0000CC;
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
                                class="style1"> Gracias por confiar 
                            en nosotros y no se olvide hacerse fan nuestro de <span class="style2">facebook</span> ;) </h3>
                        
                        </div>
                </div>
        <asp:Login ID="IndexLoginC" runat="server" Height="150px" Width="306px" 
            LoginButtonText="Acceder" RememberMeText="Recordarme la próxima vez." 
            onauthenticate="IndexLoginC_Authenticate" 
            DestinationPageUrl="~/Index.aspx">
            <CheckBoxStyle CssClass="IndexCheck" />
            <LabelStyle CssClass="IndexLabel" />
            <LoginButtonStyle CssClass="IndexBotonAcceder" />
            <TextBoxStyle CssClass="IndexTextBox" />
            <TitleTextStyle CssClass="IndexTitle" />
        </asp:Login>
              <br />
                <iframe src="http://www.facebook.com/plugins/like.php?href=www.rentacar.net" 
                  scrolling="no" frameborder="0" 
                  style="float:left; width:200px; height:100px; margin-left: 315px; margin-top: 37px;" 
                  id="I1" name="I1"></iframe> 

            </div>        
          </div>	
          
                
            <asp:Label ID="Label12" CssClass="PerfilbotonNFactura" runat="server" Text="Imprimir" 
                    BackColor="Silver" ForeColor="White"></asp:Label>
          </div>
    </div>
</asp:Content>
