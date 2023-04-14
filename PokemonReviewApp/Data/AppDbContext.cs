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
        public DbSet<Category> Categories { set; get; }
        public DbSet<Country> Countries { set; get; }
        public DbSet<Owner> Owners { set; get; }
        public DbSet<Pokemon> Pokemons { set; get; }
        public DbSet<Reviewer> Reviewers { set; get; }
        public DbSet<Review> Reviews { set; get; }
        public DbSet<PokemonCategory> PokemonCategories { set; get; }
        public DbSet<PokemonOwner> PokemonOwners { set; get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PokemonCategory>()
                .HasKey(pc => new { pc.PokemonId, pc.CategoryId });

            modelBuilder.Entity<PokemonCategory>()
                .HasOne(pc => pc.Pokemon)
                .WithMany(p => p.PokemonCategories)
                .HasForeignKey(p => p.PokemonId);

            modelBuilder.Entity<PokemonCategory>()
              .HasOne(pc => pc.Category)
              .WithMany(p => p.PokemonCategories)
              .HasForeignKey(c => c.CategoryId);

            modelBuilder.Entity<PokemonOwner>()
    .HasKey(po => new { po.PokemonId, po.OwnerId });

            modelBuilder.Entity<PokemonOwner>()
                .HasOne(pc => pc.Pokemon)
                .WithMany(po => po.PokemonOwners)
                .HasForeignKey(p => p.PokemonId);

            modelBuilder.Entity<PokemonOwner>()
              .HasOne(pc => pc.Owner)
              .WithMany(p => p.PokemonOwners)
              .HasForeignKey(c => c.OwnerId);


        }

    }
}
