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
    public partial class Solicitar_Objeto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            verObjetos();
        }

        protected void verObjetos()
        {
            Service1Client cliente = new Service1Client();
            String[] objetos = cliente.getObjetosBD();

            Implementos.Items.Add("Seleccione un objeto...");
            //if (Implementos.Items.Count != objetos.Length)
            //{
            for (int i = 0; i < objetos.Length; i++)
            {
                string o = objetos[i];
                Implementos.Items.Add(o);
            }
            //}
        }

        [WebMethod]
        public static String[] getInfoObjetos(string objeto)
        {
            Service1Client cliente = new Service1Client();
            String[] infoObjetos = cliente.InfoObjetos(objeto);

            return infoObjetos;
        }

        protected void Prestamo(object sender, EventArgs e)
        {

        }
    }
}