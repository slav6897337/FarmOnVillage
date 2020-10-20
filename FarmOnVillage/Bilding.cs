// <copyright file="Bilding.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FarmOnVillage
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// class Bilding.
    /// </summary>
    public class Bilding
    {
        /// <summary>
        /// Gets or Sets NameBilding.
        /// </summary>
        public string NameBilding { get; set; }

        /// <summary>
        /// Gets or Sets AriaOfBilding.
        /// </summary>
        public int AriaOfBilding { get; set; }

        /// <summary>
        /// Gets or Sets ContentAnimals.
        /// </summary>
        public int ContentAnimals { get; set; }

        /// <summary>
        /// Gets or Sets Animals.
        /// </summary>
        public List<Animals> AnimalsOnBild { get; set; }

        /// <summary>
        /// Console write report of garden Bed.
        /// </summary>
        public void ReportBildings()
        {
            Console.WriteLine($"Thesis {NameBilding} square equals {AriaOfBilding} " +
                $"contains {ContentAnimals} animal {AnimalsOnBild[0].NameAnimal}" +
                $"percentage of occupancy {AnimalsOnBild.Count * 100 / ContentAnimals}%"); 
        }
    }
}
