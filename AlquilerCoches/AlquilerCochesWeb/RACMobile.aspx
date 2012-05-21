<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RACMobile.aspx.cs" Inherits="AlquilerCochesWeb.RACMobile" EnableSessionState="True" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1" />
        <link rel="stylesheet" href="http://code.jquery.com/mobile/1.1.0/jquery.mobile-1.1.0.min.css" />
        <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js">
        </script>
        <script src="http://code.jquery.com/mobile/1.1.0/jquery.mobile-1.1.0.min.js">
        </script>

    <title>RAC Mobile</title>
</head>
<body>
   <!-- HOME -->
<div data-role="page" id="home" data-title="Home">
    <div data-role="header" data-position="inline" data-theme="a">
        <a href="Index.aspx" data-icon="arrow-u" data-theme="b" rel="external">Web</a>
        <h1 id = "tit">RACMobile</h1>
        <a href="#login" data-icon="check" data-theme="b">Login</a>
    </div><!-- /header -->
    <div data-role="content">
        <ul data-role="listview" data-filter="false" data-theme="a" data-dividertheme="b" data-inset="true">
            <li data-role="list-divider">Menú</li>
            <li id ="lireg"><a href="#">Registro</a></li>
            <li id="lilogin"><a href="#login">Login</a></li>
            <li><a href="#Compras">Ofertas</a></li>
            <li><a href="#">Reservas</a></li>
            <li><a href="#Compras">Compras</a></li>
            <li><a href="#donde">¿Donde estamos?</a></li>
        </ul>
    </div><!-- /content -->
 
    <div data-role="footer" data-position="fixed">
        <h4>&copy; Rent A Car</h4>
    </div><!-- /footer -->
</div><!-- /page home -->
 
<!-- LOGIN -->
<div data-role="page" id="login" data-title="Login">
    <div data-role="header" data-theme="b">
        <h1>Login</h1>
        <a href="#home" data-icon="home" data-iconpos="notext" class="ui-btn-right"></a>
    </div><!-- /header -->
 
    <div data-role="content" data-theme="a">
        <form action="RACMobileLogin.aspx" method="post" id="login">
            <div data-role="fieldcontain">
                <label for="username">Usuario</label>
                <input type="text" name="_username" id="username" placeholder="Nombre de usuario" autofocus required/>
            </div>
 
            <div data-role="fieldcontain">
                <label for="password">Password</label>
                <input type="password" name="_password" id="password" value="" placeholder="Introduzca password" required />
            </div>
 
            <div class="ui-grid-a">
                <div class="ui-block-a">
                    <button type="submit" data-theme="e">Login</button>
                </div>
                <div class="ui-block-b">
                    <a data-role="button" href="#home">Cancel</a>
                </div>
            </div>
        </form>
    </div><!-- /content -->
 
    <div data-role="footer" data-theme="b">
        <h4>&copy; Rent A Car</h4>
    </div><!-- /footer -->
</div><!-- /page login -->

<!-- Compras -->
<div data-role="page" id="compras" data-title="Compras">
    <div data-role="header" data-theme="b">
        <h1>Ofertas</h1>
        <a href="#home" data-icon="home" data-iconpos="notext" class="ui-btn-right"></a>
    </div><!-- /header -->
 
    <div data-role="content" data-theme="a" style="text-align:center;">
        <ul id="Ofertas" data-role="listview" data-filter="false" data-theme="a" data-dividertheme="b" data-inset="true">
        </ul>
    </div><!-- /content -->
 
    <div data-role="footer" data-theme="b">
        <h4>&copy; Rent A Car</h4>
    </div><!-- /footer -->
</div><!-- /page donde -->

<!-- Donde estamos -->
<div data-role="page" id="donde" data-title="Donde">
    <div data-role="header" data-theme="b">
        <h1>¿Donde estamos?</h1>
        <a href="#home" data-icon="home" data-iconpos="notext" class="ui-btn-right"></a>
    </div><!-- /header -->
 
    <div data-role="content" data-theme="a" style="text-align:center;">
        <img src="https://maps.googleapis.com/maps/api/staticmap?center=Guarroman&amp;zoom=14&amp;size=288x200&amp;markers=Guarroman&amp;sensor=false" width="288" height="200" />
    </div><!-- /content -->
 
    <div data-role="footer" data-theme="b">
        <h4>&copy; Rent A Car</h4>
    </div><!-- /footer -->
</div><!-- /page donde -->
</body>
</html>
