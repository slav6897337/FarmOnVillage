// <copyright file="Bilding.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FarmOnVillage
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// class Building.
    /// </summary>
    public class Bilding
    {
        /// <summary>
        /// Gets or Sets NameBilding.
        /// </summary>
        public string NameBilding { get; set; }

        /// <summary>
        /// Gets or Sets AriaOfBilding.
        /// </summary>
        public int AriaOfBilding { get; set; }

        /// <summary>
        /// Gets or Sets ContentAnimals.
        /// </summary>
        public int ContentAnimals { get; set; }

        /// <summary>
        /// Gets or Sets Animals.
        /// </summary>
        public List<Animals> AnimalsOnBild { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Bilding"/> class.
        /// </summary>
        public Bilding()
        {
            AnimalsOnBild = new List<Animals>();
            AriaOfBilding = 100;
            ContentAnimals = 20;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Bilding"/> class.
        /// </summary>
        /// <param name="nameBuilding"></param>
        /// <param name="areaOfBuilding"></param>
        /// <param name="conteints"></param>
        /// <param name="animal"></param>
        public Bilding(string nameBuilding, int areaOfBuilding, int conteints, Animals animal)
        {
            AnimalsOnBild = new List<Animals>();
            NameBilding = nameBuilding;
            AriaOfBilding = conteints;
            ContentAnimals = conteints;
            AnimalsOnBild.Add(animal);
        }

        /// <summary>
        /// Console write report of garden Bed.
        /// </summary>
        public void ReportBildings()
        {
            Console.WriteLine($"This is the {NameBilding} square equals {AriaOfBilding} contains {ContentAnimals} animal {AnimalsOnBild[0].NameAnimal} percentage of occupancy {AnimalsOnBild.Count * 100 / ContentAnimals}%\n");
        }

        /// <summary>
        /// This Method add animals to build.
        /// </summary>
        /// <param name="val"></param>
        public void AddAnimalToTheBild()
        {
            Console.WriteLine("Haw many Animals do you want to add");
            int count;
            while (!int.TryParse(Console.ReadLine(), out count))
            {
                Console.WriteLine("Please enter correctly data");
            }

            if (AnimalsOnBild.Count + count < ContentAnimals)
            {
                string name = AnimalsOnBild[0].NameAnimal;
                ProduktOfAnimal product = AnimalsOnBild[0].ProduktAnimal;

                for (int i = 0; i < count; i++)
                {
                    var animal = new Animals(name, product);
                    AnimalsOnBild.Add(animal);
                }

                Console.WriteLine("Mew animals add");
            }
            else
            {
                Console.WriteLine("Sorry Square is busy");
            }
        }

        /// <summary>
        ///  Method add product on stock.
        /// </summary>
        /// <param name="stock"></param>
        public void ProductonStock(Stock stock)
        {
            foreach (var item in AnimalsOnBild)
            {
                stock.AddProduct(item.NameAnimal);
                Console.WriteLine($"{item.NameAnimal} gave {item.ProduktAnimal.NameProduktOfAnimal}");
            }
        }
    }
}
