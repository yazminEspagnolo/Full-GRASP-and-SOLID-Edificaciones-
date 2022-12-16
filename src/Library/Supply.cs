//--------------------------------------------------------------------------------------
// <copyright file="Product.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// Clase que representa un producto.
    /// </summary>
    public class Supply
    {
        /// <summary>
        /// El constructor de la clase.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="unitCost"></param>
        public Supply(string description, double unitCost)
        {
            this.Description = description;
            this.UnitCost = unitCost;
        }

        /// <summary>
        /// Descripción del producto.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Costo unitario del producto.
        /// </summary>
        public double UnitCost { get; set; }
    }
}