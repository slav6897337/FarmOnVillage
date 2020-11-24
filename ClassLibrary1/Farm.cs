namespace Farm.Data
{
    using System.Collections.Generic;
    /// <summary>
    /// Class that contains Farm.
    /// </summary>
    public class Farm
    {
        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        public int FarmId { get; set; }

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
        public List<GardenBed> GardenBedFarm { get; set; } = new List<GardenBed>();

        /// <summary>
        /// Gets or sets property BildingFarm.
        /// </summary>
        public List<Building> BuildingFarm { get; set; } = new List<Building>();

        /// <summary>
        /// Gets or sets property Stock.
        /// </summary>
        public Stock StockInCountry { get; set; }

        /// <summary>
        /// Gets or sets property your money.
        /// </summary>
        public decimal Money { get; set; }

        /// <summary>
        /// Gets or sets property your MarketForFarm.
        /// </summary>
        public Market MarketForFarm { get; set; }

        /// <summary>
        /// Gets or sets RawMaterialOnFarm.
        /// </summary>
        public RawMaterial RawMaterialOnFarm { get; set; }
    }
}
