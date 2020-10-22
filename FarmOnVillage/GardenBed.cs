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
        /// Initializes a new instance of the <see cref="GardenBed"/> class.
        /// </summary>
        public GardenBed()
        {
            Square = 10;
            PlantsBed = new List<Plants>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GardenBed"/> class.
        /// </summary>
        /// <param name="square"></param>
        public GardenBed(int square)
        {
            Square = square;
            PlantsBed = new List<Plants>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GardenBed"/> class.
        /// </summary>
        /// <param name="square"></param>
        /// <param name="plant"></param>
        public GardenBed(int square, Plants plant)
        {
            Square = square;
            PlantsBed = new List<Plants>();
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
        public void AddPlantsToThebed()
        {
            Plants plantToAdd = new Plants();
            Console.WriteLine("Enter name product");
            string namePlant = Console.ReadLine();
            plantToAdd.NamePlant = "Cucumber";
            Console.WriteLine("Enter area of seat");
            int ariaOfSeat = int.Parse(Console.ReadLine());
            plantToAdd.AriaOfSeat = ariaOfSeat;
            Console.WriteLine("Enter name season seat");
            int seasonSeat = int.Parse(Console.ReadLine());
            plantToAdd.SeasonSeat = seasonSeat;
            Console.WriteLine("Enter season gather");
            int seasonGather = int.Parse(Console.ReadLine());
            plantToAdd.SeasonGather = seasonGather;

            if (UsedAreaBed() + ariaOfSeat < Square)
            {
                PlantsBed.Add(plantToAdd);
                Console.WriteLine("Mew Plant add");
            }
            else
            {
                Console.WriteLine("Sorry Square is busy");
            }
        }
    }
}
