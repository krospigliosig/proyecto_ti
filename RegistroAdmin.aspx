<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroAdmin.aspx.cs" Inherits="proyecto_ti.RegistroAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registro de administrador EPCC</title>
    <script src="Scripts/jquery-3.4.1.js"></script>
</head>
<body>
    <form id="formRegistroAdmin" runat="server" method="post">
        <asp:Button runat="server" Text="Volver al inicio" OnClick="Volver_Inicio"/>
        <h2>Registrarse como administrador</h2>
        <p>Nombres: <input id="NombreRegistro" type="text" runat="server"/></p>
        <p>Apellidos: <input id="ApellidosRegistro" type="text" runat="server"/></p>
        <p>CUI: <input id="CUIRegistro" type="text" runat="server" onblur="let s = $('#CUIRegistro').val() + '|admin|'; return ValidarRegCliente(s);"/></p>
        <asp:Textbox ID="ValidacionRegistro" runat="server" class="form-control" Style="visibility: visible" ReadOnly="true"/>
        <p>Correo institucional: <input id="eMailRegistro" type="email" runat="server"/></p>
        <p>Ingrese una contraseña: <input id="ContraseñaRegistro" type="password" runat="server"/></p>
        <p>Verifique su contraseña: <input id="VerifContraseñaRegistro" type="password" runat="server"/></p>
        <asp:Button ID="VerifRegistroAdmin" runat="server" Text="Registrarse" OnClientClick="return validarRegistro();" OnClick="Registrar"/>
    </form>
    <script src="scripts.js"></script>
</body>
</html>
