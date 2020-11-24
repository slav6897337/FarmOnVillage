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
        /// Gets or sets PlantId.
        /// </summary>
        public int GardenBedId { get; set; }

        /// <summary>
        /// Gets or sets property Square.
        /// </summary>
        public int Square { get; set; }

        /// <summary>
        /// Gets or sets property Square.
        /// </summary>
        public List<Plant> PlantsBed { get; set; } = new List<Plant>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GardenBed"/> class.
        /// </summary>
        public GardenBed()
        {
            Square = 10;
            PlantsBed = new List<Plant>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GardenBed"/> class.
        /// </summary>
        /// <param name="square"></param>
        public GardenBed(int square)
        {
            Square = square;
            PlantsBed = new List<Plant>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GardenBed"/> class.
        /// </summary>
        /// <param name="square"></param>
        /// <param name="plant"></param>
        public GardenBed(int square, Plant plant)
        {
            Square = square;
            PlantsBed = new List<Plant>();
            PlantsBed.Add(plant);
        }

        /// <summary>
        /// Console write report of garden Bed.
        /// </summary>
        public void ReportGardenBed()
        {
            Console.WriteLine($"This is the Garden Bed square equals {Square}");
            Console.Write($"Plants grow in the garden Bed: ");
            foreach (var item in PlantsBed)
            {
                Console.Write($"{item.NamePlant} ");
            }

            Console.WriteLine($"percentage of occupancy {UsedAreaBed() * 100 / Square}%\n");
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
        /// Method add Plants to the bed.
        /// </summary>
        /// <returns>free or not area.</returns>
        /// <param name="plants"></param>
        public bool ChekFreeBed(Plant plants)
        {
            return UsedAreaBed() + plants.AriaOfSeat < Square;
        }
    }
}
