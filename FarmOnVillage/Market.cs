// <copyright file="Market.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FarmOnVillage
{
    using System.Collections.Generic;

    /// <summary>
    /// Class Market.
    /// </summary>
    public class Market
    {
        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        public int MarketId { get; set; }

        /// <summary>
        /// Gets or Sets SeedsToBuy.
        /// </summary>
        public List<Seed> SeedsToBuy { get; set; }

        /// <summary>
        /// Gets or Sets AnimalsToBuy.
        /// </summary>
        public List<Animal> AnimalsToBuy { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Market"/> class.
        /// </summary>
        public Market()
        {
            SeedsToBuy = new List<Seed>();
            AnimalsToBuy = new List<Animal>();

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

            Animal cow = new Animal("Cow", milk, 150);
            Animal pig = new Animal("Pig", meat, 100);
            Animal sheep = new Animal("Sheep", wool, 80);
            Animal hen = new Animal("Hen", egg, 60);

            AnimalsToBuy.Add(cow);
            AnimalsToBuy.Add(pig);
            AnimalsToBuy.Add(sheep);
            AnimalsToBuy.Add(hen);
        }
    }
}
