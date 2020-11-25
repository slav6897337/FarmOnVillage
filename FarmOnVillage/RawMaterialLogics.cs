// <copyright file="RawMaterial.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FarmOnVillage
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Farm.Data;

    /// <summary>
    /// Class Raw material.
    /// </summary>
    public static class RawMaterialLogics
    {
        /// <summary>
        /// Method report raw material.
        /// </summary>
        public static void ReportRawMaterial(RawMaterial rawMaterial)
        {
            foreach (var animal in rawMaterial.AnimalsFree)
            {
                Console.WriteLine($"\t {animal.NameAnimal} on Raw Material");
            }

            foreach (var plant in rawMaterial.PlantsFree)
            {
                Console.WriteLine($"\t {plant.NamePlant} on Raw Material");
            }
        }
    }
}
