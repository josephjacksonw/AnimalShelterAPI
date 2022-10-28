using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
    public class AnimalShelterContext : DbContext
    {
        public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Animal>()
              .HasData(
                  new Animal { AnimalId = 1, Name = "Max", Species = "Cat", Age = 1 },
                  new Animal { AnimalId = 2, Name = "Laura", Species = "Dog", Age = 8 },
                  new Animal { AnimalId = 3, Name = "Marley", Species = "Dog", Age = 6 },
                  new Animal { AnimalId = 4, Name = "Cheese", Species = "Cat", Age = 5 },
                  new Animal { AnimalId = 5, Name = "Grouch", Species = "Dog", Age = 12 }
              );
        }
        public DbSet<Animal> Animals { get; set; }
    }
}