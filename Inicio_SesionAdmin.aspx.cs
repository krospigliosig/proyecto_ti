using proyecto_ti.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proyecto_ti
{
    public partial class Inicio_SesionAdmin : System.Web.UI.Page
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
            string nombre = NombreAdmin.Value;
            string contraseña = ContraseñaAdmin.Value;

            string datos = nombre + '|' + contraseña + '|' + "admin|";

            Service1Client cliente = new Service1Client();
            if (cliente.ValidarIS(datos))
            {
                CrearSesion(nombre);
                Response.Redirect("Admin");
            }
            else
            {
                Response.Write("<script>alert('Error: Verifique los datos de inicio de sesión y vuelva a intentarlo'); return false;</script>");
            }
        }

        private void CrearSesion(string nombre)
        {
            Session["Nombre"] = nombre;
            Session["admin"] = true;
        }
    }
}