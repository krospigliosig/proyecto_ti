<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pagina_Inicio.aspx.cs" Inherits="proyecto_ti.Pagina_Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Implementos deportivos de la EPCC</title>
</head>
<body>
    <form id="formPaginaInicio" runat="server" method="post">
        <div>
            <p>¡Bienvenido a la página de gestión de implementos deportivos de la EPCC!<br />
                Aquí podrás solicitar el préstamo de distintos recursos para divertirte.
            </p>
            <section>
                <p>Recuerda seguir las reglas de uso del material recreativo de la EPCC.<br />
                <asp:Button ID="VerReglas" runat="server" Text="Ver las reglas de uso" OnClick="Ver_Reglas_Uso"/>
            </p>
            </section>
            <section>
                <p>Revisa las restricciones y sanciones aquí<br />
                <asp:Button ID="VerSanciones" runat="server" Text="Restricciones y sanciones" OnClick="Ver_Restricciones_Sanciones"/>
            </p>
            </section>
        </div>
        <div>
            <asp:Button ID="IniciarSesion" runat="server" Text="Iniciar sesión" OnClick="Iniciar_Sesion_User"/>
            <asp:Button ID="Registrarse" runat="server" Text="Registrarse" OnClick="Registro_User"/>
        </div>
        <div>
            <p>¿Eres administrador?</p>
            <asp:Button ID="IniciarSesionAdmin" runat="server" Text="Iniciar sesión como administrador" OnClick="Iniciar_Sesion_Admin"/>
            <asp:Button ID="RegistrarseAdmin" runat="server" Text="Registrarse como administrador" OnClick="Registro_Admin"/>
        </div>
    </form>
</body>
</html>
