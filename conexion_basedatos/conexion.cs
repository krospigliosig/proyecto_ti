using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexion_basedatos
{
    class Conectar
    {
        private SqlConnection conexion;
        private String path;

        public Conectar()
        {
            path = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\pc\\AppData\\Local\\Microsoft\\VisualStudio\\SSDT\\database_ti.mdf;Integrated Security=True;Connect Timeout=30";
        }

        public Boolean abrirConexion()
        {
            try
            {
                conexion = new SqlConnection(path);
                conexion.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public void cerrarConexion()
        {
            conexion.Close();
        }

        public SqlDataReader hacerConsulta(String consulta)
        {
            try
            {
                SqlCommand query = new SqlCommand(consulta, conexion);
                SqlDataReader lector = query.ExecuteReader();
                return lector;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
