// <copyright file="Bilding.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FarmOnVillage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Farm.Data;
    using Microsoft.EntityFrameworkCore;

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
            Console.Write($"\nThis is the {building.NameBuilding} square equals {building.AriaOfBuilding} contains {building.ContentAnimals} animal: ");
            foreach (var animal in building.AnimalsOnBild)
            {
                Console.Write($"\n{animal.NameAnimal} ");
            }

            Console.WriteLine($"percentage of occupancy {building.AnimalsOnBild.Count * 100 / building.ContentAnimals}%\n");
        }

        /// <summary>
        ///  Method add product on stock.
        /// </summary>
        /// <param name="stock"></param>
        public static void ProductonStock(Building building, Stock stock)
        {
            Console.Clear();
            foreach (var item in building.AnimalsOnBild)
            {                
                StockLogics.AddProduct(stock, item.ProduktAnimal);
                Console.WriteLine($"\t {item.NameAnimal} gave {item.ProduktAnimal.NameProduktOfAnimal} {1}kg");
            }
        }

        /// <summary>
        /// Method add Animal To Build.
        /// </summary>
        public static void AddAnimalToBild(Farm farm)
        {
            if (farm.BuildingFarm.Count == 0)
            {
                Console.WriteLine("\n\t There are no buildings on the farm");
                return;
            }

            Console.WriteLine("\n\t Please choose in what build do you wont add animal");
            for (int i = 0; i < farm.BuildingFarm.Count; i++)
            {
                Console.WriteLine($"\t{i + 1} - {farm.BuildingFarm[i].NameBuilding}");
            }

            int building;
            while (!int.TryParse(Console.ReadLine(), out building) || building - 1 < 0 || building - 1 >= farm.BuildingFarm.Count)
            {
                Console.WriteLine("\n\t Please enter correctly data");
            }

            ChecfreeAnimal(farm, farm.BuildingFarm[building - 1]);
        }

        /// <summary>
        /// This Method add animals to build.
        /// </summary>
        /// <param name="bilding"></param>
        public static void ChecfreeAnimal(Farm farm, Building bilding)
        {
            if (farm.RawMaterialOnFarm.AnimalsFree.Count == 0)
            {
                Console.WriteLine("\n\t Please buy Animals");
                return;
            }

            Console.WriteLine("\nChoose what Animals do you want to add");
            foreach (var item in farm.RawMaterialOnFarm.AnimalsFree)
            {
                Console.WriteLine($"\t {item.AnimalId} - {item.NameAnimal}");
            }

            int temp;
            while (!int.TryParse(Console.ReadLine(), out temp)
                || farm.RawMaterialOnFarm.AnimalsFree.Select(x => x.AnimalId).Min(x => x) < 0
                || temp > farm.RawMaterialOnFarm.AnimalsFree.Select(x => x.AnimalId).Max(x => x))
            {
                Console.WriteLine("\n\t Please enter correctly data");
            }

            var animal = farm.RawMaterialOnFarm
                                .AnimalsFree
                                .FirstOrDefault(x => x.AnimalId == temp);

            Animal anim = new Animal()
            {
                NameAnimal = animal.NameAnimal,
                Price = animal.Price,
                TimeBetweenHarvests = animal.TimeBetweenHarvests,
                ProduktAnimal = animal.ProduktAnimal
            };


            if (bilding.AnimalsOnBild.Count + 1 < bilding.ContentAnimals)
            {
                bilding.AnimalsOnBild
                       .Add(anim);

                SaveAnimalInBd(farm, bilding, anim);

                farm.RawMaterialOnFarm
                    .AnimalsFree
                    .Remove(animal);
                RawMaterialLogics.DeleteRawFaterialFromBd(farm, animal);



                Console.WriteLine("\n\t New animals added");
            }
            else
            {
                Console.WriteLine("\n\t Sorry Square is busy");
            }
        }

        private static void SaveAnimalInBd(Farm farm, Building build, Animal animal)
        {
            using (var context = new FarmContext())
            {


                context.Farms.Attach(farm);
                context.Entry(farm
                    .BuildingFarm
                    .First(b => b.BuildingId == build.BuildingId)
                    .AnimalsOnBild
                    .First(a => a.AnimalId == animal.AnimalId))
                    .State = EntityState.Added;

                context.SaveChanges();
            }
        }
    }
}
