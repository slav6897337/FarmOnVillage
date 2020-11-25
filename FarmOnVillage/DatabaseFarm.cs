// <copyright file="DatabaseFarm.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FarmOnVillage
{
    using System;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using Farm.Data;

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

                farm = farmContext.Where(f => f.FarmId == farmId)
                              .Include(m => m.MarketForFarm)
                              .Include(a => a.MarketForFarm.AnimalsToBuy)
                              .ThenInclude(p => p.ProduktAnimal)
                              .Include(s => s.MarketForFarm.SeedsToBuy)
                              .Include(s => s.StockInCountry)
                              .Include(p => p.StockInCountry.ProduktsOfAnimal)
                              .Include(s => s.StockInCountry.Plants)
                              .Include(r => r.RawMaterialOnFarm)
                              .Include(r => r.RawMaterialOnFarm.AnimalsFree)
                              .ThenInclude(p => p.ProduktAnimal)
                              .Include(r => r.RawMaterialOnFarm.PlantsFree)
                              .Include(g => g.GardenBedFarm)
                              .ThenInclude(p => p.PlantsBed)
                              .Include(b => b.BuildingFarm)
                              .ThenInclude(a => a.AnimalsOnBild)
                              .ThenInclude(p => p.ProduktAnimal)
                              .FirstOrDefault();


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

            var rawMaterial = new RawMaterial();

            Farm farm;

            using (var context = new FarmContext())
            {
                Market market = context.Markets
                                       .Include(x => x.AnimalsToBuy)
                                       .ThenInclude(x => x.ProduktAnimal)
                                       .Include(x => x.SeedsToBuy)                                        
                                       .FirstOrDefault();

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

            Seed seedExzemp = new Seed()
            { 
                PlantsSeed = "Apple",
                SeasonSeat = 5,
                Price = 50,
            };
            market.SeedsToBuy.Add(seedExzemp);
            seedExzemp = new Seed()
            {
                PlantsSeed = "Cucumber",
                SeasonSeat = 6,
                Price = 60,
            };
            market.SeedsToBuy.Add(seedExzemp);
            seedExzemp = new Seed()
            {
                PlantsSeed = "Tomato",
                SeasonSeat = 6,
                Price = 70,
            };
            market.SeedsToBuy.Add(seedExzemp);
            seedExzemp = new Seed()
            {
                PlantsSeed = "Strawberry",
                SeasonSeat = 5,
                Price = 50,
            };
            market.SeedsToBuy.Add(seedExzemp);
            seedExzemp = new Seed()
            {
                PlantsSeed = "Potatoes",
                SeasonSeat = 6,
                Price = 40,
            };
            market.SeedsToBuy.Add(seedExzemp);
            seedExzemp = new Seed()
            {
                PlantsSeed = "Overnight",
                SeasonSeat = 5,
                Price = 70,
            };
            market.SeedsToBuy.Add(seedExzemp);

            ProduktOfAnimal milk = new ProduktOfAnimal()
            {
                NameProduktOfAnimal = "Milk",
                Mass = 10,
                Price = 30,
            };
            ProduktOfAnimal meat = new ProduktOfAnimal()
            {
                NameProduktOfAnimal = "Meat",
                Mass = 100,
                Price = 100,
            };
            ProduktOfAnimal wool = new ProduktOfAnimal()
            {
                NameProduktOfAnimal = "Wool",
                Mass = 10,
                Price = 30,
            };
            ProduktOfAnimal egg = new ProduktOfAnimal()
            {
                NameProduktOfAnimal = "Egg",
                Mass = 30,
                Price = 30,
            };

            Animal cow = new Animal()
            {
                NameAnimal = "Cow",
                ProduktAnimal = milk,
                Price = 150,
                TimeBetweenHarvests = 48
            };
            Animal pig = new Animal()
            {
                NameAnimal = "Pig",
                ProduktAnimal = meat,
                Price = 100,
                TimeBetweenHarvests = 48
            };
            Animal sheep = new Animal()
            {
                NameAnimal = "Sheep",
                ProduktAnimal = wool,
                Price = 80,
                TimeBetweenHarvests = 48
            };
            Animal hen = new Animal()
            {
                NameAnimal = "Hen",
                ProduktAnimal = egg,
                Price = 60,
                TimeBetweenHarvests = 48
            };

            market.AnimalsToBuy.Add(cow);
            market.AnimalsToBuy.Add(pig);
            market.AnimalsToBuy.Add(sheep);
            market.AnimalsToBuy.Add(hen);            

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

            var seed = new Seed() 
            {
                PlantsSeed = nameSeed,
                SeasonSeat = seasonSeat,
                Price = price
            };

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

            decimal priceProduct;
            do
            {
                System.Console.WriteLine("Please enter price product");
            }
            while (!decimal.TryParse(System.Console.ReadLine(), out priceProduct));

            decimal priceAnimal;
            do
            {
                System.Console.WriteLine("Please enter price Animal");
            }
            while (!decimal.TryParse(System.Console.ReadLine(), out priceAnimal));

            var animal = new Animal()
            {
                NameAnimal = nameAnimal,
                Price = priceAnimal,
                ProduktAnimal = new ProduktOfAnimal()
                {
                    NameProduktOfAnimal = nameProductOfAnimal,
                    Mass = massProduct,
                    Price = priceProduct
                }
            };

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