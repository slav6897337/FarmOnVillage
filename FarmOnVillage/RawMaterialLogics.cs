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
            RawMaterial rawmat = null;
            using (var context = new FarmContext())
            {
                rawmat = context.RawMaterials
                                .Include(x => x.PlantsFree)
                                .Include(x => x.AnimalsFree)
                                .FirstOrDefault(x => x.RawMaterialId == rawMaterial.RawMaterialId);
            }

            foreach (var animal in rawmat.AnimalsFree)
            {
                Console.WriteLine($"{animal.NameAnimal} on Raw Material");
            }

            foreach (var plant in rawmat.PlantsFree)
            {
                Console.WriteLine($"{plant.NamePlant} on Raw Material");
            }
        }
    }
}
