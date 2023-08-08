<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="proyecto_ti.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Escuela de Ciencias de la Computación - Implementos Recreativos y Deportivos </title>
</head>
<body>
    <form id="form1" runat="server">
        <h1 id="header" runat="server"></h1>
        <div>
            <p>Solicita un implemento aquí: <asp:Button ID="SolicitarImplemento" runat="server" Text="Solicitar un objeto" OnClick="Ir_Solicitar"/></p>
            <p>Revisa el inventario aquí: <asp:Button ID="VerInventario" runat="server" Text="Ver Inventario" OnClick="Ver_Inventario"/></p>
        </div>
        <div>
            <p>Estado</p>
            <asp:TextBox ID="InfoEstado" runat="server"/>
            <asp:PlaceHolder ID="ActualizarEstado" runat="server"/>
        </div>
        <asp:Button ID="CerrarSesion" runat="server" Text="Cerrar Sesión" OnClick="Cerrar_Sesion"/>
    </form>
</body>
</html>
