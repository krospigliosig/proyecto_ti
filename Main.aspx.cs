﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proyecto_ti
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //header.InnerText = "Bienvenido, " + Session["Nombre"].ToString();
        }

        protected void Ver_Inventario(object sender, EventArgs e)
        {
            Response.Redirect("VerBaseDatos");
        }

        protected void Cerrar_Sesion(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Session.Abandon();
            Response.Redirect("Pagina_Inicio");
        }

        protected void Ir_Solicitar(object sender, EventArgs e)
        {
            Response.Redirect("Solicitar_Objeto");
        }
    }
}