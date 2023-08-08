using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proyecto_ti
{
    public partial class Reglas_Uso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Volver_Inicio(object sender, EventArgs e)
        {
            Response.Redirect("Pagina_Inicio");
        }

        protected void Ver_Restricciones_Sanciones(object sender, EventArgs e)
        {
            Response.Redirect("Restricciones_Sanciones");
        }
    }
}