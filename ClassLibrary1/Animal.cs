namespace Farm.Data
{
    using System.Collections.Generic;

    /// <summary>
    /// class Animals.
    /// </summary>
    public class Animal
    {
        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        public int AnimalId { get; set; }

        /// <summary>
        /// Gets or sets NameAnimal.
        /// </summary>
        public string NameAnimal { get; set; }

        /// <summary>
        /// Gets or sets ProduktOfAnimal.
        /// </summary>
        public ProduktOfAnimal ProduktAnimal { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether IsMultyHarvest.
        /// </summary>
        public bool IsMultyHarvest { get; set; } = true;

        /// <summary>
        /// Gets or sets TimeBetweenHarvests.
        /// </summary>
        public int TimeBetweenHarvests { get; set; }

        /// <summary>
        /// Gets or sets Price.
        /// </summary>
        public decimal Price { get; set; }
    }
}
