using conexion_basedatos;
using System;
using System.Collections.Generic;

namespace lab_6
{
    class ConexionDB
    {
        public static void Main(string[] args)
        {
            ConexionDB db = new ConexionDB();
            db.query();

            Console.ReadKey();
        }

        private void query()
        {
            //Objeto c = new Objeto();
            //IList<String> ciudaes = c.getDetalles();

            //if (ciudaes == null)
            //{
            //    Console.WriteLine("Nada");
            //    return;
            //}

            //for (int i = 0; i < ciudaes.Count; i++)
            //{
            //    Console.WriteLine(ciudaes[i]);
            //}

            //Verificar verificar = new Verificar();
            //if(verificar.ValidarRegistro("20213120|Kristopher|Rospigliosi Gonzales|krospigliosig@unsa.edu.pe|"))
            //{
            //    Console.WriteLine("si");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}

            //Registro registro = new Registro();
            //registro.RegistrarUser("8989|qqq|eee|i@unsa.edu.pe|jlian|u|");

            //Verificar verif = new Verificar();
            //Console.WriteLine(verif.ValidarCUI("8989|"));

            Objeto objeto = new Objeto();
            Console.WriteLine(objeto.VerificarDisponibilidad("Pelota 5"));

            //IList<string> info = objeto.InfoObjetos("Tablero");
            //foreach (string str in info)
            //{
            //    Console.WriteLine(str);
            //}

            //Verificar fechas = new Verificar();
            //Console.WriteLine(fechas.VerificarSancion("2020"));
        }
    }
}