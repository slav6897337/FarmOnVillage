namespace Farm.Data
{
    using System.Collections.Generic;

    /// <summary>
    /// class Building.
    /// </summary>
    public class Building
    {
        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        public int BuildingId { get; set; }

        /// <summary>
        /// Gets or Sets NameBilding.
        /// </summary>
        public string NameBuilding { get; set; }

        /// <summary>
        /// Gets or Sets AriaOfBilding.
        /// </summary>
        public int AriaOfBuilding { get; set; }

        /// <summary>
        /// Gets or Sets ContentAnimals.
        /// </summary>
        public int ContentAnimals { get; set; }

        /// <summary>
        /// Gets or Sets Animals.
        /// </summary>
        public List<Animal> AnimalsOnBild { get; set; } = new List<Animal>();
    }
}
