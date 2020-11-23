// <copyright file="DatabaseFarm.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FarmOnVillage
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Linq;

    /// <summary>
    /// Work with database.
    /// </summary>
    internal static class DatabaseFarm
    {
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
        internal static void AddSeed()
        {
            System.Console.WriteLine("Please enter Name seed");
            string nameSeed = System.Console.ReadLine();

            int seasonSeat;
            do
            {
                System.Console.WriteLine("Please enter SeasonSeat");
            }
            while (!int.TryParse(System.Console.ReadLine(), out seasonSeat) && seasonSeat < 1 && seasonSeat > 12);

            decimal price;
            do
            {
                System.Console.WriteLine("Please enter price");
            }
            while (!decimal.TryParse(System.Console.ReadLine(), out price));

            var seed = new Seed(nameSeed, seasonSeat, price);

            using (var context = new FarmContext())
            {
                context.Seeds.Add(seed);
                var addSeatInMarcet = context.Markets.FirstOrDefault();
                addSeatInMarcet.SeedsToBuy.Add(seed);
                context.SaveChanges();
            }
        }



        internal static void ShowTableMarket()
        {
            using (var context = new FarmContext())
            {
                var tx = 

                foreach (var item in tx)
                {
                    Console.WriteLine(item);
                }

            }
        }
    }
}
/*new Seed("Overnight", 5, 70);
ProduktOfAnimal milk = new ProduktOfAnimal("Milk", 10);
Animal cow = new Animal("Cow", milk, 150);*/