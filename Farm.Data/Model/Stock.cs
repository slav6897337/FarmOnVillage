namespace Farm.Data
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class Stock.
    /// </summary>
    public class Stock
    {
        const int volumeStok = 1000;
        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        public int StockId { get; set; }

        /// <summary>
        /// Gets or Sets VolumeStock.
        /// </summary>
        public int VolumeStock { get; set; } = volumeStok;

        /// <summary>
        /// Gets or Sets Product.
        /// </summary>
        public List<ProduktOfAnimal> ProduktsOfAnimal { get; set; } = new List<ProduktOfAnimal>();

        /// <summary>
        /// Gets or Sets Fruit.
        /// </summary>
        public List<Plant> Plants { get; set; } = new List<Plant>();

    }
}
