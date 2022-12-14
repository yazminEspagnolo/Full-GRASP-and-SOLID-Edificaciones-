using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter 
    {
        public static void PrintBuilding(Building building)
        {
            Console.WriteLine($"Edificio {building.PrintBuilding()}:");
        }
        // Utilizo el patrón SRP para que la clase ConsolePrinter solo se encargue de imprimir en consola
    }
}