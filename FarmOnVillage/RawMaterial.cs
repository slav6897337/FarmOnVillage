// <copyright file="RawMaterial.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FarmOnVillage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Class Raw material.
    /// </summary>
    public class RawMaterial
    {
        /// <summary>
        /// Gets or sets RawMaterialId.
        /// </summary>
        public int RawMaterialId { get; set; }

        /// <summary>
        ///  Gets or sets AnimalsFree.
        /// </summary>
        public List<Animal> AnimalsFree { get; set; } = new List<Animal>();

        /// <summary>
        /// Gets or sets PlantsFree.
        /// </summary>
        public List<Plant> PlantsFree { get; set; } = new List<Plant>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RawMaterial"/> class.
        /// </summary>
        public RawMaterial()
        {
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
