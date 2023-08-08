function validarRegistro() {
    var comprobar = "";
    let estado = document.getElementById("NombreRegistro").value;
    for (let i = 0; i < estado.length; ++i) {
        if (estado.charAt(i) == '0' || estado.charAt(i) == '1' || estado.charAt(i) == '2' || estado.charAt(i) == '3' || estado.charAt(i) == '4' || estado.charAt(i) == '5' || estado.charAt(i) == '6' || estado.charAt(i) == '7' || estado.charAt(i) == '8' || estado.charAt(i) == '9') {
            alert("Error: Verifique su nombre");
            return false;
        }
    }
    if (estado == comprobar) {
        alert("Error: Ingrese su nombre");
        return false;
    }
    estado = document.getElementById("ApellidosRegistro").value;
    for (let i = 0; i < estado.length; ++i) {
        if (estado.charAt(i) == '0' || estado.charAt(i) == '1' || estado.charAt(i) == '2' || estado.charAt(i) == '3' || estado.charAt(i) == '4' || estado.charAt(i) == '5' || estado.charAt(i) == '6' || estado.charAt(i) == '7' || estado.charAt(i) == '8' || estado.charAt(i) == '9') {
            alert("Error: Verifique sus apellidos");
            return false;
        }
    }
    if (estado == comprobar) {
        alert("Error: Ingrese sus apellidos");
        return false;
    }
    estado = document.getElementById("CUIRegistro").value;
    var patron = /[0-9]/;
    if (estado == comprobar) {
        alert("Error: Ingrese su CUI");
        return false;
    }
    if (estado.length != 8) {
        alert("Error: Verifique su CUI");
        return false;
    }
    if (!patron.test(estado)) {
        alert("Error: Verifique su CUI");
        return false;
    }
    estado = document.getElementById("eMailRegistro").value;
    for (let i = 0; i < estado.length; ++i) {
        if (estado.charAt(i) == '0' || estado.charAt(i) == '1' || estado.charAt(i) == '2' || estado.charAt(i) == '3' || estado.charAt(i) == '4' || estado.charAt(i) == '5' || estado.charAt(i) == '6' || estado.charAt(i) == '7' || estado.charAt(i) == '8' || estado.charAt(i) == '9') {
            alert("Error: Ingrese una dirección de correo electrónico válida");
            return false;
        }
        if (estado.charAt(i) == '@' && estado.substring(i, estado.length) != "@unsa.edu.pe") {
            alert("Error: Ingrese una dirección de correo electrónico válida");
            return false;
        }
    }
    if (estado == comprobar) {
        alert("Error: Ingrese su dirección de correo electrónico");
        return false;
    }
    if (!estado.includes("@")) {
        alert("Error: Ingrese una dirección de correo electrónico válida");
        return false;
    }
    estado = document.getElementById("ContraseñaRegistro").value;
    if (estado == comprobar) {
        alert("Error: Ingrese su contraseña");
        return false;
    }
    comprobar = document.getElementById("VerifContraseñaRegistro").value;
    if (comprobar == "") {
        alert("Error: Verifique su contraseña");
        return false;
    }
    if (estado.length > 12||estado.length<8) {
        alert("Error: Su contraseña debe tener entre 8 y 12 caracteres");
        return false;
    }
    if (estado.length != comprobar.length) {
        alert("Error: Las contraseñas no coinciden");
        return false;
    }
    if (estado != comprobar) {
        alert("Error: Las contraseñas no coinciden");
        return false;
    }
    alert("Registrado exitosamente. Se le redirigirá a la página de inicio, donde podrá iniciar sesión cuando se verifique el pago de su carnét.");
    return true;
}

function ValidarRegCliente(datos) {
    $.ajax({
        url: 'Inicio_Sesion.aspx/ComprobarRegistro',
        type: 'POST',
        async: true,
        data: '{ datos: "' + datos + '" }',
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: exito
    });
    return exito;
}

function exito(data) {
    if (!data.d) {
        $('#ValidacionRegistro').val("El usuario aún no existe.");
        $('#ValidacionRegistro').css('border', '#007e06');
        $('#ValidacionRegistro').css('background-color', '#66c66b');
        $('#VerifRegistro').removeAttr("disabled");
        $('#VerifRegistroAdmin').removeAttr("disabled");
    }
    else {
        $('#ValidacionRegistro').val("¡El usuario ya existe!");
        $('#ValidacionRegistro').css('border', 'red');
        $('#ValidacionRegistro').css('background-color', '#FF8E8E');
        $('#VerifRegistro').attr("disabled", "true");
        $('#VerifRegistroAdmin').attr("disabled", "true");
    }
    return false;
}

function MostrarInfoObjeto(objeto) {
    $.ajax({
        url: 'VerBaseDatos.aspx/getInfoObjetos',
        type: 'POST',
        async: true,
        data: '{ objeto: "' + objeto + '" }',
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: showInfo
    });
    return showInfo;
}

function showInfo(info) {
    $('#Deporte').val(info.d[0]);
    $('#Cantidad').val(info.d[1]);
    $('#Observaciones').val(info.d[2]);
    $('#Disponible').val(info.d[3]);
    return false;
}

function MostrarInfoUsuario(cui) {
    $.ajax({
        url: 'Gestionar_Usuario.aspx/getInfoUsuario',
        type: 'POST',
        async: true,
        data: '{ cui: "' + cui + '" }',
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: showInfoUser,
    });
    return showInfoUser;
}

function showInfoUser(info) {
    if (info.d == "") {
        alert("No se encontró al usuario");
        $('#NombreBuscar').val("");
        $('#ApellidosBuscar').val("");
        $('#CUIBuscar').val("");
        $('#CorreoBuscar').val("");
        $('#PrestadoBuscar').val("");
        $('#MostrarEstado').val("");
        deshabilitarBotones();
        ocultar();
    }
    else {
        $('#NombreBuscar').val(info.d[0]);
        $('#ApellidosBuscar').val(info.d[1]);
        $('#CUIBuscar').val(info.d[2]);
        $('#CorreoBuscar').val(info.d[3]);
        $('#PrestadoBuscar').val(info.d[4]);
        $('#MostrarEstado').val(info.d[5]);
        habilitarBotones();
        prestamo();
    }
    return false;
}

function prestamo() {
    if ($('#PrestadoBuscar').val() != "No") {
        $('#PrestamoActivo').show();
        $('#FechaPrestamo').val("08/08/2023");
        $('#FechaDevolucion').val("10/08/2023");
    }
    else {
        ocultar();
    }
    return false;
}

function deshabilitarBotones() {
    $('#Sancionar').attr("disabled", "true");
    $('#Levantar_Sancion').attr("disabled", "true");
    $('#AceptarSancion').attr("disabled", "true");
}

function habilitarBotones() {
    $('#Sancionar').removeAttr("disabled");
    $('#Levantar_Sancion').removeAttr("disabled");
}
function ocultar() {
    $('#PrestamoActivo').hide();
}

function confirmarQuitarObjeto() {
    if (confirm("¿Está seguro de querer eliminar este objeto del inventarios?")) {
        return true;
    } else {
        return false;
    }
}

function impedirSelectedZero() {
    if ($('#Implementos').val() == "Seleccione un objeto...") {
        $('#QuitarItem').attr("disabled", "true");
        $('#ModificarItem').attr("disabled", "true");
        $('#Prestarse').attr("disabled", "true");
    }
    else {
        $('#QuitarItem').removeAttr("disabled");
        $('#ModificarItem').removeAttr("disabled");
        $('#Prestarse').removeAttr("disabled");
    }
}

function AplicarSancion() {
    if ($('#DiasSancion').val() == "0") {
        alert("Error: Ingrese un número de días de sanción");
        return false;
    }
    var patron = /[a-z]/;
    if (patron.test($('#DiasSancion').val())) {
        alert("Error: Ingrese un número");
        return false;
    }
    confirm("Se va a sancionar a " + $('#NombreBuscar').val() + " por " + $('#DiasSancion').val() + " día(s). ¿Desea continuar?");

    return false;
}

function confirmarSancion() {
    if ($('#DiasSancion').val() == "") {
        $('#AceptarSancion').attr("disabled", "true");
    }
    else {
        $('#AceptarSancion').removeAttr("disabled");
    }
    return false;
}

function ConfirmarLevantamiento() {
    confirm("Se levantará la sanción de " + $('#NombreBuscar').val() + ". ¿Desea continuar?");

    return false;
}

function ValidarModif() {
    var patron = /[a-z]/;
    if (patron.test($('#AumentarItem').val())){
        alert("Error: La casilla \"Cantidades\" solo acepta números");
        return false;
    }
    return true;
}

function ValidarPrestamo() {

}