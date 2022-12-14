//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Building
    {
        private ArrayList tasks = new ArrayList();

        public Building(string name)
        {
            this.Description = name;
        }

        public string Description { get; set; }

        public void AddTask(Task task)
        {
            this.tasks.Add(task);
        }

        public void RemoveTask(Task task)
        {
            this.tasks.Remove(task);
        }

        public string PrintBuilding()
        {
            // no imprime solo retorna lo que se imprime
            string building = $"Edificio {this.Description}:\n";
            foreach (Task task in this.tasks)
            {
                building += $"{task.Quantity} de '{task.Material.Description}' " +
                    $"usando '{task.Equipment.Description}' durante {task.Time}\n";
            }
            building += $"Costo de producción total: {this.GetProductionCost()}";
            return building;

            /* Console.WriteLine($"Edificio {this.Description}:");
            foreach (Task task in this.tasks)
            {
                Console.WriteLine($"{task.Quantity} de '{task.Material.Description}' " +
                    $"usando '{task.Equipment.Description}' durante {task.Time}");
            }
            Console.WriteLine($"Costo de producción total: {this.GetProductionCost()}"); // Agregamos el cálculo del costo de producción en un método. */
        }
 
        public double GetProductionCost()
        {
            double cost = 0;
            foreach (Task task in this.tasks)
            {
                cost += task.Quantity * task.Material.UnitCost;
                cost += task.Time * task.Equipment.HourlyCost;
            }
            return cost;
        }
        
        // Utilizamos el patrón Expert para que la clase Building sea la encargada de calcular el costo de producción porque tiene toda la información necesaria para hacerlo.
    }
}