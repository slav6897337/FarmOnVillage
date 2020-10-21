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
            Console.ForegroundColor = ConsoleColor.DarkRed;
            byte manth = 0;
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
            var tomato1 = new Plants("tomato", 6, 9, 10);

            Plants strawberry = new Plants();
            strawberry.NamePlant = "Strawberry";
            strawberry.AriaOfSeat = 10;
            strawberry.SeasonSeat = 5;
            strawberry.SeasonGather = 7;
            Plants strawberry1 = new Plants("Strawberry", 5, 7, 10);

            Plants potatoes = new Plants();
            potatoes.NamePlant = "Potatoes";
            potatoes.AriaOfSeat = 10;
            potatoes.SeasonSeat = 5;
            potatoes.SeasonGather = 8;
            Plants potatoes1 = new Plants("Potatoes", 5, 8, 10);

            GardenBed gardenBen1 = new GardenBed();
            gardenBen1.Square = 100;
            gardenBen1.PlantsBed = new List<Plants>();
            gardenBen1.PlantsBed.Add(cucumber);
            var cucumber1 = new Plants("cucumber", 6, 9, 10);
            gardenBen1.PlantsBed.Add(cucumber1);

            GardenBed gardenBen2 = new GardenBed();
            gardenBen2.Square = 100;
            gardenBen2.PlantsBed = new List<Plants>();
            gardenBen2.PlantsBed.Add(strawberry);
            gardenBen2.PlantsBed.Add(strawberry1);

            GardenBed gardenBen3 = new GardenBed();
            gardenBen3.Square = 100;
            gardenBen3.PlantsBed = new List<Plants>();
            gardenBen3.PlantsBed.Add(potatoes);
            gardenBen3.PlantsBed.Add(potatoes1);
            gardenBen3.PlantsBed.Add(tomato);
            gardenBen3.PlantsBed.Add(tomato1);

            farmGrodno.GardenBedFarm = new List<GardenBed>();
            farmGrodno.GardenBedFarm.Add(gardenBen1);
            farmGrodno.GardenBedFarm.Add(gardenBen2);
            farmGrodno.GardenBedFarm.Add(gardenBen3);

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
            Animals pig1 = new Animals("Pig", meat);
            pigsty.AnimalsOnBild.Add(pig1);
            Animals pig2 = new Animals("Pig", meat);
            Animals pig3 = new Animals("Pig", meat);
            Animals pig4 = new Animals("Pig", meat);
            Animals pig5 = new Animals("Pig", meat);
            Animals pig6 = new Animals("Pig", meat);
            pigsty.AnimalsOnBild.Add(pig2);
            pigsty.AnimalsOnBild.Add(pig3);
            pigsty.AnimalsOnBild.Add(pig4);
            pigsty.AnimalsOnBild.Add(pig5);
            pigsty.AnimalsOnBild.Add(pig6);

            Bilding barn = new Bilding();
            barn.NameBilding = "Barn";
            barn.AriaOfBilding = 1000;
            barn.ContentAnimals = 80;
            barn.AnimalsOnBild = new List<Animals>();
            barn.AnimalsOnBild.Add(kow);

            Bilding cote = new Bilding();
            cote.NameBilding = "Cote";
            cote.AriaOfBilding = 1000;
            cote.ContentAnimals = 100;
            cote.AnimalsOnBild = new List<Animals>();
            cote.AnimalsOnBild.Add(sheep);


            Bilding hennery = new Bilding();
            hennery.NameBilding = "Hennery";
            hennery.AriaOfBilding = 200;
            hennery.ContentAnimals = 100;
            hennery.AnimalsOnBild = new List<Animals>();
            hennery.AnimalsOnBild.Add(hen);

            farmGrodno.BildingFarm = new List<Bilding>();
            farmGrodno.BildingFarm.Add(pigsty);
            farmGrodno.BildingFarm.Add(barn);
            farmGrodno.BildingFarm.Add(cote);
            farmGrodno.BildingFarm.Add(hennery);

            farmGrodno.ReportFarm();
            gardenBen1.ReportGardenBed();
            gardenBen2.ReportGardenBed();
            gardenBen3.ReportGardenBed();
            pigsty.ReportBildings();
            barn.ReportBildings();
            cote.ReportBildings();
            hennery.ReportBildings();

            Stock stok1 = new Stock();
            stok1.VolumeStock = 500;
            stok1.Fruit = new Dictionary<string, int>();
            stok1.Product = new Dictionary<string, int>();
            stok1.Product.Add(milk.NameProduktOfAnimal, 10);
            stok1.Product.Add(meat.NameProduktOfAnimal, 50);
            stok1.Product.Add(wool.NameProduktOfAnimal, 5);
            stok1.Product.Add(egg.NameProduktOfAnimal, 30);

            stok1.Fruit.Add(cucumber.NamePlant, 30);
            stok1.Fruit.Add(tomato.NamePlant, 30);
            stok1.Fruit.Add(strawberry.NamePlant, 20);
            stok1.Fruit.Add(potatoes.NamePlant, 50);

            bool game = true;

            while (game)
            {
                Console.WriteLine(" 1 - Report of Farm\n 2 - Report of Garden Bed\n 3 - Report of Buildings\n 4 - Report of Stock\n 5 - Farm management\n Q - quit.");

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
                        stok1.ReporStock();
                        break;
                    case "5":
                        Console.WriteLine(" 1 - Add new garden bed\n 2 - Add new plants on Garden Bed\n 3 - Add new Building\n 4 - Add Animal");

                        switch (Console.ReadLine())
                        {
                            case "1":
                                
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
                        break;
                }
            }
        }
    }
}
