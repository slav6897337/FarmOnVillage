// <copyright file="Animal.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FarmOnVillage
{
    /// <summary>
    /// class Animals.
    /// </summary>
    public class Animal
    {
        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        public int AnimalId { get; set; }

        /// <summary>
        /// Gets or sets NameAnimal.
        /// </summary>
        public string NameAnimal { get; set; }

        /// <summary>
        /// Gets or sets ProduktOfAnimal.
        /// </summary>
        public ProduktOfAnimal ProduktAnimal { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether IsMultyHarvest.
        /// </summary>
        public bool IsMultyHarvest { get; set; }

        /// <summary>
        /// Gets or sets TimeBetweenHarvests.
        /// </summary>
        public int TimeBetweenHarvests { get; set; }

        /// <summary>
        /// Gets or sets Price.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Animal"/> class.
        /// </summary>
        public Animal()
        {
            IsMultyHarvest = true;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Animal"/> class.
        /// </summary>
        /// <param name="nameAnimal"></param>
        /// <param name="produktAnimal"></param>
        public Animal(string nameAnimal, ProduktOfAnimal produktAnimal)
        {
            NameAnimal = nameAnimal;
            ProduktAnimal = produktAnimal;
            IsMultyHarvest = true;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Animal"/> class.
        /// </summary>
        /// <param name="nameAnimal"></param>
        /// <param name="produktAnimal"></param>
        /// <param name="praice"></param>
        public Animal(string nameAnimal, ProduktOfAnimal produktAnimal, decimal praice)
        {
            NameAnimal = nameAnimal;
            ProduktAnimal = produktAnimal;
            IsMultyHarvest = true;
            Price = praice;
        }
    }
}
