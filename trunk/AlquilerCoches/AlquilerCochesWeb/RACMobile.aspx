﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RACMobile.aspx.cs" Inherits="AlquilerCochesWeb.RACMobile" %>

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
        <h1>RACMobile</h1>
        <a href="#login" data-icon="check" data-theme="b">Login</a>
    </div><!-- /header -->
    <div data-role="content">
        <ul data-role="listview" data-filter="true" data-theme="a" data-dividertheme="b" data-inset="true">
            <li data-role="list-divider">Menú</li>
            <li><a href="#">Registro</a></li>
            <li><a href="#login">Login</a></li>
            <li><a href="#">Ofertas</a></li>
            <li><a href="#">Reservas</a></li>
            <li><a href="#">Compras</a></li>
            <li><a href="RACMobileDonde.aspx">¿Donde estamos?</a></li>
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
        <h4>&copy; Rent A Car</h4>
    </div><!-- /footer -->
</div><!-- /page login -->
</body>
</html>
