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
    public partial class Gestionar_Usuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
 
        }

        [WebMethod]
        public static String[] getInfoUsuario(string cui)
        {
            Service1Client cliente = new Service1Client();
            String[] info = cliente.InfoUsuario(cui);

            Array.Resize(ref info, info.Length + 1);

            info[info.Length - 1] = cliente.RevisarSanciones(cui);

            return info;
        }

        protected void Volver(object sender, EventArgs e)
        {
            Response.Redirect("Admin");
        }

        protected void SancionarUsuario(object sender, EventArgs e)
        {
            string c = Buscar.Text;
            int n = Int32.Parse(DiasSancion.Text);

            Service1Client cliente = new Service1Client();
            cliente.Sancion(c, n);
        }

        protected void LevantarSancion(object sender, EventArgs e)
        {
            Service1Client cliente = new Service1Client();
            cliente.Levantar(Buscar.Text);
        }
    }
}