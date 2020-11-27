namespace Farm.Data
{
    using System.Collections.Generic;

    /// <summary>
    /// class GardenBed.
    /// </summary>
    public class GardenBed
    {
        /// <summary>
        /// Gets or sets PlantId.
        /// </summary>
        public int GardenBedId { get; set; }

        /// <summary>
        /// Gets or sets property Square.
        /// </summary>
        public int Square { get; set; }

        /// <summary>
        /// Gets or sets property Square.
        /// </summary>
        public List<Plant> PlantsBed { get; set; } = new List<Plant>();
    }
}
