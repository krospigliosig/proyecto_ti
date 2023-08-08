using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexion_basedatos
{
    public interface IFechas
    {
        void Sancionar(string cui, int dias);

        void Levantar(string cui);
    }
}
