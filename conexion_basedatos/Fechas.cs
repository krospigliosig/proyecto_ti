using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexion_basedatos
{
    public class Fechas : IFechas
    {
        public void Sancionar(string cui,int dias)
        {
            Conectar ConSQL = new Conectar();

            DateTime hoy= DateTime.Today;
            DateTime fechaSancion = hoy.AddDays(dias);

            string stringSancion = fechaSancion.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

            try
            {
                ConSQL.abrirConexion();
                SqlDataReader lector = ConSQL.hacerConsulta("update registrados set sancionado='" + stringSancion + "' where cui='" + cui + "'");

                ConSQL.cerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Levantar(string cui)
        {
            Conectar ConSQL = new Conectar();

            try
            {
                ConSQL.abrirConexion();
                SqlDataReader lector = ConSQL.hacerConsulta("update registrados set sancionado=null where cui='" + cui + "'");

                ConSQL.cerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
