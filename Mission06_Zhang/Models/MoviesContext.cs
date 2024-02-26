using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace Mission06_Zhang.Models
{
    public class MoviesContext : DbContext // from the app tpo the database
    {
        public MoviesContext(DbContextOptions<MoviesContext> options) : base(options) 
        { 
        }
        public DbSet<Movie> Movies {  get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
