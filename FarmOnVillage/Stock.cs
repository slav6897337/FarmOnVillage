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
        /// Initializes a new instance of the <see cref="Stock"/> class.
        /// </summary>
        public Stock()
        {
            Product = new Dictionary<string, int>();
            Fruit = new Dictionary<string, int>();
            VolumeStock = 1000;
        }

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
            Console.WriteLine($"Report of Stock Volume Stock {VolumeStock}Kg, percentage of warehouse Stock: {UsedVolumeInStock() * 100 / VolumeStock}%\n");
        }

        /// <summary>
        /// Method Add product.
        /// </summary>
        /// <param name="key1"></param>
        public void AddProduct(string key1)
        {
            foreach (var prod in Product)
            {
                if (prod.Key == key1)
                {
                    int temp = prod.Value + 1;
                    Product.Remove(prod.Key);
                    Product.Add(key1, temp);
                    return;
                }
            }

            Product.Add(key1, 1);
        }

        /// <summary>
        /// Method add product on stock.
        /// </summary>
        /// <param name="key1"></param>
        public void AddFruit(string key1)
        {
            foreach (var fruit in Fruit)
            {
                if (fruit.Key == key1)
                {
                    int temp = fruit.Value + 1;
                    Product.Remove(fruit.Key);
                    Product.Add(key1, temp);
                    return;
                }
            }

            Fruit.Add(key1, 1);
        }
    }
}
