// <copyright file="DatabaseFarm.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FarmOnVillage
{
    using System;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Work with database.
    /// </summary>
    internal static class DatabaseFarm
    {
        /// <summary>
        /// Choose Farm.
        /// </summary>
        /// <returns>FarmId.</returns>
        internal static Farm ChooseFarm()
        {
            Farm farm;

            using (var context = new FarmContext())
            {
                var farmContext = context.Farms;
                foreach (var item in farmContext)
                {
                    Console.WriteLine(item.FarmId
                        + " "
                        + item.NameFarm);
                }

                int farmId;
                do
                {
                    Console.WriteLine("Choose number of Farm");
                }
                while (!int.TryParse(Console.ReadLine(), out farmId)
                || !farmContext.Select(x => x.FarmId).Contains(farmId));

                farm = context.Farms
                              .Include(x => x.BildingFarm)
                              .Include(x => x.GardenBedFarm)
                              .Include(x => x.MarketForFarm)
                              .Include(x => x.RawMaterialOnFarm)
                              .Include(x => x.StockInCountry)
                              .Include(x => x.RawMaterialOnFarm.AnimalsFree)
                              .Include(x => x.RawMaterialOnFarm.PlantsFree)
                              .FirstOrDefault(x => x.FarmId == farmId);     

            }

            return farm;
        }

        /// <summary>
        /// Add new line in base.
        /// </summary>
        /// <returns>FarmId.</returns>
        internal static Farm CreateFarm()
        {
            Console.WriteLine("Please enter Name Farm");
            string nameFarm = System.Console.ReadLine();

            int area;
            do
            {
                Console.WriteLine("Please enter Area");
            }
            while (!int.TryParse(Console.ReadLine(), out area));

            decimal money;
            do
            {
                System.Console.WriteLine("Please enter Start Money");
            }
            while (!decimal.TryParse(Console.ReadLine(), out money));

            var stock = new Stock();

            var market = new Market();

            var rawMaterial = new RawMaterial();

            Farm farm;

            using (var context = new FarmContext())
            {
                context.Farms.Add(new Farm()
                {
                    NameFarm = nameFarm,
                    Area = area,
                    Money = money,
                    StockInCountry = stock,
                    MarketForFarm = market,
                    RawMaterialOnFarm = rawMaterial,
                });

                context.SaveChanges();

                farm = context.Farms.FirstOrDefault(x => x.NameFarm == nameFarm);
            }

            return farm;
        }

        /// <summary>
        /// Fill Market.
        /// </summary>
        internal static void FillTableMarket()
        {
            var market = new Market();
            using (var context = new FarmContext())
            {
                context.Markets.Add(market);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Add seed.
        /// </summary>
        internal static void AddSeedToMarket()
        {
            Console.WriteLine("Please enter Name seed");
            string nameSeed = Console.ReadLine();

            int seasonSeat;
            do
            {
                Console.WriteLine("Please enter SeasonSeat");
            }
            while (!int.TryParse(Console.ReadLine(), out seasonSeat) && seasonSeat < 1 && seasonSeat > 12);

            decimal price;
            do
            {
                System.Console.WriteLine("Please enter price");
            }
            while (!decimal.TryParse(Console.ReadLine(), out price));

            var seed = new Seed(nameSeed, seasonSeat, price);

            using (var context = new FarmContext())
            {
                context.Seeds.Add(seed);
                var addSeatInMarcet = context.Markets.FirstOrDefault();
                addSeatInMarcet.SeedsToBuy.Add(seed);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Shows products in the store.
        /// </summary>
        internal static void ShowTableMarket()
        {
            Console.WriteLine("Choose 1-Seeds 2-Animals");
            string keyChoose = Console.ReadLine();
            if (keyChoose != "1" || keyChoose != "2")
                return;

            using (var context = new FarmContext())
            {
                var market = context.Markets.FirstOrDefault();

                if (keyChoose == "1")
                {
                    foreach (var item in market.SeedsToBuy)
                    {
                        Console.WriteLine($"{0} Season seat:{1} price:{2}", item.PlantsSeed, item.SeasonSeat, item.Price);
                    }
                }

                if (keyChoose == "2")
                {
                    foreach (var item in market.AnimalsToBuy)
                    {
                        Console.WriteLine($"{0} Product:{1} price:{2}", item.NameAnimal, item.ProduktAnimal, item.Price);
                    }
                }
            }
        }

        /// <summary>
        /// Add Animal To Market.
        /// </summary>
        internal static void AddAnimalToMarket()
        {
            Console.WriteLine("Please enter Name Animal");
            string nameAnimal = System.Console.ReadLine();

            Console.WriteLine("Please enter Name Product of Animal");
            string nameProductOfAnimal = System.Console.ReadLine();

            int massProduct;
            do
            {
                System.Console.WriteLine("Please enter Mass product of animal");
            }
            while (!int.TryParse(System.Console.ReadLine(), out massProduct));

            decimal price;
            do
            {
                System.Console.WriteLine("Please enter price");
            }
            while (!decimal.TryParse(System.Console.ReadLine(), out price));

            var animal = new Animal(
                nameAnimal,
                new ProduktOfAnimal(nameProductOfAnimal, massProduct),
                price);

            using (var context = new FarmContext())
            {
                context.Animals.Add(animal);
                var addSeatInMarcet = context.Markets.FirstOrDefault();
                addSeatInMarcet.AnimalsToBuy.Add(animal);
                context.SaveChanges();
            }
        }
    }
}