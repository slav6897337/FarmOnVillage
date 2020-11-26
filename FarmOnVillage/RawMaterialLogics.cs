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

        /// <summary>
        /// Removes raw material from the database.
        /// </summary>
        /// <param name="farm"></param>
        /// <param name="animal"></param>
        internal static void DeleteRawFaterialFromBd(Farm farm, Animal animal)
        {
            using (var context = new FarmContext())
            {
                var farmTemp = new Farm()
                {
                    FarmId = farm.FarmId,
                    RawMaterialOnFarm = new RawMaterial()
                    {
                        RawMaterialId = farm.RawMaterialOnFarm.RawMaterialId,
                        AnimalsFree = new List<Animal>()
                        {
                            new Animal()
                            {
                                AnimalId = animal.AnimalId
                            }
                        }
                    }
                };
                context.Farms.Attach(farmTemp);
                context.Entry(farmTemp.RawMaterialOnFarm.AnimalsFree.First()).State = EntityState.Deleted;

                context.SaveChanges();
            }
        }
    }
}
