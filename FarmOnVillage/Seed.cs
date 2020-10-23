// <copyright file="Seed.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FarmOnVillage
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Class seed.
    /// </summary>
    public class Seed
    {
        /// <summary>
        /// Gets or sets PlantsSeed.
        /// </summary>
        public string PlantsSeed { get; set; }

        /// <summary>
        /// Gets or sets SeasonSeat.
        /// </summary>
        public int SeasonSeat { get; set; }

        /// <summary>
        /// Gets or sets Price.
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Seed"/> class.
        /// </summary>
        public Seed()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Seed"/> class.
        /// </summary>
        /// <param name="plantsSeed"></param>
        /// <param name="seasonSeat"></param>
        /// <param name="price"></param>
        public Seed(string plantsSeed, int seasonSeat, int price)
        {
            PlantsSeed = plantsSeed;
            SeasonSeat = seasonSeat;
            Price = price;
        }
    }
}
