using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proyecto_ti
{
    public partial class Pagina_Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Iniciar_Sesion_User(object sender, EventArgs e)
        {
            Response.Redirect("Inicio_Sesion");
        }

        protected void Registro_User(object sender, EventArgs e)
        {
            Response.Redirect("Registrarse");
        }

        protected void Iniciar_Sesion_Admin(object sender, EventArgs e)
        {
            Response.Redirect("Inicio_SesionAdmin");
        }

        protected void Registro_Admin(object sender, EventArgs e)
        {
            Response.Redirect("RegistroAdmin");
        }

        protected void Ver_Reglas_Uso(object sender, EventArgs e)
        {
            Response.Redirect("Reglas_Uso");
        }

        protected void Ver_Restricciones_Sanciones(object sender, EventArgs e)
        {
            Response.Redirect("Restricciones_Sanciones");
        }
    }
}