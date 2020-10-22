// <copyright file="Farm.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FarmOnVillage
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class that contains Farm.
    /// </summary>
    public class Farm
    {
        /// <summary>
        /// Gets or sets property NameFarm.
        /// </summary>
        public string NameFarm { get; set; }

        /// <summary>
        /// Gets or sets property Area.
        /// </summary>
        public int Area { get; set; }

        /// <summary>
        /// Gets or sets property GardenBed.
        /// </summary>
        public List<GardenBed> GardenBedFarm { get; set; }

        /// <summary>
        /// Gets or sets property BildingFarm.
        /// </summary>
        public List<Bilding> BildingFarm { get; set; }

        /// <summary>
        /// Gets or sets property Stock.
        /// </summary>
        public Stock StockInCountry { get; set; }

        /// <summary>
        /// Method calculate used area on Farm.
        /// </summary>
        /// <returns> Used area.</returns>
        private int UsedAreaFarm()
        {
            int usedAreaFarm = 0;
            foreach (var item in GardenBedFarm)
            {
                usedAreaFarm += item.Square;
            }

            foreach (var item in BildingFarm)
            {
                usedAreaFarm += item.AriaOfBilding;
            }

            return usedAreaFarm;
        }

        /// <summary>
        /// Console write report of Farm.
        /// </summary>
        public void ReportFarm()
        {
            Console.WriteLine($"This is the farm {NameFarm}, area {Area}, " +
                $"{BildingFarm.Count} building and {GardenBedFarm.Count} Garden Beds, " +
                $"Percent used area: {UsedAreaFarm() * 100 / Area}%");
            foreach (var item in GardenBedFarm)
            {
                item.ReportGardenBed();
            }

            foreach (var item in BildingFarm)
            {
                item.ReportBildings();
            }
        }

        /// <summary>
        /// This Method calculate used area on farm.
        /// </summary>
        /// <returns>usedAreaOnFarm.</returns>
        private int UsedAreaOnFarm()
        {
            int usedAreaOnFarm = 0;
            foreach (var item in GardenBedFarm)
            {
                usedAreaOnFarm += item.Square;
            }

            foreach (var item in BildingFarm)
            {
                usedAreaOnFarm += item.AriaOfBilding;
            }

            return usedAreaOnFarm;
        }

        /// <summary>
        /// This Method add build on farm.
        /// </summary>
        public void AddBildOnFarm()
        {
            Console.WriteLine("Enter name building");
            string nameBuilding = Console.ReadLine();
            Console.WriteLine("Enter area of seat");
            int ariaOfBuilding = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter capacity");
            int conteints = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter name animal");
            string nameAnimal = Console.ReadLine();
            Console.WriteLine("Enter name product of animal");
            string nameProdukt = Console.ReadLine();
            Console.WriteLine("Enter mass of product");
            int massProduct = int.Parse(Console.ReadLine());
            ProduktOfAnimal produkt = new ProduktOfAnimal(nameProdukt, massProduct);
            Animals animal = new Animals(nameAnimal, produkt);
            if (UsedAreaOnFarm() + ariaOfBuilding < Area)
            {
                Bilding build = new Bilding(nameBuilding, ariaOfBuilding, conteints, animal);
                BildingFarm.Add(build);
                Console.WriteLine("Mew Building add");
            }
            else
            {
                Console.WriteLine("Sorry Area busy.");
            }
        }

        /// <summary>
        /// Method add Animal To Build.
        /// </summary>
        public void AddAnimalToBild()
        {
            Console.WriteLine("Please choose in what build do you wont add animal");
            for (int i = 0; i < BildingFarm.Count; i++)
            {
                Console.WriteLine($"{i} - {BildingFarm[i].NameBilding}");
            }

            int building;
            while (!int.TryParse(Console.ReadLine(), out building) || building < 0 || building >= BildingFarm.Count)
            {
                Console.WriteLine("Please enter correctly data");
            }

            BildingFarm[building].AddAnimalToTheBild();
        }

        /// <summary>
        /// Method add Plants to bed.
        /// </summary>
        public void AddPlantsToBed()
        {
            Console.WriteLine("Please choose in what Garden bed do you wont add plants");
            for (int i = 0; i < GardenBedFarm.Count; i++)
            {
                Console.WriteLine($"{i} - Garden Bed");
            }

            int bed;
            while (!int.TryParse(Console.ReadLine(), out bed) || bed < 0 || bed >= GardenBedFarm.Count)
            {
                Console.WriteLine("Please enter correctly data");
            }

            GardenBedFarm[bed].AddPlantsToThebed();
        }

        /// <summary>
        /// This Method add bad on farm.
        /// </summary>
        public void AddBadOnFarm()
        {
            Console.WriteLine("Enter Square garden bed");
            int square = int.Parse(Console.ReadLine());

            if (UsedAreaOnFarm() + square < Area)
            {
                GardenBed bed = new GardenBed(square);
                GardenBedFarm.Add(bed);
                Console.WriteLine("Mew Garden bed add");
            }
            else
            {
                Console.WriteLine("Sorry Area busy.");
            }
        }

        /// <summary>
        /// Method add product on stock.
        /// </summary>
        /// <param name="stock"></param>
        public void SmenaSezona(Stock stock)
        {
            foreach (var item in BildingFarm)
            {
                item.ProductonStock(stock);
            }
        }

        /// <summary>
        /// Method check season and add plants.
        /// </summary>
        /// <param name="month"></param>
        public void ChekSeason(int month)
        {
            foreach (var bed in GardenBedFarm)
            {
                foreach (var plant in bed.PlantsBed)
                {
                    if (plant.SeasonGather == month)
                    {
                        StockInCountry.AddFruit(plant.NamePlant);
                    }
                }
            }
        }
    }
}
