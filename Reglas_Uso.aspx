<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reglas_Uso.aspx.cs" Inherits="proyecto_ti.Reglas_Uso" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Reglas de uso de los implementos EPCC</title>
    <link rel="stylesheet" href="estilo.css"/>
</head>
<body>
    <form id="formRegUso" runat="server">
        <asp:Button runat="server" Text="Volver al inicio" OnClick="Volver_Inicio"/>
        <asp:Button runat="server" Text="Ver restricciones y sanciones" OnClick="Ver_Restricciones_Sanciones"/>
        <h1>Reglamento de Uso de Implementos Recreativos y Deportivos de la Escuela de Ciencia de la Computación de la UNSA</h1>
        <p>El presente reglamento constituye el conjunto de normas que regulan el uso y funcionamiento de los Implementos Recreativos y Deportivos de la Escuela de Ciencia de la Computación (desde ahora EPCC) de la Universidad de San Agustín. La finalidad es brindar a nuestros compañeros un mejor servicio de acceso a los recursos deportivos y recreativos. Este reglamento establece los derechos, sanciones y condiciones de uso de los recursos de información.</p>
        <h2>1. Requisitos de elegibilidad</h2>
        <ul style="list-style-type:none">
            <li>1.1. Los usuarios deben ser estudiantes, egresados, docentes o personal administrativo de la EPCC.</li>
            <li>1.2. Los estudiantes de la EPCC deben presentar su credencial emitida por el Centro de Estudiantes para poder acceder a los Implementos Recreativos y Deportivos. Se considera acreditados a todos los docentes y administrativos que operen en la EPCC.</li>
        </ul>
        <h2>2. Solicitud y reserva de Implementos Recreativos y Deportivos</h2>
        <ul style="list-style-type:none">
            <li>2.1. Los Implementos Recreativos y Deportivos deben ser solicitados por un estudiante de la EPCC y registrados adecuadamente.</li>
            <li>2.2. El solicitante se hace responsable del cuidado y mantenimiento de los Implementos Recreativos y Deportivos durante su uso.</li>
            <li>2.3. No se realizará ningún cobro a los acreditados de la EPCC por el uso de los Implementos Recreativos y Deportivos.</li>
            <li>2.4. Los estudiantes de otras escuelas que cuenten con acreditación del Centro de Estudiantes tendrán que realizar el abono según la tabla que fijará el Centro de Estudiantes para el uso de los Implementos Recreativos y Deportivos.</li>
        </ul>
    </form>
</body>
</html>
