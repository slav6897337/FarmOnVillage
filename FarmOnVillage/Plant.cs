// <copyright file="Plant.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FarmOnVillage
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
        public bool IsMultyHarvest { get; set; }

        /// <summary>
        /// Gets or sets Price.
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// Gets or sets Harvest.
        /// </summary>
        public int Harvest { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Plant"/> class.
        /// </summary>
        public Plant()
        {
            IsMultyHarvest = true;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Plant"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="seasonSeat"></param>
        /// <param name="seasonGathew"></param>
        /// <param name="areaOfSeat"></param>
        public Plant(string name, int seasonSeat, int seasonGathew, int areaOfSeat)
        {
            NamePlant = name;
            SeasonSeat = seasonSeat;
            SeasonGather = seasonGathew;
            AriaOfSeat = areaOfSeat;
            IsMultyHarvest = true;
            Harvest = 10;
        }
    }
}
