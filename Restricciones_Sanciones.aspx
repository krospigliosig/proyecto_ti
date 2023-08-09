<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Restricciones_Sanciones.aspx.cs" Inherits="proyecto_ti.Restricciones_Sanciones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Restricciones y sanciones</title>
    <link rel="stylesheet" href="estilo.css"/>
</head>
<body>
    <form id="formRes_San" runat="server">
        <asp:Button runat="server" Text="Volver al inicio" OnClick="Volver_Inicio"/>
        <asp:Button runat="server" Text="Ver reglas de uso" OnClick="Ver_Reglas_Uso"/>
        <h2>3. Uso y restricciones</h2>
        <ul style="list-style-type:none">
            <li>3.1. No estar en estado etílico ni fumar, según Ley Nro. 25357 y 25358.</li>
            <li>3.2. Los Implementos Recreativos y Deportivos no pueden ser transferidos a otra persona sin autorización.</li>
            <li>3.3. Para solicitar la transferencia de los Implementos Recreativos y Deportivos, es necesario que el solicitante se acerque al Centro de Estudiantes y se registre en el libro correspondiente.</li>
            <li>3.4. Solo los acreditados pueden hacer uso de los Implementos Recreativos y Deportivos.</li>
            <li>3.5. El uso de un carné ajeno o falsificado será sancionado tanto a estudiantes como a docentes y personal administrativo.</li>
            <li>3.6. Está prohibido prestar algún material a usuarios externos sin autorización del Centro de Estudiantes.</li>
        </ul>
        <h2>4. Sanciones por incumplimiento</h2>
        <ul style="list-style-type:none">
            <li>4.1. <b>Advertencia verbal:</b> En caso de una infracción leve, se realizará una advertencia verbal al estudiante infractor, recordándole las normas establecidas y exhortándolo a cumplirlas en el futuro.</li>
            <li>4.2. <b>Suspensión temporal:</b> En caso de reincidencia o incumplimientos graves, el estudiante podrá ser suspendido temporalmente del acceso a los Implementos Recreativos y Deportivos por un período determinado, durante el cual no podrá hacer uso de los mismos.</li>
            <li>4.3. <b>Responsabilidad económica:</b> Si se detecta daño intencional o negligencia grave en el cuidado de los Implementos Recreativos y Deportivos, el estudiante será responsable de cubrir los gastos de reparación o reemplazo, de acuerdo a lo establecido por el Centro de Estudiantes.</li>
            <li>4.4. <b>Prohibición de uso:</b> En casos extremos de incumplimiento grave o reiterado, la EPCC se reserva el derecho de prohibir al estudiante el acceso a los Implementos Recreativos y Deportivos de manera permanente.</li>
            <li>4.5. <b>Sanción colectiva:</b> De ser reiterado por mas de 5 estudiantes, se procedera al retiro total de todos los Implementos Recreativos y Deportivos durante el semestre en curso.</li>
        </ul>
    </form>
</body>
</html>
