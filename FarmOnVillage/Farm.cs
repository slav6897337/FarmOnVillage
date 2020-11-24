// <copyright file="Farm.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FarmOnVillage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Class that contains Farm.
    /// </summary>
    public class Farm
    {
        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        public int FarmId { get; set; }

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
        public List<GardenBed> GardenBedFarm { get; set; } = new List<GardenBed>();

        /// <summary>
        /// Gets or sets property BildingFarm.
        /// </summary>
        public List<Bilding> BildingFarm { get; set; } = new List<Bilding>();

        /// <summary>
        /// Gets or sets property Stock.
        /// </summary>
        public Stock StockInCountry { get; set; }

        /// <summary>
        /// Gets or sets property your money.
        /// </summary>
        public decimal Money { get; set; }

        /// <summary>
        /// Gets or sets property your MarketForFarm.
        /// </summary>
        public Market MarketForFarm { get; set; }

        /// <summary>
        /// Gets or sets RawMaterialOnFarm.
        /// </summary>
        public RawMaterial RawMaterialOnFarm { get; set; }

        internal void SaveChanges()
        {
            using (var context = new FarmContext())
            {
                var farmDb = context.Farms.FirstOrDefault(x => x.FarmId == FarmId);
                if (farmDb.Area != Area)
                    farmDb.Area = Area;
                if (farmDb?.BildingFarm != BildingFarm)
                    farmDb.BildingFarm = BildingFarm;
                if (farmDb?.GardenBedFarm != GardenBedFarm)
                    farmDb.GardenBedFarm = GardenBedFarm;
                if (farmDb.Money != Money)
                    farmDb.Money = Money;
                if (farmDb?.RawMaterialOnFarm != RawMaterialOnFarm)
                    farmDb.RawMaterialOnFarm = RawMaterialOnFarm;
                if (farmDb?.StockInCountry != StockInCountry)
                    farmDb.StockInCountry = StockInCountry;

                context.SaveChanges();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Farm"/> class.
        /// </summary>
        public Farm()
        {
        }

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
            if (Money < 500)
            {
                Console.WriteLine("Sorry you mast have 500$");
                return;
            }

            Console.WriteLine("Enter name building");
            string nameBuilding = Console.ReadLine();
            Console.WriteLine("Enter area of seat");
            int ariaOfBuilding = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter capacity");
            int conteints = int.Parse(Console.ReadLine());

            if (UsedAreaOnFarm() + ariaOfBuilding < Area)
            {
                Bilding build = new Bilding(nameBuilding, ariaOfBuilding, conteints);
                BildingFarm.Add(build);
                Money -= 500;
                SaveChanges();
                Console.WriteLine("Mew Building added");
            }
            else
            {
                Console.WriteLine("Sorry Area busy. You must buy more land.");
            }
        }

        /// <summary>
        /// Method add Animal To Build.
        /// </summary>
        public void AddAnimalToBild()
        {
            if (BildingFarm.Count == 0)
            {
                Console.WriteLine("There are no buildings on the farm");
                return;
            }

            Console.WriteLine("Please choose in what build do you wont add animal");
            for (int i = 0; i < BildingFarm.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {BildingFarm[i].NameBilding}");
            }

            int building;
            while (!int.TryParse(Console.ReadLine(), out building) || building - 1 < 0 || building - 1 >= BildingFarm.Count)
            {
                Console.WriteLine("Please enter correctly data");
            }

            ChecfreeAnimal(BildingFarm[building - 1]);
        }

        /// <summary>
        /// Method add Plants to bed.
        /// </summary>
        public void AddPlantsToBed()
        {
            if (GardenBedFarm.Count == 0)
            {
                Console.WriteLine("There are no Garden bed on the farm");
                return;
            }

            Console.WriteLine("Please choose in what Garden bed do you wont add plants");
            for (int i = 0; i < GardenBedFarm.Count; i++)
            {
                Console.WriteLine($"{i + 1} - Garden Bed");
            }

            int bed;
            while (!int.TryParse(Console.ReadLine(), out bed) || bed - 1 < 0 || bed - 1 >= GardenBedFarm.Count)
            {
                Console.WriteLine("Please enter correctly data");
            }

            ChecfreeGardenBed(GardenBedFarm[bed - 1]);
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
                SaveChanges();
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
        public void SmenaSezona()
        {
            foreach (var item in BildingFarm)
            {
                item.ProductonStock(StockInCountry);
            }
            SaveChanges();
        }

        /// <summary>
        /// Method check season and add plants.
        /// </summary>
        /// <param name="month"></param>
        public void ChekSeason(int month)
        {
            foreach (var bed in GardenBedFarm)
            {
                for (int i = 0; i < bed.PlantsBed.Count; i++)
                {
                    if (bed.PlantsBed[i].SeasonGather == month)
                    {
                        StockInCountry.AddFruit(bed.PlantsBed[i]);
                        bed.PlantsBed[i].IsMultyHarvest = false;
                        bed.PlantsBed.Remove(bed.PlantsBed[i]);
                        SaveChanges();                        
                    }
                }
            }
        }

        /// <summary>
        /// Method buy land.
        /// </summary>
        public void BuyLand()
        {
            Console.WriteLine("Haw many land you want to buy?");

            int temp = int.Parse(Console.ReadLine());
            Area += temp;
            Money -= temp * 10;
            SaveChanges();
        }

        /// <summary>
        /// Method Purchases.
        /// </summary>
        public void Purchases()
        {
            Console.WriteLine("What will you want buy? 1 - Animals, 2 - Seeds");

            string choose = Console.ReadLine();

            if (choose == "1")
            {
                Console.WriteLine("Please choose animal");
                for (int i = 0; i < MarketForFarm.AnimalsToBuy.Count; i++)
                {
                    Console.WriteLine($"{i + 1} - {MarketForFarm.AnimalsToBuy[i].NameAnimal}");
                }

                int temp;
                while (!int.TryParse(Console.ReadLine(), out temp) || temp - 1 < 0 || temp - 1 >= MarketForFarm.AnimalsToBuy.Count)
                {
                    Console.WriteLine("Please enter correctly data");
                }

                BuySomething(MarketForFarm.AnimalsToBuy[temp - 1]);
            }
            else if (choose == "2")
            {
                Console.WriteLine("Please choose seeds");
                for (int i = 0; i < MarketForFarm.SeedsToBuy.Count; i++)
                {
                    Console.WriteLine($"{i + 1} - {MarketForFarm.SeedsToBuy[i].PlantsSeed}");
                }

                int temp;
                while (!int.TryParse(Console.ReadLine(), out temp) || temp - 1 < 0 || temp - 1 >= MarketForFarm.SeedsToBuy.Count)
                {
                    Console.WriteLine("Please enter correctly data");
                }

                BuySomething(MarketForFarm.SeedsToBuy[temp - 1]);
            }
            else
            {
                Console.WriteLine("Sorry we don't have it.");
            }
        }

        /// <summary>
        /// Method BuySomething.
        /// </summary>
        /// <param name="anim"></param>
        public void BuySomething(Animal anim)
        {
            if (Money > anim.Price)
            {
                Animal newAnim = new Animal(anim.NameAnimal, anim.ProduktAnimal, anim.Price);
                RawMaterialOnFarm.AnimalsFree.Add(newAnim);
                Money -= anim.Price;
                SaveChanges();
            }
            else
            {
                Console.WriteLine("Sorry you don't have money.");
            }
        }

        /// <summary>
        /// Method BuySomething.
        /// </summary>
        /// <param name="seed"></param>
        public void BuySomething(Seed seed)
        {
            if (Money > seed.Price)
            {
                Plant newPlant = new Plant(seed.PlantsSeed, seed.SeasonSeat, seed.SeasonSeat + 3, 10);
                RawMaterialOnFarm.PlantsFree.Add(newPlant);
                Money -= seed.Price;
                SaveChanges();
            }
            else
            {
                Console.WriteLine("Sorry you don't have money.");
            }
        }

        /// <summary>
        /// This Method add animals to build.
        /// </summary>
        /// <param name="bilding"></param>
        public void ChecfreeAnimal(Bilding bilding)
        {
            if (RawMaterialOnFarm.AnimalsFree.Count == 0)
            {
                Console.WriteLine("Please buy Animals");
                return;
            }

            Console.WriteLine("Choose what Animals do you want to add");
            for (int i = 0; i < RawMaterialOnFarm.AnimalsFree.Count; i++)
            {
                Console.WriteLine($"  {i} - {RawMaterialOnFarm.AnimalsFree[i].NameAnimal}");
            }

            int temp;
            while (!int.TryParse(Console.ReadLine(), out temp) || temp < 0 || temp >= RawMaterialOnFarm.AnimalsFree.Count)
            {
                Console.WriteLine("Please enter correctly data");
            }

            if (bilding.AnimalsOnBild.Count + 1 < bilding.ContentAnimals)
            {
                bilding.AnimalsOnBild.Add(RawMaterialOnFarm.AnimalsFree[temp]);
                RawMaterialOnFarm.AnimalsFree.RemoveAt(temp);
                SaveChanges();
                Console.WriteLine("New animals added");
            }
            else
            {
                Console.WriteLine("Sorry Square is busy");
            }
        }

        /// <summary>
        /// Method ChecfreeGardenBed.
        /// </summary>
        /// <param name="bed"></param>
        public void ChecfreeGardenBed(GardenBed bed)
        {
            if (RawMaterialOnFarm.PlantsFree.Count == 0)
            {
                Console.WriteLine("Please buy Plants");
                return;
            }

            Console.WriteLine("Choose what Plants do you want to add");
            for (int i = 0; i < RawMaterialOnFarm.PlantsFree.Count; i++)
            {
                Console.WriteLine($"  {i} - {RawMaterialOnFarm.PlantsFree[i].NamePlant}");
            }

            int temp;
            while (!int.TryParse(Console.ReadLine(), out temp) || temp < 0 || temp >= RawMaterialOnFarm.PlantsFree.Count)
            {
                Console.WriteLine("Please enter correctly data");
            }

            if (bed.ChekFreeBed(RawMaterialOnFarm.PlantsFree[temp]))
            {
                bed.PlantsBed.Add(RawMaterialOnFarm.PlantsFree[temp]);
                Console.WriteLine("Mew Plant added");
                RawMaterialOnFarm.PlantsFree.RemoveAt(temp);
                SaveChanges();
            }
            else
            {
                Console.WriteLine("Sorry Square is busy");
            }
        }

        /// <summary>
        /// Method sales.
        /// </summary>
        public void Sales()
        {
            if (StockInCountry == null)
            {
                Console.WriteLine("Stock empty");
                return;
            }
                
            int temp = (StockInCountry.ProduktsOfAnimal.Count * 10) + (StockInCountry.Plants.Count * 5);
            Money += temp;
            StockInCountry.ProduktsOfAnimal.Clear();
            StockInCountry.Plants.Clear();
            Console.WriteLine($"You earned {temp}$");
            SaveChanges();
        }
    }
}
