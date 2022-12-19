//---------------------------------------------------------------------------------
// <copyright file="AllInOnePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------
using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// Esta clase hace de intermediario entre la clase Building y la clase ConsolePrinter.
    /// </summary>
    public enum Destination
    {
        /// <summary>
        /// Constante que representa la impresión en consola.
        /// </summary>
        Console,
        /// <summary>
        /// Constante que representa la impresión en un archivo.
        /// </summary>
        File
    }

    /// <summary>
    /// Esta clase se encarga de imprimir un edificio.
    /// </summary>
    public class AllInOnePrinter
    {
        /// <summary>
        /// Este método imprime un edificio.
        /// </summary>
        public void PrintRecipe(Building building, Destination destination)
        {
            if (destination == Destination.Console) // No se cumple el principio de responsabilidad única, ya que esta clase se encarga de imprimir en consola y en archivo.
            {
                Console.WriteLine(building.GetTextToPrint());
            }
            else
            {
                File.WriteAllText("Building.txt", building.GetTextToPrint());
            }
        }

        // Se utiliza el patrón Polimorfismo para que la clase ConsolePrinter y FilePrinter implementen la interfaz IPrinter.
    }
}