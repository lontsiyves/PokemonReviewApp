using Microsoft.EntityFrameworkCore;
using PokemonReviewApp.Models;
using System.Collections.Generic;

namespace PokemonReviewApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Country> Countries { set; get; }
    }
}
