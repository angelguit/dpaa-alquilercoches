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
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MaestraContenedor" runat="server">
 <div id="Cuerpo">	
          <div id="PerfilDatosUsuario">
            <div>
            <!--    &nbsp;<img class="Foto" alt="usuario" src="/Imagenes/ImagenesPerfil/Desconocido.jpg" /><div class="Perfilbordes">  -->
                <div id="NuevoRegistro" 
                  style="height: 567px; width: 377px; margin-top: 0px; margin-left: 28px;">
                   <p style="text-align:center;background-color:#e6e6e6; width: 376px; font-family: verdana;">Nuevo registro</p>
                  <p style="font-family: verdana; height: 521px; margin-left: 28px; width: 345px;">
                    <asp:Label ID="Label1" runat="server" Text="Label" Width="90" font-size="14px">Nombre</asp:Label>
                       <asp:TextBox ID="TTextBoxNombre" runat="server" Width="178px"></asp:TextBox> <br /> <br /> <br /> 
      
                    <asp:Label ID="Label2" runat="server" Text="Label" Width="90" font-size="14px">Apellidos</asp:Label>
                       <asp:TextBox ID="TTextBoxApellidos" runat="server"  Width="178px"></asp:TextBox> <br /> <br /> <br /> 
                            
                    <asp:Label ID="Label3" runat="server" Text="Label" Width="90" font-size="14px">Provincia</asp:Label>
                        <asp:DropDownList ID="TDropDownListProvincia" runat="server" Height="22px" 
                           Width="185px" AutoPostBack="True" onload="TDropDownListProvincia_Load" 
                           ontextchanged="TDropDownListProvincia_TextChanged" 
                           onselectedindexchanged="TDropDownListProvincia_SelectedIndexChanged"></asp:DropDownList> <br /> <br /> <br /> 
              
                    <asp:Label ID="Label4" runat="server" Text="Label" Width="90" font-size="14px">Ciudad</asp:Label>
                       <asp:DropDownList ID="TDropDownListCiudad" runat="server" Height="22px" 
                          Width="185px" onselectedindexchanged="TDropDownListCiudad_SelectedIndexChanged"></asp:DropDownList> <br /> <br /> <br /> 
               
                    <asp:Label ID="Label5" runat="server" Text="Label" Width="90" font-size="14px">Dirección</asp:Label>
                       <asp:TextBox ID="TTextBoxDireccion" runat="server" Height="17px" Width="178px"></asp:TextBox> <br /> <br /> <br /> 
                       
                
                    <asp:Label ID="Label6" runat="server" Text="Label" Width="90" font-size="14px">Teléfono</asp:Label>
                       <asp:TextBox ID="TTextBoxTelefono" runat="server" Height="17px" Width="178px"></asp:TextBox> <br /> <br /> <br /> 
           
                    <asp:Label ID="Label7" runat="server" Text="Label" Width="90" font-size="14px">E-Mail</asp:Label>
                    <asp:TextBox ID="TTextBoxEmail" runat="server" Width="182px"></asp:TextBox> <br /> <br />  <br />   
                
                    <asp:Button ID="Button1"  CssClass="PerfilbotonUsuario" runat="server" Text="Enviar" />
                       
                    </p>
                     </div>  
                </div>
            </div>        
          </div>	
          <div id="PerfilDatosReservas">
                <p style="text-align:center; background-color:#e6e6e6; font-family: verdana;">Foto 
                    carnet</p>
                    <div id="IntroduceFoto">
                     <p style="text-align:center; font-family: verdana;font-size:11px;color:Green">
                     Por favor, introduce tu foto formato carnet para poder tener una ficha más personalizada. </p>
                    </div>
                    <div id="ImagenUsuario">
                       <asp:Image ID="Image1" runat="server" alt="usuario" Height="86px" Width="140px" 
                            src="/Imagenes/ImagenesPerfil/Desconocido.jpg"  />

                    </div>
                    <div id="CargarArchivo">
                    
                    
                        <asp:FileUpload ID="FileUpload1" runat="server" Width="319px" 
                            style="margin-left: 18px" />
                    
                    
                    </div>
          </div>		
          
                
            <asp:Label ID="Label12" CssClass="PerfilbotonNFactura" runat="server" Text="Imprimir" 
                    BackColor="Silver" ForeColor="White"></asp:Label>
          </div>
    </div>
</asp:Content>
