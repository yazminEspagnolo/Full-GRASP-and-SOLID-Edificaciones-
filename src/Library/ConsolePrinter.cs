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
        /// <param name="printable"></param>
        public void PrintBuilding(IPrintable printable)
        {
            Console.WriteLine(printable.GetTextToPrint());
        }
        
    }
    // Se utiliza el patrón Polimorfismo para que la clase ConsolePrinter y FilePrinter implementen la interfaz IPrinter.
}