using EFExample.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;

namespace EFExample;

public class AppDbContext : DbContext
{
    static string CSHome = "Host=localhost;Username=postgres;Password=admin;Database=Learn_MaximaSchool";
    static string CSWork = "Host=localhost;Username=postgres;Password=admin;Database=postgres";
    private static readonly string ConnectionString = CSWork;

    /*public AppDbContext()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }*/

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(ConnectionString);

#if DEBUG
        optionsBuilder.EnableSensitiveDataLogging();
#endif

        optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasKey(x => x.Id);
        modelBuilder.Entity<User>().HasOne(x => x.School)
            .WithMany(c => c.users)
            .OnDelete(DeleteBehavior.Cascade);
            
        
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<User> Users { get; set; }
    public DbSet<School> Schools { get; set; }
}