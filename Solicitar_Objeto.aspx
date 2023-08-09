<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Solicitar_Objeto.aspx.cs" Inherits="proyecto_ti.Solicitar_Objeto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Solicitud de Implementos Recreativos y Deportivos EPCC</title>
    <link rel="stylesheet" href="estilo.css"/>
    <script src="Scripts/jquery-3.4.1.js"></script>
</head>
<body onload="impedirSelectedZero();">
    <form id="SolicitarObjetoF" runat="server">
        <asp:Button ID="Regresar" runat="server" Text="Volver atrás" />
        <h2>Solicitar un Implemento de la EPCC</h2>
        <asp:DropDownList ID="Implementos" runat="server" onchange="let o = $('#Implementos').val(); impedirSelectedZero(); return MostrarInfoObjeto(o);"></asp:DropDownList>
        <p>Deporte: <asp:TextBox ID="Deporte" runat="server" ReadOnly="true"></asp:TextBox></p>
        <p>Cantidad: <asp:TextBox ID="Cantidad" runat="server" ReadOnly="true"></asp:TextBox></p>
        <p>Observaciones: <asp:TextBox ID="Observaciones" runat="server" ReadOnly="true"></asp:TextBox></p>
        <p>Disponible: <asp:TextBox ID="Disponible" runat="server" ReadOnly="true"></asp:TextBox></p>
        <asp:Button ID="Prestarse" runat="server" Text="Solicitar" />
        <script src="scripts.js"></script>
    </form>
</body>
</html>
