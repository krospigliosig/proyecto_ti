using proyecto_ti.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proyecto_ti
{
    public partial class Inicio_Sesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Volver_Inicio(object sender, EventArgs e)
        {
            Response.Redirect("Pagina_Inicio");
        }

        protected void Iniciar_Sesion(object sender, EventArgs e)
        {
            string nombre = NombreUser.Value;
            string contraseña = ContraseñaUser.Value;

            string datos = nombre + '|' + contraseña + '|';

            Service1Client cliente = new Service1Client();
            if (cliente.ValidarIS(datos))
            {
                CrearSesion(nombre);
                Response.Redirect("Main");
            }
            else
            {
                Response.Write("<script>alert('Error: Verifique los datos de inicio de sesión y vuelva a intentarlo'); return false;</script>");
            }
        }

        [WebMethod]
        public static bool ComprobarRegistro(string datos)
        {
            Service1Client cliente = new Service1Client();
            return cliente.VerificarCUI(datos);
        }

        private void CrearSesion(string nombre)
        {
            Session["Nombre"] = nombre;
            Session["admin"] = false;
        }
    }
}