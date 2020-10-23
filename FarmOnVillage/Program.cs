// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FarmOnVillage
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class Program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// the first met.
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            Game.StartGame();

            #region coment
            /* Console.ForegroundColor = ConsoleColor.DarkRed;
             byte manth = 1;
             Farm farmGrodno = new Farm();
             farmGrodno.NameFarm = "Grodno Farm";
             farmGrodno.Area = 10000;

             Plants cucumber = new Plants();
             cucumber.NamePlant = "Cucumber";
             cucumber.AriaOfSeat = 10;
             cucumber.SeasonSeat = 6;
             cucumber.SeasonGather = 9;

             Plants tomato = new Plants();
             tomato.NamePlant = "Tomato";
             tomato.AriaOfSeat = 10;
             tomato.SeasonSeat = 6;
             tomato.SeasonGather = 9;

             Plants strawberry = new Plants();
             strawberry.NamePlant = "Strawberry";
             strawberry.AriaOfSeat = 10;
             strawberry.SeasonSeat = 5;
             strawberry.SeasonGather = 7;

             Plants potatoes = new Plants();
             potatoes.NamePlant = "Potatoes";
             potatoes.AriaOfSeat = 10;
             potatoes.SeasonSeat = 5;
             potatoes.SeasonGather = 8;

             GardenBed gardenBen = new GardenBed();
             gardenBen.Square = 100;
             gardenBen.PlantsBed.Add(cucumber);
             cucumber = new Plants("cucumber", 6, 9, 10);
             gardenBen.PlantsBed.Add(cucumber);
             cucumber = new Plants("cucumber", 6, 9, 10);
             gardenBen.PlantsBed.Add(cucumber);
             cucumber = new Plants("cucumber", 6, 9, 5);
             gardenBen.PlantsBed.Add(cucumber);
             gardenBen.PlantsBed.Add(strawberry);
             strawberry = new Plants("Strawberry", 5, 7, 3);
             gardenBen.PlantsBed.Add(strawberry);
             gardenBen.PlantsBed.Add(tomato);
             tomato = new Plants("tomato", 6, 9, 10);
             gardenBen.PlantsBed.Add(tomato);
             gardenBen.PlantsBed.Add(potatoes);
             potatoes = new Plants("Potatoes", 5, 8, 10);
             gardenBen.PlantsBed.Add(potatoes);

             farmGrodno.GardenBedFarm = new List<GardenBed>();
             farmGrodno.GardenBedFarm.Add(gardenBen);
             gardenBen = new GardenBed();
             farmGrodno.GardenBedFarm.Add(gardenBen);

             ProduktOfAnimal milk = new ProduktOfAnimal("Milk", 10);
             ProduktOfAnimal meat = new ProduktOfAnimal("Meat", 100);
             ProduktOfAnimal wool = new ProduktOfAnimal("Wool", 10);
             ProduktOfAnimal egg = new ProduktOfAnimal("Egg", 30);

             Animals kow = new Animals("Kow", milk);
             Animals pig = new Animals("Pig", meat);
             Animals sheep = new Animals("Sheep", wool);
             Animals hen = new Animals("Hen", egg);

             Bilding pigsty = new Bilding();
             pigsty.NameBilding = "Pigsty";
             pigsty.AriaOfBilding = 1000;
             pigsty.ContentAnimals = 100;
             pigsty.AnimalsOnBild = new List<Animals>();
             pigsty.AnimalsOnBild.Add(pig);
             for (int i = 0; i < 70; i++)
             {
                 pig = new Animals("Pig", meat);
                 pigsty.AnimalsOnBild.Add(pig);
             }

             Bilding barn = new Bilding();
             barn.NameBilding = "Barn";
             barn.AriaOfBilding = 1000;
             barn.ContentAnimals = 80;
             barn.AnimalsOnBild = new List<Animals>();
             barn.AnimalsOnBild.Add(kow);
             for (int i = 0; i < 60; i++)
             {
                 kow = new Animals("Kow", milk);
                 barn.AnimalsOnBild.Add(kow);
             }

             Bilding cote = new Bilding();
             cote.NameBilding = "Cote";
             cote.AriaOfBilding = 1000;
             cote.ContentAnimals = 100;
             cote.AnimalsOnBild = new List<Animals>();
             cote.AnimalsOnBild.Add(sheep);
             for (int i = 0; i < 60; i++)
             {
                 sheep = new Animals("Sheep", wool);
                 cote.AnimalsOnBild.Add(sheep);
             }

             Bilding hennery = new Bilding();
             hennery.NameBilding = "Hennery";
             hennery.AriaOfBilding = 200;
             hennery.ContentAnimals = 100;
             hennery.AnimalsOnBild = new List<Animals>();
             hennery.AnimalsOnBild.Add(hen);
             for (int i = 0; i < 60; i++)
             {
                 hen = new Animals("Hen", egg);
                 hennery.AnimalsOnBild.Add(hen);
             }

             farmGrodno.BildingFarm = new List<Bilding>();
             farmGrodno.BildingFarm.Add(pigsty);
             farmGrodno.BildingFarm.Add(barn);
             farmGrodno.BildingFarm.Add(cote);
             farmGrodno.BildingFarm.Add(hennery);

             farmGrodno.ReportFarm();

             Stock stock = new Stock();
             stock.VolumeStock = 5000;
             stock.Fruit = new Dictionary<string, int>();
             stock.Product = new Dictionary<string, int>();
             stock.Product.Add(milk.NameProduktOfAnimal, 10);
             stock.Product.Add(meat.NameProduktOfAnimal, 50);
             stock.Product.Add(wool.NameProduktOfAnimal, 5);
             stock.Product.Add(egg.NameProduktOfAnimal, 30);
             stock.Fruit.Add(cucumber.NamePlant, 30);
             stock.Fruit.Add(tomato.NamePlant, 30);
             stock.Fruit.Add(strawberry.NamePlant, 20);
             stock.Fruit.Add(potatoes.NamePlant, 50);
             farmGrodno.StockInCountry = stock;

             bool game = true;

             while (game)
             {
                 Console.WriteLine(" 1 - Report of Farm\n 2 - Report of Garden Bed\n 3 - Report of Raw Material\n 4 - Report of Stock\n 5 - Farm management\n Q - quit.");

                 switch (Console.ReadLine())
                 {
                     case "1":
                         farmGrodno.ReportFarm();
                         break;
                     case "2":
                         foreach (var item in farmGrodno.GardenBedFarm)
                         {
                             item.ReportGardenBed();
                         }

                         break;
                     case "3":
                         foreach (var item in farmGrodno.BildingFarm)
                         {
                             item.ReportBildings();
                         }

                         break;
                     case "4":
                         stock.ReporStock();
                         break;
                     case "5":
                         Console.WriteLine(" 1 - Add Animal in building\n 2 - plant seeds\n 3 - realty");

                         switch (Console.ReadLine())
                         {
                             case "1":
                                 farmGrodno.AddBadOnFarm();
                                 break;
                             case "2":
                                 farmGrodno.AddPlantsToBed();
                                 break;
                             case "3":
                                 farmGrodno.AddBildOnFarm();
                                 break;
                             case "4":
                                 farmGrodno.AddAnimalToBild();
                                 break;
                             default:
                                 break;
                         }

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

                         farmGrodno.SmenaSezona(stock);
                         farmGrodno.ChekSeason(manth);
                         break;
                 }
             }*/
            #endregion
        }
    }
}
