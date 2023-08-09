<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio_SesionAdmin.aspx.cs" Inherits="proyecto_ti.Inicio_SesionAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Iniciar sesión como administrador EPCC</title>
    <link rel="stylesheet" href="estilo.css"/>
</head>
<body>
    <form id="formInicioSesionAdmin" runat="server" method="post">
        <asp:Button runat="server" Text="Volver al inicio" OnClick="Volver_Inicio"/>
        <div class="alinear-centro">
            <h2>Iniciar sesión como administrador</h2>
            <p>Usuario: <input id="NombreAdmin" type="text" runat="server" /></p>
            <p>Contraseña: <input id="ContraseñaAdmin" type="password" runat="server" /></p>
            <asp:Button ID="IngresoAdmin" runat="server" Text="Ingresar" OnClick="Iniciar_Sesion"/>
        </div>
    </form>
</body>
</html>
