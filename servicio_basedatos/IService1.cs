using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace servicio_basedatos
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        IList<String> getObjetosBD();

        [OperationContract]
        IList<String> InfoObjetos(string objeto);

        [OperationContract]
        void AgregarObj(string objeto);

        [OperationContract]
        void EliminarObj(string objeto);

        [OperationContract]
        void ModificarObj(string objeto, string info);

        [OperationContract]
        Boolean estaDisponible(string objeto);

        [OperationContract]
        IList<String> InfoUsuario(string cui);

        [OperationContract]
        Boolean ValidarReg(string Registro);

        [OperationContract]
        Boolean ValidarIS(string InicioSesion);

        [OperationContract]
        void Registrar(string data);

        [OperationContract]
        Boolean VerificarCUI(string cui);

        [OperationContract]
        void Sancion(string cui,int dias);

        [OperationContract]
        void Levantar(string cui);

        [OperationContract]
        string RevisarSanciones(string cui);
    }
}
