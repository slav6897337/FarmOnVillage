// <copyright file="ProduktOfAnimal.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FarmOnVillage
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// class ProduktOfAnimal.
    /// </summary>
    public class ProduktOfAnimal
    {
        /// <summary>
        /// Gets or Sets NameProduktOfAnimal.
        /// </summary>
        public string NameProduktOfAnimal { get; set; }

        /// <summary>
        /// Gets or Sets Mass of product.
        /// </summary>
        public int Mass { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProduktOfAnimal"/> class.
        /// </summary>
        public ProduktOfAnimal()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProduktOfAnimal"/> class.
        /// </summary>
        /// <param name="nameProduct"></param>
        /// <param name="mass"></param>
        public ProduktOfAnimal(string nameProduct, int mass)
        {
            NameProduktOfAnimal = nameProduct;
            Mass = mass;
        }
    }
}
