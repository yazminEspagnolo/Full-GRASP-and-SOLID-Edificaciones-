//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;




namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// Clase que representa un edificio.
    /// </summary>
    public class Building : IPrintable
    {
        private ArrayList tasks = new ArrayList();

        /// <summary>
        /// Constructor de la clase Building.
        /// </summary>
        /// <param name="name"></param>
        public Building(string name)
        {
            this.Description = name;
        }

        /// <summary>  
        /// Propiedad Description de la clase Building.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Método que agrega una tarea a la lista de tareas.
        /// </summary>
        public void AddTask(Supply material, double quantity, Tool equipment, int time)
        {
            Task task = new Task(material, quantity, equipment, time);
            this.tasks.Add(task);
        }
        

        /// <summary>
        /// Método que remueve una tarea de la lista de tareas.
        /// </summary>
        public void RemoveTask(Task task)
        {
            this.tasks.Remove(task);
        }

        /// <summary>
        /// Método que da los pasos para imprimir un edificio.
        /// </summary>
        public string GetTextToPrint()
        {
            List<string> Buildings = new List<string>();
            Buildings.Add($"Edificio {this.Description}:");
            foreach (Task i in this.tasks)
            {
                Buildings.Add($"{i.Quantity} de '{i.Material.Description}' " +
                    $"usando '{i.Equipment.Description}' durante {i.Time}");
            }
            Buildings.Add($"Cuesta un total de: ${this.GetProductionCost()}");
            return String.Join("\n", Buildings.ToArray());
        }
 
        /// <summary>
        /// Método que calcula el costo de producción de un edificio.
        /// </summary>
        public double GetProductionCost()
        {
            if (tasks.Count == 0)
            {
                throw new EmptyTasksException("La lista de tareas está vacía");
            }
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