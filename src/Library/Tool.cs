//-------------------------------------------------------------------------------
// <copyright file="Equipment.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// Clase que representa un equipo.
    /// </summary>
    public class Tool
    {
        /// <summary>
        /// El constructor de la clase.
        /// </summary>
        public Tool(string description, double hourlyCost)
        {
            this.Description = description;
            this.HourlyCost = hourlyCost;
        }

        /// <summary>   
        /// Descripción del equipo.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Costo por hora del equipo.
        /// </summary>
        public double HourlyCost { get; set; }
    }
}