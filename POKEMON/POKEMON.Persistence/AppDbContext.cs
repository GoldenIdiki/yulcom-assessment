using Microsoft.EntityFrameworkCore;
using POKEMON.Domain.Entities;

namespace POKEMON.Persistence
{
    public class AppDbContext : DbContext
    {
        private readonly DbContextOptions<AppDbContext> _options;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            _options = options;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Pokemon>().HasKey(x => x.Id);
            builder.Entity<Pokemon>().HasIndex(x => x.Name);
            base.OnModelCreating(builder);
        }

        public DbSet<Pokemon> Pokemons { get; set; }
    }
}