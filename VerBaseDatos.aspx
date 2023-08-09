<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerBaseDatos.aspx.cs" Inherits="proyecto_ti.VerBaseDatos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Base de datos EPCC</title>
    <link rel="stylesheet" href="estilo.css"/>
    <script src="Scripts/jquery-3.4.1.js"></script>
</head>
<body onload="impedirSelectedZero(); $('#AgregarCarcts').hide(); $('#ModifCarcts').hide();">
    <form id="formBaseDatos" runat="server">
        <h2>Ver base de datos:</h2>
        <asp:DropDownList ID="Implementos" runat="server" onchange="let o = $('#Implementos').val(); impedirSelectedZero(); return MostrarInfoObjeto(o);"></asp:DropDownList>
        <p>Deporte: <asp:TextBox ID="Deporte" runat="server" ReadOnly="true"></asp:TextBox></p>
        <p>Cantidad: <asp:TextBox ID="Cantidad" runat="server" ReadOnly="true"></asp:TextBox></p>
        <p>Observaciones: <asp:TextBox ID="Observaciones" runat="server" ReadOnly="true"></asp:TextBox></p>
        <p>Disponible: <asp:TextBox ID="Disponible" runat="server" ReadOnly="true"></asp:TextBox></p>
        <asp:Button ID="AgregarItem" runat="server" Text="Agregar objeto al inventario" OnClientClick="$('#AgregarCarcts').show(); return false;"/>
        <asp:Button ID="QuitarItem" runat="server" Text="Quitar objeto del inventario" OnClientClick="return confirmarQuitarObjeto();" OnClick="QuitarObjeto"/>
        <asp:Button ID="ModificarItem" runat="server" Text="Modificar objeto" OnClientClick=" $('#ModifCarcts').show(); return false;"/>
        <asp:Button ID="Regresar" runat="server" Text="Regresar" />
        <div id="AgregarCarcts" runat="server">
            <p>Nombre del objeto: <asp:TextBox ID="AgregarNombre" runat="server"></asp:TextBox></p>
            <p>Deporte: <asp:TextBox ID="AgregarDeporte" runat="server"></asp:TextBox></p>
            <p>Cantidad: <asp:TextBox ID="AgregarCantidad" runat="server"></asp:TextBox></p>
            <p>Observaciones: <asp:TextBox ID="AgregarObservaciones" runat="server"></asp:TextBox></p>
            <asp:Button ID="ConfirmarAgregar" runat="server" Text="Agregar" OnClick="AgregarObjeto"/>
            <asp:Button ID="CancelarAgregar" runat="server" Text="Cancelar" OnClientClick="$('#AgregarCarcts').hide(); return false;"/>
        </div>
        <div id="ModifCarcts" runat="server">
            <p>Agregar observación: <asp:TextBox ID="ModifObservacion" runat="server"></asp:TextBox></p>
            <p>Cantidad: <asp:TextBox ID="AumentarItem" runat="server"></asp:TextBox></p>
            <asp:Button ID="AceptarModif" runat="server" Text="Modificar" OnClientClick="return ValidarModif();" OnClick="ModificarObjeto"/>
            <asp:Button ID="CancelarModif" runat="server" Text="Cancelar" OnClientClick="$('#ModifCarcts').hide(); return false;"/>
        </div>
        <script src="scripts.js"></script>
    </form>
</body>
</html>
