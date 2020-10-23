// <copyright file="Game.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FarmOnVillage
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Class Game.
    /// </summary>
    public static class Game
    {
        /// <summary>
        /// Method Start Game.
        /// </summary>
        public static void StartGame()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Farm farm = new Farm();
            Market bigMarket = new Market();
            Stock stoc = new Stock();
            RawMaterial rawMaterial = new RawMaterial();
            farm.MarketForFarm = bigMarket;
            farm.StockInCountry = stoc;
            farm.RawMaterialOnFarm = rawMaterial;
            InterfeisOne(farm, stoc, bigMarket);
        }

        /// <summary>
        /// Method Interface.
        /// </summary>
        /// <param name="farm"></param>
        /// <param name="stock"></param>
        /// <param name="market"></param>
        public static void InterfeisOne(Farm farm, Stock stock, Market market)
        {
            bool game = true;
            byte manth = 1;

            while (game)
            {
                Console.WriteLine(" 1 - Report of Farm\n 2 - Purchases\n 3 - Report of Raw Material\n 4 - Report of Stock\n 5 - Farm management\n 6 - Money\n 7 - Sales\n Q - quit.");

                switch (Console.ReadLine())
                {
                    case "1":
                        farm.ReportFarm();
                        break;
                    case "2":
                        farm.Purchases();
                        break;
                    case "3":
                        farm.RawMaterialOnFarm.ReportRawMaterial();
                        break;
                    case "4":
                        stock.ReporStock();
                        break;
                    case "5":
                        FarmManagement(farm, stock, market);
                        break;
                    case "6":
                        Console.WriteLine($"You have {farm.Money}$");
                        break;
                    case "7":
                        farm.Sales();
                        break;
                    case "q":
                        game = false;
                        break;
                    default:
                        manth++;
                        if (manth > 12)
                        {
                            manth = 1;
                        }

                        farm.SmenaSezona(stock);
                        farm.ChekSeason(manth);
                        break;
                }
            }
        }

        /// <summary>
        /// Method Farm Management.
        /// </summary>
        /// <param name="farm"></param>
        /// <param name="stock"></param>
        /// <param name="market"></param>
        public static void FarmManagement(Farm farm, Stock stock, Market market)
        {
            Console.WriteLine(" 1 - Add Animal in building\n 2 - Plant seeds\n 3 - Realty");

            switch (Console.ReadLine())
            {
                case "1":
                    farm.AddAnimalToBild();
                    break;
                case "2":
                    farm.AddPlantsToBed();
                    break;
                case "3":
                    Realty(farm);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Method Realty.
        /// </summary>
        /// <param name="farm"></param>
        public static void Realty(Farm farm)
        {
            Console.WriteLine(" 1 - Buy land \n 2 - Add garden bed\n 3 - Add building");

            switch (Console.ReadLine())
            {
                case "1":
                    farm.BuyLand();
                    break;
                case "2":
                    farm.AddBadOnFarm();
                    break;
                case "3":
                    farm.AddBildOnFarm();
                    break;
                default:
                    break;
            }
        }
    }
}
