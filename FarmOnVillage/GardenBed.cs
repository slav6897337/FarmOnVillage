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

            int planed = 0;
            foreach (var item in PlantsBed)
            {
                planed += item.AriaOfSeat;
            }

            Console.WriteLine($"\npercentage of occupancy {planed * 100 / Square}%");
        }
    }
}
