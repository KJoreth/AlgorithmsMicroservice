namespace DataStructure.API.Data
{
    public class DataStructureContext : DbContext
    {
        public DataStructureContext(DbContextOptions<DataStructureContext> options)
            : base(options) { }

        public DbSet<Structure> DataStructures { get; set; }

    }
}
