using EjercicioPrueba.Servicios;

namespace EjercicioPrueba.Controladores
{
    /// <summary>
    /// Clase principal de la aplicación
    /// 250923- ebp
    /// </summary>

    internal class Program
    {
        /// <summary>
        /// Método de entrada de la aplicación
        /// 250923 -ebp
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {

            
            MenuInterfaz menuI = new MenuImplementacion();
            menuI.mostrarMensajeBienvenida();

            //variable que controla el bucle while
            bool cerrarMenu = false;
            //variable del usuario
            int opcionSeleccionar;

            //desde la primera interacción debe cumplirse la condición
            while (!cerrarMenu) 
            {
                /*
                 * Asingno el valor de la variable opcionSeleccionarMenu a opcionSeleccionar
                 */

                opcionSeleccionar = menuI.mostrarMenuySeleccion();
                Console.WriteLine(opcionSeleccionar);

                switch (opcionSeleccionar)

                {
                    case 0:
                        Console.WriteLine("INFO-- Se ejecuta caso 0");
                        cerrarMenu= true;
                        break;

                    case 1:
                        Console.WriteLine("INFO-- Se ejecuta caso 1");
                        break;

                    case 2:
                        Console.WriteLine("INFO-- Se ejecuta caso 2");
                        break;

                    case 3:
                        Console.WriteLine("INFO-- Se ejecuta caso 3");
                        break;

                    case 4:
                        Console.WriteLine("INFO-- Se ejecuta caso 4");
                        break;

                    case 5:
                        Console.WriteLine("INFO-- Se ejecuta caso 5");
                        break;

                    default:

                        Console.WriteLine("[INFO] - La opción seleccionada no coincide");
                        break;
                }

            }


        }
    }

}