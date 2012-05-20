<%@ Page Title="Rent A Car" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AlquilerCochesWeb.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="/Javascript/jquery.min.js" type="text/javascript"></script>
    <script src="/Javascript/jquery.simplyscroll.js" type="text/javascript"></script>
    <link rel="stylesheet" href="Css/jquery.simplyscroll.css"/>
    
</asp:Content>
<asp:Content ID="Index" ContentPlaceHolderID="MaestraContenedor" runat="server">
    <div id="IndexPresentacion">
        <div id="IndexTextoPresentacion">
            <p>Rent A Car es una empresa con años de experiencia.</p>
            <p>Nuestros clientes son nuestra mayor prioridad y esperamos ofrecerle un servicio de su agrado. </p>
            <br />
            <div id="Apis">
                <a href="https://twitter.com/share" class="twitter-share-button" data-lang="en" style="margin-top:1cm;">Tweet</a>
                <iframe src="http://www.facebook.com/plugins/like.php?href=www.rentacar.net" scrolling="no" frameborder="0" style="float:left; width:200px; height:100px;"></iframe> 

                <script type="text/javascript"> !function (d, s, id) { var js, fjs = d.getElementsByTagName(s)[0]; if (!d.getElementById(id)) { js = d.createElement(s); js.id = id; js.src = "//platform.twitter.com/widgets.js"; fjs.parentNode.insertBefore(js, fjs); } } (document, "script", "twitter-wjs");</script>
            </div>
            <br />
            <br />
        </div>
    </div>
    <div id="IndexLogin">
        <asp:Label ID="TLabelBienvenida" runat="server" Text="Label"></asp:Label>
        <asp:Login ID="IndexLoginC" runat="server" Height="150px" Width="202px" 
            LoginButtonText="Acceder" RememberMeText="Recordarme la próxima vez." 
            onauthenticate="IndexLoginC_Authenticate" 
            DestinationPageUrl="~/Index.aspx">
            <CheckBoxStyle CssClass="IndexCheck" />
            <LabelStyle CssClass="IndexLabel" />
            <LoginButtonStyle CssClass="IndexBotonAcceder" />
            <TextBoxStyle CssClass="IndexTextBox" />
            <TitleTextStyle CssClass="IndexTitle" />
        </asp:Login>
        <asp:ImageButton ID="IndexLogoUsuario" runat="server" Width= "120px" 
            Height="140px" onclick="IndexLogoUsuario_Click" /> <br />
        <asp:PlaceHolder ID="IndexReservaRapida" runat="server">
            <span>Reserva Rapida</span><br />
            <!--<asp:RadioButton ID="TRadioButtonUltimaReserva" runat="server" Text="Ultima Reserva" GroupName="Radio" /><br />
            <asp:RadioButton ID="TRadioButtonReservaHabitual" runat="server" Text="Reserva Habitual" GroupName="Radio" /><br />-->
            <asp:RadioButtonList ID="TRadioButtonList" runat="server" CssClass="RadioButtons">
                <asp:ListItem>Último Vehículo</asp:ListItem>
                <asp:ListItem>Vehículo habitual</asp:ListItem>
            </asp:RadioButtonList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorReservaRapida" runat="server" ErrorMessage="Seleccione vehículo." ControlToValidate="TRadioButtonList" CssClass="AspectoError"></asp:RequiredFieldValidator>
            <br />
            <asp:Button ID="TButtonReservar" runat="server" Text="Reservar" 
                onclick="TButtonReservar_Click" />
        </asp:PlaceHolder>
    </div>
    <asp:PlaceHolder ID="IndexRegistroPH" runat="server">
        <div id="IndexRegistro">
            <br />
            <br />
            <p>¿No tienes una cuenta Rent A Car?</p>
            <p>A que estas esperando, consigue todas las ventajas</p>
            <br />
            <br />
            <a id="IndexLinkReg" href="Registro.aspx"> &nbsp Registrate &nbsp </a>
        </div>
     </asp:PlaceHolder>
    <div id="IndexOfertas">
        <h1><span>Nuestras Ofertas</span></h1>

        <div id="IndexBoxOfertas"></div>
    </div>
    <div id="IndexReserva">
        <h1><span></span>Realizar Reserva</h1>

        <asp:ScriptManager ID="ScriptManager1" runat="server" EnableScriptGlobalization="True"  >
            <Services>
                <asp:ServiceReference Path="~/ServicioWeb.asmx" />
            </Services>
        </asp:ScriptManager>

        <ajaxToolkit:CalendarExtender runat="server"
            TargetControlID="IndexTextFechaInicio"
            CssClass="IndexFechaInicio"
            Format="dd/MM/yyyy"
            PopupButtonID="CalendarioInicio" />

        <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server"
            TargetControlID="IndexTextFechaFin"
            CssClass="IndexFechaFin"
            Format="dd/MM/yyyy"
            PopupButtonID="CalendarioFin" />

        <h2>Selecciona las fechas de tu reserva</h2>
        <br />
        Desde:
        <asp:TextBox ID="IndexTextFechaInicio" runat="server" Height="21px" 
            Width="82px"></asp:TextBox>

        <input type="image" name="CalendarioInicio" 
            id="CalendarioInicio" src="../Imagenes/Calendario.png" 
            onclick="javascript:MostrarCalendario()" alt="Click para mostrar calendario" 
            style="border-width:0px;" />
        
        hasta:
        <asp:TextBox ID="IndexTextFechaFin" runat="server" Height="21px" Width="82px"></asp:TextBox>

        <input type="image" name="CalendarioFin" 
            id="CalendarioFin" src="../Imagenes/Calendario.png" 
            onclick="javascript:MostrarCalendario()" alt="Click para mostrar calendario" 
            style="border-width:0px;" /><br />
        <br />
        <asp:CompareValidator ID="Posterior" runat="server"
                    ErrorMessage="Fecha Inicio menor que fecha actual"
                    ControlToValidate="IndexTextFechaInicio"
                    Operator="GreaterThanEqual"
                    Type="String"
                    EnableViewState="false"
                    Enabled="true"
                    CssClass="AspectoError"></asp:CompareValidator>
        <asp:CompareValidator ID="CompareValidatorFechas" runat="server"
                    ErrorMessage="Fecha fin inferior a la de inicio"
                    ControlToValidate="IndexTextFechaFin"
                    ControlToCompare="IndexTextFechaInicio"
                    Operator="GreaterThanEqual"
                    Type="Date"
                    EnableViewState="false"
                    Enabled="true"
                    CssClass="AspectoError"></asp:CompareValidator>
        <br />
        <asp:Button ID="IndexBotonReserva2" runat="server" Height="44px" Text="Reservar" 
            Width="85px" onclick="IndexBotonReserva_Click" />
        
    </div>
</asp:Content>


