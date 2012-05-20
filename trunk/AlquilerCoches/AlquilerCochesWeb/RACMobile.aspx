<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RACMobile.aspx.cs" Inherits="AlquilerCochesWeb.RACMobile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="Css/jquery.mobile.structure-1.1.0.min.css" rel="Stylesheet" type="text/css" />
    <script src="/Javascript/jquery.min.js" type="text/javascript"></script>
    <script src="Javascript/jquery.mobile-1.1.0.min.js" type="text/javascript"></script>
    <title>RAC Mobile</title>
</head>
<body>
   <!-- HOME -->
<div data-role="page" id="home" data-title="Home">
    <div data-role="header" data-position="inline" data-theme="a">
        <a href="http://www.facultia.com/blog" data-icon="arrow-u" data-theme="b" rel="external">Blog</a>
        <h1>Grupos</h1>
        <a href="#login" data-icon="check" data-theme="b">Login</a>
    </div><!-- /header -->
    <div data-role="content">
        <ul data-role="listview" data-filter="true" data-theme="a" data-dividertheme="b" data-inset="true">
            <li data-role="list-divider">Internacionales</li>
            <li><a href="#">The Beatles</a></li>
            <li><a href="#">The Rolling Stones</a></li>
            <li><a href="#">Bob Dylan</a></li>
            <li><a href="#">Nick Drake</a></li>
            <li><a href="#">The Beach Boys</a></li>
            <li><a href="#">The Byrds</a></li>
            <li><a href="#">Spoon</a></li>
            <li><a href="#">Yo La Tengo</a></li>
            <li data-role="list-divider">Nacionales</li>
            <li><a href="#">Los Planetas</a></li>
            <li><a href="#">La Casa Azul</a></li>
            <li><a href="#">La Buena Vida</a></li>
            <li><a href="#">La Estrella De David</a></li>
            <li><a href="#">Los Brincos</a></li>
            <li><a href="#">Manos de topo</a></li>
            <li><a href="#">Papa Topo</a></li>
        </ul>
    </div><!-- /content -->
 
    <div data-role="footer" data-position="fixed">
        <div data-role="navbar">
            <ul>
                <li><a href="#" class="ui-btn-active" data-icon="refresh" data-theme="b">Actualizar</a></li>
                <li><a href="#" data-icon="search" data-theme="b">Buscar</a></li>
                <li><a href="#" data-icon="gear" data-theme="b">Ajustes</a></li>
            </ul>
        </div><!-- /navbar -->
    </div><!-- /footer -->
</div><!-- /page home -->
 
<!-- LOGIN -->
<div data-role="page" id="login" data-title="Login">
    <div data-role="header" data-theme="b">
        <h1>Login</h1>
        <a href="#home" data-icon="home" data-iconpos="notext" class="ui-btn-right"></a>
    </div><!-- /header -->
 
    <div data-role="content" data-theme="a">
        <form action="#" method="post" id="login">
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
        <h4>&copy; Facultia</h4>
    </div><!-- /footer -->
</div><!-- /page login -->
</body>
</html>
