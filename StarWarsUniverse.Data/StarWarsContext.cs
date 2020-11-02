using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using StarWarsUniverse.Data.Repositories.Api;
using StarWarsUniverse.Domain;

namespace StarWarsUniverse.Data
{
    public class StarWarsContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public StarWarsContext() { }

        public StarWarsContext(DbContextOptions<StarWarsContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server = (localdb)\\mssqllocaldb; Database = StarWarsDB; Trusted_Connection = True; ");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasKey(m => m.Uri);
            IList<Movie> remoteMovies = new MovieApiRepository().GetAllMovies();
            modelBuilder.Entity<Movie>().HasData(remoteMovies.ToArray());
        }
    }
}
