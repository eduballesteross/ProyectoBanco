using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPrueba.Servicios
{

    /// <summary>
    /// Interfaz con la redacción de métodos de la funcionalidad menú 
    /// 250923 - ebp
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Método que muestra mensaje de bienvenida al cajero
        /// </summary>
        public void mostrarMensajeBienvenida();

        /// <summary>
        ///  Método que muestra el menu y guarda la seleccion del usuario
        ///  26092023 - ebp
        /// </summary>
        /// <returns>Entero con la opcion seleccionar</returns>
        public int mostrarMenuySeleccion();


    }
}
