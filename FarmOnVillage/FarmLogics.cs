// <copyright file="Farm.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FarmOnVillage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using Farm.Data;

    /// <summary>
    /// Class that contains Farm.
    /// </summary>
    public static class FarmLogics
    {



        internal static void SaveChanges(Farm farm)
        {
            using (var context = new FarmContext())
            {
                var farmDb = context.Farms.FirstOrDefault(x => x.FarmId == farm.FarmId);
                if (farmDb.Area != farm.Area)
                    farmDb.Area = farm.Area;
                if (farmDb?.BuildingFarm != farm.BuildingFarm)
                    farmDb.BuildingFarm = farm.BuildingFarm;
                if (farmDb?.GardenBedFarm != farm.GardenBedFarm)
                    farmDb.GardenBedFarm = farm.GardenBedFarm;
                if (farmDb.Money != farm.Money)
                    farmDb.Money = farm.Money;
                if (farmDb?.RawMaterialOnFarm != farm.RawMaterialOnFarm)
                    farmDb.RawMaterialOnFarm = farm.RawMaterialOnFarm;
                if (farmDb?.StockInCountry != farm.StockInCountry)
                    farmDb.StockInCountry = farm.StockInCountry;

                context.SaveChanges();
            }
        }

        /// <summary>
        /// Used Area Farm.
        /// </summary>
        /// <param name="farm"></param>
        /// <returns></returns>
        private static int UsedAreaFarm(Farm farm)
        {
            int usedAreaFarm = 0;
            foreach (var item in farm.GardenBedFarm)
            {
                usedAreaFarm += item.Square;
            }

            foreach (var item in farm.BuildingFarm)
            {
                usedAreaFarm += item.AriaOfBuilding;
            }

            return usedAreaFarm;
        }

        /// <summary>
        /// Console write report of Farm.
        /// </summary>
        public static void ReportFarm(Farm farm)
        {
            Console.WriteLine($"\n\nThis is the farm {farm.NameFarm}, area {farm.Area}, " +
                $"{farm.BuildingFarm.Count} building and {farm.GardenBedFarm.Count} Garden Beds, " +
                $"Percent used area: {UsedAreaFarm(farm) * 100 / farm.Area}%");
            foreach (var item in farm.GardenBedFarm)
            {
                GardenBedLogics.ReportGardenBed(item);
            }

            foreach (var item in farm.BuildingFarm)
            {
                BuildingLogics.ReportBuildings(item);
            }
        }

        /// <summary>
        /// This Method calculate used area on farm.
        /// </summary>
        /// <returns>usedAreaOnFarm.</returns>
        private static int UsedAreaOnFarm(Farm farm)
        {
            int usedAreaOnFarm = 0;
            foreach (var item in farm.GardenBedFarm)
            {
                usedAreaOnFarm += item.Square;
            }

            foreach (var item in farm.BuildingFarm)
            {
                usedAreaOnFarm += item.AriaOfBuilding;
            }

            return usedAreaOnFarm;
        }

        /// <summary>
        /// This Method add build on farm.
        /// </summary>
        public static void AddBildOnFarm(Farm farm)
        {
            if (farm.Money < 500)
            {
                Console.WriteLine("\t Sorry you mast have 500$");
                return;
            }

            Console.WriteLine("\t Enter name building");
            string nameBuilding = Console.ReadLine();
            Console.WriteLine("\t Enter area of seat");
            int ariaOfBuilding = int.Parse(Console.ReadLine());
            Console.WriteLine("\t Enter capacity");
            int conteints = int.Parse(Console.ReadLine());

            if (UsedAreaOnFarm(farm) + ariaOfBuilding < farm.Area)
            {
                Building build = new Building()
                {
                    NameBuilding = nameBuilding,
                    AriaOfBuilding = ariaOfBuilding,
                    ContentAnimals = conteints
                };
                farm.BuildingFarm.Add(build);
                farm.Money -= 500;
                SaveChanges(farm);
                Console.WriteLine("\t Mew Building added");
            }
            else
            {
                Console.WriteLine("\t Sorry Area busy. You must buy more land.");
            }
        }

        /// <summary>
        /// This Method add bad on farm.
        /// </summary>
        public static void AddBadOnFarm(Farm farm)
        {
            Console.WriteLine("\t Enter Square garden bed");
            int square = int.Parse(Console.ReadLine());

            if (UsedAreaOnFarm(farm) + square < farm.Area)
            {
                GardenBed bed = new GardenBed()
                {
                    Square = square
                };

                farm.GardenBedFarm.Add(bed);
                Console.WriteLine("\t Mew Garden bed add");
                SaveChanges(farm);
            }
            else
            {
                Console.WriteLine("\t Sorry Area busy.");
            }
        }

        /// <summary>
        /// Method add product on stock.
        /// </summary>
        /// <param name="stock"></param>
        public static void SmenaSezona(Farm farm)
        {
            foreach (var item in farm.BuildingFarm)
            {
                BuildingLogics.ProductonStock(item, farm.StockInCountry);
            }
           // SaveChanges(farm);
        }

        /// <summary>
        /// Method check season and add plants.
        /// </summary>
        /// <param name="month"></param>
        public static void ChekSeason(Farm farm, int month)
        {
            foreach (var bed in farm.GardenBedFarm)
            {
                for (int i = 0; i < bed.PlantsBed.Count; i++)
                {
                    if (bed.PlantsBed[i].SeasonGather == month)
                    {
                        StockLogics.AddFruit(farm.StockInCountry, bed.PlantsBed[i]);
                        bed.PlantsBed[i].IsMultyHarvest = false;
                        bed.PlantsBed.Remove(bed.PlantsBed[i]);
                        SaveChanges(farm);
                    }
                }
            }
        }

        /// <summary>
        /// Method buy land.
        /// </summary>
        public static void BuyLand(Farm farm)
        {
            int temp;
            do
            {
                Console.WriteLine("\n\n\t Haw many land you want to buy?");
            }
            while (!int.TryParse(Console.ReadLine(), out temp));

            farm.Area += temp;
            farm.Money -= temp * 10;
            SaveChanges(farm);
        }

        /// <summary>
        /// Method Purchases.
        /// </summary>
        public static void Purchases(Farm farm)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n\t What will you want to buy?\n" +
                              "\t 1 - Animals\n" +
                              "\t 2 - Seeds\n");

            string choose = Console.ReadLine();

            if (choose == "1")
            {
                Console.WriteLine("\n\n\t Please choose animal");
                for (int i = 0; i < farm.MarketForFarm.AnimalsToBuy.Count; i++)
                {
                    Console.WriteLine($"\t{i + 1} - {farm.MarketForFarm.AnimalsToBuy[i].NameAnimal}");
                }

                int temp;
                while (!int.TryParse(Console.ReadLine(), out temp) 
                    || temp - 1 < 0 
                    || temp - 1 >= farm.MarketForFarm.AnimalsToBuy.Count)
                {
                    Console.WriteLine("\t Please enter correctly data");
                }

                BuySomething(farm, farm.MarketForFarm.AnimalsToBuy[temp - 1]);
            }
            else if (choose == "2")
            {
                Console.WriteLine("\n\n\t Please choose seeds");
                for (int i = 0; i < farm.MarketForFarm.SeedsToBuy.Count; i++)
                {
                    Console.WriteLine($"\t{i + 1} - {farm.MarketForFarm.SeedsToBuy[i].PlantsSeed}");
                }

                int temp;
                while (!int.TryParse(Console.ReadLine(), out temp) 
                    || temp - 1 < 0 
                    || temp - 1 >= farm.MarketForFarm.SeedsToBuy.Count)
                {
                    Console.WriteLine("\t Please enter correctly data");
                }

                BuySomething(farm, farm.MarketForFarm.SeedsToBuy[temp - 1]);
            }
            else
            {
                Console.WriteLine("\t Sorry we don't have it.");
            }
        }

        /// <summary>
        /// Method BuySomething.
        /// </summary>
        /// <param name="anim"></param>
        public static void BuySomething(Farm farm, Animal anim)
        {
            if (farm.Money > anim.Price)
            {
                Animal newAnim = new Animal()
                {
                    NameAnimal = anim.NameAnimal,
                    ProduktAnimal = new ProduktOfAnimal()
                    {
                        NameProduktOfAnimal = anim.ProduktAnimal.NameProduktOfAnimal,
                        Mass = anim.ProduktAnimal.Mass,
                        Price = anim.ProduktAnimal.Price
                    },
                    Price = anim.Price
                }
                    ;
                farm.RawMaterialOnFarm.AnimalsFree.Add(newAnim);
                farm.Money -= anim.Price;
                SaveChanges(farm);
            }
            else
            {
                Console.WriteLine("\n\t Sorry you don't have money.");
            }
        }

        /// <summary>
        /// Method BuySomething.
        /// </summary>
        /// <param name="seed"></param>
        public static void BuySomething(Farm farm, Seed seed)
        {
            if (farm.Money > seed.Price)
            {
                Plant newPlant = new Plant()
                {
                    NamePlant = seed.PlantsSeed,
                    SeasonSeat = seed.SeasonSeat,
                    SeasonGather = seed.SeasonSeat + 3,
                    AriaOfSeat = 10,
                    Harvest = 6
                };
                farm.RawMaterialOnFarm.PlantsFree.Add(newPlant);
                farm.Money -= seed.Price;
                SaveChanges(farm);
            }
            else
            {
                Console.WriteLine("\t Sorry you don't have money.");
            }
        }



        /// <summary>
        /// Method ChecfreeGardenBed.
        /// </summary>
        /// <param name="bed"></param>
        public static void ChecfreeGardenBed(Farm farm, GardenBed bed)
        {
            if (farm.RawMaterialOnFarm.PlantsFree.Count == 0)
            {
                Console.WriteLine("\n\t Please buy Plants");
                return;
            }

            Console.WriteLine("\nChoose what Plants do you want to add");
            for (int i = 0; i < farm.RawMaterialOnFarm.PlantsFree.Count; i++)
            {
                Console.WriteLine($"\t {i} - {farm.RawMaterialOnFarm.PlantsFree[i].NamePlant}");
            }

            int temp;
            while (!int.TryParse(Console.ReadLine(), out temp) 
                || temp < 0 
                || temp >= farm.RawMaterialOnFarm.PlantsFree.Count)
            {
                Console.WriteLine("\n\t Please enter correctly data");
            }

            if (GardenBedLogics.ChekFreeBed(bed, farm.RawMaterialOnFarm.PlantsFree[temp]))
            {
                bed.PlantsBed.Add(farm.RawMaterialOnFarm.PlantsFree[temp]);
                Console.WriteLine("\n\t Mew Plant added");
                farm.RawMaterialOnFarm.PlantsFree.RemoveAt(temp);
                SaveChanges(farm);
            }
            else
            {
                Console.WriteLine("\n\t Sorry Square is busy");
            }
        }

        /// <summary>
        /// Method sales.
        /// </summary>
        public static void Sales(Farm farm)
        {
            if (farm.StockInCountry == null)
            {
                Console.WriteLine("\t Stock empty");
                return;
            }

            int temp = (farm.StockInCountry.ProduktsOfAnimal.Count * 10) + (farm.StockInCountry.Plants.Count * 5);
            farm.Money += temp;
            farm.StockInCountry.ProduktsOfAnimal.Clear();
            farm.StockInCountry.Plants.Clear();
            Console.WriteLine($"\t You earned {temp}$");
            SaveChanges(farm);
        }
    }
}
