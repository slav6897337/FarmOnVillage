namespace Farm.Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Class Raw material.
    /// </summary>
    public class RawMaterial
    {
        /// <summary>
        /// Gets or sets RawMaterialId.
        /// </summary>
        public int RawMaterialId { get; set; }

        /// <summary>
        ///  Gets or sets AnimalsFree.
        /// </summary>
        public List<Animal> AnimalsFree { get; set; } = new List<Animal>();

        /// <summary>
        /// Gets or sets PlantsFree.
        /// </summary>
        public List<Plant> PlantsFree { get; set; } = new List<Plant>();

    }
}
