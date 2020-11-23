// <copyright file="FarmContext.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FarmOnVillage
{
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Context.
    /// </summary>
    internal class FarmContext : DbContext
    {
        public DbSet<ProduktOfAnimal> ProduktsOfAnimal { get; set; }

        public DbSet<Animal> Animals { get; set; }

        public DbSet<Bilding> Bildings { get; set; }

        public DbSet<Plant> Plants { get; set; }

        public DbSet<GardenBed> GardenBeds { get; set; }

        public DbSet<Seed> Seeds { get; set; }

        public DbSet<Market> Markets { get; set; }

        public DbSet<RawMaterial> RawMaterials { get; set; }

        public DbSet<Farm> Farms { get; set; }

        public DbSet<Stock> Stocks { get; set; }

        /// <summary>
        /// Connect.
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQL_EXPRESS;Database=FarmDB;Trusted_Connection=True;");
        }
    }
}
