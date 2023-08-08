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
    public partial class Registrarse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Volver_Inicio(object sender, EventArgs e)
        {
            Response.Redirect("Pagina_Inicio");
        }

        protected void Registrar(object sender, EventArgs e)
        {
            string datos = "";
            string nomVal = NombreRegistro.Value;
            string apeVal = ApellidosRegistro.Value;
            string cuiVal = CUIRegistro.Value;
            string corVal = eMailRegistro.Value;
            string cont = ContraseñaRegistro.Value;

            datos += cuiVal + '|' + nomVal + '|' + apeVal + '|' + corVal + '|';
            
            Service1Client cliente = new Service1Client();
            if (cliente.ValidarReg(datos))
            {
                datos += cont + '|';
                cliente.Registrar(datos);
                Response.Redirect("Pagina_Inicio");
            }
        }
    }
}