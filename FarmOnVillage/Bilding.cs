// <copyright file="Bilding.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FarmOnVillage
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// class Building.
    /// </summary>
    public class Bilding
    {
        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        public int BildingId { get; set; }

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
        public List<Animal> AnimalsOnBild { get; set; } = new List<Animal>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Bilding"/> class.
        /// </summary>
        public Bilding()
        {
            AnimalsOnBild = new List<Animal>();
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
        public Bilding(string nameBuilding, int areaOfBuilding, int conteints)
        {
            AnimalsOnBild = new List<Animal>();
            NameBilding = nameBuilding;
            AriaOfBilding = conteints;
            ContentAnimals = conteints;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Bilding"/> class.
        /// </summary>
        /// <param name="nameBuilding"></param>
        /// <param name="areaOfBuilding"></param>
        /// <param name="conteints"></param>
        /// <param name="animal"></param>
        public Bilding(string nameBuilding, int areaOfBuilding, int conteints, Animal animal)
        {
            AnimalsOnBild = new List<Animal>();
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
            Console.Write($"This is the {NameBilding} square equals {AriaOfBilding} contains {ContentAnimals} animal: ");
            foreach (var animal in AnimalsOnBild)
            {
                Console.Write($"{animal.NameAnimal} ");
            }

            Console.WriteLine($"percentage of occupancy {AnimalsOnBild.Count * 100 / ContentAnimals}%\n");
        }

        /// <summary>
        ///  Method add product on stock.
        /// </summary>
        /// <param name="stock"></param>
        public void ProductonStock(Stock stock)
        {
            foreach (var item in AnimalsOnBild)
            {
                stock.AddProduct(item.ProduktAnimal);
                Console.WriteLine($"{item.NameAnimal} gave {item.ProduktAnimal.NameProduktOfAnimal} {1}kg");
            }
        }
    }
}
