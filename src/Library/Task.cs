//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// Clase que representa una tarea.
    /// </summary>
    public class Task
    {
        /// <summary>
        /// El constructor de la clase.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="quantity"></param>
        /// <param name="equipment"></param>
        /// <param name="time"></param>
        public Task(Supply material, double quantity, Tool equipment, int time)
        {
            this.Quantity = quantity;
            this.Material = material;
            this.Time = time;
            this.Equipment = equipment;
        }

        /// <summary>
        /// Material de la tarea.
        /// </summary>
        public Supply Material { get; set; }

        /// <summary>
        /// Cantidad de material de la tarea.
        /// </summary>
        public double Quantity { get; set; }

        /// <summary>
        /// Tiempo de la tarea.
        /// </summary>
        public int Time { get; set; }

        /// <summary>
        /// Equipo de la tarea.
        /// </summary>
        public Tool Equipment { get; set; }

    }
}