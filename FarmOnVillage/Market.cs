﻿// <copyright file="Market.cs" company="PlaceholderCompany">
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
        public List<Seed> SeedsToBuy { get; set; } = new List<Seed>();

        /// <summary>
        /// Gets or Sets AnimalsToBuy.
        /// </summary>
        public List<Animal> AnimalsToBuy { get; set; } = new List<Animal>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Market"/> class.
        /// </summary>
        public Market()
        {

        }
    }
}
