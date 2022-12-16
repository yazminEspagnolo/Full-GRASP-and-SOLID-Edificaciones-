using System;
using System.Collections;
using System.IO;


namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// Clase que representa la impresión en consola.
    /// </summary>
    public class FilePrinter : IPrinter
    {
        /// <summary>
        /// Este método imprime un edificio en archivo.
        /// </summary>
        public void PrintBuilding(Building building)
        {
            File.WriteAllText("Building.txt", building.PrintBuilding());
        }
    }
    // Se utiliza el patrón Polimorfismo para que la clase ConsolePrinter y FilePrinter implementen la interfaz IPrinter.
}