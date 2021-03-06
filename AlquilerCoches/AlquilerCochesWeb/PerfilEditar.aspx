﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="PerfilEditar.aspx.cs" Inherits="AlquilerCochesWeb.PerfilEditar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<link rel="stylesheet" href="Css/PerfilEditar.css"/>

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
                   <p style="text-align:center;background-color:#e6e6e6; width: 376px; font-family: verdana;">Editar Usuario</p>
                   <p style="font-family: verdana; height: 521px; margin-left: 28px; width: 345px;">
                    <asp:Label ID="Label1" runat="server" Text="Label" Width="90" font-size="14px">Nombre</asp:Label>
                       <asp:TextBox ID="TTextBoxNombre" runat="server" Width="178px"></asp:TextBox>
                      
                        <asp:RegularExpressionValidator ID="RegularExpressionValidatorNombre" runat="server" 
                            ErrorMessage="*"
                            controltovalidate="TTextBoxNombre"
                            validationexpression="^[A-Za-zñÑáéíóúÁÉÍÓÚçÇ\s]{3,30}$" ForeColor="#CC0000"></asp:RegularExpressionValidator><br /><br />


                    <asp:Label ID="Label2" runat="server" Text="Label" Width="90" font-size="14px">Apellidos</asp:Label>
                       <asp:TextBox ID="TTextBoxApellidos" runat="server"  Width="178px"></asp:TextBox> 
                      
                        <asp:RegularExpressionValidator ID="RegularExpressionValidatorApellidos" runat="server" 
                            ErrorMessage="*"
                            controltovalidate="TTextBoxApellidos"
                            validationexpression="^[A-Za-zñÑáéíóúÁÉÍÓÚçÇ\s]{3,30}$" ForeColor="#CC0000"></asp:RegularExpressionValidator><br /><br />
                            
                    <asp:Label ID="Label3" runat="server" Text="Label" Width="90" font-size="14px">Provincia</asp:Label>
                        <asp:DropDownList ID="TDropDownListProvincia" runat="server" Height="22px" 
                           Width="185px" AutoPostBack="True" onload="TDropDownListProvincia_Load" 
                           ontextchanged="TDropDownListProvincia_TextChanged"></asp:DropDownList>

                           <asp:RegularExpressionValidator ID="RegularExpressionValidatorProvi" runat="server" 
                            ErrorMessage="*"
                            controltovalidate="TDropDownListProvincia"
                            validationexpression="^[A-Za-zñÑáéíóúÁÉÍÓÚçÇ\s]{3,30}$" ForeColor="#CC0000"></asp:RegularExpressionValidator><br /><br />
              
                    <asp:Label ID="Label4" runat="server" Text="Label" Width="90" font-size="14px">Ciudad</asp:Label>
                       <asp:DropDownList ID="TDropDownListCiudad" runat="server" Height="22px" Width="185px"></asp:DropDownList> <br /> <br />
               
                    <asp:Label ID="Label5" runat="server" Text="Label" Width="90" font-size="14px">Dirección</asp:Label>
                       <asp:TextBox ID="TTextBoxDireccion" runat="server" Height="22px" Width="178px"></asp:TextBox>

                       <asp:RegularExpressionValidator ID="RegularExpressionValidatorDirecc" runat="server" 
                            ErrorMessage="*"
                            controltovalidate="TTextBoxDireccion"
                            validationexpression="^[A-Za-zñÑáéíóúÁÉÍÓÚçÇ\s]{3,40}$" ForeColor="#CC0000"></asp:RegularExpressionValidator><br /><br />

                
                    <asp:Label ID="Label6" runat="server" Text="Label" Width="90" font-size="14px">Teléfono</asp:Label>
                       <asp:TextBox ID="TTextBoxTelefono" runat="server" Height="22px" Width="179px"></asp:TextBox>
                       
                        <asp:RegularExpressionValidator ID="RegularExpressionValidatorTelefono" runat="server" 
                            ErrorMessage="*"
                            controltovalidate="TTextBoxTelefono"
                            validationexpression="^[0-9]{9}$" ForeColor="#CC0000"></asp:RegularExpressionValidator><br /><br />
           
                    <asp:Label ID="Label7" runat="server" Text="Label" Width="90" font-size="14px">E-Mail</asp:Label>
                    <asp:TextBox ID="TTextBoxEmail" runat="server" Width="182px"></asp:TextBox>
                    
                        <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server" 
                            ErrorMessage="*"
                            controltovalidate="TTextBoxEmail"
                            validationexpression="^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$" ForeColor="#CC0000"></asp:RegularExpressionValidator><br /><br /><br />

                    Cambiar password:<br /><br />
                    <asp:Label ID="Label8" runat="server" Text="Label" Width="90" font-size="14px">Password(1)</asp:Label> 
                    <asp:TextBox ID="TTextBoxPass"  runat="server"  Width="182px"></asp:TextBox>
                       <!-- se puede usar textmode="Password" per hay algun problemilla q surge-->
                       <asp:CompareValidator ID="CompareValidatorPass0" runat="server"
                              ErrorMessage="*"
                              ControlToValidate="TTextBoxPass"
                              ControlToCompare="TTextBoxPass2"
                              ForeColor="#CC0000"></asp:CompareValidator>
                       
                       <br /> <br />

                    <asp:Label ID="Label9" runat="server" Text="Label" Width="90" font-size="14px">Password(2)</asp:Label>
                    <asp:TextBox ID="TTextBoxPass2" runat="server" Width="182px"></asp:TextBox>
                       
                       <asp:CompareValidator ID="CompareValidatorPass" runat="server"
                              ErrorMessage="*"
                              ControlToValidate="TTextBoxPass"
                              ControlToCompare="TTextBoxPass2"
                              ForeColor="#CC0000"></asp:CompareValidator>
                       
                       <br /> <br />
                       <asp:Label ID="LabelErrorCampos" style="color:Red" runat="server" Text="Error, rellene los campos correctamente"></asp:Label>
                       <asp:Button ID="ButtonGuardar"  CssClass="PerfilbotonUsuario" runat="server" 
                           Text="Guardar" onclick="Button1_Click" />
                       
                    </p>
                     </div>  
                </div>
            </div>        
          </div>	
          <div id="PerfilDatosImagen">
                <p style="text-align:center; background-color:#e6e6e6; font-family: verdana;">Foto 
                    carnet                  carnet</p>
                    <div id="IntroduceFoto">
                     <p style="text-align:center; font-family: verdana;font-size:11px;color:Green">
                     Por favor, introduce tu foto formato carnet para poder tener una ficha más personalizada. </p>
                    </div>
                    <div id="ImagenUsuario">
                       <asp:Image ID="FotoUsuario" runat="server" CssClass="Foto" alt="usuario" />

                    </div>
                    <div id="CargarArchivo">
                    
                     <asp:FileUpload ID="FileUpload1" style="margin-left: 18px" runat="server" Width="319px" /></br>
                        <asp:Button ID="ButtonSubirImagen" style="margin-left:18px;" runat="server" Text="Subir Imagen" 
                            onclick="ButtonSubirImagen_Click"/>
                       <asp:Label id="UploadStatusLabel" runat="server"></asp:Label>
                    
                    
                    </div>
          </div>		
          
          </div>
    </div>
</asp:Content>

