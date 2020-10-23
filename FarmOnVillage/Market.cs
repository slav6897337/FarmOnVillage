// <copyright file="Market.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FarmOnVillage
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Class Market.
    /// </summary>
    public class Market
    {
        /// <summary>
        /// Gets or Sets SeedsToBuy.
        /// </summary>
        public List<Seed> SeedsToBuy { get; set; }

        /// <summary>
        /// Gets or Sets AnimalsToBuy.
        /// </summary>
        public List<Animals> AnimalsToBuy { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Market"/> class.
        /// </summary>
        public Market()
        {
            SeedsToBuy = new List<Seed>();
            AnimalsToBuy = new List<Animals>();

            Seed seedExzemp = new Seed("Apple", 5, 50);
            SeedsToBuy.Add(seedExzemp);
            seedExzemp = new Seed("Cucumber", 6, 60);
            SeedsToBuy.Add(seedExzemp);
            seedExzemp = new Seed("Tomato", 6, 70);
            SeedsToBuy.Add(seedExzemp);
            seedExzemp = new Seed("Strawberry", 5, 50);
            SeedsToBuy.Add(seedExzemp);
            seedExzemp = new Seed("Potatoes", 6, 40);
            SeedsToBuy.Add(seedExzemp);
            seedExzemp = new Seed("Overnight", 5, 70);
            SeedsToBuy.Add(seedExzemp);

            ProduktOfAnimal milk = new ProduktOfAnimal("Milk", 10);
            ProduktOfAnimal meat = new ProduktOfAnimal("Meat", 100);
            ProduktOfAnimal wool = new ProduktOfAnimal("Wool", 10);
            ProduktOfAnimal egg = new ProduktOfAnimal("Egg", 30);

            Animals cow = new Animals("Cow", milk, 150);
            Animals pig = new Animals("Pig", meat, 100);
            Animals sheep = new Animals("Sheep", wool, 80);
            Animals hen = new Animals("Hen", egg, 60);

            AnimalsToBuy.Add(cow);
            AnimalsToBuy.Add(pig);
            AnimalsToBuy.Add(sheep);
            AnimalsToBuy.Add(hen);
        }
    }
}
