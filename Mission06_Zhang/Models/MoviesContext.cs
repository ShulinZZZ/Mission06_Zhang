﻿using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace Mission06_Zhang.Models
{
    public class MoviesContext : DbContext
    {
        public MoviesContext(DbContextOptions<MoviesContext> options) : base(options) 
        { 
        }
        public DbSet<Movie> movies {  get; set; }
        public DbSet<Category> categories { get;}
    }
}
