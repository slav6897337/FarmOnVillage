namespace Farm.Data
{
    /// <summary>
    /// Class Plants.
    /// </summary>
    public class Plant
    {
        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        public int PlantId { get; set; }

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
        public bool IsMultyHarvest { get; set; } = true;

        /// <summary>
        /// Gets or sets Price.
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// Gets or sets Harvest.
        /// </summary>
        public int Harvest { get; set; }
    }
}
