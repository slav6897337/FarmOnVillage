// <copyright file="Stock.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FarmOnVillage
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class Stock.
    /// </summary>
    public class Stock
    {
        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        public int StockId { get; set; }

        /// <summary>
        /// Gets or Sets VolumeStock.
        /// </summary>
        public int VolumeStock { get; set; }

        /// <summary>
        /// Gets or Sets Product.
        /// </summary>
        public List<ProduktOfAnimal> ProduktsOfAnimal { get; set; }

        /// <summary>
        /// Gets or Sets Fruit.
        /// </summary>
        public List<Plant> Plants { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Stock"/> class.
        /// </summary>
        public Stock()
        {
            ProduktsOfAnimal = new List<ProduktOfAnimal>();
            Plants = new List<Plant>();
            VolumeStock = 1000;
        }

        /// <summary>
        /// Method calculate used Volume in stock.
        /// </summary>
        /// <returns> Used area.</returns>
        private int UsedVolumeInStock()
        {
            int usedVolumeInStock = 0;
            foreach (var item in ProduktsOfAnimal)
            {
                usedVolumeInStock += item.Mass;
            }

            foreach (var item in Plants)
            {
                usedVolumeInStock += item.Harvest;
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
        /// <param name="produktOfAnimal"></param>
        public void AddProduct(ProduktOfAnimal produktOfAnimal)
        {
            ProduktsOfAnimal.Add(new ProduktOfAnimal()
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
        public void AddFruit(Plant plant)
        {
            Plants.Add(plant);
        }
    }
}
