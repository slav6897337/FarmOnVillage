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
        /// This Method calculate used area on farm.
        /// </summary>
        /// <returns>usedAreaOnFarm.</returns>
        private int UsedAreaOnFarm()
        {
            int usedAreaOnFarm = 0;
            foreach (var item in GardenBedFarm)
            {
                usedAreaOnFarm += item.Square;
            }

            foreach (var item in BildingFarm)
            {
                usedAreaOnFarm += item.AriaOfBilding;
            }

            return usedAreaOnFarm;
        }

        /// <summary>
        /// This Method add bild on farm.
        /// </summary>
        /// <param name="val"></param>
        public void AddBildOnFarm(Bilding val)
        {
            if (UsedAreaOnFarm() + val.AriaOfBilding < Area)
            {
                BildingFarm.Add(val);
            }
            else
            {
                Console.WriteLine("Sorry Area busy.");
            }
        }

        /// <summary>
        /// This Method add bad on farm.
        /// </summary>
        /// <param name="val"></param>
        public void AddBadOnFarm(GardenBed val)
        {
            if (UsedAreaOnFarm() + val.Square < Area)
            {
                GardenBedFarm.Add(val);
            }
            else
            {
                Console.WriteLine("Sorry Area busy.");
            }
        }
    }
}
