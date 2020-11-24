// <copyright file="Game.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FarmOnVillage
{
    using System;
    using System.Linq;

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

            Console.WriteLine("Would you 1-Create new Farm or 2-Continue game\n");

            switch (Console.ReadLine())
            {
                case "1":
                    farm = DatabaseFarm.CreateFarm();
                    break;
                case "2":
                    farm = DatabaseFarm.ChooseFarm();
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
                Console.WriteLine(" 1 - Report of Farm\n 2 - Purchases\n 3 - Report of Raw Material\n 4 - Report of Stock\n 5 - Farm management\n 6 - Money\n 7 - Sales\n Q - quit.\n");

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
                        farm.StockInCountry.ReporStock();
                        break;
                    case "5":
                        FarmManagement(farm);
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

                        farm.SmenaSezona();
                        farm.ChekSeason(manth);
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
                Console.WriteLine(" 1 - Add Animal in building\n 2 - Plant seeds\n 3 - Realty\n b - back\n");

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
                Console.WriteLine(" 1 - Buy land \n 2 - Add garden bed\n 3 - Add building\n b - back\n");

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
