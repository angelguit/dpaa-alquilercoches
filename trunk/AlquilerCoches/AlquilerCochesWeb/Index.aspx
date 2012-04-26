<%@ Page Title="Rent A Car" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AlquilerCochesWeb.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="IndexIzquierda" ContentPlaceHolderID="MaestraContenedor" runat="server">
    <div id="IndexPresentacion">
        <div id="IndexTextoPresentacion">
            <p>Rent A Car es una empresa con años de experiencia.</p>
            <p>Nuestros clientes son nuestra mayor prioridad y esperamos ofrecerle un servicio de su agrado. </p>
        </div>
    </div>
    <div id="IndexLogin">
        <asp:Login ID="IndexLoginC" runat="server" Height="150px" Width="202px" 
            LoginButtonText="Acceder" RememberMeText="Recordarme la próxima vez.">
            <CheckBoxStyle CssClass="IndexCheck" />
            <LabelStyle CssClass="IndexLabel" />
            <LoginButtonStyle CssClass="IndexBotonAcceder" />
            <TextBoxStyle CssClass="IndexTextBox" />
            <TitleTextStyle CssClass="IndexTitle" />
        </asp:Login>
    </div>
    <div id="IndexRegistro">
        <br />
        <br />
        <p>¿No tienes una cuenta Rent A Car?</p>
        <p>A que estas esperando, consigue todas las ventajas</p>
        <br />
        <br />
        <a id="IndexLinkReg" href="Registro.aspx"> &nbsp Registrate &nbsp </a>
    </div>
    <div id="IndexOfertas">
    </div>
    <div id="IndexReserva">
    <asp:ScriptManager ID="ScriptManager1" runat="server" EnableScriptGlobalization="True"  ></asp:ScriptManager>
    <ajaxToolkit:CalendarExtender runat="server"
        TargetControlID="IndexTextFechaInicio"
        CssClass="IndexFechaInicio"
        Format="MMMM d, yyyy"
        PopupButtonID="CalendarioInicio" />
        <asp:TextBox ID="IndexTextFechaInicio" runat="server"></asp:TextBox>
        <input type="image" name="CalendarioInicio" 
            id="CalendarioInicio" src="../Imagenes/Calendario.png" 
            onclick="javascript:MostrarCalendario()" alt="Click para mostrar calendario" 
            style="border-width:0px;" /><br />

    </div>
</asp:Content>


