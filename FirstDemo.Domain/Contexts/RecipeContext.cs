using FirstDemo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.Domain.Contexts
{
    public class RecipeContext : DbContext, IRecipeContext
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public RecipeContext(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(
                    _connectionString,
                    m => m.MigrationsAssembly(_migrationAssemblyName));
            }

            base.OnConfiguring(dbContextOptionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
            .Entity<Recipe>()
            .HasMany(p => p.Ingredients)
            .WithMany(p => p.Receipes)
            .UsingEntity(j => j.ToTable("ReceipeIngrediant"));

            base.OnModelCreating(modelBuilder);
        }
        
        public DbSet<Recipe> Receipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
    }
}
