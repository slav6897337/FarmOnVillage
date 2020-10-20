// <copyright file="GardenBed.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FarmOnVillage
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// class GardenBed.
    /// </summary>
    public class GardenBed
    {
        /// <summary>
        /// Gets or sets property Square.
        /// </summary>
        public int Square { get; set; }

        /// <summary>
        /// Gets or sets property Square.
        /// </summary>
        public List<Plants> PlantsBed { get; set; }

        /// <summary>
        /// Console write report of garden Bed.
        /// </summary>
        public void ReportGardenBed()
        {
            Console.WriteLine($"Thesis Garden Bed square equals {Square}");
            Console.Write($"Plants grow in the garden Bed: ");
            foreach (var item in PlantsBed)
            {
                Console.Write($"{item.NamePlant} ");
            }

            Console.WriteLine($"\npercentage of occupancy {UsedAreaBed() * 100 / Square}%");
        }

        /// <summary>
        /// Method calculate used area.
        /// </summary>
        /// <returns> Used area.</returns>
        private int UsedAreaBed()
        {
            int usedAreaBed = 0;
            foreach (var item in PlantsBed)
            {
                usedAreaBed += item.AriaOfSeat;
            }

            return usedAreaBed;
        }

        /// <summary>
        /// This Method add plants to Garden Bed.
        /// </summary>
        /// <param name="val"></param>
        public void AddPlantToGardenBed(Plants val)
        {
            if (UsedAreaBed() + val.AriaOfSeat < Square)
            {
                PlantsBed.Add(val);
            }
            else
            {
                Console.WriteLine("Sorry Square is busy");
            }
        }
    }
}
