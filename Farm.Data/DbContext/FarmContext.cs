namespace Farm.Data
{
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Context.
    /// </summary>
    public class FarmContext : DbContext
    {
        /// <summary>
        /// Gets or sets dbSet.
        /// </summary>
        public DbSet<ProduktOfAnimal> ProduktsOfAnimal { get; set; }

        /// <summary>
        /// Gets or sets dbSet.
        /// </summary>
        public DbSet<Animal> Animals { get; set; }

        /// <summary>
        /// Gets or sets dbSet.
        /// </summary>
        public DbSet<Building> Buildings { get; set; }

        /// <summary>
        /// Gets or sets dbSet.
        /// </summary>
        public DbSet<Plant> Plants { get; set; }

        /// <summary>
        /// Gets or sets dbSet.
        /// </summary>
        public DbSet<GardenBed> GardenBeds { get; set; }

        /// <summary>
        /// Gets or sets dbSet.
        /// </summary>
        public DbSet<Seed> Seeds { get; set; }

        /// <summary>
        /// Gets or sets dbSet.
        /// </summary>
        public DbSet<Market> Markets { get; set; }

        /// <summary>
        /// Gets or sets dbSet.
        /// </summary>
        public DbSet<RawMaterial> RawMaterials { get; set; }

        /// <summary>
        /// Gets or sets dbSet.
        /// </summary>
        public DbSet<Farm> Farms { get; set; }

        /// <summary>
        /// Gets or sets dbSet.
        /// </summary>
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
