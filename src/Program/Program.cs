﻿//-------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;
using System.Linq;
using Full_GRASP_And_SOLID.Library;
using System.Collections.Generic;

namespace Full_GRASP_And_SOLID
{
    /// <summary>
    /// Programa principal.
    /// </summary>
    public class Program
    {
        private static ArrayList supplyCatalog = new ArrayList();

        private static ArrayList toolCatalog = new ArrayList();

        /// <summary>
        /// Este método agrega un producto al catálogo.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            PopulateCatalogs();

            
            Building tower = new Building("Tower");
            tower.AddTask(GetProduct("Cemento"), 100, GetEquipment("Hormigonera"), 120);
            tower.AddTask(GetProduct("Arena"), 200, GetEquipment("Hormigonera"), 120);
            tower.AddTask(GetProduct("Tabla"), 50, GetEquipment("Martillo"), 15);
            
            //IPrintable building = new Building("torre");
            IPrinter filePrinter = new FilePrinter();
            IPrinter consolePrinter = new ConsolePrinter();
            
            consolePrinter.PrintBuilding(tower);
            filePrinter.PrintBuilding(tower);

        }

        private static void PopulateCatalogs()
        {
            AddProductToCatalog("Cemento", 100);
            AddProductToCatalog("Arena", 200);
            AddProductToCatalog("Tabla", 300);

            AddEquipmentToCatalog("Hormigonera", 1000);
            AddEquipmentToCatalog("Martillo", 2000);
        }

        private static void AddProductToCatalog(string description, double unitCost)
        {
            supplyCatalog.Add(new Supply(description, unitCost));
        }

        private static void AddEquipmentToCatalog(string description, double hourlyCost)
        {
            toolCatalog.Add(new Tool(description, hourlyCost));
        }

        private static Supply ProductAt(int index)
        {
            return supplyCatalog[index] as Supply;
        }

        private static Tool EquipmentAt(int index)
        {
            return toolCatalog[index] as Tool;
        }

        private static Supply GetProduct(string description)
        {
            var query = from Supply product in supplyCatalog where product.Description == description select product;
            return query.FirstOrDefault();
        }

        private static Tool GetEquipment(string description)
        {
            var query = from Tool equipment in toolCatalog where equipment.Description == description select equipment;
            return query.FirstOrDefault();
        }

    
        
    }
}
