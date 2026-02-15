using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RecipeWebApp.Models;

public partial class PlatefulContext : DbContext
{
    public DbSet<Recipe> Recipes { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }
    public DbSet<RecipeStep> RecipeSteps { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Recipe> DailyRecipe { get; set; }

    public PlatefulContext(DbContextOptions<PlatefulContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
