// <copyright file="Farm.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FarmOnVillage
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class that contains Farm.
    /// </summary>
    public class Farm
    {
        /// <summary>
        /// Gets or sets property NameFarm.
        /// </summary>
        public string NameFarm { get; set; }

        /// <summary>
        /// Gets or sets property Area.
        /// </summary>
        public int Area { get; set; }

        /// <summary>
        /// Gets or sets property GardenBed.
        /// </summary>
        public List<GardenBed> GardenBedFarm { get; set; }

        /// <summary>
        /// Gets or sets property BildingFarm.
        /// </summary>
        public List<Bilding> BildingFarm { get; set; }

        /// <summary>
        /// Console write report of Farm.
        /// </summary>
        public void ReportFarm()
        {
            Console.WriteLine($"Thesis farm {NameFarm}, area {Area}, {BildingFarm.Count} building and {GardenBedFarm.Count} Garden Beds");
        }

        /// <summary>
        /// Method add beds to the farm.
        /// </summary>
        public void AddGardenInFarm()
        {
            GardenBed
        }
    }
}
