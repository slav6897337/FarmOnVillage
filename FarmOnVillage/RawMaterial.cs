// <copyright file="RawMaterial.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FarmOnVillage
{
    using System;
    using System.Collections.Generic;

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
        public List<Animal> AnimalsFree { get; set; }

        /// <summary>
        /// Gets or sets PlantsFree.
        /// </summary>
        public List<Plant> PlantsFree { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RawMaterial"/> class.
        /// </summary>
        public RawMaterial()
        {
            AnimalsFree = new List<Animal>();
            PlantsFree = new List<Plant>();
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
