// <copyright file="GardenBed.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FarmOnVillage
{
    using System;
    using Farm.Data;

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
            Console.Clear();
            if (farm.GardenBedFarm.Count == 0)
            {
                Console.WriteLine("\n\n\t There are no Garden bed on the farm");
                return;
            }

            Console.WriteLine("\n\nPlease choose in what Garden bed do you wont add plants");
            for (int i = 0; i < farm.GardenBedFarm.Count; i++)
            {
                Console.WriteLine($"\t {i + 1} - Garden Bed");
            }

            int bed;
            while (!int.TryParse(Console.ReadLine(), out bed) || bed - 1 < 0 || bed - 1 >= farm.GardenBedFarm.Count)
            {
                Console.WriteLine("\n\tPlease enter correctly data");
            }

            FarmLogics.ChecfreeGardenBed(farm, farm.GardenBedFarm[bed - 1]);
        }
    }
}
