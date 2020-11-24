// <copyright file="Stock.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FarmOnVillage
{
    using System;
    using System.Collections.Generic;
    using Farm.Data;

    /// <summary>
    /// Class Stock.
    /// </summary>
    public static class StockLogics
    {
        /// <summary>
        /// Method calculate used Volume in stock.
        /// </summary>
        /// <returns> Used area.</returns>
        private static int UsedVolumeInStock(Stock stock)
        {
            int usedVolumeInStock = 0;
            foreach (var item in stock.ProduktsOfAnimal)
            {
                usedVolumeInStock += item.Mass;
            }

            foreach (var item in stock.Plants)
            {
                usedVolumeInStock += item.Harvest;
            }

            return usedVolumeInStock;
        }

        /// <summary>
        /// Console write report of Stock.
        /// </summary>
        public static void ReporStock(Stock stock)
        {
            Console.WriteLine($"Report of Stock Volume Stock {stock.VolumeStock}Kg," +
                $" percentage of warehouse Stock: {UsedVolumeInStock(stock) * 100 / stock.VolumeStock}%\n");
        }

        /// <summary>
        /// Method Add product.
        /// </summary>
        /// <param name="produktOfAnimal"></param>
        public static void AddProduct(Stock stock, ProduktOfAnimal produktOfAnimal)
        {
            stock.ProduktsOfAnimal.Add(new ProduktOfAnimal()
            {
                NameProduktOfAnimal = produktOfAnimal.NameProduktOfAnimal,
                Mass = produktOfAnimal.Mass,
                Price = produktOfAnimal.Price,
            });
        }

        /// <summary>
        /// Method add product on stock.
        /// </summary>
        /// <param name="plant"></param>
        public static void AddFruit(Stock stock, Plant plant)
        {
            stock.Plants.Add(plant);
        }
    }
}
