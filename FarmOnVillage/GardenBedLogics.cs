// <copyright file="GardenBed.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FarmOnVillage
{
    using System;
    using System.Linq;
    using Farm.Data;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// class GardenBed.
    /// </summary>
    public static class GardenBedLogics
    {
        /// <summary>
        /// Console write report of garden Bed.
        /// </summary>
        public static void ReportGardenBed(GardenBed gardenBed)
        {
            Console.WriteLine($"This is the Garden Bed square equals {gardenBed.Square}");
            Console.Write($"Plants grow in the garden Bed: ");
            foreach (var item in gardenBed.PlantsBed)
            {
                Console.Write($"{item.NamePlant} ");
            }

            Console.WriteLine($"percentage of occupancy {UsedAreaBed(gardenBed) * 100 / gardenBed.Square}%\n");
        }

        /// <summary>
        /// Method calculate used area.
        /// </summary>
        /// <returns> Used area.</returns>
        private static int UsedAreaBed(GardenBed gardenBed)
        {
            int usedAreaBed = 0;
            foreach (var item in gardenBed.PlantsBed)
            {
                usedAreaBed += item.AriaOfSeat;
            }

            return usedAreaBed;
        }

        /// <summary>
        /// Method add Plants to the bed.
        /// </summary>
        /// <returns>free or not area.</returns>
        /// <param name="plants"></param>
        public static bool ChekFreeBed(GardenBed gardenBed, Plant plants)
        {
            return UsedAreaBed(gardenBed) + plants.AriaOfSeat < gardenBed.Square;
        }

        /// <summary>
        /// Method add Plants to bed.
        /// </summary>
        public static void AddPlantsToBed(Farm farm)
        {
            while (true)
            {
                Console.Clear();
                if (farm.GardenBedFarm.Count == 0)
                {
                    Console.WriteLine("\n\n\t There are no Garden bed on the farm");
                    Console.ReadKey();
                    return;
                }

                Console.WriteLine("\n\n\tPlease choose in what Garden bed do you wont add plants");
                for (int i = 0; i < farm.GardenBedFarm.Count; i++)
                {
                    Console.WriteLine($"\t {i + 1} - Garden Bed");
                }

                Console.WriteLine($"\t b - back");

                int bed;
                while (!int.TryParse(Console.ReadLine(), out bed) || bed - 1 < 0 || bed - 1 >= farm.GardenBedFarm.Count)
                {
                    Console.WriteLine("\n\tPlease enter correctly data");
                    return;
                }

                FarmLogics.ChecfreeGardenBed(farm, farm.GardenBedFarm[bed - 1]);
            }
        }

        internal static void AddFreePlantsToBed(Farm farm, GardenBed bed, Plant choisenPlant)
        {
            Plant plant = new Plant()
            {
                NamePlant = choisenPlant.NamePlant,
                Price = choisenPlant.Price,
                AriaOfSeat = choisenPlant.AriaOfSeat,
                Harvest = choisenPlant.Harvest,
                SeasonGather = choisenPlant.SeasonGather,
                SeasonSeat = choisenPlant.SeasonSeat
            };

            bed.PlantsBed.Add(plant);
            SaveAnimalToGb(farm, bed, plant);
            farm.RawMaterialOnFarm.PlantsFree.Remove(choisenPlant);
            RawMaterialLogics.DeleteRawMaterialFromBd(farm, choisenPlant);
            Console.WriteLine("\n\t Mew Plant added");
            Console.ReadKey();
        }

        /// <summary>
        /// Save changes after added animal in Building.
        /// </summary>
        /// <param name="farm">Farm.</param>
        /// <param name="build">Building.</param>
        /// <param name="animal">New animal.</param>
        private static void SaveAnimalToGb(Farm farm, GardenBed bed, Plant plant)
        {
            using (var context = new FarmContext())
            {
                context.Farms.Attach(farm);
                context.Entry(farm
                    .GardenBedFarm
                    .First(b => b.GardenBedId == bed.GardenBedId)
                    .PlantsBed
                    .First(a => a.PlantId == plant.PlantId))
                    .State = EntityState.Added;

                context.SaveChanges();
            }
        }
    }
}
