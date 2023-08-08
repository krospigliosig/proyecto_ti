<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio_Sesion.aspx.cs" Inherits="proyecto_ti.Inicio_Sesion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Iniciar sesión en la EPCC</title>
</head>
<body>
    <form id="formInicioSesion" runat="server" method="post">
        <asp:Button runat="server" Text="Volver al inicio" OnClick="Volver_Inicio"/>
        <div class="alinear-centro">
            <h2>Iniciar sesión</h2>
            <p>Usuario: <input id="NombreUser" type="text" runat="server" /></p>
            <p>Contraseña: <input id="ContraseñaUser" type="password" runat="server" /></p>
            <asp:Button ID="IngresoUser" runat="server" Text="Ingresar" OnClick="Iniciar_Sesion"/>
        </div>
    </form>
</body>
</html>
