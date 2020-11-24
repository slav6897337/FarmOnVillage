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
        public int BildingId { get; set; }

        /// <summary>
        /// Gets or Sets NameBilding.
        /// </summary>
        public string NameBilding { get; set; }

        /// <summary>
        /// Gets or Sets AriaOfBilding.
        /// </summary>
        public int AriaOfBilding { get; set; }

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
