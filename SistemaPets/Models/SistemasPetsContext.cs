using Microsoft.EntityFrameworkCore;

namespace SistemaPets.Models
{
    public class SistemasPetsContext : DbContext
    {
        public SistemasPetsContext( DbContextOptions<SistemasPetsContext> options) : base(options)
        {
        }

        public DbSet<Tutor> Tutor {get; set;}

        public DbSet<Pet> Pet {get; set;}
    }
}