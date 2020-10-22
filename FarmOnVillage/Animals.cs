// <copyright file="Animals.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FarmOnVillage
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// class Animals.
    /// </summary>
    public class Animals
    {
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
        /// Initializes a new instance of the <see cref="Animals"/> class.
        /// </summary>
        public Animals()
        {
            IsMultyHarvest = true;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Animals"/> class.
        /// </summary>
        /// <param name="nameAnimal"></param>
        /// <param name="produktAnimal"></param>
        public Animals(string nameAnimal, ProduktOfAnimal produktAnimal)
        {
            NameAnimal = nameAnimal;
            ProduktAnimal = produktAnimal;
            IsMultyHarvest = true;
        }
    }
}
