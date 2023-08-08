using conexion_basedatos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace servicio_basedatos
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public IList<String> getObjetosBD()
        {
            Objeto obj = new Objeto();
            IList<String> Implementos = new List<String>();
            Implementos = obj.getImplementos();
            return Implementos;
        }

        public IList<String> InfoObjetos(string objeto)
        {
            Objeto obj = new Objeto();
            IList<String> info = obj.InfoObjetos(objeto);
            return info;
        }

        public void AgregarObj(string objeto)
        {
            Objeto obj = new Objeto();
            obj.AgregarObjeto(objeto);
        }

        public void EliminarObj(string objeto)
        {
            Objeto obj = new Objeto();
            obj.EliminarObjeto(objeto);
        }

        public void ModificarObj(string objeto, string info)
        {
            Objeto obj = new Objeto();
            obj.ModifObjeto(objeto, info);
        }

        public Boolean estaDisponible(string objeto)
        {
            Objeto obj = new Objeto();
            return obj.VerificarDisponibilidad(objeto);
        }

        public IList<String> InfoUsuario(string cui)
        {
            Verificar verif = new Verificar();
            IList<String> informacion = verif.InfoUsuario(cui);
            return informacion;
        }

        public Boolean ValidarReg(string Registro)
        {
            Verificar verificar = new Verificar();
            return verificar.ValidarRegistro(Registro);
        }

        public Boolean ValidarIS(string InicioSesion)
        {
            Verificar verificar = new Verificar();
            return verificar.ValidarInicioSesion(InicioSesion);
        }

        public Boolean VerificarCUI(string cui)
        {
            Verificar verificar = new Verificar();
            return verificar.ValidarCUI(cui);
        }

        public void Registrar(string data)
        {
            Registro registro = new Registro();
            registro.RegistrarUser(data);
        }

        public void Sancion(string cui, int dias)
        {
            Fechas fecha = new Fechas();
            fecha.Sancionar(cui, dias);
        }

        public void Levantar(string cui)
        {
            Fechas fecha = new Fechas();
            fecha.Levantar(cui);
        }

        public string RevisarSanciones(string cui)
        {
            Verificar verif = new Verificar();
            return verif.VerificarSancion(cui);
        }
    }
}
