// <copyright file="RawMaterial.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FarmOnVillage
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Class Raw material.
    /// </summary>
    public class RawMaterial
    {
        /// <summary>
        ///  Gets or sets AnimalsFree.
        /// </summary>
        public List<Animals> AnimalsFree { get; set; }

        /// <summary>
        /// Gets or sets PlantsFree.
        /// </summary>
        public List<Plants> PlantsFree { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RawMaterial"/> class.
        /// </summary>
        public RawMaterial()
        {
            AnimalsFree = new List<Animals>();
            PlantsFree = new List<Plants>();
        }

        /// <summary>
        /// Method report raw material.
        /// </summary>
        public void ReportRawMaterial()
        {
            foreach (var animal in AnimalsFree)
            {
                Console.WriteLine($"{animal.NameAnimal} on Raw Material");
            }

            foreach (var plant in PlantsFree)
            {
                Console.WriteLine($"{plant.NamePlant} on Raw Material");
            }
        }
    }
}
