using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexion_basedatos
{
    public class Registro : IRegistro
    {
        public void RegistrarUser(string data)
        {
            Conectar conSQL = new Conectar();
            IList<String> datosEstandarizados = new List<String>();
            string consulta = "";

            string temp = "";
            for (int i = 0; i < data.Length; ++i)
            {
                if (data[i] != '|')
                {
                    temp += data[i];
                }
                else
                {
                    datosEstandarizados.Add(temp);
                    temp = "";
                }
            }

            if (datosEstandarizados.Count == 5)
            {
                consulta = "insert into Registrados values (";

                consulta += "\'" + datosEstandarizados[0] + "\'" + ",";
                consulta += "\'" + datosEstandarizados[1] + "\'" + ",";
                consulta += "\'" + datosEstandarizados[2] + "\'" + ",";
                consulta += "\'" + datosEstandarizados[3] + "\'" + ",";
                consulta += "\'" + datosEstandarizados[4] + "\'";

                consulta += ");";
            }
            else
            {
                consulta = "insert into RegistradosAdmin values (";

                consulta += "\'" + datosEstandarizados[0] + "\'" + ",";
                consulta += "\'" + datosEstandarizados[1] + "\'" + ",";
                consulta += "\'" + datosEstandarizados[2] + "\'" + ",";
                consulta += "\'" + datosEstandarizados[3] + "\'" + ",";
                consulta += "\'" + datosEstandarizados[4] + "\'";

                consulta += ");";
            }

            try
            {
                conSQL.abrirConexion();
                SqlDataReader reader = conSQL.hacerConsulta(consulta);
                conSQL.cerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
