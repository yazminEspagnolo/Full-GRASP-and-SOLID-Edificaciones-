using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// Clase que representa la impresión en consola.
    /// </summary>

    public class ConsolePrinter : IPrinter
    {
        /// <summary>
        /// Este método imprime un edificio en consola.
        /// </summary>
        /// <param name="building"></param>
        public void PrintBuilding(Building building)
        {
            Console.WriteLine(building.PrintBuilding());
        }
        
    }
    // Se utiliza el patrón Polimorfismo para que la clase ConsolePrinter y FilePrinter implementen la interfaz IPrinter.
}