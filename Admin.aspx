<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="proyecto_ti.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>(Administrador) Escuela de Ciencias de la Computación - Implementos Recreativos y Deportivos </title>
</head>
<body>
    <form id="form1" runat="server">
        <h1 id="headerAdmin" runat="server"></h1>
        <div>
            <p>Solicita un implemento aquí: <asp:Button ID="SolicitarImplemento" runat="server" Text="Solicitar un objeto" /></p>
            <p>Revisa el inventario aquí: <asp:Button ID="VerInventario" runat="server" Text="Ver Inventario" OnClick="Ver_Inventario"/></p>
        </div>
        <div>
            <p>Estado</p>
            <asp:TextBox ID="InfoEstado" runat="server"/>
            <asp:PlaceHolder ID="ActualizarEstado" runat="server"/>
        </div>
        <asp:Button ID="CerrarSesion" runat="server" Text="Cerrar Sesión" OnClick="Cerrar_Sesion"/>
        <div id="HerramientasAdmin">
            <asp:Button ID="GestionarInventario" runat="server" Text="Gestionar Inventario" />
            <asp:Button ID="GestionarUsers" runat="server" Text="Gestionar Usuarios" OnClick="Ir_Gestionar_Usuarios"/>
        </div>
    </form>
</body>
</html>
