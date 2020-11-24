// <copyright file="Bilding.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FarmOnVillage
{
    using System;
    using System.Collections.Generic;
    using Farm.Data;

    /// <summary>
    /// class Building.
    /// </summary>
    public static class BuildingLogics
    {
        /// <summary>
        /// Console write report of garden Bed.
        /// </summary>
        public static void ReportBuildings(Building building)
        {
            Console.Write($"This is the {building.NameBuilding} square equals {building.AriaOfBuilding} contains {building.ContentAnimals} animal: ");
            foreach (var animal in building.AnimalsOnBild)
            {
                Console.Write($"{animal.NameAnimal} ");
            }

            Console.WriteLine($"percentage of occupancy {building.AnimalsOnBild.Count * 100 / building.ContentAnimals}%\n");
        }

        /// <summary>
        ///  Method add product on stock.
        /// </summary>
        /// <param name="stock"></param>
        public static void ProductonStock(Building building, Stock stock)
        {
            foreach (var item in building.AnimalsOnBild)
            {
                StockLogics.AddProduct(stock, item.ProduktAnimal);
                Console.WriteLine($"{item.NameAnimal} gave {item.ProduktAnimal.NameProduktOfAnimal} {1}kg");
            }
        }

        /// <summary>
        /// Method add Animal To Build.
        /// </summary>
        public static void AddAnimalToBild(Farm farm)
        {
            if (farm.BuildingFarm.Count == 0)
            {
                Console.WriteLine("There are no buildings on the farm");
                return;
            }

            Console.WriteLine("Please choose in what build do you wont add animal");
            for (int i = 0; i < farm.BuildingFarm.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {farm.BuildingFarm[i].NameBuilding}");
            }

            int building;
            while (!int.TryParse(Console.ReadLine(), out building) || building - 1 < 0 || building - 1 >= farm.BuildingFarm.Count)
            {
                Console.WriteLine("Please enter correctly data");
            }

            FarmLogics.ChecfreeAnimal(farm, farm.BuildingFarm[building - 1]);
        }
    }
}
