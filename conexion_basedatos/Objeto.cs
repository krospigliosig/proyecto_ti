using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace conexion_basedatos
{
    public class Objeto : IObjeto
    {
        public IList<String> getImplementos()
        {
            Conectar conSQL = new Conectar();
            IList<String> objetos = new List<String>();

            try
            {
                conSQL.abrirConexion();
                SqlDataReader lector = conSQL.hacerConsulta("select objeto from DataObjetos");

                if(lector.HasRows)
                {
                    while(lector.Read())
                    {
                        objetos.Add(lector.GetString(0));
                    }
                }

                conSQL.cerrarConexion();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }

            return objetos;
        }

        public IList<String> InfoObjetos(string objeto)
        {
            Conectar conSQL = new Conectar();

            Dictionary<string, string> valores = new Dictionary<string, string>();

            try
            {
                conSQL.abrirConexion();
                SqlDataReader lector = conSQL.hacerConsulta("select * from DataObjetos where objeto='" + objeto + "'");

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        valores["deporte"] = lector["deporte"].ToString();
                        valores["cantidad"] = lector["cantidad"].ToString();

                        if (lector["observacion"].ToString() == "")
                        {
                            valores["observacion"] = "Sin observaciones";
                        }
                        else
                        {
                            valores["observacion"] = lector["observacion"].ToString();
                        }

                        if ((bool)lector["estado"])
                        {
                            valores["estado"] = "Disponible";
                        }
                        else
                        {
                            valores["estado"] = "No disponible";
                        }
                    }
                }

                conSQL.cerrarConexion();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }

            IList<String> info = valores.Values.ToArray();
            return info;
        }

        public void AgregarObjeto(string objeto)
        {
            Conectar conSQL = new Conectar();
            IList<String> infoObjeto = new List<String>();

            string temp = "";
            for (int i = 0; i < objeto.Length; i++)
            {
                if (objeto[i] != '|')
                {
                    temp += objeto[i];
                }
                else
                {
                    infoObjeto.Add(temp);
                    temp = "";
                }
            }

            string consulta = "insert into dataobjetos values (";

            consulta += "\'" + infoObjeto[0] + "\'" + ",";
            consulta += "\'" + infoObjeto[1] + "\'" + ",";
            consulta += infoObjeto[2] + ",";
            consulta += "\'" + infoObjeto[3] + "\'" + ",";
            consulta += 1 ;

            consulta += ");";

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

        public void EliminarObjeto(string objeto)
        {
            Conectar conSQL = new Conectar();

            try
            {
                conSQL.abrirConexion();
                SqlDataReader lector = conSQL.hacerConsulta("delete from dataobjetos where objeto='" + objeto + "'");

                conSQL.cerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void ModifObjeto(string objeto, string info)
        {
            Conectar conSQL = new Conectar();
            IList<String> subir = new List<String>();

            string temp = "";
            for (int i = 0; i < info.Length; i++)
            {
                if (info[i] != '|')
                {
                    temp += info[i];
                }
                else
                {
                    subir.Add(temp);
                    temp = "";
                }
            }

            string consulta = "update dataobjetos set ";
            if (subir.Count == 2)
            {
                consulta += "observacion='" + subir[0] + "', cantidad=" + subir[1] + " where objeto='" + objeto + "'";
            }
            else if (subir.Count == 1 && SoloDigitos(subir[0])) {
                consulta += "cantidad=" + subir[0] + " where objeto='" + objeto + "'";
            }
            else if (subir.Count == 1)
            {
                consulta += "observacion='" + subir[0] + "' where objeto='" + objeto + "'";
            }

            try
            {
                conSQL.abrirConexion();
                SqlDataReader lector = conSQL.hacerConsulta(consulta);

                conSQL.cerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public Boolean VerificarDisponibilidad(string objeto)
        {
            Conectar conSQL = new Conectar();

            try
            {
                conSQL.abrirConexion();
                SqlDataReader lector = conSQL.hacerConsulta("select estado from dataobjetos where objeto='" + objeto + "'");

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        return (bool)lector.GetSqlBoolean(0);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return false;
        }

        private bool SoloDigitos(string str)
        {
            foreach(char c in str)
            {
                if (c < '0' || c > '9')
                {
                    return false;
                }
            }
            return true;
        }

        private IList<String> getDeporte()
        {
            Conectar conSQL = new Conectar();
            IList<String> objetos = new List<String>();

            try
            {
                conSQL.abrirConexion();
                SqlDataReader lector = conSQL.hacerConsulta("select deporte from DataObjetos");

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        objetos.Add(lector.GetString(0));
                    }
                }

                conSQL.cerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }

            return objetos;
        }

        private IList<int> getCantidades()
        {
            Conectar conSQL = new Conectar();
            IList<int> objetos = new List<int>();

            try
            {
                conSQL.abrirConexion();
                SqlDataReader lector = conSQL.hacerConsulta("select cantidad from DataObjetos");

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        objetos.Add((int)lector.GetInt32(0));
                    }
                }

                conSQL.cerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }

            return objetos;
        }

        private IList<String> getDetalles()
        {
            Conectar conSQL = new Conectar();
            IList<String> objetos = new List<String>();

            try
            {
                conSQL.abrirConexion();
                SqlDataReader lector = conSQL.hacerConsulta("select observacion from DataObjetos");

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        if(lector.IsDBNull(0))
                        {
                            objetos.Add("Sin observaciones");
                        }
                        else
                        {
                            objetos.Add(lector.GetString(0));
                        }
                    }
                }

                conSQL.cerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }

            return objetos;
        }

        private IList<Boolean> getEstado()
        {
            Conectar conSQL = new Conectar();
            IList<Boolean> objetos = new List<Boolean>();

            try
            {
                conSQL.abrirConexion();
                SqlDataReader lector = conSQL.hacerConsulta("select estado from DataObjetos");

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        objetos.Add((bool)lector.GetSqlBoolean(0));
                    }
                }

                conSQL.cerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }

            return objetos;
        }
    }
}
