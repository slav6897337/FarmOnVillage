// <copyright file="Game.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FarmOnVillage
{
    using System;
    using System.Linq;
    using Farm.Data;

    /// <summary>
    /// Class Game.
    /// </summary>
    public static class Game
    {
        /// <summary>
        /// Start game.
        /// </summary>
        /// <returns>Farm.</returns>
        internal static Farm StartGame()
        {
            Farm farm = null;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\t Would you\n\n" +
                                    "\t 1 - Create new Farm\n\n" +
                                    "\t or\n\n" +
                                    "\t 2 - Continue game\n");

            switch (Console.ReadLine())
            {
                case "1":
                    farm = DatabaseFarm.CreateFarm();
                    Console.Clear();
                    break;
                case "2":
                    farm = DatabaseFarm.ChooseFarm();
                    Console.Clear();
                    break;
                case "3":
                    DatabaseFarm.FillTableMarket();
                    break;
            }

            return farm;
        }

        /// <summary>
        /// Method Interface.
        /// </summary>
        public static void StartMenu()
        {
            Farm farm = StartGame();
            if (farm == null)
                return;

            bool game = true;
            byte manth = 1;

            while (game)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n\n\t 1 - Report of Farm\n" +
                                        "\t 2 - Purchases\n" +
                                        "\t 3 - Report of Raw Material\n" +
                                        "\t 4 - Report of Stock\n" +
                                        "\t 5 - Farm management\n" +
                                        "\t 6 - Money\n" +
                                        "\t 7 - Sales\n" +
                                        "\t Q - quit.\n");

                switch (Console.ReadLine())
                {
                    case "1":
                        FarmLogics.ReportFarm(farm);
                        Console.ReadKey();
                        break;
                    case "2":
                        FarmLogics.Purchases(farm);
                        break;
                    case "3":
                        RawMaterialLogics.ReportRawMaterial(farm.RawMaterialOnFarm);
                        Console.ReadKey();
                        break;
                    case "4":
                        StockLogics.ReporStock(farm.StockInCountry);
                        Console.ReadKey();
                        break;
                    case "5":
                        FarmManagement(farm);
                        break;
                    case "6":
                        Console.WriteLine($"\t You have {farm.Money}$");
                        Console.ReadKey();
                        break;
                    case "7":
                        FarmLogics.Sales(farm);
                        Console.ReadKey();
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

                        FarmLogics.SmenaSezona(farm);
                        FarmLogics.ChekSeason(farm, manth);
                        break;
                }
            }
        }

        /// <summary>
        /// Method Farm Management.
        /// </summary>
        /// <param name="farm"></param>
        public static void FarmManagement(Farm farm)
        {
            bool farmManag = true;
            while (farmManag)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n\n\t 1 - Add Animal in building\n" +
                                      "\t 2 - Plant seeds\n" +
                                      "\t 3 - Realty\n " +
                                      "\t b - back\n");

                switch (Console.ReadLine())
                {
                    case "1":
                        BuildingLogics.AddAnimalToBild(farm);
                        break;
                    case "2":
                        GardenBedLogics.AddPlantsToBed(farm);
                        break;
                    case "3":
                        Realty(farm);
                        break;
                    case "b":
                        farmManag = false;
                        break;
                    default:
                        break;
                }
            }
            
        }

        /// <summary>
        /// Method Realty.
        /// </summary>
        /// <param name="farm"></param>
        public static void Realty(Farm farm)
        {
            bool realty = true;
            while (realty)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n\n\t 1 - Buy land \n" +
                                      "\t 2 - Add garden bed\n" +
                                      "\t 3 - Add building\n" +
                                      "\t b - back\n");

                switch (Console.ReadLine())
                {
                    case "1":
                        FarmLogics.BuyLand(farm);
                        break;
                    case "2":
                        FarmLogics.AddBadOnFarm(farm);
                        break;
                    case "3":
                        FarmLogics.AddBildOnFarm(farm);
                        break;
                    case "b":
                        realty = false;
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
