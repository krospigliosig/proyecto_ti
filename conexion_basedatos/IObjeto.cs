using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexion_basedatos
{
    public interface IObjeto
    {
        IList<String> getImplementos();

        IList<String> InfoObjetos(string objeto);

        void AgregarObjeto(string objeto);

        void EliminarObjeto(string objeto);

        void ModifObjeto(string objeto, string info);

        Boolean VerificarDisponibilidad(string objeto);
    }
}
