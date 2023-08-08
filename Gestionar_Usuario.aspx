<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Gestionar_Usuario.aspx.cs" Inherits="proyecto_ti.Gestionar_Usuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Gestión de usuarios - Administrador</title>
    <script src="Scripts/jquery-3.4.1.js"></script>
</head>
<body onload="ocultar(); $('#AñadirSancion').hide(); deshabilitarBotones();">
    <form id="Gestionar_Usuario" runat="server">
        <asp:Button ID="VolverAtras" runat="server" Text="Volver" OnClick="Volver"/>
        <h2>Gestionar usuarios</h2>
        <div id="SoloAdmin" runat="server">
            <p>Ingresar un CUI de usuario: <asp:TextBox ID="Buscar" runat="server" onblur="let c=$('#Buscar').val(); return MostrarInfoUsuario(c);"></asp:TextBox></p>
            <div id="InfoUsuarioBuscar" runat="server">
                <p>Nombre: <asp:TextBox ID="NombreBuscar" runat="server" ReadOnly="true"></asp:TextBox></p>
                <p>Apellido: <asp:TextBox ID="ApellidosBuscar" runat="server" ReadOnly="true"></asp:TextBox></p>
                <p>CUI: <asp:TextBox ID="CUIBuscar" runat="server" ReadOnly="true"></asp:TextBox></p>
                <p>Correo electrónico: <asp:TextBox ID="CorreoBuscar" runat="server" ReadOnly="true"></asp:TextBox></p>
                <p>Bajo préstamo: <asp:TextBox ID="PrestadoBuscar" runat="server" ReadOnly="true"></asp:TextBox></p>
            </div>
            <div id="estadoBuscar" runat="server">
                <p>Estado: <br />
                    <asp:TextBox ID="MostrarEstado" runat="server"></asp:TextBox></p>
            </div>
            <div id="PrestamoActivo" runat="server">
                <p>Fecha de préstamo: <asp:TextBox ID="FechaPrestamo" runat="server" ReadOnly="true"></asp:TextBox></p>
                <p>Fecha de devolución: <asp:TextBox ID="FechaDevolucion" runat="server" ReadOnly="true"></asp:TextBox></p>
            </div>
            <asp:Button ID="Sancionar" runat="server" Text="Sancionar" OnClientClick="$('#AñadirSancion').show(); return false;"/>
            <asp:Button ID="Levantar_Sancion" runat="server" Text="Levantar Sanción" OnClientClick="ConfirmarLevantamiento();" OnClick="LevantarSancion"/>
            <%--<asp:Button ID="VerUsuarios" runat="server" Text="Ver todos los usuarios registrados" />--%>
            <div id="AñadirSancion" runat="server">
                <p>Días de sanción: <asp:TextBox ID="DiasSancion" runat="server" onchange="confirmarSancion();"></asp:TextBox></p>
                <asp:Button ID="AceptarSancion" runat="server" Text="Aceptar" OnClientClick="AplicarSancion();" OnClick="SancionarUsuario"/>
                <asp:Button ID="CancelarSancion" runat="server" Text="Cancelar" OnClientClick="$('#AñadirSancion').hide(); return false;"/>
            </div>
        </div>
        <script src="scripts.js"></script>
    </form>
</body>
</html>
