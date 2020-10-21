// <copyright file="Stock.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FarmOnVillage
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Class Stock.
    /// </summary>
    public class Stock
    {
        /// <summary>
        /// Gets or Sets VolumeStock.
        /// </summary>
        public int VolumeStock { get; set; }

        /// <summary>
        /// Gets or Sets Product.
        /// </summary>
        public Dictionary<string, int> Product { get; set; }

        /// <summary>
        /// Gets or Sets Fruit.
        /// </summary>
        public Dictionary<string, int> Fruit { get; set; }

        /// <summary>
        /// Method calculate used Volume in stock.
        /// </summary>
        /// <returns> Used area.</returns>
        private int UsedVolumeInStock()
        {
            int usedVolumeInStock = 0;
            foreach (var item in Product)
            {
                usedVolumeInStock += item.Value;
            }

            foreach (var item in Fruit)
            {
                usedVolumeInStock += item.Value;
            }

            return usedVolumeInStock;
        }

        /// <summary>
        /// Console write report of Stock.
        /// </summary>
        public void ReporStock()
        {
            Console.WriteLine($"Report of Stock Volume Stock {VolumeStock}Kg," +
                $" percentage of warehouse Stock: {UsedVolumeInStock() * 100 / VolumeStock}%");
        }
    }
}
