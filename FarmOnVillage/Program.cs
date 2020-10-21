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

            GardenBed gardenBen1 = new GardenBed();
            gardenBen1.Square = 100;
            gardenBen1.PlantsBed = new List<Plants>();
            gardenBen1.PlantsBed.Add(cucumber);
            gardenBen1.PlantsBed.Add(tomato);
            gardenBen1.PlantsBed.Add(strawberry);
            gardenBen1.PlantsBed.Add(potatoes);

            GardenBed gardenBen2 = new GardenBed();
            gardenBen2.Square = 100;
            gardenBen2.PlantsBed = new List<Plants>();
            gardenBen2.PlantsBed.Add(cucumber);
            gardenBen2.PlantsBed.Add(cucumber);
            gardenBen2.PlantsBed.Add(strawberry);
            gardenBen2.PlantsBed.Add(potatoes);
            gardenBen2.PlantsBed.Add(tomato);

            GardenBed gardenBen3 = new GardenBed();
            gardenBen3.Square = 100;
            gardenBen3.PlantsBed = new List<Plants>();
            gardenBen3.PlantsBed.Add(strawberry);
            gardenBen3.PlantsBed.Add(strawberry);
            gardenBen3.PlantsBed.Add(strawberry);
            gardenBen3.PlantsBed.Add(strawberry);
            gardenBen3.PlantsBed.Add(strawberry);

            farmGrodno.GardenBedFarm = new List<GardenBed>();
            farmGrodno.GardenBedFarm.Add(gardenBen1);
            farmGrodno.GardenBedFarm.Add(gardenBen2);
            farmGrodno.GardenBedFarm.Add(gardenBen3);

            ProduktOfAnimal milk = new ProduktOfAnimal();
            milk.NameProduktOfAnimal = "Milk";
            milk.Mass = 10;

            ProduktOfAnimal meat = new ProduktOfAnimal();
            meat.NameProduktOfAnimal = "Meat";
            meat.Mass = 100;

            ProduktOfAnimal wool = new ProduktOfAnimal();
            wool.NameProduktOfAnimal = "Wool";
            wool.Mass = 10;

            ProduktOfAnimal egg = new ProduktOfAnimal();
            egg.NameProduktOfAnimal = "Egg";
            egg.Mass = 30;

            Animals kow = new Animals();
            kow.NameAnimal = "Kow";
            kow.ProduktAnimal = milk;

            Animals pig = new Animals();
            pig.NameAnimal = "Pig";
            pig.ProduktAnimal = meat;

            Animals sheep = new Animals();
            sheep.NameAnimal = "Sheep";
            sheep.ProduktAnimal = wool;

            Animals hen = new Animals();
            hen.NameAnimal = "Hen";
            hen.ProduktAnimal = egg;

            Bilding pigsty = new Bilding();
            pigsty.NameBilding = "Pigsty";
            pigsty.AriaOfBilding = 1000;
            pigsty.ContentAnimals = 100;
            pigsty.AnimalsOnBild = new List<Animals>();
            for (int i = 0; i < 100; i++)
            {
                pigsty.AnimalsOnBild.Add(pig);
            }

            Bilding barn = new Bilding();
            barn.NameBilding = "Barn";
            barn.AriaOfBilding = 1000;
            barn.ContentAnimals = 80;
            barn.AnimalsOnBild = new List<Animals>();
            for (int i = 0; i < 80; i++)
            {
                barn.AnimalsOnBild.Add(kow);
            }

            Bilding cote = new Bilding();
            cote.NameBilding = "Cote";
            cote.AriaOfBilding = 1000;
            cote.ContentAnimals = 100;
            cote.AnimalsOnBild = new List<Animals>();
            for (int i = 0; i < 100; i++)
            {
                cote.AnimalsOnBild.Add(sheep);
            }

            Bilding hennery = new Bilding();
            hennery.NameBilding = "Hennery";
            hennery.AriaOfBilding = 200;
            hennery.ContentAnimals = 100;
            hennery.AnimalsOnBild = new List<Animals>();
            for (int i = 0; i < 100; i++)
            {
                hennery.AnimalsOnBild.Add(hen);
            }

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
