namespace Farm.Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Class Market.
    /// </summary>
    public class Market
    {
        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        public int MarketId { get; set; }

        /// <summary>
        /// Gets or Sets SeedsToBuy.
        /// </summary>
        public List<Seed> SeedsToBuy { get; set; } = new List<Seed>();

        /// <summary>
        /// Gets or Sets AnimalsToBuy.
        /// </summary>
        public List<Animal> AnimalsToBuy { get; set; } = new List<Animal>();

    }
}
