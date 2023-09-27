using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPrueba.Servicios
{
    /// <summary>
    /// Cajero que implementa la interfaz menú
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public void mostrarMensajeBienvenida()
        {
            String mensaje = "Cajero CSI1";
            Console.WriteLine(mensaje);
        }

        public int mostrarMenuySeleccion()
        {

            //Definimos variables que vamos a utilizar

            int opcionSeleccionadaMenu;

            Console.WriteLine("---------------------------------");
            Console.WriteLine("0. Cerrar aplicación");
            Console.WriteLine("1. Darse de alta");
            Console.WriteLine("2. Ingresar dinero");
            Console.WriteLine("3. Sacar dinero");
            Console.WriteLine("4. Transferir dinero");
            Console.WriteLine("5. Historia de operaciones");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Seleccione una opción:     ");

            //Guardamos la respuesta del usuario(ReadKey - Solo lee un cáracter)
            //KeyChar (Guarda la primera tecla que pulse el usuario)

            opcionSeleccionadaMenu = Console.ReadKey(true).KeyChar - ('0');
            return opcionSeleccionadaMenu;

        }
    }
}
