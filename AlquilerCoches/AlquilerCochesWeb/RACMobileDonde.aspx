<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RACMobileDonde.aspx.cs" Inherits="AlquilerCochesWeb.RACMobile2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <meta charset="utf-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1" />
        <title>RAC Mobile</title>
        <link rel="stylesheet" href="http://code.jquery.com/mobile/1.1.0/jquery.mobile-1.1.0.min.css" />
        <link rel="stylesheet" href="my.css" />
        <style>
            /* App custom styles */
        </style>
        <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js">
        </script>
        <script src="http://code.jquery.com/mobile/1.1.0/jquery.mobile-1.1.0.min.js">
        </script>
    </head>

<body>
    <form id="form1" runat="server">
    <div>
        <div data-role="page" id="donde" data-title="Donde">
    <div data-role="header" data-position="inline" data-theme="a">
        <a href="RACMobile.aspx" data-icon="arrow-u" data-theme="b" rel="external">Inicio</a>
        <h1>RACMobile</h1>
        <a href="#login" data-icon="check" data-theme="b">Login</a>
    </div><!-- /header -->
    <div data-role="content">
        <div data-role="content">
                <img src="https://maps.googleapis.com/maps/api/staticmap?center=Guarroman&amp;zoom=14&amp;size=288x200&amp;markers=Guarroman&amp;sensor=false" width="288" height="200" />
            </div>
    </div>
    <div data-role="footer" data-position="fixed">
        <h4>&copy; Rent A Car</h4>
    </div><!-- /footer -->
    </div>
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
                    <a data-role="button" href="#donde">Cancel</a>
                </div>
            </div>
        </form>
    </div><!-- /content -->
 
    <div data-role="footer" data-theme="b">
        <h4>&copy; Rent A Car</h4>
    </div><!-- /footer -->
</div><!-- /page login -->
    </div>
    </div>
    </form>
</body>
</html>
