using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexion_basedatos
{
    public class Verificar : IVerificar
    {
        public Boolean ValidarRegistro(string Registro)
        {
            Conectar conSql = new Conectar();
            IList<String> datosEstandarizados = new List<String>();
            string tabla = "alumnosepcc";

            IList<int> datosCUI = getCUI(conSql,tabla);
            IList<String> datosNombres = getNombres(conSql,tabla);
            IList<String> datosApellidos = getApellidos(conSql,tabla);
            IList<String> datosCorreos = getCorreos(conSql,tabla);

            string temp = "";
            for (int i = 0; i < Registro.Length; i++)
            {
                if (Registro[i] != '|')
                {
                    temp += Registro[i];
                }
                else
                {
                    datosEstandarizados.Add(temp);
                    temp = "";
                }
            }

            int cui = Int32.Parse(datosEstandarizados[0]);

            if (!datosCUI.Contains(cui))
            {
                return false;
            }
            if (!datosNombres.Contains(datosEstandarizados[1]))
            {
                return false;
            }
            if (!datosApellidos.Contains(datosEstandarizados[2]))
            {
                return false;
            }
            if (!datosCorreos.Contains(datosEstandarizados[3]))
            {
                return false;
            }

            return true;
        }

        public Boolean ValidarInicioSesion(string InicioSesion)
        {
            Conectar conSql = new Conectar();
            IList<String> datosEstandarizados = new List<String>();

            string temp = "";
            for (int i = 0; i < InicioSesion.Length; i++)
            {
                if (InicioSesion[i] != '|')
                {
                    temp += InicioSesion[i];
                }
                else
                {
                    datosEstandarizados.Add(temp);
                    temp = "";
                }
            }

            string tabla = "";
            if (datosEstandarizados.Count == 2)
            {
                tabla = "Registrados";
            }
            else
            {
                tabla = "RegistradosAdmin";
            }

            IList<String> datosNombres = getNombres(conSql, tabla);
            IList<String> datosContraseñas = getContraseña(conSql, tabla);

            if (!datosNombres.Contains(datosEstandarizados[0]))
            {
                return false;
            }
            if (!datosContraseñas.Contains(datosEstandarizados[1]))
            {
                return false;
            }
            return true;
        }

        public Boolean ValidarCUI(string CUI)
        {
            Conectar conSql = new Conectar();
            IList<String> CUI_ = new List<String>();

            string temp = "";
            for (int i = 0; i < CUI.Length; i++)
            {
                if (CUI[i] != '|')
                {
                    temp += CUI[i];
                }
                else
                {
                    CUI_.Add(temp);
                    temp = "";
                }
            }

            string tabla = "";
            if (CUI_.Count == 2)
            {
                tabla = "RegistradosAdmin";
            }
            else
            {
                tabla = "Registrados";
            }

            IList<int> datosCUI = getCUI(conSql, tabla);
            int iCUI = Int32.Parse(CUI_[0]);

            if (datosCUI.Contains(iCUI))
            {
                return true;
            }
            return false;
        }

        public IList<String> InfoUsuario(string cui)
        {
            Conectar conSql = new Conectar();

            Dictionary<string, string> data = new Dictionary<string, string>();

            try
            {
                conSql.abrirConexion();
                SqlDataReader lector = conSql.hacerConsulta("select * from Registrados where cui='" + cui + "'");

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        data["nombres"] = lector["nombres"].ToString();
                        data["apellidos"] = lector["apellidos"].ToString();
                        data["cui"] = lector["cui"].ToString();
                        data["correo"] = lector["correo"].ToString();

                        if (lector["prestado"].ToString() == "")
                        {
                            data["prestado"] = "No";
                        }
                        else
                        {
                            data["prestado"] = lector["prestado"].ToString();
                        }
                    }

                    conSql.cerrarConexion();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }

            IList<String> informacion = data.Values.ToArray();
            return informacion;
        }

        public string VerificarSancion(string cui)
        {
            Conectar conSql = new Conectar();
            string estado = "";

            try
            {
                conSql.abrirConexion();

                SqlDataReader lector = conSql.hacerConsulta("select sancionado from registrados where cui='" + cui + "'");

                if (lector.HasRows)
                {
                    while(lector.Read())
                    {
                        try
                        {
                            estado = "Sancionado hasta: " + lector.GetDateTime(0).ToString();
                        }
                        catch (Exception)
                        {
                            estado = "Sin sanciones";
                        }
                    }
                }

                conSql.cerrarConexion();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }

            return estado;
        }

        private IList<int> getCUI(Conectar conSql, string tabla)
        {
            IList<int> cuis = new List<int>();

            try
            {
                conSql.abrirConexion();

                SqlDataReader lector = conSql.hacerConsulta("select cui from " + tabla);

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        cuis.Add((int)lector.GetInt32(0));
                    }
                }

                conSql.cerrarConexion();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }

            return cuis;
        }

        private IList<String> getNombres(Conectar conSql, string tabla)
        {
            IList<String> noms = new List<String>();

            try
            {
                conSql.abrirConexion();

                SqlDataReader lector = conSql.hacerConsulta("select nombres from " + tabla);

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        noms.Add(lector.GetString(0));
                    }
                }

                conSql.cerrarConexion();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }

            return noms;
        }

        private IList<String> getApellidos(Conectar conSql, string tabla)
        {
            IList<String> apls = new List<String>();

            try
            {
                conSql.abrirConexion();

                SqlDataReader lector = conSql.hacerConsulta("select apellidos from " + tabla);

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        apls.Add(lector.GetString(0));
                    }
                }

                conSql.cerrarConexion();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }

            return apls;
        }

        private IList<String> getCorreos(Conectar conSql, string tabla)
        {
            IList<String> cors = new List<String>();

            try
            {
                conSql.abrirConexion();

                SqlDataReader lector = conSql.hacerConsulta("select correo from " + tabla);

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        cors.Add(lector.GetString(0));
                    }
                }

                conSql.cerrarConexion();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }

            return cors;
        }

        private IList<String> getContraseña(Conectar conSql, string tabla)
        {
            IList<String> pwrd = new List<String>();

            try
            {
                conSql.abrirConexion();

                SqlDataReader lector = conSql.hacerConsulta("select contrasena from " + tabla);

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        pwrd.Add(lector.GetString(0));
                    }
                }

                conSql.cerrarConexion();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }

            return pwrd;
        }
    }
}
