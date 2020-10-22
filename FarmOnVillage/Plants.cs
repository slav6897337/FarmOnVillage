// <copyright file="Plants.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FarmOnVillage
{
    using System;

/// <summary>
/// Class Plants.
/// </summary>
    public class Plants
    {
        /// <summary>
        /// Gets or sets namePlant.
        /// </summary>
        public string NamePlant { get; set; }

        /// <summary>
        /// Gets or sets SeasonSeat.
        /// </summary>
        public int SeasonSeat { get; set; }

        /// <summary>
        /// Gets or sets SeasonGather.
        /// </summary>
        public int SeasonGather { get; set; }

        /// <summary>
        /// Gets or sets AriaOfSeat.
        /// </summary>
        public int AriaOfSeat { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether IsMultyHarvest.
        /// </summary>
        public bool IsMultyHarvest { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Plants"/> class.
        /// </summary>
        public Plants()
        {
            IsMultyHarvest = true;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Plants"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="seasonSeat"></param>
        /// <param name="seasonGathew"></param>
        /// <param name="areaOfSeat"></param>
        public Plants(string name, int seasonSeat, int seasonGathew, int areaOfSeat)
        {
            NamePlant = name;
            SeasonSeat = seasonSeat;
            SeasonGather = seasonGathew;
            AriaOfSeat = areaOfSeat;
            IsMultyHarvest = true;
        }
    }
}
